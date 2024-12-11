using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZCLINIC.Areas.URM.Controllers
{
    [Area("URM")]

    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View(new ZCLINIC.Areas.URM.APIControllers.UserController().UserGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpGet]
        // For Creation of new User/for Edit Purpose as Well
        public IActionResult AUser(int Id = 0)
        {
            return View(new ZCLINIC.Areas.URM.APIControllers.UserController().UserGetById(Id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SaveUser(ZCLINIC.Areas.URM.Models.User user)
        {
            return new ZCLINIC.Areas.URM.APIControllers.UserController().UserSave(new List<object>() { user, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

       

        [HttpPost]
        public string UpdateUser(ZCLINIC.Areas.URM.Models.User user)
        {
            return new ZCLINIC.Areas.URM.APIControllers.UserController().UserUpdate(new List<object>() { user, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        //[HttpPost]
        //public string DeleteUser(int UserId)
        //{
        //    return new ZCLINIC.Areas.URM.APIControllers.UserController().UserDelete(UserId, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        //}

    }
}
