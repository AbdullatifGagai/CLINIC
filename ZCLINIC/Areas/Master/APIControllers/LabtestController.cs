using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Master.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LabtestController : Controller
    {
        public List<Labtest> LabtestGetAll(BValues bv, string ip, string cInfo)
        {
            return new Labtest().Master_LabtestGetAll(bv, ip, cInfo);
        }

        public Labtest LabtestGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new Labtest().Master_LabtestGetById(id, bv, ip, cInfo);
        }

        //[HttpPost]
        //public string LabtestSave(List<object> objList, string ip, string cInfo)
        //{
        //    return ((Labtest)objList[0]).Master_LabtestSave((BValues)objList[1], ip, cInfo);
        //}

        //[HttpPost]
        //public string LabtestUpdate(List<object> objList, string ip, string cInfo)
        //{
        //    return ((Labtest)objList[0]).Master_LabtestUpdate((BValues)objList[1], ip, cInfo);
        //}

        [HttpPost]
        public string LabtestDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new Labtest().Master_LabtestDelete(id, bv, ip, cInfo);
        }
    }
}