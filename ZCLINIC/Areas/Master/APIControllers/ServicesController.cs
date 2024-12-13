using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Master.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ServicesController : Controller
    {
        public List<Services> ServicesGetAll(BValues bv, string ip, string cInfo)
        {
            return new Services().Master_ServicesGetAll(bv, ip, cInfo);
        }

        public Services ServicesGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new Services().Master_ServicesGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string ServicesSave(List<object> objList, string ip, string cInfo)
        {
            return ((Services)objList[0]).Master_ServicesSave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string ServicesUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((Services)objList[0]).Master_ServicesUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string ServicesDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new Services().Master_ServicesDelete(id, bv, ip, cInfo);
        }
    }
}