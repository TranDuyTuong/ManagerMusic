using DataTable.Table.Role;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMigration.DataConfiguration
{
    public class T_HistoryRole_Configuration : IEntityTypeConfiguration<T_HistoryRole>
    {
        public void Configure(EntityTypeBuilder<T_HistoryRole> builder)
        {
            builder.ToTable("HistoryRoles");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.IdRole).IsRequired(true);
            builder.Property(x => x.IdUser).IsRequired(true);
            builder.Property(x => x.StartDate).IsRequired(true);
            builder.Property(x => x.IdUserDecenRole).IsRequired(true);

        }
    }
}
