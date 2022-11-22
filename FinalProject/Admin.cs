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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        AdminClass x = new AdminClass();
        private void Admin_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pays NewPrice = new pays();
            NewPrice.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            x.NetflixPrice = Convert.ToDouble(textBox1.Text);
        }

        private void GP30_TextBox_TextChanged(object sender, EventArgs e)
        {
            x.GP30Price = Convert.ToDouble(GP30_TextBox.Text);
        }

        private void GP60_TextBox_TextChanged(object sender, EventArgs e)
        {
            x.GP60Price = Convert.ToDouble(GP60_TextBox.Text);
        }

        private void GP61_TextBox_TextChanged(object sender, EventArgs e)
        {
            x.GP61Price = Convert.ToDouble(GP61_TextBox.Text);
        }

        private void ElecP50_TextBox_TextChanged(object sender, EventArgs e)
        {
            x.ElecP50Price = Convert.ToDouble(ElecP50_TextBox.Text);
        }

        private void ElecP100_TextBox_TextChanged(object sender, EventArgs e)
        {
            x.ElecP100Price = Convert.ToDouble(ElecP100_TextBox.Text);
        }

        private void ElecP200_TextBox_TextChanged(object sender, EventArgs e)
        {
            x.ElecP200Price = Convert.ToDouble(ElecP200_TextBox.Text);
        }

        private void ElecP350_TextBox_TextChanged(object sender, EventArgs e)
        {
            x.ElecP350Price = Convert.ToDouble(ElecP350_TextBox.Text);
        }

        private void TaxValue_TextBox_TextChanged(object sender, EventArgs e)
        {
            x.TaxPrice = Convert.ToDouble(TaxValue_TextBox.Text);
        }

        private void VatTaxValue_TextBox_TextChanged(object sender, EventArgs e)
        {
            x.VatTaxPrice = Convert.ToDouble(VatTaxValue_TextBox.Text);
        }
    }
}
