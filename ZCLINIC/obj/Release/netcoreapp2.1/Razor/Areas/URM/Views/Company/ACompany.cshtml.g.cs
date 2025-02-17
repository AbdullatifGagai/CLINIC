#pragma checksum "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\URM\Views\Company\ACompany.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dca369764f1238f00029fc666f28cd6724408655"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_URM_Views_Company_ACompany), @"mvc.1.0.view", @"/Areas/URM/Views/Company/ACompany.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/URM/Views/Company/ACompany.cshtml", typeof(AspNetCore.Areas_URM_Views_Company_ACompany))]
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
#line 3 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\URM\Views\Company\ACompany.cshtml"
using SMSERP;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dca369764f1238f00029fc666f28cd6724408655", @"/Areas/URM/Views/Company/ACompany.cshtml")]
    public class Areas_URM_Views_Company_ACompany : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SMSERP.Areas.URM.Models.Company>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\URM\Views\Company\ACompany.cshtml"
  

    string URL = Model == null ? "/URM/Company/SaveCompany" : "/URM/Company/UpdateCompany";

    string image = Model == null || Model.Image_Picture == null ? "" : "data:image/png;base64," + Convert.ToBase64String(Model.Image_Picture);




#line default
#line hidden
            BeginContext(315, 45, true);
            WriteLiteral("\r\n<form class=\"form-horizontal\" method=\"post\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 360, "\"", 365, 0);
            EndWriteAttribute();
            BeginContext(366, 11, true);
            WriteLiteral(" data-url=\"");
            EndContext();
            BeginContext(378, 3, false);
#line 16 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\URM\Views\Company\ACompany.cshtml"
                                                       Write(URL);

#line default
#line hidden
            EndContext();
            BeginContext(381, 57, true);
            WriteLiteral("\" data-display=\"Master\" data-rurl=\"/URM/Company\">\r\n\r\n    ");
            EndContext();
            BeginContext(439, 31, false);
#line 18 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\URM\Views\Company\ACompany.cshtml"
Write(Html.HiddenFor(m => m.TenantId));

