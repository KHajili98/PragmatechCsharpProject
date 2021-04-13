using System;
using System.Threading;

namespace Week5.Task
{
    public static class Student
    {
        public static string AdVeSoyad()
        {
            Console.Write("Zehmet olmasa adinizi daxil edin: ");
            var ad = Console.ReadLine();
            Console.Write("Zehmet olmasa soyadinizi daxil edin: ");
            var soyad = Console.ReadLine();
            return ad + " " + soyad;
        }


        public static bool ImtahanBali(string netice, string imtahanNomresi)
        {
            int result;
           

            if (!Int32.TryParse(netice, out result))
            {
                Console.WriteLine(imtahanNomresi +" neticesini duzgun daxil edilmeyib!!!\nReqemlerden istifade edin!!!");
                Thread.Sleep(3000);
                return false;

            }

            if (!(Convert.ToInt32(netice) >= 0 && Convert.ToInt32(netice) <= 100))
            {
                Console.WriteLine(imtahanNomresi +" neticesini duzgun daxil edilmeyib!!!.\nnetice 0-100 arasi bir bal olmalidir !!! ");
                Thread.Sleep(3000);
                return false;

            }
            return true;


        }

        public static  void Netice(string netice1, string netice2, string netice3, string shexs)
        {

            Console.Clear();
            var  ortalama = (Convert.ToInt32(netice1) + Convert.ToInt32(netice3) + Convert.ToInt32(netice3)) / 3;

            var diplomIwi = ortalama >= 81 ? " KECMISINIZ " : "KECMEMISINZ";
            Console.WriteLine("Ad ve Soyad : " + shexs);
            Console.WriteLine("\n1-ci Netice : " + netice1);
            Console.WriteLine("2-ci Netice : " + netice2);
            Console.WriteLine("3-cu Netice : " + netice3);
            Console.WriteLine("\nOrtalama : " + ortalama);
            Console.WriteLine("\nDiplom iwine " + diplomIwi);
        }

     
    }
}
