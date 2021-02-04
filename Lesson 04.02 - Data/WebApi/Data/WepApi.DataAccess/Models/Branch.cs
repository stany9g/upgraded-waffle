using System.Collections.Generic;

namespace WepApi.DataAccess.Models
{
    public class Branch : DbBase
    {
        public ICollection<Employee> Workers { get; set; }

        public int ManagerId { get; set; }
        public Employee Manager { get; set; }

        public ICollection<Client> Clients { get; set; }

        public ICollection<Supplier> Suppliers { get; set; }
    }
}