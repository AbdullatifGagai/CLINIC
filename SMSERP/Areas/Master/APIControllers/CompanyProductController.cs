using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Master.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CompanyProductController : Controller
    {
        public List<CompanyProduct> CompanyProductGetAll(BValues bv, string ip, string cInfo)
        {
            return new CompanyProduct().Master_CompanyProductGetAll(bv, ip, cInfo);
        }

        public CompanyProduct CompanyProductGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new CompanyProduct().Master_CompanyProductGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string CompanyProductSave(List<object> objList, string ip, string cInfo)
        {
            return ((CompanyProduct)objList[0]).Master_CompanyProductSave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string CompanyProductUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((CompanyProduct)objList[0]).Master_CompanyProductUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string CompanyProductDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new CompanyProduct().Master_CompanyProductDelete(id, bv, ip, cInfo);
        }
    }
}