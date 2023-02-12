using DataTable.Table.Staff;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataMigration.DataConfiguration
{
    public class T_StatusHappyBirthDayStaff_Configuration : IEntityTypeConfiguration<T_StatusHappyBirthDayStaff>
    {
        public void Configure(EntityTypeBuilder<T_StatusHappyBirthDayStaff> builder)
        {
            builder.ToTable("StatusHappyBirthDayStaffs");
            builder.HasKey(x => x.IsStatusSent);
            builder.Property(x => x.IsStatusSent).UseIdentityColumn();
            builder.Property(x => x.Description).IsRequired(true).HasColumnType("Nvarchar(250)").HasMaxLength(250);
            builder.Property(x => x.DateCreate).IsRequired(true);
        }
    }
}
