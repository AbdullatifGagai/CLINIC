using ZCLINIC.Areas.Transaction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CustomerFeeVoucherApiController = ZCLINIC.Areas.Transaction.APIControllers.CustomerFeeVoucherController;

namespace ZCLINIC.Areas.Transaction.Controllers
{
    [Area("Transaction")]
    public class CustomerFeeVoucherController : Controller
    {
        public IActionResult Index()
        {
            return View(new FeeVoucher().Transaction_CustomizedFeeVoucherGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        // create/edit view for CustomerFeeVoucher
        public IActionResult ACustomerFeeVoucher(int id = 0)
        {
            return View(new FeeVoucher().Transaction_FeeVoucherGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }
          public IActionResult ACustomerSaleInvoiceFeeVoucher(int id = 0)
        {
            return View(new FeeVoucher().Transaction_FeeVoucherSaleIdGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SaveFeeVoucher(FeeVoucher FeeVoucher, List<FeeVoucherDetail> FeeVoucherDetail)
        {
            return new FeeVoucher().Transaction_FeeVoucherSave(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo(), FeeVoucher, FeeVoucherDetail);
        }


        [HttpPost]
        public string UpdateFeeVoucher(FeeVoucher FeeVoucher, List<FeeVoucherDetail> FeeVoucherDetail)
        {
            return new FeeVoucher().Transaction_FeeVoucherUpdate(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo(), FeeVoucher, FeeVoucherDetail);
        }

        [HttpPost]
        public string DeleteCustomerFeeVoucher(int id)
        {
            return new FeeVoucher().Transaction_FeeVoucherDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
    }
}