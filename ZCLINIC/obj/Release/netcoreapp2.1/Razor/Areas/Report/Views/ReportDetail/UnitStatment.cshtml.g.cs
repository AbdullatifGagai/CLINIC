#pragma checksum "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Report\Views\ReportDetail\UnitStatment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "baec48652035954bdebb38459e1e531b9535bb0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Report_Views_ReportDetail_UnitStatment), @"mvc.1.0.view", @"/Areas/Report/Views/ReportDetail/UnitStatment.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Report/Views/ReportDetail/UnitStatment.cshtml", typeof(AspNetCore.Areas_Report_Views_ReportDetail_UnitStatment))]
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
#line 1 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Report\Views\ReportDetail\UnitStatment.cshtml"
using SMSERP;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"baec48652035954bdebb38459e1e531b9535bb0a", @"/Areas/Report/Views/ReportDetail/UnitStatment.cshtml")]
    public class Areas_Report_Views_ReportDetail_UnitStatment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(15, 172, true);
            WriteLiteral("<div class=\"page-header page-header-default\">\r\n    <div class=\"breadcrumb-line\">\r\n        <h5 class=\"text-semibold\">Unit Wise Account Statement</h5>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
#line 8 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Report\Views\ReportDetail\UnitStatment.cshtml"
  
    string a = string.Empty;

#line default
#line hidden
            BeginContext(224, 2898, true);
            WriteLiteral(@"


<div class=""content"">
    <div class=""panel panel-flat"">
        <div class=""panel-body"">


















            <div class=""row"">


                <div class=""form-group form-group-xs col-md-12"">

                    <div class=""form-group form-group-xs col-md-2"">
                        <label>From  Date<b class=""wysiwyg-color-red""></b></label>
                        <input type=""date"" class=""form-control"" id=""FromDate"" />

                    </div>




                    <div class=""form-group form-group-xs col-md-2"">
                        <label>To Date<b class=""wysiwyg-color-red""></b></label>
                        <input type=""date"" class=""form-control"" id=""ToDate"" />

                    </div>


                    <div class=""form-group form-group-xs col-md-2"">
                        <label>Allow<b class=""wysiwyg-color-red""></b></label>
                        <input type=""text"" class=""form-control"" readonly id=""AllowId"" />

         ");
            WriteLiteral(@"           </div>





                </div>




            </div>



            <div class=""row"">


                <div class=""form-group form-group-xs col-md-12"">







                    <div class=""form-group form-group-xs col-md-4"">
                        <label>Unit  Name<b class=""wysiwyg-color-red""></b></label>
                        <input type=""text"" class=""form-control"" id=""UnitN"" />

                    </div>

                    <div class=""form-group form-group-xs col-md-3"">
                        <label>Card Id<b class=""wysiwyg-color-red""></b></label>
                        <input type=""text"" class=""form-control"" id=""CardId"" />

                    </div>

                    <div class=""form-group form-group-xs col-md-2"">
                        <label>Reg No<b class=""wysiwyg-color-red""></b></label>
                        <input type=""text"" class=""form-control"" readonly id=""RegNo"" />

                    </div>

                    <div cl");
            WriteLiteral(@"ass=""form-group form-group-xs col-md-2"">
                        <label>Member No<b class=""wysiwyg-color-red""></b></label>
                        <input type=""text"" class=""form-control"" readonly id=""Mno"" />

                    </div>




                </div>
            </div>

            <div class=""row"">


                <div class=""form-group form-group-xs col-md-12"">





                    <div class=""form-group form-group-xs col-md-4"">
                        <label>Member Name<b class=""wysiwyg-color-red""></b></label>
                        <input type=""text"" class=""form-control"" readonly id=""AllowName"" />

                    </div>



                    <div class=""form-group form-group-xs col-md-4"">

                        <label>Statment Selected<b class=""wysiwyg-color-red""></b></label>
");
            EndContext();
#line 136 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Report\Views\ReportDetail\UnitStatment.cshtml"
                          
                            List<SMSERP.Areas.Master.Models.Master_Vmode> cities = new SMSERP.Areas.Master.Models.Master_Vmode().Master_VmodeGetAll(Context.Session.GetBValues(), Context.GetIP(), Context.GetCInfo());

                        

#line default
#line hidden
            BeginContext(3396, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(3421, 146, false);
#line 140 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Report\Views\ReportDetail\UnitStatment.cshtml"
                   Write(Html.DropDownList("VMode", cities.Select(s => new SelectListItem() { Text = s.VMode, Value = s.Id.ToString() }), new { @class = "form-control " }));

#line default
#line hidden
            EndContext();
            BeginContext(3567, 165, true);
            WriteLiteral("\r\n\r\n                    </div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n                </div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n            </div>\r\n\r\n\r\n\r\n\r\n\r\n          \r\n\r\n            <div class=\"row\">\r\n\r\n\r\n");
            EndContext();
            BeginContext(4450, 886, true);
            WriteLiteral(@"

                <div class=""form-group form-group-xs col-md-10"">

                    <div class=""form-group form-group-xs col-sm-2"">
                        <a id=""Clean"" class=""btn btn-primary btn-xs""><i class=""position-left""></i>Clean</a>


                    </div>




                    <div class=""form-group form-group-xs col-md-3"">
                        <a id=""AccDetail"" class=""btn btn-primary btn-xs""><i class=""position-left""></i>Unit Wise Statement Detail</a>


                    </div>
                  
                    <div class=""form-group form-group-xs col-md-3"">
                        <a id=""AccSummary"" class=""btn btn-primary btn-xs""><i class=""position-left""></i>Unit Wise Statement Summary</a>


                    </div>







                </div>



            </div>

        </div>

    </div>
</div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
