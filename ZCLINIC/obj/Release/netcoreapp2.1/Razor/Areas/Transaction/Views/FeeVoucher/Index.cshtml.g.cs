#pragma checksum "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\FeeVoucher\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "993eacc3a66072cc92695f31118f57b8619835ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Transaction_Views_FeeVoucher_Index), @"mvc.1.0.view", @"/Areas/Transaction/Views/FeeVoucher/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Transaction/Views/FeeVoucher/Index.cshtml", typeof(AspNetCore.Areas_Transaction_Views_FeeVoucher_Index))]
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
#line 1 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\FeeVoucher\Index.cshtml"
using SMSERP;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"993eacc3a66072cc92695f31118f57b8619835ec", @"/Areas/Transaction/Views/FeeVoucher/Index.cshtml")]
    public class Areas_Transaction_Views_FeeVoucher_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SMSERP.Areas.Transaction.Models.FeeVoucher>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(16, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
            BeginContext(86, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\FeeVoucher\Index.cshtml"
  
    bool addview = SMSERP.UserRights.URM_AddNew_IsAuthenticated(Context.Session.GetRoleId(), "66");
    bool editview = SMSERP.UserRights.URM_Update_IsAuthenticated(Context.Session.GetRoleId(), "66");
    bool delete = SMSERP.UserRights.URM_Delete_IsAuthenticated(Context.Session.GetRoleId(), "66");
    bool Print = SMSERP.UserRights.URM_Print_IsAuthenticated(Context.Session.GetRoleId(), "66");


#line default
#line hidden
            BeginContext(498, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 16 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\FeeVoucher\Index.cshtml"
  
    string a = string.Empty;

#line default
#line hidden
            BeginContext(539, 350, true);
            WriteLiteral(@"


<div class=""page-header page-header-default"">
    <div class=""breadcrumb-line"">
        <h6 class=""text-semibold"">Monthly Fee Voucher</h6>
    </div>
</div>


<div class=""content"">
    <div class=""panel panel-flat"">
        <div class=""panel-body"">
            <div class=""row"">
                <div class=""col-md-3 buttons-top"">

");
            EndContext();
#line 35 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\FeeVoucher\Index.cshtml"
                     if (addview)
                    {

#line default
#line hidden
            BeginContext(947, 301, true);
            WriteLiteral(@"                        <a class=""btn btn-success btn-sm"" data-modalhorizontal=""true"" data-modalsize=""modal-full"" data-url=""/Transaction/FeeVoucher/AFeeVoucher"" data-heading=""Monthly  Fee Voucher"" data-script=""/assets/Areas/Transaction/FeeVoucher/FeeVoucher.js""><i class=""icon-add mr-5""></i> Add</a>
");
            EndContext();
#line 38 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\FeeVoucher\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1271, 120, true);
            WriteLiteral("\r\n\r\n\r\n\r\n                </div>\r\n\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n");
            EndContext();
            BeginContext(1746, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2146, 912, true);
            WriteLiteral(@"                    </div>

                </div>

                <div class=""col-sm-3"">
                    <div class=""input-group "">
                        <input type=""text"" class=""form-control"" id=""FilterInput"">
                        <span class=""input-group-addon bg-blue-800""><i class=""icon-search4""></i></span>
                    </div>
                </div>
            </div>

            <table class=""table table-xxs table-md datatable-basic table-bordered table-striped table-hover bg-lightgray dataTables_scrollBody"">

                <thead>
                    <tr class=""bg-blue-800"">
                        <th>Fee VoucherId</th>

                        <th>Voucher Date</th>

                        <th>Month Name</th>
                        <th>Level Name</th>
                        <th>Total  Amount</th>
                        <th>RefId</th>





");
            EndContext();
            BeginContext(3105, 122, true);
            WriteLiteral("                        <th>Actions</th>\r\n\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
            EndContext();
#line 93 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\FeeVoucher\Index.cshtml"
                     foreach (SMSERP.Areas.Transaction.Models.FeeVoucher s in Model)
                    {

#line default
#line hidden
            BeginContext(3336, 40, true);
            WriteLiteral("                        <tr data-rowid=\"");
            EndContext();
            BeginContext(3377, 7, false);
#line 95 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\FeeVoucher\Index.cshtml"
                                   Write(s.FeeId);

#line default
#line hidden
            EndContext();
            BeginContext(3384, 36, true);
            WriteLiteral("\">\r\n                            <td>");
            EndContext();
            BeginContext(3421, 9, false);
#line 96 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\FeeVoucher\Index.cshtml"
                           Write(s.FeeCode);

#line default
#line hidden
            EndContext();
            BeginContext(3430, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3470, 9, false);
#line 97 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\FeeVoucher\Index.cshtml"
                           Write(s.VouDate);

#line default
#line hidden
            EndContext();
            BeginContext(3479, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3519, 11, false);
#line 98 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\FeeVoucher\Index.cshtml"
                           Write(s.MonthName);

#line default
#line hidden
            EndContext();
            BeginContext(3530, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3570, 11, false);
#line 99 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\FeeVoucher\Index.cshtml"
                           Write(s.LevelName);

#line default
#line hidden
            EndContext();
            BeginContext(3581, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3621, 9, false);
#line 100 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\FeeVoucher\Index.cshtml"
                           Write(s.TAmount);

#line default
#line hidden
            EndContext();
            BeginContext(3630, 68, true);
            WriteLiteral("</td>\r\n                           \r\n                            <td>");
            EndContext();
            BeginContext(3699, 7, false);
#line 102 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\FeeVoucher\Index.cshtml"
                           Write(s.RefId);

#line default
#line hidden
            EndContext();
            BeginContext(3706, 129, true);
            WriteLiteral("</td>\r\n                           \r\n                            <td>\r\n                                <ul class=\"icons-list\">\r\n\r\n");
            EndContext();
#line 107 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\FeeVoucher\Index.cshtml"
                                     if (editview)
                                    {

#line default
#line hidden
            BeginContext(3926, 282, true);
            WriteLiteral(@"                                        <li class=""text-primary-600""><a data-modalhorizontal=""true"" data-modalsize=""modal-full"" data-heading=""Edit Monthly Fee Voucher"" data-script=""/assets/Areas/Transaction/FeeVoucher/FeeVoucher.js"" data-url=""/Transaction/FeeVoucher/AFeeVoucher?Id=");
            EndContext();
            BeginContext(4209, 7, false);
#line 109 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\FeeVoucher\Index.cshtml"
                                                                                                                                                                                                                                                                                     Write(s.FeeId);

#line default
#line hidden
            EndContext();
            BeginContext(4216, 41, true);
            WriteLiteral("\"><i class=\"icon-pencil7\"></i></a></li>\r\n");
            EndContext();
#line 110 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\FeeVoucher\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(4296, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 113 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\FeeVoucher\Index.cshtml"
                                     if (delete)
                                    {

#line default
#line hidden
            BeginContext(4389, 70, true);
            WriteLiteral("                                        <li class=\"text-danger-600\"><a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4459, "\"", 4565, 8);
            WriteAttributeValue("", 4469, "DeleteAlert({", 4469, 13, true);
            WriteAttributeValue(" ", 4482, "\'Id\':", 4483, 6, true);
#line 115 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\FeeVoucher\Index.cshtml"
WriteAttributeValue("", 4488, s.FeeId, 4488, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 4496, "},", 4496, 2, true);
            WriteAttributeValue(" ", 4498, "\'/Transaction/FeeVoucher/DeleteFeeVoucher\',", 4499, 44, true);
            WriteAttributeValue(" ", 4542, "\'Monthly", 4543, 9, true);
            WriteAttributeValue(" ", 4551, "Fee", 4552, 4, true);
            WriteAttributeValue(" ", 4555, "Voucher\')", 4556, 10, true);
            EndWriteAttribute();
            BeginContext(4566, 38, true);
            WriteLiteral("><i class=\"icon-trash\"></i></a></li>\r\n");
            EndContext();
#line 116 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\FeeVoucher\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(4643, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 119 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\FeeVoucher\Index.cshtml"
                                     if (Print)
                                    {

#line default
#line hidden
            BeginContext(4735, 108, true);
            WriteLiteral("                                        <li class=\"text-primary-600\"><a data-toggle=\"tooltip\" title=\"Report\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4843, "\"", 5046, 14);
            WriteAttributeValue("", 4850, "/Report/Reportrdlc/AReport?rvalues.Name=19&rvalues.Value[0]=", 4850, 60, true);
#line 121 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\FeeVoucher\Index.cshtml"
WriteAttributeValue("", 4910, s.FeeId, 4910, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 4918, "&rvalues.Value[1]=", 4918, 18, true);
#line 121 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\FeeVoucher\Index.cshtml"
WriteAttributeValue("", 4936, s.VouDate, 4936, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 4946, "&rvalues.Value[2]=", 4946, 18, true);
#line 121 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\FeeVoucher\Index.cshtml"
WriteAttributeValue("", 4964, a, 4964, 2, false);

#line default
#line hidden
            WriteAttributeValue("", 4966, "&rvalues.Value[3]=", 4966, 18, true);
#line 121 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\FeeVoucher\Index.cshtml"
WriteAttributeValue("", 4984, a, 4984, 2, false);

#line default
#line hidden
            WriteAttributeValue("", 4986, "&rvalues.Value[4]=", 4986, 18, true);
#line 121 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\FeeVoucher\Index.cshtml"
WriteAttributeValue("", 5004, a, 5004, 2, false);

#line default
#line hidden
            WriteAttributeValue("", 5006, "&rvalues.Value[5]=", 5006, 18, true);
#line 121 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\FeeVoucher\Index.cshtml"
WriteAttributeValue("", 5024, a, 5024, 2, false);

#line default
#line hidden
            WriteAttributeValue("", 5026, "&rvalues.Value[6]=", 5026, 18, true);
#line 121 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\FeeVoucher\Index.cshtml"
WriteAttributeValue("", 5044, a, 5044, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5047, 80, true);
            WriteLiteral(" data-heading=\"CPD Form\" target=\"_blank\"><i class=\"icon-printer\"></i></a></li>\r\n");
            EndContext();
#line 122 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\FeeVoucher\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(5166, 117, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n                                </ul>\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 132 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\FeeVoucher\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(5306, 84, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SMSERP.Areas.Transaction.Models.FeeVoucher>> Html { get; private set; }
    }
}
#pragma warning restore 1591