#pragma checksum "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Degree\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32463225b53297f5b189efdd333200b55a62f545"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Master_Views_Degree_Index), @"mvc.1.0.view", @"/Areas/Master/Views/Degree/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Master/Views/Degree/Index.cshtml", typeof(AspNetCore.Areas_Master_Views_Degree_Index))]
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
#line 1 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Degree\Index.cshtml"
using SMSERP;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32463225b53297f5b189efdd333200b55a62f545", @"/Areas/Master/Views/Degree/Index.cshtml")]
    public class Areas_Master_Views_Degree_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SMSERP.Areas.Master.Models.Degree>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(16, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(73, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Degree\Index.cshtml"
  
    bool addview = SMSERP.UserRights.URM_AddNew_IsAuthenticated(Context.Session.GetRoleId(), "88");
    bool editview = SMSERP.UserRights.URM_Update_IsAuthenticated(Context.Session.GetRoleId(), "88");
    bool delete = SMSERP.UserRights.URM_Delete_IsAuthenticated(Context.Session.GetRoleId(), "88");

#line default
#line hidden
            BeginContext(385, 337, true);
            WriteLiteral(@"



<div class=""page-header page-header-default"">
    <div class=""breadcrumb-line"">
        <h6 class=""text-semibold"">Degree</h6>
    </div>
</div>

<div class=""content"">
    <div class=""panel panel-flat"">
        <div class=""panel-body"">
            <div class=""row"">
                <div class=""col-md-3 buttons-top"">

");
            EndContext();
#line 26 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Degree\Index.cshtml"
                     if (addview)
                    {

#line default
#line hidden
            BeginContext(780, 223, true);
            WriteLiteral("                        <a class=\"btn btn-success btn-sm\" data-modalhorizontal=\"true\" data-modalsize=\"modal-sm\" data-url=\"/Master/Degree/ADegree\" data-heading=\"Degree\" data-script=\"#\"><i class=\"icon-add mr-5\"></i> Add</a>\r\n");
            EndContext();
#line 29 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Degree\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1026, 118, true);
            WriteLiteral("\r\n\r\n\r\n                </div>\r\n\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n");
            EndContext();
            BeginContext(1499, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1899, 714, true);
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
                        <th>Degree Name</th>




");
            EndContext();
            BeginContext(2660, 122, true);
            WriteLiteral("                        <th>Actions</th>\r\n\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
            EndContext();
#line 75 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Degree\Index.cshtml"
                     foreach (SMSERP.Areas.Master.Models.Degree s in Model)
                    {

#line default
#line hidden
            BeginContext(2882, 40, true);
            WriteLiteral("                        <tr data-rowid=\"");
            EndContext();
            BeginContext(2923, 7, false);
#line 77 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Degree\Index.cshtml"
                                   Write(s.DegId);

#line default
#line hidden
            EndContext();
            BeginContext(2930, 38, true);
            WriteLiteral("\">\r\n\r\n                            <td>");
            EndContext();
            BeginContext(2969, 9, false);
#line 79 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Degree\Index.cshtml"
                           Write(s.DegCode);

#line default
#line hidden
            EndContext();
            BeginContext(2978, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3018, 9, false);
#line 80 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Degree\Index.cshtml"
                           Write(s.DegName);

#line default
#line hidden
            EndContext();
            BeginContext(3027, 104, true);
            WriteLiteral("</td>\r\n\r\n\r\n\r\n                            <td>\r\n                                <ul class=\"icons-list\">\r\n");
            EndContext();
#line 86 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Degree\Index.cshtml"
                                     if (editview)
                                    {

#line default
#line hidden
            BeginContext(3222, 253, true);
            WriteLiteral("                                        <li class=\"text-primary-600\">\r\n\r\n                                            <a data-modalhorizontal=\"true\" data-modalsize=\"modal-sm\" data-heading=\"Edit Degree\" data-script=\"#\" data-url=\"/Master/Degree/ADegree?Id=");
            EndContext();
            BeginContext(3476, 7, false);
#line 90 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Degree\Index.cshtml"
                                                                                                                                                                               Write(s.DegId);

#line default
#line hidden
            EndContext();
            BeginContext(3483, 84, true);
            WriteLiteral(" \"><i class=\"icon-pencil7\"></i></a>\r\n                                        </li>\r\n");
            EndContext();
#line 92 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Degree\Index.cshtml"
                                    }

#line default
#line hidden
#line 93 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Degree\Index.cshtml"
                                     if (delete)
                                    {

#line default
#line hidden
            BeginContext(3695, 70, true);
            WriteLiteral("                                        <li class=\"text-danger-600\"><a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3765, "\"", 3845, 6);
            WriteAttributeValue("", 3775, "DeleteAlert({", 3775, 13, true);
            WriteAttributeValue(" ", 3788, "\'Id\':", 3789, 6, true);
#line 95 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Degree\Index.cshtml"
WriteAttributeValue("", 3794, s.DegId, 3794, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 3802, "},", 3802, 2, true);
            WriteAttributeValue(" ", 3804, "\'/Master/Degree/DeleteDegree\',", 3805, 31, true);
            WriteAttributeValue(" ", 3835, "\'Degree\')", 3836, 10, true);
            EndWriteAttribute();
            BeginContext(3846, 38, true);
            WriteLiteral("><i class=\"icon-trash\"></i></a></li>\r\n");
            EndContext();
#line 96 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Degree\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(3923, 115, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n                                </ul>\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 105 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Degree\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(4061, 84, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SMSERP.Areas.Master.Models.Degree>> Html { get; private set; }
    }
}
#pragma warning restore 1591
