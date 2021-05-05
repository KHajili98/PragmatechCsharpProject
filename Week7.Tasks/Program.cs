using System;
using System.Collections;

namespace Week7.Tasks
{

    class Program
    {
        static void Main(string[] args)
        {

            #region Week 7
            #region Week 7 task description
            /*
            * Productin database elave edilmesi, silinmesi, redakte edilmesi,butun mehsullarin gosterilmesi.
            * Taski yerine yetirerken kecdiyimiz yeni movzulari
            * ehate etmesine fikir verilmelidir. 2 mehsul tipimiz olacaq biri Tv digeri ise Laptop.
            *
            *
            * Product
            * Id : sistem terefinden genarete olunacaq , set oluna bilmez, 1-den baslayaraq artan olmalidir.
            * Barcode : DataBase-de eyni barcode-a sahip mehsulun olub olmamasi yoxlanmalidir.
            * Purchase price : mehsulun alis qiymeti 0-dan kicik ve ya beraber ola bilmez.
            * Sale price : mehsulun satis qiymeti alis qiymetinden kicik ola bilmez.
            * Discount price : mehsulun endirimli qiymeti 0-dan kicik ve ya beraber ola bilmez.
            * CreateDate : set edile bilmez.
            * Brand
            * Model
            * IsDeleted (bool)
            * DeletedDate : set edile bilmez
            * UpdatedDate : set edile bilmez
             *
             *
            * *Laptop
            * cpu
            * ram
            * videoCard
            *
            * * Tv
            * SmartTv (bool)
            * Inch
            * HDMi (bool)
            *
            * *Database 
            * Add : mehsulun elave edilmesi
            * Remove : mehsulun silinmesi
            * GetAll : IsDeleted statusu false olanlarin siyahisinin gosterilmesi 
            * Update : Mehsulun Brand,Model,Discount price,Sale price,Purchase price, Barcode xususiyyetleri redakte edilecek.
            *
            *
            */

            #endregion

            #region Week 7 task Solution

            DataBase databaza = new();
            TV yeniTv = new() 
            {
                Brand = "asd",
                Model = "erwrewrwer",
                DiscountPrice = 60,
                PurchasePrice = 30,
                SalePrice = 80,
                BarCode = 123456789,
                CreatedTime = DateTime.Now.AddDays(-10),
                Inch = 18,
                SmartTv = true,
                HDMI = true,
                Id = 1
            };

            Laptop laptop = new()
            {
                Brand = "bggbgb",
                Model = "qwe",
                DiscountPrice = 60,
                PurchasePrice = 30,
                SalePrice = 80,
                BarCode = 123456789,
                CreatedTime = DateTime.Now.AddDays(-10),
                CpuGhz=2.2,
                RamGB = 32,
                VideoCardGB =4,
                Id = 2
            };

            databaza.AddPrdouct(yeniTv);
            databaza.AddPrdouct(laptop);
            databaza.GetAllPrdouct(databaza.DB);







           /* db.Add(yeniTv);
            db.Add(laptop);

            Console.WriteLine(db.Count);

            foreach (object item in db)
            {

                if (item is TV )
                {
                    TV temp = (TV)item;
                    Console.WriteLine(temp.HDMI);

                }else if(item is Laptop)
                {

                    Laptop templ = (Laptop)item;
                    Console.WriteLine(templ.RamGB);
                }

            }

            Console.WriteLine(yeniTv is Product);*/
            

           




            #endregion

            #endregion
        }
    }
}
