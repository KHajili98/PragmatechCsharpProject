using System.Collections.Generic;

namespace Week6.Tasks
{
    public class Menu
    {
        public string DeliveringDescription { get; set; }
        public string BravoBonusCardDescription { get; set; }
        public string PaymentWith_Cash { get; set; }
        public string PaymentWith_Card { get; set; }
        public List<Product> AllProducts { get; } = Product.GetAllProducts();


    }
}
