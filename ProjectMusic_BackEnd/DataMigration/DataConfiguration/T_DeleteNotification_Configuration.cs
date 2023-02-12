using DataTable.Table.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataMigration.DataConfiguration
{
    public class T_DeleteNotification_Configuration : IEntityTypeConfiguration<T_DeleteNotification>
    {
        public void Configure(EntityTypeBuilder<T_DeleteNotification> builder)
        {
            builder.ToTable("DeleteNotifications");
            builder.HasKey(x => x.IdDeleteNotification);
            builder.Property(x => x.IdDeleteNotification).UseIdentityColumn();
            builder.Property(x => x.Description).IsRequired(true).HasColumnType("Nvarchar(450)").HasMaxLength(450);
            builder.Property(x => x.DateCreate).IsRequired(true);
        }
    }
}
