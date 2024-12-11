using ZCLINIC.Areas.Transaction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Transaction.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class Transaction_CashReceiptVoucherController : Controller
    {
        public List<Transaction_CashReceiptVoucher> Transaction_CashReceiptVoucherGetAll(BValues bv, string ip, string cInfo)
        {
            return new Transaction_CashReceiptVoucher().Transaction_Transaction_CashReceiptVoucherGetAll(bv, ip, cInfo);
        }

        public Transaction_CashReceiptVoucher Transaction_CashReceiptVoucherGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new Transaction_CashReceiptVoucher().Transaction_Transaction_CashReceiptVoucherGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string Transaction_CashReceiptVoucherSave(List<object> objList, string ip, string cInfo)
        {
            return ((Transaction_CashReceiptVoucher)objList[0]).Transaction_Transaction_CashReceiptVoucherSave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string Transaction_CashReceiptVoucherUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((Transaction_CashReceiptVoucher)objList[0]).Transaction_Transaction_CashReceiptVoucherUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string Transaction_CashReceiptVoucherDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new Transaction_CashReceiptVoucher().Transaction_Transaction_CashReceiptVoucherDelete(id, bv, ip, cInfo);
        }
    }
}