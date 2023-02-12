using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagerMusic.Models.EmailFile
{
    public class SaveFileEmailRequest
    {
        public List<IFormFile> L_File { get; set; }
        public string ContentAnswerSentRequestUser { get; set; }
    }
}
