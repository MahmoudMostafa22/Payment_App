using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Home_Internet_Payment : Form
    {
        public string Phone;
        public string ClientName;
        private AdminClass X = new AdminClass();
        public Home_Internet_Payment( string PhoneNo,string ClientName)
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Internet_Form A = new Internet_Form();
            A.Show();
        }

        private void PayInternet_Label_Click(object sender, EventArgs e)
        {

        }

        private void Home_Internet_Payment_Load(object sender, EventArgs e)
        {

        }

        private void NetPlans_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = NetPlans_ListBox.SelectedItem.ToString();
            switch (a)
            {

                case "140 GigaByte Plan (180 Pounds)":
                    PayInternet_Label.Text = "180";
                    break;
                case "200 GigaByte Plan(200 Pounds)":
                    PayInternet_Label.Text = "200";
                    break;
                case "240 GigaByte Plan(280 Pounds)":
                    PayInternet_Label.Text = "280";
                    break;
                case "280 GigaByte Plan(340 Pounds)":
                    PayInternet_Label.Text = "340";
                    break;
                default:
                    PayInternet_Label.Text = "   ";
                    break;
            }
        }

        private void Proceed_Button_Click(object sender, EventArgs e)
        {

                double Cost = Convert.ToDouble(PayInternet_Label.Text);
                reciet z = new reciet(ClientName, Phone, Cost, X.TaxPrice, Cost + Cost * X.TaxPrice);
                z.Show();
            
            
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
    }
    
}
