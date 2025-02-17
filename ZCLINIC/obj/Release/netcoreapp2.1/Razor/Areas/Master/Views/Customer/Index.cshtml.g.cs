#pragma checksum "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Customer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e36500feba5af22e81d332d2ec3b8acbcee167c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Master_Views_Customer_Index), @"mvc.1.0.view", @"/Areas/Master/Views/Customer/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Master/Views/Customer/Index.cshtml", typeof(AspNetCore.Areas_Master_Views_Customer_Index))]
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
#line 1 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Customer\Index.cshtml"
using SMSERP;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e36500feba5af22e81d332d2ec3b8acbcee167c", @"/Areas/Master/Views/Customer/Index.cshtml")]
    public class Areas_Master_Views_Customer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SMSERP.Areas.Master.Models.Customer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(16, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(75, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Customer\Index.cshtml"
  
    bool addview = SMSERP.UserRights.URM_AddNew_IsAuthenticated(Context.Session.GetRoleId(), "31");
    bool editview = SMSERP.UserRights.URM_Update_IsAuthenticated(Context.Session.GetRoleId(), "31");
    bool delete = SMSERP.UserRights.URM_Delete_IsAuthenticated(Context.Session.GetRoleId(), "31");

#line default
#line hidden
            BeginContext(387, 339, true);
            WriteLiteral(@"



<div class=""page-header page-header-default"">
    <div class=""breadcrumb-line"">
        <h6 class=""text-semibold"">Customer</h6>
    </div>
</div>

<div class=""content"">
    <div class=""panel panel-flat"">
        <div class=""panel-body"">
            <div class=""row"">
                <div class=""col-md-3 buttons-top"">

");
            EndContext();
#line 26 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Customer\Index.cshtml"
                     if (addview)
                    {

#line default
#line hidden
            BeginContext(784, 229, true);
            WriteLiteral("                        <a class=\"btn btn-success btn-sm\" data-modalhorizontal=\"true\" data-modalsize=\"modal-sm\" data-url=\"/Master/Customer/ACustomer\" data-heading=\"Customer\" data-script=\"#\"><i class=\"icon-add mr-5\"></i> Add</a>\r\n");
            EndContext();
#line 29 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Customer\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1036, 118, true);
            WriteLiteral("\r\n\r\n\r\n                </div>\r\n\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n");
            EndContext();
            BeginContext(1509, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1909, 837, true);
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
                        <th>ID</th>
                        <th>Customer Name</th>
                        <th>Address</th>
                        <th>Mobile</th>
                        <th>Phone</th>



");
            EndContext();
            BeginContext(2793, 122, true);
            WriteLiteral("                        <th>Actions</th>\r\n\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
            EndContext();
#line 77 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Customer\Index.cshtml"
                     foreach (SMSERP.Areas.Master.Models.Customer s in Model)
                    {

#line default
#line hidden
            BeginContext(3017, 40, true);
            WriteLiteral("                        <tr data-rowid=\"");
            EndContext();
            BeginContext(3058, 7, false);
#line 79 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Customer\Index.cshtml"
                                   Write(s.CusId);

#line default
#line hidden
            EndContext();
            BeginContext(3065, 38, true);
            WriteLiteral("\">\r\n\r\n                            <td>");
            EndContext();
            BeginContext(3104, 7, false);
#line 81 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Customer\Index.cshtml"
                           Write(s.CusId);

#line default
#line hidden
            EndContext();
            BeginContext(3111, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3151, 14, false);
#line 82 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Customer\Index.cshtml"
                           Write(s.CustomerName);

#line default
#line hidden
            EndContext();
            BeginContext(3165, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3205, 9, false);
#line 83 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Customer\Index.cshtml"
                           Write(s.Address);

#line default
#line hidden
            EndContext();
            BeginContext(3214, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3254, 10, false);
#line 84 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Customer\Index.cshtml"
                           Write(s.MobileNo);

#line default
#line hidden
            EndContext();
            BeginContext(3264, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3304, 9, false);
#line 85 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Customer\Index.cshtml"
                           Write(s.PhoneNo);

#line default
#line hidden
            EndContext();
            BeginContext(3313, 102, true);
            WriteLiteral("</td>\r\n\r\n\r\n                            <td>\r\n                                <ul class=\"icons-list\">\r\n");
            EndContext();
#line 90 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Customer\Index.cshtml"
                                     if (editview)
                                    {

#line default
#line hidden
            BeginContext(3506, 259, true);
            WriteLiteral(@"                                        <li class=""text-primary-600"">

                                            <a data-modalhorizontal=""true"" data-modalsize=""modal-sm"" data-heading=""Edit Customer"" data-script=""#"" data-url=""/Master/Customer/ACustomer?Id=");
            EndContext();
            BeginContext(3766, 7, false);
#line 94 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Customer\Index.cshtml"
                                                                                                                                                                                     Write(s.CusId);

#line default
#line hidden
            EndContext();
            BeginContext(3773, 84, true);
            WriteLiteral(" \"><i class=\"icon-pencil7\"></i></a>\r\n                                        </li>\r\n");
            EndContext();
#line 96 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Customer\Index.cshtml"
                                    }

#line default
#line hidden
#line 97 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Customer\Index.cshtml"
                                     if (delete)
                                    {

#line default
#line hidden
            BeginContext(3985, 70, true);
            WriteLiteral("                                        <li class=\"text-danger-600\"><a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4055, "\"", 4141, 6);
            WriteAttributeValue("", 4065, "DeleteAlert({", 4065, 13, true);
            WriteAttributeValue(" ", 4078, "\'Id\':", 4079, 6, true);
#line 99 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Customer\Index.cshtml"
WriteAttributeValue("", 4084, s.CusId, 4084, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 4092, "},", 4092, 2, true);
            WriteAttributeValue(" ", 4094, "\'/Master/Customer/DeleteCustomer\',", 4095, 35, true);
            WriteAttributeValue(" ", 4129, "\'Customer\')", 4130, 12, true);
            EndWriteAttribute();
            BeginContext(4142, 38, true);
            WriteLiteral("><i class=\"icon-trash\"></i></a></li>\r\n");
            EndContext();
#line 100 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Customer\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(4219, 115, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n                                </ul>\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 109 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Customer\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(4357, 84, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SMSERP.Areas.Master.Models.Customer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
