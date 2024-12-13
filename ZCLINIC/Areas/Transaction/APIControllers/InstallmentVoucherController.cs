using ZCLINIC.Areas.Transaction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Transaction.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class InstallmentVoucherController : Controller
    {
        //public List<InstallmentVoucher> InstallmentVoucherGetAll(BValues bv, string ip, string cInfo)
        //{
        //    return new InstallmentVoucher().Transaction_InstallmentVoucherGetAll(bv, ip, cInfo);
        //}

        public InstallmentVoucher InstallmentVoucherGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new InstallmentVoucher().Transaction_InstallmentVoucherGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string InstallmentVoucherSave(List<object> objList, string ip, string cInfo)
        {
            return ((InstallmentVoucher)objList[0]).Transaction_InstallmentVoucherSave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string InstallmentVoucherUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((InstallmentVoucher)objList[0]).Transaction_InstallmentVoucherUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string InstallmentVoucherDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new InstallmentVoucher().Transaction_InstallmentVoucherDelete(id, bv, ip, cInfo);
        }
    }
}