#pragma checksum "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\CompanyProduct\ACompanyProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b769c90affe0a6fa026486c1fb393c752c456820"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Master_Views_CompanyProduct_ACompanyProduct), @"mvc.1.0.view", @"/Areas/Master/Views/CompanyProduct/ACompanyProduct.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Master/Views/CompanyProduct/ACompanyProduct.cshtml", typeof(AspNetCore.Areas_Master_Views_CompanyProduct_ACompanyProduct))]
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
#line 3 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\CompanyProduct\ACompanyProduct.cshtml"
using ZCLINIC;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b769c90affe0a6fa026486c1fb393c752c456820", @"/Areas/Master/Views/CompanyProduct/ACompanyProduct.cshtml")]
    public class Areas_Master_Views_CompanyProduct_ACompanyProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ZCLINIC.Areas.Master.Models.CompanyProduct>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(71, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\CompanyProduct\ACompanyProduct.cshtml"
  
    string URL = Model == null ? "/Master/CompanyProduct/SaveCompanyProduct" : "/Master/CompanyProduct/UpdateCompanyProduct";

#line default
#line hidden
            BeginContext(207, 45, true);
            WriteLiteral("\r\n<form class=\"form-horizontal\" method=\"post\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 252, "\"", 257, 0);
            EndWriteAttribute();
            BeginContext(258, 11, true);
            WriteLiteral(" data-url=\"");
            EndContext();
            BeginContext(270, 3, false);
#line 10 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\CompanyProduct\ACompanyProduct.cshtml"
                                                       Write(URL);

#line default
#line hidden
            EndContext();
            BeginContext(273, 67, true);
            WriteLiteral("\" data-display=\"Master\" data-rurl=\"/Master/CompanyProduct\">\r\n\r\n    ");
            EndContext();
            BeginContext(341, 28, false);
#line 12 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\CompanyProduct\ACompanyProduct.cshtml"
Write(Html.HiddenFor(m => m.ComId));

#line default
#line hidden
            EndContext();
            BeginContext(369, 258, true);
            WriteLiteral(@"

    <div class=""row"">

        <div class=""form-group form-group-xs"">
            <label class=""control-label col-sm-4"">Company  Id<b class=""wysiwyg-color-red"">*</b></label>
            <div class=""form-group has-feedback col-sm-4"">
                ");
            EndContext();
            BeginContext(628, 113, false);
#line 19 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\CompanyProduct\ACompanyProduct.cshtml"
           Write(Html.TextBoxFor(m => m.ComId, new { @class = "form-control input-group", type = "text", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(741, 55, true);
            WriteLiteral("\r\n                <div class=\"form-control-feedback\"><i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 796, "\"", 804, 0);
            EndWriteAttribute();
            BeginContext(805, 282, true);
            WriteLiteral(@"></i></div>
            </div>
        </div>

        <div class=""form-group form-group-xs"">
            <label class=""control-label col-sm-4"">Company Name <b class=""wysiwyg-color-red"">*</b></label>
            <div class=""form-group has-feedback col-sm-8"">
                ");
            EndContext();
            BeginContext(1088, 146, false);
#line 27 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\CompanyProduct\ACompanyProduct.cshtml"
           Write(Html.TextBoxFor(m => m.CompName, new { @class = "form-control input-group", placeholder = "Company  Name", type = "text", required = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(1234, 55, true);
            WriteLiteral("\r\n                <div class=\"form-control-feedback\"><i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1289, "\"", 1297, 0);
            EndWriteAttribute();
            BeginContext(1298, 427, true);
            WriteLiteral(@"></i></div>
            </div>
        </div>




        <div class=""modal-footer no-padding no-border"">
            <button type=""button"" class=""btn btn-danger btn-xs"" data-dismiss=""modal""><i class=""icon-cross""></i>Close</button>
            <button type=""button"" data-submit=""true"" class=""btn btn-primary btn-xs""><i class=""icon-floppy-disk position-left""></i>Save</button>
        </div>

    </div>

</form>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ZCLINIC.Areas.Master.Models.CompanyProduct> Html { get; private set; }
    }
}
#pragma warning restore 1591
