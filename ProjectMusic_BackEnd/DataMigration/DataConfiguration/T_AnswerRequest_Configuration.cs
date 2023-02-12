using DataTable.Table.RequestUser;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataMigration.DataConfiguration
{
    public class T_AnswerRequest_Configuration : IEntityTypeConfiguration<T_AnswerRequest>
    {
        public void Configure(EntityTypeBuilder<T_AnswerRequest> builder)
        {
            builder.ToTable("AnswerRequests");
            builder.HasKey(x => x.IdAnswer);
            builder.Property(x => x.IdAnswer).UseIdentityColumn();
            builder.Property(x => x.IdTypeSent).IsRequired(true);
            builder.Property(x => x.IdUser).IsRequired(true);
            builder.Property(x => x.IdStaff).IsRequired(true);
            builder.Property(x => x.IdRequest).IsRequired(true);
            builder.Property(x => x.IdRead).IsRequired(true);
            builder.Property(x => x.TitleSent).IsRequired(true).HasColumnType("Nvarchar(450)").HasMaxLength(450);
            builder.Property(x => x.ContentSent).IsRequired(true).HasColumnType("Nvarchar(MAX)");
            builder.Property(x => x.DateSent).IsRequired(true);
            builder.HasOne(x => x.T_TypeSentUsers).WithMany(x => x.T_AnswerRequests).HasForeignKey(x => x.IdTypeSent);
            builder.HasOne(x => x.T_Users).WithMany(x => x.T_AnswerRequests).HasForeignKey(x => x.IdUser);
            builder.HasOne(x => x.T_RequestUsers).WithMany(x => x.T_AnswerRequests).HasForeignKey(x => x.IdRequest);
            builder.HasOne(x => x.T_ReadUsers).WithMany(x => x.T_AnswerRequests).HasForeignKey(x => x.IdRead);
        }
    }
}
