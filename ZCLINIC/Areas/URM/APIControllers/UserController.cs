using ZCLINIC.Areas.URM.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZCLINIC.Areas.URM.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : Controller
    {
        public List<User> UserGetAll(BValues bv, string IP, string CInfo)
        {
            return new User().URM_UserGetAll(bv, IP, CInfo);
        }

        public User UserGetById(int id, BValues bv, string IP, string CInfo)
        {
            return new User().URM_UserGetById(id, bv, IP, CInfo);
        }

        [HttpPost]
        public string UserSave(List<object> objlist, string IP, string CInfo)
        {
            return ((User)objlist.ElementAt(0)).URM_UserSave((BValues)objlist.ElementAt(1), IP, CInfo);
        }

        [HttpPost]
        public string UserUpdate(List<object> objlist, string IP, string CInfo)
        {
            return ((User)objlist.ElementAt(0)).URM_UserUpdate((BValues)objlist.ElementAt(1), IP, CInfo);
        }


        //[HttpPost]
        //public string UserDelete(int id, BValues bv, string ip, string cInfo)
        //{
        //  //  return new User().URM_UserDelete(id, bv, ip, cInfo);
        //}

    }
}
