using DataTable.Table.RequestUser;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataMigration.DataConfiguration
{
    public class T_RequestPassword_Configuration : IEntityTypeConfiguration<T_RequestPassword>
    {
        public void Configure(EntityTypeBuilder<T_RequestPassword> builder)
        {
            builder.ToTable("RequestPasswords");
            builder.HasKey(x => x.IdRequestPassword);
            builder.Property(x => x.IdRequestPassword).UseIdentityColumn();
            builder.Property(x => x.IdReceiveRequest).IsRequired(true);
            builder.Property(x => x.NameUser).IsRequired(true).HasColumnType("Nvarchar(250)").HasMaxLength(250);
            builder.Property(x => x.TitleRequest).IsRequired(true).HasColumnType("Nvarchar(500)").HasMaxLength(500);
            builder.Property(x => x.ContentRequest).IsRequired(true).HasColumnType("Nvarchar(MAX)");
            builder.Property(x => x.GmailRequest).IsRequired(true).HasColumnType("varchar(250)").HasMaxLength(250);
            builder.Property(x => x.ImageRequest).IsRequired(true);
            builder.Property(x => x.DateRequest).IsRequired(true);
            builder.HasOne(x => x.T_ReceiveRequests).WithMany(x => x.T_RequestPasswords).HasForeignKey(x => x.IdReceiveRequest);
        }
    }
}
