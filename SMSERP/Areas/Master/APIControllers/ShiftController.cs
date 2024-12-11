using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Master.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ShiftController : Controller
    {
        public List<Shift> ShiftGetAll(BValues bv, string ip, string cInfo)
        {
            return new Shift().Master_ShiftGetAll(bv, ip, cInfo);
        }

        public Shift ShiftGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new Shift().Master_ShiftGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string ShiftSave(List<object> objList, string ip, string cInfo)
        {
            return ((Shift)objList[0]).Master_ShiftSave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string ShiftUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((Shift)objList[0]).Master_ShiftUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string ShiftDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new Shift().Master_ShiftDelete(id, bv, ip, cInfo);
        }
    }
}