using DataTable.Table.RequestUser;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataMigration.DataConfiguration
{
    public class T_ReceiveRequest_Configuration : IEntityTypeConfiguration<T_ReceiveRequest>
    {
        public void Configure(EntityTypeBuilder<T_ReceiveRequest> builder)
        {
            builder.ToTable("ReceiveRequests");
            builder.HasKey(x => x.IdReceiveRequest);
            builder.Property(x => x.IdReceiveRequest).UseIdentityColumn();
            builder.Property(x => x.Description).IsRequired(true).HasColumnType("Nvarchar(250)").HasMaxLength(250);
            builder.Property(x => x.DateCreate).IsRequired(true);
        }
    }
}
