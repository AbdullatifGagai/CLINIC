using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Master.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SeatsController : Controller
    {
        public List<Seats> SeatsGetAll(BValues bv, string ip, string cInfo)
        {
            return new Seats().Master_SeatsGetAll(bv, ip, cInfo);
        }

        public Seats SeatsGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new Seats().Master_SeatsGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string SeatsSave(List<object> objList, string ip, string cInfo)
        {
            return ((Seats)objList[0]).Master_SeatsSave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string SeatsUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((Seats)objList[0]).Master_SeatsUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string SeatsDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new Seats().Master_SeatsDelete(id, bv, ip, cInfo);
        }
    }
}