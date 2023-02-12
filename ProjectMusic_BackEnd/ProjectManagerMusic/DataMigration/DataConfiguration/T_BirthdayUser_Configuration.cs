using DataTable.Table.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataMigration.DataConfiguration
{
    public class T_BirthdayUser_Configuration : IEntityTypeConfiguration<T_BirthdayUser>
    {
        public void Configure(EntityTypeBuilder<T_BirthdayUser> builder)
        {
            builder.ToTable("BirthdayUsers");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.IdUser).IsRequired(true);
            builder.Property(x => x.TitleSent).IsRequired(true).HasColumnType("Nvarchar(250)").HasMaxLength(250);
            builder.Property(x => x.ContentSent).IsRequired(true).HasColumnType("Nvarchar(MAX)");
            builder.Property(x => x.BirthdayUser).IsRequired(true);
            builder.Property(x => x.DateSent).IsRequired(true);
            builder.Property(x => x.StatusSent).IsRequired(true);
        }
    }
}
