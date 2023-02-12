using DataTable.Table.Staff;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataMigration.DataConfiguration
{
    public class T_StatusStaffOff_Configuration : IEntityTypeConfiguration<T_StatusStaffOff>
    {
        public void Configure(EntityTypeBuilder<T_StatusStaffOff> builder)
        {
            builder.ToTable("StatusStaffOffs");
            builder.HasKey(x => x.StatusStaffOff);
            builder.Property(x => x.StatusStaffOff).UseIdentityColumn();
            builder.Property(x => x.Description).IsRequired(true).HasColumnType("Nvarchar(250)").HasMaxLength(250);
            builder.Property(x => x.DateCreate).IsRequired(true);
        }
    }
}
