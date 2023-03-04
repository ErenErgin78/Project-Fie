using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Sıfre : Form
    {
        public Sıfre()
        {
            InitializeComponent();
        }

        private void Sıfre_Load(object sender, EventArgs e)
        {

        }

        private void Onayla_Click(object sender, EventArgs e)
        {
            string sifre = sıfre_gir.Text.ToString();
            if (sifre == "55261" && kullanıcıadı.Text == "Vodvil")
            {
                Hosgeldin hosgeldin = new Hosgeldin();
                this.Hide();
                hosgeldin.Show();

            }
            else { MessageBox.Show("Kullanıcı adı veya şifre yanlış", "XXXXXXXXXXXXXXXXXXXXXX"); } }
    }
}
