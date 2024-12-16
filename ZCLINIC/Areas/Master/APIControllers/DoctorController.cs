using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Master.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DoctorController : Controller
    {
        public List<Doctor> DoctorGetAll(BValues bv, string ip, string cInfo)
        {
            return new Doctor().Master_DoctorGetAll(bv, ip, cInfo);
        }

        //public Doctor DoctorGetById(int id, BValues bv, string ip, string cInfo)
        //{
        //    return new Doctor().Master_DoctorGetById(id, bv, ip, cInfo);
        //}

        //[HttpPost]
        //public string DoctorSave(List<object> objList, string ip, string cInfo)
        //{
        //    return ((Doctor)objList[0]).Master_DoctorSave((BValues)objList[1], ip, cInfo);
        //}

        //[HttpPost]
        //public string DoctorUpdate(List<object> objList, string ip, string cInfo)
        //{
        //    return ((Doctor)objList[0]).Master_DoctorUpdate((BValues)objList[1], ip, cInfo);
        //}

        [HttpPost]
        public string DoctorDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new Doctor().Master_DoctorDelete(id, bv, ip, cInfo);
        }
    }
}