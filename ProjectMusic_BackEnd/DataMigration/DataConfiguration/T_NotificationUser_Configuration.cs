using DataTable.Table.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataMigration.DataConfiguration
{
    public class T_NotificationUser_Configuration : IEntityTypeConfiguration<T_NotificationUser>
    {
        public void Configure(EntityTypeBuilder<T_NotificationUser> builder)
        {
            builder.ToTable("NotificationUsers");
            builder.HasKey(x => x.IdNotification);
            builder.Property(x => x.IdNotification).UseIdentityColumn();
            builder.Property(x => x.IdUser).IsRequired(true);
            builder.Property(x => x.IdViewNotification).IsRequired(true);
            builder.Property(x => x.IdDeleteNotification).IsRequired(true);
            builder.Property(x => x.TitleNotification).IsRequired(true).HasColumnType("Nvarchar(MAX)");
            builder.Property(x => x.DateCreate).IsRequired(true);
            builder.Property(x => x.TimeCreate).IsRequired(true);
            builder.Property(x => x.AuthorNotification).IsRequired(true).HasColumnType("Nvarchar(250)");
            builder.HasOne(x => x.T_Users).WithMany(x => x.T_NotificationUsers).HasForeignKey(x => x.IdUser);
            builder.HasOne(x => x.T_ViewNotifications).WithMany(x => x.T_NotificationUsers).HasForeignKey(x => x.IdViewNotification);
            builder.HasOne(x => x.T_DeleteNotifications).WithMany(x => x.T_NotificationUsers).HasForeignKey(x => x.IdDeleteNotification);
        }
    }
}
