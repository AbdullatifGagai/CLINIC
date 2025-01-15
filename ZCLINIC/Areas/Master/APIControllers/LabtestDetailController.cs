using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Master.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LabtestDetailController : Controller
    {
        public List<LabtestDetail> LabtestDetailGetAll(BValues bv, string ip, string cInfo)
        {
            return new LabtestDetail().Master_LabtestDetailGetAll(bv, ip, cInfo);
        }

        public LabtestDetail LabtestDetailGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new LabtestDetail().Master_LabtestDetailGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string LabtestDetailSave(List<object> objList, string ip, string cInfo)
        {
            return ((LabtestDetail)objList[0]).Master_LabtestDetailSave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string LabtestDetailUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((LabtestDetail)objList[0]).Master_LabtestDetailUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string LabtestDetailDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new LabtestDetail().Master_LabtestDetailDelete(id, bv, ip, cInfo);
        }
    }
}