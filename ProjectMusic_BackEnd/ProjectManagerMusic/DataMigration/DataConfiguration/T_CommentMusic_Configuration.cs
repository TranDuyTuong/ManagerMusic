using DataTable.Table.Comment;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataMigration.DataConfiguration
{
    public class T_CommentMusic_Configuration : IEntityTypeConfiguration<T_CommentMusic>
    {
        public void Configure(EntityTypeBuilder<T_CommentMusic> builder)
        {
            builder.ToTable("CommentMusics");
            builder.HasKey(x => x.IdComment);
            builder.Property(x => x.IdComment).UseIdentityColumn();
            builder.Property(x => x.ContentComment).IsRequired(true).HasColumnType("Nvarchar(500)").HasMaxLength(500);
            builder.Property(x => x.DateCreate).IsRequired(true);
            builder.Property(x => x.IdMusic).IsRequired(true);
            builder.Property(x => x.IdUser).IsRequired(true);
            builder.HasOne(x => x.T_Musics).WithMany(x => x.T_CommentMusics).HasForeignKey(x => x.IdMusic);
            builder.HasOne(x => x.T_Users).WithMany(x => x.T_CommentMusics).HasForeignKey(x => x.IdUser);
        }
    }
}
