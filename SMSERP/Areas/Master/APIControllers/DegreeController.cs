using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Master.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DegreeController : Controller
    {
        public List<Degree> DegreeGetAll(BValues bv, string ip, string cInfo)
        {
            return new Degree().Master_DegreeGetAll(bv, ip, cInfo);
        }

        public Degree DegreeGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new Degree().Master_DegreeGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string DegreeSave(List<object> objList, string ip, string cInfo)
        {
            return ((Degree)objList[0]).Master_DegreeSave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string DegreeUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((Degree)objList[0]).Master_DegreeUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string DegreeDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new Degree().Master_DegreeDelete(id, bv, ip, cInfo);
        }
    }
}