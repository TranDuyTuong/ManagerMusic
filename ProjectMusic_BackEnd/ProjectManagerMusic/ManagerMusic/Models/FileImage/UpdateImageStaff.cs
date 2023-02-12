using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagerMusic.Models.FileImage
{
    public class UpdateImageStaff
    {
        public IFormFile ImgAvata { get; set; }
        public string UpdateStaff_Json { get; set; }
    }
}
