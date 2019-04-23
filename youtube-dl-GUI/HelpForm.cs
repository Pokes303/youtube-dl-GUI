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
    public partial class HelpForm : Form
    {
        public Form1 f1;

        public HelpForm(Form1 _f1)
        {
            InitializeComponent();

            f1 = _f1;

            VersionLabel.Text = f1.Version;
            LogCheckBox.Checked = f1.SaveToLog;
        }

        private void YTDLLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://ytdl-org.github.io/youtube-dl/index.html");
        }

        private void FlaticonLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.flaticon.com");
        }

        private void SourceLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/Pokes303/youtube-dl-GUI/");
        }
        
        private void LogCheckBox_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de que quieres " + ((!f1.SaveToLog) ? "activar" : "desactivar") + " los registros?\n\nLa aplicación se reiniciará", "Activar/Desactivar registros", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;
            if (f1.SaveToLog && !File.Exists(f1.NoLogsPath))
                File.Create(f1.NoLogsPath);
            else if (!f1.SaveToLog && File.Exists(f1.NoLogsPath))
                File.Delete(f1.NoLogsPath);
            Application.Restart();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DeleteLogsButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de que quieres eliminar la carpeta de registros?: " + f1.LogsPath, "Eliminar registros", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string[] Logs = Directory.GetFiles(f1.LogsPath);
                int LogsDeleted = 0;
                bool ActualLogFound = false;
                for (int i = 0; i < Logs.Length; i++)
                {
                    if (Logs[i] == f1.CurrentLog)
                    {
                        ActualLogFound = true;
                        continue;
                    }
                    try { File.Delete(Logs[i]); }
                    catch { continue; }
                    LogsDeleted++;
                }
                MessageBox.Show("Registros eliminados correctamente: " + LogsDeleted + "/" + (Logs.Length - ((ActualLogFound) ? 1 : 0)), "Eliminar registros completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
