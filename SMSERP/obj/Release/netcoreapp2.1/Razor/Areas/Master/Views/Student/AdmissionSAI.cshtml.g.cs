#pragma checksum "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Student\AdmissionSAI.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a4c2f42a488c11c788e70cbf47186794826729e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Master_Views_Student_AdmissionSAI), @"mvc.1.0.view", @"/Areas/Master/Views/Student/AdmissionSAI.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Master/Views/Student/AdmissionSAI.cshtml", typeof(AspNetCore.Areas_Master_Views_Student_AdmissionSAI))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Student\AdmissionSAI.cshtml"
using SMSERP;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a4c2f42a488c11c788e70cbf47186794826729e", @"/Areas/Master/Views/Student/AdmissionSAI.cshtml")]
    public class Areas_Master_Views_Student_AdmissionSAI : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SMSERP.Areas.Master.Models.Student>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(58, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Student\AdmissionSAI.cshtml"
  
    string URL = Model == null ? "/Master/Student/SaveStudent" : "/Master/Student/UpdateStudent";
    int counter = 0;

#line default
#line hidden
            BeginContext(188, 373, true);
            WriteLiteral(@"
<style>
    /*Remove Arrows/Spinners from type number*/
    /* Chrome, Safari, Edge, Opera */
    input::-webkit-outer-spin-button,
    input::-webkit-inner-spin-button {
        -webkit-appearance: none;
        margin: 0;
    }

    /* Firefox */
    input[type=number] {
        -moz-appearance: textfield;
    }
</style>

<form method=""post"" data-url=""");
            EndContext();
            BeginContext(562, 3, false);
#line 24 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Student\AdmissionSAI.cshtml"
                         Write(URL);

#line default
#line hidden
            EndContext();
            BeginContext(565, 152, true);
            WriteLiteral("\" data-rurl=\"/Master/Student/AdmissionSAIIndex\"  data-script=\"/assets/Areas/Master/Student/IndexSai.js\" data-display=\"Bank Payment Voucher\">\r\n\r\n\r\n\r\n    ");
            EndContext();
            BeginContext(718, 27, false);
#line 28 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Student\AdmissionSAI.cshtml"
Write(Html.HiddenFor(m => m.GRId));

#line default
#line hidden
            EndContext();
            BeginContext(745, 242, true);
            WriteLiteral("\r\n\r\n\r\n    <div class=\"row\">\r\n\r\n\r\n\r\n        <div class=\"form-group form-group-xs col-md-12\">\r\n\r\n            <div class=\"form-group form-group-xs col-md-2\">\r\n                <label>GrNo<b class=\"wysiwyg-color-red\"></b></label>\r\n                ");
            EndContext();
            BeginContext(988, 94, false);
#line 39 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Student\AdmissionSAI.cshtml"
           Write(Html.TextBoxFor(m => m.Grno, new { @class = "form-control", type = "text", @readonly = true }));

#line default
#line hidden
            EndContext();
            BeginContext(1082, 181, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n            <div class=\"form-group form-group-xs col-md-4\">\r\n                <label>Student Name<b class=\"wysiwyg-color-red\"></b></label>\r\n                ");
            EndContext();
            BeginContext(1264, 106, false);
#line 45 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Student\AdmissionSAI.cshtml"
           Write(Html.TextBoxFor(m => m.StudentName, new { @class = "form-control", type = "text", required = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(1370, 160, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n            <div class=\"form-group form-group-xs col-md-2\">\r\n                <label>S/O,D/O<b class=\"wysiwyg-color-red\"></b></label>\r\n");
            EndContext();
#line 51 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Student\AdmissionSAI.cshtml"
                  

                    var Int = new List<(int Id, string Name)>();
                    Int.Add((Id: 0, Name: "Select"));
                    Int.Add((Id: 1, Name: "S/O"));
                    Int.Add((Id: 2, Name: "D/O"));


                

#line default
#line hidden
            BeginContext(1800, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(1817, 234, false);
#line 60 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Student\AdmissionSAI.cshtml"
           Write(Html.DropDownList("Int", Int.Select(p => new SelectListItem() { Text = p.Name, Value = p.Name.ToString() }), new { @class = "form-control", data_style = "btn-default btn-xs", tabindex = '1', data_search = "true", data_width = "100%"}));

#line default
#line hidden
            EndContext();
            BeginContext(2051, 191, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n            <div class=\"form-group form-group-xs col-md-4\">\r\n                <label>Father  Name<b class=\"wysiwyg-color-red\"></b></label>\r\n                ");
            EndContext();
            BeginContext(2243, 105, false);
#line 71 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Student\AdmissionSAI.cshtml"
           Write(Html.TextBoxFor(m => m.FatherName, new { @class = "form-control", type = "text", required = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(2348, 321, true);
            WriteLiteral(@"

            </div>









        </div>
    </div>






    <div class=""row"">



        <div class=""form-group form-group-xs col-md-12"">

            <div class=""form-group form-group-xs col-md-4"">
                <label>SurName<b class=""wysiwyg-color-red""></b></label>
                ");
            EndContext();
            BeginContext(2670, 102, false);
#line 99 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Student\AdmissionSAI.cshtml"
           Write(Html.TextBoxFor(m => m.SurName, new { @class = "form-control", type = "text", required = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(2772, 186, true);
            WriteLiteral("\r\n\r\n            </div>\r\n            <div class=\"form-group form-group-xs col-md-4\">\r\n                <label>Residential Address<b class=\"wysiwyg-color-red\"></b></label>\r\n                ");
            EndContext();
            BeginContext(2959, 99, false);
#line 104 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Student\AdmissionSAI.cshtml"
           Write(Html.TextBoxFor(m => m.RAdd, new { @class = "form-control", type = "text", required = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(3058, 177, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n            <div class=\"form-group form-group-xs col-md-2\">\r\n                <label>Religion<b class=\"wysiwyg-color-red\"></b></label>\r\n                ");
            EndContext();
            BeginContext(3236, 103, false);
#line 110 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Student\AdmissionSAI.cshtml"
           Write(Html.TextBoxFor(m => m.Religion, new { @class = "form-control", type = "text", required = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(3339, 176, true);
            WriteLiteral("\r\n\r\n            </div>\r\n            <div class=\"form-group form-group-xs col-md-2\">\r\n                <label>Mobile No<b class=\"wysiwyg-color-red\"></b></label>\r\n                ");
            EndContext();
            BeginContext(3516, 101, false);
#line 115 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Student\AdmissionSAI.cshtml"
           Write(Html.TextBoxFor(m => m.CellNo, new { @class = "form-control", type = "text", required = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(3617, 319, true);
            WriteLiteral(@"

            </div>









        </div>
    </div>




    <div class=""row"">



        <div class=""form-group form-group-xs col-md-12"">

            <div class=""form-group form-group-xs col-md-2"">
                <label>Phone  No<b class=""wysiwyg-color-red""></b></label>
                ");
            EndContext();
            BeginContext(3937, 102, false);
#line 141 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Student\AdmissionSAI.cshtml"
           Write(Html.TextBoxFor(m => m.PhoneNo, new { @class = "form-control", type = "text", required = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(4039, 182, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n            <div class=\"form-group form-group-xs col-md-2\">\r\n                <label>Date Of Brith<b class=\"wysiwyg-color-red\"></b></label>\r\n                ");
            EndContext();
            BeginContext(4222, 102, false);
#line 147 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Student\AdmissionSAI.cshtml"
           Write(Html.TextBoxFor(m => m.DOBrith, new { @class = "form-control", type = "date", required = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(4324, 160, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n\r\n            <div class=\"form-group form-group-xs col-md-2\">\r\n                <label>Shift<b class=\"wysiwyg-color-red\"></b></label>\r\n");
            EndContext();
#line 154 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Student\AdmissionSAI.cshtml"
                  

                    var shift = new List<(int Id, string Name)>();
                    shift.Add((Id: 0, Name: "Select Shift"));
                    shift.Add((Id: 1, Name: "MOR"));
                    shift.Add((Id: 2, Name: "EVE"));


                

#line default
#line hidden
            BeginContext(4768, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(4785, 239, false);
#line 163 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Student\AdmissionSAI.cshtml"
           Write(Html.DropDownList("Shift", shift.Select(p => new SelectListItem() { Text = p.Name, Value = p.Name.ToString() }), new { @class = "form-control", data_style = "btn-default btn-xs", tabindex = '4', data_search = "true", data_width = "100%" }));

#line default
#line hidden
            EndContext();
            BeginContext(5024, 187, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n\r\n\r\n            <div class=\"form-group form-group-xs col-md-2\">\r\n                <label>Admission Date<b class=\"wysiwyg-color-red\"></b></label>\r\n                ");
            EndContext();
            BeginContext(5212, 101, false);
#line 171 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Student\AdmissionSAI.cshtml"
           Write(Html.TextBoxFor(m => m.AdDate, new { @class = "form-control", type = "date", required = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(5313, 162, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n\r\n            <div class=\"form-group form-group-xs col-md-2\">\r\n                <label>Section<b class=\"wysiwyg-color-red\"></b></label>\r\n");
            EndContext();
#line 178 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Student\AdmissionSAI.cshtml"
                  

                    var Sec = new List<(int Id, string Name)>();
                    Sec.Add((Id: 0, Name: "Select Section"));
                    Sec.Add((Id: 1, Name: "A"));
                    Sec.Add((Id: 2, Name: "B"));
                    Sec.Add((Id: 3, Name: "C"));
                    Sec.Add((Id: 4, Name: "D"));


                

#line default
#line hidden
            BeginContext(5849, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(5866, 235, false);
#line 189 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Student\AdmissionSAI.cshtml"
           Write(Html.DropDownList("Sec", Sec.Select(p => new SelectListItem() { Text = p.Name, Value = p.Name.ToString() }), new { @class = "form-control", data_style = "btn-default btn-xs", tabindex = '4', data_search = "true", data_width = "100%" }));

#line default
#line hidden
            EndContext();
            BeginContext(6101, 180, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n\r\n\r\n            <div class=\"form-group form-group-xs col-md-2\">\r\n                <label>Roll No<b class=\"wysiwyg-color-red\"></b></label>\r\n                ");
            EndContext();
            BeginContext(6282, 101, false);
#line 197 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Student\AdmissionSAI.cshtml"
           Write(Html.TextBoxFor(m => m.RollNo, new { @class = "form-control", type = "text", required = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(6383, 303, true);
            WriteLiteral(@"

            </div>








        </div>
    </div>




    <div class=""row"">



        <div class=""form-group form-group-xs col-md-12"">




            <div class=""form-group form-group-xs col-md-4"">
                <label>Panel<b class=""wysiwyg-color-red""></b></label>
");
            EndContext();
#line 225 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Student\AdmissionSAI.cshtml"
                  
                    List<SMSERP.Areas.Master.Models.Panel> Panel = new SMSERP.Areas.Master.Models.Panel().Master_PanelGetAll(Context.Session.GetBValues(), Context.GetIP(), Context.GetCInfo());

                

#line default
#line hidden
            BeginContext(6921, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(6938, 148, false);
#line 229 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Student\AdmissionSAI.cshtml"
           Write(Html.DropDownList("PanelId", Panel.Select(s => new SelectListItem() { Text = s.PName, Value = s.PId.ToString() }), new { @class = "form-control " }));

#line default
#line hidden
            EndContext();
            BeginContext(7086, 162, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n\r\n\r\n            <div class=\"form-group form-group-xs col-md-4\">\r\n                <label>Level<b class=\"wysiwyg-color-red\"></b></label>\r\n");
            EndContext();
#line 237 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Student\AdmissionSAI.cshtml"
                  
                    List<SMSERP.Areas.Master.Models.Levels> Levels = new SMSERP.Areas.Master.Models.Levels().Master_LevelsGetAll(Context.Session.GetBValues(), Context.GetIP(), Context.GetCInfo());

                

#line default
#line hidden
            BeginContext(7487, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(7504, 153, false);
#line 241 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Student\AdmissionSAI.cshtml"
           Write(Html.DropDownList("LevelId", Levels.Select(s => new SelectListItem() { Text = s.LevelName, Value = s.LId.ToString() }), new { @class = "form-control " }));

#line default
#line hidden
            EndContext();
            BeginContext(7657, 180, true);
            WriteLiteral("\r\n\r\n            </div>\r\n            <div class=\"form-group form-group-xs col-md-2\">\r\n                <label>Date Leaving <b class=\"wysiwyg-color-red\"></b></label>\r\n                ");
            EndContext();
            BeginContext(7838, 106, false);
#line 246 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Student\AdmissionSAI.cshtml"
           Write(Html.TextBoxFor(m => m.DateLeaving, new { @class = "form-control", type = "date", required = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(7944, 161, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n\r\n            <div class=\"form-group form-group-xs col-md-2\">\r\n                <label>Status<b class=\"wysiwyg-color-red\"></b></label>\r\n");
            EndContext();
#line 253 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Student\AdmissionSAI.cshtml"
                  

                    var Status = new List<(int Id, string Name)>();
                    Status.Add((Id: 0, Name: "Select StatUs"));
                    Status.Add((Id: 1, Name: "Present"));
                    Status.Add((Id: 2, Name: "Left"));



                

#line default
#line hidden
            BeginContext(8401, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(8418, 239, false);
#line 263 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Student\AdmissionSAI.cshtml"
           Write(Html.DropDownList("LeaveF", Status.Select(p => new SelectListItem() { Text = p.Name, Value = p.Id.ToString() }), new { @class = "form-control", data_style = "btn-default btn-xs", tabindex = '4', data_search = "true", data_width = "100%" }));

#line default
#line hidden
            EndContext();
            BeginContext(8657, 310, true);
            WriteLiteral(@"

            </div>







        </div>
    </div>



    <div class=""row"">



        <div class=""form-group form-group-xs col-md-12"">






            <div class=""form-group form-group-xs col-md-4"">
                <label>Month Name<b class=""wysiwyg-color-red""></b></label>

");
            EndContext();
#line 292 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Student\AdmissionSAI.cshtml"
                  
                    List<SMSERP.Areas.Master.Models.AcadmicYear> AcadmicYear = new SMSERP.Areas.Master.Models.AcadmicYear().Master_AcadmicYearGetAll(Context.Session.GetBValues(), Context.GetIP(), Context.GetCInfo());

                

#line default
#line hidden
            BeginContext(9226, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(9243, 156, false);
#line 296 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Student\AdmissionSAI.cshtml"
           Write(Html.DropDownList("MonthId", AcadmicYear.Select(s => new SelectListItem() { Text = s.FeesTerm, Value = s.Id.ToString() }), new { @class = "form-control " }));

#line default
#line hidden
            EndContext();
            BeginContext(9399, 184, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n            </div>\r\n            <div class=\"form-group form-group-xs col-md-2\">\r\n                <label>Opening Amt<b class=\"wysiwyg-color-red\"></b></label>\r\n                ");
            EndContext();
            BeginContext(9584, 102, false);
#line 304 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Student\AdmissionSAI.cshtml"
           Write(Html.TextBoxFor(m => m.OpenAmt, new { @class = "form-control", type = "text", required = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(9686, 180, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n\r\n            <div class=\"form-group form-group-xs col-md-2\">\r\n                <label>Discount <b class=\"wysiwyg-color-red\"></b></label>\r\n                ");
            EndContext();
            BeginContext(9867, 102, false);
#line 311 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Student\AdmissionSAI.cshtml"
           Write(Html.TextBoxFor(m => m.MDisAmt, new { @class = "form-control", type = "text", required = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(9969, 183, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n            <div class=\"form-group form-group-xs col-md-2\">\r\n                <label>Transport  Amt<b class=\"wysiwyg-color-red\"></b></label>\r\n                ");
            EndContext();
            BeginContext(10153, 107, false);
#line 317 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Student\AdmissionSAI.cshtml"
           Write(Html.TextBoxFor(m => m.TransportAmt, new { @class = "form-control", type = "text", required = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(10260, 178, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n\r\n\r\n            <div class=\"form-group form-group-xs col-md-2\">\r\n                <label>RefId<b class=\"wysiwyg-color-red\"></b></label>\r\n                ");
            EndContext();
            BeginContext(10439, 95, false);
#line 325 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Student\AdmissionSAI.cshtml"
           Write(Html.TextBoxFor(m => m.RefId, new { @class = "form-control", type = "text", @readonly = true }));

#line default
#line hidden
            EndContext();
            BeginContext(10534, 305, true);
            WriteLiteral(@"

            </div>






        </div>
    </div>

    <div class=""row"">



        <div class=""form-group form-group-xs col-md-12"">

            <div class=""form-group form-group-xs col-md-4"">
                <label>Remarks<b class=""wysiwyg-color-red""></b></label>
                ");
            EndContext();
            BeginContext(10840, 102, false);
#line 345 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Student\AdmissionSAI.cshtml"
           Write(Html.TextBoxFor(m => m.Remarks, new { @class = "form-control", type = "text", required = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(10942, 166, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n\r\n            <div class=\"form-group form-group-xs col-md-2\">\r\n                <label>Plan Name<b class=\"wysiwyg-color-red\"></b></label>\r\n\r\n");
            EndContext();
#line 353 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Student\AdmissionSAI.cshtml"
                  
                    List<SMSERP.Areas.Transaction.Models.PlanMaster> PlanMaster = new SMSERP.Areas.Transaction.Models.PlanMaster().Transaction_PlanMasterGetAll(Context.Session.GetBValues(), Context.GetIP(), Context.GetCInfo());

                

#line default
#line hidden
            BeginContext(11378, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(11395, 158, false);
#line 357 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Student\AdmissionSAI.cshtml"
           Write(Html.DropDownList("PlanId", PlanMaster.Select(s => new SelectListItem() { Text = s.PlanName, Value = s.PlanId.ToString() }), new { @class = "form-control " }));

#line default
#line hidden
            EndContext();
            BeginContext(11553, 181, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n            </div>\r\n\r\n            <div class=\"form-group form-group-xs col-md-2\">\r\n                <label>SeatNo<b class=\"wysiwyg-color-red\"></b></label>\r\n                ");
            EndContext();
            BeginContext(11735, 101, false);
#line 366 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Student\AdmissionSAI.cshtml"
           Write(Html.TextBoxFor(m => m.SeatNo, new { @class = "form-control", type = "text", required = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(11836, 186, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n            <div class=\"form-group form-group-xs col-md-2\">\r\n                <label>Monthly Panel Amt<b class=\"wysiwyg-color-red\"></b></label>\r\n                ");
            EndContext();
            BeginContext(12023, 106, false);
#line 372 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Student\AdmissionSAI.cshtml"
           Write(Html.TextBoxFor(m => m.CloseingAmt, new { @class = "form-control", type = "text", required = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(12129, 414, true);
            WriteLiteral(@"

            </div>






        </div>
    </div>










    <div class=""modal-footer mt-10 no-padding no-border"">



        <button type=""button"" class=""btn btn-danger btn-xs"" data-dismiss=""modal""><i class=""icon-cross""></i>Close</button>
        <button type=""button"" data-submit=""true"" class=""btn btn-primary  btn-xs""><i class=""icon-floppy-disk position-left""></i>Save</button>
");
            EndContext();
            BeginContext(12693, 917, true);
            WriteLiteral(@"
    </div>

</form>



<script>






    $('#CellNo').formatter({
        pattern: '{{9999}}-{{9999999}}'
    });

    $('#PhoneNo').formatter({
        pattern: '{{9999}}-{{9999999}}'
    });












    //document.getElementById('DOBrith').valueAsDate = new Date();
    //document.getElementById('AdDate').valueAsDate = new Date();
    //document.getElementById('DateLeaving').valueAsDate = new Date();
    if ($('#GRId').val() > 0) {
        //  
       
    }
    else {

        document.getElementById('DOBrith').valueAsDate = new Date();
        document.getElementById('AdDate').valueAsDate = new Date();
        document.getElementById('DateLeaving').valueAsDate = new Date();

        $('#StudentName').focus();
        //$('#UserName').val($('#personName').text());
        //$('#UserId').val($('#personId').val())


    }



</script>




");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SMSERP.Areas.Master.Models.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591