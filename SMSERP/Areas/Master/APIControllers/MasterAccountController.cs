using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data;

namespace ZCLINIC.Areas.Master.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MasterAccountController : Controller
    {
        public List<MasterAccount> MasterAccountGetAll(BValues bv, string ip, string cInfo)
        {
            return new MasterAccount().Master_MasterAccountGetAll(bv, ip, cInfo);
        }

        public MasterAccount MasterAccountGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new MasterAccount().Master_MasterAccountGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string MasterAccountSave(List<object> objList, string ip, string cInfo)
        {
            return ((MasterAccount)objList[0]).Master_MasterAccountSave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string MasterAccountUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((MasterAccount)objList[0]).Master_MasterAccountUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string MasterAccountDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new MasterAccount().Master_MasterAccountDelete(id, bv, ip, cInfo);
        }

        public DataTable Master_MasterAccountGetMasterId(BValues bv, string ip, string cInfo)
        {
            return new MasterAccount().Master_MasterAccountGetMasterId(bv, ip, cInfo);
        }


    }
}