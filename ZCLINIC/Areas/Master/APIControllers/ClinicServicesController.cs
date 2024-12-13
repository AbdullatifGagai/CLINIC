using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Master.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ClinicServicesController : Controller
    {
        public List<ClinicServices> ClinicServicesGetAll(BValues bv, string ip, string cInfo)
        {
            return new ClinicServices().Master_ClinicServicesGetAll(bv, ip, cInfo);
        }

        public ClinicServices ClinicServicesGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new ClinicServices().Master_ClinicServicesGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string ClinicServicesSave(List<object> objList, string ip, string cInfo)
        {
            return ((ClinicServices)objList[0]).Master_ClinicServicesSave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string ClinicServicesUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((ClinicServices)objList[0]).Master_ClinicServicesUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string ClinicServicesDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new ClinicServices().Master_ClinicServicesDelete(id, bv, ip, cInfo);
        }
    }
}