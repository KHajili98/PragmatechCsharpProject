using System;
using System.Collections.Generic;

namespace Week6.Tasks
{
    public class Menu
    {
        public string DeliveringDescription { get; } = "\nSifariwiniz 15 aznden az olarsa, catdirilma ucun YEKUN MEBLEGE  /*** 4.5 AZN ***\\ ELAVE OLUNACAQ";
        public string BravoBonusCardDescription { get; } = "EGer Bravo Bonus kartiniz varsa, YEKUN MEBLEGIN  /*** 2% ***\\ balansiniza geri qayidacaqdir\n";
        public string PaymentWith_Cash { get; } = "NEGD ---> odeniw zamani toplam EDV /*** 15% ***\\ balansiniza geri qaytarilacaqdir";
        public string PaymentWith_Card { get;  }= "KARTLA ---> odeniw zamani toplam EDV /*** 10% ***\\ balansiniza geri qaytarilacaqdir";
        public List<Product> AllProducts { get;  } = Product.GetAllProducts();
       
        
        
       
        public static void Show()
        {
            double price;
            Menu _menu =new  Menu();
            var productList = _menu.AllProducts;
            Console.WriteLine(@"\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\  BRAVO ONLINE MAGAZA   /\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\\/\/\/\ ");
            Console.WriteLine("\n\n"+_menu.PaymentWith_Cash);
            Console.WriteLine(_menu.PaymentWith_Card +"\n \n");
            Console.WriteLine("\t \t \t**********************   MENU   **********************\n");


            for (var i = 0; i < productList.Count; i++)
            {
                if (productList[i].Discount == 0)
                    price = productList[i].Price;
                else
                    price = (double)(productList[i].Price - (productList[i].Price * productList[i].Discount/100));

                Console.WriteLine(
                    $" | Id = {productList[i].Id}  " +
                    $"| Mehsulun adi : {productList[i].Name}    " +
                    $"| Olcu Vahidi : {productList[i].MeasuresType}  " +
                    $"|Endirim : {productList[i].Discount}%  " +
                    $"| Evvelki Qiymet : {productList[i].Price} AZN  " +
                    $"| Son Qiymet : {price} AZN |\n"
                    );

            }
            Console.WriteLine("\t \t \t**********************   MENU   **********************\n");

            Console.WriteLine(_menu.DeliveringDescription);
            Console.WriteLine(_menu.BravoBonusCardDescription);
            Console.WriteLine("\n\n!!! Bir mehsulu alarken sayini istediyiniz qeder daxil edin eks halda yeniden eyni mehsuldan ala bilmeyeceksiniz !!!");



        }


    }
}
