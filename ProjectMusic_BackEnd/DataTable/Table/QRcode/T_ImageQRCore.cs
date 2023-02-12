using DataTable.Table.Music;
using System;

namespace DataTable.Table.QRcode
{
    public class T_ImageQRCore
    {
        public int IdQRcore { get; set; } //key
        public Guid IdMusic { get; set; } //key
        public string TitleImage { get; set; }
        public byte[] ImageData { get; set; }
        public DateTime DateCreate { get; set; }

        public T_Music T_Musics { get; set; }
    }
}
