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
    public partial class pays : Form
    {
        public pays()
        {
            InitializeComponent();
            
        }

        private void Netflix_click(object sender, EventArgs e)
        {
            
            this.Hide();
            Netflix netflix = new Netflix();
            netflix.Closed += (s, args) => this.Close();
            netflix.Show();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Internet_Form internet = new Internet_Form();
            internet.Closed += (s, args) => this.Close();
            internet.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Internet_Form internet = new Internet_Form();
            internet.Closed += (s, args) => this.Close();
            internet.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            PhoneCash phone = new PhoneCash();
            phone.Closed += (s, args) => this.Close();
            phone.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Electricity_Form elec = new Electricity_Form();
            elec.Closed += (s, args) => this.Close();
            elec.Show();
        }

        private void pays_Load(object sender, EventArgs e)
        {

        }

        private void GasButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gas_Form gas = new Gas_Form();
            gas.Closed += (s, args) => this.Close();
            gas.Show();

        }
    }
}
