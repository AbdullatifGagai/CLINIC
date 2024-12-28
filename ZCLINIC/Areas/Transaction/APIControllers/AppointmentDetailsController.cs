using ZCLINIC.Areas.Transaction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Transaction.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AppointmentDetailsController : Controller
    {
        public List<AppointmentDetails> AppointmentDetailsGetAll(BValues bv, string ip, string cInfo)
        {
            return new AppointmentDetails().Transaction_AppointmentDetailsGetAll(bv, ip, cInfo);
        }

        public AppointmentDetails AppointmentDetailsGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new AppointmentDetails().Transaction_AppointmentDetailsGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string AppointmentDetailsSave(List<object> objList, string ip, string cInfo)
        {
            return ((AppointmentDetails)objList[0]).Transaction_AppointmentDetailsSave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string AppointmentDetailsUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((AppointmentDetails)objList[0]).Transaction_AppointmentDetailsUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string AppointmentDetailsDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new AppointmentDetails().Transaction_AppointmentDetailsDelete(id, bv, ip, cInfo);
        }
    }
}