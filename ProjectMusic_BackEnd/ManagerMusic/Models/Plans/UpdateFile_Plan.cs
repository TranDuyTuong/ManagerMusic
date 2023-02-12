using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagerMusic.Models.Plans
{
    public class UpdateFile_Plan
    {
        public string IdPlan_Json { get; set; }
        public IFormFile FileUpdate { get; set; }
    }
}
