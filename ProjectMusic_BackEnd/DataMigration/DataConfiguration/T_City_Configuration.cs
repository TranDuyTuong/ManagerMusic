using DataTable.Table.Address;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataMigration.DataConfiguration
{
    public class T_City_Configuration : IEntityTypeConfiguration<T_City>
    {
        public void Configure(EntityTypeBuilder<T_City> builder)
        {
            builder.ToTable("Citys");
            builder.HasKey(x => x.IdCity);
            builder.Property(x => x.IdCity).UseIdentityColumn();
            builder.Property(x => x.NameCity).IsRequired(true).HasColumnType("Nvarchar(300)");
            builder.Property(x => x.DateCreate).IsRequired(true);
            builder.Property(x => x.Symbol).IsRequired(true);
            builder.Property(x => x.AreaCode).IsRequired(true);
        }
    }
}
