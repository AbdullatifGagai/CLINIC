using ZCLINIC.Areas.Transaction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Transaction.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ReportDetailController : Controller
    {
        public List<ReportDetail> ReportDetailGetAll(BValues bv, string ip, string cInfo)
        {
            return new ReportDetail().Transaction_ReportDetailGetAll(bv, ip, cInfo);
        }

        public ReportDetail ReportDetailGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new ReportDetail().Transaction_ReportDetailGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string ReportDetailSave(List<object> objList, string ip, string cInfo)
        {
            return ((ReportDetail)objList[0]).Transaction_ReportDetailSave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string ReportDetailUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((ReportDetail)objList[0]).Transaction_ReportDetailUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string ReportDetailDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new ReportDetail().Transaction_ReportDetailDelete(id, bv, ip, cInfo);
        }
    }
}