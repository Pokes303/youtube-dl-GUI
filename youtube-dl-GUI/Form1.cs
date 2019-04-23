using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
namespace youtube_dl_GUI
{
    public partial class Form1 : Form
    {
        public string Version = "2.0";
        
        private static Color Good = Color.FromArgb(192, 255, 192);
        private static Color Bad = Color.FromArgb(255, 192, 192);

        private string OutputPath = Directory.GetCurrentDirectory() + "\\Downloaded videos\\";

        public readonly bool SaveToLog = !File.Exists(Directory.GetCurrentDirectory() + "\\nologs");
        public string LogsPath = Directory.GetCurrentDirectory() + "\\logs\\";
        StreamWriter LogSw;
        public string CurrentLog = null;
        public string NoLogsPath = Directory.GetCurrentDirectory() + "\\nologs";

        private bool DownloadingVideo = false;
        private bool DownloadingPlaylist = false;

        private enum PageTypes
        {
            Playlist = 0, Channel, Unknown
        }

        public Form1()
        {
            InitializeComponent();

            if (!Directory.Exists(OutputPath))
                Directory.CreateDirectory(OutputPath);

            SaveTextBox.Text = OutputPath;
            if (SaveToLog)
            {
                if (!Directory.Exists(LogsPath))
                    Directory.CreateDirectory(LogsPath);
                CurrentLog = LogsPath + "log" + DateTime.Now.ToFileTime() + ".txt";
            }

            Log("#### youtube-dl GUI log ####");
            Log("\nApplication version: " + Version);
            Log("\nStarted at: " + DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + " - " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "\n");

            CheckLibs(true);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Log("\n\n## End ##");
            if (SaveToLog)
                LogSw.Close();

            if (DownloadingVideo)
                VideoProcess.Kill();
            else if (DownloadingPlaylist)
                PlaylistProcess.Kill();

            /*if (VideoProcess.Id != 0 && !VideoProcess.HasExited)
                VideoProcess.Kill();
            else if (PlaylistProcess.Id != 0 && !PlaylistProcess.HasExited)
                PlaylistProcess.Kill();*/
        }

        public void Log(string text)
        {
            if (!SaveToLog)
                return;
            LogSw = new StreamWriter(CurrentLog);
            LogSw.Write(text.Replace("\n", "\r\n"));
            LogSw.Close();
        }

