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
    public partial class PhoneCash : Form
    {
        public PhoneCash()
        {
            InitializeComponent();
            pictureBox1.ImageLocation = "D:\\phonepay.jpg";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            int n = 9;
            if (textBox1.Text.Length == n && textBox1.Text.Contains("03")|| textBox1.Text.Contains("02"))
            {
                this.Hide();
                Phonepayment x = new Phonepayment();
                x.Closed += (s, args) => this.Close();
                x.Show();
            }
            else
            {
                label2.Visible = true;

            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
          

        }

        private void label2_Click(object sender, EventArgs e)
        {
          
           
        }

        private void PhoneCash_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            pays back = new pays();
            back.Closed += (s, args) => this.Close();
            back.Show();
        }
    }
}
