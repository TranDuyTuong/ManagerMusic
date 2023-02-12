using DataTable.Table.Marriage;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataMigration.DataConfiguration
{
    public class T_Marriage_Configuration : IEntityTypeConfiguration<T_Marriage>
    {
        public void Configure(EntityTypeBuilder<T_Marriage> builder)
        {
            builder.ToTable("Marriages");
            builder.HasKey(x => x.IdMarriage);
            builder.Property(x => x.IdMarriage).UseIdentityColumn();
            builder.Property(x => x.NameMarriage).IsRequired(true).HasColumnType("Nvarchar(250)").HasMaxLength(250);
            builder.Property(x => x.DateCreate).IsRequired(true);
        }
    }
}
