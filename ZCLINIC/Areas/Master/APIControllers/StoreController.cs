using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Master.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StoreController : Controller
    {
        public List<Store> StoreGetAll(BValues bv, string ip, string cInfo)
        {
            return new Store().Master_StoreGetAll(bv, ip, cInfo);
        }

        public Store StoreGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new Store().Master_StoreGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string StoreSave(List<object> objList, string ip, string cInfo)
        {
            return ((Store)objList[0]).Master_StoreSave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string StoreUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((Store)objList[0]).Master_StoreUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string StoreDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new Store().Master_StoreDelete(id, bv, ip, cInfo);
        }
    }
}