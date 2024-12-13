using ZCLINIC.Areas.URM.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.URM.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class URM_RoleDetailController : Controller
    {
        public List<URM_RoleDetail> URM_RoleDetailGetAll(BValues bv, string ip, string cInfo)
        {
            return new URM_RoleDetail().URM_URM_RoleDetailGetAll(bv, ip, cInfo);
        }

        public URM_RoleDetail URM_RoleDetailGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new URM_RoleDetail().URM_URM_RoleDetailGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string URM_RoleDetailSave(List<object> objList, string ip, string cInfo)
        {
            return ((URM_RoleDetail)objList[0]).URM_URM_RoleDetailSave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string URM_RoleDetailUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((URM_RoleDetail)objList[0]).URM_URM_RoleDetailUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string URM_RoleDetailDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new URM_RoleDetail().URM_URM_RoleDetailDelete(id, bv, ip, cInfo);
        }
    }
}