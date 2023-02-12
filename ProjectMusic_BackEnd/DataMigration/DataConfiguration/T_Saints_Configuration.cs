using DataTable.Table.Saints;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataMigration.DataConfiguration
{
    public class T_Saints_Configuration : IEntityTypeConfiguration<T_Saints>
    {
        public void Configure(EntityTypeBuilder<T_Saints> builder)
        {
            builder.ToTable("Saintes");
            builder.HasKey(x => x.IdSaints);
            builder.Property(x => x.IdSaints).UseIdentityColumn();
            builder.Property(x => x.IdStatusSaints).IsRequired(true);
            builder.Property(x => x.NameSaints).IsRequired(true).HasColumnType("Nvarchar(500)").HasMaxLength(500);
            builder.Property(x => x.DateCreate).IsRequired(true);
            builder.HasOne(x => x.T_StatusSaintes).WithMany(x => x.T_Saintes).HasForeignKey(x => x.IdStatusSaints);
        }
    }
}
