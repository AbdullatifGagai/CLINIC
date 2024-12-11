using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MasterAccountApiController = ZCLINIC.Areas.Master.APIControllers.MasterAccountController;
using System.IO;
using System.Data;
using DatabaseTVP_Core;



namespace ZCLINIC.Areas.Master.Controllers

{
    
    [Area("Master")]
    public class MasterAccountController : Controller
    {




        public IActionResult Index()
        {
           



                return View(new MasterAccountApiController().MasterAccountGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
            
            
                 
         }

        // create/edit view for MasterAccount
        public IActionResult AMasterAccount(int id = 0)
        {

                return View(new MasterAccountApiController().MasterAccountGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
          
          
          


        }





        [HttpPost]
        public string SaveMasterAccount(MasterAccount model)
        {
            return new MasterAccountApiController().MasterAccountSave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string UpdateMasterAccount(MasterAccount model)
        {
            return new MasterAccountApiController().MasterAccountUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeleteMasterAccount(int id)
        {



            return new MasterAccountApiController().MasterAccountDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
        
       

        
    }
}