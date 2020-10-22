using Market.Models;

namespace Market.DataAccess
{
    public class Context : IContext
    {
        public void Connect(string connectionString)
        {
            throw new System.NotImplementedException();
        }

        public IRepository<Customer> Customers { get; set; }
        public IRepository<Order> Orders { get; set; }
    }
}