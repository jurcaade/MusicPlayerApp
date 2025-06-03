namespace MusicPlayerApp
{
    partial class FormAddSong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddSong));
            this.textBoxPiesa = new System.Windows.Forms.TextBox();
            this.textBoxArtist = new System.Windows.Forms.TextBox();
            this.labelTitluPiesa = new System.Windows.Forms.Label();
            this.labelNumeArtist = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPiesa
            // 
            this.textBoxPiesa.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPiesa.Location = new System.Drawing.Point(375, 116);
            this.textBoxPiesa.Multiline = true;
            this.textBoxPiesa.Name = "textBoxPiesa";
            this.textBoxPiesa.Size = new System.Drawing.Size(209, 36);
            this.textBoxPiesa.TabIndex = 0;
            // 
            // textBoxArtist
            // 
            this.textBoxArtist.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.textBoxArtist.Location = new System.Drawing.Point(375, 179);
            this.textBoxArtist.Multiline = true;
            this.textBoxArtist.Name = "textBoxArtist";
            this.textBoxArtist.Size = new System.Drawing.Size(209, 36);
            this.textBoxArtist.TabIndex = 1;
            // 
            // labelTitluPiesa
            // 
            this.labelTitluPiesa.AutoSize = true;
            this.labelTitluPiesa.BackColor = System.Drawing.Color.Transparent;
            this.labelTitluPiesa.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.labelTitluPiesa.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTitluPiesa.Location = new System.Drawing.Point(203, 125);
            this.labelTitluPiesa.Name = "labelTitluPiesa";
            this.labelTitluPiesa.Size = new System.Drawing.Size(120, 27);
            this.labelTitluPiesa.TabIndex = 3;
            this.labelTitluPiesa.Text = "Song Title:";
            // 
            // labelNumeArtist
            // 
            this.labelNumeArtist.AutoSize = true;
            this.labelNumeArtist.BackColor = System.Drawing.Color.Transparent;
            this.labelNumeArtist.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.labelNumeArtist.ForeColor = System.Drawing.SystemColors.Control;
            this.labelNumeArtist.Location = new System.Drawing.Point(188, 188);
            this.labelNumeArtist.Name = "labelNumeArtist";
            this.labelNumeArtist.Size = new System.Drawing.Size(140, 27);
            this.labelNumeArtist.TabIndex = 4;
            this.labelNumeArtist.Text = "Artist Name:";
            // 
            // buttonOk
            // 
            this.buttonOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonOk.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.buttonOk.Location = new System.Drawing.Point(193, 269);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(176, 54);
            this.buttonOk.TabIndex = 5;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = false;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(74)))));
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCancel.Location = new System.Drawing.Point(408, 269);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(176, 54);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormAddSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelNumeArtist);
            this.Controls.Add(this.labelTitluPiesa);
            this.Controls.Add(this.textBoxArtist);
            this.Controls.Add(this.textBoxPiesa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddSong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusicPlayerApp - Add Song";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPiesa;
        private System.Windows.Forms.TextBox textBoxArtist;
        private System.Windows.Forms.Label labelTitluPiesa;
        private System.Windows.Forms.Label labelNumeArtist;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}