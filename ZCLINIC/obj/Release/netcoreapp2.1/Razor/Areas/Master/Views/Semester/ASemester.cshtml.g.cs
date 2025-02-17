#pragma checksum "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Semester\ASemester.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "293bdfd54c382b5908a45a4c729ac78eb4c19731"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Master_Views_Semester_ASemester), @"mvc.1.0.view", @"/Areas/Master/Views/Semester/ASemester.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Master/Views/Semester/ASemester.cshtml", typeof(AspNetCore.Areas_Master_Views_Semester_ASemester))]
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
#line 3 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Semester\ASemester.cshtml"
using SMSERP;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"293bdfd54c382b5908a45a4c729ac78eb4c19731", @"/Areas/Master/Views/Semester/ASemester.cshtml")]
    public class Areas_Master_Views_Semester_ASemester : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SMSERP.Areas.Master.Models.Semester>
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
#line 6 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Semester\ASemester.cshtml"
  
    string URL = Model == null ? "/Master/Semester/SaveSemester" : "/Master/Semester/UpdateSemester";

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
#line 10 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Semester\ASemester.cshtml"
                                                       Write(URL);

#line default
#line hidden
            EndContext();
            BeginContext(241, 61, true);
            WriteLiteral("\" data-display=\"Master\" data-rurl=\"/Master/Semester\">\r\n\r\n    ");
            EndContext();
            BeginContext(303, 25, false);
#line 12 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Semester\ASemester.cshtml"
Write(Html.HiddenFor(m => m.Id));

#line default
#line hidden
            EndContext();
            BeginContext(328, 263, true);
            WriteLiteral(@"

    <div class=""row"">


        <div class=""form-group form-group-xs"">
            <label class=""control-label col-sm-4"">Semester Name <b class=""wysiwyg-color-red"">*</b></label>
            <div class=""form-group has-feedback col-sm-8"">
                ");
            EndContext();
            BeginContext(592, 144, false);
#line 20 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Semester\ASemester.cshtml"
           Write(Html.TextBoxFor(m => m.SName, new { @class = "form-control input-group", placeholder = "Semester  Name", type = "text", required = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(736, 55, true);
            WriteLiteral("\r\n                <div class=\"form-control-feedback\"><i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 791, "\"", 799, 0);
            EndWriteAttribute();
            BeginContext(800, 57, true);
            WriteLiteral("></i></div>\r\n            </div>\r\n        </div>\r\n\r\n\r\n\r\n\r\n");
            EndContext();
            BeginContext(1523, 215, true);
            WriteLiteral("\r\n        <div class=\"form-group form-group-xs\">\r\n            <label class=\"control-label col-sm-4\">Fiscal Year<b class=\"wysiwyg-color-red\">*</b></label>\r\n            <div class=\"form-group has-feedback col-sm-8\">\r\n");
            EndContext();
#line 44 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Semester\ASemester.cshtml"
                  


                    List<SMSERP.Areas.Master.Models.Fiscal> Fiscal = new SMSERP.Areas.Master.Models.Fiscal().Master_FiscalGetAll(Context.Session.GetBValues(), Context.GetIP(), Context.GetCInfo());
                    Fiscal.Insert(0, new SMSERP.Areas.Master.Models.Fiscal { FId = 0, FName = "Select Fiscal  Name" });
                

#line default
#line hidden
            BeginContext(2100, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(2117, 145, false);
#line 50 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Master\Views\Semester\ASemester.cshtml"
           Write(Html.DropDownList("SId", Fiscal.Select(s => new SelectListItem() { Text = s.FName, Value = s.FId.ToString() }), new { @class = "form-control " }));

#line default
#line hidden
            EndContext();
            BeginContext(2262, 57, true);
            WriteLiteral("\r\n\r\n                <div class=\"form-control-feedback\"><i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2319, "\"", 2327, 0);
            EndWriteAttribute();
            BeginContext(2328, 465, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SMSERP.Areas.Master.Models.Semester> Html { get; private set; }
    }
}
#pragma warning restore 1591
