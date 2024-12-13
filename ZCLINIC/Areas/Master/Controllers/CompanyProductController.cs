using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CompanyProductApiController = ZCLINIC.Areas.Master.APIControllers.CompanyProductController;

namespace ZCLINIC.Areas.Master.Controllers
{
    [Area("Master")]
    public class CompanyProductController : Controller
    {
        public IActionResult Index()
        {
            return View(new CompanyProductApiController().CompanyProductGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        // create/edit view for CompanyProduct
        public IActionResult ACompanyProduct(int id = 0)
        {
            return View(new CompanyProductApiController().CompanyProductGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SaveCompanyProduct(CompanyProduct model)
        {
            return new CompanyProductApiController().CompanyProductSave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string UpdateCompanyProduct(CompanyProduct model)
        {
            return new CompanyProductApiController().CompanyProductUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeleteCompanyProduct(int id)
        {
            return new CompanyProductApiController().CompanyProductDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
    }
}