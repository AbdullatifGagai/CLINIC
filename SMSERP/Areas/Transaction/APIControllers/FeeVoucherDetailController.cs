using ZCLINIC.Areas.Transaction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Transaction.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FeeVoucherDetailController : Controller
    {
        public List<FeeVoucherDetail> FeeVoucherDetailGetAll(BValues bv, string ip, string cInfo)
        {
            return new FeeVoucherDetail().Transaction_FeeVoucherDetailGetAll(bv, ip, cInfo);
        }

        //public FeeVoucherDetail FeeVoucherDetailGetById(int id, BValues bv, string ip, string cInfo)
        //{
        //    return new FeeVoucherDetail().Transaction_FeeVoucherDetailGetById(id, bv, ip, cInfo);
        //}

        [HttpPost]
        public string FeeVoucherDetailSave(List<object> objList, string ip, string cInfo)
        {
            return ((FeeVoucherDetail)objList[0]).Transaction_FeeVoucherDetailSave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string FeeVoucherDetailUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((FeeVoucherDetail)objList[0]).Transaction_FeeVoucherDetailUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string FeeVoucherDetailDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new FeeVoucherDetail().Transaction_FeeVoucherDetailDelete(id, bv, ip, cInfo);
        }
    }
}