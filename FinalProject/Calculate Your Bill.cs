using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Calculate_Your_Bill : Form
    {
        public Calculate_Your_Bill()
        {
            InitializeComponent();
        }

        private void BHElec_Button_Click(object sender, EventArgs e)
        {
            Electricity_Form A = new Electricity_Form();
            A.Show();
        }

        private void Calculate_Your_Bill_Load(object sender, EventArgs e)
        {

        }
    }
}
