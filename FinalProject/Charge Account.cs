using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Charge_Account_Form : Form
    {
        public Charge_Account_Form()
        {
            InitializeComponent();
            pictureBox1.ImageLocation = "D:\\Project Advanced\\Utilites\\Membership.jpg";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Charge_Account_Form_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Gas_Form s = new Gas_Form();
            s.Show();
        }

        private void Confirm_Button_Click(object sender, EventArgs e)
        {
            reciet x = new reciet();
            x.Show();
        }
    }
}
