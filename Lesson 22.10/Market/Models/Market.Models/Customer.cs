using System.Collections;
using System.Collections.Generic;

namespace Market.Models
{
    public class Customer
    {
        public string Name { get; set; }

        public StoreCard StoreCard { get; set; }

        public IEnumerable<Order> Orders { get; set; }
    }
}