using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagerMusic.Models.Plans
{
    public class PlanFileStaff
    {
        public List<IFormFile> L_FilePlans { get; set; }
        public string CreatePlan_V { get; set; }
    }
}
