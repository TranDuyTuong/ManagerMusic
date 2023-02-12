using DataTable.Table.Role;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataMigration.DataConfiguration
{
    public class T_UserRole_Configuration : IEntityTypeConfiguration<T_UserRole>
    {
        public void Configure(EntityTypeBuilder<T_UserRole> builder)
        {
            builder.ToTable("UserRoles");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.IdRole).IsRequired(true);
            builder.Property(x=>x.IdUser).IsRequired(true);
            builder.Property(x => x.DateDecentralization).IsRequired(true);
            builder.HasOne(x => x.T_Roles).WithMany(x => x.T_UserRoles).HasForeignKey(x => x.IdRole);
            builder.HasOne(x => x.T_Users).WithMany(x => x.T_UserRoles).HasForeignKey(x => x.IdUser);
        }
    }
}
