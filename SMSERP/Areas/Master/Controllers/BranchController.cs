using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using BranchApiController = ZCLINIC.Areas.Master.APIControllers.BranchController;

namespace ZCLINIC.Areas.Master.Controllers
{
    [Area("Master")]
    public class BranchController : Controller
    {
        public IActionResult Index()
        {
            return View(new BranchApiController().BranchGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        // create/edit view for Branch
        public IActionResult ABranch(int id = 0)
        {
            return View(new BranchApiController().BranchGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SaveBranch(Branch model)
        {
            return new BranchApiController().BranchSave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string UpdateBranch(Branch model)
        {
            return new BranchApiController().BranchUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeleteBranch(int id)
        {
            return new BranchApiController().BranchDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }


        public List<Branch> BranchGetAllActiveList()
        {
            return (new Branch().Master_BranchGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }




    }
}