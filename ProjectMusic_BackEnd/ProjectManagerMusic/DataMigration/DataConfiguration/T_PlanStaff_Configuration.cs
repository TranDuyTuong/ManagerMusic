using DataTable.Table.Staff;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMigration.DataConfiguration
{
    public class T_PlanStaff_Configuration : IEntityTypeConfiguration<T_PlanStaff>
    {
        public void Configure(EntityTypeBuilder<T_PlanStaff> builder)
        {
            builder.ToTable("PlanStaffs");
            builder.HasKey(x => x.IdPlan);
            builder.Property(x => x.IdPlan).UseIdentityColumn();
            builder.Property(x => x.NamePlan).IsRequired(true).HasColumnType("Nvarchar(MAX)");
            builder.Property(x => x.ContentPlan).IsRequired(true).HasColumnType("Nvarchar(MAX)");
            builder.Property(x => x.DateCreate).IsRequired(true);
            builder.Property(x => x.IdUserPlan).IsRequired(true);
            builder.Property(x => x.IdUserRequest).IsRequired(true);
            builder.Property(x => x.DateComplete).IsRequired(true);
            builder.Property(x => x.TimeComplete).IsRequired(true);
        }
    }
}
