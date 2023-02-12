using DataTable.Table.RequestUser;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataMigration.DataConfiguration
{
    public class T_AnswerGmailRequestPassword_Configuration : IEntityTypeConfiguration<T_AnswerGmailRequestPassword>
    {
        public void Configure(EntityTypeBuilder<T_AnswerGmailRequestPassword> builder)
        {
            builder.ToTable("AnswerGmailRequestPasswords");
            builder.HasKey(x => x.IdAnswerGmail);
            builder.Property(x => x.IdAnswerGmail).UseIdentityColumn();
            builder.Property(x => x.IdRequestPassword).IsRequired(true);
            builder.Property(x => x.IdStaff).IsRequired(true);
            builder.Property(x => x.NameUser).IsRequired(true).HasColumnType("Nvarchar(250)").HasMaxLength(250);
            builder.Property(x => x.TitleAnswer).IsRequired(true).HasColumnType("Nvarchar(450)").HasMaxLength(450);
            builder.Property(x => x.ContentAnswer).IsRequired(true).HasColumnType("Nvarchar(MAX)");
            builder.Property(x => x.DateAnswer).IsRequired(true);
            builder.HasOne(x => x.T_RequestPasswords).WithMany(x => x.T_AnswerGmailRequestPasswords)
                                                            .HasForeignKey(x => x.IdRequestPassword);
        }
    }
}
