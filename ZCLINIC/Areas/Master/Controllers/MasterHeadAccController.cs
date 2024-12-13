using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MasterHeadAccApiController = ZCLINIC.Areas.Master.APIControllers.MasterHeadAccController;

namespace ZCLINIC.Areas.Master.Controllers
{
    [Area("Master")]
    public class MasterHeadAccController : Controller
    {
        public IActionResult Index()
        {
            return View(new MasterHeadAccApiController().MasterHeadAccGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        // create/edit view for MasterHeadAcc
        public IActionResult AMasterHeadAcc(int id = 0)
        {
            return View(new MasterHeadAccApiController().MasterHeadAccGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SaveMasterHeadAcc(MasterHeadAcc model)
        {
            return new MasterHeadAccApiController().MasterHeadAccSave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string UpdateMasterHeadAcc(MasterHeadAcc model)
        {
            return new MasterHeadAccApiController().MasterHeadAccUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeleteMasterHeadAcc(int id)
        {
            return new MasterHeadAccApiController().MasterHeadAccDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
    }
}