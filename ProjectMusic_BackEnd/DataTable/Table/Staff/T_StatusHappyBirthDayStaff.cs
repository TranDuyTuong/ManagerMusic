using System;
using System.Collections.Generic;

namespace DataTable.Table.Staff
{
    public class T_StatusHappyBirthDayStaff
    {
        public int IsStatusSent { get; set; } //key
        public string Description { get; set; } //success, error
        public DateTime DateCreate { get; set; }

        public List<T_HappyBirthdayStaff> T_HappyBirthdayStaffs { get; set; }
    }
}
