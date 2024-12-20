#pragma checksum "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Levels\ALevels.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f063d3e90746ac0e67e8783504d5d37f0138f575"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Master_Views_Levels_ALevels), @"mvc.1.0.view", @"/Areas/Master/Views/Levels/ALevels.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Master/Views/Levels/ALevels.cshtml", typeof(AspNetCore.Areas_Master_Views_Levels_ALevels))]
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
#line 1 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Levels\ALevels.cshtml"
using SMSERP;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f063d3e90746ac0e67e8783504d5d37f0138f575", @"/Areas/Master/Views/Levels/ALevels.cshtml")]
    public class Areas_Master_Views_Levels_ALevels : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SMSERP.Areas.Master.Models.Levels>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Levels\ALevels.cshtml"
  
    string URL = Model == null ? "/Master/Levels/SaveLevels" : "/Master/Levels/UpdateLevels";
    int counter = 0;

#line default
#line hidden
            BeginContext(183, 373, true);
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
            BeginContext(557, 3, false);
#line 24 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Levels\ALevels.cshtml"
                         Write(URL);

#line default
#line hidden
            EndContext();
            BeginContext(560, 77, true);
            WriteLiteral("\" data-rurl=\"/Master/Levels\" data-display=\"Bank Payment Voucher\">\r\n\r\n\r\n\r\n    ");
            EndContext();
            BeginContext(638, 26, false);
#line 28 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Levels\ALevels.cshtml"
Write(Html.HiddenFor(m => m.LId));

#line default
#line hidden
            EndContext();
            BeginContext(664, 244, true);
            WriteLiteral("\r\n    <div class=\"row\">\r\n\r\n\r\n\r\n        <div class=\"form-group form-group-xs col-md-12\">\r\n\r\n            <div class=\"form-group form-group-xs col-md-6\">\r\n                <label>Level Name<b class=\"wysiwyg-color-red\"></b></label>\r\n                ");
            EndContext();
            BeginContext(909, 104, false);
