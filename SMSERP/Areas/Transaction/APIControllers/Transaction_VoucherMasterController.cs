using ZCLINIC.Areas.Transaction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Transaction.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class Transaction_VoucherMasterController : Controller
    {
        public List<Transaction_VoucherMaster> Transaction_VoucherMasterGetAll(string Voumode,BValues bv, string ip, string cInfo)
        {
            return new Transaction_VoucherMaster().Transaction_VoucherMasterGetAll(bv, ip, cInfo,Voumode);
        }

        public Transaction_VoucherMaster Transaction_VoucherMasterGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new Transaction_VoucherMaster().Transaction_VoucherMasterGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string Transaction_VoucherMasterSave(List<object> objList, string ip, string cInfo)
        {
            return ((Transaction_VoucherMaster)objList[0]).Transaction_VoucherMasterSave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string Transaction_VoucherMasterUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((Transaction_VoucherMaster)objList[0]).Transaction_VoucherMasterUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string Transaction_VoucherMasterDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new Transaction_VoucherMaster().Transaction_VoucherMasterDelete(id, bv, ip, cInfo);
        }
    }
}