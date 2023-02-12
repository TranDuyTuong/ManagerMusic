using DataTable.Table.Music;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataMigration.DataConfiguration
{
    public class T_FileMusic_Configuration : IEntityTypeConfiguration<T_FileMusic>
    {
        public void Configure(EntityTypeBuilder<T_FileMusic> builder)
        {
            builder.ToTable("FileMusics");
            builder.HasKey(x => x.IdFile);
            builder.Property(x => x.IdFile).UseIdentityColumn();
            builder.Property(x => x.NameFile).IsRequired(true).HasColumnType("varchar(500)").HasMaxLength(500);
            builder.Property(x => x.DataFile).IsRequired(true);
            builder.Property(x => x.DateCreate).IsRequired(true);
            builder.HasOne(x => x.T_Musics).WithMany(x => x.T_FileMusics).HasForeignKey(x => x.IdMusic);
        }
    }
}
