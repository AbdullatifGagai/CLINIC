#pragma checksum "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Report\Views\ReportDetail\CollectionDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00a82d27a4c964c3492b16a0e057e468cb7a45bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Report_Views_ReportDetail_CollectionDetail), @"mvc.1.0.view", @"/Areas/Report/Views/ReportDetail/CollectionDetail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Report/Views/ReportDetail/CollectionDetail.cshtml", typeof(AspNetCore.Areas_Report_Views_ReportDetail_CollectionDetail))]
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
#line 1 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Report\Views\ReportDetail\CollectionDetail.cshtml"
using ZCLINIC;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00a82d27a4c964c3492b16a0e057e468cb7a45bd", @"/Areas/Report/Views/ReportDetail/CollectionDetail.cshtml")]
    public class Areas_Report_Views_ReportDetail_CollectionDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(16, 162, true);
            WriteLiteral("<div class=\"page-header page-header-default\">\r\n    <div class=\"breadcrumb-line\">\r\n        <h5 class=\"text-semibold\">Collection Report</h5>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
#line 8 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Report\Views\ReportDetail\CollectionDetail.cshtml"
  
    string a = string.Empty;

#line default
#line hidden
            BeginContext(215, 1032, true);
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



                    <div class=""form-group form-group-xs col-md-4"">
                       
                        <div class=""form-group form-group-xs col-md-4"">
                            <label>Shift Name<b class=""wysiwyg-color-red""></b></");
            WriteLiteral("label>\r\n");
            EndContext();
#line 61 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Report\Views\ReportDetail\CollectionDetail.cshtml"
                              

                                var Status = new List<(int Id, string Name)>();

                                Status.Add((Id: 0, Name: "All"));
                                Status.Add((Id: 1, Name: "A"));
                                Status.Add((Id: 2, Name: "B"));
                                Status.Add((Id: 3, Name: "C"));




                            

#line default
#line hidden
            BeginContext(1665, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(1694, 241, false);
#line 74 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Report\Views\ReportDetail\CollectionDetail.cshtml"
                       Write(Html.DropDownList("ShiftN", Status.Select(p => new SelectListItem() { Text = p.Name, Value = p.Name.ToString() }), new { @class = "form-control", data_style = "btn-default btn-xs", tabindex = '4', data_search = "true", data_width = "100%" }));

#line default
#line hidden
            EndContext();
            BeginContext(1935, 130, true);
            WriteLiteral("\r\n\r\n                        </div>\r\n\r\n                    </div>\r\n\r\n\r\n\r\n                </div>\r\n\r\n\r\n\r\n\r\n            </div>\r\n\r\n\r\n\r\n");
            EndContext();
            BeginContext(2311, 1963, true);
            WriteLiteral(@"
            <div class=""row"">


                <div class=""form-group form-group-xs col-md-6"">

                    <div class=""form-group form-group-xs col-md-4"">
                        <a id=""CollectPrint"" class=""btn btn-primary btn-xs""><i class=""position-left""></i>Collection Summary Report</a>



                    </div>
                 





                </div>



            </div>

        </div>

    </div>
</div>

<script>


    document.getElementById('FromDate').valueAsDate = new Date();
    document.getElementById('ToDate').valueAsDate = new Date();



    $('#CollectPrint').click(function (e) {



        var Date = 'Form Date: ' + moment($(""#FromDate"").val()).format('DD/MM/YYYY') +
            ' Up to Date: ' + moment($(""#ToDate"").val()).format('DD/MM/YYYY');


        //var RecId = $('#FId').val();


        debugger


        var value = `/Report/Reportrdlc/AReport?rvalues.Name=50&rvalues.Value[0]=${$('#FromDate').val()}&rvalues.Value[");
            WriteLiteral(@"1]=${$('#ToDate').val()}&rvalues.Value[2]=${$('#ShiftN').val()}&rvalues.Value[3]=''&rvalues.Value[4]=''&rvalues.Value[5]=''&rvalues.Value[6]=${Date}`
        $(this).attr('href', value)
        $(this).attr('target', ""_blank"")




    })



    //$('#AdPrint').click(function (e) {



    //    var Date = 'Form Date: ' + moment($(""#FromDate"").val()).format('DD/MM/YYYY') +
    //        ' Up to Date: ' + moment($(""#ToDate"").val()).format('DD/MM/YYYY');


    //    //var RecId = $('#FId').val();


    //    debugger


    //    var value = `/Report/Reportrdlc/AReport?rvalues.Name=48&rvalues.Value[0]=${$('#FromDate').val()}&rvalues.Value[1]=${$('#ToDate').val()}&rvalues.Value[2]=''&rvalues.Value[3]=''&rvalues.Value[4]=''&rvalues.Value[5]=''&rvalues.Value[6]=${Date}`
    //    $(this).attr('href', value)
    //    $(this).attr('target', ""_blank"")




    //})














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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
