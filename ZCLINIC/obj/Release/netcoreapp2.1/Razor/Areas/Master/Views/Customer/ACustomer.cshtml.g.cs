#pragma checksum "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Customer\ACustomer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f29726d905cac53e95372f023f71f1a002adda7c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Master_Views_Customer_ACustomer), @"mvc.1.0.view", @"/Areas/Master/Views/Customer/ACustomer.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Master/Views/Customer/ACustomer.cshtml", typeof(AspNetCore.Areas_Master_Views_Customer_ACustomer))]
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
#line 3 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Customer\ACustomer.cshtml"
using SMSERP;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f29726d905cac53e95372f023f71f1a002adda7c", @"/Areas/Master/Views/Customer/ACustomer.cshtml")]
    public class Areas_Master_Views_Customer_ACustomer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SMSERP.Areas.Master.Models.Customer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(63, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Customer\ACustomer.cshtml"
  
    string URL = Model == null ? "/Master/Customer/SaveCustomer" : "/Master/Customer/UpdateCustomer";

#line default
#line hidden
            BeginContext(175, 45, true);
            WriteLiteral("\r\n<form class=\"form-horizontal\" method=\"post\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 220, "\"", 225, 0);
            EndWriteAttribute();
            BeginContext(226, 11, true);
            WriteLiteral(" data-url=\"");
            EndContext();
            BeginContext(238, 3, false);
#line 10 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Customer\ACustomer.cshtml"
                                                       Write(URL);

#line default
#line hidden
            EndContext();
            BeginContext(241, 61, true);
            WriteLiteral("\" data-display=\"Master\" data-rurl=\"/Master/Customer\">\r\n\r\n    ");
            EndContext();
            BeginContext(303, 28, false);
#line 12 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Customer\ACustomer.cshtml"
Write(Html.HiddenFor(m => m.CusId));

#line default
#line hidden
            EndContext();
            BeginContext(331, 258, true);
            WriteLiteral(@"

    <div class=""row"">

        <div class=""form-group form-group-xs"">
            <label class=""control-label col-sm-4"">Customer Id<b class=""wysiwyg-color-red"">*</b></label>
            <div class=""form-group has-feedback col-sm-4"">
                ");
            EndContext();
            BeginContext(590, 113, false);
#line 19 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Customer\ACustomer.cshtml"
           Write(Html.TextBoxFor(m => m.CusId, new { @class = "form-control input-group", type = "text", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(703, 55, true);
            WriteLiteral("\r\n                <div class=\"form-control-feedback\"><i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 758, "\"", 766, 0);
            EndWriteAttribute();
            BeginContext(767, 283, true);
            WriteLiteral(@"></i></div>
            </div>
        </div>

        <div class=""form-group form-group-xs"">
            <label class=""control-label col-sm-4"">Customer Name <b class=""wysiwyg-color-red"">*</b></label>
            <div class=""form-group has-feedback col-sm-8"">
                ");
            EndContext();
            BeginContext(1051, 150, false);
#line 27 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Customer\ACustomer.cshtml"
           Write(Html.TextBoxFor(m => m.CustomerName, new { @class = "form-control input-group", placeholder = "Customer Name", type = "text", required = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(1201, 55, true);
            WriteLiteral("\r\n                <div class=\"form-control-feedback\"><i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1256, "\"", 1264, 0);
            EndWriteAttribute();
            BeginContext(1265, 246, true);
            WriteLiteral("></i></div>\r\n            </div>\r\n        </div>\r\n\r\n\r\n\r\n        <div class=\"form-group form-group-xs\">\r\n            <label class=\"control-label col-sm-4\">Address</label>\r\n            <div class=\"form-group has-feedback col-sm-8\">\r\n                ");
            EndContext();
            BeginContext(1512, 116, false);
#line 37 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Customer\ACustomer.cshtml"
           Write(Html.TextBoxFor(m => m.Address, new { @class = "form-control input-group", placeholder = "Address", type = "text" }));

#line default
#line hidden
            EndContext();
            BeginContext(1628, 55, true);
            WriteLiteral("\r\n                <div class=\"form-control-feedback\"><i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1683, "\"", 1691, 0);
            EndWriteAttribute();
            BeginContext(1692, 243, true);
            WriteLiteral("></i></div>\r\n            </div>\r\n        </div>\r\n\r\n\r\n        <div class=\"form-group form-group-xs\">\r\n            <label class=\"control-label col-sm-4\">Mobile</label>\r\n            <div class=\"form-group has-feedback col-sm-8\">\r\n                ");
            EndContext();
            BeginContext(1936, 118, false);
#line 46 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Customer\ACustomer.cshtml"
           Write(Html.TextBoxFor(m => m.MobileNo, new { @class = "form-control input-group", placeholder = "MobileNo", type = "text" }));

#line default
#line hidden
            EndContext();
            BeginContext(2054, 55, true);
            WriteLiteral("\r\n                <div class=\"form-control-feedback\"><i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2109, "\"", 2117, 0);
            EndWriteAttribute();
            BeginContext(2118, 242, true);
            WriteLiteral("></i></div>\r\n            </div>\r\n        </div>\r\n\r\n\r\n        <div class=\"form-group form-group-xs\">\r\n            <label class=\"control-label col-sm-4\">Phone</label>\r\n            <div class=\"form-group has-feedback col-sm-8\">\r\n                ");
            EndContext();
            BeginContext(2361, 116, false);
#line 55 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Customer\ACustomer.cshtml"
           Write(Html.TextBoxFor(m => m.PhoneNo, new { @class = "form-control input-group", placeholder = "PhoneNo", type = "text" }));

#line default
#line hidden
            EndContext();
            BeginContext(2477, 55, true);
            WriteLiteral("\r\n                <div class=\"form-control-feedback\"><i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2532, "\"", 2540, 0);
            EndWriteAttribute();
            BeginContext(2541, 243, true);
            WriteLiteral("></i></div>\r\n            </div>\r\n        </div>\r\n\r\n\r\n        <div class=\"form-group form-group-xs\">\r\n            <label class=\"control-label col-sm-4\">NTN No</label>\r\n            <div class=\"form-group has-feedback col-sm-8\">\r\n                ");
            EndContext();
            BeginContext(2785, 112, false);
#line 64 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Customer\ACustomer.cshtml"
           Write(Html.TextBoxFor(m => m.NTNNo, new { @class = "form-control input-group", placeholder = "NTNNo", type = "text" }));

#line default
#line hidden
            EndContext();
            BeginContext(2897, 55, true);
            WriteLiteral("\r\n                <div class=\"form-control-feedback\"><i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2952, "\"", 2960, 0);
            EndWriteAttribute();
            BeginContext(2961, 449, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SMSERP.Areas.Master.Models.Customer> Html { get; private set; }
    }
}
#pragma warning restore 1591
