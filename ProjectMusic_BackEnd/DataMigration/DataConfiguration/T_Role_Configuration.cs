using DataTable.Table.Role;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataMigration.DataConfiguration
{
    public class T_Role_Configuration : IEntityTypeConfiguration<T_Role>
    {
        public void Configure(EntityTypeBuilder<T_Role> builder)
        {
            builder.ToTable("Roles");
            builder.HasKey(x => x.IdRole);
            builder.Property(x => x.IdStatusRole).IsRequired(true);
            builder.Property(x => x.SymbolRole).IsRequired(true).HasColumnType("varchar(50)");
            builder.Property(x => x.Name).IsRequired(true).HasColumnType("Nvarchar(250)");
            builder.Property(x => x.Description).IsRequired(true).HasColumnType("Nvarchar(500)");
            builder.Property(x => x.DateCreate).IsRequired(true);
            builder.HasOne(x => x.T_StatusRoles).WithMany(x => x.T_Roles).HasForeignKey(x => x.IdStatusRole);
        }
    }
}
