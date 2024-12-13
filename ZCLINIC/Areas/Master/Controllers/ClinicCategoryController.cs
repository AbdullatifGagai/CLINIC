using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ClinicCategoryApiController = ZCLINIC.Areas.Master.APIControllers.ClinicCategoryController;

namespace ZCLINIC.Areas.Master.Controllers
{
    [Area("Master")]
    public class ClinicCategoryController : Controller
    {
        public IActionResult Index()
        {
            return View(new ClinicCategoryApiController().ClinicCategoryGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        // create/edit view for ClinicCategory
        public IActionResult AClinicCategory(int id = 0)
        {
            return View(new ClinicCategoryApiController().ClinicCategoryGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SaveClinicCategory(ClinicCategory model)
        {
            return new ClinicCategoryApiController().ClinicCategorySave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string UpdateClinicCategory(ClinicCategory model)
        {
            return new ClinicCategoryApiController().ClinicCategoryUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeleteClinicCategory(int id)
        {
            return new ClinicCategoryApiController().ClinicCategoryDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
    }
}