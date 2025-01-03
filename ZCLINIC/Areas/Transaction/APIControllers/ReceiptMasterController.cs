using ZCLINIC.Areas.Transaction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Transaction.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ReceiptMasterController : Controller
    {
        public List<ReceiptMaster> ReceiptMasterGetAll(BValues bv, string ip, string cInfo)
        {
            return new ReceiptMaster().Transaction_ReceiptMasterGetAll(bv, ip, cInfo);
        }

        public ReceiptMaster ReceiptMasterGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new ReceiptMaster().Transaction_ReceiptMasterGetById(id, bv, ip, cInfo);
        }

        //[HttpPost]
        //public string ReceiptMasterSave(List<object> objList, string ip, string cInfo)
        //{
        //    return ((ReceiptMaster)objList[0]).Transaction_ReceiptMasterSave((BValues)objList[1], ip, cInfo);
        //}

        //[HttpPost]
        //public string ReceiptMasterUpdate(List<object> objList, string ip, string cInfo)
        //{
        //    return ((ReceiptMaster)objList[0]).Transaction_ReceiptMasterUpdate((BValues)objList[1], ip, cInfo);
        //}

        [HttpPost]
        public string ReceiptMasterDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new ReceiptMaster().Transaction_ReceiptMasterDelete(id, bv, ip, cInfo);
        }
    }
}