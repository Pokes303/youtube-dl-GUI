namespace YT_Downloader_GUI
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirDirectorioDelProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.VideosTextBox = new System.Windows.Forms.TextBox();
            this.ImportTXT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ExportTXT = new System.Windows.Forms.Button();
            this.Download = new System.Windows.Forms.Button();
            this.DownloadProgressBar = new System.Windows.Forms.ProgressBar();
            this.DownloadingText = new System.Windows.Forms.Label();
            this.ExportTXTSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.ImportTXTOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.OpenAtEndCheckBox = new System.Windows.Forms.CheckBox();
            this.SaveTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SaveFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.MP3CheckBox = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirDirectorioDelProgramaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.aToolStripMenuItem.Image = global::youtube_dl_GUI.Properties.Resources.settings;
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.aToolStripMenuItem.Text = "Opciones";
            // 
            // abrirDirectorioDelProgramaToolStripMenuItem
            // 
            this.abrirDirectorioDelProgramaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("abrirDirectorioDelProgramaToolStripMenuItem.Image")));
            this.abrirDirectorioDelProgramaToolStripMenuItem.Name = "abrirDirectorioDelProgramaToolStripMenuItem";
            this.abrirDirectorioDelProgramaToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.abrirDirectorioDelProgramaToolStripMenuItem.Text = "Abrir directorio del programa";
            this.abrirDirectorioDelProgramaToolStripMenuItem.Click += new System.EventHandler(this.abrirDirectorioDelProgramaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ayudaToolStripMenuItem.Image")));
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.VideosTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 165);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "URL de vídeos de YouTube (Uno por línea)";
            // 
            // VideosTextBox
            // 
            this.VideosTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.VideosTextBox.Location = new System.Drawing.Point(6, 19);
            this.VideosTextBox.Multiline = true;
            this.VideosTextBox.Name = "VideosTextBox";
            this.VideosTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.VideosTextBox.Size = new System.Drawing.Size(448, 140);
            this.VideosTextBox.TabIndex = 3;
            this.VideosTextBox.WordWrap = false;
            this.VideosTextBox.TextChanged += new System.EventHandler(this.VideosTextBox_TextChanged);
            // 
            // ImportTXT
            // 
            this.ImportTXT.Location = new System.Drawing.Point(248, 198);
            this.ImportTXT.Name = "ImportTXT";
            this.ImportTXT.Size = new System.Drawing.Size(224, 23);
            this.ImportTXT.TabIndex = 3;
            this.ImportTXT.Text = "Importar URLs de un archivo .txt";
            this.ImportTXT.UseVisualStyleBackColor = true;
            this.ImportTXT.Click += new System.EventHandler(this.ImportTXT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // ExportTXT
            // 
            this.ExportTXT.Location = new System.Drawing.Point(12, 198);
            this.ExportTXT.Name = "ExportTXT";
            this.ExportTXT.Size = new System.Drawing.Size(224, 23);
            this.ExportTXT.TabIndex = 3;
            this.ExportTXT.Text = "Exportar URLs a un archivo .txt";
            this.ExportTXT.UseVisualStyleBackColor = true;
            this.ExportTXT.Click += new System.EventHandler(this.ExportTXT_Click);
            // 
            // Download
            // 
            this.Download.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Download.Location = new System.Drawing.Point(12, 266);
            this.Download.Name = "Download";
            this.Download.Size = new System.Drawing.Size(363, 46);
            this.Download.TabIndex = 5;
            this.Download.Text = "Descargar";
            this.Download.UseVisualStyleBackColor = true;
            this.Download.Click += new System.EventHandler(this.Download_Click);
            // 
            // DownloadProgressBar
            // 
            this.DownloadProgressBar.Location = new System.Drawing.Point(12, 318);
            this.DownloadProgressBar.Name = "DownloadProgressBar";
            this.DownloadProgressBar.Size = new System.Drawing.Size(410, 23);
            this.DownloadProgressBar.TabIndex = 6;
            // 
            // DownloadingText
            // 
            this.DownloadingText.AutoSize = true;
            this.DownloadingText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadingText.Location = new System.Drawing.Point(428, 325);
            this.DownloadingText.Name = "DownloadingText";
            this.DownloadingText.Size = new System.Drawing.Size(32, 17);
            this.DownloadingText.TabIndex = 8;
            this.DownloadingText.Text = "--/--";
            this.DownloadingText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExportTXTSaveFileDialog
            // 
            this.ExportTXTSaveFileDialog.FileName = "videos.txt";
            this.ExportTXTSaveFileDialog.Filter = "Archivo TXT|*.txt|Todos los archivos|*.*";
            // 
            // ImportTXTOpenFileDialog
            // 
            this.ImportTXTOpenFileDialog.FileName = "videos.txt";
            this.ImportTXTOpenFileDialog.Filter = "Archivo TXT|*.txt|Todos los archivos|*.*";
            // 
            // OpenAtEndCheckBox
            // 
            this.OpenAtEndCheckBox.AutoSize = true;
            this.OpenAtEndCheckBox.Checked = true;
            this.OpenAtEndCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OpenAtEndCheckBox.Location = new System.Drawing.Point(381, 282);
            this.OpenAtEndCheckBox.Name = "OpenAtEndCheckBox";
            this.OpenAtEndCheckBox.Size = new System.Drawing.Size(97, 30);
            this.OpenAtEndCheckBox.TabIndex = 9;
            this.OpenAtEndCheckBox.Text = "Abrir carpeta al\r\nfinalizar";
            this.OpenAtEndCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OpenAtEndCheckBox.UseVisualStyleBackColor = true;
            // 
            // SaveTextBox
            // 
            this.SaveTextBox.Location = new System.Drawing.Point(12, 240);
            this.SaveTextBox.Name = "SaveTextBox";
            this.SaveTextBox.Size = new System.Drawing.Size(426, 20);
            this.SaveTextBox.TabIndex = 10;
            this.SaveTextBox.TextChanged += new System.EventHandler(this.SaveTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Guardar vídeos en carpeta:";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(444, 237);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(28, 23);
            this.SaveButton.TabIndex = 12;
            this.SaveButton.Text = "...";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // MP3CheckBox
            // 
            this.MP3CheckBox.AutoSize = true;
            this.MP3CheckBox.Location = new System.Drawing.Point(381, 266);
            this.MP3CheckBox.Name = "MP3CheckBox";
            this.MP3CheckBox.Size = new System.Drawing.Size(103, 17);
            this.MP3CheckBox.TabIndex = 13;
            this.MP3CheckBox.Text = "Convertir a .mp3";
            this.MP3CheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 351);
            this.Controls.Add(this.MP3CheckBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SaveTextBox);
            this.Controls.Add(this.OpenAtEndCheckBox);
            this.Controls.Add(this.DownloadingText);
            this.Controls.Add(this.DownloadProgressBar);
            this.Controls.Add(this.Download);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExportTXT);
            this.Controls.Add(this.ImportTXT);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Youtube-dl GUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox VideosTextBox;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.Button ImportTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExportTXT;
        private System.Windows.Forms.Button Download;
        private System.Windows.Forms.ToolStripMenuItem abrirDirectorioDelProgramaToolStripMenuItem;
        private System.Windows.Forms.ProgressBar DownloadProgressBar;
        private System.Windows.Forms.Label DownloadingText;
        private System.Windows.Forms.SaveFileDialog ExportTXTSaveFileDialog;
        private System.Windows.Forms.OpenFileDialog ImportTXTOpenFileDialog;
        private System.Windows.Forms.CheckBox OpenAtEndCheckBox;
        private System.Windows.Forms.TextBox SaveTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.FolderBrowserDialog SaveFolderBrowserDialog;
        private System.Windows.Forms.CheckBox MP3CheckBox;
    }
}

