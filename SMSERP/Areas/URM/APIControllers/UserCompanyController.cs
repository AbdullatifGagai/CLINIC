using ZCLINIC.Areas.URM.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.URM.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserCompanyController : Controller
    {
       

        public UserCompany UserCompanyGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new UserCompany().URM_UserCompanyGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string UserCompanySave(List<object> objList, string ip, string cInfo)
        {
            return ((UserCompany)objList[0]).URM_UserCompanySave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string UserCompanyUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((UserCompany)objList[0]).URM_UserCompanyUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string UserCompanyDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new UserCompany().URM_UserCompanyDelete(id, bv, ip, cInfo);
        }
    }
}