using Market.Models;

namespace Market.Data.Access
{
    public class Context : IContext
    {
        public void Connect(string connectionString)
        {
            throw new System.NotImplementedException();
        }

        public IRepository<Customer> Customers { get; set; }
    }
}