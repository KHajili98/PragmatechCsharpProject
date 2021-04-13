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
                    Console.WriteLine("---------------------Menu-------------------");
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


       
    }
}
