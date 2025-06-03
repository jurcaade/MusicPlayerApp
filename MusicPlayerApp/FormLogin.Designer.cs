namespace MusicPlayerApp
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.labelUtilizator = new System.Windows.Forms.Label();
            this.labelParola = new System.Windows.Forms.Label();
            this.textBoxUtilizator = new System.Windows.Forms.TextBox();
            this.textBoxParola = new System.Windows.Forms.TextBox();
            this.buttonAutentificare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUtilizator
            // 
            this.labelUtilizator.AutoSize = true;
            this.labelUtilizator.BackColor = System.Drawing.Color.Transparent;
            this.labelUtilizator.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUtilizator.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelUtilizator.Location = new System.Drawing.Point(206, 121);
            this.labelUtilizator.Name = "labelUtilizator";
            this.labelUtilizator.Size = new System.Drawing.Size(121, 27);
            this.labelUtilizator.TabIndex = 0;
            this.labelUtilizator.Text = "Username:";
            // 
            // labelParola
            // 
            this.labelParola.AutoSize = true;
            this.labelParola.BackColor = System.Drawing.Color.Transparent;
            this.labelParola.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.labelParola.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelParola.Location = new System.Drawing.Point(206, 202);
            this.labelParola.Name = "labelParola";
            this.labelParola.Size = new System.Drawing.Size(114, 27);
            this.labelParola.TabIndex = 1;
            this.labelParola.Text = "Password:";
            // 
            // textBoxUtilizator
            // 
            this.textBoxUtilizator.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxUtilizator.Location = new System.Drawing.Point(353, 110);
            this.textBoxUtilizator.Multiline = true;
            this.textBoxUtilizator.Name = "textBoxUtilizator";
            this.textBoxUtilizator.Size = new System.Drawing.Size(211, 38);
            this.textBoxUtilizator.TabIndex = 2;
            // 
            // textBoxParola
            // 
            this.textBoxParola.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxParola.Location = new System.Drawing.Point(353, 191);
            this.textBoxParola.Multiline = true;
            this.textBoxParola.Name = "textBoxParola";
            this.textBoxParola.Size = new System.Drawing.Size(211, 38);
            this.textBoxParola.TabIndex = 3;
            // 
            // buttonAutentificare
            // 
            this.buttonAutentificare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonAutentificare.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAutentificare.Location = new System.Drawing.Point(265, 292);
            this.buttonAutentificare.Name = "buttonAutentificare";
            this.buttonAutentificare.Size = new System.Drawing.Size(239, 58);
            this.buttonAutentificare.TabIndex = 4;
            this.buttonAutentificare.Text = "Login";
            this.buttonAutentificare.UseVisualStyleBackColor = false;
            this.buttonAutentificare.Click += new System.EventHandler(this.buttonAutentificare_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAutentificare);
            this.Controls.Add(this.textBoxParola);
            this.Controls.Add(this.textBoxUtilizator);
            this.Controls.Add(this.labelParola);
            this.Controls.Add(this.labelUtilizator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusicPlayerApp - Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUtilizator;
        private System.Windows.Forms.Label labelParola;
        private System.Windows.Forms.TextBox textBoxUtilizator;
        private System.Windows.Forms.TextBox textBoxParola;
        private System.Windows.Forms.Button buttonAutentificare;
    }
}

