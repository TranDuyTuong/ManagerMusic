using DataViewModel.ViewModelAdmin.Comment_Vm;
using DataViewModel.ViewModelAdmin.Rating_Vm;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel.ViewModelAdmin.Music_Vm
{
    public class DetailMusic_V
    {
        public Guid IdMusic { get; set; }
        public string NoMusic { get; set; }
        public Guid IdUser { get; set; }
        public string IdStaff { get; set; }
        public string NameStaff { get; set; }
        public string NameRole { get; set; }
        public string DateCreate { get; set; }
        public int LikeMusic { get; set; }
        public int NumberDowload { get; set; }
        public string TimeCreate { get; set; }
        public int NumberQR { get; set; }
        public string NameMusic { get; set; }
        public string Author { get; set; }
        public string NameSeason { get; set; }
        public string NameSaint { get; set; }
        public string NameStatus { get; set; }
        public string NameFile { get; set; }
        public byte[] ContentFile { get; set; }
        public byte[] ImageMusic { get; set; }
        public string TypeImage { get; set; }
        public string MimeType { get; set; }

    }
}
