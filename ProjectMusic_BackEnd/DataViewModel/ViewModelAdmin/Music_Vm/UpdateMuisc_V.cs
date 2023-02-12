using DataViewModel.ViewModelAdmin.Saint_Vm;
using DataViewModel.ViewModelAdmin.Season_Vm;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel.ViewModelAdmin.Music_Vm
{
    public class UpdateMuisc_V
    {
        public Guid IdMuisc { get; set; }
        public string NameMuisc { get; set; }
        public string Author { get; set; }
        public string NameFile { get; set; }
        public IFormFile FormFile_Muisc { get; set; }
        public byte[] ContentFile { get; set; }
        public string MineType { get; set; }
        public IFormFile FormFile_Image { get; set; }
        public string TypeImage { get; set; }
        public byte[] ContentImage { get; set; }
        public Guid IdUser { get; set; }
        public DateTime DateUpdate { get; set; }
        public int IdSeason { get; set; }
        public string NameSeason { get; set; }
        public int IdSaint { get; set; }
        public string NameSaint { get; set; }
        public string TokenData { get; set; }
        public List<GetAllSaint_V> L_Saint { get; set; }
        public List<GetAllSeason_V> L_Season { get; set; }

    }
}
