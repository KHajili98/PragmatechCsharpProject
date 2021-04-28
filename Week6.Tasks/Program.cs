using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Week6.Tasks
{
    class Program
    {

        
        static void Main(string[] args)
        {
            #region tasks

            #region rectangle -------------------------------------------------------------------------------------------------------------------

            #region tapwirigin werti
            /*
             * Console-dan daxil edilen en ve uzunluga gore duzbucaqlinin sahesinin hesablanmasi.
             * class memeber-ler ve encapsulation movuzlarina uygun isleyin.
             * Qeyd: daxil edilnlerden her hansisa birinin menfi olub olmamasini yoxlayin.
             * menfidirse deyeri 0 beraber edin.
             */
            #endregion

            //-------------------------------------------solution :

            /*
            Rectangle yeni = new Rectangle();
            yeni.Uzunluq = Rectangle.SetTeref("Uzunluq");
            yeni.En = Rectangle.SetTeref("En");



            Console.WriteLine("uzunluq : " + yeni.Uzunluq);
            Console.WriteLine("en : " + yeni.En);
            Console.WriteLine("sahe : " + yeni.CalculateArea().ToString("0.##"));
            */


            #endregion

            #region teacher class --------------------------------------------------------------------------------------------------------------

            #region tapwirigin werti
            /*
             *  Muellim modeli yaradin, id, adi,soyadi,vezifesi,dogum tarixi, ise baslama tarixi, islediyi yer
             *  datalarini saxlasin.
             *  Id: sadece oxuna biler auto yaradilacaq.
             *  Vezife: daxil edilmeyibse nulldursa Teacher deye set edilsin.
             *  Ise Baslama tarixi : Muellimin eger 23 yasi varsa muellim olaraq fealiyyet gostere biler.
             */
            #endregion

            //-------------------------------------------solution :
            /*
            var muellimler = Muellim.MuellimlerUcunList();

            foreach (var item in muellimler)
            {
                Console.WriteLine("***************************");
                Console.WriteLine("Dogum Tarixi : "+item.DogumTarixi.ToString("MM/dd/yyyy"));
                Console.WriteLine("Isleme Statusu : \t" + item.Status());
                if(item.Status() == "!!! Tebrikler !!! Isleye bilersiz") {
                    Console.WriteLine("Isleme Tarixi : " + item.IslemeTarixi.ToString("MM/dd/yyyy"));
                }
                Console.WriteLine("Ad : " + item.Ad);
                Console.WriteLine("Soyad : " + item.Soyad);
                Console.WriteLine("Vezife : " + item.Vezife);
                Console.WriteLine("Islediyi Yer : " + item.IslediyiYer );
                Console.WriteLine("***************************\n");

            }
            
            */



            #endregion

            #region gelende eve corey al -------------------------------------------------------------------------------------------------

            #region tapwirigin werti
            /*
             *  Online alis veris :
             *  * Console ekaraninda musterini ilk once  menu qarsilamalidir,
             *  mehsullari menudan sececek( qiymetleri de olmalidir) sonra hansindan ne qeder istediyini qeyd edecek
             *  bildiklerinizi tetbiq ederek asagidaki numune cekin hazilanmasi
             *  lazimdir. Mehsul adlari onlarin qiymetleri edv olub olmamasi mehsulda endirim olub olmamasi
             *  siz terefden serbest teyin olunacaq.(burada gosterilenler hayel urunudur hic biri gercegi yansitmamaktadir).
             *
             *  | mehsul adi        |  miqdar  |  qiymet  |EDV  |toplam|
             *  | Un                | 5 kq     |  1       |0 %  |5     |
             *   Sizin qazanciniz=================== 0,495             |
             *  | quzu eti          | 3,5 kq   |  12      |18 % |42    |
             *   Sizin qazanciniz=================== 0,90              |
             *  | cay               | 2   eded |  1,50    |0 %  |      |
             *   Sizin qazanciniz=================== 0,90              |
             *  | alma qirmizi      | 2   kq   |  2,50    |0 %  |      |
             *   Sizin qazanciniz=================== 0,90              |
             *  | alma sari         | 2   kq   |  2       |18 % |      |
             *   Sizin qazanciniz=================== 0,90              |
             *  | goyerti           | 2   eded |  0,15    |0 %  |      |
             *   Sizin qazanciniz=================== 0,90              |
             *  | makaron           | 2   eded |  2       |0 %  |      |
             *   Sizin qazanciniz=================== 0,90              |
             *  | baliq konservasi  | 2   eded |  3,50    |0 %  |      |
             *   Sizin qazanciniz=================== 0,90              |
             *  | lavas             | 1   eded |  1,50    |0 %  |      |
             *   Sizin qazanciniz=================== 0,90              |
             *  | corek             | 2   eded |  0,50    |18 % |      |
             *   Sizin qazanciniz=================== 0,90              |
             *  | pomidor           | 2   kq   |  2,50    |0 %  |      |
             *   Sizin qazanciniz=================== 0,90              |
             *  | xiyar             | 2   kq   |  2       |0 %  |      |
             *   Sizin qazanciniz=================== 0,90              |
             *  | toyuq             | 2   eded |  2,50    |0 %  |      |
             *   Sizin qazanciniz=================== 0,90
             * +++++++++++++++++++++++++++++++++++++++++++++++++++++++++
             * Endirim                                          | 2,48 |
             * vergi edv                                        | 5,02 |
             * yekun mebleg                                     | 54,50|
             * odenis novu: kartla odenib                        
             * tarix 20:04:21
             * qebz nomresi : 12
             *
             * Musterinin hesabinda umumi 450 azn pul var,
             * elave olaraq musteri bravo endirim kartina sahib oldugu ucun her alis verishinde
             * umumi meblegin 2% qeder endirim elde edir. Musteri odenisi kartla ederse 0,18 elave deyer vergisinin
             * 10 % qederini , negd pulla ederse 15 % qederini yeniden musterinin hesabina kocurulur.
             *
             * sizin qazanciniz :
             * | Un                | 5 kq     |  1       |0 %  | 5
             *  Sizin qazanciniz=================== 0,495 ( 5 % endirim olub bu mehsulda digerlerinde de bu sekilde endrim olarsa hesablanmalidir.)
             *
             * EDV :
             *  asagida gosterildiyi kimi bezi mehsullarda 0% bezilerinde 18% edv olmalidir.
             *  Sonda elave deyer vergisi-de hansi mehsullarda varsa toplanib yekun meblegin
             *  uzerine gelmelidir. Musteri odenisi kart-la  edibse 10% negd yolla odenis edibse
             *  15 % umumi edv-den musterinin hesabina pul qayidacaq.
             *
             *  | mehsul adi        |  miqdar  |  qiymet  |EDV  |toplam
             *  | Un                | 5 kq     |  1       |0 %  |5
             *   Sizin qazanciniz=================== 0,495
             *  | quzu eti          | 3,5 kq   |  12      |18 % |42
             *
             *
             *  alis veris 15 azn den azdirsa catdirilma ucun 4,50 azn teleb olunacaq.
             */

            #endregion

            Product product = new Product();
            Customer kamran = new Customer();
            Menu.Show();
            Console.WriteLine("\n\nCari Balansiniz : \t {0} AZN\n\n\n", kamran.Balance);
            do
            {
                Console.WriteLine("Zehmet olmasa istediyiniz mehsulun nomresini muvafiq olaraq daxil edin : ");
                int orderNumber = Convert.ToInt32(Console.ReadLine()); // heleki yoxlamiram reqem olub olmadigini 
                kamran.CustomerOrders.ProductId.Add(orderNumber);
                
                Console.WriteLine("Yeniden mehsul almaq isteyirsiniz? **istediyiniz duymeni basin ** / ** X ** (Beli / Xeyr)");
            } while (Console.ReadLine().ToUpper() != "X");


            Console.WriteLine("Bonus kartiniz var ? **istediyiniz duymeni basin ** / ** X ** (Beli / Xeyr) ");
            var BonusKartInput = Console.ReadLine().ToUpper();
            if (!BonusKartInput.Equals("X"))
            {
                kamran.HasBravoBonusCard = true;
            }

            Console.WriteLine("Odeniwi nece yekunlawdirmaq isteyirsiniz? ** KARTLA ** / ** NEGD ** (k / n) ");
            var CheckOutOptionInput = Console.ReadLine().ToUpper();
            kamran.Balance = GetBalanceAfterPayment(CheckOutOptionInput);

            Console.WriteLine(kamran.Balance);



            double GetBalanceAfterPayment(string inputForPayment)
            {
                if (inputForPayment.Equals("K"))
                {
                    double totatlEdvCashBack = 0;
                    double edvCashBack = 0;

                    kamran.Balance -= GetTotalCashOfReceipt();
                    foreach (var edv in kamran.CustomerOrders.AllEDV)
                    {
                        edvCashBack = edv * 0.1;
                        totatlEdvCashBack += edvCashBack;
                    }
                    kamran.Balance += totatlEdvCashBack;

                    if (kamran.HasBravoBonusCard)
                    {
                        kamran.Balance += 0.02 * GetTotalCashOfReceipt();
                    }

                    return kamran.Balance;

                }
                else if (inputForPayment.Equals("N"))
                {
                    double totatlEdvCashBack = 0;
                    double edvCashBack = 0;

                    kamran.Balance -= GetTotalCashOfReceipt();
                    foreach (var edv in kamran.CustomerOrders.AllEDV)
                    {
                        edvCashBack = edv * 0.15;
                        totatlEdvCashBack += edvCashBack;
                    }
                    kamran.Balance += totatlEdvCashBack;

                    if (kamran.HasBravoBonusCard)
                    {
                        kamran.Balance += 0.02 * GetTotalCashOfReceipt();
                    }
                    return kamran.Balance;

                }

                return kamran.Balance;
            }


            double GetTotalCashOfReceipt()
            {
                double totalEDV = 0;
                double totalMebleg = 0;
                double price = 0;
                double edv = 0;
                foreach (var id in kamran.CustomerOrders.ProductId)// toplam mebleg 
                {
                    foreach (Product product1 in Product.GetAllProducts())
                    {
                        if(id== product1.Id)// discount yoxlama
                        {
                            if (product1.Discount!=0)
                            {
                                var discount = (product1.Price * product1.Discount) / 100;
                                kamran.CustomerOrders.AllDiscounts.Add(discount);
                                price = (double)(product1.Price - discount);
                                totalMebleg += price;
                                if (product1.EDV != 0)//edv yoxlama
                                {
                                    edv = price * product1.EDV / 100;
                                    kamran.CustomerOrders.AllEDV.Add(edv);
                                    totalEDV += edv;

                                }
                            }
                            else
                            {
                                price = product1.Price;
                                totalMebleg += price;
                                if (product1.EDV != 0)//edv yoxlama
                                {
                                    edv = product1.Price * product1.EDV / 100;
                                    kamran.CustomerOrders.AllEDV.Add(edv);
                                    totalEDV += edv;

                                }
                            }

                           /* if (product1.EDV != 0)//edv yoxlama
                            {
                                edv= product1.Price * product1.EDV / 100;
                                kamran.CustomerOrders.AllEDV.Add(edv);
                                totalEDV += edv;
                                
                            }*/
                           
                            break;
                        }
                    }

                }

               
                totalMebleg += totalEDV;
                Console.WriteLine(totalEDV + "toplamedv");
                Console.WriteLine(totalMebleg + "totalMebleg");
                return totalMebleg;
            }

            #endregion

            #endregion
        }

        

    }
}
