#pragma checksum "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Report\Views\ReportDetail\StudentStatement.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7e5462e3a137c48118a428b64e7c9063e07413e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Report_Views_ReportDetail_StudentStatement), @"mvc.1.0.view", @"/Areas/Report/Views/ReportDetail/StudentStatement.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Report/Views/ReportDetail/StudentStatement.cshtml", typeof(AspNetCore.Areas_Report_Views_ReportDetail_StudentStatement))]
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
#line 1 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Report\Views\ReportDetail\StudentStatement.cshtml"
using SMSERP;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7e5462e3a137c48118a428b64e7c9063e07413e", @"/Areas/Report/Views/ReportDetail/StudentStatement.cshtml")]
    public class Areas_Report_Views_ReportDetail_StudentStatement : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(15, 164, true);
            WriteLiteral("<div class=\"page-header page-header-default\">\r\n    <div class=\"breadcrumb-line\">\r\n        <h5 class=\"text-semibold\">Student Fees Ledger</h5>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
#line 8 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Report\Views\ReportDetail\StudentStatement.cshtml"
  
    string a = string.Empty;

#line default
#line hidden
            BeginContext(216, 2619, true);
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







                </div>




            </div>
            <div class=""row"">


                <div class=""form-group form-group-xs col-md-12"">


                    <div class=""form-group form-group-xs col-md-2"">
             ");
            WriteLiteral(@"           <label>GrId<b class=""wysiwyg-color-red""></b></label>
                        <input type=""text"" readonly class=""form-control"" id=""GrId"" />

                    </div>








                    <div class=""form-group form-group-xs col-md-2"">
                        <label>Gr No<b class=""wysiwyg-color-red""></b></label>
                        <input type=""text"" readonly class=""form-control"" id=""Grno"" />

                    </div>




                    <div class=""form-group form-group-xs col-md-4"">
                        <label>Student Name<b class=""wysiwyg-color-red""></b></label>
                        <input type=""text"" readonly=readonly class=""form-control"" id=""Name"" />

                    </div>




                    <div class=""form-group form-group-xs mt-20 col-md-1"">
                        <a class=""btn btn-info btn-sm"" id=""AddItemBtn"" data-script=""#""><i class=""icon-add mr-5""></i>Student</a>
                    </div>


                    



");
            WriteLiteral(@"




                </div>




            </div>




            <div class=""row"">


                <div class=""form-group form-group-xs col-md-6"">

                    <div class=""form-group form-group-xs col-md-4"">
                        <a id=""FeeId"" class=""btn btn-primary btn-xs""><i class=""position-left""></i>Student Fees Ledger</a>
                       


                      


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