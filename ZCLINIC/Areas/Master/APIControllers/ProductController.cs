using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Master.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : Controller
    {
        public List<Product> ProductGetAll(BValues bv, string ip, string cInfo)
        {
            return new Product().Master_ProductGetAll(bv, ip, cInfo);
        }

        public Product ProductGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new Product().Master_ProductGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string ProductSave(List<object> objList, string ip, string cInfo)
        {
            return ((Product)objList[0]).Master_ProductSave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string ProductUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((Product)objList[0]).Master_ProductUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string ProductDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new Product().Master_ProductDelete(id, bv, ip, cInfo);
        }
  
    
 
    
    
    
    
    }
}