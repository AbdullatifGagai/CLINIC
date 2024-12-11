using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Master.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MasterHeadAccController : Controller
    {
        public List<MasterHeadAcc> MasterHeadAccGetAll(BValues bv, string ip, string cInfo)
        {
            return new MasterHeadAcc().Master_HeadAccGetAll(bv, ip, cInfo);
        }

        public MasterHeadAcc MasterHeadAccGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new MasterHeadAcc().Master_HeadAccGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string MasterHeadAccSave(List<object> objList, string ip, string cInfo)
        {
            return ((MasterHeadAcc)objList[0]).Master_HeadAccSave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string MasterHeadAccUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((MasterHeadAcc)objList[0]).Master_HeadAccUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string MasterHeadAccDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new MasterHeadAcc().Master_HeadAccDelete(id, bv, ip, cInfo);
        }
    }
}