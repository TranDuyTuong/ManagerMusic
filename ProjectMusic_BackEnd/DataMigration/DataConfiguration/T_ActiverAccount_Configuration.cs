using DataTable.Table.Account;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataMigration.DataConfiguration
{
    public class T_ActiverAccount_Configuration : IEntityTypeConfiguration<T_ActiverAccount>
    {
        public void Configure(EntityTypeBuilder<T_ActiverAccount> builder)
        {
            builder.ToTable("ActiverAccounts");
            builder.HasKey(x => x.IdAccountActiver);
            builder.Property(x => x.IdAccountActiver).UseIdentityColumn();
            builder.Property(x => x.NameAccountActiver).IsRequired(true).HasColumnType("Nvarchar(250)");
            builder.Property(x => x.DateCreate).IsRequired(true);


        }
    }
}
