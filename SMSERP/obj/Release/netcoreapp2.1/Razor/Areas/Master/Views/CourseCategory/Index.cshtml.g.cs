#pragma checksum "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\CourseCategory\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0bde620c03ff9e1fde39da531e67e4222b6b1050"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Master_Views_CourseCategory_Index), @"mvc.1.0.view", @"/Areas/Master/Views/CourseCategory/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Master/Views/CourseCategory/Index.cshtml", typeof(AspNetCore.Areas_Master_Views_CourseCategory_Index))]
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
#line 1 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\CourseCategory\Index.cshtml"
using SMSERP;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bde620c03ff9e1fde39da531e67e4222b6b1050", @"/Areas/Master/Views/CourseCategory/Index.cshtml")]
    public class Areas_Master_Views_CourseCategory_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SMSERP.Areas.Master.Models.CourseCategory>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(16, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(81, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\CourseCategory\Index.cshtml"
  
    bool addview = SMSERP.UserRights.URM_AddNew_IsAuthenticated(Context.Session.GetRoleId(), "73");
    bool editview = SMSERP.UserRights.URM_Update_IsAuthenticated(Context.Session.GetRoleId(), "73");
    bool delete = SMSERP.UserRights.URM_Delete_IsAuthenticated(Context.Session.GetRoleId(), "73");

#line default
#line hidden
            BeginContext(393, 346, true);
            WriteLiteral(@"



<div class=""page-header page-header-default"">
    <div class=""breadcrumb-line"">
        <h6 class=""text-semibold"">Course Category</h6>
    </div>
</div>

<div class=""content"">
    <div class=""panel panel-flat"">
        <div class=""panel-body"">
            <div class=""row"">
                <div class=""col-md-3 buttons-top"">

");
            EndContext();
#line 26 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\CourseCategory\Index.cshtml"
                     if (addview)
                    {

#line default
#line hidden
            BeginContext(797, 241, true);
            WriteLiteral("                        <a class=\"btn btn-success btn-sm\" data-modalhorizontal=\"true\" data-modalsize=\"modal-sm\" data-url=\"/Master/CourseCategory/ACourseCategory\" data-heading=\"Category\" data-script=\"#\"><i class=\"icon-add mr-5\"></i> Add</a>\r\n");
            EndContext();
#line 29 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\CourseCategory\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1061, 118, true);
            WriteLiteral("\r\n\r\n\r\n                </div>\r\n\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n");
            EndContext();
            BeginContext(1534, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1934, 716, true);
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

                        <th>Category Name</th>



");
            EndContext();
            BeginContext(2697, 122, true);
            WriteLiteral("                        <th>Actions</th>\r\n\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
            EndContext();
#line 75 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\CourseCategory\Index.cshtml"
                     foreach (SMSERP.Areas.Master.Models.CourseCategory s in Model)
                    {

#line default
#line hidden
            BeginContext(2927, 40, true);
            WriteLiteral("                        <tr data-rowid=\"");
            EndContext();
            BeginContext(2968, 12, false);
#line 77 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\CourseCategory\Index.cshtml"
                                   Write(s.CategoryId);

#line default
#line hidden
            EndContext();
            BeginContext(2980, 36, true);
            WriteLiteral("\">\r\n                            <td>");
            EndContext();
            BeginContext(3017, 14, false);
#line 78 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\CourseCategory\Index.cshtml"
                           Write(s.CategoryCode);

#line default
#line hidden
            EndContext();
            BeginContext(3031, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3071, 14, false);
#line 79 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\CourseCategory\Index.cshtml"
                           Write(s.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(3085, 100, true);
            WriteLiteral("</td>\r\n\r\n                            <td>\r\n                                <ul class=\"icons-list\">\r\n");
            EndContext();
#line 83 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\CourseCategory\Index.cshtml"
                                     if (editview)
                                    {

#line default
#line hidden
            BeginContext(3276, 271, true);
            WriteLiteral(@"                                        <li class=""text-primary-600"">

                                            <a data-modalhorizontal=""true"" data-modalsize=""modal-sm"" data-heading=""Edit Category"" data-script=""#"" data-url=""/Master/CourseCategory/ACourseCategory?Id=");
            EndContext();
            BeginContext(3548, 12, false);
#line 87 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\CourseCategory\Index.cshtml"
                                                                                                                                                                                                 Write(s.CategoryId);

#line default
#line hidden
            EndContext();
            BeginContext(3560, 83, true);
            WriteLiteral("\"><i class=\"icon-pencil7\"></i></a>\r\n                                        </li>\r\n");
            EndContext();
#line 89 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\CourseCategory\Index.cshtml"
                                    }

#line default
#line hidden
#line 90 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\CourseCategory\Index.cshtml"
                                     if (delete)
                                    {

#line default
#line hidden
            BeginContext(3771, 70, true);
            WriteLiteral("                                        <li class=\"text-danger-600\"><a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3841, "\"", 3951, 7);
            WriteAttributeValue("", 3851, "DeleteAlert({", 3851, 13, true);
            WriteAttributeValue(" ", 3864, "\'Id\':", 3865, 6, true);
#line 92 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\CourseCategory\Index.cshtml"
WriteAttributeValue("", 3870, s.CategoryId, 3870, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 3883, "},", 3883, 2, true);
            WriteAttributeValue(" ", 3885, "\'/Master/CourseCategory/DeleteCourseCategory\',", 3886, 47, true);
            WriteAttributeValue(" ", 3932, "\'Course", 3933, 8, true);
            WriteAttributeValue(" ", 3940, "Category\')", 3941, 11, true);
            EndWriteAttribute();
            BeginContext(3952, 38, true);
            WriteLiteral("><i class=\"icon-trash\"></i></a></li>\r\n");
            EndContext();
#line 93 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\CourseCategory\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(4029, 115, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n                                </ul>\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 102 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\CourseCategory\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(4167, 84, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SMSERP.Areas.Master.Models.CourseCategory>> Html { get; private set; }
    }
}
#pragma warning restore 1591