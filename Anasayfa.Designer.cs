namespace Project
{
    partial class Anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.Misafir = new System.Windows.Forms.Button();
            this.Yönetici = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Misafir
            // 
            this.Misafir.BackColor = System.Drawing.Color.Black;
            this.Misafir.Font = new System.Drawing.Font("Wide Latin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Misafir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Misafir.Location = new System.Drawing.Point(395, 275);
            this.Misafir.Name = "Misafir";
            this.Misafir.Size = new System.Drawing.Size(198, 67);
            this.Misafir.TabIndex = 0;
            this.Misafir.Text = "Misafir";
            this.Misafir.UseVisualStyleBackColor = false;
            this.Misafir.Click += new System.EventHandler(this.Misafir_Click);
            // 
            // Yönetici
            // 
            this.Yönetici.BackColor = System.Drawing.Color.Black;
            this.Yönetici.Font = new System.Drawing.Font("Wide Latin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Yönetici.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Yönetici.Location = new System.Drawing.Point(57, 275);
            this.Yönetici.Name = "Yönetici";
            this.Yönetici.Size = new System.Drawing.Size(198, 67);
            this.Yönetici.TabIndex = 0;
            this.Yönetici.Text = "Yönetici";
            this.Yönetici.UseVisualStyleBackColor = false;
            this.Yönetici.Click += new System.EventHandler(this.Yönetici_Click);
            this.Yönetici.MouseLeave += new System.EventHandler(this.Yönetici_MouseLeave);
            this.Yönetici.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Yönetici_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Help;
            this.pictureBox1.Image = global::Project.Properties.Resources.Göz;
            this.pictureBox1.Location = new System.Drawing.Point(97, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(467, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Project.Properties.Resources.gözler;
            this.pictureBox2.Location = new System.Drawing.Point(-5, 219);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(343, 208);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(648, 418);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Yönetici);
            this.Controls.Add(this.Misafir);
            this.Controls.Add(this.pictureBox2);
            this.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "H̶̢͔͍̱̤̳̣̩̾͜ͅo̷̱̲̳͇̞͚̠̦̯̿̀̔͊̔̾̿͛̋̾̏̚͘s̵̡̨̗͈͒̕g̸̪̜̫̝̯̈e̸̪͕̠̱̲͌̾̿͊̓̃͆̀̿͘͜͝l̶̽̂͊̐̓͂͠" +
    "̨̧̢̧̮̘̝̱̫̞̬̑̓̽̋͜d̴̛̩̪͎͒̂͋͛̀͊̾̾i̸̗͒́n̵̨̳̬̼̝̭̉̓ Vodvil";
            this.Deactivate += new System.EventHandler(this.Anasayfa_Deactivate);
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Misafir;
        private System.Windows.Forms.Button Yönetici;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}