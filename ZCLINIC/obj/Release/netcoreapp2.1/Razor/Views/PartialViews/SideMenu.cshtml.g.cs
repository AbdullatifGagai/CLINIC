#pragma checksum "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Views\PartialViews\SideMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a496a0d2ecb0d5bfb205ca502d19f72e48e6da0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PartialViews_SideMenu), @"mvc.1.0.view", @"/Views/PartialViews/SideMenu.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PartialViews/SideMenu.cshtml", typeof(AspNetCore.Views_PartialViews_SideMenu))]
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
#line 1 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Views\_ViewImports.cshtml"
using SMSERP;

#line default
#line hidden
#line 2 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Views\_ViewImports.cshtml"
using SMSERP.Models;

#line default
#line hidden
#line 1 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Views\PartialViews\SideMenu.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#line 2 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Views\PartialViews\SideMenu.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a496a0d2ecb0d5bfb205ca502d19f72e48e6da0", @"/Views/PartialViews/SideMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"181a81803dc64bbf4e922a882b00e58d27d223a2", @"/Views/_ViewImports.cshtml")]
    public class Views_PartialViews_SideMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/Logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(135, 36, true);
            WriteLiteral("<div class=\"sidebar sidebar-main\">\r\n");
            EndContext();
            BeginContext(194, 35, true);
            WriteLiteral("    <div class=\"sidebar-content\">\r\n");
            EndContext();
            BeginContext(299, 145, true);
            WriteLiteral("        <!-- User menu -->\r\n        <div class=\"sidebar-user\">\r\n            <div class=\"category-content\">\r\n                <div class=\"media\">\r\n");
            EndContext();
            BeginContext(727, 51, true);
            WriteLiteral("                    <a href=\"#\" class=\"media-left\">");
            EndContext();
            BeginContext(778, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2a496a0d2ecb0d5bfb205ca502d19f72e48e6da04622", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(816, 118, true);
            WriteLiteral("</a>\r\n                    <div class=\"media-body\">\r\n                        <span class=\"media-heading text-semibold\">");
            EndContext();
            BeginContext(936, 134, false);
#line 16 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Views\PartialViews\SideMenu.cshtml"
                                                              Write(new SMSERP.Areas.URM.Models.USERAUTH().URM_USERAUTHGetById(Context.Session.GetBValues(), Context.GetIP(), Context.GetCInfo()).FullName);

#line default
#line hidden
            EndContext();
            BeginContext(1071, 97, true);
            WriteLiteral("</span>\r\n                        <span class=\"media-heading text-semibold\">Administrator</span>\r\n");
            EndContext();
            BeginContext(1491, 173, true);
            WriteLiteral("                    </div>\r\n\r\n                    <div class=\"media-right media-middle\">\r\n                        <ul class=\"icons-list\">\r\n                            <li>\r\n");
            EndContext();
            BeginContext(1825, 435, true);
            WriteLiteral(@"                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
        <!-- /user menu -->
        <!-- Main navigation -->
        <div class=""sidebar-category sidebar-category-visible"">
            <div class=""category-content no-padding"">
                <ul class=""navigation navigation-main navigation-accordion"">
                    ");
            EndContext();
            BeginContext(2262, 110, false);
#line 39 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Views\PartialViews\SideMenu.cshtml"
                Write(new HtmlString(MenuRender(new SMSERP.Areas.URM.Models.Menu().PrepareMenu(Context.Session.GetRoleId()), Model)));

#line default
#line hidden
            EndContext();
            BeginContext(2373, 37, true);
            WriteLiteral("\r\n                    <!-- Main -->\r\n");
            EndContext();
            BeginContext(2665, 116, true);
            WriteLiteral("                </ul>\r\n            </div>\r\n        </div>\r\n        <!-- /main navigation -->\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
#line 50 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Views\PartialViews\SideMenu.cshtml"
  
    string MenuRender(IEnumerable<SMSERP.Areas.URM.Models.Menu> menu, string html)
    {
        foreach (SMSERP.Areas.URM.Models.Menu m in menu)
        {
            string ContentPath = m.Script ?? "dummy";
            if (m.MenuList.Count > 0)
            {
                string inhtml = MenuRender(m.MenuList, "");
                html += "<li><a href = '#' class='has-ul legitRipple'><i class='" + m.Icon + "'></i> <span>" + m.MenuText + "</span></a> <ul class='hidden-ul'>" + inhtml + "</ul></li>";
            }
            else
            {
                html += "<li><a href = '#' data-url='" + Url.Action("" + m.Method + "", "" + m.Controller + "", new { Area = "" + m.ModuleName + "" }) + "' data-script='" + Url.Content(ContentPath) + "' data-display='" + m.MenuText + "' class='legitRipple'><i class='" + m.Icon + "'></i><span>" + m.MenuText + "</span></a></li>";
            }
        }
        return html;
    }

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
