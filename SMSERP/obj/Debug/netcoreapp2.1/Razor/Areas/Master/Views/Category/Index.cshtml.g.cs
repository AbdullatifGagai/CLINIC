#pragma checksum "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Master\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c25e357c3dc766d6e8d82d5e145055900e6b0ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Master_Views_Category_Index), @"mvc.1.0.view", @"/Areas/Master/Views/Category/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Master/Views/Category/Index.cshtml", typeof(AspNetCore.Areas_Master_Views_Category_Index))]
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
#line 1 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Master\Views\Category\Index.cshtml"
using ZCLINIC;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c25e357c3dc766d6e8d82d5e145055900e6b0ab", @"/Areas/Master/Views/Category/Index.cshtml")]
    public class Areas_Master_Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ZCLINIC.Areas.Master.Models.Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(17, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(77, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Master\Views\Category\Index.cshtml"
  
    bool addview = ZCLINIC.UserRights.URM_AddNew_IsAuthenticated(Context.Session.GetRoleId(), "26");
    bool editview = ZCLINIC.UserRights.URM_Update_IsAuthenticated(Context.Session.GetRoleId(), "26");
    bool delete = ZCLINIC.UserRights.URM_Delete_IsAuthenticated(Context.Session.GetRoleId(), "26");

#line default
#line hidden
            BeginContext(392, 339, true);
            WriteLiteral(@"



<div class=""page-header page-header-default"">
    <div class=""breadcrumb-line"">
        <h6 class=""text-semibold"">Category</h6>
    </div>
</div>

<div class=""content"">
    <div class=""panel panel-flat"">
        <div class=""panel-body"">
            <div class=""row"">
                <div class=""col-md-3 buttons-top"">

");
            EndContext();
#line 26 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Master\Views\Category\Index.cshtml"
                     if (addview)
                    {

#line default
#line hidden
            BeginContext(789, 229, true);
            WriteLiteral("                        <a class=\"btn btn-success btn-sm\" data-modalhorizontal=\"true\" data-modalsize=\"modal-sm\" data-url=\"/Master/Category/ACategory\" data-heading=\"Category\" data-script=\"#\"><i class=\"icon-add mr-5\"></i> Add</a>\r\n");
            EndContext();
#line 29 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Master\Views\Category\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1041, 118, true);
            WriteLiteral("\r\n\r\n\r\n                </div>\r\n\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n");
            EndContext();
            BeginContext(1514, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1914, 738, true);
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
            BeginContext(2699, 122, true);
            WriteLiteral("                        <th>Actions</th>\r\n\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
            EndContext();
#line 75 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Master\Views\Category\Index.cshtml"
                     foreach (ZCLINIC.Areas.Master.Models.Category s in Model)
                    {

#line default
#line hidden
            BeginContext(2924, 40, true);
            WriteLiteral("                        <tr data-rowid=\"");
            EndContext();
            BeginContext(2965, 12, false);
#line 77 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Master\Views\Category\Index.cshtml"
                                   Write(s.CategoryId);

#line default
#line hidden
            EndContext();
            BeginContext(2977, 36, true);
            WriteLiteral("\">\r\n                            <td>");
            EndContext();
            BeginContext(3014, 14, false);
#line 78 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Master\Views\Category\Index.cshtml"
                           Write(s.CategoryCode);

#line default
#line hidden
            EndContext();
            BeginContext(3028, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3068, 14, false);
#line 79 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Master\Views\Category\Index.cshtml"
                           Write(s.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(3082, 124, true);
            WriteLiteral("</td>\r\n                        \r\n                            <td>\r\n                                <ul class=\"icons-list\">\r\n");
            EndContext();
#line 83 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Master\Views\Category\Index.cshtml"
                                     if (editview)
                                    {

#line default
#line hidden
            BeginContext(3297, 259, true);
            WriteLiteral(@"                                        <li class=""text-primary-600"">

                                            <a data-modalhorizontal=""true"" data-modalsize=""modal-sm"" data-heading=""Edit Category"" data-script=""#"" data-url=""/Master/Category/ACategory?Id=");
            EndContext();
            BeginContext(3557, 12, false);
#line 87 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Master\Views\Category\Index.cshtml"
                                                                                                                                                                                     Write(s.CategoryId);

#line default
#line hidden
            EndContext();
            BeginContext(3569, 83, true);
            WriteLiteral("\"><i class=\"icon-pencil7\"></i></a>\r\n                                        </li>\r\n");
            EndContext();
#line 89 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Master\Views\Category\Index.cshtml"
                                    }

#line default
#line hidden
#line 90 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Master\Views\Category\Index.cshtml"
                                     if (delete)
                                    {

#line default
#line hidden
            BeginContext(3780, 70, true);
            WriteLiteral("                                        <li class=\"text-danger-600\"><a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3850, "\"", 3941, 6);
            WriteAttributeValue("", 3860, "DeleteAlert({", 3860, 13, true);
            WriteAttributeValue(" ", 3873, "\'Id\':", 3874, 6, true);
#line 92 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Master\Views\Category\Index.cshtml"
WriteAttributeValue("", 3879, s.CategoryId, 3879, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 3892, "},", 3892, 2, true);
            WriteAttributeValue(" ", 3894, "\'/Master/Category/DeleteCategory\',", 3895, 35, true);
            WriteAttributeValue(" ", 3929, "\'Category\')", 3930, 12, true);
            EndWriteAttribute();
            BeginContext(3942, 38, true);
            WriteLiteral("><i class=\"icon-trash\"></i></a></li>\r\n");
            EndContext();
#line 93 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Master\Views\Category\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(4019, 115, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n                                </ul>\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 102 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Master\Views\Category\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(4157, 84, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ZCLINIC.Areas.Master.Models.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591