using System;
using System.Threading;

namespace Week4.Task
{

    partial class Program
    {
        public static class MultiplicationOperation
        {

            public static int  VurugunQebulEdilmesi( string vuruqNomresi)
            {
             
                while (true)
                {
                    Console.WriteLine(vuruqNomresi + " elave edin : ");
                    var InputVuruq = Console.ReadLine();
                  
                    if (Int32.TryParse(InputVuruq, out int number) )
                    {

                        if (Int32.Parse(InputVuruq) > 0)
                        {
                            return Int32.Parse(InputVuruq);
                            break;
                        }
                        else
                        {
                            Console.Write(vuruqNomresi + " menfi ededdir. Zehmet olmasa musbet eded daxil edin. ");
                            Thread.Sleep(3000);
                            Console.Clear();
                            continue;
                            
                        }
                    }
                    else
                    {
                        Console.Write(vuruqNomresi + " reqemlerden ferqli bir wey ola bilmez. Zehmet olmasa musbet eded daxil edin. ");
                        Thread.Sleep(3000);
                        Console.Clear();
                        continue;
                    }

                }
            }

            public static int VurmaEmeliyyati (int firstNumbet, int secondNumber)
            {
                var sum = 0;
                for (var i = secondNumber; i > 0; i--)
                {
                    sum += firstNumbet;
                }
                return sum;
            }

            public static void Netice(int hasil , int vuruq1, int vuruq2)
            {
                Console.WriteLine("Netice :\n"+vuruq1+" * "+vuruq2 +" = " + hasil );
            }

        }
    }
    }

