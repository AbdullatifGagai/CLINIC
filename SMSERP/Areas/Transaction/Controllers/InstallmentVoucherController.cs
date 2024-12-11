using ZCLINIC.Areas.Transaction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using InstallmentVoucherApiController = ZCLINIC.Areas.Transaction.APIControllers.InstallmentVoucherController;
using System.Linq;
using System;

namespace ZCLINIC.Areas.Transaction.Controllers
{
    [Area("Transaction")]
    public class InstallmentVoucherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // create/edit view for InstallmentVoucher
        public IActionResult AInstallmentVoucher(int id = 0)
        {
            return View(new InstallmentVoucherApiController().InstallmentVoucherGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SaveInstallmentVoucher(InstallmentVoucher model)
        {
            return new InstallmentVoucherApiController().InstallmentVoucherSave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string UpdateInstallmentVoucher(InstallmentVoucher model)
        {
            return new InstallmentVoucherApiController().InstallmentVoucherUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeleteInstallmentVoucher(int id)
        {
            return new InstallmentVoucherApiController().InstallmentVoucherDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }




        public JsonResult Transaction_InstallmentVoucherGetAll()
        {

            List<InstallmentVoucher> data = new InstallmentVoucher().Transaction_InstallmentVoucherGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo(), Convert.ToInt32(Request.Form["length"]), Convert.ToInt32(Request.Form["start"]), Request.Form["search[value]"].ToString(), Convert.ToInt32(Request.Form["Status"]));
            var a = data.FirstOrDefault();
            int TotalRecords = a != null ? a.TotalCount : 0;
            return Json(new { data, recordsFiltered = TotalRecords, recordsTotal = data.Count, draw = Convert.ToInt32(Request.Form["draw"]) });
        }










    }
}