using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel.ViewModelAdmin.Users_Vm
{
    public class GetAllSentBirthdayUser_V
    {
        public int Id { get; set; }
        public Guid Iduser { get; set; }
        public string NameUser { get; set; }
        public string TitleSent { get; set; }
        public string ContentSent { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime DateSent { get; set; }
        public bool StatusSent { get; set; }
        public string Str_Birthday { get; set; }
        public string Str_DateSent { get; set; }
    }
}
