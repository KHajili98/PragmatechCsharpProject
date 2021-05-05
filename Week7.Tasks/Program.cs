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
                Brand = "LG",
                Model = "girdirme",
                DiscountPrice = 60,
                PurchasePrice = 30,
                SalePrice = 80,
                BarCode = 285349823,
                CreatedTime = DateTime.Now.AddDays(-10),
                Inch = 18,
                SmartTv = true,
                HDMI = true,
                Id =1
            };
            TV yeniTv1 = new()
            {
                Brand = "SAMSUNG",
                Model = "teze",
                DiscountPrice = 60,
                PurchasePrice = 30,
                SalePrice = 80,
                BarCode = 987435435,
                CreatedTime = DateTime.Now.AddDays(-10),
                Inch = 18,
                SmartTv = true,
                HDMI = true,
            };
            Laptop laptop = new()
            {
                Brand = "MSI",
                Model = "GL627rex",
                DiscountPrice = 60,
                PurchasePrice = 30,
                SalePrice = 80,
                BarCode = 123456789,
                CreatedTime = DateTime.Now.AddDays(-10),
                CpuGhz=2.2,
                RamGB = 32,
                VideoCardGB =4,
            };
            Laptop laptop1 = new()
            {
                Brand = "ACER",
                Model = "asdasd",
                DiscountPrice = 60,
                PurchasePrice = 30,
                SalePrice = 80,
                BarCode = 123456789,
                CreatedTime = DateTime.Now.AddDays(-10),
                CpuGhz = 2.2,
                RamGB = 32,
                VideoCardGB = 4,
            };






            Console.WriteLine("\nid-1 artiq databazada var amma yeniden daxil etmeyi yoxlayacagoq Netiec:\n"); // default olaraq db yarananda id 1 olan product deye add etmeyecek
            databaza.AddPrdouct(yeniTv);
            Console.WriteLine("*****************************************************************************");
            databaza.AddPrdouct(yeniTv1);
            databaza.AddPrdouct(laptop);
            databaza.AddPrdouct(laptop1);
            databaza.GetAllPrdouct();
            Console.WriteLine("\nid-1 olani sileceyik\n");
            Console.WriteLine("================================Removedan sonra============================================");
            databaza.RemovePrdouct( 1); // db-da olan id 1 olani silenden sonra yeni isdeleted true edenden sonra butun productlari cagidaracagiq
            databaza.GetAllPrdouct();
            Console.WriteLine("\nid-2,,, id-3  olani update edeceyik\n"); // update methodda static olaraq methodun icerisinde yeni deyerleri menimsetmiwem
            databaza.UpdatePrdouct(2);
            databaza.UpdatePrdouct(3);
            Console.WriteLine("================================Updateden sonra============================================");
            databaza.GetAllPrdouct();



            #endregion

            #endregion
        }
    }
}
