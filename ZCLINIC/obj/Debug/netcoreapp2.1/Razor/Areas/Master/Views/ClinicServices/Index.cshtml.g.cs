#pragma checksum "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\ClinicServices\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a991011d9b19bb08957f1c6f3262c83ca525048a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Master_Views_ClinicServices_Index), @"mvc.1.0.view", @"/Areas/Master/Views/ClinicServices/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Master/Views/ClinicServices/Index.cshtml", typeof(AspNetCore.Areas_Master_Views_ClinicServices_Index))]
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
#line 1 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\ClinicServices\Index.cshtml"
using ZCLINIC;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a991011d9b19bb08957f1c6f3262c83ca525048a", @"/Areas/Master/Views/ClinicServices/Index.cshtml")]
    public class Areas_Master_Views_ClinicServices_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ZCLINIC.Areas.Master.Models.ClinicServices>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(17, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(83, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\ClinicServices\Index.cshtml"
  
    bool addview = ZCLINIC.UserRights.URM_AddNew_IsAuthenticated(Context.Session.GetRoleId(), "96");
    bool editview = ZCLINIC.UserRights.URM_Update_IsAuthenticated(Context.Session.GetRoleId(), "96");
    bool delete = ZCLINIC.UserRights.URM_Delete_IsAuthenticated(Context.Session.GetRoleId(), "96");

#line default
#line hidden
            BeginContext(398, 339, true);
            WriteLiteral(@"



<div class=""page-header page-header-default"">
    <div class=""breadcrumb-line"">
        <h6 class=""text-semibold"">Services</h6>
    </div>
</div>

<div class=""content"">
    <div class=""panel panel-flat"">
        <div class=""panel-body"">
            <div class=""row"">
                <div class=""col-md-3 buttons-top"">

");
            EndContext();
#line 26 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\ClinicServices\Index.cshtml"
                     if (addview)
                    {

#line default
#line hidden
            BeginContext(795, 241, true);
            WriteLiteral("                        <a class=\"btn btn-success btn-sm\" data-modalhorizontal=\"true\" data-modalsize=\"modal-sm\" data-url=\"/Master/ClinicServices/AClinicServices\" data-heading=\"Services\" data-script=\"#\"><i class=\"icon-add mr-5\"></i> Add</a>\r\n");
            EndContext();
#line 29 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\ClinicServices\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1059, 118, true);
            WriteLiteral("\r\n\r\n\r\n                </div>\r\n\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n");
            EndContext();
            BeginContext(1532, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1932, 802, true);
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
                        <th>Servics Name</th>
                        <th>Category Name</th>
                        <th>Rate</th>




");
            EndContext();
            BeginContext(2781, 122, true);
            WriteLiteral("                        <th>Actions</th>\r\n\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
            EndContext();
#line 77 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\ClinicServices\Index.cshtml"
                     foreach (ZCLINIC.Areas.Master.Models.ClinicServices s in Model)
                    {

#line default
#line hidden
            BeginContext(3012, 40, true);
            WriteLiteral("                        <tr data-rowid=\"");
            EndContext();
            BeginContext(3053, 12, false);
#line 79 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\ClinicServices\Index.cshtml"
                                   Write(s.ServicesId);

#line default
#line hidden
            EndContext();
            BeginContext(3065, 38, true);
            WriteLiteral("\">\r\n\r\n                            <td>");
            EndContext();
            BeginContext(3104, 14, false);
#line 81 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\ClinicServices\Index.cshtml"
                           Write(s.ServicesCode);

#line default
#line hidden
            EndContext();
            BeginContext(3118, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3158, 14, false);
#line 82 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\ClinicServices\Index.cshtml"
                           Write(s.ServicesName);

#line default
#line hidden
            EndContext();
            BeginContext(3172, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3212, 14, false);
#line 83 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\ClinicServices\Index.cshtml"
                           Write(s.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(3226, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3266, 6, false);
#line 84 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\ClinicServices\Index.cshtml"
                           Write(s.Rate);

#line default
#line hidden
            EndContext();
            BeginContext(3272, 106, true);
            WriteLiteral("</td>\r\n\r\n\r\n\r\n\r\n                            <td>\r\n                                <ul class=\"icons-list\">\r\n");
            EndContext();
#line 91 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\ClinicServices\Index.cshtml"
                                     if (editview)
                                    {

#line default
#line hidden
            BeginContext(3469, 271, true);
            WriteLiteral(@"                                        <li class=""text-primary-600"">

                                            <a data-modalhorizontal=""true"" data-modalsize=""modal-sm"" data-heading=""Edit Services"" data-script=""#"" data-url=""/Master/ClinicServices/AClinicServices?Id=");
            EndContext();
            BeginContext(3741, 12, false);
#line 95 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\ClinicServices\Index.cshtml"
                                                                                                                                                                                                 Write(s.ServicesId);

#line default
#line hidden
            EndContext();
            BeginContext(3753, 84, true);
            WriteLiteral(" \"><i class=\"icon-pencil7\"></i></a>\r\n                                        </li>\r\n");
            EndContext();
#line 97 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\ClinicServices\Index.cshtml"
                                    }

#line default
#line hidden
#line 98 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\ClinicServices\Index.cshtml"
                                     if (delete)
                                    {

#line default
#line hidden
            BeginContext(3965, 70, true);
            WriteLiteral("                                        <li class=\"text-danger-600\"><a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4035, "\"", 4138, 6);
            WriteAttributeValue("", 4045, "DeleteAlert({", 4045, 13, true);
            WriteAttributeValue(" ", 4058, "\'Id\':", 4059, 6, true);
#line 100 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\ClinicServices\Index.cshtml"
WriteAttributeValue("", 4064, s.CategoryId, 4064, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 4077, "},", 4077, 2, true);
            WriteAttributeValue(" ", 4079, "\'/Master/ClinicServices/DeleteClinicServices\',", 4080, 47, true);
            WriteAttributeValue(" ", 4126, "\'Services\')", 4127, 12, true);
            EndWriteAttribute();
            BeginContext(4139, 38, true);
            WriteLiteral("><i class=\"icon-trash\"></i></a></li>\r\n");
            EndContext();
#line 101 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\ClinicServices\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(4216, 115, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n                                </ul>\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 110 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\ClinicServices\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(4354, 84, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ZCLINIC.Areas.Master.Models.ClinicServices>> Html { get; private set; }
    }
}
#pragma warning restore 1591