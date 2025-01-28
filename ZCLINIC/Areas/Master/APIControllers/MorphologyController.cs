using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Master.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MorphologyController : Controller
    {
        public List<Morphology> MorphologyGetAll(BValues bv, string ip, string cInfo)
        {
            return new Morphology().Master_MorphologyGetAll(bv, ip, cInfo);
        }

        public Morphology MorphologyGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new Morphology().Master_MorphologyGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string MorphologySave(List<object> objList, string ip, string cInfo)
        {
            return ((Morphology)objList[0]).Master_MorphologySave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string MorphologyUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((Morphology)objList[0]).Master_MorphologyUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string MorphologyDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new Morphology().Master_MorphologyDelete(id, bv, ip, cInfo);
        }
    }
}