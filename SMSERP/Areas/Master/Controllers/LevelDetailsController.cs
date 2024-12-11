using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LevelDetailsApiController = ZCLINIC.Areas.Master.APIControllers.LevelDetailsController;

namespace ZCLINIC.Areas.Master.Controllers
{
    [Area("Master")]
    public class LevelDetailsController : Controller
    {
        public IActionResult Index()
        {
            return View(new LevelDetailsApiController().LevelDetailsGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        // create/edit view for LevelDetails
        public IActionResult ALevelDetails(int id = 0)
          {
            return View(new LevelDetailsApiController().LevelDetailsGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SaveLevelDetails(LevelDetails model)
        {
            return new LevelDetailsApiController().LevelDetailsSave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string UpdateLevelDetails(LevelDetails model)
        {
            return new LevelDetailsApiController().LevelDetailsUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeleteLevelDetails(int id)
        {
            return new LevelDetailsApiController().LevelDetailsDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
    
       [HttpGet]
        public List<LevelDetails> GetProductList(int id)
        {
            return new LevelDetails().GetProductList(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
    
     [HttpGet]
        public List<LevelDetails> LevelDetailsGetByCourseId(int id)
        {
            return new LevelDetails().LevelDetailsGetByCourseId(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
    
    
    
    
    
    
    }
}