using DataTable.Table.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataMigration.DataConfiguration
{
    public class T_StaffOrUser_Configuration : IEntityTypeConfiguration<T_StaffOrUser>
    {
        public void Configure(EntityTypeBuilder<T_StaffOrUser> builder)
        {
            builder.ToTable("StaffOrUsers");
            builder.HasKey(x => x.IdStaffOrUser);
            builder.Property(x => x.IdStaffOrUser).UseIdentityColumn();
            builder.Property(x => x.symbol).IsRequired(true).HasColumnType("varchar(10)").HasMaxLength(10);
            builder.Property(x => x.Description).IsRequired(true).HasColumnType("Nvarchar(250)").HasMaxLength(250);
            builder.Property(x => x.DateCreate).IsRequired(true);
            builder.Property(x => x.Status).IsRequired(true);
        }
    }
}
