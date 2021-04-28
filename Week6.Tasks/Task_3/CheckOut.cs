using System;

namespace Week6.Tasks
{
    public class CheckOut
    {
        public double TotalDiscount { get; set; }
        public double TotalEDV { get; set; }
        public double TotalPayment { get; set; }
        public string PaymentMethod { get; set; }
        public DateTime Time { get; set; }
        public int ReceiptId { get; set; }

    }
}
