using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Master.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SupplierController : Controller
    {
        public List<Supplier> SupplierGetAll(BValues bv, string ip, string cInfo)
        {
            return new Supplier().Master_SupplierGetAll(bv, ip, cInfo);
        }

        public Supplier SupplierGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new Supplier().Master_SupplierGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string SupplierSave(List<object> objList, string ip, string cInfo)
        {
            return ((Supplier)objList[0]).Master_SupplierSave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string SupplierUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((Supplier)objList[0]).Master_SupplierUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string SupplierDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new Supplier().Master_SupplierDelete(id, bv, ip, cInfo);
        }
    }
}