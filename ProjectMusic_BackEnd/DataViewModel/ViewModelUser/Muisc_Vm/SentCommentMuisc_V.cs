using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel.ViewModelUser.Muisc_Vm
{
    public class SentCommentMuisc_V
    {
        public Guid IdMuisc { get; set; }
        public Guid IdUser { get; set; }
        public string Content { get; set; }
        public DateTime DateCreate { get; set; }
    }
}
