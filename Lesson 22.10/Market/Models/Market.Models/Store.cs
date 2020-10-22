using System.Collections;
using System.Collections.Generic;

namespace Market.Models
{
    public class Store
    {
        public Stock StockInfo { get; set; }

        public IEnumerable<StoreCard> StoreCards { get; set; }

        public IEnumerable<Order> Orders { get; set; }
    }
}