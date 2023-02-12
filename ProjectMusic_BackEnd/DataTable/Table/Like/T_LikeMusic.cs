using DataTable.Table.Music;
using DataTable.Table.User;
using System;

namespace DataTable.Table.Like
{
    public class T_LikeMusic
    {
        public int IdLike { get; set; } //key
        public Guid IdMusic { get; set; } //key
        public Guid IdUser { get; set; } //key
        public bool LikeStatus { get; set; }
        public DateTime DateLike { get; set; }
        public T_Music T_Musics { get; set; }
        public T_User T_Users { get; set; }

    }
}
