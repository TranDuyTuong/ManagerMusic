using DataTable.Table.Music;
using System;
using System.Collections.Generic;

namespace DataTable.Table.Saints
{
    public class T_Saints
    {
        public int IdSaints { get; set; } //key
        public string NameSaints { get; set; }
        public DateTime DateCreate { get; set; }
        public int IdStatusSaints { get; set; } //key
        public string IdStaff { get; set; }
        public string TokenData { get; set; }
        public Guid IdUser { get; set; }

        public T_StatusSaints T_StatusSaintes { get; set; }

        public List<T_Music> T_Musics { get; set; }
    }
}
