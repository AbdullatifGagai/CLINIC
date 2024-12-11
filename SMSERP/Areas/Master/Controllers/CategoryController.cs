using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CategoryApiController = ZCLINIC.Areas.Master.APIControllers.CategoryController;

namespace ZCLINIC.Areas.Master.Controllers
{
    [Area("Master")]
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View(new CategoryApiController().CategoryGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        // create/edit view for Category
        public IActionResult ACategory(int id = 0)
        {
            return View(new CategoryApiController().CategoryGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SaveCategory(Category model)
        {
            return new CategoryApiController().CategorySave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string UpdateCategory(Category model)
        {
            return new CategoryApiController().CategoryUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeleteCategory(int id)
        {
            return new CategoryApiController().CategoryDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
    }
}