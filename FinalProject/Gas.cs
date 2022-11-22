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
    public partial class Gas_Form : Form
    {
        public Gas_Form()
        {
            InitializeComponent();

        }

        private void Proceed_Button_Click(object sender, EventArgs e)
        {
            if (CalCBillGas_RB.Checked.Equals(true))
            {
                CalcGas_Form A = new CalcGas_Form();
                A.Show();
            }
            if (PayGas_RB.Checked.Equals(true))
            {
                PayGas_Form B = new PayGas_Form();
                    B.Show();
            }
            if ( CGas_RB.Checked.Equals(true))
            {
                Charge_Account_Form C = new Charge_Account_Form();
                    C.Show();
            }
        }

        private void Gas_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
