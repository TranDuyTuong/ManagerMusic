using DataMigration.DataConfiguration;
using DataMigration.DataExtestion;
using DataTable.Table.Account;
using DataTable.Table.Address;
using DataTable.Table.Comment;
using DataTable.Table.Dowload;
using DataTable.Table.Gender;
using DataTable.Table.Like;
using DataTable.Table.Marriage;
using DataTable.Table.Music;
using DataTable.Table.QRcode;
using DataTable.Table.Rating;
using DataTable.Table.RequestUser;
using DataTable.Table.Role;
using DataTable.Table.Saints;
using DataTable.Table.Season;
using DataTable.Table.Staff;
using DataTable.Table.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataMigration.DataEF
{
    public class ContextDB: IdentityDbContext<T_User, T_Role, Guid>
    {
        public ContextDB(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configure using Fluent API
            modelBuilder.ApplyConfiguration(new T_ActiverAccount_Configuration());
            modelBuilder.ApplyConfiguration(new T_AnswerComment_Configuration());
            modelBuilder.ApplyConfiguration(new T_AnswerGmailRequestPassword_Configuration());
            modelBuilder.ApplyConfiguration(new T_AnswerRequest_Configuration());
            modelBuilder.ApplyConfiguration(new T_BirthdayUser_Configuration());
            modelBuilder.ApplyConfiguration(new T_City_Configuration());
            modelBuilder.ApplyConfiguration(new T_CommentMusic_Configuration());
            modelBuilder.ApplyConfiguration(new T_DeleteNotification_Configuration());
            modelBuilder.ApplyConfiguration(new T_District_Configuration());
            modelBuilder.ApplyConfiguration(new T_DowloadMusic_Configuration());
            modelBuilder.ApplyConfiguration(new T_FileMusic_Configuration());
            modelBuilder.ApplyConfiguration(new T_Gender_Configuration());
            modelBuilder.ApplyConfiguration(new T_HappyBirthdayStaff_Configuration());
            modelBuilder.ApplyConfiguration(new T_ImageQRCore_Configuration());
            modelBuilder.ApplyConfiguration(new T_LeverUser_Configuration());
            modelBuilder.ApplyConfiguration(new T_LikeMusic_Configuration());
            modelBuilder.ApplyConfiguration(new T_Login_Configuration());
            modelBuilder.ApplyConfiguration(new T_Marriage_Configuration());
            modelBuilder.ApplyConfiguration(new T_Music_Configuration());
            modelBuilder.ApplyConfiguration(new T_NotificationUser_Configuration());
            modelBuilder.ApplyConfiguration(new T_Rating_Configuration());
            modelBuilder.ApplyConfiguration(new T_ReadUser_Configuration());
            modelBuilder.ApplyConfiguration(new T_ReceiveRequest_Configuration());
            modelBuilder.ApplyConfiguration(new T_RequestPassword_Configuration());
            modelBuilder.ApplyConfiguration(new T_RequestUser_Configuration());
            modelBuilder.ApplyConfiguration(new T_Role_Configuration());
            modelBuilder.ApplyConfiguration(new T_Saints_Configuration());
            modelBuilder.ApplyConfiguration(new T_Season_Configuration());
            modelBuilder.ApplyConfiguration(new T_StaffOrUser_Configuration());
            modelBuilder.ApplyConfiguration(new T_StatusHappyBirthDayStaff_Configuration());
            modelBuilder.ApplyConfiguration(new T_StatusMusic_Configuration());
            modelBuilder.ApplyConfiguration(new T_StatusSaints_Configuration());
            modelBuilder.ApplyConfiguration(new T_StatusSeason_Configuration());
            modelBuilder.ApplyConfiguration(new T_StatusStaffOff_Configuration());
            modelBuilder.ApplyConfiguration(new T_TypeSentUser_Configuration());
            modelBuilder.ApplyConfiguration(new T_User_Configuration());
            modelBuilder.ApplyConfiguration(new T_UserRole_Configuration());
            modelBuilder.ApplyConfiguration(new T_ViewNotification_Configuration());
            modelBuilder.ApplyConfiguration(new T_StatusRole_Configuration());
            modelBuilder.ApplyConfiguration(new T_UpdateMusic_Configuration());
            modelBuilder.ApplyConfiguration(new T_ChatStaff_Configuration());
            modelBuilder.ApplyConfiguration(new T_ChatImageStaff_Configuration());
            modelBuilder.ApplyConfiguration(new T_HistoryRole_Configuration());
            modelBuilder.ApplyConfiguration(new T_PlanStaff_Configuration());
            modelBuilder.ApplyConfiguration(new T_StatusPlan_Configuration());
            modelBuilder.ApplyConfiguration(new T_FilePlan_Configuration());
            modelBuilder.ApplyConfiguration(new T_NotificationPlan_Configuration());

            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims");
            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles").HasKey(x => new { x.UserId, x.RoleId });
            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x => x.UserId);
            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims");
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens").HasKey(x => x.UserId);

            //Data seeding
            modelBuilder.Seed();
        }
        public DbSet<T_ActiverAccount> T_ActiverAccounts { get; set; }
        public DbSet<T_Login> T_Logins { get; set; }
        public DbSet<T_City> T_Cities { get; set; }
        public DbSet<T_District> T_Districts { get; set; }
        public DbSet<T_AnswerComment> T_AnswerComments { get; set; }
        public DbSet<T_CommentMusic> T_CommentMusic { get; set; }
        public DbSet<T_DowloadMusic> T_DowloadMusics { get; set; }
        public DbSet<T_Gender> T_Genders { get; set; }
        public DbSet<T_LikeMusic> T_LikeMusics { get; set; }
        public DbSet<T_Marriage> T_Marriages { get; set; }
        public DbSet<T_FileMusic> T_FileMusics { get; set; }
        public DbSet<T_Music> T_Musics { get; set; }
        public DbSet<T_StatusMusic> T_StatusMusics { get; set; }
        public DbSet<T_ImageQRCore> T_ImageQRCores { get; set; }
        public DbSet<T_Rating> T_Ratings { get; set; }
        public DbSet<T_AnswerGmailRequestPassword> T_AnswerGmailRequestPasswords { get; set; }
        public DbSet<T_AnswerRequest> T_AnswerRequests { get; set; }
        public DbSet<T_ReadUser> T_ReadUsers { get; set; }
        public DbSet<T_ReceiveRequest> T_ReceiveRequests { get; set; }
        public DbSet<T_RequestPassword> T_RequestPasswords { get; set; }
        public DbSet<T_RequestUser> T_RequestUsers { get; set; }
        public DbSet<T_TypeSentUser> T_TypeSentUsers { get; set; }
        public DbSet<T_Role> T_Roles { get; set; }
        public DbSet<T_StatusRole> T_StatusRoles { get; set; }
        public DbSet<T_UserRole> T_UserRoles { get; set; }
        public DbSet<T_Saints> T_Saints { get; set; }
        public DbSet<T_StatusSaints> T_StatusSaints { get; set; }
        public DbSet<T_Season> T_Seasons { get; set; }
        public DbSet<T_StatusSeason> T_StatusSeasons { get; set; }
        public DbSet<T_HappyBirthdayStaff> T_HappyBirthdayStaffs { get; set; }
        public DbSet<T_StatusHappyBirthDayStaff> T_StatusHappyBirthDayStaffs { get; set; }
        public DbSet<T_StatusStaffOff> T_StatusStaffOffs { get; set; }
        public DbSet<T_BirthdayUser> T_BirthdayUsers { get; set; }
        public DbSet<T_DeleteNotification> T_DeleteNotifications { get; set; }
        public DbSet<T_LeverUser> T_LeverUsers { get; set; }
        public DbSet<T_NotificationUser> T_NotificationUsers { get; set; }
        public DbSet<T_StaffOrUser> T_StaffOrUsers { get; set; }
        public DbSet<T_User> T_Users { get; set; }
        public DbSet<T_ViewNotification> T_ViewNotifications { get; set; }
        public DbSet<T_UpdateMusic> T_UpdateMusics { get; set; }
        public DbSet<T_ChatStaff> T_ChatStaffs { get; set; }
        public DbSet<T_ChatImageStaff> T_ChatImageStaffs { get; set; }
        public DbSet<T_HistoryRole> T_HistoryRoles { get; set; }
        public DbSet<T_PlanStaff> T_PlanStaffs { get; set; }
        public DbSet<T_StatusPlan> T_StatusPlans { get; set; }
        public DbSet<T_FilePlan> T_FilePlans { get; set; }
        public DbSet<T_NotificationPlan> T_NotificationPlans { get; set; }
    }
}
