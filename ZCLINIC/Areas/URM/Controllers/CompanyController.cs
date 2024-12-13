using ZCLINIC.Areas.URM.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CompanyApiController = ZCLINIC.Areas.URM.APIControllers.CompanyController;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using System;

namespace ZCLINIC.Areas.URM.Controllers
{
    [Area("URM")]
    public class CompanyController : Controller
    {

        private readonly IHostingEnvironment _hostingeviroment;

        public CompanyController(IHostingEnvironment hostingEnvironment)
        {
            _hostingeviroment = hostingEnvironment;
        }
        public IActionResult Index()
        {
            return View(new CompanyApiController().CompanyGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        // create/edit view for Company
        public IActionResult ACompany(int id = 0)
        {
            return View(new CompanyApiController().CompanyGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SaveCompany(Company model)
        {
            return new CompanyApiController().CompanySave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string UpdateCompany(Company model)
        {
            return new CompanyApiController().CompanyUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeleteCompany(int id)
        {
            return new CompanyApiController().CompanyDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
    
    
    [HttpGet]
        public List<Company> URM_CompanyGetAppId(int Id)
        {
            return new Company().URM_CompanyGetAppId(Id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }



        public string UploadImage(IFormFile file)
        {

            string filename = "";



            string rootpath = Path.Combine(_hostingeviroment.WebRootPath, "LOGO");








            filename = Guid.NewGuid() + "_" + file.FileName;
            var filepath = Path.Combine(rootpath, filename);
            var fst = new FileStream(filepath, FileMode.Create);
            file.CopyTo(fst);
            fst.Dispose();
            return filename;

        }
    }
}