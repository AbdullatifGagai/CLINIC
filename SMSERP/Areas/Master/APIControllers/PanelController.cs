using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Master.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PanelController : Controller
    {
        public List<Panel> PanelGetAll(BValues bv, string ip, string cInfo)
        {
            return new Panel().Master_PanelGetAll(bv, ip, cInfo);
        }

        public Panel PanelGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new Panel().Master_PanelGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string PanelSave(List<object> objList, string ip, string cInfo)
        {
            return ((Panel)objList[0]).Master_PanelSave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string PanelUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((Panel)objList[0]).Master_PanelUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string PanelDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new Panel().Master_PanelDelete(id, bv, ip, cInfo);
        }
    }
}