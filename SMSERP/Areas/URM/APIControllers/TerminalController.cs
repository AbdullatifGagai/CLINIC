using ZCLINIC.Areas.URM.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.URM.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TerminalController : Controller
    {
        public List<Terminal> TerminalGetAll(BValues bv, string ip, string cInfo)
        {
            return new Terminal().URM_TerminalGetAll(bv, ip, cInfo);
        }

        public Terminal TerminalGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new Terminal().URM_TerminalGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string TerminalSave(List<object> objList, string ip, string cInfo)
        {
            return ((Terminal)objList[0]).URM_TerminalSave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string TerminalUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((Terminal)objList[0]).URM_TerminalUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string TerminalDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new Terminal().URM_TerminalDelete(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string TerminalToggleStatus(List<object> objList, string ip, string cInfo)
        {
            return ((Terminal)objList[0]).URM_TerminalToggleStatus((BValues)objList[1], ip, cInfo);
        }
    }
}