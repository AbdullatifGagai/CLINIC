using ZCLINIC.Areas.Transaction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Transaction_VoucherDetailApiController = ZCLINIC.Areas.Transaction.APIControllers.Transaction_VoucherDetailController;

namespace ZCLINIC.Areas.Transaction.Controllers
{
    [Area("Transaction")]
    public class Transaction_VoucherDetailController : Controller
    {
        public IActionResult Index()
        {
            return View(new Transaction_VoucherDetailApiController().Transaction_VoucherDetailGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        // create/edit view for Transaction_VoucherDetail
        public IActionResult ATransaction_VoucherDetail(int id = 0)
        {
            return View(new Transaction_VoucherDetailApiController().Transaction_VoucherDetailGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SaveTransaction_VoucherDetail(Transaction_VoucherDetail model)
        {
            return new Transaction_VoucherDetailApiController().Transaction_VoucherDetailSave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string UpdateTransaction_VoucherDetail(Transaction_VoucherDetail model)
        {
            return new Transaction_VoucherDetailApiController().Transaction_VoucherDetailUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeleteTransaction_VoucherDetail(int id)
        {
            return new Transaction_VoucherDetailApiController().Transaction_VoucherDetailDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
   
     
    
    
    
    
    }
}