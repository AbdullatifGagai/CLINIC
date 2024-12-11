using ZCLINIC.Areas.Transaction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Transaction.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class Transaction_Unit_transferController : Controller
    {
        public List<Transaction_Unit_transfer> Transaction_Unit_transferGetAll(BValues bv, string ip, string cInfo)
        {
            return new Transaction_Unit_transfer().Transaction_UnitTransafarGetAll(bv, ip, cInfo);
        }

        public Transaction_Unit_transfer Transaction_Unit_transferGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new Transaction_Unit_transfer().Transaction_UnitTransafarGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string Transaction_Unit_transferSave(List<object> objList, string ip, string cInfo)
        {
            return ((Transaction_Unit_transfer)objList[0]).Transaction_UnitTransafarSave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string Transaction_Unit_transferUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((Transaction_Unit_transfer)objList[0]).Transaction_UnitTransafarUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string Transaction_Unit_transferDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new Transaction_Unit_transfer().Transaction_UnitTransafarDelete(id, bv, ip, cInfo);
        }
    }
}