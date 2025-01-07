using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using PanelApiController = ZCLINIC.Areas.Master.APIControllers.PanelController;

namespace ZCLINIC.Areas.Master.Controllers
{
    [Area("Master")]
    public class PanelController : Controller
    {
        public IActionResult Index()
        {
            return View(new PanelApiController().PanelGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        // create/edit view for Panel
        public IActionResult APanel(int id = 0)
        {
            return View(new PanelApiController().PanelGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        
        
        public IActionResult PanelRateAdd(int id = 0)
        {
            return View(new PanelRate().Master_PanelRateGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        [HttpPost]
        public string SavePanel(Panel model)
        {
            return new PanelApiController().PanelSave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string UpdatePanel(Panel model)
        {
            return new PanelApiController().PanelUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeletePanel(int id)
        {
            return new PanelApiController().PanelDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
    
        
        }
   
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    }
}