#line default
#line hidden
            EndContext();
            BeginContext(470, 415, true);
            WriteLiteral(@"
    <div class=""col-lg-12"">
        <div class=""col-lg-8"">

            <div class=""col-lg-10"">
                <div class=""row"">

                    <div class=""form-group form-group-xs"">
                        <label class=""control-label col-sm-4"">Company Id<b class=""wysiwyg-color-red"">*</b></label>
                        <div class=""form-group has-feedback col-sm-4"">
                            ");
            EndContext();
            BeginContext(886, 116, false);
#line 28 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\URM\Views\Company\ACompany.cshtml"
                       Write(Html.TextBoxFor(m => m.TenantId, new { @class = "form-control input-group", type = "text", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(1002, 67, true);
            WriteLiteral("\r\n                            <div class=\"form-control-feedback\"><i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1069, "\"", 1077, 0);
            EndWriteAttribute();
            BeginContext(1078, 354, true);
            WriteLiteral(@"></i></div>
                        </div>
                    </div>

                    <div class=""form-group form-group-xs"">
                        <label class=""control-label col-sm-4"">Company Name <b class=""wysiwyg-color-red"">*</b></label>
                        <div class=""form-group has-feedback col-sm-8"">
                            ");
            EndContext();
            BeginContext(1433, 148, false);
#line 36 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\URM\Views\Company\ACompany.cshtml"
                       Write(Html.TextBoxFor(m => m.CompanyName, new { @class = "form-control input-group", placeholder = "Company Name", type = "text", required = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(1581, 67, true);
            WriteLiteral("\r\n                            <div class=\"form-control-feedback\"><i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1648, "\"", 1656, 0);
            EndWriteAttribute();
            BeginContext(1657, 346, true);
            WriteLiteral(@"></i></div>
                        </div>
                    </div>
                    <div class=""form-group form-group-xs"">
                        <label class=""control-label col-sm-4"">Address<b class=""wysiwyg-color-red"">*</b></label>
                        <div class=""form-group has-feedback col-sm-8"">
                            ");
            EndContext();
            BeginContext(2004, 139, false);
#line 43 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\URM\Views\Company\ACompany.cshtml"
                       Write(Html.TextBoxFor(m => m.Address, new { @class = "form-control input-group", placeholder = "Address", type = "text", required = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(2143, 67, true);
            WriteLiteral("\r\n                            <div class=\"form-control-feedback\"><i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2210, "\"", 2218, 0);
            EndWriteAttribute();
            BeginContext(2219, 348, true);
            WriteLiteral(@"></i></div>
                        </div>
                    </div>

                    <div class=""form-group form-group-xs"">
                        <label class=""control-label col-sm-4"">PhoneNo<b class=""wysiwyg-color-red"">*</b></label>
                        <div class=""form-group has-feedback col-sm-8"">
                            ");
            EndContext();
            BeginContext(2568, 139, false);
#line 51 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\URM\Views\Company\ACompany.cshtml"
                       Write(Html.TextBoxFor(m => m.PhoneNo, new { @class = "form-control input-group", placeholder = "PhoneNo", type = "text", required = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(2707, 67, true);
            WriteLiteral("\r\n                            <div class=\"form-control-feedback\"><i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2774, "\"", 2782, 0);
            EndWriteAttribute();
            BeginContext(2783, 349, true);
            WriteLiteral(@"></i></div>
                        </div>
                    </div>


                    <div class=""form-group form-group-xs"">
                        <label class=""control-label col-sm-4"">CellNo<b class=""wysiwyg-color-red"">*</b></label>
                        <div class=""form-group has-feedback col-sm-8"">
                            ");
            EndContext();
            BeginContext(3133, 137, false);
#line 60 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\URM\Views\Company\ACompany.cshtml"
                       Write(Html.TextBoxFor(m => m.CellNo, new { @class = "form-control input-group", placeholder = "CellNo", type = "text", required = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(3270, 67, true);
            WriteLiteral("\r\n                            <div class=\"form-control-feedback\"><i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 3337, "\"", 3345, 0);
            EndWriteAttribute();
            BeginContext(3346, 346, true);
            WriteLiteral(@"></i></div>
                        </div>
                    </div>

                    <div class=""form-group form-group-xs"">
                        <label class=""control-label col-sm-4"">NTNNo<b class=""wysiwyg-color-red"">*</b></label>
                        <div class=""form-group has-feedback col-sm-8"">
                            ");
            EndContext();
            BeginContext(3693, 135, false);
#line 68 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\URM\Views\Company\ACompany.cshtml"
                       Write(Html.TextBoxFor(m => m.NTNNo, new { @class = "form-control input-group", placeholder = "NTNNo", type = "text", required = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(3828, 67, true);
            WriteLiteral("\r\n                            <div class=\"form-control-feedback\"><i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 3895, "\"", 3903, 0);
            EndWriteAttribute();
            BeginContext(3904, 350, true);
            WriteLiteral(@"></i></div>
                        </div>
                    </div>



                    <div class=""form-group form-group-xs"">
                        <label class=""control-label col-sm-4"">STRNO<b class=""wysiwyg-color-red"">*</b></label>
                        <div class=""form-group has-feedback col-sm-8"">
                            ");
            EndContext();
            BeginContext(4255, 135, false);
#line 78 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\URM\Views\Company\ACompany.cshtml"
                       Write(Html.TextBoxFor(m => m.STRNO, new { @class = "form-control input-group", placeholder = "STRNO", type = "text", required = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(4390, 67, true);
            WriteLiteral("\r\n                            <div class=\"form-control-feedback\"><i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 4457, "\"", 4465, 0);
            EndWriteAttribute();
            BeginContext(4466, 352, true);
            WriteLiteral(@"></i></div>
                        </div>
                    </div>

                    <div class=""form-group form-group-xs"">
                        <label class=""control-label col-sm-4"">Expair Date<b class=""wysiwyg-color-red"">*</b></label>
                        <div class=""form-group has-feedback col-sm-8"">
                            ");
            EndContext();
            BeginContext(4819, 101, false);
#line 86 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\URM\Views\Company\ACompany.cshtml"
                       Write(Html.TextBoxFor(m => m.Exdate, new { @class = "form-control", type = "date", required = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(4920, 67, true);
            WriteLiteral("\r\n                            <div class=\"form-control-feedback\"><i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 4987, "\"", 4995, 0);
            EndWriteAttribute();
            BeginContext(4996, 348, true);
            WriteLiteral(@"></i></div>
                        </div>
                    </div>


                    <div class=""form-group form-group-xs"">
                        <label class=""control-label col-sm-4"">AppId<b class=""wysiwyg-color-red"">*</b></label>
                        <div class=""form-group has-feedback col-sm-8"">
                            ");
            EndContext();
            BeginContext(5345, 135, false);
#line 95 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\URM\Views\Company\ACompany.cshtml"
                       Write(Html.TextBoxFor(m => m.AppId, new { @class = "form-control input-group", placeholder = "STRNO", type = "text", required = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(5480, 67, true);
            WriteLiteral("\r\n                            <div class=\"form-control-feedback\"><i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 5547, "\"", 5555, 0);
            EndWriteAttribute();
            BeginContext(5556, 209, true);
            WriteLiteral("></i></div>\r\n                        </div>\r\n                    </div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n                </div>\r\n            </div>\r\n\r\n\r\n\r\n        </div>\r\n\r\n\r\n\r\n\r\n        <div class=\"col-lg-4\">\r\n\r\n            ");
            EndContext();
            BeginContext(5766, 27, false);
#line 119 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\URM\Views\Company\ACompany.cshtml"
       Write(Html.HiddenFor(m => m.Logo));

#line default
#line hidden
            EndContext();
            BeginContext(5793, 3162, true);
            WriteLiteral(@"

            <div class=""col-lg-12"">


         
                <div class=""form-group col-sm-9"">
                    <input type=""file"" class=""file-input"" data-show-remove=""true"" accept=""image/*"" data-show-upload=""false"" data-show-caption=""false"" data-browse-class=""btn bg-slate btn-xs"" data-remove-class=""btn btn-warning btn-xs"" />
                </div>
            </div>

        </div>


           
        
    </div>


        <div class=""modal-footer no-padding no-border"">
            <button type=""button"" class=""btn btn-danger btn-xs"" data-dismiss=""modal""><i class=""icon-cross""></i>Close</button>
            <button type=""button"" data-submit=""true"" class=""btn btn-primary btn-xs""><i class=""icon-floppy-disk position-left""></i>Save</button>
        </div>



</form>
<script>


   // document.getElementById('Exdate').valueAsDate = new Date();


    if ($('#TenantId').val() > 0) {

       
    }
    else {

        document.getElementById('Exdate').valueAsDate = new D");
            WriteLiteral(@"ate();


        //$('#UserName').val($('#personName').text());
        //$('#UserId').val($('#personId').val())


    }



    $('.file-input').change(function (e) {

        debugger;
        if (this.files.length == 0) {
            $('#Logo').val("""");

            return;
        }



        var filename = e.target.value;

        var allowed_extensions = new Array(""jpg"", ""png"", ""jpeg"");
        var file_extension = filename.split('.').pop().toLowerCase();
        var result = false;
        for (var i = 0; i <= allowed_extensions.length; i++) {
            if (allowed_extensions[i] == file_extension) {
                result = true;
                break;
            } else {
                result = false
            }
        }
        if (result === false) {
            ErrorAlert(""Upload Only Image"")
        } else {


            var formData = new FormData();
            formData.append(""file"", e.target.files[0]);
            $.ajax({
                url:");
            WriteLiteral(@" ""/URM/Company/UploadImage"",
                type: 'POST',
                cache: false,
                contentType: false,
                processData: false,
                data: formData,
                success: function (response) {
                    $('#Logo').val(response);


                }
            });



        }



    })


    var image = $('#Logo').val() == """" || $('#Logo').val() == null ? """" : ""/Logo/"" + $('#Logo').val()






    //var image = $('#PhotoPath').val() == """" || $('#PhotoPath').val() == null ? """" : ""D:/Photo/cc4b1277-74e9-4fd5-b2f7-bacbc1613716_5d079167-28a9-4db0-b579-94ffaabf7889_tree-736885__480.jpg""

    debugger;
    $('.file-input').fileinput({
        browseLabel: 'Select',
        browseIcon: '<i class=""icon-image2 position-left""></i>',
        removeIcon: '<i class=""icon-cross3""></i>',
        initialPreview: image,
        initialPreviewAsData: true,

    });
    $('body').find('.fileinput-remove,.fileinput-remove-button').c");
            WriteLiteral("lick(function () {\r\n        $(\'#Logo\').val(\"\");\r\n    })\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SMSERP.Areas.URM.Models.Company> Html { get; private set; }
    }
}
#pragma warning restore 1591
