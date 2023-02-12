using DataTable.Table.Music;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMigration.DataConfiguration
{
    public class T_UpdateMusic_Configuration : IEntityTypeConfiguration<T_UpdateMusic>
    {
        public void Configure(EntityTypeBuilder<T_UpdateMusic> builder)
        {
            builder.ToTable("T_UpdateMusics");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.IdMusic).IsRequired(true);
            builder.Property(x => x.IdUser).IsRequired(true);
            builder.Property(x => x.TokenData).IsRequired(true);
            builder.Property(x => x.DateUpdate).IsRequired(true);
        }
    }
}
