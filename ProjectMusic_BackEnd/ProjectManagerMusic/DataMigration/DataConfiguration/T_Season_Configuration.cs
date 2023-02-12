using DataTable.Table.Season;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataMigration.DataConfiguration
{
    public class T_Season_Configuration : IEntityTypeConfiguration<T_Season>
    {
        public void Configure(EntityTypeBuilder<T_Season> builder)
        {
            builder.ToTable("Seasons");
            builder.HasKey(x => x.IdSeason);
            builder.Property(x => x.IdSeason).UseIdentityColumn();
            builder.Property(x => x.IdStatusSeason).IsRequired(true);
            builder.Property(x => x.NameSeason).IsRequired(true).HasColumnType("Nvarchar(500)").HasMaxLength(500);
            builder.Property(x => x.DateCreate).IsRequired(true);
            builder.HasOne(x => x.T_StatusSeasons).WithMany(x => x.T_Seasons).HasForeignKey(x => x.IdStatusSeason);
        }
    }
}
