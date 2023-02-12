using System;
using System.Collections.Generic;

namespace DataTable.Table.Saints
{
    public class T_StatusSaints
    {
        public int IdIdStatusSaints { get; set; } //key
        public string NameStatusSaints { get; set; }
        public DateTime DateCreate { get; set; }

        public List<T_Saints> T_Saintes { get; set; }

    }
}
