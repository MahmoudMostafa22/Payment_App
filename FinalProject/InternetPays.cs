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
    public partial class Internet_Form : Form
    {
        public string PhoneNo;
        public string ClientName;
        public Internet_Form()
        {
            InitializeComponent();

            comboBox1.Items.Add("Landline Phone Payment");
            comboBox1.Items.Add("Home Internet Payment");
            comboBox1.Items.Add("New Subscription");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PhoneNo = textBox1.Text;
            ClientName = NameTextBox.Text;
           if ((comboBox1.Text == "Landline Phone Payment")&&(PhoneNo != ""))
            {
                Landline_Payment x = new Landline_Payment(PhoneNo,ClientName);
                x.Show();
            }
            else if ((comboBox1.Text == "Home Internet Payment")&& (PhoneNo != ""))
            {
                Home_Internet_Payment x = new Home_Internet_Payment(PhoneNo,ClientName);
                x.Show();
            }
            else if ((comboBox1.Text == "New Subscription")&& (PhoneNo != ""))
            {
                Home_Internet_Payment x = new Home_Internet_Payment(PhoneNo,ClientName);
                x.Show();
            }
            else
            {
                label4.Text = "Please Choose a Service";
            }

        }

        private void Internet_Form_Load(object sender, EventArgs e)
        {

        }

        private void Service_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pays x = new pays();
            x.Show();
        }

        private void Submit_Button_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text.Length < 9)&&(NameTextBox.Text !=""))
            {
                label2.Text = "Enter a Valid Phone Number";
            }else
            {
                label2.Hide();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
