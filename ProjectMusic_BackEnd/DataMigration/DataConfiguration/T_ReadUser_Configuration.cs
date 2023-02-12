using DataTable.Table.RequestUser;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataMigration.DataConfiguration
{
    public class T_ReadUser_Configuration : IEntityTypeConfiguration<T_ReadUser>
    {
        public void Configure(EntityTypeBuilder<T_ReadUser> builder)
        {
            builder.ToTable("ReadUsers");
            builder.HasKey(x => x.IdRead);
            builder.Property(x => x.IdRead).UseIdentityColumn();
            builder.Property(x => x.ReadContent).IsRequired(true);
            builder.Property(x => x.DateCreate).IsRequired(true);
        }
    }
}
