#pragma checksum "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\InstallmentVoucher\AInstallmentVoucher.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7b1be7cfb7c50797019c8bcf7d810edb75baa72"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Transaction_Views_InstallmentVoucher_AInstallmentVoucher), @"mvc.1.0.view", @"/Areas/Transaction/Views/InstallmentVoucher/AInstallmentVoucher.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Transaction/Views/InstallmentVoucher/AInstallmentVoucher.cshtml", typeof(AspNetCore.Areas_Transaction_Views_InstallmentVoucher_AInstallmentVoucher))]
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
#line 1 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\InstallmentVoucher\AInstallmentVoucher.cshtml"
using ZCLINIC;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7b1be7cfb7c50797019c8bcf7d810edb75baa72", @"/Areas/Transaction/Views/InstallmentVoucher/AInstallmentVoucher.cshtml")]
    public class Areas_Transaction_Views_InstallmentVoucher_AInstallmentVoucher : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ZCLINIC.Areas.Transaction.Models.InstallmentVoucher>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(76, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\InstallmentVoucher\AInstallmentVoucher.cshtml"
  
    string URL = Model == null ? "/Transaction/InstallmentVoucher/SaveInstallmentVoucher" : "/Transaction/InstallmentVoucher/UpdateInstallmentVoucher";
    int counter = 0;

#line default
#line hidden
            BeginContext(260, 373, true);
            WriteLiteral(@"
<style>
    /*Remove Arrows/Spinners from type number*/
    /* Chrome, Safari, Edge, Opera */
    input::-webkit-outer-spin-button,
    input::-webkit-inner-spin-button {
        -webkit-appearance: none;
        margin: 0;
    }

    /* Firefox */
    input[type=number] {
        -moz-appearance: textfield;
    }
</style>

<form method=""post"" data-url=""");
            EndContext();
            BeginContext(634, 3, false);
#line 24 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\InstallmentVoucher\AInstallmentVoucher.cshtml"
                         Write(URL);

#line default
#line hidden
            EndContext();
            BeginContext(637, 162, true);
            WriteLiteral("\" data-rurl=\"/Transaction/InstallmentVoucher\" data-script=\"/assets/Areas/Transaction/InstallmentVoucher/Index.js\" data-display=\"Bank Payment Voucher\">\r\n\r\n\r\n\r\n    ");
            EndContext();
            BeginContext(800, 28, false);
#line 28 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\InstallmentVoucher\AInstallmentVoucher.cshtml"
Write(Html.HiddenFor(m => m.InsId));

#line default
#line hidden
            EndContext();
            BeginContext(828, 8, true);
            WriteLiteral("\r\n\r\n    ");
            EndContext();
            BeginContext(837, 27, false);
#line 30 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\InstallmentVoucher\AInstallmentVoucher.cshtml"
Write(Html.HiddenFor(m => m.GrId));

#line default
#line hidden
            EndContext();
            BeginContext(864, 256, true);
            WriteLiteral(@"



    <div class=""row"">



        <div class=""form-group form-group-xs col-md-12"">




            <div class=""form-group form-group-xs col-md-3"">
                <label>Receipt No<b class=""wysiwyg-color-red""></b></label>
                ");
            EndContext();
            BeginContext(1121, 103, false);
#line 45 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\InstallmentVoucher\AInstallmentVoucher.cshtml"
           Write(Html.TextBoxFor(m => m.InsCode, new { @class = "form-control", type = "text", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(1224, 171, true);
            WriteLiteral("\r\n\r\n            </div>\r\n            <div class=\"form-group form-group-xs col-md-4\">\r\n                <label>Date<b class=\"wysiwyg-color-red\"></b></label>\r\n                ");
            EndContext();
            BeginContext(1396, 79, false);
#line 50 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\InstallmentVoucher\AInstallmentVoucher.cshtml"
           Write(Html.TextBoxFor(m => m.InsDate, new { @class = "form-control", type = "date" }));

#line default
#line hidden
            EndContext();
            BeginContext(1475, 177, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n            <div class=\"form-group form-group-xs col-md-4\">\r\n                <label>Due Date<b class=\"wysiwyg-color-red\"></b></label>\r\n                ");
            EndContext();
            BeginContext(1653, 82, false);
#line 56 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\InstallmentVoucher\AInstallmentVoucher.cshtml"
           Write(Html.TextBoxFor(m => m.IntDueDate, new { @class = "form-control", type = "date" }));

#line default
#line hidden
            EndContext();
            BeginContext(1735, 312, true);
            WriteLiteral(@"

            </div>








        </div>
    </div>


    <div class=""row"">



        <div class=""form-group form-group-xs col-md-12"">



            <div class=""form-group form-group-xs col-md-4"">
                <label>GRNO<b class=""wysiwyg-color-red""></b></label>
                ");
            EndContext();
            BeginContext(2048, 100, false);
#line 81 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\InstallmentVoucher\AInstallmentVoucher.cshtml"
           Write(Html.TextBoxFor(m => m.Grno, new { @class = "form-control", type = "text", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(2148, 181, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n            <div class=\"form-group form-group-xs col-md-4\">\r\n                <label>Student Name<b class=\"wysiwyg-color-red\"></b></label>\r\n                ");
            EndContext();
            BeginContext(2330, 100, false);
#line 87 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\InstallmentVoucher\AInstallmentVoucher.cshtml"
           Write(Html.TextBoxFor(m => m.Name, new { @class = "form-control", type = "text", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(2430, 529, true);
            WriteLiteral(@"

            </div>




            <div class=""form-group form-group-xs mt-20 col-md-1"">
                <a class=""btn btn-info btn-sm"" id=""AddItemBtn"" data-script=""#""><i class=""icon-add mr-5""></i>Student</a>
            </div>









        </div>
    </div>

    <div class=""row"">



        <div class=""form-group form-group-xs col-md-12"">



            <div class=""form-group form-group-xs col-md-4"">
                <label>Month<b class=""wysiwyg-color-red""></b></label>
                ");
            EndContext();
            BeginContext(2960, 80, false);
#line 119 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\InstallmentVoucher\AInstallmentVoucher.cshtml"
           Write(Html.TextBoxFor(m => m.IntMonth, new { @class = "form-control", type = "text" }));

#line default
#line hidden
            EndContext();
            BeginContext(3040, 181, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n            <div class=\"form-group form-group-xs col-md-6\">\r\n                <label>Discription <b class=\"wysiwyg-color-red\"></b></label>\r\n                ");
            EndContext();
            BeginContext(3222, 86, false);
#line 125 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\InstallmentVoucher\AInstallmentVoucher.cshtml"
           Write(Html.TextBoxFor(m => m.IntDiscription, new { @class = "form-control", type = "text" }));

#line default
#line hidden
            EndContext();
            BeginContext(3308, 180, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n\r\n\r\n            <div class=\"form-group form-group-xs col-md-2\">\r\n                <label>Amount <b class=\"wysiwyg-color-red\"></b></label>\r\n                ");
            EndContext();
            BeginContext(3489, 80, false);
#line 133 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\InstallmentVoucher\AInstallmentVoucher.cshtml"
           Write(Html.TextBoxFor(m => m.IntAmt, new { @class = "form-control", type = "Number" }));

#line default
#line hidden
            EndContext();
            BeginContext(3569, 291, true);
            WriteLiteral(@"

            </div>





            <div class=""row"">



                <div class=""form-group form-group-xs col-md-12"">

                    <div class=""form-group form-group-xs col-md-6"">
                        <label>Bank Name<b class=""wysiwyg-color-red""></b></label>
");
            EndContext();
#line 149 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\InstallmentVoucher\AInstallmentVoucher.cshtml"
                          
                            List<ZCLINIC.Areas.Master.Models.Master_SubAccount> SubAcc = new ZCLINIC.Areas.Master.Models.Master_SubAccount().Master_SubAccountGetBankMaster(Context.Session.GetBValues(), Context.GetIP(), Context.GetCInfo());

                        

#line default
#line hidden
            BeginContext(4158, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(4183, 160, false);
#line 153 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\InstallmentVoucher\AInstallmentVoucher.cshtml"
                   Write(Html.DropDownList("IntBankId", SubAcc.Select(s => new SelectListItem() { Text = s.Subacc_Name, Value = s.Com_id.ToString() }), new { @class = "form-control " }));

#line default
#line hidden
            EndContext();
            BeginContext(4343, 191, true);
            WriteLiteral("\r\n\r\n                    </div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n                </div>\r\n            </div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n        </div>\r\n    </div>\r\n    <div style=\"display:none;\">\r\n\r\n\r\n");
            EndContext();
            BeginContext(4787, 403, true);
            WriteLiteral(@"











    </div>


















    <div class=""modal-footer mt-10 no-padding no-border"">



        <button type=""button"" class=""btn btn-danger btn-xs"" data-dismiss=""modal""><i class=""icon-cross""></i>Close</button>
        <button type=""button"" data-submit=""true"" class=""btn btn-primary  btn-xs ""><i class=""icon-floppy-disk position-left""></i>Save</button>
");
            EndContext();
            BeginContext(5340, 25, true);
            WriteLiteral("\r\n    </div>\r\n\r\n</form>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ZCLINIC.Areas.Transaction.Models.InstallmentVoucher> Html { get; private set; }
    }
}
#pragma warning restore 1591