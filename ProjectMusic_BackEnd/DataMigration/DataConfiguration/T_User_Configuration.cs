using DataTable.Table.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataMigration.DataConfiguration
{
    public class T_User_Configuration : IEntityTypeConfiguration<T_User>
    {
        public void Configure(EntityTypeBuilder<T_User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(x => x.IdUser);
            //builder.Property(x => x.IdStaff).IsRequired(true);
            builder.Property(x => x.IdAccountActiver).IsRequired(true);
            builder.Property(x => x.IdLever).IsRequired(true);
            builder.Property(x=>x.IdStaffOrUser).IsRequired(true);
            //builder.Property(x => x.StatusStaffOff).IsRequired(true);
            //builder.Property(x => x.IdMarriage).IsRequired(true);
            builder.Property(x => x.IdGender).IsRequired(true);
            builder.Property(x => x.IdCity).IsRequired(true);
            builder.Property(x => x.IdDistrict).IsRequired(true);
            builder.Property(x => x.FullName).IsRequired(true).HasColumnType("Nvarchar(250)").HasMaxLength(250);
            builder.Property(x => x.Birthday).IsRequired(true);
            builder.Property(x => x.Date).IsRequired(true);
            builder.Property(x => x.Month).IsRequired(true);
            builder.Property(x => x.Year).IsRequired(true);
            builder.Property(x => x.Email).IsRequired(true).HasColumnType("varchar(250)").HasMaxLength(250);
            builder.Property(x => x.PasswordHash).IsRequired(true).HasColumnType("varchar(100)").HasMaxLength(100);
            builder.Property(x => x.DateCreate).IsRequired(true);
            builder.Property(x => x.Age).IsRequired(true);
            builder.Property(x => x.AddressSatff).HasColumnType("Nvarchar(500)").HasMaxLength(500);
            builder.Property(x => x.PhoneStaff).HasColumnType("varchar(15)").HasMaxLength(15);

            builder.HasOne(x => x.T_ActiverAccounts).WithMany(x => x.T_Users).HasForeignKey(x => x.IdAccountActiver);
            builder.HasOne(x => x.T_LeverUsers).WithMany(x => x.T_Users).HasForeignKey(x => x.IdLever);
            builder.HasOne(x => x.T_StaffOrUsers).WithMany(x => x.T_Users).HasForeignKey(x => x.IdStaffOrUser);
            builder.HasOne(x => x.T_StatusStaffOffs).WithMany(x => x.T_Users).HasForeignKey(x => x.StatusStaffOff);
            builder.HasOne(x => x.T_Marriages).WithMany(x => x.T_Users).HasForeignKey(x => x.IdMarriage);
            builder.HasOne(x => x.T_Genders).WithMany(x => x.T_Users).HasForeignKey(x => x.IdGender);
            builder.HasOne(x => x.T_Citys).WithMany(x => x.T_Users).HasForeignKey(x => x.IdCity);
            builder.HasOne(x => x.T_Districts).WithMany(x => x.T_Users).HasForeignKey(x => x.IdDistrict);
            
        }
    }
}
