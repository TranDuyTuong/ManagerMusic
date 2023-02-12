using System;

namespace DataTable.Table.Music
{
    public class T_FileMusic
    {
        public int IdFile { get; set; } //key
        public Guid IdMusic { get; set; } //key
        public string NameFile { get; set; }
        public string MimeType { get; set; }
        public byte[] DataFile { get; set; }
        public DateTime DateCreate { get; set; }
        public string NameImage { get; set; }
        public byte[] DataFieImage { get; set; }
        public string TypeImage { get; set; }
        public T_Music T_Musics { get; set; }
    }
}
