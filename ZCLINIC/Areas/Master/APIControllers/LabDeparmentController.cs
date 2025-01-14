using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Master.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LabDeparmentController : Controller
    {
        public List<LabDeparment> LabDeparmentGetAll(BValues bv, string ip, string cInfo)
        {
            return new LabDeparment().Master_LabDeparmentGetAll(bv, ip, cInfo);
        }

        public LabDeparment LabDeparmentGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new LabDeparment().Master_LabDeparmentGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string LabDeparmentSave(List<object> objList, string ip, string cInfo)
        {
            return ((LabDeparment)objList[0]).Master_LabDeparmentSave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string LabDeparmentUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((LabDeparment)objList[0]).Master_LabDeparmentUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string LabDeparmentDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new LabDeparment().Master_LabDeparmentDelete(id, bv, ip, cInfo);
        }
    }
}