using ZCLINIC.Areas.Transaction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Transaction.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class salesController : Controller
    {
        public List<sales> salesGetAll(BValues bv, string ip, string cInfo)
        {
            return new sales().Transaction_salesGetAll(bv, ip, cInfo);
        }

        public sales salesGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new sales().Transaction_salesGetById(id, bv, ip, cInfo);
        }

       

       
        [HttpPost]
        public string salesDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new sales().Transaction_salesDelete(id, bv, ip, cInfo);
        }
    }
}