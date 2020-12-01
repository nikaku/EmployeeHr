using Hr.BL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hr.DB.EntityConfigurations
{
    public class DepartmentsAndBranchesConfiguration : IEntityTypeConfiguration<DepartmentsAndBranches>
    {
        public void Configure(EntityTypeBuilder<DepartmentsAndBranches> builder)
        {
            builder.HasKey(p => new { p.BranchId, p.DepartmentId });

            builder.HasOne(x => x.Branch)
               .WithMany(x => x.DepartmentsAndBranches)
               .HasForeignKey(x => x.BranchId).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.Department)
               .WithMany(x => x.DepartmentsAndBranches)
               .HasForeignKey(x => x.DepartmentId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
