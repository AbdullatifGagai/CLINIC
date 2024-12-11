using ZCLINIC.Areas.Transaction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using FeeVoucherDetailApiController = ZCLINIC.Areas.Transaction.APIControllers.FeeVoucherDetailController;

namespace ZCLINIC.Areas.Transaction.Controllers
{
    [Area("Transaction")]
    public class FeeVoucherDetailController : Controller
    {
        public IActionResult Index()
        {
            return View(new FeeVoucherDetailApiController().FeeVoucherDetailGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        // create/edit view for FeeVoucherDetail
        //public IActionResult AFeeVoucherDetail(int id = 0)
        //{
        //    return View(new FeeVoucherDetailApiController().FeeVoucherDetailGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        //}

        [HttpPost]
        public string SaveFeeVoucherDetail(FeeVoucherDetail model)
        {
            return new FeeVoucherDetailApiController().FeeVoucherDetailSave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string UpdateFeeVoucherDetail(FeeVoucherDetail model)
        {
            return new FeeVoucherDetailApiController().FeeVoucherDetailUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeleteFeeVoucherDetail(int id)
        {
            return new FeeVoucherDetailApiController().FeeVoucherDetailDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
  
        [HttpGet]
        public List<FeeVoucherDetail> GetFeeVoucherDetail(int id)
        {
            return new FeeVoucherDetail().GetFeeVoucherDetail(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
  
     [HttpGet]
        public List<FeeVoucherDetail> GetGrIdSaleId(int id)
        {
            return new FeeVoucherDetail().GetGrIdSaleId(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpGet]
        public List<FeeVoucherDetail> GetStudentFeeVoucher(int id)
        {
            return new FeeVoucherDetail().GetStudentFeeVoucher(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }




    }
}