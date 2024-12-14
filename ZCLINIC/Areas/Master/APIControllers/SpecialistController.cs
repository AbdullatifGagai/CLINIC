using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Master.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SpecialistController : Controller
    {
        public List<Specialist> SpecialistGetAll(BValues bv, string ip, string cInfo)
        {
            return new Specialist().Master_SpecialistGetAll(bv, ip, cInfo);
        }

        public Specialist SpecialistGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new Specialist().Master_SpecialistGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string SpecialistSave(List<object> objList, string ip, string cInfo)
        {
            return ((Specialist)objList[0]).Master_SpecialistSave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string SpecialistUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((Specialist)objList[0]).Master_SpecialistUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string SpecialistDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new Specialist().Master_SpecialistDelete(id, bv, ip, cInfo);
        }
    }
}