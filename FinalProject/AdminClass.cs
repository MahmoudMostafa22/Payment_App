using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    //Modify Prices By Admin
    class AdminClass 
    {
        private string Email;
        private string Password;
        private string price;
        private double Netflix_Price;
        private double GP30_Price;
        private double GP60_Price;
        private double GP61_Price;
        private double ElecP50_Price;
        private double ElecP100_Price;
        private double ElecP200_Price;
        private double ElecP350_Price;
        private double VatTax_Price;
        private double Tax_Price;
        public AdminClass() 
        {
            Netflix_Price = 60.00;
            GP30_Price = 2.35;
            GP60_Price = 3.1;
            GP61_Price = 3.6;
            ElecP50_Price = 0.48;
            ElecP100_Price = 0.58;
            ElecP200_Price = 0.77;
            ElecP350_Price = 1.06;
            VatTax_Price = 0.14;
            Tax_Price = 0.12;
        }
        public AdminClass(string mail , string pass)
        {
            this.Email = mail;
            this.Password = pass;
            Netflix_Price = 60.00;
            GP30_Price = 2.35;
            GP60_Price = 3.1;
            GP61_Price = 3.6;
            ElecP50_Price = 0.48;
            ElecP100_Price = 0.58;
            ElecP200_Price = 0.77;
            ElecP350_Price = 1.06;
            VatTax_Price = 0.14;
            Tax_Price = 0.12;
        }
        public string GetEmail
        {
            get { return Email;}
            set { Email = value; }
        }
        public string GetPass
        {
            get { return Password;}
            set { Password = value; }
        }
        //Modify Netflix Price
        public double NetflixPrice
        {
            get { return this.Netflix_Price; }
            set
            {
                if (value > 0)
                {
                    this.Netflix_Price = value;
                }
            }
        }
        //Modify Gas 30 C
        public double GP30Price
        {
            get { return this.GP30_Price; }
            set
            {
                if (value > 0)
                {
                    this.GP30_Price = value;
                }
            }
        }
        //Modify Gas 60
        public double GP60Price
        {
            get { return this.GP60_Price; }
            set
            {
                if (value > 0)
                {
                    this.GP60_Price = value;
                }
            }
        }
        //Modify Gas Above 60
        public double GP61Price
        {
            get { return this.GP61_Price; }
            set
            {
                if (value > 0)
                {
                    this.GP61_Price = value;
                }
            }
        }
        //Modify Electricity 50KW Price
        public double ElecP50Price
        {
            get { return this.ElecP50_Price; }
            set
            {
                if (value > 0)
                {
                    this.ElecP50_Price = value;
                }
            }
        }
        //Modify Electricity 100KW Price
        public double ElecP100Price
        {
            get { return this.ElecP100_Price; }
            set
            {
                if (value > 0)
                {
                    this.ElecP100_Price = value;
                }
            }
        }
        //Modify Electricity 200KW Price
        public double ElecP200Price
        {
            get { return this.ElecP200_Price; }
            set
            {
                if (value > 0)
                {
                    this.ElecP200_Price = value;
                }
            }
        }
        //Modify Electricity 350KW Price
        public double ElecP350Price
        {
            get { return this.ElecP350_Price; }
            set
            {
                if (value > 0)
                {
                    this.ElecP350_Price = value;
                }
            }
        }
        public double VatTaxPrice
        {
            get { return this.VatTax_Price; }
            set
            {
                if (value > 0)
                {
                    this.VatTax_Price = value;
                }
            }
        }
        public double TaxPrice
        {
            get { return this.Tax_Price; }
            set
            {
                if (value > 0)
                {
                    this.Tax_Price = value;
                }
            }
        }

    }
}
