#pragma checksum "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\ClinicServices\AClinicServices.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c72ebf37d783524e7da6e5be0b4dbf6db5d8848"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Master_Views_ClinicServices_AClinicServices), @"mvc.1.0.view", @"/Areas/Master/Views/ClinicServices/AClinicServices.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Master/Views/ClinicServices/AClinicServices.cshtml", typeof(AspNetCore.Areas_Master_Views_ClinicServices_AClinicServices))]
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
#line 3 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\ClinicServices\AClinicServices.cshtml"
using ZCLINIC;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c72ebf37d783524e7da6e5be0b4dbf6db5d8848", @"/Areas/Master/Views/ClinicServices/AClinicServices.cshtml")]
    public class Areas_Master_Views_ClinicServices_AClinicServices : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ZCLINIC.Areas.Master.Models.ClinicServices>
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
#line 6 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\ClinicServices\AClinicServices.cshtml"
  
    string URL = Model == null ? "/Master/ClinicServices/SaveClinicServices" : "/Master/ClinicServices/UpdateClinicServices";

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
#line 10 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\ClinicServices\AClinicServices.cshtml"
                                                       Write(URL);

#line default
#line hidden
            EndContext();
            BeginContext(273, 67, true);
            WriteLiteral("\" data-display=\"Master\" data-rurl=\"/Master/ClinicServices\">\r\n\r\n    ");
            EndContext();
            BeginContext(341, 33, false);
#line 12 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\ClinicServices\AClinicServices.cshtml"
Write(Html.HiddenFor(m => m.CategoryId));

#line default
#line hidden
            EndContext();
            BeginContext(374, 257, true);
            WriteLiteral(@"

    <div class=""row"">

        <div class=""form-group form-group-xs"">
            <label class=""control-label col-sm-4"">Servies Id<b class=""wysiwyg-color-red"">*</b></label>
            <div class=""form-group has-feedback col-sm-4"">
                ");
            EndContext();
            BeginContext(632, 120, false);
#line 19 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\ClinicServices\AClinicServices.cshtml"
           Write(Html.TextBoxFor(m => m.ServicesCode, new { @class = "form-control input-group", type = "text", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(752, 55, true);
            WriteLiteral("\r\n                <div class=\"form-control-feedback\"><i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 807, "\"", 815, 0);
            EndWriteAttribute();
            BeginContext(816, 283, true);
            WriteLiteral(@"></i></div>
            </div>
        </div>

        <div class=""form-group form-group-xs"">
            <label class=""control-label col-sm-4"">Services Name <b class=""wysiwyg-color-red"">*</b></label>
            <div class=""form-group has-feedback col-sm-8"">
                ");
            EndContext();
            BeginContext(1100, 149, false);
#line 27 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\ClinicServices\AClinicServices.cshtml"
           Write(Html.TextBoxFor(m => m.ServicesName, new { @class = "form-control input-group", placeholder = "Servies Name", type = "text", required = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(1249, 55, true);
            WriteLiteral("\r\n                <div class=\"form-control-feedback\"><i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1304, "\"", 1312, 0);
            EndWriteAttribute();
            BeginContext(1313, 268, true);
            WriteLiteral(@"></i></div>
            </div>
        </div>

        <div class=""form-group form-group-xs"">
            <label class=""control-label col-sm-4"">Category  Name <b class=""wysiwyg-color-red"">*</b></label>
            <div class=""form-group has-feedback col-sm-8"">
");
            EndContext();
#line 35 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\ClinicServices\AClinicServices.cshtml"
                  
                    List<ZCLINIC.Areas.Master.Models.ClinicCategory> ClinicCategory = new ZCLINIC.Areas.Master.Models.ClinicCategory().Master_ClinicCategoryGetAll(Context.Session.GetBValues(), Context.GetIP(), Context.GetCInfo());

                

#line default
#line hidden
            BeginContext(1854, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(1871, 174, false);
#line 39 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\ClinicServices\AClinicServices.cshtml"
           Write(Html.DropDownList("CategoryId", ClinicCategory.Select(s => new SelectListItem() { Text = s.CategoryName, Value = s.CategoryId.ToString() }), new { @class = "form-control " }));

#line default
#line hidden
            EndContext();
            BeginContext(2045, 65, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n                <div class=\"form-control-feedback\"><i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2110, "\"", 2118, 0);
            EndWriteAttribute();
            BeginContext(2119, 273, true);
            WriteLiteral(@"></i></div>
            </div>
        </div>

        <div class=""form-group form-group-xs"">
            <label class=""control-label col-sm-4"">Rate<b class=""wysiwyg-color-red"">*</b></label>
            <div class=""form-group has-feedback col-sm-8"">
                ");
            EndContext();
            BeginContext(2393, 133, false);
#line 52 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\ClinicServices\AClinicServices.cshtml"
           Write(Html.TextBoxFor(m => m.Rate, new { @class = "form-control input-group", placeholder = "Rate", type = "text", required = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(2526, 55, true);
            WriteLiteral("\r\n                <div class=\"form-control-feedback\"><i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2581, "\"", 2589, 0);
            EndWriteAttribute();
            BeginContext(2590, 429, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ZCLINIC.Areas.Master.Models.ClinicServices> Html { get; private set; }
    }
}
#pragma warning restore 1591