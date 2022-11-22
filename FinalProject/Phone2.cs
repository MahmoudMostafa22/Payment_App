using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Phone2:Netflix
    {
        private string Phone_num;
        public Phone2() { }
        public Phone2(string num )  
        {
            this.Phone_num = num; 
        }
        public string getphone2
        {
            get { return Phone_num; }
            set 
            {
                Netflix Net = new Netflix();
                Phone_num = Net.phone_Num;
            }
        }

    }
}
