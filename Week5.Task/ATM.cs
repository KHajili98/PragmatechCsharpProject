using System;
using System.Threading;

namespace Week5.Task
{
    public  static class ATM
    {
        private static int Password = 1234;
        private static int Balance = 1000;


        public static void LogIn ()
        {
            string inputPassword;
            int result;
            while (true)
            {
               Console.WriteLine("************************* Zehmet olmasa wifrenizi daxil edin : **********************************");
               inputPassword = Console.ReadLine();
               if(inputPassword == Password.ToString() && Int32.TryParse(inputPassword, out result) && inputPassword.Length == 4)
                {
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.WriteLine("!!!!!!!!!!        WIFRE YANLIWDIR        !!!!!!!!!!");
                    Console.WriteLine("********** Wifre 4 reqemden ibaret olmalidir  **********");
                    Thread.Sleep(3000);
                    Console.Clear();
                    continue;
                }

            }
        }


        public static void Menu()
        {
            Console.WriteLine("---------------------Menu-------------------");
            Console.WriteLine("1.BALANSIN YOXLANILMASI");
            Console.WriteLine("2.MEXARIC");
            Console.WriteLine("3.BALANSIN CIXARIWI\n");

            Console.Write("\nEmeliiyat nomresini daxil edin:\t");
        }

        public static void BalansinYoxlanilmasi()
        {
            Console.WriteLine("Balans " + Balance);
        }

        public static void Mexaric()
        {
            Console.WriteLine("pulunuzu cekin ");
        }

        public static void BalansinCixariwi()
        {
            Console.WriteLine("cixariw ");
        }

    }
}
