using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using StudentApiController = ZCLINIC.Areas.Master.APIControllers.StudentController;
using System;
using System.Linq;



 using Microsoft.AspNetCore.Http;



using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace ZCLINIC.Areas.Master.Controllers
{
    [Area("Master")]
    public class StudentController : Controller
    {

        private readonly IHostingEnvironment _hostingeviroment;

        public StudentController(IHostingEnvironment hostingEnvironment)
        {
            _hostingeviroment = hostingEnvironment;
        }


        public IActionResult Index()
        {
            return View();
        }

        // create/edit view for Student
        public IActionResult AStudent(int id = 0)
        {
            return View(new StudentApiController().StudentGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SaveStudent(Student model)
        {
            return new StudentApiController().StudentSave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string UpdateStudent(Student model)
        {
            return new StudentApiController().StudentUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeleteStudent(int id)
        {
            return new StudentApiController().StudentDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
   
    
    [HttpGet]
        public List<Student> Master_StudentGetLevelId(int Id)
        {
            return new Student().Master_StudentGetLevelId(Id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
   
    
     [HttpGet]
        public List<Student> StudentGetVou(int Id,int SId,int LeaveF,int MonthId)
        {
            return new Student().Master_StudentGetVouStudent(Id,SId,LeaveF,MonthId, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }

         [HttpGet]
        public List<Student> StudentGetVouPen(int Id)
        {
            return new Student().Master_StudentGetVouPen(Id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }



        [HttpGet]
        public List<Student> StudentGetReceipt()
        {
            return new Student().StudentGetReceipt(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }

         [HttpGet]
        public List<Student> StudentGetVoucher( int GrId)
        {
            return new Student().StudentGetVoucher(GrId,HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }

           public List<Student> StudentGetReportLedger( int GrId)
        {
            return new Student().StudentGetReportLedger(GrId,HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }



        public IActionResult AdmissionIndex()
        {
                return View();
        }


       public IActionResult A_Admission(int id = 0)
        {
            return View(new StudentApiController().StudentGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }





        public IActionResult AdmissionSAIIndex()
        {
            return View();
        }











         public IActionResult AdmissionSAI(int id = 0)
        {
            return View(new StudentApiController().StudentGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }









        public JsonResult Master_CCStudentGetAll()
        {

            List<Student> data = new Student().Master_CCStudentGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo(), Convert.ToInt32(Request.Form["length"]), Convert.ToInt32(Request.Form["start"]), Request.Form["search[value]"].ToString(), Convert.ToInt32(Request.Form["Status"]));
            var a = data.FirstOrDefault();
            int TotalRecords = a != null ? a.TotalCount : 0;
            return Json(new { data, recordsFiltered = TotalRecords, recordsTotal = data.Count, draw = Convert.ToInt32(Request.Form["draw"]) });
        }








        public JsonResult Master_StudentGetAll()
        {

            List<Student> data = new Student().Master_StudentGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo(), Convert.ToInt32(Request.Form["length"]), Convert.ToInt32(Request.Form["start"]), Request.Form["search[value]"].ToString(), Convert.ToInt32(Request.Form["Status"]));
            var a = data.FirstOrDefault();
            int TotalRecords = a != null ? a.TotalCount : 0;
            return Json(new { data, recordsFiltered = TotalRecords, recordsTotal = data.Count, draw = Convert.ToInt32(Request.Form["draw"]) });
        }







        public JsonResult Master_StudentGetAllSAI()
        {

            List<Student> data = new Student().Master_StudentGetAllSAI(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo(), Convert.ToInt32(Request.Form["length"]), Convert.ToInt32(Request.Form["start"]), Request.Form["search[value]"].ToString(), Convert.ToInt32(Request.Form["Status"]));
            var a = data.FirstOrDefault();
            int TotalRecords = a != null ? a.TotalCount : 0;
            return Json(new { data, recordsFiltered = TotalRecords, recordsTotal = data.Count, draw = Convert.ToInt32(Request.Form["draw"]) });
        }


















        [HttpGet]
        public List<Student> StudentGrId(int id)
        {
            return new Student().Master_StudentGetGrId(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }



        [HttpGet]
        public List<Student> StudentGetVouSem(int Id, int SId,int StuId)
        {
            return new Student().StudentGetVouSem(Id, SId, StuId,HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }


        [HttpGet]
        public List<Student> StudentlistPanelGrId(int MonthId ,int PanelId,int StudentId)
        {
            return new Student().StudentlistPanelGrId(MonthId,PanelId, StudentId, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpGet]
        public List<Student> Master_StudentGetPanelId(int PanelId)
        {
            return new Student().Master_StudentGetPanelId(PanelId, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }




        public string UploadImage(IFormFile file)
        {

            string filename = "";
            
            

          string rootpath = Path.Combine(_hostingeviroment.WebRootPath, "StudentPhoto");

          

         


         

            filename = Guid.NewGuid() + "_" + file.FileName;
            var filepath = Path.Combine(rootpath, filename);
            var fst = new FileStream(filepath, FileMode.Create);
            file.CopyTo(fst);
            fst.Dispose();
            return  filename;

        }

    }
}