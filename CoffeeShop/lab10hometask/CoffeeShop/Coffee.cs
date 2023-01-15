using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public class DLL
    {
       public string Amountavailable(double amount,double MBalance)
        {
            string res = "";
           
            if (amount < 0)
            {
                res = "Price less than zero";
               
            }
            if (amount > MBalance)
            {
                res = "Price Exceeds Balance";
               
            }
            else
            {
                double n = MBalance;
                MBalance = MBalance - amount;
                res = "Order Placed";
               
            }
            return res;
        }

    }
}
