using ZCLINIC.Areas.URM.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.URM.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class URM_RoleController : Controller
    {
        public List<URM_Role> URM_RoleGetAll(BValues bv, string ip, string cInfo)
        {
            return new URM_Role().URM_RoleGetAll(bv, ip, cInfo);
        }

        public URM_Role URM_RoleGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new URM_Role().URM_RoleGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string URM_RoleSave(List<object> objList, string ip, string cInfo)
        {
            return ((URM_Role)objList[0]).URM_RoleSave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string URM_RoleUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((URM_Role)objList[0]).URM_RoleUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string URM_RoleDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new URM_Role().URM_URM_RoleDelete(id, bv, ip, cInfo);
        }
    
    [HttpPost]
        public List<Menu> GetMenuRole(BValues bv, string ip, string cInfo)
        {
            return new URM_Role().GetMenuRole(bv, ip, cInfo);
        }
    
    
    
    }
}