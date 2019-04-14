using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
namespace YT_Downloader_GUI
{
    public partial class Form1 : Form
    {
        public string Version = "1.1";
        
        private static Color Good = Color.FromArgb(192, 255, 192);
        private static Color Bad = Color.FromArgb(255, 192, 192);

        private string OutputPath = Directory.GetCurrentDirectory() + "\\DownloadedVideos\\";

        public readonly bool SaveToLog = !File.Exists(Directory.GetCurrentDirectory() + "\\nologs");
        public string LogsPath = Directory.GetCurrentDirectory() + "\\logs\\";
        StreamWriter LogSw;
        public string CurrentLog = null;
        public string NoLogsPath = Directory.GetCurrentDirectory() + "\\nologs";

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
                LogSw = new StreamWriter(CurrentLog);
            }

            Log("#### youtube-dl GUI log ####");
            Log("\r\nStarted at: " + DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + " - " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "\r\n");

            CheckLibs(true);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Log("\r\n\r\n## End ##");
            if (SaveToLog)
                LogSw.Close();
        }

        public void Log(string Text)
        {
            if (SaveToLog)
                LogSw.Write(Text);
        }

        public bool CheckLibs(bool CloseIfCancel)
        {
            Log("\r\nChecking libs...");
            while (!File.Exists(Directory.GetCurrentDirectory() + "\\youtube-dl.exe"))
            {
                Log("\r\nyoutube-dl library not found. Trying again...");
                DialogResult dr = MessageBox.Show("No se pudo encontrar el archvo youtube-dl.exe\n\nDescargue el programa de nuevo desde https://github.com/Pokes303/youtube-dl-GUI e inténtelo de nuevo", "Archivo youtube-dl.exe no encontrado", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (dr == DialogResult.Cancel)
                {
                    if (CloseIfCancel)
                        Application.Exit();
                    return false;
                }
            }
            Log("\r\nyoutube-dl library found!");
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
            Log("\r\nffmpeg library found!");
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
            try
            {
                if (ImportTXTOpenFileDialog.ShowDialog() != DialogResult.OK)
                    return;
                Log("\r\nImporting txt from: " + ImportTXTOpenFileDialog.FileName);
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
                Log("\r\nError during Import txt: " + ioe.Message);
                MessageBox.Show("Error: " + ioe.Message + "\n\n" + ioe.Data);
            }
        }

        private void ExportTXT_Click(object sender, EventArgs e)
        {
            try
            {
                if (ExportTXTSaveFileDialog.ShowDialog() != DialogResult.OK)
                    return;
                Log("\nImporting txt to: " + ExportTXTSaveFileDialog.FileName);
                StreamWriter exportsw = new StreamWriter(ExportTXTSaveFileDialog.FileName);
                for (int i = 0; i < VideosTextBox.Lines.Length; i++)
                {
                    exportsw.Write(VideosTextBox.Lines[i]);// + "\r\n");
                    if (i < VideosTextBox.Lines.Length - 1)
                        exportsw.Write("\r\n");
                }
                exportsw.Close();
            }
            catch (IOException ioe)
            {
                Log("\r\nError during Export txt: " + ioe.Message);
                MessageBox.Show("Error: " + ioe.Message + "\n\n" + ioe.Data);
            }
        }

        private void SaveTextBox_TextChanged(object sender, EventArgs e)
        {
            bool Valid = Directory.Exists(SaveTextBox.Text);
            SaveTextBox.BackColor = (Valid) ? Good : Bad;
            Download.Enabled = Valid;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (SaveFolderBrowserDialog.ShowDialog() == DialogResult.OK)
                SaveTextBox.Text = SaveFolderBrowserDialog.SelectedPath;
        }

        private void Download_Click(object sender, EventArgs e)
        {
            if (!CheckLibs(false))
                return;

            Download.Enabled = false;
            Download.Text = "Descargando...";
            Cursor.Current = Cursors.WaitCursor;

            string[] Videos = VideosTextBox.Text.Split('\n');

            Log("\r\n\r\nDownloading " + Videos.Length + " videos from YouTube");
            Log("\r\nConvert videos to .mp3: " + MP3CheckBox.Checked);

            DownloadProgressBar.Maximum = Videos.Length * 2;
            DownloadingText.Text = "1/" + Videos.Length;

            if (!Directory.Exists(OutputPath))
                Directory.CreateDirectory(OutputPath);
            
            try
            {
                using (Process DownloadProcess = new Process())
                {
                    string DownloadedVideosInfo = "";
                    int DownloadedVideos = 0;

                    Log("\r\nStarting download process");

                    DownloadProcess.StartInfo.UseShellExecute = false;
                    DownloadProcess.StartInfo.CreateNoWindow = true;
                    DownloadProcess.StartInfo.RedirectStandardOutput = true;
                    DownloadProcess.StartInfo.FileName = "youtube-dl.exe";

                    for (int i = 0; i < Videos.Length; i++)
                    {
                        Log("\r\nDownloading video " + i + "/" + Videos.Length + "...");
                        DownloadedVideosInfo += "\n\n" + (i + 1) + "/" + Videos.Length + ": ";

                        DownloadProcess.StartInfo.Arguments = Videos[i] + " --get-title";
                        DownloadProcess.Start();
                        while (!DownloadProcess.HasExited) { }

                        StreamReader sr = DownloadProcess.StandardOutput;
                        string Title = sr.ReadLine();
                        sr.Close();

                        DownloadProgressBar.Value++;

                        if (Title == null)
                        {
                            Log("\r\n[ERROR] Video " + (i + 1) + "/" + Videos.Length + " was not found. URL: " + Videos[i]);
                            DownloadedVideosInfo += "VÍDEO NO DISPONIBLE\n   URL: " + Videos[i];
                            DownloadProgressBar.Value++;
                            continue;
                        }

                        Log("\r\nVideo " + (i + 1) + "/" + Videos.Length + " was found! Title: " + Title + ", URL: " + Videos[i]);

                        if (!MP3CheckBox.Checked)
                            DownloadProcess.StartInfo.Arguments = Videos[i] + " -f mp4 -o \"" + OutputPath + Title + ".mp4\"";
                        else
                            DownloadProcess.StartInfo.Arguments = Videos[i] + " -x --audio-format mp3 -o \"" + OutputPath + Title + ".mp3\"";

                        DownloadProcess.Start();
                        while (!DownloadProcess.HasExited) { }

                        Log("\r\nVideo downloaded/converted successfully!");
                        DownloadedVideosInfo += Title + "\n   URL: " + Videos[i];

                        DownloadedVideos++;
                        DownloadProgressBar.Value++;
                        DownloadingText.Text = (i + 1) + "/" + Videos.Length;
                    }
                    Log("Vídeos downloaded " + ((MP3CheckBox.Checked) ? "and converted to .mp3 " : "") + "successfully: " + DownloadedVideos + "/" + Videos.Length + "\r\n");
                    MessageBox.Show("Vídeos descargados " + ((MP3CheckBox.Checked) ? "y convertidos a .mp3 " : "") + "con éxito: " + DownloadedVideos + "/" + Videos.Length + "\n-----------------------------------" + DownloadedVideosInfo, "Vídeos descargados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Log("\r\n[ERROR] Error during download process: " + ex.Message);
                MessageBox.Show("Error during download process:\n\n" + ex.ToString(),
                    ex.Source, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            Cursor.Current = Cursors.Default;
            Download.Text = "Descargar";
            Download.Enabled = true;
            DownloadProgressBar.Value = 0;
            DownloadingText.Text = "--/--";
            if (OpenAtEndCheckBox.Checked)
                Process.Start("explorer.exe", OutputPath);
        }

        private void VideosTextBox_TextChanged(object sender, EventArgs e)
        {
            /*if (VideosTextBox.Text == "")
                return;

            string[] Videos = VideosTextBox.Text.Split('\n');

            using (Process CheckProcess = new Process())
            {
                CheckProcess.StartInfo.UseShellExecute = false;
                CheckProcess.StartInfo.CreateNoWindow = true;//false;//true;
                CheckProcess.StartInfo.RedirectStandardOutput = true;
                CheckProcess.StartInfo.FileName = "youtube-dl.exe";

                for (int i = 0; i < Videos.Length; i++)
                {
                    if (Videos[i] == "")
                        continue;
                    CheckProcess.StartInfo.Arguments = Videos[i] + " --get-duration";
                    CheckProcess.Start();
                    StreamReader sr = CheckProcess.StandardOutput;
                    string EndLine = sr.ReadToEnd();
                    if (EndLine == "")
                        VideosTextBox.BackColor = Color.FromArgb(255, 192, 192);
                    else
                        VideosTextBox.BackColor = Color.FromArgb(192, 255, 192);
                    MessageBox.Show("_" + Videos[i] + "\n\n" + EndLine + "_");
                }
            }*/
        }
    }
}
