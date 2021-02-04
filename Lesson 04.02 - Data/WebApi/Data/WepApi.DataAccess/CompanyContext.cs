using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WepApi.DataAccess.Configuration;
using WepApi.DataAccess.Models;

namespace WepApi.DataAccess
{
    public class CompanyContext : DbContext
    {
        public CompanyContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Branch> Branches { get; set; }
        public DbSet<Supplier> BranchSuppliers { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new BranchConfiguration());
            modelBuilder.ApplyConfiguration(new WorksWithConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
        }
    }
}