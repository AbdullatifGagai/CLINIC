using ZCLINIC.Areas.Transaction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Transaction.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PurchaseDetailController : Controller
    {
        public List<PurchaseDetail> PurchaseDetailGetAll(BValues bv, string ip, string cInfo)
        {
            return new PurchaseDetail().Transaction_PurchaseDetailGetAll(bv, ip, cInfo);
        }

        //public PurchaseDetail PurchaseDetailGetById(int id, BValues bv, string ip, string cInfo)
        //{
        //    return new PurchaseDetail().Transaction_PurchaseDetailGetById(id, bv, ip, cInfo);
        //}

        [HttpPost]
        public string PurchaseDetailSave(List<object> objList, string ip, string cInfo)
        {
            return ((PurchaseDetail)objList[0]).Transaction_PurchaseDetailSave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string PurchaseDetailUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((PurchaseDetail)objList[0]).Transaction_PurchaseDetailUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string PurchaseDetailDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new PurchaseDetail().Transaction_PurchaseDetailDelete(id, bv, ip, cInfo);
        }
    }
}