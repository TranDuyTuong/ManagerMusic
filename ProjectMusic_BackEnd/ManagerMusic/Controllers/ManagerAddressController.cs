using DataApplication.ApplicationAdmin.ApplicationAddress.Address_App;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static DataUtilities.NameRoleSetting;

namespace ManagerMusic.Controllers
{
    [Authorize]
    public class ManagerAddressController : Controller
    {
        private readonly IaddressApplication _context;
        public ManagerAddressController(IaddressApplication context)
        {
            _context = context;
        }

        /// <summary>
        /// PageCitys
        /// </summary>
        [Authorize(Roles = RoleSetting.symbolRole_Satff + "," + RoleSetting.symbolRole_Admin)]
        [HttpGet]
        public IActionResult PageCitys()
        {
            return View();
        }

        /// <summary>
        /// JsonGetAllCitys
        /// </summary>
        [Authorize(Roles = RoleSetting.symbolRole_Satff + "," + RoleSetting.symbolRole_Admin)]
        [HttpGet]
        public IActionResult JsonGetAllCitys(int pageSize, int pageIndex, string seach, int orderBy)
        {
            var result = _context.GetAllCitys(pageIndex, pageSize, orderBy, seach);
            return new JsonResult(result);
        }

    }
}
