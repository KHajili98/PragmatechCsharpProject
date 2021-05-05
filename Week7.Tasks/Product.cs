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
        public void AddPrdouct();
        public void GetAllPrdouct();
        public void UpdatePrdouct();
        public void RemovePrdouct();
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

    public class DataBase
    {
        public ArrayList ProductDB { get; set; }
    }

}
