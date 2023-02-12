using DataTable.Table.RequestUser;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataMigration.DataConfiguration
{
    public class T_TypeSentUser_Configuration : IEntityTypeConfiguration<T_TypeSentUser>
    {
        public void Configure(EntityTypeBuilder<T_TypeSentUser> builder)
        {
            builder.ToTable("TypeSentUsers");
            builder.HasKey(x => x.IdTypeSent);
            builder.Property(x => x.IdTypeSent).UseIdentityColumn();
            builder.Property(x => x.NameType).IsRequired(true).HasColumnType("Nvarchar(250)");
            builder.Property(x => x.DateCreate).IsRequired(true);
        }
    }
}
