using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Customer
    {
        private string Name;
        private string Phone_number;
        private string Visa;
        private string Email;
        private string Password;

        public Customer() { }
        public Customer(string name, string phone_num, string visa)
        {
            this.Name = name;
            this.Phone_number = phone_num;
            this.Visa = visa;
        }
        public string getName
        {
            get { return Name;  }
            set { Name = value; }
        }
        public string getPhone
        {
            get { return Phone_number; }
            set { Name = value; }
        }
        public string getvisa
        {
            get { return Visa; }
            set { Name = value; }
        }
        public string getEmail
        {
            get { return Email; }
            set { Name = value; }
        }
        public string getPass
        {
            get { return Password; }
            set { Name = value; }
        }

    }
}
