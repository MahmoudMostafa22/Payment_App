using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FawryTest
{
    public partial class succesfully : Form
    {
        public succesfully()
        {
            InitializeComponent();
            pictureBox1.ImageLocation = "D:\\download.png";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 w = new Form1();
            w.Show();
        }
    }
}
