using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WepApi.DataAccess.Models;

namespace WepApi.DataAccess.Configuration
{
    public class WorksWithConfiguration : IEntityTypeConfiguration<WorksWith>
    {
        public void Configure(EntityTypeBuilder<WorksWith> builder)
        {
            builder.ToTable("WorksWith");
            builder.HasKey(x => new {x.ClientId, x.EmployeeId});
            builder.HasOne(c => c.Client).WithMany(p => p.Partners).HasForeignKey(f => f.ClientId);
            builder.HasOne(e => e.Employee).WithMany(c => c.Clients).HasForeignKey(f => f.EmployeeId);
        }
    }
}