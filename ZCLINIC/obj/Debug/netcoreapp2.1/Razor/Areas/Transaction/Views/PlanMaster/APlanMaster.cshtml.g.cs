#pragma checksum "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\PlanMaster\APlanMaster.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "520b03b796f14d703d6587f7b875425a0b65e696"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Transaction_Views_PlanMaster_APlanMaster), @"mvc.1.0.view", @"/Areas/Transaction/Views/PlanMaster/APlanMaster.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Transaction/Views/PlanMaster/APlanMaster.cshtml", typeof(AspNetCore.Areas_Transaction_Views_PlanMaster_APlanMaster))]
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
#line 2 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\PlanMaster\APlanMaster.cshtml"
using ZCLINIC;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"520b03b796f14d703d6587f7b875425a0b65e696", @"/Areas/Transaction/Views/PlanMaster/APlanMaster.cshtml")]
    public class Areas_Transaction_Views_PlanMaster_APlanMaster : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ZCLINIC.Areas.Transaction.Models.PlanMaster>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(70, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\PlanMaster\APlanMaster.cshtml"
  
    string URL = Model == null ? "/Transaction/PlanMaster/SavePlanMaster" : "/Transaction/PlanMaster/UpdatePlanMaster";
    int counter = 0;




    List<ZCLINIC.Areas.Master.Models.Semester> Semester = new ZCLINIC.Areas.Master.Models.Semester().Master_SemesterGetAll(Context.Session.GetBValues(), Context.GetIP(), Context.GetCInfo());
    // Master_SubAccount.Insert(0, new ZCLINIC.Areas.Master.Models.Master_SubAccount { Sub_accountCode = "0", Subacc_Name = "Select Account Name" });
    Semester.Insert(0, new ZCLINIC.Areas.Master.Models.Semester { Id = 0, SName = "--Select Semester Name--" });







#line default
#line hidden
            BeginContext(699, 373, true);
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
            BeginContext(1073, 3, false);
#line 38 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\PlanMaster\APlanMaster.cshtml"
                         Write(URL);

#line default
#line hidden
            EndContext();
            BeginContext(1076, 74, true);
            WriteLiteral("\" data-rurl=\"/Transaction/PlanMaster\" data-display=\"Fee Plan\">\r\n\r\n\r\n\r\n    ");
            EndContext();
            BeginContext(1151, 29, false);
#line 42 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\PlanMaster\APlanMaster.cshtml"
Write(Html.HiddenFor(m => m.PlanId));

#line default
#line hidden
            EndContext();
            BeginContext(1180, 241, true);
            WriteLiteral("\r\n    <div class=\"row\">\r\n\r\n\r\n\r\n        <div class=\"form-group form-group-xs col-md-12\">\r\n\r\n            <div class=\"form-group form-group-xs col-md-4\">\r\n                <label>Plan Id<b class=\"wysiwyg-color-red\"></b></label>\r\n                ");
            EndContext();
            BeginContext(1422, 102, false);
#line 51 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\PlanMaster\APlanMaster.cshtml"
           Write(Html.TextBoxFor(m => m.PlanId, new { @class = "form-control", type = "text", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(1524, 173, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n            <div class=\"form-group form-group-xs col-md-4\">\r\n                <label>Date<b class=\"wysiwyg-color-red\"></b></label>\r\n                ");
            EndContext();
            BeginContext(1698, 80, false);
#line 57 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\PlanMaster\APlanMaster.cshtml"
           Write(Html.TextBoxFor(m => m.PlanDate, new { @class = "form-control", type = "date" }));

#line default
#line hidden
            EndContext();
            BeginContext(1778, 319, true);
            WriteLiteral(@"

            </div>





        </div>
    </div>



    <div class=""row"">



        <div class=""form-group form-group-xs col-md-12"">






            <div class=""form-group form-group-xs col-md-4"">
                <label>Plan Name<b class=""wysiwyg-color-red""></b></label>
                ");
            EndContext();
            BeginContext(2098, 80, false);
#line 83 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\PlanMaster\APlanMaster.cshtml"
           Write(Html.TextBoxFor(m => m.PlanName, new { @class = "form-control", type = "text" }));

#line default
#line hidden
            EndContext();
            BeginContext(2178, 177, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n            <div class=\"form-group form-group-xs col-md-4\">\r\n                <label>Degree<b class=\"wysiwyg-color-red\"></b></label>\r\n");
            EndContext();
#line 98 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\PlanMaster\APlanMaster.cshtml"
                  


                    List<ZCLINIC.Areas.Master.Models.Degree> Degree = new ZCLINIC.Areas.Master.Models.Degree().Master_DegreeGetAll(Context.Session.GetBValues(), Context.GetIP(), Context.GetCInfo());
                    Degree.Insert(0, new ZCLINIC.Areas.Master.Models.Degree {  DegId= 0,DegName = "Select Degree  Name" });
                

#line default
#line hidden
            BeginContext(2723, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(2740, 154, false);
#line 104 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\PlanMaster\APlanMaster.cshtml"
           Write(Html.DropDownList("DegreeId", Degree.Select(s => new SelectListItem() { Text = s.DegName, Value = s.DegId.ToString() }), new { @class = "form-control " }));

#line default
#line hidden
            EndContext();
            BeginContext(2894, 1231, true);
            WriteLiteral(@"


            </div>
          



        </div>
    </div>







    <div class=""clearfix""></div>


    <div class=""panel-body form-group panel panel-flat mt-5"" style=""height:322px; width:100%; overflow-y:auto;"" id=""table-div"">


        <div class=""table-responsive container-fluid quotaiontable"">
            <table class=""table table-xxs table-md table-bordered table-striped table-hover bg-lightgray dataTables_scrollBody"">
                <thead>
                    <tr class=""bg-blue-800"">

                        <th>Semester Name</th>
                       
                        <th>AdmissionFee</th>
                        <th>TuitionFee</th>
                        <th>AnnualFee</th>
                        <th>EnrollFee</th>
                        <th>ExamFee</th>
                        <th>KUAFee</th>
                        
                        <th>MisFee</th>
                        <th>PenaltyAmt</th>
                        <th>DisAmt</th>
     ");
            WriteLiteral("                   <th>Action</th>\r\n\r\n\r\n                     \r\n\r\n\r\n                    </tr>\r\n                    <tr>\r\n\r\n\r\n\r\n\r\n\r\n\r\n                        <th class=\"col-md-3\">\r\n                            ");
            EndContext();
            BeginContext(4126, 226, false);
#line 159 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\PlanMaster\APlanMaster.cshtml"
                       Write(Html.DropDownList("semesterId", Semester.Select(p => new SelectListItem() { Text = p.SName.ToString(), Value = p.Id.ToString() }), new { @class = "bootstrap-select vatratecal", data_live_search = "true", data_width = "100%" }));

#line default
#line hidden
            EndContext();
            BeginContext(4352, 1750, true);
            WriteLiteral(@"

                        </th>
                        


                        <th class=""col-md-1""><input type=""number"" class=""form-control AdmissionFee TxtBox"" , id=""AdmissionFee"" /></th>
                        <th class=""col-md-1""><input type=""number"" class=""form-control TutionFee TxtBox"" id=""TutionFee"" /></th>
                        <th class=""col-md-1""><input type=""number"" class=""form-control AnnualFee TxtBox"" id=""AnnualFee"" /></th>
                        <th class=""col-md-1""><input type=""number"" class=""form-control Enrollmentfee TxtBox"" id=""Enrollmentfee"" /></th>
                        <th class=""col-md-1""><input type=""number"" class=""form-control ExamFee TxtBox"" id=""ExamFee"" /></th>
                        <th class=""col-md-1""><input type=""number"" class=""form-control KUAFee TxtBox"" id=""KUAFee"" /></th>
                        <th class=""col-md-1""><input type=""number"" class=""form-control MisFee TxtBox"" id=""MisFee"" /></th>
                        <th class=""col-md-1""><input type=""numbe");
            WriteLiteral(@"r"" class=""form-control PenaltyFee TxtBox"" id=""PenaltyFee"" /></th>
                        <th class=""col-md-1""><input type=""number"" class=""form-control DisAmt TxtBox"" id=""DisAmt"" /></th>
                     





                        <th class=""col-lg-1""><a class=""icon-add text-primary"" id=""AddItemBtn""></a></th>
                    </tr>


                </thead>


                <tbody id=""tbodytable"">
                
                
                
                
                
                
                </tbody>










                <tfoot>
                        <tr>

                            
                      
                            <td>");
            EndContext();
            BeginContext(6103, 103, false);
#line 210 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\PlanMaster\APlanMaster.cshtml"
                           Write(Html.TextBoxFor(m => m.TFees, new { @class = "form-control", type = "number", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(6206, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(6246, 111, false);
#line 211 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\PlanMaster\APlanMaster.cshtml"
                           Write(Html.TextBoxFor(m => m.TAdmissionFee, new { @class = "form-control", type = "number", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(6357, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(6397, 109, false);
#line 212 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\PlanMaster\APlanMaster.cshtml"
                           Write(Html.TextBoxFor(m => m.T_TutionFee, new { @class = "form-control", type = "number", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(6506, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(6546, 108, false);
#line 213 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\PlanMaster\APlanMaster.cshtml"
                           Write(Html.TextBoxFor(m => m.T_Annelfee, new { @class = "form-control", type = "number", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(6654, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(6694, 109, false);
#line 214 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\PlanMaster\APlanMaster.cshtml"
                           Write(Html.TextBoxFor(m => m.TEnrollment, new { @class = "form-control", type = "number", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(6803, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(6843, 103, false);
#line 215 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\PlanMaster\APlanMaster.cshtml"
                           Write(Html.TextBoxFor(m => m.TExam, new { @class = "form-control", type = "number", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(6946, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(6986, 102, false);
#line 216 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\PlanMaster\APlanMaster.cshtml"
                           Write(Html.TextBoxFor(m => m.TKUA, new { @class = "form-control", type = "number", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(7088, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(7128, 102, false);
#line 217 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\PlanMaster\APlanMaster.cshtml"
                           Write(Html.TextBoxFor(m => m.TMis, new { @class = "form-control", type = "number", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(7230, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(7270, 106, false);
#line 218 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\PlanMaster\APlanMaster.cshtml"
                           Write(Html.TextBoxFor(m => m.TPenalty, new { @class = "form-control", type = "number", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(7376, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(7416, 102, false);
#line 219 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\PlanMaster\APlanMaster.cshtml"
                           Write(Html.TextBoxFor(m => m.TDis, new { @class = "form-control", type = "number", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(7518, 626, true);
            WriteLiteral(@"</td>



                            



                        </tr>

                    </tfoot>
















            </table>




        </div>


    </div>

















    <div class=""modal-footer mt-10 no-padding no-border"">


        <a data-url=""/Transaction/PlanMaster/Index"" data-script=""#"" class=""btn btn-danger btn-xs  closeBtn"" data-dismiss=""modal""><i class=""icon-cross""></i>Close</a>
        
        <button type=""button"" data-submit="""" class=""btn btn-primary  btn-xs  SaveBtn""><i class=""icon-floppy-disk position-left""></i>Save</button>
");
            EndContext();
            BeginContext(8294, 25, true);
            WriteLiteral("\r\n    </div>\r\n\r\n</form>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ZCLINIC.Areas.Transaction.Models.PlanMaster> Html { get; private set; }
    }
}
#pragma warning restore 1591