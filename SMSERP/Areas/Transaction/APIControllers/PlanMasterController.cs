using ZCLINIC.Areas.Transaction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Transaction.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PlanMasterController : Controller
    {
        public List<PlanMaster> PlanMasterGetAll(BValues bv, string ip, string cInfo)
        {
            return new PlanMaster().Transaction_PlanMasterGetAll(bv, ip, cInfo);
        }

        public PlanMaster PlanMasterGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new PlanMaster().Transaction_PlanMasterGetById(id, bv, ip, cInfo);
        }

        //[HttpPost]
        //public string PlanMasterSave(List<object> objList, string ip, string cInfo)
        //{
        //    return ((PlanMaster)objList[0]).Transaction_PlanMasterSave((BValues)objList[1], ip, cInfo);
        //}

        //[HttpPost]
        //public string PlanMasterUpdate(List<object> objList, string ip, string cInfo)
        //{
        //    return ((PlanMaster)objList[0]).Transaction_PlanMasterUpdate((BValues)objList[1], ip, cInfo);
        //}

        [HttpPost]
        public string PlanMasterDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new PlanMaster().Transaction_PlanMasterDelete(id, bv, ip, cInfo);
        }
    }
}