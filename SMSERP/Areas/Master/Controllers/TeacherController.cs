using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TeacherApiController = ZCLINIC.Areas.Master.APIControllers.TeacherController;

namespace ZCLINIC.Areas.Master.Controllers
{
    [Area("Master")]
    public class TeacherController : Controller
    {
        public IActionResult Index()
        {
            return View(new TeacherApiController().TeacherGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        // create/edit view for Teacher
        public IActionResult ATeacher(int id = 0)
        {
            return View(new TeacherApiController().TeacherGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SaveTeacher(Teacher model)
        {
            return new TeacherApiController().TeacherSave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string UpdateTeacher(Teacher model)
        {
            return new TeacherApiController().TeacherUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeleteTeacher(int id)
        {
            return new TeacherApiController().TeacherDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
    }
}