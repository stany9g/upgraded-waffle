using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WepApi.DataAccess.Models;

namespace WepApi.DataAccess.Configuration
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employees");

            builder.HasMany(e => e.Subordinates).WithOne(s => s.Supervisor);

            // Do not have to
            builder.HasOne(e => e.Branch).WithMany(b => b.Workers).HasForeignKey(f => f.BranchId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}