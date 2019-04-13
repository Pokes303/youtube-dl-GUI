using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
namespace YT_Downloader_GUI
{
    public partial class HelpForm : Form
    {
        Form1 f1 = new Form1();

        public HelpForm()
        {
            InitializeComponent();

            VersionLabel.Text = f1.Version;
            LogCheckBox.Checked = f1.SaveToLog;
        }

        private void YTDLLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://ytdl-org.github.io/youtube-dl/index.html");
        }

        private void SourceLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/Pokes303/youtube-dl-GUI/");
        }

        private void LogCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //f1.SaveToLog = true;//LogCheckBox.Checked;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
