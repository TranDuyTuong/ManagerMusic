using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagerMusic.Models.FileImage
{
    public class UpdateFileMuisc
    {
        public IFormFile FileMusic { get; set; }
        public IFormFile FileImage { get; set; }
        public string UpdateMuisc_V { get; set; }
    }
}
