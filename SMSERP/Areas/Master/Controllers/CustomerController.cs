using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CustomerApiController = ZCLINIC.Areas.Master.APIControllers.CustomerController;

namespace ZCLINIC.Areas.Master.Controllers
{
    [Area("Master")]
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View(new CustomerApiController().CustomerGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        // create/edit view for Customer
        public IActionResult ACustomer(int id = 0)
        {
            return View(new CustomerApiController().CustomerGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SaveCustomer(Customer model)
        {
            return new CustomerApiController().CustomerSave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string UpdateCustomer(Customer model)
        {
            return new CustomerApiController().CustomerUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeleteCustomer(int id)
        {
            return new CustomerApiController().CustomerDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
    }
}