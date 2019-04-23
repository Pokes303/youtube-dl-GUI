namespace youtube_dl_GUI
{
    partial class DownloadResultForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DownloadResultForm));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.InfoTextBox = new System.Windows.Forms.TextBox();
            this.MP3CheckBox = new System.Windows.Forms.CheckBox();
            this.MetadataCheckBox = new System.Windows.Forms.CheckBox();
            this.ResultPictureBox = new System.Windows.Forms.PictureBox();
            this.ExportResultButton = new System.Windows.Forms.Button();
            this.ExportSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ResultPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(113, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(307, 20);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Vídeos descargados con éxito: --/--";
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeLabel.Location = new System.Drawing.Point(113, 29);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(127, 17);
            this.TypeLabel.TabIndex = 1;
            this.TypeLabel.Text = "Tipo de descarga: ";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameLabel.Enabled = false;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(114, 49);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(329, 22);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "   Nombre de lista de reproducción/canal   ";
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(397, 426);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // InfoTextBox
            // 
            this.InfoTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.InfoTextBox.Location = new System.Drawing.Point(12, 113);
            this.InfoTextBox.Multiline = true;
            this.InfoTextBox.Name = "InfoTextBox";
            this.InfoTextBox.ReadOnly = true;
            this.InfoTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.InfoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.InfoTextBox.Size = new System.Drawing.Size(460, 307);
            this.InfoTextBox.TabIndex = 3;
            this.InfoTextBox.WordWrap = false;
            // 
            // MP3CheckBox
            // 
            this.MP3CheckBox.AutoCheck = false;
            this.MP3CheckBox.AutoSize = true;
            this.MP3CheckBox.Checked = true;
            this.MP3CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MP3CheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MP3CheckBox.Location = new System.Drawing.Point(114, 74);
            this.MP3CheckBox.Name = "MP3CheckBox";
            this.MP3CheckBox.Size = new System.Drawing.Size(220, 17);
            this.MP3CheckBox.TabIndex = 4;
            this.MP3CheckBox.Text = "Videos descargados y convertidos a .mp3";
            this.MP3CheckBox.UseVisualStyleBackColor = true;
            // 
            // MetadataCheckBox
            // 
            this.MetadataCheckBox.AutoCheck = false;
            this.MetadataCheckBox.AutoSize = true;
            this.MetadataCheckBox.Checked = true;
            this.MetadataCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MetadataCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MetadataCheckBox.Location = new System.Drawing.Point(114, 90);
            this.MetadataCheckBox.Name = "MetadataCheckBox";
            this.MetadataCheckBox.Size = new System.Drawing.Size(248, 17);
            this.MetadataCheckBox.TabIndex = 4;
            this.MetadataCheckBox.Text = "Datos del vídeo añadidos al archivo (Metadata)";
            this.MetadataCheckBox.UseVisualStyleBackColor = true;
            // 
            // ResultPictureBox
            // 
            this.ResultPictureBox.Image = global::youtube_dl_GUI.Properties.Resources.info;
            this.ResultPictureBox.Location = new System.Drawing.Point(24, 24);
            this.ResultPictureBox.Name = "ResultPictureBox";
            this.ResultPictureBox.Size = new System.Drawing.Size(65, 65);
            this.ResultPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ResultPictureBox.TabIndex = 0;
            this.ResultPictureBox.TabStop = false;
            // 
            // ExportResultButton
            // 
            this.ExportResultButton.Location = new System.Drawing.Point(12, 426);
            this.ExportResultButton.Name = "ExportResultButton";
            this.ExportResultButton.Size = new System.Drawing.Size(265, 23);
            this.ExportResultButton.TabIndex = 5;
            this.ExportResultButton.Text = "Exportar resultado de la descarga a un archivo.txt";
            this.ExportResultButton.UseVisualStyleBackColor = true;
            this.ExportResultButton.Click += new System.EventHandler(this.ExportResultButton_Click);
            // 
            // ExportSaveFileDialog
            // 
            this.ExportSaveFileDialog.FileName = "result.txt";
            this.ExportSaveFileDialog.Filter = "Archivo TXT|*.txt|Todos los archivos|*.*";
            // 
            // DownloadResultForm
            // 
            this.AcceptButton = this.OkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.ExportResultButton);
            this.Controls.Add(this.MetadataCheckBox);
            this.Controls.Add(this.MP3CheckBox);
            this.Controls.Add(this.InfoTextBox);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.ResultPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "DownloadResultForm";
            this.Text = "Resultado de la descarga";
            ((System.ComponentModel.ISupportInitialize)(this.ResultPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.TextBox InfoTextBox;
        private System.Windows.Forms.CheckBox MP3CheckBox;
        private System.Windows.Forms.CheckBox MetadataCheckBox;
        private System.Windows.Forms.PictureBox ResultPictureBox;
        private System.Windows.Forms.Button ExportResultButton;
        private System.Windows.Forms.SaveFileDialog ExportSaveFileDialog;
    }
}