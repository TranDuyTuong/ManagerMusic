using DataTable.Table.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataMigration.DataConfiguration
{
    public class T_LeverUser_Configuration : IEntityTypeConfiguration<T_LeverUser>
    {
        public void Configure(EntityTypeBuilder<T_LeverUser> builder)
        {
            builder.ToTable("LeverUsers");
            builder.HasKey(x => x.IdLever);
            builder.Property(x => x.IdLever).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired(true).HasColumnType("Nvarchar(250)").HasMaxLength(250);
            builder.Property(x => x.DescriptionName).IsRequired(true).HasColumnType("Nvarchar(MAX)");
            builder.Property(x => x.DateCreate).IsRequired(true);
        }
    }
}
