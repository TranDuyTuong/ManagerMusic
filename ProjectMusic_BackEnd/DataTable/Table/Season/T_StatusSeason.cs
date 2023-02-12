using System;
using System.Collections.Generic;

namespace DataTable.Table.Season
{
    public class T_StatusSeason
    {
        public int IdStatusSeason { get; set; } //key
        public string NameStatus { get; set; }
        public DateTime DateCreate { get; set; }

        public List<T_Season> T_Seasons { get; set; }
    }
}
