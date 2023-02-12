using DataTable.Table.User;
using System;

namespace DataTable.Table.Comment
{
    public class T_AnswerComment
    {
        public int IdAnswer { get; set; } //key
        public int IdComment { get; set; } //key
        public Guid IdUser { get; set; } //key
        public string ContentAnswer { get; set; }
        public DateTime DateCreate { get; set; }
        public T_CommentMusic T_CommentMusics { get; set; }
        public T_User T_Users { get; set; }
    }
}
