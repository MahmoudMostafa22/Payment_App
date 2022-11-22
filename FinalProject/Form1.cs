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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Customer customer = new Customer();
            string mail = customer.getEmail;
            string pass = customer.getPass;
            mail = textBox1.Text;
            pass =textBox2.Text; 
            if (mail == "Admin@gmail.com" && pass == "12345678" )
            {
                Admin admin = new Admin();
                admin.Show();
            }
            else if (mail.Contains("@gmail.com")  && pass.Length == 8)
            {
                this.Hide();
                pays pay = new pays();
                pay.Closed += (s, args) => this.Close();
                pay.Show();
            }

            else
            {
                string D = "Error:Email should contain @gmail.com/password should be 8 digits";
                
                Error.Text = D ;

            }

        }
            private void label1_Click(object sender, EventArgs e)
            {

            }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void C(object sender, EventArgs e)
        {

        }
    }
    } 
