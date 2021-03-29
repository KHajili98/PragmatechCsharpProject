using System;

namespace Week3.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task

            #region 1 Bal Ortalamasinin Hesablanmasi
            /*
             * 1. Istifadeciden gelen 3 ferqli imtahan neticelerinin
             * ortalamasinin 45-den  boyuk ve ya beraber olmasini
             * yoxlayin.
             *
             * qeyd : if else istifade etmeyin burada
             * 
             * netice asagidaki kimi olmalidir.
             *
             *
             * Netice : 30
             * Netice : 50
             * Netice : 40
             *
             *
             * "Ortalama 45-e beraber ve ya boyukdurmu?" : "40"(Ortalamadir) : Beli ve ya Xeyr
             */

            //---------------------------------------------------  Solution :

            /*
            Console.WriteLine("Zehmet olmasa 1-ci imtahan neticesini elave edin :");
            var netice1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nZehmet olmasa 2-ci imtahan neticesini elave edin :");
            var netice2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nZehmet olmasa 3-cu imtahan neticesini elave edin :");
            var netice3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n1-ci Netice : " + netice1);
            Console.WriteLine("2-ci Netice : " + netice2);
            Console.WriteLine("3-cu Netice : " + netice3);

            Console.WriteLine("\nOrtalama 45-e beraber ve ya boyukdurmu?\n");


            var ortalama = (netice1 + netice2 + netice3) / 3;
            string yekunNetice = ortalama >= 45
                ? "Beli.Sizin ortalamaniz : " + ortalama
                : "Xeyr.Sizin ortalamaniz :" + ortalama;
            Console.WriteLine(yekunNetice);
            */




            /*
            * 2.Bal Ortalamasinin Hesablanmasi
            *
            * istifadeciden ad ve soyadini ,
            *  4 eded imtahan neticesini daxil etmesini isteyirik.
            *
            * netice asagidaki kimi olmalidir
            *
            * Ad ve Soyad : Parviz Aliyev
            *
            * Netice : 50
            * Netice : 40
            * Netice : 30
            * Netice : 20
            *
            * Ortalama : 35
            */

            //---------------------------------------------------  Solution :

            /*
            Console.Write("Zehmet olmasa adinizi daxil edin: ");
            var ad = Console.ReadLine();
            Console.Write("Zehmet olmasa soyadinizi daxil edin: ");
            var soyad = Console.ReadLine();

            var shexs = ad + " " + soyad;

            Console.Write("\nZehmet olmasa 1-ci imtahan neticesini elave edin :");
            var netice1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Zehmet olmasa 2-ci imtahan neticesini elave edin :");
            var netice2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Zehmet olmasa 3-cu imtahan neticesini elave edin :");
            var netice3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Zehmet olmasa 4-cu imtahan neticesini elave edin :");
            var netice4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nAd ve Soyad : " + shexs);
            Console.WriteLine("\n1-ci Netice : " + netice1);
            Console.WriteLine("2-ci Netice : " + netice2);
            Console.WriteLine("3-cu Netice : " + netice3);
            Console.WriteLine("4-cu Netice : " + netice4);

            var ortalama = (netice1 + netice2 + netice3 + netice4) / 4;

            Console.WriteLine("\nOrtalama : " + ortalama);
            */


            #endregion

            #region 2. while ile consoledan daxil edilen ededden geriye dogru loop 
            //---------------------------------------------------  Solution :

            /*
            Console.Write("Ededi daxil edin :");
            var eded = Convert.ToInt32(Console.ReadLine());

            while (eded >= 0)
            {
                Console.WriteLine(eded);
                eded--;
            }
            */


            #endregion

            #region 3. while ile 0 ile 100 arasindaki tek ededlerin cemi


            #endregion

            #region 4. while ile faktorialin hesablanmasi

            #endregion

            #region 5. Mini login

            /*
             * Username ve password deye deyisenler teyin edin.
             *
             *  Username : admin
             *  Password : 6gH123
             *
             * Istifadeciden  username ve Password daxil etmesini isteyin.
             *
             * Daxil edilen username ve passwordun teyin edilen
             * deyisenlerin deyerine beraber olub olmamasini yoxlayin,
             *
             * Netice olaraq login emeliyyatinin ugurlu ve ya
             *
             *  daxil edilen username ve ya sifrenin dogru olmadigi mesajini verin.
             *
             *
             */

            #endregion

            #region exam

            /*
             * 1. int num1=10;
             *    int num2=20;
             *    bool result = num1 > num2;
             *
             *  asagidakilardan hansi uygun gelir ?
             *
             *  num1 deyeri num2 deyerinden kicikdir ve bool tipinde olan result
             *  deyiseni bu iki deyerin muqayisesinden false deyerini alir.
             *
             * num1 deyeri num2 deyerine beraberdir ve bool tipinde olan result
             *  deyiseni true-dur.
             *
             ********************
             * 2. int num1 = 100;
             *
             *    int num2 = 2;
             *    
             *    int result = (num1 + 10 ) / num2;
             *    
             *    Console.WriteLine(result);
             *
             * Result : 33;
             * Result : 55;
             * Result : 66;
             * ******************
             * 3. Boyuk beraberdir  ve beraber deyildir operatorlari hansilardir.
             *
             * =! , ==
             * == , <=
             * >= , <=
             * >= , !=
             */

            #endregion

            #endregion

        }
    }
}
