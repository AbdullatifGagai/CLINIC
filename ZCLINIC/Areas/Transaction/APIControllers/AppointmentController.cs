using ZCLINIC.Areas.Transaction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Transaction.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AppointmentController : Controller
    {
        public List<Appointment> AppointmentGetAll(BValues bv, string ip, string cInfo)
        {
            return new Appointment().Transaction_AppointmentGetAll(bv, ip, cInfo);
        }

        public Appointment AppointmentGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new Appointment().Transaction_AppointmentGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string AppointmentSave(List<object> objList, string ip, string cInfo)
        {
            return ((Appointment)objList[0]).Transaction_AppointmentSave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string AppointmentUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((Appointment)objList[0]).Transaction_AppointmentUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string AppointmentDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new Appointment().Transaction_AppointmentDelete(id, bv, ip, cInfo);
        }
    }
}