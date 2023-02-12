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
    class T_StatusPlan_Configuration : IEntityTypeConfiguration<T_StatusPlan>
    {
        public void Configure(EntityTypeBuilder<T_StatusPlan> builder)
        {
            builder.ToTable("StatusPlans");
            builder.HasKey(x => x.IdStatusPlan);
            builder.Property(x => x.IdStatusPlan).UseIdentityColumn();
            builder.Property(x => x.NameStauts).IsRequired(true);
        }
    }
}
