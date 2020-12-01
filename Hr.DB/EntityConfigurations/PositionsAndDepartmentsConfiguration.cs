using Hr.BL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hr.DB.EntityConfigurations
{
    public class PositionsAndDepartmentsConfiguration : IEntityTypeConfiguration<PositionsAndDepartments>
    {
        public void Configure(EntityTypeBuilder<PositionsAndDepartments> builder)
        {
            builder.HasIndex(p => new { p.BranchId, p.DepartmentId, p.PositionId }).IsUnique();
        }
    }
}
