using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Master.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FiscalController : Controller
    {
        public List<Fiscal> FiscalGetAll(BValues bv, string ip, string cInfo)
        {
            return new Fiscal().Master_FiscalGetAll(bv, ip, cInfo);
        }

        public Fiscal FiscalGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new Fiscal().Master_FiscalGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string FiscalSave(List<object> objList, string ip, string cInfo)
        {
            return ((Fiscal)objList[0]).Master_FiscalSave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string FiscalUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((Fiscal)objList[0]).Master_FiscalUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string FiscalDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new Fiscal().Master_FiscalDelete(id, bv, ip, cInfo);
        }
    }
}