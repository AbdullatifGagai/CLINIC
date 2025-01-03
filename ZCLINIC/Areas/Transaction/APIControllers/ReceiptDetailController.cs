using ZCLINIC.Areas.Transaction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Transaction.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ReceiptDetailController : Controller
    {
        //public List<ReceiptDetail> ReceiptDetailGetAll(BValues bv, string ip, string cInfo)
        //{
        //    return new ReceiptDetail().Transaction_ReceiptDetailGetAll(bv, ip, cInfo);
        //}

        public ReceiptDetail ReceiptDetailGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new ReceiptDetail().Transaction_ReceiptDetailGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string ReceiptDetailSave(List<object> objList, string ip, string cInfo)
        {
            return ((ReceiptDetail)objList[0]).Transaction_ReceiptDetailSave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string ReceiptDetailUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((ReceiptDetail)objList[0]).Transaction_ReceiptDetailUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string ReceiptDetailDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new ReceiptDetail().Transaction_ReceiptDetailDelete(id, bv, ip, cInfo);
        }
    }
}