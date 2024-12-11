using ZCLINIC.Areas.Transaction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Transaction.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class Transaction_JournalVoucherController : Controller
    {
        public List<Transaction_JournalVoucher> Transaction_JournalVoucherGetAll(BValues bv, string ip, string cInfo)
        {
            return new Transaction_JournalVoucher().Transaction_Transaction_JournalVoucherGetAll(bv, ip, cInfo);
        }

        public Transaction_JournalVoucher Transaction_JournalVoucherGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new Transaction_JournalVoucher().Transaction_Transaction_JournalVoucherGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string Transaction_JournalVoucherSave(List<object> objList, string ip, string cInfo)
        {
            return ((Transaction_JournalVoucher)objList[0]).Transaction_Transaction_JournalVoucherSave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string Transaction_JournalVoucherUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((Transaction_JournalVoucher)objList[0]).Transaction_Transaction_JournalVoucherUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string Transaction_JournalVoucherDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new Transaction_JournalVoucher().Transaction_Transaction_JournalVoucherDelete(id, bv, ip, cInfo);
        }
    }
}