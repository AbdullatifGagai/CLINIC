using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Master.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoryController : Controller
    {
        public List<Category> CategoryGetAll(BValues bv, string ip, string cInfo)
        {
            return new Category().Master_CategoryGetAll(bv, ip, cInfo);
        }

        public Category CategoryGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new Category().Master_CategoryGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string CategorySave(List<object> objList, string ip, string cInfo)
        {
            return ((Category)objList[0]).Master_CategorySave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string CategoryUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((Category)objList[0]).Master_CategoryUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string CategoryDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new Category().Master_CategoryDelete(id, bv, ip, cInfo);
        }
    }
}