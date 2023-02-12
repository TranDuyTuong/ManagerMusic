using DataViewModel.ViewModelAdmin.User_Vm;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagerMusic.Models.FileImage
{
    public class SaveFileChat
    {
        public List<IFormFile> L_File { get; set; }
        public string InfoUser { get; set; }

    }
}
