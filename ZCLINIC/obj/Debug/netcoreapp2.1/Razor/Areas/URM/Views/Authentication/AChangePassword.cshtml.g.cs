#pragma checksum "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\URM\Views\Authentication\AChangePassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c32273af82e61699b4e7b9db63850e12b1c98869"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_URM_Views_Authentication_AChangePassword), @"mvc.1.0.view", @"/Areas/URM/Views/Authentication/AChangePassword.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/URM/Views/Authentication/AChangePassword.cshtml", typeof(AspNetCore.Areas_URM_Views_Authentication_AChangePassword))]
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
#line 2 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\URM\Views\Authentication\AChangePassword.cshtml"
using ZCLINIC;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c32273af82e61699b4e7b9db63850e12b1c98869", @"/Areas/URM/Views/Authentication/AChangePassword.cshtml")]
    public class Areas_URM_Views_Authentication_AChangePassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ZCLINIC.Areas.URM.Models.USERAUTH>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\URM\Views\Authentication\AChangePassword.cshtml"
  
    string URL = "/URM/Authentication/UpdatePassword";


#line default
#line hidden
            BeginContext(123, 45, true);
            WriteLiteral("\r\n<form class=\"form-horizontal\" method=\"post\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 168, "\"", 173, 0);
            EndWriteAttribute();
            BeginContext(174, 11, true);
            WriteLiteral(" data-url=\"");
            EndContext();
            BeginContext(186, 3, false);
#line 8 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\URM\Views\Authentication\AChangePassword.cshtml"
                                                       Write(URL);

#line default
#line hidden
            EndContext();
            BeginContext(189, 315, true);
            WriteLiteral(@""" data-display=""Master Account"">



    <div class=""row"">



        <div class=""form-group form-group-xs"">
            <label class=""control-label col-sm-4 text-right"">Current Password <b class=""wysiwyg-color-red"">*</b></label>
            <div class=""form-group has-feedback col-sm-8"">
                ");
            EndContext();
            BeginContext(505, 159, false);
#line 19 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\URM\Views\Authentication\AChangePassword.cshtml"
           Write(Html.TextBoxFor(m => m.USER_PWS, new { @class = "form-control input-group", placeholder = "Enter Current Password", type = "password", required = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(664, 55, true);
            WriteLiteral("\r\n                <div class=\"form-control-feedback\"><i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 719, "\"", 727, 0);
            EndWriteAttribute();
            BeginContext(728, 291, true);
            WriteLiteral(@"></i></div>
            </div>
        </div>
        <div class=""form-group form-group-xs"">
            <label class=""control-label col-sm-4 text-right"">New Password <b class=""wysiwyg-color-red"">*</b></label>
            <div class=""form-group has-feedback col-sm-8"">
                ");
            EndContext();
            BeginContext(1020, 158, false);
#line 26 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\URM\Views\Authentication\AChangePassword.cshtml"
           Write(Html.TextBoxFor(m => m.NewPassword, new { @class = "form-control input-group", placeholder = "Enter New Password", type = "password", required = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(1178, 55, true);
            WriteLiteral("\r\n                <div class=\"form-control-feedback\"><i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1233, "\"", 1241, 0);
            EndWriteAttribute();
            BeginContext(1242, 295, true);
            WriteLiteral(@"></i></div>
            </div>
        </div>
        <div class=""form-group form-group-xs"">
            <label class=""control-label col-sm-4 text-right"">Confirm Password <b class=""wysiwyg-color-red"">*</b></label>
            <div class=""form-group has-feedback col-sm-8"">
                ");
            EndContext();
            BeginContext(1538, 166, false);
#line 33 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\URM\Views\Authentication\AChangePassword.cshtml"
           Write(Html.TextBoxFor(m => m.ConfirmPassword, new { @class = "form-control input-group", placeholder = "Enter Confirm Password", type = "password", required = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(1704, 55, true);
            WriteLiteral("\r\n                <div class=\"form-control-feedback\"><i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1759, "\"", 1767, 0);
            EndWriteAttribute();
            BeginContext(1768, 423, true);
            WriteLiteral(@"></i></div>
            </div>
        </div>

        <div class=""modal-footer no-padding no-border"">
            <button type=""button"" class=""btn btn-danger btn-xs"" data-dismiss=""modal""><i class=""icon-cross""></i> Close</button>
            <button type=""button"" data-submit=""true"" class=""btn btn-primary btn-xs""><i class=""icon-floppy-disk position-left""></i> Save</button>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ZCLINIC.Areas.URM.Models.USERAUTH> Html { get; private set; }
    }
}
#pragma warning restore 1591
