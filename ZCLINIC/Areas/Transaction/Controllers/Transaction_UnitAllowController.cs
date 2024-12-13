using ZCLINIC.Areas.Transaction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Transaction_UnitAllowApiController = ZCLINIC.Areas.Transaction.APIControllers.Transaction_UnitAllowController;
using ZCLINIC.Areas.Master.Models;

namespace ZCLINIC.Areas.Transaction.Controllers
{
    [Area("Transaction")]
    public class Transaction_UnitAllowController : Controller
    {
        public IActionResult Index()
        {
            return View(new Transaction_UnitAllowApiController().Transaction_UnitAllowGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        // create/edit view for Transaction_UnitAllow
        public IActionResult ATransaction_UnitAllow(int id = 0)
        {
            return View(new Transaction_UnitAllowApiController().Transaction_UnitAllowGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SaveTransaction_UnitAllow(Transaction_UnitAllow model)
        {
            return new Transaction_UnitAllowApiController().Transaction_UnitAllowSave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string UpdateTransaction_UnitAllow(Transaction_UnitAllow model)
        {
            return new Transaction_UnitAllowApiController().Transaction_UnitAllowUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

       [HttpPost]
        public string DouPathSaveTransaction_UnitAllow(Transaction_UnitAllow model)
        {
            return new Transaction_UnitAllowApiController().DouPathSaveTransaction_UnitAllow(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

       
        
        
        
        
        [HttpPost]
        public string DeleteTransaction_UnitAllow(int id)
        {
            return new Transaction_UnitAllowApiController().Transaction_UnitAllowDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
        [HttpGet]
        public List<Master_UnitRegistration> UnitList()
        {
            return (new Transaction_UnitAllowApiController().UnitList(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

         [HttpGet]
        public List<Transaction_UnitAllow> GetregId(string SocN)
        {
            return (new Transaction_UnitAllowApiController().GetregId(SocN, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }


          [HttpGet]
        public List<Transaction_UnitAllow> GetUnitListM(int Id)
        {
            return (new Transaction_UnitAllowApiController().GetUnitListM(Id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        
          [HttpGet]
        public List<Transaction_UnitAllow> GetAllowment()
        {
            return (new Transaction_UnitAllowApiController().GetAllowment( HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

          [HttpGet]
        public List<Transaction_UnitAllow> GetAllowmentSearch(string Id)
        {
            return (new Transaction_UnitAllowApiController().GetAllowmentSearch(Id,HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        public IActionResult GetDoument_UnitAllow(int  Id)
        {
           
                var AllowId = new Transaction_UnitAllow().GetDoument_UnitAllow(Id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
                ViewBag.hashcode = AllowId.DocumentPath;
                ViewBag.Id = AllowId.AllowID;
                ViewBag.Script = AllowId.Script;
                                            
            
            return View();
        }



    }
}