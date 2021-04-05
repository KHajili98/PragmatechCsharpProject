using System;

namespace Week4.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            #region tasks

            #region 1.
            /*
             * asagida verilen arrayin elementlerini artan sira ile
             * ekrana cap edin
             *
             * qeyd : manual edilecek/ hazir methodlarsiz
             */

            // ------------------------------------------- Solution :

            /*
                        int[] intArray = { 2, 9, 4, 3, 5, 1, 7 };
                        int temp = 0;



                        for (int i = 0; i < intArray.Length; i++)
                        {
                            for (int j = i+1; j < intArray.Length; j++)
                            {
                                if (intArray[i] >intArray[j])
                                {
                                    temp = intArray[i];

                                    intArray[i] = intArray[j];
                                    intArray[j] = temp;
                                }
                            }
                        }

                        Console.WriteLine("Elementlerin artan sira ile manual wekilde sort edilmesi : \n");

                        foreach (var item in intArray)
                        {
                            Console.WriteLine(item);
                        }
            */
            #endregion

            #region 2.
            /*
             * asagida verilen arrayin elementlerini azalan sira ile
             * ekrana cap edin
             *
             * qeyd : manual edilecek/ hazir methodlarsiz
             */

            // ------------------------------------------- Solution :
            /*
                        int[] intArray = { 2, 9, 4, 3, 5, 1, 7 };
                        int temp = 0;


                        for (int i = 0; i < intArray.Length; i++)
                        {
                            for (int j = i + 1; j < intArray.Length; j++)
                            {
                                if (intArray[i] < intArray[j])
                                {
                                    temp = intArray[i];

                                    intArray[i] = intArray[j];
                                    intArray[j] = temp;
                                }
                            }
                        }

                        Console.WriteLine("Elementlerin azalan sira ile manual wekilde sort edilmesi : \n");

                        foreach (var item in intArray)
                        {
                            Console.WriteLine(item);
                        }
            */


            #endregion

            #region 3. geriden geriden
            /*
             * asagida verilen arrayin elementlerini tersine duzerek
             * ekrana cap edin
             *
             * qeyd : manual edilecek/ hazir methodlarsiz
             */

            //----------------------------------------------------- Solution :

            /*
                        int[] arr = { 5, 6, 9, 12, 15, 7, 3, 20, 14, 36, 24 };
                        int temp = 0;
                        var length = arr.Length;

                        Console.WriteLine("Arrayin manual wekilde reverse olunmasi :");
                        Console.WriteLine();
                        Console.WriteLine("Ilkin array  :");

                        foreach (var item in arr)
                        {
                            Console.Write(item + "\t");
                        }



                        for (int i = 0; i < length / 2 ; i++)
                        {
                            temp = arr[i];
                            arr[i] = arr[length -i- 1];
                            arr[length -i- 1] = temp;
                        }
                        Console.WriteLine();
                        Console.WriteLine("\nCevrilmiw array  : ");

                        foreach (var item in arr)
                        {
                            Console.Write(item+"\t");
                        }
                        Console.WriteLine();
            */

            #endregion

            #region 4. para pul el cirki
            /*
             * istifadeci bankomatdan cixarmaq istediyi meblegi daxil edir(sonsuz sayda, emeliyyati dayandirmagida nezere alin).
             * daxil edilen meblege uygun console-a eskinaslari sayi ile cap edirik.
             *
             * eskinaslar : 200, 100, 50, 20, 10, 5, 1
             *
             * meselen daxil edilen pul miqdari 45 dir:
             * 2 eded 20 azn
             * 1 eded 5 azn
             *
             */

            //----------------------------------------------------- Solution :

            /*
            while (true)
            {
                var bankNotes = new int[] { 200, 100, 50, 20, 10, 5, 1 };
                Console.Write("bankomatdan cixarmaq istediyi meblegi daxil edin : ");
                int inputMoney = Convert.ToInt32(Console.ReadLine());
                if (string.IsNullOrEmpty(Convert.ToString(inputMoney)) || string.IsNullOrWhiteSpace(Convert.ToString(inputMoney)))  break;

                for (int i = 0; i < bankNotes.Length; i++)
                {
                    if (inputMoney >= bankNotes[i])
                    {
                        int bankNotesCount = inputMoney / bankNotes[i];
                        inputMoney -= bankNotesCount * bankNotes[i];
                        Console.WriteLine(bankNotesCount + " - " + bankNotes[i]);
                    }
                }
            }
            */

             #endregion

            #region 5. tek ededlerin kublari cemi
            /*
             * 1-10 qeder tek ededlerin kublarinin cemini yazin.
            */
             //----------------------------------------------------- Solution :
                /*
                int sum = 0;
                for (int i = 1; i <= 10; i++)
                {
                    if (i % 2 == 1)
                    {
                        sum = sum + (i * i * i);
                    }
                }
                Console.WriteLine("1-10 qeder tek ededlerin kublarinin cemini : "+sum);
                 */

    #endregion

            #region 6. yas hesablanmasi

                /*
                 * dogum tarixini daxil eden istifedecinin
                 * yasini hesablayib ekrana cap edin
                 */

                 //----------------------------------------------------- Solution :

             /*
                DateTime today = DateTime.Today;

                Console.WriteLine("dogum tarixini daxil edin (gun,ay,il) : ");

                string birthDay=  Console.ReadLine();

                string[] birthDayArray = new string[3];

                birthDay.Split(',').CopyTo(birthDayArray, 0);

                var age = today.Year - Convert.ToInt32(birthDayArray[2]);

                Console.WriteLine("Sizin yawiniz : "+age);
               */






    #endregion

            #region 7.
                 /*
                 * istifadeci terefinden daxil edilen iki musbet ededin hasilini vurma emeliyyati ile
                  * deyil toplama emeliyyati ile ekrana cap edin.
                 */

                 //----------------------------------------------------- Solution :

                 /*
                int sum = 0;
                int firstNumber = 0;
                int  secondNumber = 0;



                while (true)
                {
                    Console.WriteLine("Birinci vurugu elave edin : ");
                     firstNumber = Convert.ToInt32(Console.ReadLine());
                    if (firstNumber < 0)
                        Console.Write("Birinci vuruq musbet eded deyil. Zehmet olmasa musbet eded daxil edin. ");
                    else
                        break;
                }

                while (true)
                {


                    Console.WriteLine("Ikinci vurugu elave edin : ");
                     secondNumber = Convert.ToInt32(Console.ReadLine());
                    if (secondNumber < 0)
                        Console.Write("Ikinci vuruq musbet eded deyil. Zehmet olmasa musbet eded daxil edin. ");
                    else
                        break;
                }

                for (var i = secondNumber; i > 0; i--)
                {
                    sum += firstNumber;
                }

                Console.WriteLine("Daxil edilen vuruqlarin hasili : " +sum);
                */



             #endregion
             #endregion
}
    }
    }

