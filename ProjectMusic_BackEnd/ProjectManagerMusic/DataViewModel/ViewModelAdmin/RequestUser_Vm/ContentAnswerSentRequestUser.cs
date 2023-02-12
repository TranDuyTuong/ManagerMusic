using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel.ViewModelAdmin.RequestUser_Vm
{
    public class ContentAnswerSentRequestUser
    {
        public List<IFormFile> L_Files { get; set; } = new List<IFormFile>();
        public string ContentSent { get; set; }
        public int IdTypeSent { get; set; }
        public Guid IdUser { get; set; }
        public int IdRequest { get; set; }
        public string IdStaff { get; set; }
        public int IdRead { get; set; }
        public string TitleSent { get; set; }
        public DateTime DateSent { get; set; }
        public string Email { get; set; }
    }
}
