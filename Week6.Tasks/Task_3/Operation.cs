using System;
using System.Collections.Generic;
using System.Text;

namespace Week6.Tasks.Task_3
{
    public class  Operation
    {
        public  double GetBalanceAfterPayment(string inputForPayment,Customer customer, CheckOut checkOut)
        {
            double getTotalCashForPaymentFromReceipt = GetTotalCashOfReceipt(customer, checkOut);
            if (inputForPayment.Equals("K"))
            {
                double totatlEdvCashBack = 0;
                double edvCashBack = 0;

                customer.Balance -= getTotalCashForPaymentFromReceipt;
                foreach (var edv in customer.CustomerOrders.AllEDV)
                {
                    edvCashBack = edv * 0.1;
                    totatlEdvCashBack += edvCashBack;
                }
                customer.Balance += totatlEdvCashBack;

                if (customer.HasBravoBonusCard)
                {
                    customer.Balance += 0.02 * getTotalCashForPaymentFromReceipt;
                }

                return customer.Balance;

            }
            else if (inputForPayment.Equals("N"))
            {
                double totatlEdvCashBack = 0;
                double edvCashBack = 0;

                customer.Balance -= getTotalCashForPaymentFromReceipt;
                foreach (var edv in customer.CustomerOrders.AllEDV)
                {
                    edvCashBack = edv * 0.15;
                    totatlEdvCashBack += edvCashBack;
                }
                customer.Balance += totatlEdvCashBack;

                if (customer.HasBravoBonusCard)
                {
                    customer.Balance += 0.02 * getTotalCashForPaymentFromReceipt;
                }
                return customer.Balance;

            }

            return customer.Balance;
        }


        public  double GetTotalCashOfReceipt(Customer customer,CheckOut checkOut)
        {
            double totalEDV = 0;
            double totalMebleg = 0;
            double price = 0;
            double edv = 0;
            foreach (var id in customer.CustomerOrders.ProductId)// toplam mebleg 
            {
                foreach (Product product1 in Product.GetAllProducts())
                {
                    if (id == product1.Id)// discount yoxlama
                    {
                        if (product1.Discount != 0)
                        {
                            var discount = (product1.Price * product1.Discount) / 100;
                            customer.CustomerOrders.AllDiscounts.Add(discount);
                            price = (double)(product1.Price - discount);
                            totalMebleg += price;
                            if (product1.EDV != 0)//edv yoxlama
                            {
                                edv = price * product1.EDV / 100;
                                customer.CustomerOrders.AllEDV.Add(edv);
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
                                customer.CustomerOrders.AllEDV.Add(edv);
                                totalEDV += edv;

                            }
                        }



                        break;
                    }
                }

            }
            checkOut.TotalEDV = totalEDV; //cekde gosterilecek total edv


            totalMebleg += totalEDV;

            if (totalMebleg < 15)// catdirilma pulu
            {
                totalMebleg += 4.5;
            }

            checkOut.TotalPayment = totalMebleg; // checkde gosterilecek toplam
            checkOut.ReceiptId++;

            return totalMebleg;
        }




    }
}
