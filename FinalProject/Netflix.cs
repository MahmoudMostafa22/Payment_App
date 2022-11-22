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
    public partial class Netflix : Form
    {
        public double tax;
        public double total;
        public double cost;
        public int n;

        public Netflix()
        {
            InitializeComponent();
            comboBox1.Items.Add("Renew membership");
            comboBox1.Items.Add("New subscription");

        }

        private void Renew_Click(object sender, EventArgs e)
        {
            
        }

        private void Register_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string gettext = comboBox1.SelectedItem.ToString();
            if (gettext == "New subscription")
            {
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;

            }
            else if (gettext == "Renew membership")
            {
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                label1.Visible = true;
                label1.Text = " select your payment method  ";
            }
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked.Equals(true))
            {
                label1.Visible = true;
                label1.Text = "1 month subscription\n select your payment method  ";
                n = 1;
            }
            if (radioButton2.Checked.Equals(true))
            {
                label1.Visible = true;
                label1.Text = "3 month subscription\n select your payment method  ";
                n = 3;
            }
            if (radioButton3.Checked.Equals(true))
            {
                label1.Visible = true;
                label1.Text = "1 year subscription\n select your payment method  ";
                n = 12;
            }
        }
        public string phone_Num;
        //public Netflix(string num) { this.phone_Num = num; }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Netflix_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminClass x = new AdminClass();
            tax = x.TaxPrice;
            cost = n * x.NetflixPrice;
            total = cost + cost * tax;

            if (textBox1.Text.Trim() == String.Empty)
                textBox1.Text = "please enter your phone number";
                
            if (textBox2.Text.Trim() == String.Empty)
                textBox2.Text = "Please enter your name"; 
            else
            {
                reciet recipet = new reciet(textBox2.Text,textBox1.Text,cost,tax,total);
                recipet.Show();
            }


        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked.Equals(true) && checkBox2.Checked.Equals(true))
            {
                label6.Visible = true;
            }
            else if (checkBox2.Checked.Equals(true) && checkBox1.Checked.Equals(false))
            {
                label5.Visible = true;
                textBox3.Visible = true;
            }
            else if (checkBox2.Checked.Equals(false) && checkBox1.Checked.Equals(false))
            {
                label6.Visible = false;
                label5.Visible = false;
                textBox3.Visible = false;
            }
            else if (checkBox2.Checked.Equals(false) && checkBox1.Checked.Equals(true))
            {
                label6.Visible = false;
                label5.Visible = false;
                textBox3.Visible = false;
            }


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            pays back = new pays();
            back.Closed += (s, args) => this.Close();
            back.Show();
        }
       


        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}
