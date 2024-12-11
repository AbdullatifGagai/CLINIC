using ZCLINIC.Areas.URM.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using URM_RoleDetailApiController = ZCLINIC.Areas.URM.APIControllers.URM_RoleDetailController;

namespace ZCLINIC.Areas.URM.Controllers
{
    [Area("URM")]
    public class URM_RoleDetailController : Controller
    {
        public IActionResult Index()
        {
            return View(new URM_RoleDetailApiController().URM_RoleDetailGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        // create/edit view for URM_RoleDetail
        public IActionResult AURM_RoleDetail(int id = 0)
        {
            return View(new URM_RoleDetailApiController().URM_RoleDetailGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SaveURM_RoleDetail(URM_RoleDetail model)
        {
            return new URM_RoleDetailApiController().URM_RoleDetailSave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string UpdateURM_RoleDetail(URM_RoleDetail model)
        {
            return new URM_RoleDetailApiController().URM_RoleDetailUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeleteURM_RoleDetail(int id)
        {
            return new URM_RoleDetailApiController().URM_RoleDetailDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
    }
}