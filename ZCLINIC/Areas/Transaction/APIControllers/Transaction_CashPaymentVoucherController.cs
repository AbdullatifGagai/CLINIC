using ZCLINIC.Areas.Transaction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Transaction.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class Transaction_CashPaymentVoucherController : Controller
    {
        public List<Transaction_CashPaymentVoucher> Transaction_CashPaymentVoucherGetAll(BValues bv, string ip, string cInfo)
        {
            return new Transaction_CashPaymentVoucher().Transaction_Transaction_CashPaymentVoucherGetAll(bv, ip, cInfo);
        }

        public Transaction_CashPaymentVoucher Transaction_CashPaymentVoucherGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new Transaction_CashPaymentVoucher().Transaction_Transaction_CashPaymentVoucherGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string Transaction_CashPaymentVoucherSave(List<object> objList, string ip, string cInfo)
        {
            return ((Transaction_CashPaymentVoucher)objList[0]).Transaction_Transaction_CashPaymentVoucherSave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string Transaction_CashPaymentVoucherUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((Transaction_CashPaymentVoucher)objList[0]).Transaction_Transaction_CashPaymentVoucherUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string Transaction_CashPaymentVoucherDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new Transaction_CashPaymentVoucher().Transaction_Transaction_CashPaymentVoucherDelete(id, bv, ip, cInfo);
        }
    }
}