#pragma checksum "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\FeeVoucher\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9bc82dc14f0c483eea57dc973fa40b0a859c8744"
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
#line 1 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\FeeVoucher\Index.cshtml"
using ZCLINIC;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bc82dc14f0c483eea57dc973fa40b0a859c8744", @"/Areas/Transaction/Views/FeeVoucher/Index.cshtml")]
    public class Areas_Transaction_Views_FeeVoucher_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ZCLINIC.Areas.Transaction.Models.FeeVoucher>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(17, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
            BeginContext(88, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\FeeVoucher\Index.cshtml"
  
    bool addview = ZCLINIC.UserRights.URM_AddNew_IsAuthenticated(Context.Session.GetRoleId(), "66");
    bool editview = ZCLINIC.UserRights.URM_Update_IsAuthenticated(Context.Session.GetRoleId(), "66");
    bool delete = ZCLINIC.UserRights.URM_Delete_IsAuthenticated(Context.Session.GetRoleId(), "66");
    bool Print = ZCLINIC.UserRights.URM_Print_IsAuthenticated(Context.Session.GetRoleId(), "66");


#line default
#line hidden
            BeginContext(504, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 16 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\FeeVoucher\Index.cshtml"
  
    string a = string.Empty;

#line default
#line hidden
            BeginContext(545, 350, true);
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
#line 35 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\FeeVoucher\Index.cshtml"
                     if (addview)
                    {

#line default
#line hidden
            BeginContext(953, 301, true);
            WriteLiteral(@"                        <a class=""btn btn-success btn-sm"" data-modalhorizontal=""true"" data-modalsize=""modal-full"" data-url=""/Transaction/FeeVoucher/AFeeVoucher"" data-heading=""Monthly  Fee Voucher"" data-script=""/assets/Areas/Transaction/FeeVoucher/FeeVoucher.js""><i class=""icon-add mr-5""></i> Add</a>
");
            EndContext();
#line 38 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\FeeVoucher\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1277, 120, true);
            WriteLiteral("\r\n\r\n\r\n\r\n                </div>\r\n\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n");
            EndContext();
            BeginContext(1752, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2152, 912, true);
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
            BeginContext(3111, 122, true);
            WriteLiteral("                        <th>Actions</th>\r\n\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
            EndContext();
#line 93 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\FeeVoucher\Index.cshtml"
                     foreach (ZCLINIC.Areas.Transaction.Models.FeeVoucher s in Model)
                    {

#line default
#line hidden
            BeginContext(3343, 40, true);
            WriteLiteral("                        <tr data-rowid=\"");
            EndContext();
            BeginContext(3384, 7, false);
#line 95 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\FeeVoucher\Index.cshtml"
                                   Write(s.FeeId);

#line default
#line hidden
            EndContext();
            BeginContext(3391, 36, true);
            WriteLiteral("\">\r\n                            <td>");
            EndContext();
            BeginContext(3428, 9, false);
#line 96 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\FeeVoucher\Index.cshtml"
                           Write(s.FeeCode);

#line default
#line hidden
            EndContext();
            BeginContext(3437, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3477, 9, false);
#line 97 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\FeeVoucher\Index.cshtml"
                           Write(s.VouDate);

#line default
#line hidden
            EndContext();
            BeginContext(3486, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3526, 11, false);
#line 98 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\FeeVoucher\Index.cshtml"
                           Write(s.MonthName);

#line default
#line hidden
            EndContext();
            BeginContext(3537, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3577, 11, false);
#line 99 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\FeeVoucher\Index.cshtml"
                           Write(s.LevelName);

#line default
#line hidden
            EndContext();
            BeginContext(3588, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3628, 9, false);
#line 100 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\FeeVoucher\Index.cshtml"
                           Write(s.TAmount);

#line default
#line hidden
            EndContext();
            BeginContext(3637, 68, true);
            WriteLiteral("</td>\r\n                           \r\n                            <td>");
            EndContext();
            BeginContext(3706, 7, false);
#line 102 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\FeeVoucher\Index.cshtml"
                           Write(s.RefId);

#line default
#line hidden
            EndContext();
            BeginContext(3713, 129, true);
            WriteLiteral("</td>\r\n                           \r\n                            <td>\r\n                                <ul class=\"icons-list\">\r\n\r\n");
            EndContext();
#line 107 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\FeeVoucher\Index.cshtml"
                                     if (editview)
                                    {

#line default
#line hidden
            BeginContext(3933, 282, true);
            WriteLiteral(@"                                        <li class=""text-primary-600""><a data-modalhorizontal=""true"" data-modalsize=""modal-full"" data-heading=""Edit Monthly Fee Voucher"" data-script=""/assets/Areas/Transaction/FeeVoucher/FeeVoucher.js"" data-url=""/Transaction/FeeVoucher/AFeeVoucher?Id=");
            EndContext();
            BeginContext(4216, 7, false);
#line 109 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\FeeVoucher\Index.cshtml"
                                                                                                                                                                                                                                                                                     Write(s.FeeId);

#line default
#line hidden
            EndContext();
            BeginContext(4223, 41, true);
            WriteLiteral("\"><i class=\"icon-pencil7\"></i></a></li>\r\n");
            EndContext();
#line 110 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\FeeVoucher\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(4303, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 113 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\FeeVoucher\Index.cshtml"
                                     if (delete)
                                    {

#line default
#line hidden
            BeginContext(4396, 70, true);
            WriteLiteral("                                        <li class=\"text-danger-600\"><a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4466, "\"", 4572, 8);
            WriteAttributeValue("", 4476, "DeleteAlert({", 4476, 13, true);
            WriteAttributeValue(" ", 4489, "\'Id\':", 4490, 6, true);
#line 115 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\FeeVoucher\Index.cshtml"
WriteAttributeValue("", 4495, s.FeeId, 4495, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 4503, "},", 4503, 2, true);
            WriteAttributeValue(" ", 4505, "\'/Transaction/FeeVoucher/DeleteFeeVoucher\',", 4506, 44, true);
            WriteAttributeValue(" ", 4549, "\'Monthly", 4550, 9, true);
            WriteAttributeValue(" ", 4558, "Fee", 4559, 4, true);
            WriteAttributeValue(" ", 4562, "Voucher\')", 4563, 10, true);
            EndWriteAttribute();
            BeginContext(4573, 38, true);
            WriteLiteral("><i class=\"icon-trash\"></i></a></li>\r\n");
            EndContext();
#line 116 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\FeeVoucher\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(4650, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 119 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\FeeVoucher\Index.cshtml"
                                     if (Print)
                                    {

#line default
#line hidden
            BeginContext(4742, 108, true);
            WriteLiteral("                                        <li class=\"text-primary-600\"><a data-toggle=\"tooltip\" title=\"Report\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4850, "\"", 5053, 14);
            WriteAttributeValue("", 4857, "/Report/Reportrdlc/AReport?rvalues.Name=19&rvalues.Value[0]=", 4857, 60, true);
#line 121 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\FeeVoucher\Index.cshtml"
WriteAttributeValue("", 4917, s.FeeId, 4917, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 4925, "&rvalues.Value[1]=", 4925, 18, true);
#line 121 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\FeeVoucher\Index.cshtml"
WriteAttributeValue("", 4943, s.VouDate, 4943, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 4953, "&rvalues.Value[2]=", 4953, 18, true);
#line 121 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\FeeVoucher\Index.cshtml"
WriteAttributeValue("", 4971, a, 4971, 2, false);

#line default
#line hidden
            WriteAttributeValue("", 4973, "&rvalues.Value[3]=", 4973, 18, true);
#line 121 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\FeeVoucher\Index.cshtml"
WriteAttributeValue("", 4991, a, 4991, 2, false);

#line default
#line hidden
            WriteAttributeValue("", 4993, "&rvalues.Value[4]=", 4993, 18, true);
#line 121 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\FeeVoucher\Index.cshtml"
WriteAttributeValue("", 5011, a, 5011, 2, false);

#line default
#line hidden
            WriteAttributeValue("", 5013, "&rvalues.Value[5]=", 5013, 18, true);
#line 121 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\FeeVoucher\Index.cshtml"
WriteAttributeValue("", 5031, a, 5031, 2, false);

#line default
#line hidden
            WriteAttributeValue("", 5033, "&rvalues.Value[6]=", 5033, 18, true);
#line 121 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\FeeVoucher\Index.cshtml"
WriteAttributeValue("", 5051, a, 5051, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5054, 80, true);
            WriteLiteral(" data-heading=\"CPD Form\" target=\"_blank\"><i class=\"icon-printer\"></i></a></li>\r\n");
            EndContext();
#line 122 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\FeeVoucher\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(5173, 117, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n                                </ul>\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 132 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\FeeVoucher\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(5313, 84, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ZCLINIC.Areas.Transaction.Models.FeeVoucher>> Html { get; private set; }
    }
}
#pragma warning restore 1591
