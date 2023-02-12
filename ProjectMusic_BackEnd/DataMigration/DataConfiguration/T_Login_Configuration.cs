using DataTable.Table.Account;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataMigration.DataConfiguration
{
    public class T_Login_Configuration : IEntityTypeConfiguration<T_Login>
    {
        public void Configure(EntityTypeBuilder<T_Login> builder)
        {
            builder.ToTable("Logins");
            builder.HasKey(x => x.IdLogin);
            builder.Property(x => x.IdUser).IsRequired(true);
            builder.Property(x=>x.DateLogin).IsRequired(true);
            builder.Property(x => x.TimeLogin).IsRequired(true);
            builder.Property(x=>x.TimeSignout).IsRequired(true);
        }
    }
}
