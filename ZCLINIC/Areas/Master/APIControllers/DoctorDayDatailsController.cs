using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Master.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DoctorDayDatailsController : Controller
    {
    

        public DoctorDayDatails DoctorDayDatailsGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new DoctorDayDatails().Master_DoctorDayDatailsGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string DoctorDayDatailsSave(List<object> objList, string ip, string cInfo)
        {
            return ((DoctorDayDatails)objList[0]).Master_DoctorDayDatailsSave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string DoctorDayDatailsUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((DoctorDayDatails)objList[0]).Master_DoctorDayDatailsUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string DoctorDayDatailsDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new DoctorDayDatails().Master_DoctorDayDatailsDelete(id, bv, ip, cInfo);
        }
    }
}