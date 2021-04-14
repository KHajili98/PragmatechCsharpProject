using System;
using System.Threading;

namespace Week5.Task
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Week 5 Tasks



            #region 1. Havada bulut dimplom isini unut
            /*
             * Telebinin adini soyadini 3 imtahan neticesini
             * (((her hansisa imtahan neticesi daxil edilmezse default deyer 51 verilecek,
             * daxil edilen imtahan neticeleri0-dan kicik 100-den boyuk ola bilmez,
             * eded yerine simvol ve sair daxil edilen zaman xeta mesaji cixmalidir, yeniden emeliyyati duzgun yerine yetirerek davam etmelidir))) daxil edib,
             * ortalamasini hesablayaraq console-da  adi,soyadi, imtahan neticeleri,
             * ortalamasi, Diplom isine dusub dusmediyi yazilacaq(((bunun ucun ortalama 81den boyuk ve ya beraber olmalidir))).
             *
             * Taski mumkun derece kicik methodlara bolerek her methoda verilen adi ehtiva eden isler gorulsun.
             * Student classi yaradaraq method-lari orada yazib Program classi icerisinde Main methodunda istifade edeceksiz.
             */

            // birinci methodsuz edib sonra ise methodla edecem aradaki ferqi gormek ucun

            #region Solution with methods last version
            // ------------------------------------------------------------------------------------------- Solution with methods last version:

            
            var shexs = Student.AdVeSoyad();
            string netice,netice1="",netice2 = "", netice3 = "", imtahanNomresi;
            while (true)
            {
                Console.Clear();
                for (int i = 1; i <= 3; i++)
                {
                    while (true)
                    {
                        Console.Clear();
                        imtahanNomresi = i.ToString();
                        Console.Write(shexs + " Zehmet olmasa " + imtahanNomresi + "ci imtahan neticesini elave edin :");
                        netice = i switch
                        {
                            1 => netice1 = Console.ReadLine(),
                            2 => netice2 = Console.ReadLine(),
                            3 => netice3 = Console.ReadLine(),
                            _ => ""
                        };

                        if (!Student.ImtahanBali(netice, $"{i}-ci imtahan")) continue;

                        break;
                    }
                }
                Student.Netice(netice1, netice2, netice3, shexs);
                break;
            }
            
            #endregion

            #region Solution with methods

            // ------------------------------------------------------------------------------------------- Solution with methods:
            /*
                var shexs = Student.AdVeSoyad();
                while (true)
                {
                    Console.Clear();
                    Console.Write(shexs + " Zehmet olmasa 1-ci imtahan neticesini elave edin :");
                    var netice1 = Console.ReadLine();
                    if (!Student.ImtahanBali(netice1, "Birinci imtahan")) continue;
                    Console.Write(shexs + "Zehmet olmasa 2-ci imtahan neticesini elave edin :");
                    var netice2 = Console.ReadLine();
                    if (!Student.ImtahanBali(netice2, "Ikinci imtahan")) continue;
                    Console.Write(shexs + "Zehmet olmasa 3-cu imtahan neticesini elave edin :");
                    var netice3 = Console.ReadLine();
                    if (!Student.ImtahanBali(netice3, "Ucuncu imtahan")) continue;
                    Student.Netice(netice1, netice2, netice3, shexs);
                    break;
                }
                */

            #endregion

            #region Solution without methods

            // ------------------------------------------------------------------------------------------- Solution without methods :
            /*
            Console.Write("Zehmet olmasa adinizi daxil edin: ");
            var ad = Console.ReadLine();
            Console.Write("Zehmet olmasa soyadinizi daxil edin: ");
            var soyad = Console.ReadLine();
            var shexs = ad + " " + soyad;
            double ortalama;
            while (true)
            {
               
                Console.Clear();
                Console.Write(shexs+" Zehmet olmasa 1-ci imtahan neticesini elave edin :");
                var netice1 = Console.ReadLine();
                int result =51;
                if (! Int32.TryParse(netice1, out result )    )
                {
                    Console.WriteLine("Birinci imtahan neticesini duzgun daxil edilmeyib!!!\nReqemlerden istifade edin!!!");
                    Thread.Sleep(3000);
                    continue;
                    
                }
                if (!(Convert.ToInt32(netice1) >= 0 && Convert.ToInt32(netice1) <= 100))
                {
                    Console.WriteLine("Birinci imtahan neticesini duzgun daxil edilmeyib!!!.\nnetice 0-100 arasi bir bal olmalidir !!! ");
                    Thread.Sleep(3000);
                    continue;
                }
                Console.Write(shexs + "Zehmet olmasa 2-ci imtahan neticesini elave edin :");
                var netice2 = Console.ReadLine();
                if (!Int32.TryParse(netice2, out result))
                {
                    Console.WriteLine("Ikinci imtahan neticesini duzgun daxil edilmeyib!!!\nReqemlerden istifade edin !!!");
                    Thread.Sleep(3000);
                    continue;
                }
                if (!(Convert.ToInt32(netice2) >= 0 && Convert.ToInt32(netice2) <= 100))
                {
                    Console.WriteLine("Ikinci imtahan neticesini duzgun daxil edilmeyib!!!.\nnetice 0-100 arasi bir bal olmalidir !!! ");
                    Thread.Sleep(3000);
                    continue;
                }
                Console.Write(shexs + "Zehmet olmasa 3-cu imtahan neticesini elave edin :");
                var netice3 = Console.ReadLine();
                if (!Int32.TryParse(netice3, out result))
                {
                    Console.WriteLine("Ucuncu imtahan neticesini duzgun daxil edilmeyib!!!\nReqemlerden istifade edin!!");
                    Thread.Sleep(3000);
                    continue;
                }
                if (!(Convert.ToInt32(netice3) >= 0 && Convert.ToInt32(netice3) <= 100))
                {
                    Console.WriteLine("Ucuncu imtahan neticesini duzgun daxil edilmeyib!!!. \n netice 0-100 arasi bir bal olmalidir !!! ");
                    Thread.Sleep(3000);
                    continue;
                }
                 ortalama = (Convert.ToInt32(netice1) + Convert.ToInt32(netice3) + Convert.ToInt32(netice3)) / 3;
                var diplomIwi = ortalama >= 81 ? " KECMISINIZ " : "KECMEMISINZ";
                Console.WriteLine("\nAd ve Soyad : " + shexs);
                Console.WriteLine("\n1-ci Netice : " + netice1);
                Console.WriteLine("2-ci Netice : " + netice2);
                Console.WriteLine("3-cu Netice : " + netice3);
                Console.WriteLine("\nOrtalama : " + ortalama);
                Console.WriteLine("\nDiplom iwine " + diplomIwi);
                break;
            } */

            #endregion




            #endregion


            #region 2. para pul el cerki 2 yakinda sinemalarda
            /*
             * Evvelceden teyin edilen pin vasitesile ATM-ye yaxinlasan vetendas pini daxil edir.
             * Qarsinina cixan menu-dan balansina baxa, negd pul cixarda, ve ya umumi hesabdan cixaris
             * isteye biler.Secilen her hansi bir emeliyyatdan sonra istifadeci yeniden menuya- geri done bilmelidir.
             *
             *
             * login
             *
             * pin:
             * pin sadece reqemlerden ibaret olmalidir // 1234
             * pin sadece 4 reqemden ibaret olmalidir.
             *
             *
             * Menu
             *
             * 1.Balans:
             * (evvelceden standart olaraq balans 1000 azn olaraq nezerde tutulur.)
             *
             * 2.Negd pulun verilmesi:
             *  Istifadeci ATM-den min 1 manat max 1000 manat ceke biler.Balans yoxlamasi olacaq,
             *  daxil edilen mebleg hansi esginasdan nece eded olacaq o sekilde netice olaraq gosterilir.
             *   
             *
             * 3.Balansdan cixaris:
             *   Eger balansdan mexaric olubsa mexaric olunan meblegi ve hemin tarixi cap edin,
             *   Yox eger hele balansdan mexaric olunmayibsa bu haqqda mesaj gosterin.
             *
             *
             * Qeyd: consoledan daxil edilenler yalniz eded ola biler bular yoxlayanacaq ,
             * mumkun derece methodlarla isleyin
             *   
             */

            // --------------------------------solution : 
            /*
            ATM.LogIn();

            do
            {
                Console.Clear();
                ATM.Menu();
                byte  operation = byte.Parse(Console.ReadLine());

                switch (operation)
                {
                    case 1: ATM.BalansinYoxlanilmasi();
                        break;
                    case 2:
                        ATM.Mexaric();
                        break;
                    case 3:
                        ATM.BalansinCixariwi();
                        break;
                    default:
                        Console.Write("!!!Emeliyyat yanliwdir. Entere basdiqdan sonra yeni emeliyyat nomresini daxil edin!!!");
                        continue;
                }


                Console.Write("\nMENYUYA GERI DONMEK ISTEYIRSINIZ? b/x (beli/xeyr):\t");

            } while (Console.ReadLine()?.ToUpper() != "X"); // mellim dersdekinden goturmuwem halal eliyin :)
            */

         

            #endregion


            #endregion

        }
    }
}
