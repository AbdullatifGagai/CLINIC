#pragma checksum "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Report\Views\Reportrdlc\AReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4aa277f63902caaf64d640442bfc26e637ad11a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Report_Views_Reportrdlc_AReport), @"mvc.1.0.view", @"/Areas/Report/Views/Reportrdlc/AReport.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Report/Views/Reportrdlc/AReport.cshtml", typeof(AspNetCore.Areas_Report_Views_Reportrdlc_AReport))]
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
#line 1 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Report\Views\Reportrdlc\AReport.cshtml"
using ZCLINIC;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4aa277f63902caaf64d640442bfc26e637ad11a", @"/Areas/Report/Views/Reportrdlc/AReport.cshtml")]
    public class Areas_Report_Views_Reportrdlc_AReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(17, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
#line 5 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Report\Views\Reportrdlc\AReport.cshtml"
   ZCLINIC.Areas.Report.Model.ReportValues list = ViewBag.values;
    BValues bValues = ViewBag.bv; 

#line default
#line hidden
            BeginContext(127, 55, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n    <object style=\"width:100%; height:100%\"");
            EndContext();
            BeginWriteAttribute("data", " data=\"", 182, "\"", 673, 26);
            WriteAttributeValue("", 189, "https://localhost:44393//Reports/ViewPDF?bv.IP=", 189, 47, true);
#line 13 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Report\Views\Reportrdlc\AReport.cshtml"
WriteAttributeValue("", 236, Context.GetIP(), 236, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 252, "&bv.CInfo=", 252, 10, true);
#line 13 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Report\Views\Reportrdlc\AReport.cshtml"
WriteAttributeValue("", 262, Context.GetCInfo(), 262, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 281, "&bv.reportValues.Name=", 281, 22, true);
#line 13 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Report\Views\Reportrdlc\AReport.cshtml"
WriteAttributeValue("", 303, list.Name, 303, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 313, "&bv.reportValues.Value[0]=", 313, 26, true);
#line 13 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Report\Views\Reportrdlc\AReport.cshtml"
WriteAttributeValue("", 339, list.Value[0], 339, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 353, "&bv.reportValues.Value[1]=", 353, 26, true);
#line 13 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Report\Views\Reportrdlc\AReport.cshtml"
WriteAttributeValue("", 379, list.Value[1], 379, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 393, "&bv.reportValues.Value[2]=", 393, 26, true);
#line 13 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Report\Views\Reportrdlc\AReport.cshtml"
WriteAttributeValue("", 419, list.Value[2], 419, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 433, "&bv.reportValues.Value[3]=", 433, 26, true);
#line 13 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Report\Views\Reportrdlc\AReport.cshtml"
WriteAttributeValue("", 459, list.Value[3], 459, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 473, "&bv.reportValues.Value[4]=", 473, 26, true);
#line 13 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Report\Views\Reportrdlc\AReport.cshtml"
WriteAttributeValue("", 499, list.Value[4], 499, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 513, "&bv.reportValues.Value[5]=", 513, 26, true);
#line 13 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Report\Views\Reportrdlc\AReport.cshtml"
WriteAttributeValue("", 539, list.Value[5], 539, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 553, "&bv.reportValues.Value[6]=", 553, 26, true);
#line 13 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Report\Views\Reportrdlc\AReport.cshtml"
WriteAttributeValue("", 579, list.Value[6], 579, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 593, "&bv.UserId=", 593, 11, true);
#line 13 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Report\Views\Reportrdlc\AReport.cshtml"
WriteAttributeValue("", 604, bValues.UserId, 604, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 619, "&bv.TenantId=", 619, 13, true);
#line 13 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Report\Views\Reportrdlc\AReport.cshtml"
WriteAttributeValue("", 632, bValues.TenantId, 632, 17, false);

#line default
#line hidden
            WriteAttributeValue("", 649, "&bv.AppId=", 649, 10, true);
#line 13 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Report\Views\Reportrdlc\AReport.cshtml"
WriteAttributeValue("", 659, bValues.AppId, 659, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(674, 40, true);
            WriteLiteral(" type=\"application/pdf\">\r\n        <embed");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 714, "\"", 882, 10);
            WriteAttributeValue("", 720, "https://localhost:44393//Reports/ViewPDF?ReportName=", 720, 52, true);
#line 14 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Report\Views\Reportrdlc\AReport.cshtml"
WriteAttributeValue("", 772, list.Name, 772, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 782, "&bv.IP=", 782, 7, true);
#line 14 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Report\Views\Reportrdlc\AReport.cshtml"
WriteAttributeValue("", 789, Context.GetIP(), 789, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 805, "&bv.CInfo=", 805, 10, true);
#line 14 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Report\Views\Reportrdlc\AReport.cshtml"
WriteAttributeValue("", 815, Context.GetCInfo(), 815, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 834, "&bv.rvalues.Name=", 834, 17, true);
#line 14 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Report\Views\Reportrdlc\AReport.cshtml"
WriteAttributeValue("", 851, list.Name, 851, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 861, "&bv.Value=", 861, 10, true);
#line 14 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Report\Views\Reportrdlc\AReport.cshtml"
WriteAttributeValue("", 871, list.Value, 871, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(883, 49, true);
            WriteLiteral(" type=\"application/pdf\" />\r\n    </object>\r\n\r\n\r\n\r\n");
            EndContext();
            BeginContext(1747, 245, true);
            WriteLiteral("<script>\r\n    debugger;\r\n    var uri = window.location.toString();\r\n    if (uri.indexOf(\"?\") > 0) {\r\n        var clean_uri = uri.substring(0, uri.indexOf(\"?\"));\r\n        window.history.replaceState({}, document.title, clean_uri);\r\n    }</script>");
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
