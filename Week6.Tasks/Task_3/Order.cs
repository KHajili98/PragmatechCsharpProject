using System.Collections;
using System.Collections.Generic;

namespace Week6.Tasks
{
    public class Order
    {
        public Hashtable ProductIdAndCount { get; set; } = new Hashtable();
        public List<double> Prices { get; set; } = new List<double>();
        public List<double> AllEDV { get; set; }=new List<double>();
        public List<double> AllDiscounts { get; set; }=   new List<double>();
        public List<Product> AllProducts { get; } = Product.GetAllProducts();
    }
}
