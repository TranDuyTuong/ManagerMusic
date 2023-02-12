using DataTable.Table.Rating;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataMigration.DataConfiguration
{
    public class T_Rating_Configuration : IEntityTypeConfiguration<T_Rating>
    {
        public void Configure(EntityTypeBuilder<T_Rating> builder)
        {
            builder.ToTable("Ratings");
            builder.HasKey(x => x.IdRating);
            builder.Property(x => x.IdRating).UseIdentityColumn();
            builder.Property(x => x.Rating).IsRequired(true);
            builder.Property(x => x.DateCreate).IsRequired(true);
            builder.Property(x => x.IdMusic).IsRequired(true);
            builder.Property(x => x.IdUser).IsRequired(true);
            builder.HasOne(x => x.T_Musics).WithMany(x => x.T_Ratings).HasForeignKey(x => x.IdMusic);
            builder.HasOne(x => x.T_Users).WithMany(x => x.T_Ratings).HasForeignKey(x => x.IdUser);
        }
    }
}
