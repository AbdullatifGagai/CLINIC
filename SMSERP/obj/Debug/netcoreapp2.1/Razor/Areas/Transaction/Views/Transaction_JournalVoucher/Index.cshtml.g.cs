#pragma checksum "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\Transaction_JournalVoucher\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f80076b8e26d9d760be0155524b0bcef90c8917c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Transaction_Views_Transaction_JournalVoucher_Index), @"mvc.1.0.view", @"/Areas/Transaction/Views/Transaction_JournalVoucher/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Transaction/Views/Transaction_JournalVoucher/Index.cshtml", typeof(AspNetCore.Areas_Transaction_Views_Transaction_JournalVoucher_Index))]
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
#line 1 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\Transaction_JournalVoucher\Index.cshtml"
using ZCLINIC;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f80076b8e26d9d760be0155524b0bcef90c8917c", @"/Areas/Transaction/Views/Transaction_JournalVoucher/Index.cshtml")]
    public class Areas_Transaction_Views_Transaction_JournalVoucher_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ZCLINIC.Areas.Transaction.Models.Transaction_VoucherMaster>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(17, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(99, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\Transaction_JournalVoucher\Index.cshtml"
  
    bool addview = ZCLINIC.UserRights.URM_AddNew_IsAuthenticated(Context.Session.GetRoleId(), "9");
    bool editview = ZCLINIC.UserRights.URM_Update_IsAuthenticated(Context.Session.GetRoleId(), "9");
    bool delete = ZCLINIC.UserRights.URM_Delete_IsAuthenticated(Context.Session.GetRoleId(), "9");
    bool Print = ZCLINIC.UserRights.URM_Print_IsAuthenticated(Context.Session.GetRoleId(), "9");


#line default
#line hidden
            BeginContext(511, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
#line 15 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\Transaction_JournalVoucher\Index.cshtml"
  
    string a = string.Empty;

#line default
#line hidden
            BeginContext(554, 363, true);
            WriteLiteral(@"










<div class=""page-header page-header-default"">
    <div class=""breadcrumb-line"">
        <h6 class=""text-semibold"">Journal  Voucher</h6>
    </div>
</div>


<div class=""content"">
    <div class=""panel panel-flat"">
        <div class=""panel-body"">
            <div class=""row"">
                <div class=""col-md-3 buttons-top"">

");
            EndContext();
#line 42 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\Transaction_JournalVoucher\Index.cshtml"
                     if (addview)
                    {

#line default
#line hidden
            BeginContext(975, 328, true);
            WriteLiteral(@"                        <a class=""btn btn-success btn-sm"" data-modalhorizontal=""true"" data-modalsize=""modal-lg"" data-url=""/Transaction/Transaction_JournalVoucher/ATransaction_JournalVoucher"" data-heading=""Journal Voucher"" data-script=""/assets/Areas/Transaction/BankPayment/BankPayment.js""><i class=""icon-add mr-5""></i> Add</a>
");
            EndContext();
#line 45 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\Transaction_JournalVoucher\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1326, 120, true);
            WriteLiteral("\r\n\r\n\r\n\r\n                </div>\r\n\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n");
            EndContext();
            BeginContext(1801, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2201, 807, true);
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
                        <th>Ref ID</th>
                        <th>Voucher Code</th>
                        <th>Voucher Date</th>
                        <th>Amount</th>



");
            EndContext();
            BeginContext(3055, 122, true);
            WriteLiteral("                        <th>Actions</th>\r\n\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
            EndContext();
#line 94 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\Transaction_JournalVoucher\Index.cshtml"
                     foreach (ZCLINIC.Areas.Transaction.Models.Transaction_VoucherMaster s in Model)
                    {

#line default
#line hidden
            BeginContext(3302, 40, true);
            WriteLiteral("                        <tr data-rowid=\"");
            EndContext();
            BeginContext(3343, 8, false);
#line 96 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\Transaction_JournalVoucher\Index.cshtml"
                                   Write(s.REF_ID);

#line default
#line hidden
            EndContext();
            BeginContext(3351, 36, true);
            WriteLiteral("\">\r\n                            <td>");
            EndContext();
            BeginContext(3388, 8, false);
#line 97 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\Transaction_JournalVoucher\Index.cshtml"
                           Write(s.REF_ID);

#line default
#line hidden
            EndContext();
            BeginContext(3396, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3436, 12, false);
#line 98 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\Transaction_JournalVoucher\Index.cshtml"
                           Write(s.VOUCHER_NO);

#line default
#line hidden
            EndContext();
            BeginContext(3448, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3488, 14, false);
#line 99 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\Transaction_JournalVoucher\Index.cshtml"
                           Write(s.VOUCHAR_DATE);

#line default
#line hidden
            EndContext();
            BeginContext(3502, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3542, 12, false);
#line 100 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\Transaction_JournalVoucher\Index.cshtml"
                           Write(s.TCreditAmt);

#line default
#line hidden
            EndContext();
            BeginContext(3554, 102, true);
            WriteLiteral("</td>\r\n\r\n                            <td>\r\n                                <ul class=\"icons-list\">\r\n\r\n");
            EndContext();
#line 105 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\Transaction_JournalVoucher\Index.cshtml"
                                     if (editview)
                                    {

#line default
#line hidden
            BeginContext(3747, 310, true);
            WriteLiteral(@"                                        <li class=""text-primary-600""><a data-modalhorizontal=""true"" data-modalsize=""modal-lg"" data-heading=""Edit Journal Voucher"" data-script=""/assets/Areas/Transaction/BankPayment/BankPayment.js"" data-url=""/Transaction/Transaction_JournalVoucher/ATransaction_JournalVoucher?Id=");
            EndContext();
            BeginContext(4058, 8, false);
#line 107 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\Transaction_JournalVoucher\Index.cshtml"
                                                                                                                                                                                                                                                                                                                 Write(s.REF_ID);

#line default
#line hidden
            EndContext();
            BeginContext(4066, 41, true);
            WriteLiteral("\"><i class=\"icon-pencil7\"></i></a></li>\r\n");
            EndContext();
#line 108 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\Transaction_JournalVoucher\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(4146, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
#line 112 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\Transaction_JournalVoucher\Index.cshtml"
                                     if (delete)
                                    {

#line default
#line hidden
            BeginContext(4241, 70, true);
            WriteLiteral("                                        <li class=\"text-danger-600\"><a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4311, "\"", 4446, 7);
            WriteAttributeValue("", 4321, "DeleteAlert({", 4321, 13, true);
            WriteAttributeValue(" ", 4334, "\'Id\':", 4335, 6, true);
#line 114 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\Transaction_JournalVoucher\Index.cshtml"
WriteAttributeValue("", 4340, s.REF_ID, 4340, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 4349, "},", 4349, 2, true);
            WriteAttributeValue(" ", 4351, "\'/Transaction/Transaction_JournalVoucher/DeleteTransaction_JournalVoucher\',", 4352, 76, true);
            WriteAttributeValue(" ", 4427, "\'Journal", 4428, 9, true);
            WriteAttributeValue(" ", 4436, "Voucher\')", 4437, 10, true);
            EndWriteAttribute();
            BeginContext(4447, 38, true);
            WriteLiteral("><i class=\"icon-trash\"></i></a></li>\r\n");
            EndContext();
#line 115 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\Transaction_JournalVoucher\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(4524, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 118 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\Transaction_JournalVoucher\Index.cshtml"
                                     if (Print)
                                    {


#line default
#line hidden
            BeginContext(4618, 108, true);
            WriteLiteral("                                        <li class=\"text-primary-600\"><a data-toggle=\"tooltip\" title=\"Report\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4726, "\"", 4921, 14);
            WriteAttributeValue("", 4733, "/Report/Reportrdlc/AReport?rvalues.Name=6&rvalues.Value[0]=", 4733, 59, true);
#line 121 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\Transaction_JournalVoucher\Index.cshtml"
WriteAttributeValue("", 4792, s.REF_ID, 4792, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 4801, "&rvalues.Value[1]=", 4801, 18, true);
#line 121 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\Transaction_JournalVoucher\Index.cshtml"
WriteAttributeValue("", 4819, a, 4819, 2, false);

#line default
#line hidden
            WriteAttributeValue("", 4821, "&rvalues.Value[2]=", 4821, 18, true);
#line 121 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\Transaction_JournalVoucher\Index.cshtml"
WriteAttributeValue("", 4839, a, 4839, 2, false);

#line default
#line hidden
            WriteAttributeValue("", 4841, "&rvalues.Value[3]=", 4841, 18, true);
#line 121 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\Transaction_JournalVoucher\Index.cshtml"
WriteAttributeValue("", 4859, a, 4859, 2, false);

#line default
#line hidden
            WriteAttributeValue("", 4861, "&rvalues.Value[4]=", 4861, 18, true);
#line 121 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\Transaction_JournalVoucher\Index.cshtml"
WriteAttributeValue("", 4879, a, 4879, 2, false);

#line default
#line hidden
            WriteAttributeValue("", 4881, "&rvalues.Value[5]=", 4881, 18, true);
#line 121 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\Transaction_JournalVoucher\Index.cshtml"
WriteAttributeValue("", 4899, a, 4899, 2, false);

#line default
#line hidden
            WriteAttributeValue("", 4901, "&rvalues.Value[6]=", 4901, 18, true);
#line 121 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\Transaction_JournalVoucher\Index.cshtml"
WriteAttributeValue("", 4919, a, 4919, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4922, 80, true);
            WriteLiteral(" data-heading=\"CPD Form\" target=\"_blank\"><i class=\"icon-printer\"></i></a></li>\r\n");
            EndContext();
#line 122 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\Transaction_JournalVoucher\Index.cshtml"


                                    }

#line default
#line hidden
            BeginContext(5045, 111, true);
            WriteLiteral("\r\n\r\n\r\n                                </ul>\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 131 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\Transaction_JournalVoucher\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(5179, 84, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ZCLINIC.Areas.Transaction.Models.Transaction_VoucherMaster>> Html { get; private set; }
    }
}
#pragma warning restore 1591