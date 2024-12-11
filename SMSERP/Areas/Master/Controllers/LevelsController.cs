using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LevelsApiController = ZCLINIC.Areas.Master.APIControllers.LevelsController;

namespace ZCLINIC.Areas.Master.Controllers
{
    [Area("Master")]
    public class LevelsController : Controller
    {
        public IActionResult Index()
        {
            return View(new LevelsApiController().LevelsGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }


          public IActionResult IndexNewGroup()
        {
            return View(new LevelsApiController().LevelsGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }


        public IActionResult ANewGroup(int id = 0)
        {
            return View(new LevelsApiController().LevelsGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }








        // create/edit view for Levels
        public IActionResult ALevels(int id = 0)
        {
            return View(new LevelsApiController().LevelsGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SaveLevels(Levels model)
        {
            return new LevelsApiController().LevelsSave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }
        [HttpPost]
        public string Master_LevelsBatchSave(Levels model)
        {
            return new LevelsApiController().Master_LevelsBatchSave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }







        [HttpPost]
        public string UpdateLevels(Levels model)
        {
            return new LevelsApiController().LevelsUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeleteLevels(int id)
        {
            return new LevelsApiController().LevelsDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
    
     [HttpGet]
        public List<Levels> LevelsGetLever(int Id)
        {
            return new Levels().Master_LevelsGetLevelId(Id,HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
    
      [HttpGet]
        public List<Levels> Master_LevelsGetActiveAll()
        {
            return new Levels().Master_LevelsGetActiveAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
    
    
    
    }
}