using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ProductApiController = ZCLINIC.Areas.Master.APIControllers.ProductController;

namespace ZCLINIC.Areas.Master.Controllers
{
    [Area("Master")]
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View(new ProductApiController().ProductGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        // create/edit view for Product
        public IActionResult AProduct(int id = 0)
        {
            return View(new ProductApiController().ProductGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SaveProduct(Product model)
        {
            return new ProductApiController().ProductSave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string UpdateProduct(Product model)
        {
            return new ProductApiController().ProductUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeleteProduct(int id)
        {
            return new ProductApiController().ProductDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }


        [HttpGet]
        public List<Product> GetProductName(int Id)
        {
            return new Product().GetProductGetAll(Id,HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }

    }
}