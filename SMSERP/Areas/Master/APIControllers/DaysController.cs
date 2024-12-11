using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Master.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DaysController : Controller
    {
        public List<Days> DaysGetAll(BValues bv, string ip, string cInfo)
        {
            return new Days().Master_DaysGetAll(bv, ip, cInfo);
        }

        public Days DaysGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new Days().Master_DaysGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string DaysSave(List<object> objList, string ip, string cInfo)
        {
            return ((Days)objList[0]).Master_DaysSave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string DaysUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((Days)objList[0]).Master_DaysUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string DaysDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new Days().Master_DaysDelete(id, bv, ip, cInfo);
        }
    }
}