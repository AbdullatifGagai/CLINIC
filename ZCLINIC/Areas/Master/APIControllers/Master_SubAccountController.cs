using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Master.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class Master_SubAccountController : Controller
    {
        public List<Master_SubAccount> Master_SubAccountGetAll(BValues bv, string ip, string cInfo)
        {
            return new Master_SubAccount().Master_SubAccountGetAll(bv, ip, cInfo);
        }

        public Master_SubAccount Master_SubAccountGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new Master_SubAccount().Master_SubAccountGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string Master_SubAccountSave(List<object> objList, string ip, string cInfo)
        {
            return ((Master_SubAccount)objList[0]).Master_SubAccountSave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string Master_SubAccountUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((Master_SubAccount)objList[0]).Master_SubAccountUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string Master_SubAccountDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new Master_SubAccount().Master_SubAccountDelete(id, bv, ip, cInfo);
        }
   
        [HttpPost]
        public List<Master_SubAccount> GetMasterIdSubAccount(int id, BValues bv, string ip, string cInfo)
        {
            return new Master_SubAccount().GetMasterIdSubAccount(id, bv, ip, cInfo);
        }
   
    
    
        [HttpPost]
        public List<Master_SubAccount> GetSubIdSubAccount(string id, BValues bv, string ip, string cInfo)
        {
            return new Master_SubAccount().GetSubIdSubAccount(id, bv, ip, cInfo);
        }
   
    
    
    
    }
}