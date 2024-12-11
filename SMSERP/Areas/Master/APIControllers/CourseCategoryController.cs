using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Master.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CourseCategoryController : Controller
    {
        public List<CourseCategory> CourseCategoryGetAll(BValues bv, string ip, string cInfo)
        {
            return new CourseCategory().Master_CourseCategoryGetAll(bv, ip, cInfo);
        }

        public CourseCategory CourseCategoryGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new CourseCategory().Master_CourseCategoryGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string CourseCategorySave(List<object> objList, string ip, string cInfo)
        {
            return ((CourseCategory)objList[0]).Master_CourseCategorySave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string CourseCategoryUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((CourseCategory)objList[0]).Master_CourseCategoryUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string CourseCategoryDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new CourseCategory().Master_CourseCategoryDelete(id, bv, ip, cInfo);
        }
    }
}