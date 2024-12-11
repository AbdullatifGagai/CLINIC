using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Master_SubAccountApiController = ZCLINIC.Areas.Master.APIControllers.Master_SubAccountController;

namespace ZCLINIC.Areas.Master.Controllers
{
    [Area("Master")]
    public class Master_SubAccountController : Controller
    {
        public IActionResult Index()
        {
            return View(new Master_SubAccountApiController().Master_SubAccountGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        // create/edit view for Master_SubAccount
        public IActionResult AMaster_SubAccount(int id = 0)
        { 
     

         return View(new Master_SubAccountApiController().Master_SubAccountGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));

        }

        [HttpPost]
        public string SaveMaster_SubAccount(Master_SubAccount model)
        {
            return new Master_SubAccountApiController().Master_SubAccountSave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string UpdateMaster_SubAccount(Master_SubAccount model)
        {
            return new Master_SubAccountApiController().Master_SubAccountUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeleteMaster_SubAccount(int id)
        {

        return new Master_SubAccountApiController().Master_SubAccountDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
   
        }
   
    
      [HttpGet]
        public List<Master_SubAccount> GetMasterIdSubAccount(int id)
        {

        return new Master_SubAccountApiController().GetMasterIdSubAccount(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
   
        }
   
      [HttpGet]
        public List<Master_SubAccount> GetSubIdSubAccount(string id)
        {

        return new Master_SubAccountApiController().GetSubIdSubAccount(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
   
        }
   
    
    
    
    
    
    
    
    }
}