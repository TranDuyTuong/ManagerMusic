using DataTable.Table.Gender;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataMigration.DataConfiguration
{
    public class T_Gender_Configuration : IEntityTypeConfiguration<T_Gender>
    {
        public void Configure(EntityTypeBuilder<T_Gender> builder)
        {
            builder.ToTable("Genders");
            builder.HasKey(x => x.IdGender);
            builder.Property(x => x.IdGender).UseIdentityColumn();
            builder.Property(x => x.NameGender).IsRequired(true).HasColumnType("Nvarchar(100)").HasMaxLength(100);
            builder.Property(x => x.DateCreate).IsRequired(true);
        }
    }
}
