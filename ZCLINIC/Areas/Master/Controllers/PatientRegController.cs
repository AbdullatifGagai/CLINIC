using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using PatientRegApiController = ZCLINIC.Areas.Master.APIControllers.PatientRegController;

namespace ZCLINIC.Areas.Master.Controllers
{
    [Area("Master")]
    public class PatientRegController : Controller
    {
        public IActionResult Index()
        {
            return View(new PatientRegApiController().PatientRegGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        // create/edit view for PatientReg
        public IActionResult APatientReg(int id = 0)
        {
            return View(new PatientRegApiController().PatientRegGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SavePatientReg(PatientReg model)
        {
            return new PatientRegApiController().PatientRegSave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string UpdatePatientReg(PatientReg model)
        {
            return new PatientRegApiController().PatientRegUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeletePatientReg(int id)
        {
            return new PatientRegApiController().PatientRegDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
    
      [HttpGet]
        public List<PatientReg> Master_Daysbrith(string PAge)
        {
            return new PatientReg().Master_Daysbrith(PAge, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpGet]
        public List<PatientReg> GetPatientName(string PatientName)
        {
            return new PatientReg().GetPatientName(PatientName, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        



    }
}