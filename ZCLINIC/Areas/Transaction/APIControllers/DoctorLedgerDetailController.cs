using ZCLINIC.Areas.Transaction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Transaction.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DoctorLedgerDetailController : Controller
    {
        public List<DoctorLedgerDetail> DoctorLedgerDetailGetAll(BValues bv, string ip, string cInfo)
        {
            return new DoctorLedgerDetail().Transaction_DoctorLedgerDetailGetAll(bv, ip, cInfo);
        }

        public DoctorLedgerDetail DoctorLedgerDetailGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new DoctorLedgerDetail().Transaction_DoctorLedgerDetailGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string DoctorLedgerDetailSave(List<object> objList, string ip, string cInfo)
        {
            return ((DoctorLedgerDetail)objList[0]).Transaction_DoctorLedgerDetailSave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string DoctorLedgerDetailUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((DoctorLedgerDetail)objList[0]).Transaction_DoctorLedgerDetailUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string DoctorLedgerDetailDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new DoctorLedgerDetail().Transaction_DoctorLedgerDetailDelete(id, bv, ip, cInfo);
        }
    }
}