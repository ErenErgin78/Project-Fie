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
    public partial class Hosgeldin : Form
    {
        public Hosgeldin()
        {
            InitializeComponent();
        }

        private void btn_tamam_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
