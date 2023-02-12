using DataTable.Table.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMigration.DataConfiguration
{
    public class T_ChatStaff_Configuration : IEntityTypeConfiguration<T_ChatStaff>
    {
        public void Configure(EntityTypeBuilder<T_ChatStaff> builder)
        {
            builder.ToTable("ChatStaffs");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.IdUser).IsRequired();
            builder.Property(x => x.FullName).IsRequired();
            builder.Property(x => x.DateCreate).IsRequired();
            builder.Property(x => x.Message).IsRequired().HasColumnType("Nvarchar(MAX)");
        }
    }
}
