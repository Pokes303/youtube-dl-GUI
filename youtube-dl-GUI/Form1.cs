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
        StreamWriter sw;

        public string Version = "1.0";
        public bool SaveToLog = false;//WIP

        private static Color Good = Color.FromArgb(192, 255, 192);
        private static Color Bad = Color.FromArgb(255, 192, 192);

        private string OutputPath = Directory.GetCurrentDirectory() + "\\DownloadedVideos\\";

        public Form1()
        {
            InitializeComponent();
            
            if (!Directory.Exists(OutputPath))
                Directory.CreateDirectory(OutputPath);
            SaveTextBox.Text = OutputPath;
            if (SaveToLog)
            {
                if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\logs\\"))
                    Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\logs\\");
                sw = new StreamWriter(Directory.GetCurrentDirectory() + "\\logs\\log" + DateTime.Now.ToFileTime() + ".txt");
            }
            Log("#### youtube-dl GUI log ####");
            Log("\r\nStarted at: " + DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + " - " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "\r\n");
            
            while (!File.Exists(Directory.GetCurrentDirectory() + "\\youtube-dl.exe"))
            {
                DialogResult dr = MessageBox.Show("No se pudo encontrar el archvo youtube-dl.exe\n\nDescargue el programa de nuevo desde https://github.com/Pokes303/youtube-dl-GUI e inténtelo de nuevo", "Arcivo youtube-dl.exe no encontrado", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (dr == DialogResult.Cancel)
                    Application.Exit();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Log("\r\n\r\n## End ##");
            if (SaveToLog)
                sw.Close();
        }

        public void Log(string Text)
        {
            if (SaveToLog)
                sw.Write(Text);
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
            HelpForm hf = new HelpForm();
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
            Download.Enabled = false;
            Download.Text = "Descargando...";
            Cursor.Current = Cursors.WaitCursor;

            string[] Videos = VideosTextBox.Text.Split('\n');

            Log("\r\nDownloading " + Videos.Length + " videos from YouTube");

            DownloadProgressBar.Maximum = Videos.Length * 2;
            DownloadingText.Text = "Descargando...\n1/" + Videos.Length;

            if (!Directory.Exists(OutputPath))
                Directory.CreateDirectory(OutputPath);

            string DownloadedVideosInfo = "";
            int DownloadedVideos = 0;

            try
            {
                using (Process DownloadProcess = new Process())
                {
                    Log("\r\nStarting download process");
                    DownloadProcess.StartInfo.UseShellExecute = false;
                    DownloadProcess.StartInfo.CreateNoWindow = true;
                    DownloadProcess.StartInfo.RedirectStandardOutput = true;
                    DownloadProcess.StartInfo.FileName = "youtube-dl.exe";

                    for (int i = 0; i < Videos.Length; i++)
                    {
                        DownloadedVideosInfo += "\n\n" + (i + 1) + "/" + Videos.Length + ": ";
                        DownloadProcess.StartInfo.Arguments = Videos[i] + " --get-title";
                        DownloadProcess.Start();
                        while (!DownloadProcess.HasExited) { }
                        StreamReader sr = DownloadProcess.StandardOutput;
                        string Title = sr.ReadLine();
                        DownloadProgressBar.Value++;
                        MessageBox.Show("_" + Title + "_");
                        if (Title == null)
                        {
                            DownloadedVideosInfo += "VÍDEO NO DISPONIBLE\n   URL: " + Videos[i];
                            DownloadProgressBar.Value++;
                            continue;
                        }
                        Log("\r\nVideo " + (i + 1) + "/" + Videos.Length + " title: " + Title);
                        DownloadProcess.StartInfo.Arguments = Videos[i] + " -f mp4 -o \"" + OutputPath + Title + ".mp4\"";
                        DownloadProcess.Start();
                        while (!DownloadProcess.HasExited) { }
                        DownloadedVideosInfo += Title + "\n   URL: " + Videos[i];
                        DownloadedVideos++;
                        DownloadProgressBar.Value++;
                        DownloadingText.Text = "Descargando...\n" + (i + 2) + "/" + Videos.Length;
                    }
                }
            }
            catch (Exception ex)
            {
                Log("\r\nError during download process: " + ex.Message);
                MessageBox.Show("ERROR\n" + ex.Message + "\n\n" + ex.Data,
                    ex.Source, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
                Download.Text = "Descargar";
                Download.Enabled = true;
                DownloadProgressBar.Value = 0;
                DownloadingText.Text = "Descargando...\n1/" + Videos.Length;
            }
            MessageBox.Show("Vídeos descargados con éxito: " + DownloadedVideos + "/" + Videos.Length + "\n-----------------------------------" + DownloadedVideosInfo, "Vídeos descargados", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
