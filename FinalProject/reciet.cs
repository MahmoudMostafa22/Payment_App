using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class reciet : Form
    {
        public reciet()
        {

        }
        public reciet(string A, string b, double c, double e, double f)
        {
            InitializeComponent();
            label2.Text = A;
            label1.Text = b;
            label9.Text = Convert.ToString(c);
            label11.Text = Convert.ToString(e);
            label15.Text = Convert.ToString(f);
        }
        
        private void Nuwsub_Load(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {   
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
