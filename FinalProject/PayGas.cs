using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class PayGas_Form : Form
    {
        public PayGas_Form()
        {
            InitializeComponent();
        }

        private void Home_Button_Click(object sender, EventArgs e)
        {
            Gas_Form s = new Gas_Form();
            s.Show();
        }

        private void PayGas_Form_Load(object sender, EventArgs e)
        {

        }

        private void VisaG_RB_CheckedChanged(object sender, EventArgs e)
        {
            if (VisaG_RB.Checked.Equals(true))
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

        private void OldRG_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CG_Button_Click(object sender, EventArgs e)
        {
            
        }
    }
}
