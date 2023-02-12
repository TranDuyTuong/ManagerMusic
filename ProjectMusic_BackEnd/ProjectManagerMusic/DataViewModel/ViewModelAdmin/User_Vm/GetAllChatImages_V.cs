using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel.ViewModelAdmin.User_Vm
{
    public class GetAllChatImages_V
    {
        public int Id { get; set; }
        public string NameImage { get; set; }
        public string TypeImage { get; set; }
        public IFormFile FileImage { get; set; }
        public byte[] ContentImage_Doc { get; set; }
        public DateTime DateCreate { get; set; }
        public string DateCreateStr { get; set; }
        public string TimeCreate { get; set; }
        public string MimeType { get; set; }
        public int IdChat { get; set; }
        public string NameUser { get; set; }
        public string ImgBase64 { get; set; }
    }
}
