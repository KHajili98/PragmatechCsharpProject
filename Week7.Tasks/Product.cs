using System;
using System.Collections;

namespace Week7.Tasks
{
    public abstract class Product
    {
        public int Id { get; set; }
        public int BarCode { get; set; }
        public double PurchasePrice { get; set; }
        public double SalePrice { get; set; }
        public double DiscountPrice { get; set; }
        public DateTime CreatedTime { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime DeletedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }


    public interface ICRUD
    {
        public void AddPrdouct(object obj );
        public void GetAllPrdouct( );
        public void UpdatePrdouct( int barcode);
        public void RemovePrdouct( int id);
    }

    public class Laptop : Product 
    {
        public double CpuGhz { get; set; } = 2.2;
        public int RamGB { get; set; } = 8;
        public double VideoCardGB { get; set; } = 4;

        
    } 
    
    public class TV : Product
    {
        public double Inch { get; set; } = 15.6;
        public bool  SmartTv { get; set; } 
        public bool  HDMI { get; set; } 
    }

    public class DataBase : ICRUD
    {
        public ArrayList DB { get; set; } = new ArrayList();

        public void AddPrdouct( object obj)
        {
            DB.Add(obj);
        }

        public void GetAllPrdouct( )
        {

            Console.WriteLine("--------------------------Mehsullar ------------------------");
            foreach (Product item in DB)
            {
                if (! item.IsDeleted)
                {
                    Console.WriteLine(item.Model + "------Model");
                    Console.WriteLine(item.Brand + "------Brand");
                    Console.WriteLine(item.DiscountPrice+"------Endirimli Qiymet");
                    Console.WriteLine(item.SalePrice + "------Satiw Qiymet");
                    Console.WriteLine(item.PurchasePrice + "------Aliw Qiymet");
                    Console.WriteLine(item.BarCode+"------Barcode ");
                    Console.WriteLine(item.CreatedTime+"-------Yaradilma vaxti");
                    if(item.UpdatedDate != default(DateTime)) Console.WriteLine(item.UpdatedDate+"------------------------Deyiwilme vaxti");
                    if (item is TV)
                    {
                        TV temp = (TV)item;
                        Console.WriteLine(temp.Inch + "----televizorun inchi");
                       if(temp.HDMI) Console.WriteLine("HDMI movcuddur");
                       if(temp.SmartTv) Console.WriteLine("SmartTv movcuddur");
                    }
                    else if (item is Laptop)
                    {
                        Laptop temp = (Laptop)item;
                        Console.WriteLine(temp.RamGB + "------------------LAPTOPun RamGB");
                        Console.WriteLine(temp.VideoCardGB + "------------------LAPTOPun VideoCardGB");
                        Console.WriteLine(temp.CpuGhz + "------------------LAPTOPun CpuGhz");

                    }
                }

                Console.WriteLine("*************************************************");
            }
        }

        public void RemovePrdouct( int id)
        {

            foreach (Product item in DB)
            {
                if (id == item.Id)
                {
                    item.IsDeleted = true;
                }
            }
           
        }
        public void UpdatePrdouct( int id)
        {

            foreach (Product item in DB)
            {
                if (id == item.Id)
                {
                    item.Brand = "deyiwilmiw brand";
                    item.Model = "deyiwilmiw model";
                    item.DiscountPrice = 1;
                    item.SalePrice = 1;
                    item.PurchasePrice = 1;
                    item.BarCode = 1;
                    item.UpdatedDate = DateTime.Now;
                }
            }


        }
    }





}
