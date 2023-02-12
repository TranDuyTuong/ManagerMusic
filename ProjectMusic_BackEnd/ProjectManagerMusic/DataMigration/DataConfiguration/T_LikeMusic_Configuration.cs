using DataTable.Table.Like;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataMigration.DataConfiguration
{
    public class T_LikeMusic_Configuration : IEntityTypeConfiguration<T_LikeMusic>
    {
        public void Configure(EntityTypeBuilder<T_LikeMusic> builder)
        {
            builder.ToTable("LikeMusics");
            builder.HasKey(x => x.IdLike);
            builder.Property(x => x.IdLike).UseIdentityColumn();
            builder.Property(x => x.LikeStatus).IsRequired(true);
            builder.Property(x => x.DateLike).IsRequired(true);
            builder.Property(x => x.IdMusic).IsRequired(true);
            builder.Property(x => x.IdUser).IsRequired(true);
            builder.HasOne(x => x.T_Musics).WithMany(x => x.T_LikeMusics).HasForeignKey(x => x.IdMusic);
            builder.HasOne(x => x.T_Users).WithMany(x => x.T_LikeMusics).HasForeignKey(x => x.IdUser);
        }
    }
}
