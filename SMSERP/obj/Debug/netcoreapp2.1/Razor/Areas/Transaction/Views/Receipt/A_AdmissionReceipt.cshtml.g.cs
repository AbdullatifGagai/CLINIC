#pragma checksum "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\Receipt\A_AdmissionReceipt.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e21a26fbfc3d26cdb615ea3b95a4041a61db71c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Transaction_Views_Receipt_A_AdmissionReceipt), @"mvc.1.0.view", @"/Areas/Transaction/Views/Receipt/A_AdmissionReceipt.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Transaction/Views/Receipt/A_AdmissionReceipt.cshtml", typeof(AspNetCore.Areas_Transaction_Views_Receipt_A_AdmissionReceipt))]
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
#line 1 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\Receipt\A_AdmissionReceipt.cshtml"
using ZCLINIC;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e21a26fbfc3d26cdb615ea3b95a4041a61db71c7", @"/Areas/Transaction/Views/Receipt/A_AdmissionReceipt.cshtml")]
    public class Areas_Transaction_Views_Receipt_A_AdmissionReceipt : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ZCLINIC.Areas.Transaction.Models.Receipt>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(65, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\Receipt\A_AdmissionReceipt.cshtml"
  
    string URL = Model == null ? "/Transaction/Receipt/SaveReceipt" : "/Transaction/Receipt/UpdateReceipt";
    int counter = 0;

#line default
#line hidden
            BeginContext(205, 373, true);
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
            BeginContext(579, 3, false);
#line 24 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\Receipt\A_AdmissionReceipt.cshtml"
                         Write(URL);

#line default
#line hidden
            EndContext();
            BeginContext(582, 83, true);
            WriteLiteral("\" data-rurl=\"/Transaction/Receipt\" data-display=\"Bank Payment Voucher\">\r\n\r\n\r\n\r\n    ");
            EndContext();
            BeginContext(666, 32, false);
#line 28 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\Receipt\A_AdmissionReceipt.cshtml"
Write(Html.HiddenFor(m => m.ReceiptId));

#line default
#line hidden
            EndContext();
            BeginContext(698, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(705, 30, false);
#line 29 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\Receipt\A_AdmissionReceipt.cshtml"
Write(Html.HiddenFor(m => m.PanelId));

#line default
#line hidden
            EndContext();
            BeginContext(735, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(742, 27, false);
#line 30 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\Receipt\A_AdmissionReceipt.cshtml"
Write(Html.HiddenFor(m => m.GrId));

#line default
#line hidden
            EndContext();
            BeginContext(769, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(776, 28, false);
#line 31 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\Receipt\A_AdmissionReceipt.cshtml"
Write(Html.HiddenFor(m => m.MonId));

#line default
#line hidden
            EndContext();
            BeginContext(804, 256, true);
            WriteLiteral(@"



    <div class=""row"">



        <div class=""form-group form-group-xs col-md-12"">




            <div class=""form-group form-group-xs col-md-2"">
                <label>Receipt No<b class=""wysiwyg-color-red""></b></label>
                ");
            EndContext();
            BeginContext(1061, 107, false);
#line 46 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\Receipt\A_AdmissionReceipt.cshtml"
           Write(Html.TextBoxFor(m => m.ReceiptCode, new { @class = "form-control", type = "text", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(1168, 171, true);
            WriteLiteral("\r\n\r\n            </div>\r\n            <div class=\"form-group form-group-xs col-md-2\">\r\n                <label>GRNO<b class=\"wysiwyg-color-red\"></b></label>\r\n                ");
            EndContext();
            BeginContext(1340, 100, false);
#line 51 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\Receipt\A_AdmissionReceipt.cshtml"
           Write(Html.TextBoxFor(m => m.GRNo, new { @class = "form-control", type = "text", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(1440, 184, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n\r\n            <div class=\"form-group form-group-xs col-md-2\">\r\n                <label>Receipt  Date<b class=\"wysiwyg-color-red\"></b></label>\r\n                ");
            EndContext();
            BeginContext(1625, 77, false);
#line 58 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\Receipt\A_AdmissionReceipt.cshtml"
           Write(Html.TextBoxFor(m => m.RDate, new { @class = "form-control", type = "date" }));

#line default
#line hidden
            EndContext();
            BeginContext(1702, 175, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n\r\n            <div class=\"form-group form-group-xs col-md-3\">\r\n                <label>Name<b class=\"wysiwyg-color-red\"></b></label>\r\n                ");
            EndContext();
            BeginContext(1878, 100, false);
#line 65 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\Receipt\A_AdmissionReceipt.cshtml"
           Write(Html.TextBoxFor(m => m.Name, new { @class = "form-control", type = "text", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(1978, 182, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n\r\n            <div class=\"form-group form-group-xs col-md-3\">\r\n                <label>Father Name<b class=\"wysiwyg-color-red\"></b></label>\r\n                ");
            EndContext();
            BeginContext(2161, 106, false);
#line 72 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\Receipt\A_AdmissionReceipt.cshtml"
           Write(Html.TextBoxFor(m => m.FatherName, new { @class = "form-control", type = "text", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(2267, 314, true);
            WriteLiteral(@"

            </div>








        </div>
    </div>


    <div class=""row"">



        <div class=""form-group form-group-xs col-md-12"">



            <div class=""form-group form-group-xs col-md-2"">
                <label>Amount<b class=""wysiwyg-color-red""></b></label>
                ");
            EndContext();
            BeginContext(2582, 75, false);
#line 97 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\Receipt\A_AdmissionReceipt.cshtml"
           Write(Html.TextBoxFor(m => m.Amt, new { @class = "form-control", type = "text" }));

#line default
#line hidden
            EndContext();
            BeginContext(2657, 174, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n            <div class=\"form-group form-group-xs col-md-2\">\r\n                <label>RefId<b class=\"wysiwyg-color-red\"></b></label>\r\n                ");
            EndContext();
            BeginContext(2832, 101, false);
#line 103 "C:\Users\Administrator\Documents\GitHub\CLINIC\SMSERP\Areas\Transaction\Views\Receipt\A_AdmissionReceipt.cshtml"
           Write(Html.TextBoxFor(m => m.RefId, new { @class = "form-control", type = "text", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(2933, 407, true);
            WriteLiteral(@"

            </div>









        </div>
    </div>



    <div class=""modal-footer mt-10 no-padding no-border"">



        <button type=""button"" class=""btn btn-danger btn-xs"" data-dismiss=""modal""><i class=""icon-cross""></i>Close</button>
        <button type=""button"" data-submit=""true"" class=""btn btn-primary  btn-xs ""><i class=""icon-floppy-disk position-left""></i>Save</button>
");
            EndContext();
            BeginContext(3490, 53, true);
            WriteLiteral("\r\n    </div>\r\n\r\n    <div style=\"display:none;\">\r\n\r\n\r\n");
            EndContext();
            BeginContext(3796, 1320, true);
            WriteLiteral(@"











    </div>

    <div class=""clearfix""></div>


    <div class=""panel-body form-group panel panel-flat mt-5"" style=""height:250px; width:100%; overflow-y:auto;"" id=""table-div"">


        <div class=""table-responsive container-fluid quotaiontable"">
            <table class=""table table-xxs table-md table-bordered table-striped table-hover bg-lightgray dataTables_scrollBody"">
                <thead>
                    <tr class=""bg-blue-800"">

                        <th>Challan No</th>
                        <th>Month Name</th>
                        <th>Voucher Mode</th>
                        <th>Amount</th>


                        <th></th>


                    </tr>



                </thead>


                <tbody class=""ChaDetails"">
                </tbody>


























            </table>




        </div>


    </div>



















</form>
<script>


  


    d");
            WriteLiteral(@"ocument.getElementById('RDate').valueAsDate = new Date();












    ///  document.getElementById('VOUCHAR_DATE').valueAsDate = new Date();


        //$('#UserName').val($('#personName').text());
        //$('#UserId').val($('#personId').val())


  





</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ZCLINIC.Areas.Transaction.Models.Receipt> Html { get; private set; }
    }
}
#pragma warning restore 1591