using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ManagerMusic.Controllers
{
    [Authorize]
    public class InfomationController : Controller
    {
        //infomation user and admin
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
