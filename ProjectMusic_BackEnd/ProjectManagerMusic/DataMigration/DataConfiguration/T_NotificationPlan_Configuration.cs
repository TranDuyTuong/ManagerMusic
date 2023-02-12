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
    public class T_NotificationPlan_Configuration : IEntityTypeConfiguration<T_NotificationPlan>
    {
        public void Configure(EntityTypeBuilder<T_NotificationPlan> builder)
        {
            builder.ToTable("NotificationPlans");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.IdPlan).IsRequired(true);
            builder.Property(x => x.IdUser).IsRequired(true);
            builder.Property(x => x.DateCreate).IsRequired(true);
            builder.Property(x => x.Content).IsRequired(true);
        }
    }
}
