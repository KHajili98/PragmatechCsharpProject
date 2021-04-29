using System;

namespace Week6.Tasks
{
    public class Customer
    {
        public  double Balance { get; set; } = 450;
        public bool HasBravoBonusCard { get; set; }
        
        public Order CustomerOrders { get; set; } = new Order();


        public static string AskPaymentMethod()
        {
            Console.WriteLine("Odeniwi nece yekunlawdirmaq isteyirsiniz? ** KARTLA ** / ** NEGD ** (k / n) ");
            var CheckOutOptionInput = Console.ReadLine().ToUpper();
            return CheckOutOptionInput;
        }
        public static void AskAndCheckBonusCard(Customer customer)
        {
            Console.WriteLine("Bonus kartiniz var ? **istediyiniz duymeni basin ** / ** X ** (Beli / Xeyr) ");
            var BonusKartInput = Console.ReadLine().ToUpper();
            Customer.CheckBonusCard(BonusKartInput, customer);
        }

        public static void CheckBonusCard(string input, Customer customer)
        {
            if (!input.Equals("X"))
            {
                customer.HasBravoBonusCard = true;
            }
        }

        public static void TakeOrder(Customer customer)
        {
            do
            {
                Console.WriteLine("Zehmet olmasa istediyiniz mehsulun nomresini muvafiq olaraq daxil edin : ");
                int orderId = Convert.ToInt32(Console.ReadLine()); // heleki yoxlamiram reqem olub olmadigini 
                Console.WriteLine($"Zehmet olmasa istediyiniz mehsulun '{orderId}' ne qeder istediyinizi muvafiq olaraq daxil edin : ");
                int orderCount = Convert.ToInt32(Console.ReadLine()); // heleki yoxlamiram reqem olub olmadigini 
                customer.CustomerOrders.ProductIdAndCount.Add(orderId, orderCount);

                Console.WriteLine("Yeniden mehsul almaq isteyirsiniz? **istediyiniz duymeni basin ** / ** X ** (Beli / Xeyr)");
            } while (Console.ReadLine().ToUpper() != "X");
        }



    }

   
}
