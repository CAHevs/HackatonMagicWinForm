using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackatonMagic
{
    public partial class Form1 : Form
    {

        int pvJ1 = 20;
        int pvJ2 = 20;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMinusJ1_Click(object sender, EventArgs e)
        {
            pvJ1--;
            lblPVJ1.Text = pvJ1.ToString();
        }

        private void btnPlusJ1_Click(object sender, EventArgs e)
        {
            pvJ1++;
            lblPVJ1.Text = pvJ1.ToString();
        }

        private void btnMinusJ2_Click(object sender, EventArgs e)
        {
            pvJ2--;
            lblPVJ2.Text = pvJ2.ToString();
        }

        private void btnPlusJ2_Click(object sender, EventArgs e)
        {
            pvJ2++;
            lblPVJ2.Text = pvJ2.ToString();
        }
    }
}
