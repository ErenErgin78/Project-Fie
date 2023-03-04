namespace Project
{
    partial class Sıfre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sıfre));
            this.sifre_gir = new System.Windows.Forms.Label();
            this.kullanıcıadı = new System.Windows.Forms.TextBox();
            this.Onayla = new System.Windows.Forms.Button();
            this.sıfre_gir = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sifre_gir
            // 
            this.sifre_gir.AutoSize = true;
            this.sifre_gir.Font = new System.Drawing.Font("Ravie", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sifre_gir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.sifre_gir.Location = new System.Drawing.Point(12, 33);
            this.sifre_gir.Name = "sifre_gir";
            this.sifre_gir.Size = new System.Drawing.Size(275, 21);
            this.sifre_gir.TabIndex = 1;
            this.sifre_gir.Text = "Kullanıcı Adı ve Şifre girin";
            // 
            // kullanıcıadı
            // 
            this.kullanıcıadı.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kullanıcıadı.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kullanıcıadı.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.kullanıcıadı.Location = new System.Drawing.Point(54, 85);
            this.kullanıcıadı.MaxLength = 20;
            this.kullanıcıadı.Name = "kullanıcıadı";
            this.kullanıcıadı.Size = new System.Drawing.Size(187, 25);
            this.kullanıcıadı.TabIndex = 0;
            this.kullanıcıadı.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Onayla
            // 
            this.Onayla.Location = new System.Drawing.Point(112, 187);
            this.Onayla.Name = "Onayla";
            this.Onayla.Size = new System.Drawing.Size(75, 23);
            this.Onayla.TabIndex = 2;
            this.Onayla.Text = "O̷̧͍̣͚͓̰̫̼̱̲͉̠̦̞̓͆̿̅̓̈́̑̓́̕̚͝͝ͅn̴̡̡̞̗̥̤̼̭̮͉͔̱͂̅͆̎̃́͗̀͊̓͐̐̈́͘a̴̛͍͉̖͉̍̊͜y̷̽̍͂́̓̀̈́͂̌̒̑" +
    "̨̢͇͔̥̳̣͍̼̣̣̜̘͗̓̾l̵̰̱͎̺̤̜͈̇͑͆͗͐̅̓̇͘̚͝a̸̹̯̩͍̥̖̼̻̣̹̖̠̒̈͒͑̾̑̐";
            this.Onayla.UseVisualStyleBackColor = true;
            this.Onayla.Click += new System.EventHandler(this.Onayla_Click);
            // 
            // sıfre_gir
            // 
            this.sıfre_gir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sıfre_gir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sıfre_gir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.sıfre_gir.Location = new System.Drawing.Point(54, 140);
            this.sıfre_gir.MaxLength = 20;
            this.sıfre_gir.Name = "sıfre_gir";
            this.sıfre_gir.Size = new System.Drawing.Size(187, 25);
            this.sıfre_gir.TabIndex = 0;
            this.sıfre_gir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Sıfre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(297, 233);
            this.Controls.Add(this.Onayla);
            this.Controls.Add(this.sifre_gir);
            this.Controls.Add(this.sıfre_gir);
            this.Controls.Add(this.kullanıcıadı);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Sıfre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sifre";
            this.Load += new System.EventHandler(this.Sıfre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label sifre_gir;
        private System.Windows.Forms.TextBox kullanıcıadı;
        private System.Windows.Forms.Button Onayla;
        private System.Windows.Forms.TextBox sıfre_gir;
    }
}