using Microsoft.AspNetCore.Mvc;

namespace ManagerMusic.Controllers
{
    public class BaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