#line 37 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Levels\ALevels.cshtml"
           Write(Html.TextBoxFor(m => m.LevelName, new { @class = "form-control", type = "text", required = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(1013, 163, true);
            WriteLiteral("\r\n\r\n            </div>\r\n            <div class=\"form-group form-group-xs col-md-6\">\r\n                <label>Teacher Name<b class=\"wysiwyg-color-red\"></b></label>\r\n");
            EndContext();
#line 42 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Levels\ALevels.cshtml"
                  
                    List<SMSERP.Areas.Master.Models.Teacher> Teacher = new SMSERP.Areas.Master.Models.Teacher().Master_TeacherGetAll(Context.Session.GetBValues(), Context.GetIP(), Context.GetCInfo());

                

#line default
#line hidden
            BeginContext(1419, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(1436, 164, false);
#line 46 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Levels\ALevels.cshtml"
           Write(Html.DropDownList("TeacherId", Teacher.Select(s => new SelectListItem() { Text = s.TeacherName, Value = s.TeacherId.ToString() }), new { @class = "form-control " }));

#line default
#line hidden
            EndContext();
            BeginContext(1600, 286, true);
            WriteLiteral(@"
            </div>








        </div>
    </div>



    <div class=""row"">

        <div class=""form-group form-group-xs col-md-12"">
            <div class=""form-group form-group-xs col-md-6"">
                <label>Days<b class=""wysiwyg-color-red""></b></label>
");
            EndContext();
#line 66 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Levels\ALevels.cshtml"
                  
                    List<SMSERP.Areas.Master.Models.Days> Days = new SMSERP.Areas.Master.Models.Days().Master_DaysGetAll(Context.Session.GetBValues(), Context.GetIP(), Context.GetCInfo());

                

#line default
#line hidden
            BeginContext(2117, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(2134, 148, false);
#line 70 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Levels\ALevels.cshtml"
           Write(Html.DropDownList("DaysId", Days.Select(s => new SelectListItem() { Text = s.DayName, Value = s.DId.ToString() }), new { @class = "form-control " }));

#line default
#line hidden
            EndContext();
            BeginContext(2282, 184, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n\r\n            <div class=\"form-group form-group-xs col-md-6\">\r\n                <label>Admission Fee<b class=\"wysiwyg-color-red\"></b></label>\r\n                ");
            EndContext();
            BeginContext(2467, 152, false);
#line 77 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Levels\ALevels.cshtml"
           Write(Html.TextBoxFor(m => m.AdmissionFee, new { @class = "form-control input-group", placeholder = "Admission Fee", type = "number", required = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(2619, 315, true);
            WriteLiteral(@"

            </div>






        </div>



    </div>



    <div class=""row"">

        <div class=""form-group form-group-xs col-md-12"">

            <div class=""form-group form-group-xs col-md-6"">
                <label>Monthly Fee<b class=""wysiwyg-color-red""></b></label>
                ");
            EndContext();
            BeginContext(2935, 148, false);
#line 100 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Levels\ALevels.cshtml"
           Write(Html.TextBoxFor(m => m.MonthlyFee, new { @class = "form-control input-group", placeholder = "Monthly Fee", type = "number", required = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(3083, 179, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n            <div class=\"form-group form-group-xs col-md-6\">\r\n                <label>Course Fee<b class=\"wysiwyg-color-red\"></b></label>\r\n                ");
            EndContext();
            BeginContext(3263, 146, false);
#line 106 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Levels\ALevels.cshtml"
           Write(Html.TextBoxFor(m => m.CourseFee, new { @class = "form-control input-group", placeholder = "Course Fee", type = "number", required = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(3409, 306, true);
            WriteLiteral(@"

            </div>


        </div>



    </div>


    <div class=""row"">

        <div class=""form-group form-group-xs col-md-12"">

            <div class=""form-group form-group-xs col-md-6"">
                <label>Secuirty Fee<b class=""wysiwyg-color-red""></b></label>
                ");
            EndContext();
            BeginContext(3716, 150, false);
#line 124 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Levels\ALevels.cshtml"
           Write(Html.TextBoxFor(m => m.SecuirtyFee, new { @class = "form-control input-group", placeholder = "Secuirty Fee", type = "number", required = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(3866, 179, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n            <div class=\"form-group form-group-xs col-md-6\">\r\n                <label>Annual Fee<b class=\"wysiwyg-color-red\"></b></label>\r\n                ");
            EndContext();
            BeginContext(4046, 146, false);
#line 130 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Levels\ALevels.cshtml"
           Write(Html.TextBoxFor(m => m.AnnualFee, new { @class = "form-control input-group", placeholder = "Annual Fee", type = "number", required = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(4192, 305, true);
            WriteLiteral(@"

            </div>


        </div>



    </div>

    <div class=""row"">

        <div class=""form-group form-group-xs col-md-12"">

            <div class=""form-group form-group-xs col-md-6"">
                <label>Transport Fee<b class=""wysiwyg-color-red""></b></label>
                ");
            EndContext();
            BeginContext(4498, 152, false);
#line 147 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Levels\ALevels.cshtml"
           Write(Html.TextBoxFor(m => m.TransportFee, new { @class = "form-control input-group", placeholder = "Transport Fee", type = "number", required = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(4650, 179, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n            <div class=\"form-group form-group-xs col-md-6\">\r\n                <label>Others Fee<b class=\"wysiwyg-color-red\"></b></label>\r\n                ");
            EndContext();
            BeginContext(4830, 143, false);
#line 153 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Levels\ALevels.cshtml"
           Write(Html.TextBoxFor(m => m.Others, new { @class = "form-control input-group", placeholder = "Others Fee", type = "number", required = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(4973, 304, true);
            WriteLiteral(@"

            </div>


        </div>



    </div>


    <div class=""row"">

        <div class=""form-group form-group-xs col-md-12"">

            <div class=""form-group form-group-xs col-md-6"">
                <label>Start Date<b class=""wysiwyg-color-red""></b></label>
                ");
            EndContext();
            BeginContext(5278, 100, false);
#line 171 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Levels\ALevels.cshtml"
           Write(Html.TextBoxFor(m => m.Sdate, new { @class = "form-control", type = "date", required = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(5378, 177, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n            <div class=\"form-group form-group-xs col-md-6\">\r\n                <label>End Date<b class=\"wysiwyg-color-red\"></b></label>\r\n                ");
            EndContext();
            BeginContext(5556, 100, false);
#line 177 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Levels\ALevels.cshtml"
           Write(Html.TextBoxFor(m => m.Edate, new { @class = "form-control", type = "date", required = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(5656, 311, true);
            WriteLiteral(@"

            </div>


        </div>
    </div>



    <div class=""row"">

        <div class=""form-group form-group-xs col-md-12"">

            <div class=""form-group form-group-xs col-md-6"">
                <label>Master Account<b class=""wysiwyg-color-red""></b></label>
                <div>
");
            EndContext();
#line 194 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Levels\ALevels.cshtml"
                      
                        List<SMSERP.Areas.Master.Models.Degree> Degree = new SMSERP.Areas.Master.Models.Degree().Master_DegreeGetAll(Context.Session.GetBValues(), Context.GetIP(), Context.GetCInfo());
                        Degree.Insert(0, new SMSERP.Areas.Master.Models.Degree { DegId = 0, DegName = "Select Degree" });

                    

#line default
#line hidden
            BeginContext(6341, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(6362, 247, false);
#line 199 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Levels\ALevels.cshtml"
               Write(Html.DropDownList("DegreeId", Degree.Select(p => new SelectListItem() { Text = p.DegName, Value = p.DegId.ToString() }), new { @class = "form-control", data_style = "btn-default btn-xs", tabindex = '4', data_search = "true", data_width = "100%" }));

#line default
#line hidden
            EndContext();
            BeginContext(6609, 212, true);
            WriteLiteral("\r\n\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group form-group-xs col-md-6\">\r\n                <label>Session Name<b class=\"wysiwyg-color-red\"></b></label>\r\n                <div>\r\n");
            EndContext();
#line 207 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Levels\ALevels.cshtml"
                      
                        List<SMSERP.Areas.Master.Models.Fiscal> Fiscal = new SMSERP.Areas.Master.Models.Fiscal().Master_FiscalGetAll(Context.Session.GetBValues(), Context.GetIP(), Context.GetCInfo());
                        Fiscal.Insert(0, new SMSERP.Areas.Master.Models.Fiscal { FId = 0, FName = "Select Fiscal" });

                    

#line default
#line hidden
            BeginContext(7191, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(7212, 244, false);
#line 212 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Levels\ALevels.cshtml"
               Write(Html.DropDownList("SessionId", Fiscal.Select(p => new SelectListItem() { Text = p.FName, Value = p.FId.ToString() }), new { @class = "form-control", data_style = "btn-default btn-xs", tabindex = '4', data_search = "true", data_width = "100%" }));

#line default
#line hidden
            EndContext();
            BeginContext(7456, 1406, true);
            WriteLiteral(@"

                </div>
            </div>



        </div>
    </div>



    <!--<div class=""panel-body form-group panel panel-flat mt-5"" style=""height:322px; width:100%; overflow-y:auto;"" id=""table-div"">


        <div class=""table-responsive container-fluid quotaiontable"">
            <table class=""table table-xxs table-md table-bordered table-striped table-hover bg-lightgray dataTables_scrollBody"">
                <thead>
                    <tr class=""bg-blue-800"">

                        <th>Account Name</th>
                        <th>Remarks</th>
                        <th>Debit</th>
                        <th>Credit</th>


                        <th></th>


                    </tr>
                    <tr>





                        <th class=""col-md-5"">


                        </th>
                        <th class=""col-md-3""><input type=""text"" class=""form-control Remarksfield TxtBox"" , id=""Remarks"" /></th>
                        <th class=""col-");
            WriteLiteral(@"md-2""><input type=""text"" class=""form-control Debitfield TxtBox"" id=""DebitAmt"" /></th>
                        <th class=""col-md-2""><input type=""text"" class=""form-control Creditfield TxtBox"" id=""CreditAmt"" /></th>

                        <th class=""col-lg-1""><a class=""icon-add text-primary"" id=""AddItemBtn""></a></th>
                    </tr>


                </thead>-->
");
            EndContext();
            BeginContext(10001, 20, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            EndContext();
            BeginContext(10477, 457, true);
            WriteLiteral(@"















    <!--</table>




        </div>


    </div>-->

















    <div class=""modal-footer mt-10 no-padding no-border"">



        <button type=""button"" class=""btn btn-danger btn-xs"" data-dismiss=""modal""><i class=""icon-cross""></i>Close</button>
        <button type=""button"" data-submit=""true"" class=""btn btn-primary  btn-xs""><i class=""icon-floppy-disk position-left""></i>Save</button>
");
            EndContext();
            BeginContext(11084, 180, true);
            WriteLiteral("\r\n    </div>\r\n\r\n</form>\r\n\r\n<script>\r\n\r\n    document.getElementById(\'Sdate\').valueAsDate = new Date();\r\n    document.getElementById(\'Edate\').valueAsDate = new Date();\r\n\r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SMSERP.Areas.Master.Models.Levels> Html { get; private set; }
    }
}
#pragma warning restore 1591
