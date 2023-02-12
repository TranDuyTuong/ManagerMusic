using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel.ViewModelAdmin.Music_Vm
{
    public class GetAllHistoryUpdate_V
    {
        public int Id { get; set; }
        public Guid IdMuisc { get; set; }
        public Guid IdUser { get; set; }
        public string NameUser { get; set; }
        public string TokenData { get; set; }
        public string FileNameOld { get; set; }
        public string FileNameNew { get; set; }
        public string NameMusicOld { get; set; }
        public string NameMuiscNew { get; set; }
        public string AuthorOld { get; set; }
        public string AuthorNew { get; set; }
        public int IdSeasonOld { get; set; }
        public int IdSaintOld { get; set; }
        public int IdSeasonNew { get; set; }
        public int IdSaintNew { get; set; }
        public string NameSeason { get; set; }
        public string NameSaint { get; set; }
        public string DateUpdate { get; set; }
    }
}
