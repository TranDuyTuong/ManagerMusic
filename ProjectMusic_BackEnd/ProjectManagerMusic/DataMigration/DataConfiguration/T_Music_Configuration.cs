using DataTable.Table.Music;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataMigration.DataConfiguration
{
    public class T_Music_Configuration : IEntityTypeConfiguration<T_Music>
    {
        public void Configure(EntityTypeBuilder<T_Music> builder)
        {
            builder.ToTable("Musics");
            builder.HasKey(x => x.IdMusic);
            builder.Property(x => x.NoMusic).IsRequired(true);
            builder.Property(x => x.NameMusic).IsRequired(true).HasColumnType("Nvarchar(500)").HasMaxLength(500);
            builder.Property(x => x.AuthorMusic).IsRequired(true).HasColumnType("Nvarchar(250)").HasMaxLength(250);
            builder.Property(x => x.IdSeason).IsRequired(true);
            builder.Property(x => x.DateCreate).IsRequired(true);
            builder.Property(x => x.IdStatusMusic).IsRequired(true);
            builder.Property(x => x.IdUser).IsRequired(true);
            builder.Property(x => x.IdStaff).IsRequired(true);
            builder.Property(x => x.DateCreate).IsRequired(true);
            builder.Property(x => x.IdSaints).IsRequired(true);
            builder.Property(x => x.Date).IsRequired(true);
            builder.Property(x => x.Month).IsRequired(true);
            builder.Property(x => x.Year).IsRequired(true);
            builder.HasOne(x => x.T_Seasons).WithMany(x => x.T_Musics).HasForeignKey(x => x.IdSeason);
            builder.HasOne(x => x.T_StatusMusics).WithMany(x => x.T_Musics).HasForeignKey(x => x.IdStatusMusic);
            builder.HasOne(x => x.T_Users).WithMany(x => x.T_Musics).HasForeignKey(x => x.IdUser);
            builder.HasOne(x => x.T_Saintes).WithMany(x => x.T_Musics).HasForeignKey(x => x.IdSaints);
        }
    }
}
