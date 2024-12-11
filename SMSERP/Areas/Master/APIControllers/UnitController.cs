using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Master.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UnitController : Controller
    {
        public List<Unit> UnitGetAll(BValues bv, string ip, string cInfo)
        {
            return new Unit().Master_UnitGetAll(bv, ip, cInfo);
        }

        public Unit UnitGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new Unit().Master_UnitGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string UnitSave(List<object> objList, string ip, string cInfo)
        {
            return ((Unit)objList[0]).Master_UnitSave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string UnitUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((Unit)objList[0]).Master_UnitUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string UnitDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new Unit().Master_UnitDelete(id, bv, ip, cInfo);
        }
    }
}