using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Master.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LevelsController : Controller
    {
        public List<Levels> LevelsGetAll(BValues bv, string ip, string cInfo)
        {
            return new Levels().Master_LevelsGetAll(bv, ip, cInfo);
        }

        public Levels LevelsGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new Levels().Master_LevelsGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string LevelsSave(List<object> objList, string ip, string cInfo)
        {
            return ((Levels)objList[0]).Master_LevelsSave((BValues)objList[1], ip, cInfo);
        }

         [HttpPost]
        public string Master_LevelsBatchSave(List<object> objList, string ip, string cInfo)
        {
            return ((Levels)objList[0]).Master_LevelsBatchSave((BValues)objList[1], ip, cInfo);
        }






        [HttpPost]
        public string LevelsUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((Levels)objList[0]).Master_LevelsUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string LevelsDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new Levels().Master_LevelsDelete(id, bv, ip, cInfo);
        }
    }
}