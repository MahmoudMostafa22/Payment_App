using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class CalcGas_Form : Form
    {
        public CalcGas_Form()
        {
            InitializeComponent();
        }

        private void CalcGas_Form_Load(object sender, EventArgs e)
        {

        }

        private void BHG_Button_Click(object sender, EventArgs e)
        {
            Gas_Form A = new Gas_Form();
            A.Show();

        }
    }
}
