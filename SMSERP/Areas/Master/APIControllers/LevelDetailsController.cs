using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Master.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LevelDetailsController : Controller
    {
        public List<LevelDetails> LevelDetailsGetAll(BValues bv, string ip, string cInfo)
        {
            return new LevelDetails().Master_LevelDetailsGetAll(bv, ip, cInfo);
        }

        public LevelDetails LevelDetailsGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new LevelDetails().Master_LevelDetailsGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string LevelDetailsSave(List<object> objList, string ip, string cInfo)
        {
            return ((LevelDetails)objList[0]).Master_LevelDetailsSave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string LevelDetailsUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((LevelDetails)objList[0]).Master_LevelDetailsUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string LevelDetailsDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new LevelDetails().Master_LevelDetailsDelete(id, bv, ip, cInfo);
        }
    }
}