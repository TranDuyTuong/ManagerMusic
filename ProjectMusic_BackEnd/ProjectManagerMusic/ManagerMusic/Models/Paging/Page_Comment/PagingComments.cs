using DataViewModel.ViewModelAdmin.Comment_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagerMusic.Models.Paging.Page_Comment
{
    public class PagingComments
    {
        public IEnumerable<GetAllComment_Vm> L_Comments { get; set; }
        public int TotalComment { get; set; } 
    }
}
