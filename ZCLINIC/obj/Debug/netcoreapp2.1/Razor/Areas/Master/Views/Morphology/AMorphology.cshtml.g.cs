#pragma checksum "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\Morphology\AMorphology.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "262592a218fd5587ee2765ef1441470e41c8747a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Master_Views_Morphology_AMorphology), @"mvc.1.0.view", @"/Areas/Master/Views/Morphology/AMorphology.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Master/Views/Morphology/AMorphology.cshtml", typeof(AspNetCore.Areas_Master_Views_Morphology_AMorphology))]
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
#line 3 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\Morphology\AMorphology.cshtml"
using ZCLINIC;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"262592a218fd5587ee2765ef1441470e41c8747a", @"/Areas/Master/Views/Morphology/AMorphology.cshtml")]
    public class Areas_Master_Views_Morphology_AMorphology : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ZCLINIC.Areas.Master.Models.Morphology>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(67, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\Morphology\AMorphology.cshtml"
  
    string URL = Model == null ? "/Master/Morphology/SaveMorphology" : "/Master/Morphology/UpdateMorphology";

#line default
#line hidden
            BeginContext(187, 45, true);
            WriteLiteral("\r\n<form class=\"form-horizontal\" method=\"post\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 232, "\"", 237, 0);
            EndWriteAttribute();
            BeginContext(238, 11, true);
            WriteLiteral(" data-url=\"");
            EndContext();
            BeginContext(250, 3, false);
#line 10 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\Morphology\AMorphology.cshtml"
                                                       Write(URL);

#line default
#line hidden
            EndContext();
            BeginContext(253, 63, true);
            WriteLiteral("\" data-display=\"Master\" data-rurl=\"/Master/Morphology\">\r\n\r\n    ");
            EndContext();
            BeginContext(317, 25, false);
#line 12 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\Morphology\AMorphology.cshtml"
Write(Html.HiddenFor(m => m.Id));

#line default
#line hidden
            EndContext();
            BeginContext(342, 267, true);
            WriteLiteral(@"

    <div class=""row"">


       

        <div class=""form-group form-group-xs"">

            <label class=""control-label col-sm-4"">Name <b class=""wysiwyg-color-red"">*</b></label>
            <div class=""form-group has-feedback col-sm-8"">
                ");
            EndContext();
            BeginContext(610, 134, false);
#line 23 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\Morphology\AMorphology.cshtml"
           Write(Html.TextBoxFor(m => m.MName, new { @class = "form-control input-group", placeholder = "Name", type = "text", required = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(744, 55, true);
            WriteLiteral("\r\n                <div class=\"form-control-feedback\"><i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 799, "\"", 807, 0);
            EndWriteAttribute();
            BeginContext(808, 460, true);
            WriteLiteral(@"></i></div>
            </div>
        </div>
























        <div class=""modal-footer no-padding no-border"">
            <button type=""button"" class=""btn btn-danger btn-xs"" data-dismiss=""modal""><i class=""icon-cross""></i>Close</button>
            <button type=""button"" data-submit=""true"" class=""btn btn-primary btn-xs""><i class=""icon-floppy-disk position-left""></i>Save</button>
        </div>

    </div>


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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ZCLINIC.Areas.Master.Models.Morphology> Html { get; private set; }
    }
}
#pragma warning restore 1591
