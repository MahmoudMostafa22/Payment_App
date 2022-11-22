using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Landline_Payment : Form
    {
        public string Phone;
        public string ClientName;
        private AdminClass X = new AdminClass();
        public Landline_Payment(string PhoneNo,string name)
        {
            InitializeComponent();
            Phone = PhoneNo;
            ClientName = name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Internet_Form A = new Internet_Form();
            A.Show();

        }

        private void Landline_Payment_Load(object sender, EventArgs e)
        {

        }

        private void VisaLandLine_RB_CheckedChanged(object sender, EventArgs e)
        {
            if (VisaLandLine_RB.Checked.Equals(true))
            {
                VisaTextBox.Show();
                if (VisaTextBox.Text.Length < 14)
                {
                    ErrorsLabel.Text = "Enter a Valid Card Number";
                }
            }
            else
            {
                VisaTextBox.Hide();
            }
        }

        private void PayLandLine_Label_Click(object sender, EventArgs e)
        {

        }
        private void Proceed_Button_Click(object sender, EventArgs e)
        {
            double Cost = Convert.ToDouble(PayLandLine_Label.Text);
            reciet z = new reciet(ClientName,Phone,Cost,X.TaxPrice,Cost+Cost*X.TaxPrice);
            z.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = listBox1.SelectedItem.ToString();
            switch (a)
            {

                case "500 Minutes Plan (25 Pounds)":
                    PayLandLine_Label.Text = "25";
                    break;
                case "1000 Minutes Plan (40 Pounds)":
                    PayLandLine_Label.Text = "40";
                    break;
                case "2000 Minutes Plan (60 Pounds)":
                    PayLandLine_Label.Text = "60";
                    break;
                case "3000 Minutes Plan (100 Pounds)":
                    PayLandLine_Label.Text = "100";
                    break;

                default:
                    PayLandLine_Label.Text = "   ";
                    break;
            }
        }
    }
}
