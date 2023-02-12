using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel.ViewModelUser.Muisc_Vm
{
    public class CommentMuiscClient_V
    {
        public int IdComments { get; set; }
        public Guid IdMuisc { get; set; }
        public Guid IdUser { get; set; }
        public string NameUser { get; set; }
        public string Content { get; set; }
        public string Str_DateCreate { get; set; }
        public DateTime DateCreate { get; set; }
    }
}
