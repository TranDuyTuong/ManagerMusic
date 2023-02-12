using DataTable.Table.Music;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataMigration.DataConfiguration
{
    public class T_StatusMusic_Configuration : IEntityTypeConfiguration<T_StatusMusic>
    {
        public void Configure(EntityTypeBuilder<T_StatusMusic> builder)
        {
            builder.ToTable("StatusMusics");
            builder.HasKey(x => x.IdStatusMusic);
            builder.Property(x => x.IdStatusMusic).UseIdentityColumn();
            builder.Property(x => x.NameStatusMusic).IsRequired(true).HasColumnType("Nvarchar(100)").HasMaxLength(100);
            builder.Property(x => x.DateCreate).IsRequired(true);
        }
    }
}
