using ZCLINIC.Areas.Transaction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Transaction.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class Transaction_VoucherDetailController : Controller
    {
        public List<Transaction_VoucherDetail> Transaction_VoucherDetailGetAll(BValues bv, string ip, string cInfo)
        {
            return new Transaction_VoucherDetail().Transaction_VoucherDetailGetAll(bv, ip, cInfo);
        }

        public Transaction_VoucherDetail Transaction_VoucherDetailGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new Transaction_VoucherDetail().Transaction_Transaction_VoucherDetailGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string Transaction_VoucherDetailSave(List<object> objList, string ip, string cInfo)
        {
            return ((Transaction_VoucherDetail)objList[0]).Transaction_Transaction_VoucherDetailSave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string Transaction_VoucherDetailUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((Transaction_VoucherDetail)objList[0]).Transaction_Transaction_VoucherDetailUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string Transaction_VoucherDetailDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new Transaction_VoucherDetail().Transaction_Transaction_VoucherDetailDelete(id, bv, ip, cInfo);
        }
    }
}