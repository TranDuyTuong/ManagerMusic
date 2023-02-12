using DataTable.Table.Comment;
using DataTable.Table.Dowload;
using DataTable.Table.Like;
using DataTable.Table.QRcode;
using DataTable.Table.Rating;
using DataTable.Table.Saints;
using DataTable.Table.Season;
using DataTable.Table.User;
using System;
using System.Collections.Generic;

namespace DataTable.Table.Music
{
    public class T_Music
    {
        public Guid IdMusic { get; set; } //key
        public string NoMusic { get; set; }
        public string NameMusic { get; set; }
        public string AuthorMusic { get; set; }
        public int IdSeason { get; set; } //key
        public DateTime DateCreate { get; set; }
        public int IdStatusMusic { get; set; } //key
        public Guid IdUser { get; set; } //key
        public string IdStaff { get; set; }
        public DateTime TimeCreate { get; set; }
        public int IdSaints { get; set; } //key
        public int Date { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public string TokenData { get; set; }

        public T_Season T_Seasons { get; set; }
        public T_StatusMusic T_StatusMusics { get; set; }
        public T_User T_Users { get; set; }
        public T_Saints T_Saintes { get; set; }

        public List<T_CommentMusic> T_CommentMusics { get; set; }
        public List<T_DowloadMusic> T_DowloadMusics { get; set; }
        public List<T_LikeMusic> T_LikeMusics { get; set; }
        public List<T_FileMusic> T_FileMusics { get; set; }
        public List<T_ImageQRCore> T_ImageQRCores { get; set; }
        public List<T_Rating> T_Ratings { get; set; }


    }
}
