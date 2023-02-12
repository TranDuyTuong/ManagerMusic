using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel.ViewModelAdmin.Music_Vm
{
    public class CreateMusic_V
    {
        public string NoMusic { get; set; }
        public string NameMusic { get; set; }
        public string AuthorMusic { get; set; }
        public int IdSeason { get; set; } //key
        public DateTime DateCreate { get; set; }
        public int IdStatusMusic { get; set; } //key
        public Guid IdUser { get; set; } //key
        public string IdStaff { get; set; }
        public DateTime TimeCreate { get; set; }
        public int IdSaints { get; set; } //key
        public int Date { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public IFormFile FileMusic { get; set; }
        public string FileName { get; set; }
        public byte[] ContentFile { get; set; }
        public string MimeType { get; set; }
        public byte[] ContentFileImage { get; set; }
        public string TypeImage { get; set; }
        public IFormFile FileImage { get; set; }
        public string TokenData { get; set; }
    }
}
