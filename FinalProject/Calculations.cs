using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Calculations 
    {
        private int OldReading;
        private int NewReading;
        AdminClass X = new AdminClass();

        public Calculations() { }
        public Calculations(int oldR, int newR)
        {
            OldReading = oldR;
            NewReading = newR;
        }
        public double CalcYourBillGas(double diff)
        {
           
            double res;
            Console.Write(diff);
            if (diff <= 30)
            {
                res = diff * X.GP30Price;
            }
            else if (diff <= 60)
            {
                res = diff * X.GP60Price;
            }
            else
            {
                res = diff * X.GP61Price;
            }
            return res;
        }
        public double CalcYourBillElec(double diff)
        {
            double res;
            Console.Write(diff);
            if (diff <= 50)
            {
                res = diff * X.ElecP50Price;
            }
            else if (diff <= 100)
            {
                res = diff * X.ElecP100Price;
            }
            else if (diff <= 200)
            {
                res = diff * X.ElecP200Price;
            }
            else
            {
                res = diff * X.ElecP350Price;
            }

            return res;
        }



    }
}
