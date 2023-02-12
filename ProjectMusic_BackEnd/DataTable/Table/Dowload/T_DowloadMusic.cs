using DataTable.Table.Music;
using System;

namespace DataTable.Table.Dowload
{
    public class T_DowloadMusic
    {
        public int IdDowload { get; set; } //key
        public Guid IdMusic { get; set; } //key
        public string NameUser { get; set; }
        public Guid? IdUser { get; set; }
        public DateTime DateCreate { get; set; }
        public T_Music T_Musics { get; set; }
    }
}
