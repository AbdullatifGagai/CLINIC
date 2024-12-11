using ZCLINIC.Areas.Transaction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Transaction.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FeeVoucherController : Controller
    {
        public List<FeeVoucher> FeeVoucherGetAll(BValues bv, string ip, string cInfo)
        {
            return new FeeVoucher().Transaction_FeeVoucherGetAll(bv, ip, cInfo);
        }

        public FeeVoucher FeeVoucherGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new FeeVoucher().Transaction_FeeVoucherGetById(id, bv, ip, cInfo);
        }


        [HttpPost]

        [HttpPost]
        public string FeeVoucherDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new FeeVoucher().Transaction_FeeVoucherDelete(id, bv, ip, cInfo);
        }
    }
}