using Microsoft.AspNetCore.Http;

namespace ManagerMusic.Models.FileImage
{
    public class SaveFileMusic
    {
        public IFormFile fileDoc { get; set; }
        public IFormFile fileImage { get; set; }
        public string Music { get; set; }
    }
}
