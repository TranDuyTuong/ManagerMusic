using DataTable.Table.User;
using System;

namespace DataTable.Table.Staff
{
    public class T_HappyBirthdayStaff
    {
        public int Id { get; set; } //key
        public Guid IdUser { get; set; } //key
        public int IsStatusSent { get; set; } //key
        public string TitleSent { get; set; }
        public string ContentSent { get; set; }
        public DateTime DateCreate { get; set; }

        public T_User T_Users { get; set; }
        public T_StatusHappyBirthDayStaff T_StatusHappyBirthDayStaffs { get; set; }




    }
}
