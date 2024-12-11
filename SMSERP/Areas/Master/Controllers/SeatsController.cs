using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using SeatsApiController = ZCLINIC.Areas.Master.APIControllers.SeatsController;

namespace ZCLINIC.Areas.Master.Controllers
{
    [Area("Master")]
    public class SeatsController : Controller
    {
        public IActionResult Index()
        {
            return View(new SeatsApiController().SeatsGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        // create/edit view for Seats
        public IActionResult ASeats(int id = 0)
        {
            return View(new SeatsApiController().SeatsGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SaveSeats(Seats model)
        {
            return new SeatsApiController().SeatsSave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string UpdateSeats(Seats model)
        {
            return new SeatsApiController().SeatsUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeleteSeats(int id)
        {
            return new SeatsApiController().SeatsDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
    }
}