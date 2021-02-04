using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WepApi.DataAccess.Models;

namespace WepApi.DataAccess.Configuration
{
    public class BranchConfiguration : IEntityTypeConfiguration<Branch>
    {
        public void Configure(EntityTypeBuilder<Branch> builder)
        {
            builder.ToTable("Branches");

            builder.HasOne(e => e.Manager)
                .WithOne(b => b.Manages)
                .HasForeignKey<Branch>(f => f.ManagerId);
        }
    }
}