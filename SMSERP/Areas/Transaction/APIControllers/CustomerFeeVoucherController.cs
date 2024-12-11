using ZCLINIC.Areas.Transaction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Transaction.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CustomerFeeVoucherController : Controller
    {
        public List<CustomerFeeVoucher> CustomerFeeVoucherGetAll(BValues bv, string ip, string cInfo)
        {
            return new CustomerFeeVoucher().Transaction_CustomerFeeVoucherGetAll(bv, ip, cInfo);
        }

        public CustomerFeeVoucher CustomerFeeVoucherGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new CustomerFeeVoucher().Transaction_CustomerFeeVoucherGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string CustomerFeeVoucherSave(List<object> objList, string ip, string cInfo)
        {
            return ((CustomerFeeVoucher)objList[0]).Transaction_CustomerFeeVoucherSave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string CustomerFeeVoucherUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((CustomerFeeVoucher)objList[0]).Transaction_CustomerFeeVoucherUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string CustomerFeeVoucherDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new CustomerFeeVoucher().Transaction_CustomerFeeVoucherDelete(id, bv, ip, cInfo);
        }
    }
}