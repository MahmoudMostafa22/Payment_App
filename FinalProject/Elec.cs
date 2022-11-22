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
    public partial class Electricity_Form : Form
    {
        public Electricity_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Proceed_Button_Click(object sender, EventArgs e)
        {
            if ( CalCBillElec_RB.Checked.Equals(true))
            {
                Calculate_Your_Bill A = new Calculate_Your_Bill();
                A.Show();
            }
            if (PayElec_RB.Checked.Equals(true))
            {
                PayElec_Form B = new PayElec_Form();
                B.Show();
            }
            if (CElec_RB.Checked.Equals(true))
            {
                Charge_Card C = new Charge_Card();
                C.Show();
            }
        }
    }
}
