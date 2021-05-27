using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorForAmountPayable
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public  string ShowNameAndPrice()
        {
           // Price += Price * 0.18;
            string result = Name +"\t"+ Price.ToString();
            return result;
        }
    }
}
