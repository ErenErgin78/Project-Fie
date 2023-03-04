using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }


        readonly SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Ergin\Downloads\Sound1.wav");

        public void Anasayfa_Load(object sender, EventArgs e)
        {
            simpleSound.Play();
        }

        private void Yönetici_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox2.Visible = true;
        }
        private void Yönetici_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
        }
       
        private void Yönetici_Click(object sender, EventArgs e)
        {            
            simpleSound.Stop();
            this.Hide();
            Sıfre sıfre = new Sıfre();
            sıfre.Show();
        }

        private void Misafir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Eyes eyes = new Eyes();
            eyes.Show();

        }
        private void Anasayfa_Deactivate(object sender, EventArgs e)
        {
            simpleSound.Stop();
           
        }


    }
}
