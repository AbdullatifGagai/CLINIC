using ZCLINIC.Areas.Transaction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Transaction.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ReportMasterController : Controller
    {
        public List<ReportMaster> ReportMasterGetAll(BValues bv, string ip, string cInfo)
        {
            return new ReportMaster().Transaction_ReportMasterGetAll(bv, ip, cInfo);
        }

        public ReportMaster ReportMasterGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new ReportMaster().Transaction_ReportMasterGetById(id, bv, ip, cInfo);
        }

        //[HttpPost]
        //public string ReportMasterSave(List<object> objList, string ip, string cInfo)
        //{
        //    return ((ReportMaster)objList[0]).Transaction_ReportMasterSave((BValues)objList[1], ip, cInfo);
        //}

        //[HttpPost]
        //public string ReportMasterUpdate(List<object> objList, string ip, string cInfo)
        //{
        //    return ((ReportMaster)objList[0]).Transaction_ReportMasterUpdate((BValues)objList[1], ip, cInfo);
        //}

        [HttpPost]
        public string ReportMasterDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new ReportMaster().Transaction_ReportMasterDelete(id, bv, ip, cInfo);
        }
    }
}