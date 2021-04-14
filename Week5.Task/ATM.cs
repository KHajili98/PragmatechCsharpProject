using System;
using System.Collections;
using System.Threading;

namespace Week5.Task
{
    public  static class ATM
    {
        private static int Password = 1234;
        private static int Balance = 1000;
        private static SortedList Tarixce = new SortedList();


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

        public static byte OperationChoosen (){ 
         byte operation;
                while (true)
                {
                
                    var input = Console.ReadLine();
                    byte inputForTryParse;
                    if (Byte.TryParse(input, out  inputForTryParse))
                    {
                        operation = byte.Parse(input);
                        return operation;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Emeliyyat nomresini daxil ederken REQEMLERDEN ISTIFADE EDIN !!! { 1 - 3 }");
                        Thread.Sleep(3000);
                        Console.Clear();
                        ATM.Menu();
                        continue;
                    }
                }}

        public static void BalansinYoxlanilmasi()
        {
            Console.Clear();
            Console.WriteLine("Balansinizdaki mebleg : " + Balance +" AZN");
        }

        public static void Mexaric()
        {
            
            int result;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("-----------------Istediyiniz meblegi daxil edin (emeliyyatdan cixmaq ucun \"x\" duymesine basa bilersiniz) :");
                var inputCash = Console.ReadLine();
                if (inputCash.ToUpper() == "X") break;
                
                if (Int32.TryParse(inputCash, out result) && (Int32.Parse(inputCash) > 0 && Int32.Parse(inputCash) <= 1000)) // mexaric meblegi check edir herf ve 1-1000 arasi oldugunu
                {
                    DateTime withdrawTime = DateTime.Now;

                    if (Balance > Int32.Parse(inputCash)) // balansdaki pulla muqayise edir
                    {
                        Balance -= Int32.Parse(inputCash);
                        Console.WriteLine("Pulunuzu goturun : ");
                        OutPutCash(inputCash, withdrawTime);
                        Tarixce.Add(withdrawTime, Int32.Parse(inputCash)); // cixariw ucun emeliyyatlari elave edir
                        break;
                    }
                    else
                    {
                        Console.WriteLine("-------------------balansinizda kifayet qeder mebleg yoxdur. Balans :\t" + Balance + " AZN");
                        Thread.Sleep(3000);
                        Console.Clear();
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("!!!!!!!!!!        Daxil edilen mebleg yanliwdir       !!!!!!!!!!");
                    Console.WriteLine("********** 1-1000 daxil olan meblegi reqem olaraq qeyd edin  **********");
                    Thread.Sleep(3000);
                    continue;
                }
            }
               
         

        }



        public static void OutPutCash( string inputCash , DateTime operationTime)
        {
            while (true)
            {
                var bankNotes = new int[] { 200, 100, 50, 20, 10, 5, 1 };
                int inputMoney = Convert.ToInt32(inputCash);
                if (string.IsNullOrEmpty(Convert.ToString(inputMoney)) || string.IsNullOrWhiteSpace(Convert.ToString(inputMoney))) break;
                for (int i = 0; i < bankNotes.Length; i++)
                {
                    if (inputMoney >= bankNotes[i])
                    {
                        int bankNotesCount = inputMoney / bankNotes[i];
                        inputMoney -= bankNotesCount * bankNotes[i];
                        Console.WriteLine(bankNotesCount + " eded - " + bankNotes[i] + " AZN");
                    }
                }
                break;
            }
        }



        public static void BalansinCixariwi()
        {
            Console.Clear();
            if (Tarixce.Count == 0)
            {
                Console.WriteLine("... Hesabda hec bir emeliyyat edilmeyib ....");
            }
            else
            {
                Console.WriteLine("Mexaricler birinci emeliyyatdan sonuncu emeliyyata dogru siralanmiwdir  :\n");
                int i=1;

                foreach (DictionaryEntry item in Tarixce)
                {
                    Console.WriteLine($"{i++}). " + item.Value + " AZN" + "\t TARIX-->>  " + item.Key);
                }


            }
            
        }

    }
}
