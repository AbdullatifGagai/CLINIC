using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using SemesterApiController = ZCLINIC.Areas.Master.APIControllers.SemesterController;

namespace ZCLINIC.Areas.Master.Controllers
{
    [Area("Master")]
    public class SemesterController : Controller
    {
        public IActionResult Index()
        {
            return View(new SemesterApiController().SemesterGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        // create/edit view for Semester
        public IActionResult ASemester(int id = 0)
        {
            return View(new SemesterApiController().SemesterGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SaveSemester(Semester model)
        {
            return new SemesterApiController().SemesterSave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string UpdateSemester(Semester model)
        {
            return new SemesterApiController().SemesterUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeleteSemester(int id)
        {
            return new SemesterApiController().SemesterDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
    }
}