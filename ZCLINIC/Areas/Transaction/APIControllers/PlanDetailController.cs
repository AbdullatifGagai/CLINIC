using ZCLINIC.Areas.Transaction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Transaction.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PlanDetailController : Controller
    {
        public List<PlanDetail> PlanDetailGetAll(BValues bv, string ip, string cInfo)
        {
            return new PlanDetail().Transaction_PlanDetailGetAll(bv, ip, cInfo);
        }

        public PlanDetail PlanDetailGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new PlanDetail().Transaction_PlanDetailGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string PlanDetailSave(List<object> objList, string ip, string cInfo)
        {
            return ((PlanDetail)objList[0]).Transaction_PlanDetailSave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string PlanDetailUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((PlanDetail)objList[0]).Transaction_PlanDetailUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string PlanDetailDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new PlanDetail().Transaction_PlanDetailDelete(id, bv, ip, cInfo);
        }
    }
}