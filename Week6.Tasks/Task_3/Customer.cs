﻿namespace Week6.Tasks
{
    public class Customer
    {
        public  double Balance { get; } = 450;
        public bool HasBravoBonusCard { get; set; }
        public Order CustomerOrders { get; set; } = new Order();
    }
}
