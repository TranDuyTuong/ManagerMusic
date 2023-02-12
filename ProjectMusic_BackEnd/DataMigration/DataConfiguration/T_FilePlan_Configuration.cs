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
    public class T_FilePlan_Configuration : IEntityTypeConfiguration<T_FilePlan>
    {
        public void Configure(EntityTypeBuilder<T_FilePlan> builder)
        {
            builder.ToTable("FilePlans");
            builder.HasKey(x => x.IdFile);
            builder.Property(x => x.IdFile).UseIdentityColumn();
            builder.Property(x => x.IdPlan).IsRequired(true);
            builder.Property(x => x.TypeFile).IsRequired(true);
            builder.Property(x => x.MimeType).IsRequired(true);
            builder.Property(x => x.ContentFile).IsRequired(true);
            builder.Property(x => x.DateCreate).IsRequired(true);
        }
    }
}
