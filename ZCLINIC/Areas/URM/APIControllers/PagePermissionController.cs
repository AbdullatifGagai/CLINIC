using ZCLINIC.Areas.URM.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.URM.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PagePermissionController : Controller
    {
        public List<PagePermission> PagePermissionGetAll(BValues bv, string ip, string cInfo)
        {
            return new PagePermission().URM_PagePermissionGetAll(bv, ip, cInfo);
        }

        public PagePermission PagePermissionGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new PagePermission().URM_PagePermissionGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string PagePermissionSave(List<object> objList, string ip, string cInfo)
        {
            return ((PagePermission)objList[0]).URM_PagePermissionSave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string PagePermissionUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((PagePermission)objList[0]).URM_PagePermissionUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string PagePermissionDelete(List<object> objList, BValues bv, string ip, string cInfo)
        {
            return ((PagePermission)objList[0]).URM_PagePermissionDelete((BValues)objList[1], ip, cInfo);
        }
    }
}