using ZCLINIC.Areas.URM.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TerminalApiController = ZCLINIC.Areas.URM.APIControllers.TerminalController;

namespace ZCLINIC.Areas.URM.Controllers
{
    [Area("URM")]
    public class TerminalController : Controller
    {
        public IActionResult Index()
        {
            return View(new TerminalApiController().TerminalGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        // create/edit view for Terminal
        public IActionResult ATerminal(int id = 0)
        {
            return View(new TerminalApiController().TerminalGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SaveTerminal(Terminal model)
        {
            return new TerminalApiController().TerminalSave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string UpdateTerminal(Terminal model)
        {
            return new TerminalApiController().TerminalUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeleteTerminal(int id)
        {
            return new TerminalApiController().TerminalDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string ToggleStatusTerminal(Terminal model)
        {
            return new TerminalApiController().TerminalToggleStatus(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }


    }
}