        public bool CheckLibs(bool CloseIfCancel)
        {
            Log("\nChecking libs...");
            while (!File.Exists(Directory.GetCurrentDirectory() + "\\youtube-dl.exe"))
            {
                Log("\nyoutube-dl library not found. Trying again...");
                DialogResult dr = MessageBox.Show("No se pudo encontrar el archvo youtube-dl.exe\n\nDescargue el programa de nuevo desde https://github.com/Pokes303/youtube-dl-GUI e inténtelo de nuevo", "Archivo youtube-dl.exe no encontrado", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (dr == DialogResult.Cancel)
                {
                    if (CloseIfCancel)
                        Application.Exit();
                    return false;
                }
            }
            Log("\nyoutube-dl library found!");
            while (!File.Exists(Directory.GetCurrentDirectory() + "\\ffmpeg.exe"))
            {
                DialogResult dr = MessageBox.Show("No se pudo encontrar el archvo ffmpeg.exe\n\nDescargue el programa de nuevo desde https://github.com/Pokes303/youtube-dl-GUI e inténtelo de nuevo", "Archivo ffmpeg.exe no encontrado", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (dr == DialogResult.Cancel)
                {
                    if (CloseIfCancel)
                        Application.Exit();
                    return false;
                }
            }
            Log("\nffmpeg library found!");
            return true;
        }

        private void abrirDirectorioDelProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", Directory.GetCurrentDirectory());
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm hf = new HelpForm(this);
            hf.f1 = this;
            hf.ShowDialog();
        }

        private void ImportTXT_Click(object sender, EventArgs e)
        {
            if (ImportTXTOpenFileDialog.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                Log("\nImporting txt from: " + ImportTXTOpenFileDialog.FileName);
                VideosTextBox.Text = "";
                string[] TempTexts = File.ReadAllLines(ImportTXTOpenFileDialog.FileName);
                for (int i = 0; i < TempTexts.Length; i++)
                {
                    VideosTextBox.Text += TempTexts[i];
                    if (i < TempTexts.Length - 1)
                        VideosTextBox.Text += "\r\n";
                }
            }
            catch (IOException ioe)
            {
                Log("\nError during import txt: " + ioe.Message);
                MessageBox.Show("Error:\n\n" + ioe.ToString(), "Error importando vídeos de txt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor.Current = Cursors.Default;
        }

        private void ExportTXT_Click(object sender, EventArgs e)
        {
            if (ExportTXTSaveFileDialog.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                Log("\nEmporting txt to: " + ExportTXTSaveFileDialog.FileName);
                StreamWriter exportsw = new StreamWriter(ExportTXTSaveFileDialog.FileName);
                for (int i = 0; i < VideosTextBox.Lines.Length; i++)
                {
                    exportsw.Write(VideosTextBox.Lines[i]);
                    if (i < VideosTextBox.Lines.Length - 1)
                        exportsw.Write("\r\n");
                }
                exportsw.Close();
            }
            catch (IOException ioe)
            {
                Log("\nError during export txt: " + ioe.Message);
                MessageBox.Show("Error:\n\n" + ioe.ToString(), "Error exportando vídeos a txt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor.Current = Cursors.Default;
        }

        private void SaveTextBox_TextChanged(object sender, EventArgs e)
        {
            bool Valid = Directory.Exists(SaveTextBox.Text);
            SaveTextBox.BackColor = (Valid) ? Good : Bad;
            DownloadVideos.Enabled = Valid;
            DownloadPlaylist.Enabled = Valid;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (SaveFolderBrowserDialog.ShowDialog() == DialogResult.OK)
                SaveTextBox.Text = SaveFolderBrowserDialog.SelectedPath;
        }

        private void InitializeProcess(Process TempProcess)
        {
            Log("\nInitializing download process...");
            TempProcess.StartInfo.UseShellExecute = false;
            TempProcess.StartInfo.CreateNoWindow = true;
            TempProcess.StartInfo.RedirectStandardOutput = true;
            TempProcess.StartInfo.FileName = "youtube-dl.exe";
            TempProcess.StartInfo.WorkingDirectory = SaveTextBox.Text + (SaveTextBox.Text.EndsWith("\\") ? "" : "\\");
            Log("\nDownload process initialized!");
            Log("\n\nConvert videos to .mp3: " + MP3CheckBox.Checked);
            Log("\n\nAdd metadata: " + MetadataCheckBox.Checked);
        }

        private void DownloadVideos_Click(object sender, EventArgs e)
        {
            if (!CheckLibs(false))
                return;

            DownloadVideos.Enabled = false;
            DownloadVideos.Text = "Descargando vídeo(s)...";
            Cursor.Current = Cursors.WaitCursor;

            string[] Videos = VideosTextBox.Text.Split('\n');

            Log("\n\nDownloading " + Videos.Length + " videos from YouTube");

            DownloadProgressBar.Maximum = Videos.Length * 2;
            ProgressText.Text = "1/" + Videos.Length;

            if (!Directory.Exists(OutputPath))
                Directory.CreateDirectory(OutputPath);

            int DownloadedVideos = 0;
            string Info = "";
            bool OpenDirAtEnd = OpenAtEndCheckBox.Checked;

            try
            {
                InitializeProcess(VideoProcess);

                DownloadingVideo = true;

                for (int i = 0; i < Videos.Length; i++)
                {
                    Log("\nDownloading video " + i + "/" + Videos.Length + "...");
                    Info += (i + 1) + "/" + Videos.Length + ": ";

                    VideoProcess.StartInfo.Arguments = Videos[i] + " --get-title";
                    VideoProcess.Start();
                    VideoProcess.WaitForExit();

                    StreamReader sr = VideoProcess.StandardOutput;
                    string Title = sr.ReadLine();
                    sr.Close();

                    DownloadProgressBar.Value++;

                    if (Title == null)
                    {
                        Log("\n[ERROR] Video " + (i + 1) + "/" + Videos.Length + " was not found. URL: " + Videos[i]);
                        Info += "VÍDEO NO DISPONIBLE\n   URL: " + Videos[i];
                        DownloadProgressBar.Value++;
                        continue;
                    }

                    Log("\nVideo " + (i + 1) + "/" + Videos.Length + " was found! Title: " + Title + ", URL: " + Videos[i]);

                    if (!MP3CheckBox.Checked)
                        VideoProcess.StartInfo.Arguments = Videos[i] + " -f mp4 -o \"" + OutputPath + Title + ".mp4\"";
                    else
                        VideoProcess.StartInfo.Arguments = Videos[i] + " -x --audio-format mp3 -o \"" + OutputPath + Title + ".%(ext)s\"";
                    if (MetadataCheckBox.Checked)
                        VideoProcess.StartInfo.Arguments += " --add-metadata";

                    VideoProcess.Start();
                    VideoProcess.WaitForExit();

                    Log("\nVideo downloaded/converted successfully!");
                    Info += Title + "\n   URL: " + Videos[i] + "\n\n";

                    DownloadedVideos++;
                    DownloadProgressBar.Value++;
                    ProgressText.Text = (i + 1) + "/" + Videos.Length;
                }
                DownloadingVideo = false;

                Info = Info.Remove(Info.Length - 2, 2);

                Log("\nVideos downloaded " + ((MP3CheckBox.Checked) ? "and converted to .mp3 " : "") + "successfully: " + DownloadedVideos + "/" + Videos.Length + "\n");
                DownloadResultForm drm = new DownloadResultForm(Results.Info,
                 "Vídeos descargados con éxito: " + DownloadedVideos + "/" + Videos.Length,
                 DownloadTypes.Video,
                 null,
                 MP3CheckBox.Checked,
                 MetadataCheckBox.Checked,
                 Info);
            }
            catch (Exception ex)
            {
                DownloadingVideo = false;

                OpenDirAtEnd = false;

                Log("\n[ERROR] Error during download videos process:\n" + ex.Message + "\n");
                Info += "\n\n" + ex.ToString();

                DownloadResultForm drm = new DownloadResultForm(Results.Error,
                  "Error en la descarga de " + DownloadedVideos + "/" + Videos.Length + " vídeos",
                  DownloadTypes.Video,
                  null,
                  MP3CheckBox.Checked,
                  MetadataCheckBox.Checked,
                  Info);
            }
            Cursor.Current = Cursors.Default;

            DownloadVideos.Text = "Descargar vídeo(s)";
            DownloadVideos.Enabled = true;
            DownloadProgressBar.Value = 0;
            ProgressText.Text = "--/--";

            if (OpenDirAtEnd)
                Process.Start("explorer.exe", OutputPath);
        }

        private void DownloadPlaylist_Click(object sender, EventArgs e)
        {
            if (!CheckLibs(false))
                return;

            Cursor.Current = Cursors.WaitCursor;

            DownloadPlaylist.Enabled = false;
            DownloadPlaylist.Text = "Descargando lista de reproducción/canal...";
            DownloadPlaylist.Update();

            Log("\n\nDownloading playlist/channel from YouTube");
            InitializeProcess(PlaylistProcess);
            PlaylistProcess.StartInfo.Arguments = PlaylistTextBox.Text + " -i -f mp4" + ((MP3CheckBox.Checked) ? " -x --audio-format mp3": "") + ((MetadataCheckBox.Checked) ? " --add-metadata" : "");

            DownloadingPlaylist = PlaylistProcess.Start();

            StreamReader sr = PlaylistProcess.StandardOutput;

            string Info = "";

            PageTypes PageType = PageTypes.Unknown;
            string PageName = "";
            int PageVideos = 0;
            int DownloadedVideos = 0;
            int DownloadingVideo = 0;

            bool OpenDirAtEnd = OpenAtEndCheckBox.Checked;

            try
            {
                string FileToRename = "", FileNewName = "";

                for (int i = 0; !PlaylistProcess.HasExited; i++)
                {
                    string dLine = sr.ReadLine();

                    if (dLine == null)
                        continue;

                    switch (i)
                    {
                        case 0:
                            if (PageType != PageTypes.Unknown)
                                continue;
                            if (dLine.StartsWith("[youtube:playlist]"))
                            {
                                PageType = PageTypes.Playlist;
                                DownloadPlaylist.Text = "Descargando lista de reproducción...";
                                DownloadPlaylist.Update();
                            }
                            else if (dLine.StartsWith("[youtube:channel]"))
                            {
                                PageType = PageTypes.Channel;
                                i -= 1;
                                DownloadPlaylist.Text = "Descargando canal...";
                                DownloadPlaylist.Update();
                            }
                            else
                                throw new InvalidDataException("La URL especificada no corresponde a ninguna lista de reproducción/canal");
                            continue;
                        case 1:
                            PageName = dLine.Remove(0, (PageType == PageTypes.Playlist) ? 33 : 46);
                            PlaylistNameTextBox.Text = ((PageType == PageTypes.Playlist) ? "Lista de reproducción: " : "Canal: ") + PageName;
                            PlaylistNameTextBox.Update();
                            continue;
                        case 2:
                            PageVideos = int.Parse(dLine.Remove(0, 28 + ((PageType == PageTypes.Playlist) ? 0 : 13) + PageName.Length + 14).Split(' ')[0]);
                            DownloadedVideos = PageVideos;
                            DownloadProgressBar.Maximum = PageVideos;
                            ProgressText.Text = "1/" + PageVideos;
                            //string PageVideosText = dLine.Remove(0, 28 + ((PageType == PageTypes.Playlist) ? 0 : 13) + PageName.Length + 14);
                            continue;
                        default:
                            if (dLine.StartsWith("[download] Downloading video ") || dLine.StartsWith("[download] Finished downloading"))
                            {
                                if (FileToRename != "")
                                {
                                    try
                                    {
                                        string DirectoryToMove = SaveTextBox.Text + ((DownloadInSubfolderCheckBox.Checked) ? PageName + "\\" : "");
                                        if (!Directory.Exists(DirectoryToMove))
                                            Directory.CreateDirectory(DirectoryToMove);
                                        if (MP3CheckBox.Checked)
                                            FileToRename = FileToRename.Remove(FileToRename.Length - 1, 1) + "3";
                                        File.Move(SaveTextBox.Text + FileToRename, DirectoryToMove + FileNewName + ((MP3CheckBox.Checked) ? ".mp3" : ".mp4"));
                                    }
                                    catch (IOException ioex)
                                    {
                                        Log("\n[ERROR] Error trying to rename \"" + SaveTextBox.Text + FileToRename + "\" to \"" + SaveTextBox.Text + FileNewName + "\"\n" + ioex.ToString() + "\n");
                                        Info += "\n   ERROR AL MOVER/RENOMBRAR:\n   " + ioex.ToString() + "\n   Archivo guardado en: " + SaveTextBox.Text + FileToRename;
                                    }
                                }
                                if (dLine.StartsWith("[download] Finished downloading"))
                                    continue;

                                DownloadingVideo = int.Parse(dLine.Remove(0, 29).Split(' ')[0]);

                                Info += "\n\n" + DownloadingVideo + "/" + PageVideos + ": ";

                                ProgressText.Text = DownloadingVideo + "/" + PageVideos;
                                ProgressText.Update();
                                DownloadProgressBar.Value = DownloadingVideo;
                            }
                            if (dLine == "ERROR: This video is unavailable.")
                            {
                                DownloadedVideos--;
                                Log("\n[ERROR] Video " + DownloadingVideo + "/" + PageVideos + " was not found");
                                Info += "VíDEO NO DISPONIBLE\n";
                            }

                            if (dLine.StartsWith("[download] Destination: "))
                            {
                                FileToRename = dLine.Remove(0, 24);
                                FileNewName = FileToRename.Remove(FileToRename.Length - 16, 16);
                                string TempURL = FileToRename.Remove(0, FileNewName.Length + 1).Remove(11, 4);
                                Info += FileNewName + "\n   URL: https://www.youtube.com/watch?v=" + TempURL;
                            }
                            if (dLine.EndsWith(" has already been downloaded"))
                            {
                                FileToRename = dLine.Remove(0, 11);
                                FileToRename = FileToRename.Remove(FileToRename.Length - 28, 28);
                                FileNewName = FileToRename.Remove(FileToRename.Length - 16, 16);
                                string TempURL = FileToRename.Remove(0, FileNewName.Length + 1).Remove(11, 4);
                                Info += FileNewName + "\n   URL: https://www.youtube.com/watch?v=" + TempURL + "\n   VÍDEO YA DESCARGADO";
                            }
                            continue;
                    }
                }
                sr.Close();
                DownloadingPlaylist = false;

                Log("\nVídeos downloaded from " + ((MP3CheckBox.Checked) ? "and converted to .mp3 " : "") + "successfully from " + PageType + " # " + PageName + ": " + DownloadedVideos + "/" + PageVideos + "\n");

                DownloadResultForm drm = new DownloadResultForm(Results.Info,
                    "Vídeos descargados con éxito: " + DownloadedVideos + "/" + PageVideos,
                    (PageType == PageTypes.Playlist) ? DownloadTypes.Playlist : DownloadTypes.Channel,
                    PageName,
                    MP3CheckBox.Checked,
                    MetadataCheckBox.Checked,
                    Info.Remove(0, 2));
            }
            catch (Exception ex)
            {
                sr.Close();
                DownloadingPlaylist = false;

                OpenDirAtEnd = false;

                Log("\n[ERROR] Error during download playlist/channel process: " + ex.Message);
                Info += "\n\n" + ex.ToString();

                DownloadResultForm drm = new DownloadResultForm(Results.Error,
                    "Error en la descarga de " + PageVideos + " vídeos",
                    (PageType == PageTypes.Playlist) ? DownloadTypes.Playlist : DownloadTypes.Channel,
                    PageName,
                    MP3CheckBox.Checked,
                    MetadataCheckBox.Checked,
                    Info.Remove(0, 2));
            }
            Cursor.Current = Cursors.Default;

            PlaylistNameTextBox.Text = "Nombre de la lista de reproducción/canal";
            DownloadPlaylist.Enabled = true;
            DownloadPlaylist.Text = "Descargar lista de reproducción/canal";
            DownloadProgressBar.Value = 0;
            ProgressText.Text = "--/--";

            if (OpenDirAtEnd)
                Process.Start("explorer.exe", OutputPath);
        }

        private void ExportFromPlaylist_Click(object sender, EventArgs e)
        {
            if (ExportTXTSaveFileDialog.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                Log("\nExporting txt from playlist/channel to: " + ExportTXTSaveFileDialog.FileName);

                Cursor.Current = Cursors.WaitCursor;
                DownloadProgressBar.Maximum = 2;

                InitializeProcess(PlaylistProcess);
                PlaylistProcess.StartInfo.Arguments = PlaylistTextBox.Text + " -i --get-id";
                DownloadingPlaylist = PlaylistProcess.Start();

                List<string> ExportResult = new List<string>();

                StreamReader sr = PlaylistProcess.StandardOutput;
                DownloadingPlaylist = true;

                int Videos = 0;
                int ExportedVideos = 0;

                DownloadProgressBar.Value = 1;
                for (int i = 0; !PlaylistProcess.HasExited; i++)
                {
                    string dLine = sr.ReadLine();

                    if (dLine == null)
                        continue;

                    if (dLine.StartsWith("WARNING"))
                        continue;
                    Videos++;
                    if (dLine.StartsWith("ERROR"))
                        continue;
                    ExportResult.Add("https://youtube.com/watch?v=" + dLine);
                    ExportedVideos++;
                }
                sr.Close();
                DownloadingPlaylist = false;
                ;
                File.WriteAllLines(ExportTXTSaveFileDialog.FileName, ExportResult.ToArray());

                DownloadProgressBar.Value = 2;

                Log("\nExported videos successfully: " + ExportedVideos + "/" + Videos);
                MessageBox.Show("Vídeos exportados con éxito: " + ExportedVideos + "/" + Videos, "Resultado de Exportar a txt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Log("\nError during export txt from playlist/channel: " + ex.Message);
                MessageBox.Show("Error:\n\n" + ex.ToString(), "Error exportando a txt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor.Current = Cursors.Default;
            DownloadProgressBar.Value = 0;
        }
    }
}
