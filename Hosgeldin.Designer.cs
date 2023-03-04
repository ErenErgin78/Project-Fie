namespace Project
{
    partial class Hosgeldin
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
            this.lbl_Hosgeldin = new System.Windows.Forms.Label();
            this.btn_tamam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Hosgeldin
            // 
            this.lbl_Hosgeldin.AutoSize = true;
            this.lbl_Hosgeldin.Font = new System.Drawing.Font("Perpetua Titling MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hosgeldin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_Hosgeldin.Location = new System.Drawing.Point(88, 79);
            this.lbl_Hosgeldin.Name = "lbl_Hosgeldin";
            this.lbl_Hosgeldin.Size = new System.Drawing.Size(229, 34);
            this.lbl_Hosgeldin.TabIndex = 0;
            this.lbl_Hosgeldin.Text = "Hoşgeldiniz";
            // 
            // btn_tamam
            // 
            this.btn_tamam.Location = new System.Drawing.Point(161, 203);
            this.btn_tamam.Name = "btn_tamam";
            this.btn_tamam.Size = new System.Drawing.Size(75, 23);
            this.btn_tamam.TabIndex = 1;
            this.btn_tamam.Text = "Tamam";
            this.btn_tamam.UseVisualStyleBackColor = true;
            this.btn_tamam.Click += new System.EventHandler(this.btn_tamam_Click);
            // 
            // Hosgeldin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(401, 341);
            this.Controls.Add(this.btn_tamam);
            this.Controls.Add(this.lbl_Hosgeldin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Hosgeldin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hosgeldin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Hosgeldin;
        private System.Windows.Forms.Button btn_tamam;
    }
}