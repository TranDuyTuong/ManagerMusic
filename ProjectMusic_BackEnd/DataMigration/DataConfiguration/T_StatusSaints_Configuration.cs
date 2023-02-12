using DataTable.Table.Saints;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataMigration.DataConfiguration
{
    public class T_StatusSaints_Configuration : IEntityTypeConfiguration<T_StatusSaints>
    {
        public void Configure(EntityTypeBuilder<T_StatusSaints> builder)
        {
            builder.ToTable("StatusSaintes");
            builder.HasKey(x => x.IdIdStatusSaints);
            builder.Property(x => x.IdIdStatusSaints).UseIdentityColumn();
            builder.Property(x => x.NameStatusSaints).IsRequired(true).HasColumnType("Nvarchar(250)").HasMaxLength(250);
            builder.Property(x => x.DateCreate).IsRequired(true);
        }
    }
}
