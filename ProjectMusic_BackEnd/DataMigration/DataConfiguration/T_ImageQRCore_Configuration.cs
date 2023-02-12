using DataTable.Table.QRcode;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataMigration.DataConfiguration
{
    public class T_ImageQRCore_Configuration : IEntityTypeConfiguration<T_ImageQRCore>
    {
        public void Configure(EntityTypeBuilder<T_ImageQRCore> builder)
        {
            builder.ToTable("ImageQRCores");
            builder.HasKey(x => x.IdQRcore);
            builder.Property(x => x.IdQRcore).UseIdentityColumn();
            builder.Property(x => x.TitleImage).IsRequired(true).HasColumnType("Nvarchar(500)").HasMaxLength(500);
            builder.Property(x => x.ImageData).IsRequired(true);
            builder.Property(x => x.DateCreate).IsRequired(true);
            builder.HasOne(x => x.T_Musics).WithMany(x => x.T_ImageQRCores).HasForeignKey(x => x.IdMusic);
        }
    }
}
