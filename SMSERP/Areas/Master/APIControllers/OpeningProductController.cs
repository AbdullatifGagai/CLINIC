using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Master.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OpeningProductController : Controller
    {
        public List<OpeningProduct> OpeningProductGetAll(BValues bv, string ip, string cInfo)
        {
            return new OpeningProduct().Master_OpeningProductGetAll(bv, ip, cInfo);
        }

        public OpeningProduct OpeningProductGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new OpeningProduct().Master_OpeningProductGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string OpeningProductSave(List<object> objList, string ip, string cInfo)
        {
            return ((OpeningProduct)objList[0]).Master_OpeningProductSave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string OpeningProductUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((OpeningProduct)objList[0]).Master_OpeningProductUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string OpeningProductDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new OpeningProduct().Master_OpeningProductDelete(id, bv, ip, cInfo);
        }
    }
}