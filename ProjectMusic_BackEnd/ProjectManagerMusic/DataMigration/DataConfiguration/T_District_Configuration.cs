using DataTable.Table.Address;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataMigration.DataConfiguration
{
    public class T_District_Configuration : IEntityTypeConfiguration<T_District>
    {
        public void Configure(EntityTypeBuilder<T_District> builder)
        {
            builder.ToTable("Districts");
            builder.HasKey(x => x.IdDistrict);
            builder.Property(x => x.IdDistrict).UseIdentityColumn();
            builder.Property(x => x.NameDistrict).IsRequired(true).HasColumnType("Nvarchar(300)");
            builder.Property(x => x.DateCreate).IsRequired(true);
            builder.HasOne(x => x.T_Cities).WithMany(x => x.T_Districts).HasForeignKey(x => x.IdCity);
        }
    }
}
