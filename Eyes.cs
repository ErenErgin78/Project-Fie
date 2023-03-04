using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Eyes : Form
    {
       
        public Eyes()
        {
            InitializeComponent();
        }
        int x = 0;
        readonly SoundPlayer Sound = new SoundPlayer(@"C:\Users\Ergin\Downloads\Sound2.wav");
        private void Eyes_Load(object sender, EventArgs e)
        {
           
            Sound.Play();
        }
      
        private void timer1_Tick(object sender, EventArgs e)
        {

            x += 1;
            if (x == 5) {Application.Exit(); }
        }
    }
}
