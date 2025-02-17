#pragma checksum "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\Unit\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68c13639d9bf132c2e9e713fc59be26da2cf073d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Master_Views_Unit_Index), @"mvc.1.0.view", @"/Areas/Master/Views/Unit/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Master/Views/Unit/Index.cshtml", typeof(AspNetCore.Areas_Master_Views_Unit_Index))]
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
#line 1 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\Unit\Index.cshtml"
using ZCLINIC;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68c13639d9bf132c2e9e713fc59be26da2cf073d", @"/Areas/Master/Views/Unit/Index.cshtml")]
    public class Areas_Master_Views_Unit_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ZCLINIC.Areas.Master.Models.Unit>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(17, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(73, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\Unit\Index.cshtml"
  
    bool addview = ZCLINIC.UserRights.URM_AddNew_IsAuthenticated(Context.Session.GetRoleId(), "25");
    bool editview = ZCLINIC.UserRights.URM_Update_IsAuthenticated(Context.Session.GetRoleId(), "25");
    bool delete = ZCLINIC.UserRights.URM_Delete_IsAuthenticated(Context.Session.GetRoleId(), "25");

#line default
#line hidden
            BeginContext(388, 335, true);
            WriteLiteral(@"



<div class=""page-header page-header-default"">
    <div class=""breadcrumb-line"">
        <h6 class=""text-semibold"">Unit</h6>
    </div>
</div>

<div class=""content"">
    <div class=""panel panel-flat"">
        <div class=""panel-body"">
            <div class=""row"">
                <div class=""col-md-3 buttons-top"">

");
            EndContext();
#line 26 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\Unit\Index.cshtml"
                     if (addview)
                    {

#line default
#line hidden
            BeginContext(781, 217, true);
            WriteLiteral("                        <a class=\"btn btn-success btn-sm\" data-modalhorizontal=\"true\" data-modalsize=\"modal-sm\" data-url=\"/Master/Unit/AUnit\" data-heading=\"Unit\" data-script=\"#\"><i class=\"icon-add mr-5\"></i> Add</a>\r\n");
            EndContext();
#line 29 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\Unit\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1021, 118, true);
            WriteLiteral("\r\n\r\n\r\n                </div>\r\n\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n");
            EndContext();
            BeginContext(1494, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1894, 710, true);
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
                        <th>Unit Name</th>



");
            EndContext();
            BeginContext(2651, 122, true);
            WriteLiteral("                        <th>Actions</th>\r\n\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
            EndContext();
#line 74 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\Unit\Index.cshtml"
                     foreach (ZCLINIC.Areas.Master.Models.Unit s in Model)
                    {

#line default
#line hidden
            BeginContext(2872, 40, true);
            WriteLiteral("                        <tr data-rowid=\"");
            EndContext();
            BeginContext(2913, 8, false);
#line 76 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\Unit\Index.cshtml"
                                   Write(s.UnitId);

#line default
#line hidden
            EndContext();
            BeginContext(2921, 36, true);
            WriteLiteral("\">\r\n                            <td>");
            EndContext();
            BeginContext(2958, 10, false);
#line 77 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\Unit\Index.cshtml"
                           Write(s.UnitCode);

#line default
#line hidden
            EndContext();
            BeginContext(2968, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3008, 10, false);
#line 78 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\Unit\Index.cshtml"
                           Write(s.UnitName);

#line default
#line hidden
            EndContext();
            BeginContext(3018, 130, true);
            WriteLiteral("</td>\r\n                            \r\n\r\n                            <td>\r\n                                <ul class=\"icons-list\">\r\n");
            EndContext();
#line 83 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\Unit\Index.cshtml"
                                     if (editview)
                                    {

#line default
#line hidden
            BeginContext(3239, 247, true);
            WriteLiteral("                                        <li class=\"text-primary-600\">\r\n\r\n                                            <a data-modalhorizontal=\"true\" data-modalsize=\"modal-sm\" data-heading=\"Edit Unit\" data-script=\"#\" data-url=\"/Master/Unit/AUnit?Id=");
            EndContext();
            BeginContext(3487, 8, false);
#line 87 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\Unit\Index.cshtml"
                                                                                                                                                                         Write(s.UnitId);

#line default
#line hidden
            EndContext();
            BeginContext(3495, 84, true);
            WriteLiteral(" \"><i class=\"icon-pencil7\"></i></a>\r\n                                        </li>\r\n");
            EndContext();
#line 89 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\Unit\Index.cshtml"
                                    }

#line default
#line hidden
#line 90 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\Unit\Index.cshtml"
                                     if (delete)
                                    {

#line default
#line hidden
            BeginContext(3707, 70, true);
            WriteLiteral("                                        <li class=\"text-danger-600\"><a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3777, "\"", 3852, 6);
            WriteAttributeValue("", 3787, "DeleteAlert({", 3787, 13, true);
            WriteAttributeValue(" ", 3800, "\'Id\':", 3801, 6, true);
#line 92 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\Unit\Index.cshtml"
WriteAttributeValue("", 3806, s.UnitId, 3806, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 3815, "},", 3815, 2, true);
            WriteAttributeValue(" ", 3817, "\'/Master/Unit/DeleteUnit\',", 3818, 27, true);
            WriteAttributeValue(" ", 3844, "\'Unit\')", 3845, 8, true);
            EndWriteAttribute();
            BeginContext(3853, 38, true);
            WriteLiteral("><i class=\"icon-trash\"></i></a></li>\r\n");
            EndContext();
#line 93 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\Unit\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(3930, 115, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n                                </ul>\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 102 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\Unit\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(4068, 84, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ZCLINIC.Areas.Master.Models.Unit>> Html { get; private set; }
    }
}
#pragma warning restore 1591
