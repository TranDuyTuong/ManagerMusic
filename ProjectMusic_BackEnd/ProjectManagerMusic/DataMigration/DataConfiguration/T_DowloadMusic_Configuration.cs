using DataTable.Table.Dowload;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataMigration.DataConfiguration
{
    public class T_DowloadMusic_Configuration : IEntityTypeConfiguration<T_DowloadMusic>
    {
        public void Configure(EntityTypeBuilder<T_DowloadMusic> builder)
        {
            builder.ToTable("DowloadMusics");
            builder.HasKey(x => x.IdDowload);
            builder.Property(x => x.IdDowload).UseIdentityColumn();
            builder.Property(x => x.NameUser).IsRequired(true).HasColumnType("Nvarchar(450)").HasMaxLength(450);
            builder.Property(x => x.DateCreate).IsRequired(true);
            builder.Property(x => x.IdMusic).IsRequired(true);
            builder.HasOne(x => x.T_Musics).WithMany(x => x.T_DowloadMusics).HasForeignKey(x => x.IdMusic);
        }
    }
}
