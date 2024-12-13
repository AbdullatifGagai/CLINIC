using SMSERP.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace SMSERP.Areas.Master.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ClinicCategoryController : Controller
    {
        public List<ClinicCategory> ClinicCategoryGetAll(BValues bv, string ip, string cInfo)
        {
            return new ClinicCategory().Master_ClinicCategoryGetAll(bv, ip, cInfo);
        }

        public ClinicCategory ClinicCategoryGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new ClinicCategory().Master_ClinicCategoryGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string ClinicCategorySave(List<object> objList, string ip, string cInfo)
        {
            return ((ClinicCategory)objList[0]).Master_ClinicCategorySave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string ClinicCategoryUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((ClinicCategory)objList[0]).Master_ClinicCategoryUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string ClinicCategoryDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new ClinicCategory().Master_ClinicCategoryDelete(id, bv, ip, cInfo);
        }
    }
}