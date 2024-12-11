using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZCLINIC.Areas.Master.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CustomerController : Controller
    {
        public List<Customer> CustomerGetAll(BValues bv, string ip, string cInfo)
        {
            return new Customer().Master_CustomerGetAll(bv, ip, cInfo);
        }

        public Customer CustomerGetById(int id, BValues bv, string ip, string cInfo)
        {
            return new Customer().Master_CustomerGetById(id, bv, ip, cInfo);
        }

        [HttpPost]
        public string CustomerSave(List<object> objList, string ip, string cInfo)
        {
            return ((Customer)objList[0]).Master_CustomerSave((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string CustomerUpdate(List<object> objList, string ip, string cInfo)
        {
            return ((Customer)objList[0]).Master_CustomerUpdate((BValues)objList[1], ip, cInfo);
        }

        [HttpPost]
        public string CustomerDelete(int id, BValues bv, string ip, string cInfo)
        {
            return new Customer().Master_CustomerDelete(id, bv, ip, cInfo);
        }
    }
}