using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel.ViewModelAdmin.User_Vm
{
    public class CreateChatImagesStaff_V
    {
        public Guid IdUser { get; set; }
        public string FullName { get; set; }
        public List<GetAllChatImages_V> L_Images { get; set; }
    }
}
