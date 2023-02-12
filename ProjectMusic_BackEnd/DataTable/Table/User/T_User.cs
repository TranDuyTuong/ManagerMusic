using DataTable.Table.Account;
using DataTable.Table.Address;
using DataTable.Table.Comment;
using DataTable.Table.Gender;
using DataTable.Table.Like;
using DataTable.Table.Marriage;
using DataTable.Table.Music;
using DataTable.Table.Rating;
using DataTable.Table.RequestUser;
using DataTable.Table.Role;
using DataTable.Table.Staff;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace DataTable.Table.User
{
    public class T_User: IdentityUser<Guid>
    {
        public Guid IdUser { get; set; } //key
        public string IdStaff { get; set; } //key
        public int IdAccountActiver { get; set; } //key
        public int IdLever { get; set; } //key
        public int IdStaffOrUser { get; set; } //key
        public int? StatusStaffOff { get; set; } //key
        public int? IdMarriage { get; set; } //key
        public int IdGender { get; set; } //key
        public int IdCity { get; set; } //key
        public int IdDistrict { get; set; } //key
        public DateTime? DateStaffOff { get; set; }
        public DateTime? DateAccountBlock { get; set; }
        public DateTime Birthday { get; set; }
        public string FullName { get; set; }
        public int Date { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public DateTime DateCreate { get; set; }
        public int Age { get; set; }
        public byte[] ImageAvata { get; set; }
        public string TypeImage { get; set; }
        public string NameFile { get; set; }
        public DateTime? DateUpdate { get; set; } //date edit infomation
        public string AddressSatff { get; set; } //staff
        public string PhoneStaff { get; set; } //staff
        public int? CancelHideStaff { get; set; } //staff, 1 -> thuê, 2 -> hủy thuê
        public string TokenData { get; set; }
        public int TotalChat { get; set; }
        public bool WasView { get; set; }

        public T_ActiverAccount T_ActiverAccounts { get; set; }
        public T_LeverUser T_LeverUsers { get; set; }
        public T_StaffOrUser T_StaffOrUsers { get; set; }
        public T_StatusStaffOff T_StatusStaffOffs { get; set; }
        public T_Marriage T_Marriages { get; set; }
        public T_Gender T_Genders { get; set; }
        public T_City T_Citys { get; set; }
        public T_District T_Districts { get; set; }

        public List<T_CommentMusic> T_CommentMusics { get; set; }
        public List<T_AnswerComment> T_AnswerComments { get; set; }
        public List<T_LikeMusic> T_LikeMusics { get; set; }
        public List<T_Music> T_Musics { get; set; }
        public List<T_Rating> T_Ratings { get; set; }
        public List<T_AnswerRequest> T_AnswerRequests { get; set; }
        public List<T_RequestUser> T_RequestUsers { get; set; }
        public List<T_UserRole> T_UserRoles { get; set; }
        public List<T_HappyBirthdayStaff> T_HappyBirthdayStaffs { get; set; }
        public List<T_BirthdayUser> T_BirthdayUseres { get; set; }
        public List<T_NotificationUser> T_NotificationUsers { get; set; }


    }
}
