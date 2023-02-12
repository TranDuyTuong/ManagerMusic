using Microsoft.AspNetCore.Mvc;

namespace ManagerMusic.Controllers
{
    public class HeaderMenuController : Controller
    {
        //HeardMenu
        [HttpGet]
        public IActionResult Index()
        {
            return PartialView();
        }
    }
}
