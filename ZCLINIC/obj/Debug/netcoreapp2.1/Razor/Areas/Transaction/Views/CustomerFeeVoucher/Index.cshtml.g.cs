#pragma checksum "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\CustomerFeeVoucher\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dcf6318a8c58fdea012173bc23b0633c568f9b45"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Transaction_Views_CustomerFeeVoucher_Index), @"mvc.1.0.view", @"/Areas/Transaction/Views/CustomerFeeVoucher/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Transaction/Views/CustomerFeeVoucher/Index.cshtml", typeof(AspNetCore.Areas_Transaction_Views_CustomerFeeVoucher_Index))]
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
#line 1 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\CustomerFeeVoucher\Index.cshtml"
using ZCLINIC;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcf6318a8c58fdea012173bc23b0633c568f9b45", @"/Areas/Transaction/Views/CustomerFeeVoucher/Index.cshtml")]
    public class Areas_Transaction_Views_CustomerFeeVoucher_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ZCLINIC.Areas.Transaction.Models.FeeVoucher>>
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
#line 7 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\CustomerFeeVoucher\Index.cshtml"
  
    bool addview = ZCLINIC.UserRights.URM_AddNew_IsAuthenticated(Context.Session.GetRoleId(), "67");
    bool editview = ZCLINIC.UserRights.URM_Update_IsAuthenticated(Context.Session.GetRoleId(), "67");
    bool delete = ZCLINIC.UserRights.URM_Delete_IsAuthenticated(Context.Session.GetRoleId(), "67");
    bool Print = ZCLINIC.UserRights.URM_Print_IsAuthenticated(Context.Session.GetRoleId(), "67");


