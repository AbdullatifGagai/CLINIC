using ZCLINIC.Areas.Transaction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using FeeVoucherApiController = ZCLINIC.Areas.Transaction.APIControllers.FeeVoucherController;

namespace ZCLINIC.Areas.Transaction.Controllers
{
    [Area("Transaction")]
    public class FeeVoucherController : Controller
    {
        public IActionResult Index()
        {
            return View(new FeeVoucherApiController().FeeVoucherGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        // create/edit view for FeeVoucher
        public IActionResult AFeeVoucher(int id = 0)
        {
            return View(new FeeVoucherApiController().FeeVoucherGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }
          public IActionResult ASemFeeVoucher(int id = 0)
        {
            return View(new FeeVoucherApiController().FeeVoucherGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        public IActionResult AFeeVoucherSaleInvoice(int id = 0)
        {
            return View(new FeeVoucherApiController().FeeVoucherGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        public IActionResult SemIndex()
        {
            return View(new FeeVoucherApiController().FeeVoucherGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }


      





        [HttpPost]
        public string SaveFeeVoucher(FeeVoucher FeeVoucher, List<FeeVoucherDetail> FeeVoucherDetail)
        {
            return new FeeVoucher().Transaction_FeeVoucherSave(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo(), FeeVoucher, FeeVoucherDetail);
        }

        [HttpPost]
        public string SaveCusFeeVoucher(FeeVoucher FeeVoucher, List<FeeVoucherDetail> FeeVoucherDetail)
        {
            return new FeeVoucher().Transaction_CusFeeVoucherSave(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo(), FeeVoucher, FeeVoucherDetail);
        }

        [HttpPost]
        public string SaveSaleInvoiveFeeVoucher(FeeVoucher FeeVoucher, List<FeeVoucherDetail> FeeVoucherDetail,int SaleId  = 0)
        {
            return new FeeVoucher().SaveSaleInvoiveFeeVoucher(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo(), FeeVoucher, FeeVoucherDetail,SaleId);
        }






        [HttpPost]
        public string UpdateFeeVoucher(FeeVoucher FeeVoucher, List<FeeVoucherDetail> FeeVoucherDetail)
        {
            return new FeeVoucher().Transaction_FeeVoucherUpdate(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo(), FeeVoucher, FeeVoucherDetail);
        }
         [HttpPost]
        public string UpdateCusFeeVoucher(FeeVoucher FeeVoucher, List<FeeVoucherDetail> FeeVoucherDetail)
        {
            return new FeeVoucher().Transaction_CusFeeVoucherUpdate(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo(), FeeVoucher, FeeVoucherDetail);
        }




        [HttpPost]
        public string DeleteFeeVoucher(int id)
        {
            return new FeeVoucherApiController().FeeVoucherDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
 
        [HttpGet]
        public List<FeeVoucher> GetFeeVoucherNo(int VoucherId)
        {
            return new FeeVoucher().GetFeeVoucherNo(VoucherId, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
 
    
    
    
    
    
    
    
    }
}