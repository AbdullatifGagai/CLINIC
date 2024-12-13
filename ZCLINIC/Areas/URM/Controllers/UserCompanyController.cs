using ZCLINIC.Areas.URM.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UserCompanyApiController = ZCLINIC.Areas.URM.APIControllers.UserCompanyController;

namespace ZCLINIC.Areas.URM.Controllers
{
    [Area("URM")]
    public class UserCompanyController : Controller
    {


        // create/edit view for UserCompany
        public IActionResult AUserCompany(int id = 0)
        {
            return View(new UserCompanyApiController().UserCompanyGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SaveUserCompany(UserCompany model)
        {
            return new UserCompanyApiController().UserCompanySave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string UpdateUserCompany(UserCompany model)
        {
            return new UserCompanyApiController().UserCompanyUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeleteUserCompany(int id)
        {
            return new UserCompanyApiController().UserCompanyDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }


        public List<UserCompany> URM_UserCompanyGetAll(int Id)
        {
            return new UserCompany().URM_UserCompanyGetAll(Id,HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }




      








    }
}