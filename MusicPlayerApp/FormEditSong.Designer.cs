namespace MusicPlayerApp
{
    partial class FormEditSong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditSong));
            this.labelTitlu = new System.Windows.Forms.Label();
            this.labelArtist = new System.Windows.Forms.Label();
            this.textBoxEditedTitle = new System.Windows.Forms.TextBox();
            this.textBoxEditedArtist = new System.Windows.Forms.TextBox();
            this.buttonSalvare = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitlu
            // 
            this.labelTitlu.AutoSize = true;
            this.labelTitlu.BackColor = System.Drawing.Color.Transparent;
            this.labelTitlu.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.labelTitlu.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTitlu.Location = new System.Drawing.Point(197, 127);
            this.labelTitlu.Name = "labelTitlu";
            this.labelTitlu.Size = new System.Drawing.Size(115, 27);
            this.labelTitlu.TabIndex = 0;
            this.labelTitlu.Text = "New Title:";
            // 
            // labelArtist
            // 
            this.labelArtist.AutoSize = true;
            this.labelArtist.BackColor = System.Drawing.Color.Transparent;
            this.labelArtist.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.labelArtist.ForeColor = System.Drawing.SystemColors.Control;
            this.labelArtist.Location = new System.Drawing.Point(197, 188);
            this.labelArtist.Name = "labelArtist";
            this.labelArtist.Size = new System.Drawing.Size(125, 27);
            this.labelArtist.TabIndex = 1;
            this.labelArtist.Text = "New Artist:";
            // 
            // textBoxEditedTitle
            // 
            this.textBoxEditedTitle.Location = new System.Drawing.Point(376, 116);
            this.textBoxEditedTitle.Multiline = true;
            this.textBoxEditedTitle.Name = "textBoxEditedTitle";
            this.textBoxEditedTitle.Size = new System.Drawing.Size(211, 38);
            this.textBoxEditedTitle.TabIndex = 2;
            // 
            // textBoxEditedArtist
            // 
            this.textBoxEditedArtist.Location = new System.Drawing.Point(376, 177);
            this.textBoxEditedArtist.Multiline = true;
            this.textBoxEditedArtist.Name = "textBoxEditedArtist";
            this.textBoxEditedArtist.Size = new System.Drawing.Size(211, 38);
            this.textBoxEditedArtist.TabIndex = 3;
            // 
            // buttonSalvare
            // 
            this.buttonSalvare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonSalvare.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSalvare.Location = new System.Drawing.Point(202, 259);
            this.buttonSalvare.Name = "buttonSalvare";
            this.buttonSalvare.Size = new System.Drawing.Size(176, 54);
            this.buttonSalvare.TabIndex = 4;
            this.buttonSalvare.Text = "Save";
            this.buttonSalvare.UseVisualStyleBackColor = false;
            this.buttonSalvare.Click += new System.EventHandler(this.buttonSalvare_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(74)))));
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Location = new System.Drawing.Point(411, 259);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(176, 54);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormEditSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSalvare);
            this.Controls.Add(this.textBoxEditedArtist);
            this.Controls.Add(this.textBoxEditedTitle);
            this.Controls.Add(this.labelArtist);
            this.Controls.Add(this.labelTitlu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEditSong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusicPlayerApp - Edit song";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitlu;
        private System.Windows.Forms.Label labelArtist;
        private System.Windows.Forms.TextBox textBoxEditedTitle;
        private System.Windows.Forms.TextBox textBoxEditedArtist;
        private System.Windows.Forms.Button buttonSalvare;
        private System.Windows.Forms.Button buttonCancel;
    }
}