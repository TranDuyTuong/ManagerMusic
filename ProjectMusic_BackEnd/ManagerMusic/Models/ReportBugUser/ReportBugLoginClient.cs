using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagerMusic.Models.ReportBugUser
{
    public class ReportBugLoginClient
    {
        public IFormFile ImageBug { get; set; }
        public string SentReportBugClient_V { get; set; }
    }
}
