using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTable.Table.Music
{
    public class T_UpdateMusic
    {
        public int Id { get; set; }
        public Guid IdMusic { get; set; }
        public Guid IdUser { get; set; }
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
        public DateTime DateUpdate { get; set; }
    }
}
