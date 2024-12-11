using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Master.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class Master_DeparmentController : Controller
    {
        public List<Master_Deparment> Master_DeparmentGetAll(BValues bv, string ip, string cInfo)
        {
            return new Master_Deparment().Master_DeparmentGetAll(bv, ip, cInfo);
        }

        public Master_Deparment Master_DeparmentGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new Master_Deparment().Master_DeparmentGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string Master_DeparmentSave(List<object> objList, string ip, string cInfo)
        {
            return ((Master_Deparment)objList[0]).Master_DeparmentSave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string Master_DeparmentUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((Master_Deparment)objList[0]).Master_DeparmentUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string Master_DeparmentDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new Master_Deparment().Master_DeparmentDelete(id, bv, ip, cInfo);
        }
    }
}