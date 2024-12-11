using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ZCLINIC.Areas.Master.Controllers
{
	[Area("Master")]
    public class DashboardController : Controller
    {
        public IActionResult Index(int ModuleId = 0)
        {
            if (HttpContext.Session.GetUserId() != 0)
            {
              
                ViewBag.ModuleId = ModuleId;
               
                
                
                
                return View();
            


            }
            return RedirectToAction("Index", "Authentication", new { Area = "URM" });
        }
    }
}