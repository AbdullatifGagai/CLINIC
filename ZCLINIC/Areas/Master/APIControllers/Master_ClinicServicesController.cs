using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Master.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class Master_ClinicServicesController : Controller
    {
        public List<Master_ClinicServices> Master_ClinicServicesGetAll(BValues bv, string ip, string cInfo)
        {
            return new Master_ClinicServices().Master_Master_ClinicServicesGetAll(bv, ip, cInfo);
        }

        public Master_ClinicServices Master_ClinicServicesGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new Master_ClinicServices().Master_Master_ClinicServicesGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string Master_ClinicServicesSave(List<object> objList, string ip, string cInfo)
        {
            return ((Master_ClinicServices)objList[0]).Master_Master_ClinicServicesSave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string Master_ClinicServicesUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((Master_ClinicServices)objList[0]).Master_Master_ClinicServicesUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string Master_ClinicServicesDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new Master_ClinicServices().Master_Master_ClinicServicesDelete(id, bv, ip, cInfo);
        }
    }
}