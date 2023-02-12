using System;
using System.Collections.Generic;

namespace DataTable.Table.Music
{
    public class T_StatusMusic
    {
        public int IdStatusMusic { get; set; } //key
        public string NameStatusMusic { get; set; }
        public DateTime DateCreate { get; set; }

        public List<T_Music> T_Musics { get; set; }
    }
}
