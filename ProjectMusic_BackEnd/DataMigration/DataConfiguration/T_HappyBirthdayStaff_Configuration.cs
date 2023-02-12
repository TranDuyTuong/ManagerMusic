using DataTable.Table.Staff;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataMigration.DataConfiguration
{
    public class T_HappyBirthdayStaff_Configuration : IEntityTypeConfiguration<T_HappyBirthdayStaff>
    {
        public void Configure(EntityTypeBuilder<T_HappyBirthdayStaff> builder)
        {
            builder.ToTable("HappyBirthdayStaffs");
            builder.HasKey(x=>x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.IdUser).IsRequired(true);
            builder.Property(x => x.IsStatusSent).IsRequired(true);
            builder.Property(x => x.TitleSent).IsRequired(true).HasColumnType("Nvarchar(250)").HasMaxLength(250);
            builder.Property(x => x.ContentSent).IsRequired(true).HasColumnType("Nvarchar(MAX)");
            builder.Property(x => x.DateCreate).IsRequired(true);
            builder.HasOne(x => x.T_Users).WithMany(x => x.T_HappyBirthdayStaffs).HasForeignKey(x => x.IdUser);
            builder.HasOne(x => x.T_StatusHappyBirthDayStaffs).WithMany(x => x.T_HappyBirthdayStaffs).HasForeignKey(x => x.IsStatusSent);
        }
    }
}
