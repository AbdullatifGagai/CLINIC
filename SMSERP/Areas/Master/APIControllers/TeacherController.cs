using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Master.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TeacherController : Controller
    {
        public List<Teacher> TeacherGetAll(BValues bv, string ip, string cInfo)
        {
            return new Teacher().Master_TeacherGetAll(bv, ip, cInfo);
        }

        public Teacher TeacherGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new Teacher().Master_TeacherGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string TeacherSave(List<object> objList, string ip, string cInfo)
        {
            return ((Teacher)objList[0]).Master_TeacherSave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string TeacherUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((Teacher)objList[0]).Master_TeacherUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string TeacherDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new Teacher().Master_TeacherDelete(id, bv, ip, cInfo);
        }
    }
}