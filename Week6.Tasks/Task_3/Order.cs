using System.Collections.Generic;

namespace Week6.Tasks
{
    public class Order
    {
        public List<int> ProductId { get; set; } = new List<int>();
        public List<double> Prices { get; set; } = new List<double>();
        public List<double> AllEDV { get; set; }=new List<double>();
        public List<double> AllDiscounts { get; set; }=   new List<double>();
        public List<Product> AllProducts { get; } = Product.GetAllProducts();
    }
}
