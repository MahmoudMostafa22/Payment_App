using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Email :Form1 
    {
        public string ID;
        public int Password;
        public int Confirm_password;
        public Email()
        {
        }
        public Email(string id , int pass,int conf_pass)
        {
            this.ID = id;
            this.Password = pass;
            this.Confirm_password = conf_pass; 
        }

        public string EmailID
        {
            get
            {
               
                return ID; 
            }
            set
            {
                ID = value;
            }
        }
        public int  EmailPass
        {
            get
            {
                return Password;
            }
        }
        public int Emailconf
        {
            get
            {
                return Confirm_password;
            }
        }
    }
}
