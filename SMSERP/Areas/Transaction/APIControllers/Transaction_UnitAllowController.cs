using ZCLINIC.Areas.Transaction.Models;



using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ZCLINIC.Areas.Master.Models;

namespace ZCLINIC.Areas.Transaction.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class Transaction_UnitAllowController : Controller
    {
        public List<Transaction_UnitAllow> Transaction_UnitAllowGetAll(BValues bv, string ip, string cInfo)
        {
            return new Transaction_UnitAllow().Transaction_UnitAllowGetAll(bv, ip, cInfo);
        }

        public Transaction_UnitAllow Transaction_UnitAllowGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new Transaction_UnitAllow().Transaction_UnitAllowGetById(id, bv, ip, cInfo);
        }
        public Transaction_UnitAllow GetDoument_UnitAllow(int id, BValues bv, string ip, string cInfo)
        {
            return new Transaction_UnitAllow().GetDoument_UnitAllow(id, bv, ip, cInfo);
        }
      

        [HttpPost]
        public string Transaction_UnitAllowSave(List<object> objList, string ip, string cInfo)
        {
            return ((Transaction_UnitAllow)objList[0]).Transaction_UnitAllowSave((BValues)objList[1], ip, cInfo);
        }
        
        
        [HttpPost]
        public string SaveTransaction_RegId(List<object> objList, string ip, string cInfo)
        {
            return ((Transaction_UnitAllow)objList[0]).Transaction_UnitAllowSave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string Transaction_UnitAllowUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((Transaction_UnitAllow)objList[0]).Transaction_UnitAllowUpdate((BValues)objList[1], ip, cInfo);
        }

           [HttpPost]
        public string DouPathSaveTransaction_UnitAllow(List<object> objList, string ip, string cInfo)
        {
            return ((Transaction_UnitAllow)objList[0]).DouPathSaveTransaction_UnitAllow((BValues)objList[1], ip, cInfo);
        }











        [HttpPost]
        public string Transaction_UnitAllowDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new Transaction_UnitAllow().Transaction_UnitAllowDelete(id, bv, ip, cInfo);
        }


        [HttpGet]

        public List<Master_UnitRegistration> UnitList(BValues bv, string ip, string cinfo)
        {
            return new Transaction_UnitAllow().Transaction_UnitList(bv, ip, cinfo);
        }
         [HttpGet]

        public List<Transaction_UnitAllow> GetregId(string SocN, BValues bv, string ip, string cinfo)
        {
            return new Transaction_UnitAllow().Transaction_GetregId(SocN, bv, ip, cinfo);
        }

         [HttpGet]

        public List<Transaction_UnitAllow> GetUnitListM(int Id, BValues bv, string ip, string cinfo)
        {
            return new Transaction_UnitAllow().GetUnitListM(Id, bv, ip, cinfo);
        }
         [HttpGet]

        public List<Transaction_UnitAllow> GetAllowment(BValues bv, string ip, string cinfo)
        {
            return new Transaction_UnitAllow().Transaction_UnitAllowGetAll(bv, ip, cinfo);
        }
          [HttpGet]

        public List<Transaction_UnitAllow> GetAllowmentSearch(string Id,BValues bv, string ip, string cinfo)
        {
            return new Transaction_UnitAllow().GetAllowmentSearch(Id,bv, ip, cinfo);
        }


    }
}