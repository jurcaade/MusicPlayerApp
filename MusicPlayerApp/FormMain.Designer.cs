namespace MusicPlayerApp
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.dataGridViewSongs = new System.Windows.Forms.DataGridView();
            this.btnAdaugaPiesa = new System.Windows.Forms.Button();
            this.btnStergePiesa = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.searchSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNowPlaying = new System.Windows.Forms.Label();
            this.btnPlaySong = new System.Windows.Forms.Button();
            this.btnStopSong = new System.Windows.Forms.Button();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSongs)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.songBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSongs
            // 
            this.dataGridViewSongs.AllowUserToAddRows = false;
            this.dataGridViewSongs.AllowUserToDeleteRows = false;
            this.dataGridViewSongs.AutoGenerateColumns = false;
            this.dataGridViewSongs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridViewSongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSongs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.artistDataGridViewTextBoxColumn});
            this.dataGridViewSongs.DataSource = this.songBindingSource;
            this.dataGridViewSongs.Location = new System.Drawing.Point(69, 113);
            this.dataGridViewSongs.Name = "dataGridViewSongs";
            this.dataGridViewSongs.ReadOnly = true;
            this.dataGridViewSongs.RowHeadersWidth = 51;
            this.dataGridViewSongs.RowTemplate.Height = 24;
            this.dataGridViewSongs.Size = new System.Drawing.Size(591, 333);
            this.dataGridViewSongs.TabIndex = 0;
            // 
            // btnAdaugaPiesa
            // 
            this.btnAdaugaPiesa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(74)))));
            this.btnAdaugaPiesa.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdaugaPiesa.ForeColor = System.Drawing.Color.White;
            this.btnAdaugaPiesa.Location = new System.Drawing.Point(143, 487);
            this.btnAdaugaPiesa.Name = "btnAdaugaPiesa";
            this.btnAdaugaPiesa.Size = new System.Drawing.Size(186, 53);
            this.btnAdaugaPiesa.TabIndex = 1;
            this.btnAdaugaPiesa.Text = "Add song";
            this.btnAdaugaPiesa.UseVisualStyleBackColor = false;
            this.btnAdaugaPiesa.Click += new System.EventHandler(this.btnAdaugaPiesa_Click);
            // 
            // btnStergePiesa
            // 
            this.btnStergePiesa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(145)))));
            this.btnStergePiesa.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.btnStergePiesa.Location = new System.Drawing.Point(368, 487);
            this.btnStergePiesa.Name = "btnStergePiesa";
            this.btnStergePiesa.Size = new System.Drawing.Size(186, 53);
            this.btnStergePiesa.TabIndex = 2;
            this.btnStergePiesa.Text = "Delete song";
            this.btnStergePiesa.UseVisualStyleBackColor = false;
            this.btnStergePiesa.Click += new System.EventHandler(this.btnStergePiesa_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(185)))), ((int)(((byte)(247)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchSongToolStripMenuItem,
            this.editSongToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(919, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // searchSongToolStripMenuItem
            // 
            this.searchSongToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(93)))), ((int)(((byte)(176)))));
            this.searchSongToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.searchSongToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.searchSongToolStripMenuItem.Name = "searchSongToolStripMenuItem";
            this.searchSongToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.searchSongToolStripMenuItem.Text = "Search Song";
            this.searchSongToolStripMenuItem.Click += new System.EventHandler(this.searchSongToolStripMenuItem_Click);
            // 
            // editSongToolStripMenuItem
            // 
            this.editSongToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.editSongToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.editSongToolStripMenuItem.Name = "editSongToolStripMenuItem";
            this.editSongToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.editSongToolStripMenuItem.Text = "Edit Song";
            this.editSongToolStripMenuItem.Click += new System.EventHandler(this.editSongToolStripMenuItem_Click);
            // 
            // lblNowPlaying
            // 
            this.lblNowPlaying.AutoSize = true;
            this.lblNowPlaying.BackColor = System.Drawing.Color.Transparent;
            this.lblNowPlaying.Font = new System.Drawing.Font("Sylfaen", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNowPlaying.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(145)))));
            this.lblNowPlaying.Location = new System.Drawing.Point(84, 56);
            this.lblNowPlaying.Name = "lblNowPlaying";
            this.lblNowPlaying.Size = new System.Drawing.Size(242, 36);
            this.lblNowPlaying.TabIndex = 4;
            this.lblNowPlaying.Text = "Music Player App";
            // 
            // btnPlaySong
            // 
            this.btnPlaySong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(74)))));
            this.btnPlaySong.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.btnPlaySong.ForeColor = System.Drawing.Color.Transparent;
            this.btnPlaySong.Location = new System.Drawing.Point(716, 189);
            this.btnPlaySong.Name = "btnPlaySong";
            this.btnPlaySong.Size = new System.Drawing.Size(143, 43);
            this.btnPlaySong.TabIndex = 5;
            this.btnPlaySong.Text = "Play";
            this.btnPlaySong.UseVisualStyleBackColor = false;
            this.btnPlaySong.Click += new System.EventHandler(this.btnPlaySong_Click);
            // 
            // btnStopSong
            // 
            this.btnStopSong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(145)))));
            this.btnStopSong.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.btnStopSong.Location = new System.Drawing.Point(716, 274);
            this.btnStopSong.Name = "btnStopSong";
            this.btnStopSong.Size = new System.Drawing.Size(143, 43);
            this.btnStopSong.TabIndex = 6;
            this.btnStopSong.Text = "Stop";
            this.btnStopSong.UseVisualStyleBackColor = false;
            this.btnStopSong.Click += new System.EventHandler(this.btnStopSong_Click);
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn.Width = 150;
            // 
            // artistDataGridViewTextBoxColumn
            // 
            this.artistDataGridViewTextBoxColumn.DataPropertyName = "Artist";
            this.artistDataGridViewTextBoxColumn.HeaderText = "Artist";
            this.artistDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.artistDataGridViewTextBoxColumn.Name = "artistDataGridViewTextBoxColumn";
            this.artistDataGridViewTextBoxColumn.ReadOnly = true;
            this.artistDataGridViewTextBoxColumn.Width = 240;
            // 
            // songBindingSource
            // 
            this.songBindingSource.DataSource = typeof(MusicPlayerApp.Song);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(919, 601);
            this.Controls.Add(this.btnStopSong);
            this.Controls.Add(this.btnPlaySong);
            this.Controls.Add(this.lblNowPlaying);
            this.Controls.Add(this.btnStergePiesa);
            this.Controls.Add(this.btnAdaugaPiesa);
            this.Controls.Add(this.dataGridViewSongs);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Player App";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSongs)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.songBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSongs;
        private System.Windows.Forms.Button btnAdaugaPiesa;
        private System.Windows.Forms.Button btnStergePiesa;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem searchSongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editSongToolStripMenuItem;
        private System.Windows.Forms.Label lblNowPlaying;
        private System.Windows.Forms.Button btnPlaySong;
        private System.Windows.Forms.Button btnStopSong;
        private System.Windows.Forms.BindingSource songBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistDataGridViewTextBoxColumn;
    }
}