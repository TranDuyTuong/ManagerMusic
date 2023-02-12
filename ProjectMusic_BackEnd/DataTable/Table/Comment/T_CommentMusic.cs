using DataTable.Table.Music;
using DataTable.Table.User;
using System;
using System.Collections.Generic;

namespace DataTable.Table.Comment
{
    public class T_CommentMusic
    {
        public int IdComment { get; set; } //key
        public Guid IdMusic { get; set; } //key
        public Guid IdUser { get; set; } //key
        public string ContentComment { get; set; }
        public DateTime DateCreate { get; set; }
        public T_Music T_Musics { get; set; }
        public T_User T_Users { get; set; }
        public List<T_AnswerComment> T_AnswerComments { get; set; }
    }
}
