using DataTable.Table.RequestUser;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataMigration.DataConfiguration
{
    public class T_RequestUser_Configuration : IEntityTypeConfiguration<T_RequestUser>
    {
        public void Configure(EntityTypeBuilder<T_RequestUser> builder)
        {
            builder.ToTable("RequestUsers");
            builder.HasKey(x => x.IdRequest);
            builder.Property(x => x.IdRequest).UseIdentityColumn();
            builder.Property(x => x.IdUser).IsRequired(true);
            builder.Property(x => x.TitleRequest).IsRequired(true).HasColumnType("Nvarchar(250)").HasMaxLength(250);
            builder.Property(x => x.ContentRequest).IsRequired(true).HasColumnType("Nvarchar(MAX)");
            builder.Property(x => x.DateRequest).IsRequired(true);
            builder.Property(x => x.IdReceiveRequest).IsRequired(true);
            builder.HasOne(x => x.T_Users).WithMany(x => x.T_RequestUsers).HasForeignKey(x => x.IdUser);
            builder.HasOne(x => x.T_ReceiveRequests).WithMany(x => x.T_RequestUsers).HasForeignKey(x => x.IdReceiveRequest);
        }
    }
}
