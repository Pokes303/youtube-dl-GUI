namespace youtube_dl_GUI
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
            this.ImportTXT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ExportTXT = new System.Windows.Forms.Button();
            this.DownloadVideos = new System.Windows.Forms.Button();
            this.DownloadProgressBar = new System.Windows.Forms.ProgressBar();
            this.ProgressText = new System.Windows.Forms.Label();
            this.ExportTXTSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.ImportTXTOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.OpenAtEndCheckBox = new System.Windows.Forms.CheckBox();
            this.SaveTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SaveFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.MP3CheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.VideosTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.VideosTabPage = new System.Windows.Forms.TabPage();
            this.PlaylistTabPage = new System.Windows.Forms.TabPage();
            this.ExportFromPlaylist = new System.Windows.Forms.Button();
            this.PlaylistNameTextBox = new System.Windows.Forms.TextBox();
            this.DownloadInSubfolderCheckBox = new System.Windows.Forms.CheckBox();
            this.PlaylistTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DownloadPlaylist = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.MetadataCheckBox = new System.Windows.Forms.CheckBox();
            this.PlaylistProcess = new System.Diagnostics.Process();
            this.VideoProcess = new System.Diagnostics.Process();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.VideosTabPage.SuspendLayout();
            this.PlaylistTabPage.SuspendLayout();
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
            // ImportTXT
            // 
            this.ImportTXT.Location = new System.Drawing.Point(231, 181);
            this.ImportTXT.Name = "ImportTXT";
            this.ImportTXT.Size = new System.Drawing.Size(215, 23);
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
            this.ExportTXT.Location = new System.Drawing.Point(7, 181);
            this.ExportTXT.Name = "ExportTXT";
            this.ExportTXT.Size = new System.Drawing.Size(215, 23);
            this.ExportTXT.TabIndex = 3;
            this.ExportTXT.Text = "Exportar URLs a un archivo .txt";
            this.ExportTXT.UseVisualStyleBackColor = true;
            this.ExportTXT.Click += new System.EventHandler(this.ExportTXT_Click);
            // 
            // DownloadVideos
            // 
            this.DownloadVideos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadVideos.Location = new System.Drawing.Point(6, 210);
            this.DownloadVideos.Name = "DownloadVideos";
            this.DownloadVideos.Size = new System.Drawing.Size(440, 46);
            this.DownloadVideos.TabIndex = 5;
            this.DownloadVideos.Text = "Descargar vídeo(s)";
            this.DownloadVideos.UseVisualStyleBackColor = true;
            this.DownloadVideos.Click += new System.EventHandler(this.DownloadVideos_Click);
            // 
            // DownloadProgressBar
            // 
            this.DownloadProgressBar.Location = new System.Drawing.Point(12, 383);
            this.DownloadProgressBar.Name = "DownloadProgressBar";
            this.DownloadProgressBar.Size = new System.Drawing.Size(410, 23);
            this.DownloadProgressBar.TabIndex = 6;
            // 
            // ProgressText
            // 
            this.ProgressText.AutoSize = true;
            this.ProgressText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgressText.Location = new System.Drawing.Point(428, 390);
            this.ProgressText.Name = "ProgressText";
            this.ProgressText.Size = new System.Drawing.Size(32, 17);
            this.ProgressText.TabIndex = 8;
            this.ProgressText.Text = "--/--";
            this.ProgressText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.OpenAtEndCheckBox.Location = new System.Drawing.Point(337, 316);
            this.OpenAtEndCheckBox.Name = "OpenAtEndCheckBox";
            this.OpenAtEndCheckBox.Size = new System.Drawing.Size(135, 17);
            this.OpenAtEndCheckBox.TabIndex = 9;
            this.OpenAtEndCheckBox.Text = "Abrir carpeta al finalizar";
            this.OpenAtEndCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OpenAtEndCheckBox.UseVisualStyleBackColor = true;
            // 
            // SaveTextBox
            // 
            this.SaveTextBox.Location = new System.Drawing.Point(12, 334);
            this.SaveTextBox.Name = "SaveTextBox";
            this.SaveTextBox.Size = new System.Drawing.Size(426, 20);
            this.SaveTextBox.TabIndex = 10;
            this.SaveTextBox.TextChanged += new System.EventHandler(this.SaveTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Guardar vídeos en carpeta:";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(444, 331);
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
            this.MP3CheckBox.Location = new System.Drawing.Point(12, 360);
            this.MP3CheckBox.Name = "MP3CheckBox";
            this.MP3CheckBox.Size = new System.Drawing.Size(130, 17);
            this.MP3CheckBox.TabIndex = 13;
            this.MP3CheckBox.Text = "Descargar como .mp3";
            this.MP3CheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "URL de vídeos de YouTube (Uno por línea)";
            // 
            // VideosTextBox
            // 
            this.VideosTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.VideosTextBox.Location = new System.Drawing.Point(6, 19);
            this.VideosTextBox.Multiline = true;
            this.VideosTextBox.Name = "VideosTextBox";
            this.VideosTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.VideosTextBox.Size = new System.Drawing.Size(440, 156);
            this.VideosTextBox.TabIndex = 3;
            this.VideosTextBox.WordWrap = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.VideosTabPage);
            this.tabControl1.Controls.Add(this.PlaylistTabPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(460, 288);
            this.tabControl1.TabIndex = 15;
            // 
            // VideosTabPage
            // 
            this.VideosTabPage.Controls.Add(this.VideosTextBox);
            this.VideosTabPage.Controls.Add(this.label3);
            this.VideosTabPage.Controls.Add(this.ImportTXT);
            this.VideosTabPage.Controls.Add(this.ExportTXT);
            this.VideosTabPage.Controls.Add(this.DownloadVideos);
            this.VideosTabPage.Location = new System.Drawing.Point(4, 22);
            this.VideosTabPage.Name = "VideosTabPage";
            this.VideosTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.VideosTabPage.Size = new System.Drawing.Size(452, 262);
            this.VideosTabPage.TabIndex = 0;
            this.VideosTabPage.Text = "    Descargar vídeos    ";
            this.VideosTabPage.UseVisualStyleBackColor = true;
            // 
            // PlaylistTabPage
            // 
            this.PlaylistTabPage.Controls.Add(this.ExportFromPlaylist);
            this.PlaylistTabPage.Controls.Add(this.PlaylistNameTextBox);
            this.PlaylistTabPage.Controls.Add(this.DownloadInSubfolderCheckBox);
            this.PlaylistTabPage.Controls.Add(this.PlaylistTextBox);
            this.PlaylistTabPage.Controls.Add(this.label4);
            this.PlaylistTabPage.Controls.Add(this.DownloadPlaylist);
            this.PlaylistTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaylistTabPage.Location = new System.Drawing.Point(4, 22);
            this.PlaylistTabPage.Name = "PlaylistTabPage";
            this.PlaylistTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.PlaylistTabPage.Size = new System.Drawing.Size(452, 262);
            this.PlaylistTabPage.TabIndex = 1;
            this.PlaylistTabPage.Text = "    Descargar listas de reproducción/canales    ";
            this.PlaylistTabPage.UseVisualStyleBackColor = true;
            // 
            // ExportFromPlaylist
            // 
            this.ExportFromPlaylist.Location = new System.Drawing.Point(6, 181);
            this.ExportFromPlaylist.Name = "ExportFromPlaylist";
            this.ExportFromPlaylist.Size = new System.Drawing.Size(440, 23);
            this.ExportFromPlaylist.TabIndex = 18;
            this.ExportFromPlaylist.Text = "Exportar URLs de lista de reproducción/canal a un archivo .txt";
            this.ExportFromPlaylist.UseVisualStyleBackColor = true;
            this.ExportFromPlaylist.Click += new System.EventHandler(this.ExportFromPlaylist_Click);
            // 
            // PlaylistNameTextBox
            // 
            this.PlaylistNameTextBox.Enabled = false;
            this.PlaylistNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaylistNameTextBox.Location = new System.Drawing.Point(6, 123);
            this.PlaylistNameTextBox.Name = "PlaylistNameTextBox";
            this.PlaylistNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PlaylistNameTextBox.Size = new System.Drawing.Size(440, 26);
            this.PlaylistNameTextBox.TabIndex = 17;
            this.PlaylistNameTextBox.Text = "Nombre de la lista de reproducción/canal";
            this.PlaylistNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DownloadInSubfolderCheckBox
            // 
            this.DownloadInSubfolderCheckBox.AutoSize = true;
            this.DownloadInSubfolderCheckBox.Checked = true;
            this.DownloadInSubfolderCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DownloadInSubfolderCheckBox.Location = new System.Drawing.Point(6, 75);
            this.DownloadInSubfolderCheckBox.Name = "DownloadInSubfolderCheckBox";
            this.DownloadInSubfolderCheckBox.Size = new System.Drawing.Size(417, 17);
            this.DownloadInSubfolderCheckBox.TabIndex = 16;
            this.DownloadInSubfolderCheckBox.Text = "Descargar vídeos en subcarpeta con el nombre de la lista de reproducción o canal";
            this.DownloadInSubfolderCheckBox.UseVisualStyleBackColor = true;
            // 
            // PlaylistTextBox
            // 
            this.PlaylistTextBox.Location = new System.Drawing.Point(6, 49);
            this.PlaylistTextBox.Name = "PlaylistTextBox";
            this.PlaylistTextBox.Size = new System.Drawing.Size(440, 20);
            this.PlaylistTextBox.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "URL de lista de reproducción o canal de YouTube";
            // 
            // DownloadPlaylist
            // 
            this.DownloadPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadPlaylist.Location = new System.Drawing.Point(6, 210);
            this.DownloadPlaylist.Name = "DownloadPlaylist";
            this.DownloadPlaylist.Size = new System.Drawing.Size(440, 46);
            this.DownloadPlaylist.TabIndex = 5;
            this.DownloadPlaylist.Text = "Descargar lista de reproducción/canal";
            this.DownloadPlaylist.UseVisualStyleBackColor = true;
            this.DownloadPlaylist.Click += new System.EventHandler(this.DownloadPlaylist_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(159, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "|";
            // 
            // MetadataCheckBox
            // 
            this.MetadataCheckBox.AutoSize = true;
            this.MetadataCheckBox.Location = new System.Drawing.Point(192, 361);
            this.MetadataCheckBox.Name = "MetadataCheckBox";
            this.MetadataCheckBox.Size = new System.Drawing.Size(235, 17);
            this.MetadataCheckBox.TabIndex = 13;
            this.MetadataCheckBox.Text = "Añadir datos del vídeo al archivo (metadata)";
            this.MetadataCheckBox.UseVisualStyleBackColor = true;
            // 
            // PlaylistProcess
            // 
            this.PlaylistProcess.StartInfo.Domain = "";
            this.PlaylistProcess.StartInfo.LoadUserProfile = false;
            this.PlaylistProcess.StartInfo.Password = null;
            this.PlaylistProcess.StartInfo.StandardErrorEncoding = null;
            this.PlaylistProcess.StartInfo.StandardOutputEncoding = null;
            this.PlaylistProcess.StartInfo.UserName = "";
            this.PlaylistProcess.SynchronizingObject = this;
            // 
            // VideoProcess
            // 
            this.VideoProcess.StartInfo.Domain = "";
            this.VideoProcess.StartInfo.LoadUserProfile = false;
            this.VideoProcess.StartInfo.Password = null;
            this.VideoProcess.StartInfo.StandardErrorEncoding = null;
            this.VideoProcess.StartInfo.StandardOutputEncoding = null;
            this.VideoProcess.StartInfo.UserName = "";
            this.VideoProcess.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 416);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.MetadataCheckBox);
            this.Controls.Add(this.MP3CheckBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SaveTextBox);
            this.Controls.Add(this.OpenAtEndCheckBox);
            this.Controls.Add(this.ProgressText);
            this.Controls.Add(this.DownloadProgressBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(500, 455);
            this.MinimumSize = new System.Drawing.Size(500, 455);
            this.Name = "Form1";
            this.Text = "Youtube-dl GUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.VideosTabPage.ResumeLayout(false);
            this.VideosTabPage.PerformLayout();
            this.PlaylistTabPage.ResumeLayout(false);
            this.PlaylistTabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.Button ImportTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExportTXT;
        private System.Windows.Forms.Button DownloadVideos;
        private System.Windows.Forms.ToolStripMenuItem abrirDirectorioDelProgramaToolStripMenuItem;
        private System.Windows.Forms.ProgressBar DownloadProgressBar;
        private System.Windows.Forms.Label ProgressText;
        private System.Windows.Forms.SaveFileDialog ExportTXTSaveFileDialog;
        private System.Windows.Forms.OpenFileDialog ImportTXTOpenFileDialog;
        private System.Windows.Forms.CheckBox OpenAtEndCheckBox;
        private System.Windows.Forms.TextBox SaveTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.FolderBrowserDialog SaveFolderBrowserDialog;
        private System.Windows.Forms.CheckBox MP3CheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox VideosTextBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage VideosTabPage;
        private System.Windows.Forms.TabPage PlaylistTabPage;
        private System.Windows.Forms.TextBox PlaylistTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DownloadPlaylist;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox MetadataCheckBox;
        private System.Windows.Forms.CheckBox DownloadInSubfolderCheckBox;
        private System.Diagnostics.Process PlaylistProcess;
        private System.Windows.Forms.TextBox PlaylistNameTextBox;
        private System.Diagnostics.Process VideoProcess;
        private System.Windows.Forms.Button ExportFromPlaylist;
    }
}

