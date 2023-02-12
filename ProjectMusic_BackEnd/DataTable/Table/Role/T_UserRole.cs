using DataTable.Table.User;
using System;

namespace DataTable.Table.Role
{
    public class T_UserRole
    {
        public int Id { get; set; } //key
        public Guid IdRole { get; set; } //key
        public Guid IdUser { get; set; } //key
        public DateTime DateDecentralization { get; set; }

        public T_Role T_Roles { get; set; }
        public T_User T_Users { get; set; }

    }
}