#line default
#line hidden
            BeginContext(504, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 16 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\CustomerFeeVoucher\Index.cshtml"
  
    string a = string.Empty;

#line default
#line hidden
            BeginContext(545, 354, true);
            WriteLiteral(@"


<div class=""page-header page-header-default"">
    <div class=""breadcrumb-line"">
        <h6 class=""text-semibold"">Customized  Fee Voucher</h6>
    </div>
</div>


<div class=""content"">
    <div class=""panel panel-flat"">
        <div class=""panel-body"">
            <div class=""row"">
                <div class=""col-md-3 buttons-top"">

");
            EndContext();
#line 35 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\CustomerFeeVoucher\Index.cshtml"
                     if (addview)
                    {

#line default
#line hidden
            BeginContext(957, 318, true);
            WriteLiteral(@"                        <a class=""btn btn-success btn-sm"" data-modalhorizontal=""true"" data-modalsize=""modal-lg"" data-url=""/Transaction/CustomerFeeVoucher/ACustomerFeeVoucher"" data-heading=""Customized  Fee Voucher"" data-script=""/assets/Areas/Transaction/FeeVoucher/CusVoucher.js""><i class=""icon-add mr-5""></i> Add</a>
");
            EndContext();
#line 38 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\CustomerFeeVoucher\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1298, 120, true);
            WriteLiteral("\r\n\r\n\r\n\r\n                </div>\r\n\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n");
            EndContext();
            BeginContext(1773, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2173, 912, true);
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
            BeginContext(3132, 122, true);
            WriteLiteral("                        <th>Actions</th>\r\n\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
            EndContext();
#line 93 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\CustomerFeeVoucher\Index.cshtml"
                     foreach (ZCLINIC.Areas.Transaction.Models.FeeVoucher s in Model)
                    {

#line default
#line hidden
            BeginContext(3364, 40, true);
            WriteLiteral("                        <tr data-rowid=\"");
            EndContext();
            BeginContext(3405, 7, false);
#line 95 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\CustomerFeeVoucher\Index.cshtml"
                                   Write(s.FeeId);

#line default
#line hidden
            EndContext();
            BeginContext(3412, 36, true);
            WriteLiteral("\">\r\n                            <td>");
            EndContext();
            BeginContext(3449, 9, false);
#line 96 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\CustomerFeeVoucher\Index.cshtml"
                           Write(s.FeeCode);

#line default
#line hidden
            EndContext();
            BeginContext(3458, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3498, 9, false);
#line 97 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\CustomerFeeVoucher\Index.cshtml"
                           Write(s.VouDate);

#line default
#line hidden
            EndContext();
            BeginContext(3507, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3547, 11, false);
#line 98 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\CustomerFeeVoucher\Index.cshtml"
                           Write(s.MonthName);

#line default
#line hidden
            EndContext();
            BeginContext(3558, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3598, 11, false);
#line 99 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\CustomerFeeVoucher\Index.cshtml"
                           Write(s.LevelName);

#line default
#line hidden
            EndContext();
            BeginContext(3609, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3649, 9, false);
#line 100 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\CustomerFeeVoucher\Index.cshtml"
                           Write(s.TAmount);

#line default
#line hidden
            EndContext();
            BeginContext(3658, 41, true);
            WriteLiteral("</td>\r\n\r\n                            <td>");
            EndContext();
            BeginContext(3700, 7, false);
#line 102 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\CustomerFeeVoucher\Index.cshtml"
                           Write(s.RefId);

#line default
#line hidden
            EndContext();
            BeginContext(3707, 102, true);
            WriteLiteral("</td>\r\n\r\n                            <td>\r\n                                <ul class=\"icons-list\">\r\n\r\n");
            EndContext();
#line 107 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\CustomerFeeVoucher\Index.cshtml"
                                     if (editview)
                                    {

#line default
#line hidden
            BeginContext(3900, 300, true);
            WriteLiteral(@"                                        <li class=""text-primary-600""><a data-modalhorizontal=""true"" data-modalsize=""modal-lg"" data-heading=""Edit Customized  Fee Voucher"" data-script=""/assets/Areas/Transaction/FeeVoucher/CusVoucher.js"" data-url=""/Transaction/CustomerFeeVoucher/ACustomerFeeVoucher?Id=");
            EndContext();
            BeginContext(4201, 7, false);
#line 109 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\CustomerFeeVoucher\Index.cshtml"
                                                                                                                                                                                                                                                                                                       Write(s.FeeId);

#line default
#line hidden
            EndContext();
            BeginContext(4208, 41, true);
            WriteLiteral("\"><i class=\"icon-pencil7\"></i></a></li>\r\n");
            EndContext();
#line 110 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\CustomerFeeVoucher\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(4288, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 113 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\CustomerFeeVoucher\Index.cshtml"
                                     if (delete)
                                    {

#line default
#line hidden
            BeginContext(4381, 70, true);
            WriteLiteral("                                        <li class=\"text-danger-600\"><a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4451, "\"", 4561, 8);
            WriteAttributeValue("", 4461, "DeleteAlert({", 4461, 13, true);
            WriteAttributeValue(" ", 4474, "\'Id\':", 4475, 6, true);
#line 115 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\CustomerFeeVoucher\Index.cshtml"
WriteAttributeValue("", 4480, s.FeeId, 4480, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 4488, "},", 4488, 2, true);
            WriteAttributeValue(" ", 4490, "\'/Transaction/FeeVoucher/DeleteFeeVoucher\',", 4491, 44, true);
            WriteAttributeValue(" ", 4534, "\'Customized", 4535, 12, true);
            WriteAttributeValue("  ", 4546, "Fee", 4548, 5, true);
            WriteAttributeValue(" ", 4551, "Voucher\')", 4552, 10, true);
            EndWriteAttribute();
            BeginContext(4562, 38, true);
            WriteLiteral("><i class=\"icon-trash\"></i></a></li>\r\n");
            EndContext();
#line 116 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\CustomerFeeVoucher\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(4639, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 119 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\CustomerFeeVoucher\Index.cshtml"
                                     if (Print)
                                    {

#line default
#line hidden
            BeginContext(4731, 108, true);
            WriteLiteral("                                        <li class=\"text-primary-600\"><a data-toggle=\"tooltip\" title=\"Report\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4839, "\"", 5034, 14);
            WriteAttributeValue("", 4846, "/Report/Reportrdlc/AReport?rvalues.Name=20&rvalues.Value[0]=", 4846, 60, true);
#line 121 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\CustomerFeeVoucher\Index.cshtml"
WriteAttributeValue("", 4906, s.FeeId, 4906, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 4914, "&rvalues.Value[1]=", 4914, 18, true);
#line 121 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\CustomerFeeVoucher\Index.cshtml"
WriteAttributeValue("", 4932, a, 4932, 2, false);

#line default
#line hidden
            WriteAttributeValue("", 4934, "&rvalues.Value[2]=", 4934, 18, true);
#line 121 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\CustomerFeeVoucher\Index.cshtml"
WriteAttributeValue("", 4952, a, 4952, 2, false);

#line default
#line hidden
            WriteAttributeValue("", 4954, "&rvalues.Value[3]=", 4954, 18, true);
#line 121 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\CustomerFeeVoucher\Index.cshtml"
WriteAttributeValue("", 4972, a, 4972, 2, false);

#line default
#line hidden
            WriteAttributeValue("", 4974, "&rvalues.Value[4]=", 4974, 18, true);
#line 121 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\CustomerFeeVoucher\Index.cshtml"
WriteAttributeValue("", 4992, a, 4992, 2, false);

#line default
#line hidden
            WriteAttributeValue("", 4994, "&rvalues.Value[5]=", 4994, 18, true);
#line 121 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\CustomerFeeVoucher\Index.cshtml"
WriteAttributeValue("", 5012, a, 5012, 2, false);

#line default
#line hidden
            WriteAttributeValue("", 5014, "&rvalues.Value[6]=", 5014, 18, true);
#line 121 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\CustomerFeeVoucher\Index.cshtml"
WriteAttributeValue("", 5032, a, 5032, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5035, 80, true);
            WriteLiteral(" data-heading=\"CPD Form\" target=\"_blank\"><i class=\"icon-printer\"></i></a></li>\r\n");
            EndContext();
#line 122 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\CustomerFeeVoucher\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(5154, 117, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n                                </ul>\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 132 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\CustomerFeeVoucher\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(5294, 84, true);
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
