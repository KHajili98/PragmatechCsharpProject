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

            /*
           * 3.Bal Ortalamasinin Hesablanmasi!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
           *
           * istifadeciden ad ve soyadini ,
           *  4 eded imtahan neticesini daxil etmesini isteyirik.
           *
            *
            * ortalama 45-den kicikdirse : qeyri-kafi Kece bilmediz
            * ortalama 45-e beraber ve ya 70-den  kicikdirse :  Meqbul
            * ortalama 70-e beraber ve ya 90-dan  kicikdirse :  Yaxsi
            * ortalama 90 ile  100 arasinda (100-de daxil) :  Ela
            *
            * qeyd : ortalama 100-den boyuk ola bilmez.
            *
           * netice asagidaki kimi olmalidir.
           *
           * Ad ve Soyad : Parviz Aliyev
           *
           * Netice : 50
           * Netice : 40
           * Netice : 30
           * Netice : 20
           *
           * Ortalama : 35
           * Semestr Yekunu : qeyri-kafi Kece bilmediz
           */


            //---------------------------------------------------  Solution :

            /* 
             
            Console.Write("Zehmet olmasa adinizi daxil edin: ");
            var ad = Console.ReadLine();
            Console.Write("Zehmet olmasa soyadinizi daxil edin: ");
            var soyad = Console.ReadLine();

            var shexs = ad + " " + soyad;

            Console.WriteLine("! ! ! Ortalamalar 1-100 arasinda olmalidir ! ! !\n");

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

            if (ortalama< 100)
            {
                if (ortalama < 45)
                {
                    Console.WriteLine("Semestr Yekunu : " + "qeyri-kafi Kece bilmediz");
                    // qeyri -kafi 
                }else if(ortalama == 45 || ortalama < 70)
                {
                    Console.WriteLine("Semestr Yekunu : " + "Meqbul");

                    // meqbul
                }
                else if (ortalama ==70 || ortalama < 90)
                {
                    Console.WriteLine("Semestr Yekunu : " + "yaxsi");

                    //yaxwi 
                }
                else if(ortalama>90 || ortalama <= 100){
                    //ela
                    Console.WriteLine("Semestr Yekunu : " + "ela");

                }

            }

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

            //---------------------------------------------------  Solution :

            /*
            var a = 0;
            var result = 0;
            while (a < 100)
            {
                if(a%2 != 0)
                {
                    result += a;
                }
                a++;
            }
            Console.Write("0 ile 100 arasindaki tek ededlerin cemi : "+result);
            */

            #endregion

            #region 4. while ile faktorialin hesablanmasi
            //---------------------------------------------------  Solution :

            /*
            var factorialNumber = 5;
            var result = 1;
            while (factorialNumber > 1)
            {
                result *= factorialNumber;
                factorialNumber--;
            }
            Console.WriteLine(result);
            */


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
             **  qeyd: eyni taski, if, ternary operator ve switch ile yazin!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
             */

            //---------------------------------------------------  Solution with if  :

            /*
             
            var username = "admin";
            var password = "6gH123";

            Console.Write("Zehmet olmasa username daxil edin : ");
            var usernameInput = Console.ReadLine();
            Console.Write("Zehmet olmasa password daxil edin : ");
            var passwordInput = Console.ReadLine();

            if (passwordInput != password || usernameInput != username)
            {
              Console.WriteLine("Daxil edilen username ve ya sifre dogru deyil !");
            }
            else
            {
              Console.WriteLine("Login emeliyyati ugurla basha catdi !");
            }
                
            */

            //---------------------------------------------------  Solution with ternary  :
            /*
            var username = "admin";
            var password = "6gH123";

            Console.Write("Zehmet olmasa username daxil edin : ");
            var usernameInput = Console.ReadLine();
            Console.Write("Zehmet olmasa password daxil edin : ");
            var passwordInput = Console.ReadLine();

            var trueMessage = "Login emeliyyati ugurla basha catdi !";
            var falseMessage = "Daxil edilen username ve ya sifre dogru deyil !";

            Console.WriteLine(passwordInput != password || usernameInput != username ? falseMessage : trueMessage);
            */

            //---------------------------------------------------  Solution with switch  :

            /*
            var username = "admin";
            var password = "6gH123";
            var resultValue = username + password;


            Console.Write("Zehmet olmasa username daxil edin : ");
            var usernameInput = Console.ReadLine();
            Console.Write("Zehmet olmasa password daxil edin : ");
            var passwordInput = Console.ReadLine();
             var inputValue = usernameInput+passwordInput;
            var checkedBool = inputValue == resultValue;

            var trueMessage = "Login emeliyyati ugurla basha catdi !";
            var falseMessage = "Daxil edilen username ve ya sifre dogru deyil !";

            

            switch(checkedBool)
            {
                case true:
                    Console.WriteLine(trueMessage);
                    break;
                case false:
                    Console.WriteLine(falseMessage);
                    break;
            }
            */

            /*
             * Istifadeciden role(selahiyyet) isteyerek daxil etdiyi role uygun mesaj verin.
             *
             *  Istifadeci selahiyyeti (I.S) :
             *
             * I.S = AA , BB , CC ise "Admin selahiyyetlerine sahibsiniz."
             * I.S = MM "Moderator selahiyyetlerine sahibsiniz."
             * I.S = MH "Muhasib selahiyyetlerine sahibsiniz."
             * I.S = UU "Standart istifadeci selahiyyetlerine sahibsiniz."
             *
             * qeyd edilenlerden ferqli olarsa : "Daxil edilen selahiyyet dogru deyil"
             *
             * switchden istifade edin.
             */

            //---------------------------------------------------  Solution :

            /*
            var adminMessage = "\nAdmin selahiyyetlerine sahibsiniz.";
            var moderatorMessage = "\nModerator selahiyyetlerine sahibsiniz.";
            var muhasibMessages = "\nMuhasib selahiyyetlerine sahibsiniz.";
            var standartMessages = "\nStandart selahiyyetlerine sahibsiniz.";
            var wrongMessages = "\nDaxil edilen selahiyyet dogru deyil";


            Console.Write("Zehmet olmasa Istifadeci selahiyyeti (I.S)  daxil edin : ");
            var role = Console.ReadLine();

            switch (role)
            {
                case "AA":
                case "BB":
                case "CC":
                    Console.WriteLine(adminMessage);
                    break;
                case "MM":
                    Console.WriteLine(moderatorMessage);
                    break;
                case "MH":
                    Console.WriteLine(muhasibMessages);
                    break;
                case "UU":
                    Console.WriteLine(standartMessages);
                    break;
                default:
                    Console.WriteLine(wrongMessages);
                    break;
            }

            */


            #endregion


            #region 6. calculator : switch
            /*
             * switch istifade ederek calculator yazin
             *
             * qeyd: hem normal switchden istifade edin hem de expressionla olan variantla
             */

            //-----------------------------------------------solution with switch :

            /*
            Console.WriteLine("----Menu-----");
            Console.WriteLine("1- Toplama:");
            Console.WriteLine("2- Cixma:");
            Console.WriteLine("3- Vurma:");
            Console.WriteLine("4- Bolme:");
            Console.WriteLine("----Menu-----");

            Console.Write("Emeliyyat nomresini daxil edin: ");
            int operation = Convert.ToInt32(Console.ReadLine());

            switch (operation)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                    {
                        Console.Write("Brinci nomresini daxil edin: ");
                        decimal number1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("ikinci nomresini daxil edin: ");
                        decimal number2 = Convert.ToInt32(Console.ReadLine());
                        switch (operation)
                        {
                            case 1: Console.WriteLine("Netice: " + (number1 + number2)); break;
                            case 2: Console.WriteLine("Netice: " + (number1 - number2)); break;
                            case 3: Console.WriteLine("Netice: " + (number1 * number2)); break;
                            case 4:
                                {
                                    switch (number2)
                                    {
                                        case 0: Console.WriteLine("Bolen 0 ola bilmez"); break;
                                        default: Console.WriteLine("Netice: " + (number1 / number2)); break;

                                    }
                                }
                                break;

                        }

                    }
                    break;
                default: Console.WriteLine("Duzgun emeliyyat nomresi daxil edin"); break;
            }

           */

            //-----------------------------------------------solution with switch expressionla :

            /*
            Console.WriteLine("----Menu-----");
            Console.WriteLine("1- Toplama:");
            Console.WriteLine("2- Cixma:");
            Console.WriteLine("3- Vurma:");
            Console.WriteLine("4- Bolme:");
            Console.WriteLine("----Menu-----");

            Console.Write("Emeliyyat nomresini daxil edin: ");
            var option = Console.ReadLine();

            Console.Write("Brinci ededi daxil edin: ");
            var a = Convert.ToInt32( Console.ReadLine());

            Console.Write("ikinci ededi daxil edin: ");
            var b = Convert.ToInt32( Console.ReadLine());

            var wrong = "duzgun emeliyyat nomresi sec";
            string toplama = Convert.ToString(a + b);
            var cixma = Convert.ToString(a - b);
            var vurma = Convert.ToString(a * b);
            string bolme = b != 0 ? Convert.ToString(a / b) :"0-a bolmek olmaz";


            var netice = option switch
            {
                "1" => toplama,
                "2" => cixma,
                "3" => vurma,
                "4" => bolme,
                _ => wrong
           
            };

            Console.WriteLine("Netice: " + netice);
            */

            #endregion

            #region 7. menfi musbet
            /*
             * Daxil edilen ededin menfi ve ya musbet oldugunu yoxlayin ona uygun geriye deyer qaytarin.
             *
             * qeyd: if ve ternary istifade edin ayri ayri
             */

            //-----------------------------------------------------------solution with if :
            /*
                        Console.Write("eded daxil edin : ");
                      var  eded = Console.ReadLine();
                        if (eded.StartsWith('-'))
                        {
                            Console.WriteLine("eded menfidir");
                        }
                        else if(eded =="0")
                        {
                            Console.WriteLine("eded 0-dir");
                        }
                        else
                        {
                            Console.WriteLine("eded musbetdir");

                        }
            */

            //-----------------------------------------------------------solution with ternary :

            /*
            Console.Write("eded daxil edin : ");
            var eded = Console.ReadLine();
            Console.WriteLine(eded.StartsWith('-') ? "eded menfidir" : (eded=="0"? "eded 0-dir": "eded musbetdir") );

            */
            #endregion

            #region 8. vurma cedveli
            /*
             * vurma cedveli hazirlayin.
             *
             * netice asagidaki kimi olsun
             *
             * 1 * 1 = 1   1 * 2 = 2  1 * 3 = 3 belece davam edir
             * 2 * 1 = 2   2 * 2 = 4  2 * 3 = 6
             * 
             */
            //------------------------------------------------ solution : 

            /*for (var i = 1; i <= 10; i++)
            {
                for (var j = 1; j <= 10; j++)
                {
                    Console.Write(" " + i + " * " + j + " = " + i * j);
                }
                Console.WriteLine();
            }*/

            //--- concole boyuk pencere weklinde acin zehmet olmasa :)



            #endregion

            #region exam

            // dogru cavabin qarshisina "+++++++++++" qeyd olunacaqdir.

            /*
             * 1. int num1=10;
             *    int num2=20;
             *    bool result = num1 > num2;
             *
             *  asagidakilardan hansi uygun gelir ?
             *
             *  num1 deyeri num2 deyerinden kicikdir ve bool tipinde olan result
             *  deyiseni bu iki deyerin muqayisesinden false deyerini alir. ++++++++++++++++++++++++++++++++++++++
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
             * Result : 55; +++++++++++++++++++++++++++++++++++++++++
             * Result : 66;
             * ******************
             * 3. Boyuk beraberdir  ve beraber deyildir operatorlari hansilardir.
             *
             * =! , ==
             * == , <=
             * >= , <=
             * >= , !=  +++++++++++++++++++++++++++++++++++++++++++++++++
             */

            #endregion

            #endregion

        }
    }
}
