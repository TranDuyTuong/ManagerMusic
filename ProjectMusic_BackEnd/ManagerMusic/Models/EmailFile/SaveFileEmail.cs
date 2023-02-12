using Microsoft.AspNetCore.Http;

namespace ManagerMusic.Models.EmailFile
{
    public class SaveFileEmail
    {
        public IFormFile file { get; set; }
        public string GetInfoUserBirthday_V { get; set; }
    }
}
