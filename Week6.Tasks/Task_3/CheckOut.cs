using System;
using System.Collections;

namespace Week6.Tasks
{
    public class CheckOut
    {
        public double TotalDiscount { get; set; }
        public double TotalEDV { get; set; }
        public double TotalPayment { get; set; }
        public string PaymentMethod { get; set; }
        public DateTime Time { get; set; }
        public int ReceiptId { get; set; }
        public bool AddDeliveringPayment { get; set; }


        public static void PrepareReceipt(Product product, Customer customer, CheckOut checkOut)
        {
            Console.WriteLine("---------------------------------------    QEBZINIZ       --------------------------------------------------------------------------\n");

            foreach (DictionaryEntry order in customer.CustomerOrders.ProductIdAndCount)// toplam mebleg 
            {
                foreach (Product product1 in Product.GetAllProducts())
                {

                    if ((int)order.Key == product1.Id)// discount yoxlama
                    {
                        double priceOfProductAfterDiscount;

                        if (product1.Discount == 0)
                            priceOfProductAfterDiscount = product1.Price;
                        else
                            priceOfProductAfterDiscount = (double)(product1.Price - (product1.Price * product1.Discount / 100));

                        Console.WriteLine(
                         $"| Mehsulun adi : {product1.Name}    " +
                         $"| Miqdar  : {order.Value}    " +
                         $"| Qiymet : {priceOfProductAfterDiscount} AZN |" +
                         $"| EDV : {product1.EDV} % |" +
                         $"| Toplam : {priceOfProductAfterDiscount * (int)order.Value} Azn |"
                    );
                        // sizin qazanciniz hissesi ucun 
                        if (product1.Discount == 0)
                        {
                            Console.WriteLine($"Sizin Qazanciniz ===================================== 0 AZN\n");
                        }
                        else
                        {
                            {
                                Console.WriteLine($"Sizin Qazanciniz ===================================== {(priceOfProductAfterDiscount - product.Price) * (int)order.Value} AZN\n");
                            }

                        }

                    }
                }
            }

            if (checkOut.AddDeliveringPayment)
            {
                Console.WriteLine($"Catdirilma ======================= + 4.5 AZN");
            }

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------\n");
            Console.WriteLine($"ENDIRIM ======================= {checkOut.TotalDiscount} AZN");
            Console.WriteLine($"VERGI EDV  ======================= {checkOut.TotalEDV} AZN");
            Console.WriteLine($"YEKUN MEBLEG ======================= {checkOut.TotalPayment} AZN");
            Console.WriteLine("Tarix ==================================== " + checkOut.Time);
            Console.WriteLine($"Qebz nomresi ======================== {checkOut.ReceiptId}");
            Console.WriteLine($"ODENIW USULU=========================== {checkOut.PaymentMethod}");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------\n");

            Console.WriteLine("\nCari Balansiniz =====================================  " + customer.Balance + "AZN");


        }


        public static double CalculateTotalDiscount(Customer customer, CheckOut checkOut)
        {
            double allDiscount = 0;

            foreach (var discount in customer.CustomerOrders.AllDiscounts)
            {
                allDiscount += discount;
            }
            checkOut.TotalDiscount = allDiscount;
            return checkOut.TotalDiscount;
        }

        public static void PaymentMethodAndTimeAdding(string CheckOutOptionInput, CheckOut checkOut)
        {
            if (CheckOutOptionInput.Equals("K"))
            {
                checkOut.PaymentMethod = "Kartla odenilib";

            }
            else if (CheckOutOptionInput.Equals("N"))
            {
                checkOut.PaymentMethod = "Negd odenilib";
            }
            checkOut.ReceiptId++;
            checkOut.Time = DateTime.Now;
        }
    }
}
