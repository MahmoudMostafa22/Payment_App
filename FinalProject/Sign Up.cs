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
    public partial class Sign_Up : Form
    {
        public Sign_Up()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            succesfully o = new succesfully();
            o.Show();
        }

        private void Sign_Up_Load(object sender, EventArgs e)
        {

        }
    }
}
