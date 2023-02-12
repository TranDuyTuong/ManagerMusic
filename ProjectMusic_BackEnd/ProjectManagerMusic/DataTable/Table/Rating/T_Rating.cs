using DataTable.Table.Music;
using DataTable.Table.User;
using System;

namespace DataTable.Table.Rating
{
    public class T_Rating
    {
        public int IdRating { get; set; } //key
        public Guid IdMusic { get; set; } //key
        public Guid IdUser { get; set; } //key
        public int Rating { get; set; }
        public DateTime DateCreate { get; set; }

        public T_Music T_Musics { get; set; }
        public T_User T_Users { get; set; }
    }
}
