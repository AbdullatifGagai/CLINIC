using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Master.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PanelRateController : Controller
    {
        public List<PanelRate> PanelRateGetAll(BValues bv, string ip, string cInfo)
        {
            return new PanelRate().Master_PanelRateGetAll(bv, ip, cInfo);
        }

        public PanelRate PanelRateGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new PanelRate().Master_PanelRateGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string PanelRateSave(List<object> objList, string ip, string cInfo)
        {
            return ((PanelRate)objList[0]).Master_PanelRateSave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string PanelRateUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((PanelRate)objList[0]).Master_PanelRateUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string PanelRateDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new PanelRate().Master_PanelRateDelete(id, bv, ip, cInfo);
        }
    }
}