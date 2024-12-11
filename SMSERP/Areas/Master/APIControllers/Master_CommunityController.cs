using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Master.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class Master_CommunityController : Controller
    {
        public List<Master_Community> Master_CommunityGetAll(BValues bv, string ip, string cInfo)
        {
            return new Master_Community().Master_CommunityGetAll(bv, ip, cInfo);
        }

        public Master_Community Master_CommunityGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new Master_Community().Master_CommunityGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string Master_CommunitySave(List<object> objList, string ip, string cInfo)
        {
            return ((Master_Community)objList[0]).Master_CommunitySave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string Master_CommunityUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((Master_Community)objList[0]).Master_CommunityUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string Master_CommunityDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new Master_Community().Master_CommunityDelete(id, bv, ip, cInfo);
        }
    }
}