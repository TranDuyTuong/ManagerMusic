using DataViewModel.ViewModelAdmin.Users_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagerMusic.Models.Paging.Page_Comment
{
    public class PagingCommentByIdUser
    {
        public List<GetAllCommentByIdUser_V> L_Comment { get; set; }
        public int TotalComment { get; set; }
    }
}
