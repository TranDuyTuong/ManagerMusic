using DataTable.Table.Music;
using System;
using System.Collections.Generic;

namespace DataTable.Table.Season
{
    public class T_Season
    {
        public int IdSeason { get; set; } //key
        public string NameSeason { get; set; }
        public DateTime DateCreate { get; set; }
        public int IdStatusSeason { get; set; } //key

        public T_StatusSeason T_StatusSeasons { get; set; }

        public List<T_Music> T_Musics { get; set; }
    }
}
