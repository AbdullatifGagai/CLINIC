using ZCLINIC.Areas.Transaction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Transaction.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MisReceiptController : Controller
    {
        //public List<MisReceipt> MisReceiptGetAll(BValues bv, string ip, string cInfo)
        //{
        //    return new MisReceipt().Transaction_MisReceiptGetAll(bv, ip, cInfo);
        //}

        public MisReceipt MisReceiptGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new MisReceipt().Transaction_MisReceiptGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string MisReceiptSave(List<object> objList, string ip, string cInfo)
        {
            return ((MisReceipt)objList[0]).Transaction_MisReceiptSave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string MisReceiptUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((MisReceipt)objList[0]).Transaction_MisReceiptUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string MisReceiptDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new MisReceipt().Transaction_MisReceiptDelete(id, bv, ip, cInfo);
        }
    }
}