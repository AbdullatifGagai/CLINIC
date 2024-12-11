using ZCLINIC.Areas.Transaction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Transaction.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PushNotiController : Controller
    {
        public List<PushNoti> PushNotiGetAll(BValues bv, string ip, string cInfo)
        {
            return new PushNoti().Transaction_PushNotiGetAll(bv, ip, cInfo);
        }

        public PushNoti PushNotiGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new PushNoti().Transaction_PushNotiGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string PushNotiSave(List<object> objList, string ip, string cInfo)
        {
            return ((PushNoti)objList[0]).Transaction_PushNotiSave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string PushNotiUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((PushNoti)objList[0]).Transaction_PushNotiUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string PushNotiDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new PushNoti().Transaction_PushNotiDelete(id, bv, ip, cInfo);
        }
    }
}