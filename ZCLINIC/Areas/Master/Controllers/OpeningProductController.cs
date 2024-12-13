using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using OpeningProductApiController = ZCLINIC.Areas.Master.APIControllers.OpeningProductController;

namespace ZCLINIC.Areas.Master.Controllers
{
    [Area("Master")]
    public class OpeningProductController : Controller
    {
        public IActionResult Index()
        {
            return View(new OpeningProductApiController().OpeningProductGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        // create/edit view for OpeningProduct
        public IActionResult AOpeningProduct(int id = 0)
        {
            return View(new OpeningProductApiController().OpeningProductGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SaveOpeningProduct(OpeningProduct model)
        {
            return new OpeningProductApiController().OpeningProductSave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string UpdateOpeningProduct(OpeningProduct model)
        {
            return new OpeningProductApiController().OpeningProductUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeleteOpeningProduct(int id)
        {
            return new OpeningProductApiController().OpeningProductDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
    }
}