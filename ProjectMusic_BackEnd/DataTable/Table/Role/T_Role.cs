using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace DataTable.Table.Role
{
    public class T_Role: IdentityRole<Guid>
    {
        public Guid IdRole { get; set; } //key
        public int IdStatusRole { get; set; } //key
        public string SymbolRole { get; set; } //NV -> staff, ND -> user, AD ->Admin
        public string Description { get; set; }
        public DateTime DateCreate { get; set; }

        public T_StatusRole T_StatusRoles { get; set; }
        public List<T_UserRole> T_UserRoles { get; set; }

    }
}
