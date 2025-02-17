using ZCLINIC.Areas.Report.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

using ZCLINIC.Areas.Report.Model;


namespace ZCLINIC.Areas.Report.Controllers
{

    [Area("Report")]

    public class ReportDetailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult AccountLedger()
        {
            return View();
        }



          public IActionResult Trialbalance()
        {
            return View();
        }


        public IActionResult UnitStatment()
        {
            return View();
        }



         public IActionResult StockReport()
        {
            return View();
        }

          public IActionResult PurchaseDetails()
        {
            return View();
        }


            public IActionResult IssuanceDetails()
        {
            return View();
        }

        public IActionResult ReceivableDetails()
        {
            return View();
        }




         public IActionResult VoucherRegister()
        {
            return View();
        }

         public IActionResult ReceiptRegister()
        {
            return View();
        }

          public IActionResult StudentStatement()
        {
            return View();
        }


          public IActionResult BatchWiseList()
        {
            return View();
        }


         public IActionResult SchoolStockReport()
        {
            return View();
        }

        public IActionResult SalesInvoice()
        {
            return View();
        }

         public IActionResult ProductWiseLedger()
        {
            return View();
        }


           public IActionResult LevelWiseStudent()
        {
            return View();
        }




           public IActionResult BatchWiseDetail()
        {
            return View();
        }


        
         public IActionResult PanelWiseDetail()
        {
            return View();
        }



          public IActionResult DailyCollectionReport()
        {
            return View();
        }






          public IActionResult CollectionDetail()
        {
            return View();
        }


          public IActionResult DoctorWiseDetail()
        {
            return View();
        }




         public IActionResult LabWorkSheet()
        {
            return View();
        }















    }
}
