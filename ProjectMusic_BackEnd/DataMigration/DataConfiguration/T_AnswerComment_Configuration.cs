using DataTable.Table.Comment;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataMigration.DataConfiguration
{
    public class T_AnswerComment_Configuration : IEntityTypeConfiguration<T_AnswerComment>
    {
        public void Configure(EntityTypeBuilder<T_AnswerComment> builder)
        {
            builder.ToTable("AnswerComments");
            builder.HasKey(x => x.IdAnswer);
            builder.Property(x => x.IdAnswer).UseIdentityColumn();
            builder.Property(x => x.ContentAnswer).IsRequired(true).HasColumnType("Nvarchar(500)").HasMaxLength(500);
            builder.Property(x => x.DateCreate).IsRequired(true);
            builder.Property(x => x.IdComment).IsRequired(true);
            builder.Property(x => x.IdUser).IsRequired(true);
            builder.HasOne(x => x.T_CommentMusics).WithMany(x => x.T_AnswerComments).HasForeignKey(x => x.IdComment);
            builder.HasOne(x => x.T_Users).WithMany(x => x.T_AnswerComments).HasForeignKey(x => x.IdUser);
        }
    }
}
