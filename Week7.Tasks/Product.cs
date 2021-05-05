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
        public bool IsDeleted { get; set; }
        public DateTime DeletedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }


    public interface ICRUD
    {
        public void AddPrdouct(ArrayList arrayList,object obj );
        public ArrayList GetAllPrdouct(ArrayList arrayList);
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
        public ArrayList Db { get; set; }
        public void AddPrdouct(ArrayList arrayList,object obj)
        {
            arrayList.Add(obj);
        }

        public ArrayList GetAllPrdouct(ArrayList arrayList)
        {
            return Db;
        }

        public void RemovePrdouct(object obj, int barcode)
        {
        }

        public void UpdatePrdouct(object obj, int barcode)
        {
        }
    }



}
