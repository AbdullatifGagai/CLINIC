using ZCLINIC.Areas.Transaction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Transaction_BankReceiptVoucherApiController = ZCLINIC.Areas.Transaction.APIControllers.Transaction_BankReceiptVoucherController;
///using Transaction_BankReceiptVoucherApiController = ZCLINIC.Areas.Transaction.APIControllers.Transaction_BankReceiptVoucherController;
using Transaction_VoucherMasterApiController = ZCLINIC.Areas.Transaction.APIControllers.Transaction_VoucherMasterController;


namespace ZCLINIC.Areas.Transaction.Controllers
{
    [Area("Transaction")]
    public class Transaction_BankReceiptVoucherController : Controller
    {
        public IActionResult Index()
        {
            return View(new Transaction_VoucherMasterApiController().Transaction_VoucherMasterGetAll("BRV",HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        // create/edit view for Transaction_BankReceiptVoucher
        public IActionResult ATransaction_BankReceiptVoucher(int id = 0)
        {
            return View(new Transaction_VoucherMasterApiController().Transaction_VoucherMasterGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SaveTransaction_BankReceiptVoucher(Transaction_VoucherMaster model)
        {
            return new Transaction_VoucherMasterApiController().Transaction_VoucherMasterSave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string UpdateTransaction_BankReceiptVoucher(Transaction_VoucherMaster model)
        {
            return new Transaction_VoucherMasterApiController().Transaction_VoucherMasterUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeleteTransaction_BankReceiptVoucher(int id)
        {
            return new Transaction_VoucherMasterApiController().Transaction_VoucherMasterDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
    }
}