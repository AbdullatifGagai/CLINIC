using ZCLINIC.Areas.Transaction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Transaction.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DoctorLedgerMasterController : Controller
    {
        public List<DoctorLedgerMaster> DoctorLedgerMasterGetAll(BValues bv, string ip, string cInfo)
        {
            return new DoctorLedgerMaster().Transaction_DoctorLedgerMasterGetAll(bv, ip, cInfo);
        }

        public DoctorLedgerMaster DoctorLedgerMasterGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new DoctorLedgerMaster().Transaction_DoctorLedgerMasterGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string DoctorLedgerMasterSave(List<object> objList, string ip, string cInfo)
        {
            return ((DoctorLedgerMaster)objList[0]).Transaction_DoctorLedgerMasterSave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string DoctorLedgerMasterUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((DoctorLedgerMaster)objList[0]).Transaction_DoctorLedgerMasterUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string DoctorLedgerMasterDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new DoctorLedgerMaster().Transaction_DoctorLedgerMasterDelete(id, bv, ip, cInfo);
        }
    }
}