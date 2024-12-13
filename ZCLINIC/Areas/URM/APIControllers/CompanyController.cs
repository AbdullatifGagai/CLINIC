using ZCLINIC.Areas.URM.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.URM.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CompanyController : Controller
    {
        public List<Company> CompanyGetAll(BValues bv, string ip, string cInfo)
        {
            return new Company().URM_CompanyGetAll(bv, ip, cInfo);
        }

        public Company CompanyGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new Company().URM_CompanyGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string CompanySave(List<object> objList, string ip, string cInfo)
        {
            return ((Company)objList[0]).URM_CompanySave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string CompanyUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((Company)objList[0]).URM_CompanyUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string CompanyDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new Company().URM_CompanyDelete(id, bv, ip, cInfo);
        }
    }
}