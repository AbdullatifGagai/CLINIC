#pragma checksum "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Report\Views\ReportDetail\BatchWiseDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a3c22b41435f5955f5b998c5e9704b37c76d43e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Report_Views_ReportDetail_BatchWiseDetail), @"mvc.1.0.view", @"/Areas/Report/Views/ReportDetail/BatchWiseDetail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Report/Views/ReportDetail/BatchWiseDetail.cshtml", typeof(AspNetCore.Areas_Report_Views_ReportDetail_BatchWiseDetail))]
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
#line 1 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Report\Views\ReportDetail\BatchWiseDetail.cshtml"
using SMSERP;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a3c22b41435f5955f5b998c5e9704b37c76d43e", @"/Areas/Report/Views/ReportDetail/BatchWiseDetail.cshtml")]
    public class Areas_Report_Views_ReportDetail_BatchWiseDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(15, 162, true);
            WriteLiteral("<div class=\"page-header page-header-default\">\r\n    <div class=\"breadcrumb-line\">\r\n        <h5 class=\"text-semibold\">Batch Wise Detail</h5>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
#line 8 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Report\Views\ReportDetail\BatchWiseDetail.cshtml"
  
    string a = string.Empty;

#line default
#line hidden
            BeginContext(214, 427, true);
            WriteLiteral(@"


<div class=""content"">
    <div class=""panel panel-flat"">
        <div class=""panel-body"">


















            <div class=""row"">


                <div class=""form-group form-group-xs col-md-12"">



                    <div class=""form-group form-group-xs col-md-10"">
                        <label>Batch Name<b class=""wysiwyg-color-red""></b></label>
                        <div>
");
            EndContext();
#line 45 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Report\Views\ReportDetail\BatchWiseDetail.cshtml"
                              
                                List<SMSERP.Areas.Master.Models.Levels> Bactn = new SMSERP.Areas.Master.Models.Levels().Master_LevelsBatchGetAll(Context.Session.GetBValues(), Context.GetIP(), Context.GetCInfo());
                           //    Supplier.Insert(0, new SMSERP.Areas.Master.Models.Supplier { SupId = 0, SupplyName = "ALL" });

                            

#line default
#line hidden
            BeginContext(1049, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(1078, 241, false);
#line 50 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Report\Views\ReportDetail\BatchWiseDetail.cshtml"
                       Write(Html.DropDownList("LId", Bactn.Select(p => new SelectListItem() { Text = p.BatchName, Value = p.LId.ToString() }), new { @class = "form-control", data_style = "btn-default btn-xs", tabindex = '4', data_search = "true", data_width = "100%" }));

#line default
#line hidden
            EndContext();
            BeginContext(1319, 122, true);
            WriteLiteral("\r\n\r\n                        </div>\r\n                    </div>\r\n\r\n\r\n\r\n\r\n\r\n                </div>\r\n\r\n\r\n            </div>\r\n");
            EndContext();
            BeginContext(3398, 1406, true);
            WriteLiteral(@"
                <div class=""row"">


                    <div class=""form-group form-group-xs col-md-8"">

                        <div class=""form-group form-group-xs col-md-4"">
                            <a id=""SPrint"" class=""btn btn-primary btn-xs""><i class=""position-left""></i>Batch Wise Detail</a>



                        </div>


                        <div class=""form-group form-group-xs col-md-4"">
                            <a id=""SPrint"" class=""btn btn-primary btn-xs""><i class=""position-left""></i>Excel Batch Wise Detail</a>



                        </div>






                    </div>



                </div>

            </div>

    </div>
</div>

<script>


    //document.getElementById('FromDate').valueAsDate = new Date();
    //document.getElementById('ToDate').valueAsDate = new Date();



    $('#SPrint').click(function (e) {



        var Date = $('#LId option:selected').text();
        


        //var RecId = $('#FId').val();

");
            WriteLiteral(@"
        debugger


        var value = `/Report/Reportrdlc/AReport?rvalues.Name=42&rvalues.Value[0]=${$('#LId').val()}&rvalues.Value[1]=''&rvalues.Value[2]=''&rvalues.Value[3]=''&rvalues.Value[4]=''&rvalues.Value[5]=''&rvalues.Value[6]=${Date}`
        $(this).attr('href', value)
        $(this).attr('target', ""_blank"")




    })














</script>");
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
