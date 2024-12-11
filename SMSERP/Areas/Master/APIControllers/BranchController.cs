using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Master.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BranchController : Controller
    {
        public List<Branch> BranchGetAll(BValues bv, string ip, string cInfo)
        {
            return new Branch().Master_BranchGetAll(bv, ip, cInfo);
        }

        public Branch BranchGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new Branch().Master_BranchGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string BranchSave(List<object> objList, string ip, string cInfo)
        {
            return ((Branch)objList[0]).Master_BranchSave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string BranchUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((Branch)objList[0]).Master_BranchUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string BranchDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new Branch().Master_BranchDelete(id, bv, ip, cInfo);
        }
    }
}