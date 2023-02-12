using DataTable.Table.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataMigration.DataConfiguration
{
    public class T_ViewNotification_Configuration : IEntityTypeConfiguration<T_ViewNotification>
    {
        public void Configure(EntityTypeBuilder<T_ViewNotification> builder)
        {
            builder.ToTable("ViewNotifications");
            builder.HasKey(x => x.IdViewNotification);
            builder.Property(x => x.IdViewNotification).UseIdentityColumn();
            builder.Property(x => x.Description).HasColumnType("Nvarchar(100)").HasMaxLength(100);
            builder.Property(x => x.DateCreate).IsRequired(true);
        }
    }
}
