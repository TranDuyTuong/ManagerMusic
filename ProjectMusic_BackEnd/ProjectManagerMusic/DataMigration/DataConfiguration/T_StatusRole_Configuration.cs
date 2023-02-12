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
    public class T_StatusRole_Configuration : IEntityTypeConfiguration<T_StatusRole>
    {
        public void Configure(EntityTypeBuilder<T_StatusRole> builder)
        {
            builder.ToTable("StatusRoles");
            builder.HasKey(x => x.IdStatusRole);
            builder.Property(x => x.IdStatusRole).UseIdentityColumn();
            builder.Property(x => x.NameStatus).IsRequired(true).HasColumnType("Nvarchar(250)").HasMaxLength(250);
            builder.Property(x => x.DateCreate).IsRequired(true);
        }
    }
}
