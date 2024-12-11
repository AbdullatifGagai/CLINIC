using ZCLINIC.Areas.Transaction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Transaction.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ReceiptPanelMasterController : Controller
    {
        public List<ReceiptPanelMaster> ReceiptPanelMasterGetAll(BValues bv, string ip, string cInfo)
        {
            return new ReceiptPanelMaster().Transaction_ReceiptPanelMasterGetAll(bv, ip, cInfo);
        }

        public ReceiptPanelMaster ReceiptPanelMasterGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new ReceiptPanelMaster().Transaction_ReceiptPanelMasterGetById(id, bv, ip, cInfo);
        }

        //[HttpPost]
        //public string ReceiptPanelMasterSave(List<object> objList, string ip, string cInfo)
        //{
        //    return ((ReceiptPanelMaster)objList[0]).Transaction_ReceiptPanelMasterSave((BValues)objList[1], ip, cInfo);
        //}

        //[HttpPost]
        //public string ReceiptPanelMasterUpdate(List<object> objList, string ip, string cInfo)
        //{
        //    return ((ReceiptPanelMaster)objList[0]).Transaction_ReceiptPanelMasterUpdate((BValues)objList[1], ip, cInfo);
        //}

        [HttpPost]
        public string ReceiptPanelMasterDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new ReceiptPanelMaster().Transaction_ReceiptPanelMasterDelete(id, bv, ip, cInfo);
        }
    }
}