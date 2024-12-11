using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Master.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AcadmicYearController : Controller
    {
        public List<AcadmicYear> AcadmicYearGetAll(BValues bv, string ip, string cInfo)
        {
            return new AcadmicYear().Master_AcadmicYearGetAll(bv, ip, cInfo);
        }

        public AcadmicYear AcadmicYearGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new AcadmicYear().Master_AcadmicYearGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string AcadmicYearSave(List<object> objList, string ip, string cInfo)
        {
            return ((AcadmicYear)objList[0]).Master_AcadmicYearSave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string AcadmicYearUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((AcadmicYear)objList[0]).Master_AcadmicYearUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string AcadmicYearDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new AcadmicYear().Master_AcadmicYearDelete(id, bv, ip, cInfo);
        }
    }
}