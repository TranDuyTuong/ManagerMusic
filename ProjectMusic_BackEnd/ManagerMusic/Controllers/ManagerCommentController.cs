using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static DataUtilities.NameRoleSetting;

namespace ManagerMusic.Controllers
{
    [Authorize]
    public class ManagerCommentController : Controller
    {
        //get all comments for manager
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public IActionResult IndexComments()
        {
            return View();
        }
        [Authorize(Roles = RoleSetting.symbolRole_Satff + "," + RoleSetting.symbolRole_Admin)]
        [HttpGet]
        public IActionResult JsonGetAllComments()
        {
            return new JsonResult(0);
        }

    }
}
