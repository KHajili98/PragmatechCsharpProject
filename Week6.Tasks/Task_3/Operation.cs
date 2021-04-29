using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Week6.Tasks.Task_3
{
    public class  Operation
    {
        // balansin odeniwden sonraki halini hesablamaq ucun 
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

        //aliwveriwden sonra balansda cixacaq meblegin hesablanmasi ve diger hesabat emeliyyatlari ucun 
        public  double GetTotalCashOfReceipt(Customer customer,CheckOut checkOut)
        {
            double totalEDV = 0;
            double totalMebleg = 0;
            double price = 0;
            double edv = 0;
            foreach (DictionaryEntry order in customer.CustomerOrders.ProductIdAndCount)// toplam mebleg 
            {

                foreach (Product product1 in Product.GetAllProducts())
                {
                    if ((int)order.Key == product1.Id)// discount yoxlama
                    {

                        if (product1.Discount != 0)
                        {
                            var discount = (product1.Price * product1.Discount) / 100;
                            if ((int)order.Value == 1)
                            {
                                customer.CustomerOrders.AllDiscounts.Add(discount);
                            }
                            else
                            {
                                customer.CustomerOrders.AllDiscounts.Add(discount* (int)order.Value);

                            }


                            price = (double)(product1.Price - discount);

                            if ((int)order.Value == 1)
                            {
                                totalMebleg += price;
                            }
                            else
                            {
                                totalMebleg += price * (int)order.Value;
                            }

                            if (product1.EDV != 0)//edv yoxlama
                            {
                                if ((int)order.Value == 1)
                                {
                                    edv = price * product1.EDV / 100;
                                    customer.CustomerOrders.AllEDV.Add(edv);
                                    totalEDV += edv;
                                }
                                else
                                {
                                    edv = (int)order.Value * price * product1.EDV / 100;
                                    customer.CustomerOrders.AllEDV.Add(edv);
                                    totalEDV += edv;
                                }
                                

                            }
                        }
                        else //discountun else
                        {
                            price = product1.Price;
                            if ((int)order.Value == 1)
                            {
                                totalMebleg += price;
                            }
                            else
                            {
                                totalMebleg += price * (int)order.Value;
                            }
                            if (product1.EDV != 0)//edv yoxlama
                            {

                                if ((int)order.Value == 1)
                                {
                                    edv =  product1.Price * product1.EDV / 100;
                                    customer.CustomerOrders.AllEDV.Add(edv);
                                    totalEDV += edv;
                                }
                                else
                                {
                                    edv = (int)order.Value* product1.Price * product1.EDV / 100;
                                    customer.CustomerOrders.AllEDV.Add(edv);
                                    totalEDV += edv;
                                }
                                

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
                checkOut.AddDeliveringPayment = true;
            }

            checkOut.TotalPayment = totalMebleg; // checkde gosterilecek toplam

            return totalMebleg;
        }

    }
}
