using DataTable.Table.Season;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataMigration.DataConfiguration
{
    public class T_StatusSeason_Configuration : IEntityTypeConfiguration<T_StatusSeason>
    {
        public void Configure(EntityTypeBuilder<T_StatusSeason> builder)
        {
            builder.ToTable("StatusSeasons");
            builder.HasKey(x => x.IdStatusSeason);
            builder.Property(x => x.IdStatusSeason).UseIdentityColumn();
            builder.Property(x => x.NameStatus).IsRequired(true).HasColumnType("Nvarchar(250)").HasMaxLength(250);
            builder.Property(x => x.DateCreate).IsRequired(true);
        }
    }
}
