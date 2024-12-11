using ZCLINIC.Areas.Transaction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Transaction.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ReceiptController : Controller
    {
        //public List<Receipt> ReceiptGetAll(BValues bv, string ip, string cInfo)
        //{
        //    return new Receipt().Transaction_ReceiptGetAll(bv, ip, cInfo);
        //}

        public Receipt ReceiptGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new Receipt().Transaction_ReceiptGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string ReceiptSave(List<object> objList, string ip, string cInfo)
        {
            return ((Receipt)objList[0]).Transaction_ReceiptSave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string ReceiptUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((Receipt)objList[0]).Transaction_ReceiptUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string ReceiptDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new Receipt().Transaction_ReceiptDelete(id, bv, ip, cInfo);
        }
    }
}