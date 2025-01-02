using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Master.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DayEndController : Controller
    {
        public List<DayEnd> DayEndGetAll(BValues bv, string ip, string cInfo)
        {
            return new DayEnd().Master_DayEndGetAll(bv, ip, cInfo);
        }

        public DayEnd DayEndGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new DayEnd().Master_DayEndGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string DayEndSave(List<object> objList, string ip, string cInfo)
        {
            return ((DayEnd)objList[0]).Master_DayEndSave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string DayEndUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((DayEnd)objList[0]).Master_DayEndUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string DayEndDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new DayEnd().Master_DayEndDelete(id, bv, ip, cInfo);
        }
    }
}