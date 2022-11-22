using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class PayElec_Form : Form
    {
        public PayElec_Form()
        {
            InitializeComponent();
        }

        private void Home_Button_Click(object sender, EventArgs e)
        {
            Electricity_Form A = new Electricity_Form();
            A.Show();
        }

        private void PayElec_Form_Load(object sender, EventArgs e)
        {

        }

        private void CElec_Button_Click(object sender, EventArgs e)
        {
            
        }
    }
}
