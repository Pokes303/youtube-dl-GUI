using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace youtube_dl_GUI
{
    public enum Results
    {
        Info, Error
    }
    public enum DownloadTypes
    {
        Video, Playlist, Channel
    }

    public partial class DownloadResultForm : Form
    {

        public DownloadResultForm(
            Results result,
            string title,
            DownloadTypes downloadType,
            string playlistName,
            bool toMP3,
            bool addMetadata,
            string info)
        {
            InitializeComponent();

            if (result == Results.Error)
                ResultPictureBox.Image = Properties.Resources.error;

            TitleLabel.Text = title;

            switch (downloadType)
            {
                case DownloadTypes.Video:
                    TypeLabel.Text += "Vídeo(s)";
                    ExportSaveFileDialog.FileName = "Video_";
                    break;
                case DownloadTypes.Playlist:
                    TypeLabel.Text += "Lista de reproducción";
                    ExportSaveFileDialog.FileName = "Playlist_";
                    break;
                case DownloadTypes.Channel:
                    TypeLabel.Text += "Canal";
                    ExportSaveFileDialog.FileName = "Channel_";
                    break;
            }

            if (downloadType != DownloadTypes.Video)
            {
                NameLabel.Enabled = true;
                NameLabel.Text = "   " + playlistName + "   ";

                ExportSaveFileDialog.FileName += playlistName + "_";
            }

            MP3CheckBox.Checked = toMP3;

            MetadataCheckBox.Checked = addMetadata;

            InfoTextBox.Text = info.Replace("\n", "\r\n");

            ExportSaveFileDialog.FileName += DateTime.Now.ToFileTime();
            ExportSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();

            ShowDialog();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExportResultButton_Click(object sender, EventArgs e)
        {
            if (ExportSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    List<string> ResultToExport = new List<string>();
                    ResultToExport.Add(TitleLabel.Text);
                    ResultToExport.Add(TypeLabel.Text);
                    if (NameLabel.Text != "   Nombre de lista de reproducción/canal   ")
                        ResultToExport.Add(NameLabel.Text);
                    ResultToExport.Add("Vídeos descargados y convertidos a MP3: " + MP3CheckBox.Checked);
                    ResultToExport.Add("Datos del vídeo añadidos al archivo (Metadata): " + MetadataCheckBox.Checked);
                    ResultToExport.AddRange(InfoTextBox.Lines);

                    File.WriteAllLines(ExportSaveFileDialog.FileName, ResultToExport.ToArray());

                    MessageBox.Show("Resultado de la descarga exportado con éxito", "Exportado con éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(IOException ioex)
                {
                    MessageBox.Show("Error exportando el resultado de la descarga\n\n" + ioex.ToString(), "Error exportando", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
