using ZCLINIC.Areas.Transaction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Transaction.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class salesDetailController : Controller
    {
        //public List<salesDetail> salesDetailGetAll(BValues bv, string ip, string cInfo)
        //{
        //    return new salesDetail().Transaction_salesDetailGetAll(bv, ip, cInfo);
        //}

        //public salesDetail salesDetailGetById(int id, BValues bv, string ip, string cInfo)
        //{
        //    return new salesDetail().Transaction_salesDetailGetById(id, bv, ip, cInfo);
        //}

        [HttpPost]
        public string salesDetailSave(List<object> objList, string ip, string cInfo)
        {
            return ((salesDetail)objList[0]).Transaction_salesDetailSave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string salesDetailUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((salesDetail)objList[0]).Transaction_salesDetailUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string salesDetailDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new salesDetail().Transaction_salesDetailDelete(id, bv, ip, cInfo);
        }
    }
}