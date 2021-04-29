using System;
using Week6.Tasks.Task_3;

namespace Week6.Tasks
{
    public class Customer
    {
        public  double Balance { get; set; } = 450;
        public bool HasBravoBonusCard { get; set; }
        
        public Order CustomerOrders { get; set; } = new Order();


        public static string AskPaymentMethod()
        {
            string CheckOutOptionInput;
            Console.WriteLine("Odeniwi nece yekunlawdirmaq isteyirsiniz? ** KARTLA ** / ** NEGD ** (k / n) ");

            while (true)
            {
                 CheckOutOptionInput = Console.ReadLine().ToUpper();
                Console.WriteLine("!!! Yuxarida qeyd olunan iki hefrden birini daxil edin !!! :");


                if (IsNullOrEmptyValidation(CheckOutOptionInput) ) 
                {
                    continue;
                }else if (CheckOutOptionInput == "K" || CheckOutOptionInput == "N")
                {
                    break;
                }

              

            }

            return CheckOutOptionInput;
        }





        public static bool IsNullOrEmptyValidation(string input)
        {
            return string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input);
        }




        public static void AskAndCheckBonusCard(Customer customer)
        {
            Console.WriteLine("Bonus kartiniz var ? istediyiniz duymeni veya ENTERI basdiqda varmiw kimi qebul edecek    //  X herfini basdiqda xeyr kimi qebul edeeckdir (Beli / Xeyr) ");
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

                int orderId, orderCount;
                Console.WriteLine("Zehmet olmasa istediyiniz mehsulun nomresini muvafiq olaraq daxil edin : ");

                while (true)
                {

                    var orderIdInput = Console.ReadLine(); // heleki yoxlamiram reqem olub olmadigini 


                    if (! Int32.TryParse(orderIdInput , out int result))
                    {
                        Console.WriteLine( "\n Zehmet olmasa mehsulun NOMRESINI DUZGUN DAXIL EDIN !!! : \n");
                        continue;
                    }
                    else
                    {
                        orderId = Convert.ToInt32(orderIdInput);
                        break;
                    }


                }




                while (true)
                {
                    Console.WriteLine($"Zehmet olmasa istediyiniz  '{orderId}' nomreli mehsuldan ne qeder istediyinizi muvafiq olaraq daxil edin : ");

                    var orderCountInput = Console.ReadLine(); // heleki yoxlamiram reqem olub olmadigini 


                    if (!Int32.TryParse(orderCountInput, out int result))
                    {
                        Console.WriteLine("\n Zehmet olmasa mehsulun SAYINI DUZGUN DAXIL EDIN !!! : \n");
                        continue;
                    }
                    else
                    {
                        orderCount = Convert.ToInt32(orderCountInput);
                        break;
                    }


                }
               
                customer.CustomerOrders.ProductIdAndCount.Add(orderId, orderCount);

                Console.WriteLine(Operation.ExitMessageForLoop("Mehsul Almaq"));
            } while (Console.ReadLine().ToUpper() != "X");
        }




    }

   
}
