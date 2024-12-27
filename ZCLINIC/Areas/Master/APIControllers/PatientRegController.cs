using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Master.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PatientRegController : Controller
    {
        public List<PatientReg> PatientRegGetAll(BValues bv, string ip, string cInfo)
        {
            return new PatientReg().Master_PatientRegGetAll(bv, ip, cInfo);
        }

        public PatientReg PatientRegGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new PatientReg().Master_PatientRegGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string PatientRegSave(List<object> objList, string ip, string cInfo)
        {
            return ((PatientReg)objList[0]).Master_PatientRegSave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string PatientRegUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((PatientReg)objList[0]).Master_PatientRegUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string PatientRegDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new PatientReg().Master_PatientRegDelete(id, bv, ip, cInfo);
        }
    }
}