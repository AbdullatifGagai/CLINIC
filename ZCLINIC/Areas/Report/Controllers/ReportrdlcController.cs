using ZCLINIC.Areas.Report.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

using ZCLINIC.Areas.Report.Model;


namespace ZCLINIC.Areas.Report.Controllers
{
    [Area("Report")]
    public class ReportrdlcController : Controller
    {
        public IActionResult AReport(ReportValues rvalues)
        {
            ViewBag.values = rvalues;
            ViewBag.bv = HttpContext.Session.GetBValues();
             return View();
        }
    }


   










}