using System;
using System.Collections;
using System.Collections.Generic;

namespace Market.Models
{
    public class Order
    {
        public DateTime PurchasedTime { get; set; }

        public decimal TotalAmount { get; set; }

        public IEnumerable<Item> Items { get; set; }

        public Customer Customer { get; set; }
    }
}