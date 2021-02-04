using System.Collections.Generic;

namespace WepApi.DataAccess.Models
{
    public class Supplier : DbBase
    {
        public string Type { get; set; }

        public ICollection<Branch> Customers { get; set; }
    }
}