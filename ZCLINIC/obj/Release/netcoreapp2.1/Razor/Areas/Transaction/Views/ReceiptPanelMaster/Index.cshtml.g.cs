#pragma checksum "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\ReceiptPanelMaster\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0c284da67411852ed81692e964e752002100314"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Transaction_Views_ReceiptPanelMaster_Index), @"mvc.1.0.view", @"/Areas/Transaction/Views/ReceiptPanelMaster/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Transaction/Views/ReceiptPanelMaster/Index.cshtml", typeof(AspNetCore.Areas_Transaction_Views_ReceiptPanelMaster_Index))]
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
#line 1 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\ReceiptPanelMaster\Index.cshtml"
using SMSERP;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0c284da67411852ed81692e964e752002100314", @"/Areas/Transaction/Views/ReceiptPanelMaster/Index.cshtml")]
    public class Areas_Transaction_Views_ReceiptPanelMaster_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SMSERP.Areas.Transaction.Models.ReceiptPanelMaster>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(16, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
            BeginContext(94, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\ReceiptPanelMaster\Index.cshtml"
  
    bool addview = SMSERP.UserRights.URM_AddNew_IsAuthenticated(Context.Session.GetRoleId(), "89");
    bool editview = SMSERP.UserRights.URM_Update_IsAuthenticated(Context.Session.GetRoleId(), "89");
    bool delete = SMSERP.UserRights.URM_Delete_IsAuthenticated(Context.Session.GetRoleId(), "89");
    bool Print = SMSERP.UserRights.URM_Print_IsAuthenticated(Context.Session.GetRoleId(), "89");


#line default
#line hidden
            BeginContext(506, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 16 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\ReceiptPanelMaster\Index.cshtml"
  
    string a = string.Empty;

#line default
#line hidden
            BeginContext(547, 344, true);
            WriteLiteral(@"


<div class=""page-header page-header-default"">
    <div class=""breadcrumb-line"">
        <h6 class=""text-semibold"">Panel Receipt</h6>
    </div>
</div>


<div class=""content"">
    <div class=""panel panel-flat"">
        <div class=""panel-body"">
            <div class=""row"">
                <div class=""col-md-3 buttons-top"">

");
            EndContext();
#line 35 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\ReceiptPanelMaster\Index.cshtml"
                     if (addview)
                    {

#line default
#line hidden
            BeginContext(949, 324, true);
            WriteLiteral(@"                        <a class=""btn btn-success btn-sm"" data-modalhorizontal=""true"" data-modalsize=""modal-lg"" data-url=""/Transaction/ReceiptPanelMaster/AReceiptPanelMaster"" data-heading=""Panel Receipt"" data-script=""/assets/Areas/Transaction/ReceiptPanelMaster/ReceiptPanelMaster.js""><i class=""icon-add mr-5""></i> Add</a>
");
            EndContext();
#line 38 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\ReceiptPanelMaster\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1296, 120, true);
            WriteLiteral("\r\n\r\n\r\n\r\n                </div>\r\n\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n");
            EndContext();
            BeginContext(1771, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2171, 913, true);
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

                        <th>Panel  Name</th>
                        <th>Month Name</th>
                        <th>Total  Amount</th>
                        <th>RefNo</th>





");
            EndContext();
            BeginContext(3131, 122, true);
            WriteLiteral("                        <th>Actions</th>\r\n\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
            EndContext();
#line 93 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\ReceiptPanelMaster\Index.cshtml"
                     foreach (SMSERP.Areas.Transaction.Models.ReceiptPanelMaster s in Model)
                    {

#line default
#line hidden
            BeginContext(3370, 40, true);
            WriteLiteral("                        <tr data-rowid=\"");
            EndContext();
            BeginContext(3411, 11, false);
#line 95 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\ReceiptPanelMaster\Index.cshtml"
                                   Write(s.ReceiptId);

#line default
#line hidden
            EndContext();
            BeginContext(3422, 36, true);
            WriteLiteral("\">\r\n                            <td>");
            EndContext();
            BeginContext(3459, 13, false);
#line 96 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\ReceiptPanelMaster\Index.cshtml"
                           Write(s.ReceiptCode);

#line default
#line hidden
            EndContext();
            BeginContext(3472, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3512, 7, false);
#line 97 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\ReceiptPanelMaster\Index.cshtml"
                           Write(s.RDate);

#line default
#line hidden
            EndContext();
            BeginContext(3519, 40, true);
            WriteLiteral(" </td>\r\n                            <td>");
            EndContext();
            BeginContext(3560, 7, false);
#line 98 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\ReceiptPanelMaster\Index.cshtml"
                           Write(s.PName);

#line default
#line hidden
            EndContext();
            BeginContext(3567, 40, true);
            WriteLiteral(" </td>\r\n                            <td>");
            EndContext();
            BeginContext(3608, 10, false);
#line 99 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\ReceiptPanelMaster\Index.cshtml"
                           Write(s.FeesTerm);

#line default
#line hidden
            EndContext();
            BeginContext(3618, 40, true);
            WriteLiteral(" </td>\r\n                            <td>");
            EndContext();
            BeginContext(3659, 5, false);
#line 100 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\ReceiptPanelMaster\Index.cshtml"
                           Write(s.Amt);

#line default
#line hidden
            EndContext();
            BeginContext(3664, 100, true);
            WriteLiteral(" </td>\r\n                            \r\n                            \r\n                            <td>");
            EndContext();
            BeginContext(3765, 12, false);
#line 103 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\ReceiptPanelMaster\Index.cshtml"
                           Write(s.VOUCHER_NO);

#line default
#line hidden
            EndContext();
            BeginContext(3777, 102, true);
            WriteLiteral("</td>\r\n\r\n                            <td>\r\n                                <ul class=\"icons-list\">\r\n\r\n");
            EndContext();
#line 108 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\ReceiptPanelMaster\Index.cshtml"
                                     if (editview)
                                    {

#line default
#line hidden
            BeginContext(3970, 306, true);
            WriteLiteral(@"                                        <li class=""text-primary-600""><a data-modalhorizontal=""true"" data-modalsize=""modal-lg"" data-heading=""Edit Panel Receipt"" data-script=""/assets/Areas/Transaction/ReceiptPanelMaster/ReceiptPanelMaster.js"" data-url=""/Transaction/ReceiptPanelMaster/AReceiptPanelMaster?Id=");
            EndContext();
            BeginContext(4277, 11, false);
#line 110 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\ReceiptPanelMaster\Index.cshtml"
                                                                                                                                                                                                                                                                                                             Write(s.ReceiptId);

#line default
#line hidden
            EndContext();
            BeginContext(4288, 41, true);
            WriteLiteral("\"><i class=\"icon-pencil7\"></i></a></li>\r\n");
            EndContext();
#line 111 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\ReceiptPanelMaster\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(4368, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 114 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\ReceiptPanelMaster\Index.cshtml"
                                     if (delete)
                                    {

#line default
#line hidden
            BeginContext(4461, 70, true);
            WriteLiteral("                                        <li class=\"text-danger-600\"><a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4531, "\"", 4651, 7);
            WriteAttributeValue("", 4541, "DeleteAlert({", 4541, 13, true);
            WriteAttributeValue(" ", 4554, "\'Id\':", 4555, 6, true);
#line 116 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\ReceiptPanelMaster\Index.cshtml"
WriteAttributeValue("", 4560, s.ReceiptId, 4560, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 4572, "},", 4572, 2, true);
            WriteAttributeValue(" ", 4574, "\'/Transaction/ReceiptPanelMaster/DeleteReceiptPanelMaster\',", 4575, 60, true);
            WriteAttributeValue(" ", 4634, "\'Panel", 4635, 7, true);
            WriteAttributeValue(" ", 4641, "Receipt\')", 4642, 10, true);
            EndWriteAttribute();
            BeginContext(4652, 38, true);
            WriteLiteral("><i class=\"icon-trash\"></i></a></li>\r\n");
            EndContext();
#line 117 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\ReceiptPanelMaster\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(4729, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 120 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\ReceiptPanelMaster\Index.cshtml"
                                     if (Print)
                                    {

#line default
#line hidden
            BeginContext(4821, 108, true);
            WriteLiteral("                                        <li class=\"text-primary-600\"><a data-toggle=\"tooltip\" title=\"Report\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4929, "\"", 5134, 14);
            WriteAttributeValue("", 4936, "/Report/Reportrdlc/AReport?rvalues.Name=19&rvalues.Value[0]=", 4936, 60, true);
#line 122 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\ReceiptPanelMaster\Index.cshtml"
WriteAttributeValue("", 4996, s.ReceiptId, 4996, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 5008, "&rvalues.Value[1]=", 5008, 18, true);
#line 122 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\ReceiptPanelMaster\Index.cshtml"
WriteAttributeValue("", 5026, s.RDate, 5026, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 5034, "&rvalues.Value[2]=", 5034, 18, true);
#line 122 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\ReceiptPanelMaster\Index.cshtml"
WriteAttributeValue("", 5052, a, 5052, 2, false);

#line default
#line hidden
            WriteAttributeValue("", 5054, "&rvalues.Value[3]=", 5054, 18, true);
#line 122 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\ReceiptPanelMaster\Index.cshtml"
WriteAttributeValue("", 5072, a, 5072, 2, false);

#line default
#line hidden
            WriteAttributeValue("", 5074, "&rvalues.Value[4]=", 5074, 18, true);
#line 122 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\ReceiptPanelMaster\Index.cshtml"
WriteAttributeValue("", 5092, a, 5092, 2, false);

#line default
#line hidden
            WriteAttributeValue("", 5094, "&rvalues.Value[5]=", 5094, 18, true);
#line 122 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\ReceiptPanelMaster\Index.cshtml"
WriteAttributeValue("", 5112, a, 5112, 2, false);

#line default
#line hidden
            WriteAttributeValue("", 5114, "&rvalues.Value[6]=", 5114, 18, true);
#line 122 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\ReceiptPanelMaster\Index.cshtml"
WriteAttributeValue("", 5132, a, 5132, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5135, 80, true);
            WriteLiteral(" data-heading=\"CPD Form\" target=\"_blank\"><i class=\"icon-printer\"></i></a></li>\r\n");
            EndContext();
#line 123 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\ReceiptPanelMaster\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(5254, 117, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n                                </ul>\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 133 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\ReceiptPanelMaster\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(5394, 84, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SMSERP.Areas.Transaction.Models.ReceiptPanelMaster>> Html { get; private set; }
    }
}
#pragma warning restore 1591