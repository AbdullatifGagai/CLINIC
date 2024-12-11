using ZCLINIC.Areas.URM.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using URM_RoleApiController = ZCLINIC.Areas.URM.APIControllers.URM_RoleController;

namespace ZCLINIC.Areas.URM.Controllers
{
    [Area("URM")]
    public class URM_RoleController : Controller
    {
        public IActionResult Index()
        {
            return View(new URM_RoleApiController().URM_RoleGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        // create/edit view for URM_Role
        public IActionResult AURM_Role(int id = 0)
        {
            return View(new URM_RoleApiController().URM_RoleGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SaveURM_Role(URM_Role model)
        {
            return new URM_RoleApiController().URM_RoleSave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string UpdateURM_Role(URM_Role model)
        {
            return new URM_RoleApiController().URM_RoleUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeleteURM_Role(int id)
        {
            return new URM_RoleApiController().URM_RoleDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpGet]
        public List<Menu> GetMenuRole()
        {
            return new URM_RoleApiController().GetMenuRole(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }




    }
}