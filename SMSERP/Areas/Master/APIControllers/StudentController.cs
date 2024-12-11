using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Master.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StudentController : Controller
    {
        //public List<Student> StudentGetAll(BValues bv, string ip, string cInfo)
        //{
        //    return new Student().Master_StudentGetAll(bv, ip, cInfo);
        //}

        public Student StudentGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new Student().Master_StudentGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string StudentSave(List<object> objList, string ip, string cInfo)
        {
            return ((Student)objList[0]).Master_StudentSave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string StudentUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((Student)objList[0]).Master_StudentUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string StudentDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new Student().Master_StudentDelete(id, bv, ip, cInfo);
        }
    }
}