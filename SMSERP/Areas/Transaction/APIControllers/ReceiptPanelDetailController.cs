using ZCLINIC.Areas.Transaction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Transaction.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ReceiptPanelDetailController : Controller
    {
        //public List<ReceiptPanelDetail> ReceiptPanelDetailGetAll(BValues bv, string ip, string cInfo)
        //{
        //    return new ReceiptPanelDetail().Transaction_ReceiptPanelDetailGetAll(bv, ip, cInfo);
        //}

        public ReceiptPanelDetail ReceiptPanelDetailGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new ReceiptPanelDetail().Transaction_ReceiptPanelDetailGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string ReceiptPanelDetailSave(List<object> objList, string ip, string cInfo)
        {
            return ((ReceiptPanelDetail)objList[0]).Transaction_ReceiptPanelDetailSave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string ReceiptPanelDetailUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((ReceiptPanelDetail)objList[0]).Transaction_ReceiptPanelDetailUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string ReceiptPanelDetailDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new ReceiptPanelDetail().Transaction_ReceiptPanelDetailDelete(id, bv, ip, cInfo);
        }
    }
}