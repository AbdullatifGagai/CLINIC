using ZCLINIC.Areas.URM.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.URM.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class USERAUTHController : Controller
    {
        public List<USERAUTH> USERAUTHGetAll(BValues bv, string ip, string cInfo)
        {
            return new USERAUTH().URM_USERAUTHGetAll(bv, ip, cInfo);
        }

        public USERAUTH USERAUTHGetById(BValues bv, string ip, string cInfo)
        {
            return new USERAUTH().URM_USERAUTHGetById( bv, ip, cInfo);
        }

        //public USERAUTH URM_USERAUTHUSERGetById(BValues bv, string ip, string cInfo)
        //{
        //    return new USERAUTH().URM_USERAUTHUSERGetById( bv, ip, cInfo);
        //}





        [HttpPost]
        public string USERAUTHSave(List<object> objList, string ip, string cInfo)
        {
            return ((USERAUTH)objList[0]).URM_USERAUTHSave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string URM_USERAUTHCompanySave(List<object> objList, string ip, string cInfo)
        {
            return ((USERAUTH)objList[0]).URM_USERAUTHCompanySave((BValues)objList[1], ip, cInfo);
        }








        [HttpPost]
        public string USERAUTHUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((USERAUTH)objList[0]).URM_USERAUTHUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string URM_USERAUTHDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new USERAUTH().URM_USERAUTHDelete(id, bv, ip, cInfo);
        }
    }
}