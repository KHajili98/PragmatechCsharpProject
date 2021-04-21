using System;
using System.Collections.Generic;
using System.Threading;

namespace Week5.Task
{
    public static class Student
    {

        public static string AdVeSoyad()
        {
            string ad, soyad;
            ad = inputAd();
            soyad = InputSoyad();

            return ad + " " + soyad;
            
        }

        private static string InputSoyad()
        {
            string soyad;
            while (true)
            {
                Console.Clear();
                Console.Write("Zehmet olmasa soyadinizi daxil edin: ");
                soyad = Console.ReadLine();
                if (IsNullOrEmptyValidation(soyad))
                {
                    Console.WriteLine("Zehmet olmasa soyadinizi daxil edin. Soyad mutleq daxil edilmelidir");
                    Thread.Sleep(3000);

                    continue;
                }
                break;

            }

            return soyad;
        }

        private static string inputAd()
        {
            string ad;
            while (true)
            {
                Console.Clear();
                Console.Write("Zehmet olmasa adinizi daxil edin: ");

                ad = Console.ReadLine();
                if (IsNullOrEmptyValidation(ad))
                {
                    Console.WriteLine("Zehmet olmasa adinizi daxil edin. Ad mutleq daxil edilmelidir");
                    Thread.Sleep(3000);

                    continue;
                }
                break;

            }

            return ad;
        }

        public static bool ImtahanBali(string netice, string imtahanNomresi)
        {

            if (IsNullOrEmptyValidation(netice)) return true;

            if (!Decimal.TryParse(netice, out decimal result))
            {
                Console.WriteLine(imtahanNomresi + " neticesini duzgun daxil edilmeyib!!!\nReqemlerden istifade edin!!!");
                Thread.Sleep(3000);
                return false;

            }

            if (IsValidExamPoint(netice))
            {
                Console.WriteLine(imtahanNomresi + " neticesini duzgun daxil edilmeyib!!!.\nnetice 0-100 arasi bir bal olmalidir !!! ");
                Thread.Sleep(3000);
                return false;

            }
            return true;
        }

        public static void CheckedDefaultExamMark(ref string netice1, ref string netice2, ref string netice3)
        {
            if (Student.IsNullOrEmptyValidation(netice1)) netice1 = "51";
            if (Student.IsNullOrEmptyValidation(netice2)) netice2 = "51";
            if (Student.IsNullOrEmptyValidation(netice3)) netice3 = "51";
        }
        public static bool IsNullOrEmptyValidation(string netice)
        {
            return string.IsNullOrEmpty(netice) || string.IsNullOrWhiteSpace(netice);
        }

        private static bool IsValidExamPoint(string netice)
        {
            return !(Convert.ToDecimal(netice) >= 0 && Convert.ToDecimal(netice) <= 100);
        }

       
        public static  void Netice(string netice1, string netice2, string netice3, string shexs)
        {
            Console.Clear();
            var  ortalama = (Convert.ToDecimal(netice1) + Convert.ToDecimal(netice3) + Convert.ToDecimal(netice3)) / 3;

            var diplomIwi = ortalama >= 81 ? " KECMISINIZ " : "KECMEMISINZ";
            Console.WriteLine("Ad ve Soyad : " + shexs);
            Console.WriteLine("\n1-ci Netice : " + netice1);
            Console.WriteLine("2-ci Netice : " + netice2);
            Console.WriteLine("3-cu Netice : " + netice3);
            Console.WriteLine("\nOrtalama : " + ortalama.ToString("0.##"));
            Console.WriteLine("\nDiplom iwine " + diplomIwi);
        }


    

    }
}
