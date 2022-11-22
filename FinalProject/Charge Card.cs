using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Charge_Card : Form
    {
        public Charge_Card()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Electricity_Form A = new Electricity_Form();
            A.Show();
        }

        private void Charge_Card_Load(object sender, EventArgs e)
        {

        }
    }
}
