using System;

namespace Week5.Task
{
    public static class Student
    {
        public static void AdVeSoyad()
        {
            Console.Write("Zehmet olmasa adinizi daxil edin: ");
            var ad = Console.ReadLine();
            Console.Write("Zehmet olmasa soyadinizi daxil edin: ");
            var soyad = Console.ReadLine();
            var shexs = ad + " " + soyad;
        }

        public static void ImtahanlarinDaxilEdilmesi()
        {
            while (true)
            {
                Console.Clear();
                Console.Write("\nZehmet olmasa 1-ci imtahan neticesini elave edin :");
                var netice1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Zehmet olmasa 2-ci imtahan neticesini elave edin :");
                var netice2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Zehmet olmasa 3-cu imtahan neticesini elave edin :");
                var netice3 = Convert.ToInt32(Console.ReadLine());

                if(netice1.GetType() != typeof(int) || !(netice1>= 0 && netice1 <=100))
                {
                    Console.WriteLine("Birinci imtahan neticesini duzgun daxil edin (0-100 arasi bir bal olmalidir ) : ");
                    continue;
                }else if(netice2.GetType() == typeof(int) && (netice2 >= 0 && netice2 <= 100))
                {
                    Console.WriteLine("IKinci imtahan neticesini duzgun daxil edin (0-100 arasi bir bal olmalidir ) :  ");
                    continue;


                }
                else if (netice3.GetType() == typeof(int) && (netice3 >= 0 && netice3 <= 100))
                {
                    Console.WriteLine("Ucuncu imtahan neticesini duzgun daxil edin (0-100 arasi bir bal olmalidir ) :  "); continue;


                }
            }


        }
    }
}
