﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel.ViewModelAdmin.Users_Vm
{
    public class GetInfoUserBirthday_V
    {
        public Guid IdUser { get; set; }
        public string FullName { get; set; }
        public string Gmail { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public IFormFile Attachments { get; set; }
    }
}
