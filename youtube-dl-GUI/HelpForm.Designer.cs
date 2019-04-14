namespace YT_Downloader_GUI
{
    partial class HelpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.YTDLLink = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SourceLinkLabel = new System.Windows.Forms.LinkLabel();
            this.LogCheckBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.DeleteLogsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // YTDLLink
            // 
            resources.ApplyResources(this.YTDLLink, "YTDLLink");
            this.YTDLLink.Name = "YTDLLink";
            this.YTDLLink.TabStop = true;
            this.YTDLLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.YTDLLink_LinkClicked);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // SourceLinkLabel
            // 
            resources.ApplyResources(this.SourceLinkLabel, "SourceLinkLabel");
            this.SourceLinkLabel.Name = "SourceLinkLabel";
            this.SourceLinkLabel.TabStop = true;
            this.SourceLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SourceLinkLabel_LinkClicked);
            // 
            // LogCheckBox
            // 
            this.LogCheckBox.AutoCheck = false;
            resources.ApplyResources(this.LogCheckBox, "LogCheckBox");
            this.LogCheckBox.Checked = true;
            this.LogCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LogCheckBox.Name = "LogCheckBox";
            this.LogCheckBox.UseVisualStyleBackColor = true;
            this.LogCheckBox.Click += new System.EventHandler(this.LogCheckBox_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // ExitButton
            // 
            resources.ApplyResources(this.ExitButton, "ExitButton");
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // VersionLabel
            // 
            resources.ApplyResources(this.VersionLabel, "VersionLabel");
            this.VersionLabel.Name = "VersionLabel";
            // 
            // DeleteLogsButton
            // 
            resources.ApplyResources(this.DeleteLogsButton, "DeleteLogsButton");
            this.DeleteLogsButton.Name = "DeleteLogsButton";
            this.DeleteLogsButton.UseVisualStyleBackColor = true;
            this.DeleteLogsButton.Click += new System.EventHandler(this.DeleteLogsButton_Click);
            // 
            // HelpForm
            // 
            this.AcceptButton = this.ExitButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DeleteLogsButton);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.LogCheckBox);
            this.Controls.Add(this.SourceLinkLabel);
            this.Controls.Add(this.YTDLLink);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HelpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel YTDLLink;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel SourceLinkLabel;
        private System.Windows.Forms.CheckBox LogCheckBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Button DeleteLogsButton;
    }
}