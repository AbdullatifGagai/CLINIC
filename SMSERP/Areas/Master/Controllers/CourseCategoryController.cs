using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CourseCategoryApiController = ZCLINIC.Areas.Master.APIControllers.CourseCategoryController;

namespace ZCLINIC.Areas.Master.Controllers
{
    [Area("Master")]
    public class CourseCategoryController : Controller
    {
        public IActionResult Index()
        {
            return View(new CourseCategoryApiController().CourseCategoryGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

       


        // create/edit view for CourseCategory
        public IActionResult ACourseCategory(int id = 0)
        {
            return View(new CourseCategoryApiController().CourseCategoryGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SaveCourseCategory(CourseCategory model)
        {
            return new CourseCategoryApiController().CourseCategorySave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string UpdateCourseCategory(CourseCategory model)
        {
            return new CourseCategoryApiController().CourseCategoryUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeleteCourseCategory(int id)
        {
            return new CourseCategoryApiController().CourseCategoryDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
    }
}