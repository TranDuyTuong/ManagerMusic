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
    public class T_ChatImageStaff_Configuration : IEntityTypeConfiguration<T_ChatImageStaff>
    {
        public void Configure(EntityTypeBuilder<T_ChatImageStaff> builder)
        {
            builder.ToTable("ChatImageStaffs");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.NameImage).IsRequired(true);
            builder.Property(x => x.TypeImage).IsRequired(true);
            builder.Property(x => x.FileImage).IsRequired(true);
            builder.Property(x => x.IdChat).IsRequired(true);
        }
    }
}
