using DataViewModel.ViewModelUser.Muisc_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagerMusic.Models.CommentMuisc
{
    public class CommentMuisc
    {
        public List<CommentMuiscClient_V> L_CommentMuisc { get; set; }
        public int TotalComment { get; set; }
        public int UserStatus { get; set; }
    }
}
