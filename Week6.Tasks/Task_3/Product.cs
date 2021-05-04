using System.Collections.Generic;

namespace Week6.Tasks
{
    public class Product{
        public int Id { get; set; }
        public string Name { get; set; }
        public string MeasuresType { get; set; }
        public  double Price { get; set; }
        public double EDV { get; set; } = 0;
        public int Discount { get; set; } = 0;


       
        public static List<Product> GetAllProducts()
        { 
            List<Product> _allProducts = new List<Product>();
            _allProducts.Add(
                new Product {
                    Id =1,
                    Name = "un",
                    MeasuresType = "kq",
                    Price = 1.5,
                    EDV = 18,
                    Discount =10
                    }
                );

            _allProducts.Add(
               new Product
               {
                   Id=2,
                   Name = "yumurta",
                   MeasuresType = "eded",
                   Price = 0.15,
                   EDV = 18,
               }
               );
            _allProducts.Add(
               new Product
               {
                   Id=3,
                   Name = "Vodka",
                   MeasuresType = "eded",
                   Price = 70.0,
                   Discount = 30
               }
               );

            _allProducts.Add(
             new Product
             {
                 Id = 4,
                 Name = "Cay",
                 MeasuresType = "eded",
                 Price = 5.0,
             }
             ); 
            _allProducts.Add(
            new Product
            {
                Id = 5,
                Name = "Qab",
                MeasuresType = "eded",
                Price = 50.0,
                Discount = 10,
                EDV = 18
            }
            ); ;


            return _allProducts;
        }
    }
}
