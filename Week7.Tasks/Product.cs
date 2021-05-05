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
        public void GetAllPrdouct(ArrayList arrayList);
        public void UpdatePrdouct(object obj, int barcode);
        public void RemovePrdouct(object obj, int barcode);
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

        public void GetAllPrdouct(ArrayList arrayList)
        {
            foreach (Product item in arrayList)
            {
                if (! item.IsDeleted)
                {
                    Console.WriteLine(item.Model);
                    Console.WriteLine(item.Brand);
                    Console.WriteLine(item.DiscountPrice);
                    Console.WriteLine(item.SalePrice);
                    Console.WriteLine(item.PurchasePrice);
                    Console.WriteLine(item.BarCode);
                    Console.WriteLine(item.CreatedTime);
                    Console.WriteLine(item.UpdatedDate);
                    if (item is TV)
                    {
                        TV temp = (TV)item;
                        Console.WriteLine(temp.Inch);
                        Console.WriteLine(temp.HDMI);
                        Console.WriteLine(temp.SmartTv);
                    }
                    else if (item is Laptop)
                    {
                        Laptop temp = (Laptop)item;
                        Console.WriteLine(temp.RamGB);
                        Console.WriteLine(temp.VideoCardGB);
                        Console.WriteLine(temp.CpuGhz);

                    }
                }
            }
        }

        public void RemovePrdouct(object obj, int id)
        {
            if (obj is Product)
            {
                Product temp = (Product)obj;
                if (temp.Id == id)
                {
                    temp.IsDeleted = true;
                    temp.DeletedDate = DateTime.Now;
                }
                else
                {
                    Console.WriteLine("bele mehsul yoxdu");
                }

            }
           
        }
        public void UpdatePrdouct(object obj, int id)
        {
            if (obj is Product)
            {
                Product temp = (Product)obj;
                if (temp.Id == id)
                {
                    temp.Brand = "deyiwilmiw brand";
                    temp.Model = "deyiwilmiw model";
                    temp.DiscountPrice = 1;
                    temp.SalePrice = 1;
                    temp.PurchasePrice = 1;
                    temp.BarCode = 0;
                    temp.UpdatedDate = DateTime.Now;

                }
                else
                {
                    Console.WriteLine("bele mehsul yoxdu");
                }

            }
        }
    }





}
