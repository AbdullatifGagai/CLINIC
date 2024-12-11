using ZCLINIC.Areas.Transaction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Transaction.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class Transaction_BankReceiptVoucherController : Controller
    {
        public List<Transaction_BankReceiptVoucher> Transaction_BankReceiptVoucherGetAll(BValues bv, string ip, string cInfo)
        {
            return new Transaction_BankReceiptVoucher().Transaction_Transaction_BankReceiptVoucherGetAll(bv, ip, cInfo);
        }

        public Transaction_BankReceiptVoucher Transaction_BankReceiptVoucherGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new Transaction_BankReceiptVoucher().Transaction_Transaction_BankReceiptVoucherGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string Transaction_BankReceiptVoucherSave(List<object> objList, string ip, string cInfo)
        {
            return ((Transaction_BankReceiptVoucher)objList[0]).Transaction_Transaction_BankReceiptVoucherSave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string Transaction_BankReceiptVoucherUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((Transaction_BankReceiptVoucher)objList[0]).Transaction_Transaction_BankReceiptVoucherUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string Transaction_BankReceiptVoucherDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new Transaction_BankReceiptVoucher().Transaction_Transaction_BankReceiptVoucherDelete(id, bv, ip, cInfo);
        }
    }
}