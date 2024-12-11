using ZCLINIC.Areas.URM.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using USERAUTHApiController = ZCLINIC.Areas.URM.APIControllers.USERAUTHController;
using ZCLINIC.Areas.URM.Models;
namespace ZCLINIC.Areas.URM.Controllers
{
    [Area("URM")]
    public class USERAUTHController : Controller
    {
        public IActionResult Index()
        {
            return View(new USERAUTHApiController().USERAUTHGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        // create/edit view for USERAUTH
        public IActionResult AUSERAUTH(int id = 0)
        {
            return View(new USERAUTH().URM_USERAUTHUSERGetById(id,HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        public IActionResult ACOMPANYAUTH(int id = 0)
        {
            return View(new USERAUTHApiController().USERAUTHGetById( HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }






        [HttpPost]
        public string SaveUSERAUTH(USERAUTH model)
        {
            return new USERAUTHApiController().USERAUTHSave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }
         [HttpPost]
        public string SaveCompany(USERAUTH model)
        {



         

            USERAUTH u = model ;
            HttpContext.Session.SetSession(u);

            return new USERAUTHApiController().URM_USERAUTHCompanySave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
           
            





        }

       















        [HttpPost]
        public string UpdateUSERAUTH(USERAUTH model)
        {
            return new USERAUTHApiController().USERAUTHUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeleteUSERAUTH(int id)
        {
            return new USERAUTHApiController().URM_USERAUTHDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }



        public IActionResult AComoanySwitch(int id = 0)
        {
            return View(new USERAUTH().URM_USERAUTHGetById(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }




    }
}