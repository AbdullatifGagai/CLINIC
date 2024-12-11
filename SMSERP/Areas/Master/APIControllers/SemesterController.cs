using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Master.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SemesterController : Controller
    {
        public List<Semester> SemesterGetAll(BValues bv, string ip, string cInfo)
        {
            return new Semester().Master_SemesterGetAll(bv, ip, cInfo);
        }

        public Semester SemesterGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new Semester().Master_SemesterGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string SemesterSave(List<object> objList, string ip, string cInfo)
        {
            return ((Semester)objList[0]).Master_SemesterSave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string SemesterUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((Semester)objList[0]).Master_SemesterUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string SemesterDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new Semester().Master_SemesterDelete(id, bv, ip, cInfo);
        }
    }
}