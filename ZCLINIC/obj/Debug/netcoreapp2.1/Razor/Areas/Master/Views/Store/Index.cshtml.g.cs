#pragma checksum "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\Store\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9fe72f4e739ecb9f6f40fde0bf9d7eb90d5cc5c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Master_Views_Store_Index), @"mvc.1.0.view", @"/Areas/Master/Views/Store/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Master/Views/Store/Index.cshtml", typeof(AspNetCore.Areas_Master_Views_Store_Index))]
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
#line 1 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\Store\Index.cshtml"
using ZCLINIC;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9fe72f4e739ecb9f6f40fde0bf9d7eb90d5cc5c", @"/Areas/Master/Views/Store/Index.cshtml")]
    public class Areas_Master_Views_Store_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ZCLINIC.Areas.Master.Models.Store>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(17, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(74, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\Store\Index.cshtml"
  
    bool addview = ZCLINIC.UserRights.URM_AddNew_IsAuthenticated(Context.Session.GetRoleId(), "28");
    bool editview = ZCLINIC.UserRights.URM_Update_IsAuthenticated(Context.Session.GetRoleId(), "28");
    bool delete = ZCLINIC.UserRights.URM_Delete_IsAuthenticated(Context.Session.GetRoleId(), "28");

#line default
#line hidden
            BeginContext(389, 336, true);
            WriteLiteral(@"



<div class=""page-header page-header-default"">
    <div class=""breadcrumb-line"">
        <h6 class=""text-semibold"">Store</h6>
    </div>
</div>

<div class=""content"">
    <div class=""panel panel-flat"">
        <div class=""panel-body"">
            <div class=""row"">
                <div class=""col-md-3 buttons-top"">

");
            EndContext();
#line 26 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\Store\Index.cshtml"
                     if (addview)
                    {

#line default
#line hidden
            BeginContext(783, 220, true);
            WriteLiteral("                        <a class=\"btn btn-success btn-sm\" data-modalhorizontal=\"true\" data-modalsize=\"modal-sm\" data-url=\"/Master/Store/AStore\" data-heading=\"Store\" data-script=\"#\"><i class=\"icon-add mr-5\"></i> Add</a>\r\n");
            EndContext();
#line 29 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\Store\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1026, 118, true);
            WriteLiteral("\r\n\r\n\r\n                </div>\r\n\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n");
            EndContext();
            BeginContext(1499, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1899, 733, true);
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

                        <th>Store Name</th>
                  



");
            EndContext();
            BeginContext(2679, 122, true);
            WriteLiteral("                        <th>Actions</th>\r\n\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
            EndContext();
#line 76 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\Store\Index.cshtml"
                     foreach (ZCLINIC.Areas.Master.Models.Store s in Model)
                    {

#line default
#line hidden
            BeginContext(2901, 40, true);
            WriteLiteral("                        <tr data-rowid=\"");
            EndContext();
            BeginContext(2942, 9, false);
#line 78 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\Store\Index.cshtml"
                                   Write(s.storeId);

#line default
#line hidden
            EndContext();
            BeginContext(2951, 36, true);
            WriteLiteral("\">\r\n                            <td>");
            EndContext();
            BeginContext(2988, 11, false);
#line 79 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\Store\Index.cshtml"
                           Write(s.StoreCode);

#line default
#line hidden
            EndContext();
            BeginContext(2999, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3039, 11, false);
#line 80 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\Store\Index.cshtml"
                           Write(s.Storename);

#line default
#line hidden
            EndContext();
            BeginContext(3050, 129, true);
            WriteLiteral("</td>\r\n                         \r\n\r\n\r\n                            <td>\r\n                                <ul class=\"icons-list\">\r\n");
            EndContext();
#line 86 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\Store\Index.cshtml"
                                     if (editview)
                                    {

#line default
#line hidden
            BeginContext(3270, 250, true);
            WriteLiteral("                                        <li class=\"text-primary-600\">\r\n\r\n                                            <a data-modalhorizontal=\"true\" data-modalsize=\"modal-sm\" data-heading=\"Edit Store\" data-script=\"#\" data-url=\"/Master/Store/AStore?Id=");
            EndContext();
            BeginContext(3521, 9, false);
#line 90 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\Store\Index.cshtml"
                                                                                                                                                                            Write(s.storeId);

#line default
#line hidden
            EndContext();
            BeginContext(3530, 83, true);
            WriteLiteral("\"><i class=\"icon-pencil7\"></i></a>\r\n                                        </li>\r\n");
            EndContext();
#line 92 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\Store\Index.cshtml"
                                    }

#line default
#line hidden
#line 93 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\Store\Index.cshtml"
                                     if (delete)
                                    {

#line default
#line hidden
            BeginContext(3741, 70, true);
            WriteLiteral("                                        <li class=\"text-danger-600\"><a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3811, "\"", 3890, 6);
            WriteAttributeValue("", 3821, "DeleteAlert({", 3821, 13, true);
            WriteAttributeValue(" ", 3834, "\'Id\':", 3835, 6, true);
#line 95 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\Store\Index.cshtml"
WriteAttributeValue("", 3840, s.storeId, 3840, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 3850, "},", 3850, 2, true);
            WriteAttributeValue(" ", 3852, "\'/Master/Store/DeleteStore\',", 3853, 29, true);
            WriteAttributeValue(" ", 3881, "\'Store\')", 3882, 9, true);
            EndWriteAttribute();
            BeginContext(3891, 38, true);
            WriteLiteral("><i class=\"icon-trash\"></i></a></li>\r\n");
            EndContext();
#line 96 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\Store\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(3968, 115, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n                                </ul>\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 105 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\Store\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(4106, 84, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ZCLINIC.Areas.Master.Models.Store>> Html { get; private set; }
    }
}
#pragma warning restore 1591
