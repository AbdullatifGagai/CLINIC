using ZCLINIC.Areas.Transaction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Transaction.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PurchaseController : Controller
    {
        public List<Purchase> PurchaseGetAll(BValues bv, string ip, string cInfo)
        {
            return new Purchase().Transaction_PurchaseGetAll(bv, ip, cInfo);
        }

        public Purchase PurchaseGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new Purchase().Transaction_PurchaseGetById(id, bv, ip, cInfo);
        }


        [HttpPost]
        public string PurchaseDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new Purchase().Transaction_PurchaseDelete(id, bv, ip, cInfo);
        }
    }
}