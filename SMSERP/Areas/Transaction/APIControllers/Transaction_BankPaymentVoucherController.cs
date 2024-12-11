using ZCLINIC.Areas.Transaction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Transaction.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class Transaction_BankPaymentVoucherController : Controller
    {
        public List<Transaction_BankPaymentVoucher> Transaction_BankPaymentVoucherGetAll(BValues bv, string ip, string cInfo)
        {
            return new Transaction_BankPaymentVoucher().Transaction_Transaction_BankPaymentVoucherGetAll(bv, ip, cInfo);
        }

        public Transaction_BankPaymentVoucher Transaction_BankPaymentVoucherGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new Transaction_BankPaymentVoucher().Transaction_Transaction_BankPaymentVoucherGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string Transaction_BankPaymentVoucherSave(List<object> objList, string ip, string cInfo)
        {
            return ((Transaction_BankPaymentVoucher)objList[0]).Transaction_Transaction_BankPaymentVoucherSave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string Transaction_BankPaymentVoucherUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((Transaction_BankPaymentVoucher)objList[0]).Transaction_Transaction_BankPaymentVoucherUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string Transaction_BankPaymentVoucherDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new Transaction_BankPaymentVoucher().Transaction_Transaction_BankPaymentVoucherDelete(id, bv, ip, cInfo);
        }
    }
}