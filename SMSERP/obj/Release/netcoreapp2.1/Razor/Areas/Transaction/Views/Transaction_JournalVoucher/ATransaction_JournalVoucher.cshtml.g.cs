#pragma checksum "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\Transaction_JournalVoucher\ATransaction_JournalVoucher.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d7cb20fc28cce1da60827e8f1756858b5a834b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Transaction_Views_Transaction_JournalVoucher_ATransaction_JournalVoucher), @"mvc.1.0.view", @"/Areas/Transaction/Views/Transaction_JournalVoucher/ATransaction_JournalVoucher.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Transaction/Views/Transaction_JournalVoucher/ATransaction_JournalVoucher.cshtml", typeof(AspNetCore.Areas_Transaction_Views_Transaction_JournalVoucher_ATransaction_JournalVoucher))]
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
#line 1 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\Transaction_JournalVoucher\ATransaction_JournalVoucher.cshtml"
using SMSERP;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d7cb20fc28cce1da60827e8f1756858b5a834b3", @"/Areas/Transaction/Views/Transaction_JournalVoucher/ATransaction_JournalVoucher.cshtml")]
    public class Areas_Transaction_Views_Transaction_JournalVoucher_ATransaction_JournalVoucher : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SMSERP.Areas.Transaction.Models.Transaction_VoucherMaster>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(81, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\Transaction_JournalVoucher\ATransaction_JournalVoucher.cshtml"
  
    string URL = Model == null ? "/Transaction/Transaction_JournalVoucher/SaveTransaction_JournalVoucher" : "/Transaction/Transaction_JournalVoucher/UpdateTransaction_JournalVoucher";
    int counter = 0;

#line default
#line hidden
            BeginContext(297, 373, true);
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
            BeginContext(671, 3, false);
#line 24 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\Transaction_JournalVoucher\ATransaction_JournalVoucher.cshtml"
                         Write(URL);

#line default
#line hidden
            EndContext();
            BeginContext(674, 97, true);
            WriteLiteral("\" data-rurl=\"/Transaction/Transaction_JournalVoucher\" data-display=\"Journal Voucher\">\r\n\r\n\r\n\r\n    ");
            EndContext();
            BeginContext(772, 29, false);
#line 28 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\Transaction_JournalVoucher\ATransaction_JournalVoucher.cshtml"
Write(Html.HiddenFor(m => m.REF_ID));

#line default
#line hidden
            EndContext();
            BeginContext(801, 244, true);
            WriteLiteral("\r\n    <div class=\"row\">\r\n\r\n\r\n\r\n        <div class=\"form-group form-group-xs col-md-12\">\r\n\r\n            <div class=\"form-group form-group-xs col-md-2\">\r\n                <label>Voucher No<b class=\"wysiwyg-color-red\"></b></label>\r\n                ");
            EndContext();
            BeginContext(1046, 106, false);
#line 37 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\Transaction_JournalVoucher\ATransaction_JournalVoucher.cshtml"
           Write(Html.TextBoxFor(m => m.VOUCHER_NO, new { @class = "form-control", type = "text", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(1152, 181, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n            <div class=\"form-group form-group-xs col-md-2\">\r\n                <label>Voucher Date<b class=\"wysiwyg-color-red\"></b></label>\r\n                ");
            EndContext();
            BeginContext(1334, 84, false);
#line 43 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\Transaction_JournalVoucher\ATransaction_JournalVoucher.cshtml"
           Write(Html.TextBoxFor(m => m.VOUCHAR_DATE, new { @class = "form-control", type = "date" }));

#line default
#line hidden
            EndContext();
            BeginContext(1418, 26, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n");
            EndContext();
            BeginContext(2170, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
            BeginContext(2723, 283, true);
            WriteLiteral(@"



        </div>
    </div>



    <div class=""row"">

        <div class=""form-group form-group-xs col-md-12"">



            <div class=""form-group form-group-xs col-md-5"">
                <label>Nurration<b class=""wysiwyg-color-red""></b></label>
                ");
            EndContext();
            BeginContext(3007, 134, false);
#line 90 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\Transaction_JournalVoucher\ATransaction_JournalVoucher.cshtml"
           Write(Html.TextAreaFor(m => m.Nurration, new { @class = "form-control", style = "width: 350px; height: 69px; resize: none", type = "text" }));

#line default
#line hidden
            EndContext();
            BeginContext(3141, 42, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n\r\n\r\n            ");
            EndContext();
            BeginContext(3184, 110, false);
#line 96 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\Transaction_JournalVoucher\ATransaction_JournalVoucher.cshtml"
       Write(Html.TextBoxFor(m => m.VOUCHER_MODE, new { @class = "form-control", type = "hidden", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(3294, 163, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n            <div class=\"form-group form-group-xs col-md-3\">\r\n                <label>UserName<b class=\"wysiwyg-color-red\"></b></label>\r\n                ");
            EndContext();
            BeginContext(3458, 105, false);
#line 104 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\Transaction_JournalVoucher\ATransaction_JournalVoucher.cshtml"
           Write(Html.TextBoxFor(m => m.User_name, new { @class = "form-control", type = "text", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(3563, 183, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n\r\n            <div class=\"form-group form-group-xs col-md-3\">\r\n                <label>Voucher Time<b class=\"wysiwyg-color-red\"></b></label>\r\n                ");
            EndContext();
            BeginContext(3747, 108, false);
#line 111 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\Transaction_JournalVoucher\ATransaction_JournalVoucher.cshtml"
           Write(Html.TextBoxFor(m => m.Voucher_time, new { @class = "form-control", type = "text", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(3855, 147, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n        </div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n    </div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n    <div style=\"display:none;\">\r\n\r\n\r\n");
            EndContext();
            BeginContext(4255, 10, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
            EndContext();
#line 157 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\Transaction_JournalVoucher\ATransaction_JournalVoucher.cshtml"
          
            List<SMSERP.Areas.Master.Models.Master_SubAccount> Master_SubAccount = new SMSERP.Areas.Master.Models.Master_SubAccount().Master_SubAccountGetAll(Context.Session.GetBValues(), Context.GetIP(), Context.GetCInfo());
           // Master_SubAccount.Insert(0, new SMSERP.Areas.Master.Models.Master_SubAccount { Sub_accountCode = "0", Subacc_Name = "Select Account Name" });
        

#line default
#line hidden
            BeginContext(4672, 826, true);
            WriteLiteral(@"







    </div>

    <div class=""clearfix""></div>


    <div class=""panel-body form-group panel panel-flat mt-5"" style=""height:322px; width:100%; overflow-y:auto;"" id=""table-div"">


        <div class=""table-responsive container-fluid quotaiontable"">
            <table class="" table table-xxs table-md table-bordered table-striped table-hover bg-lightgray dataTables_scrollBody"">
                <thead>
                    <tr class=""bg-blue-800"">

                        <th>Account Name</th>
                        <th>Remarks</th>
                        <th>Debit</th>
                        <th>Credit</th>


                        <th></th>


                    </tr>
                    <tr>





                        <th class=""col-md-5"">
                            ");
            EndContext();
            BeginContext(5499, 252, false);
#line 199 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\Transaction_JournalVoucher\ATransaction_JournalVoucher.cshtml"
                       Write(Html.DropDownList("SUB_CODE", Master_SubAccount.Select(p => new SelectListItem() { Text = p.Subacc_Name.ToString(), Value = p.Sub_accountCode.ToString() }), new { @class = "bootstrap-select vatratecal", data_live_search = "true", data_width = "100%" }));

#line default
#line hidden
            EndContext();
            BeginContext(5751, 638, true);
            WriteLiteral(@"

                        </th>
                        <th class=""col-md-3""><input type=""text"" class=""form-control Remarksfield TxtBox"" , id=""Remarks"" /></th>
                        <th class=""col-md-2""><input type=""text"" class=""form-control Debitfield TxtBox"" id=""DebitAmt"" /></th>
                        <th class=""col-md-2""><input type=""text"" class=""form-control Creditfield TxtBox"" id=""CreditAmt"" /></th>

                        <th class=""col-lg-1""><a class=""icon-add text-primary"" id=""AddItemBtn""></a></th>
                    </tr>


                </thead>


                <tbody class=""BankVoucherDetails"">
");
            EndContext();
#line 214 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\Transaction_JournalVoucher\ATransaction_JournalVoucher.cshtml"
                     if (Model != null)
                    {
                        foreach (var item in Model.VoucherDetails)
                        {
                            counter++;



#line default
#line hidden
            BeginContext(6592, 118, true);
            WriteLiteral("                            <tr>\r\n\r\n\r\n\r\n\r\n                                <td>\r\n\r\n                                    ");
            EndContext();
            BeginContext(6711, 288, false);
#line 228 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\Transaction_JournalVoucher\ATransaction_JournalVoucher.cshtml"
                               Write(Html.DropDownListFor(m => m.VoucherDetails[counter - 1].SUB_CODE, Master_SubAccount.Select(p => new SelectListItem() { Text = p.Subacc_Name.ToString(), Value = p.Sub_accountCode.ToString() }), new { @class = "bootstrap-select vatratecal", data_live_search = "true", data_width = "100%" }));

#line default
#line hidden
            EndContext();
            BeginContext(6999, 133, true);
            WriteLiteral("\r\n                                </td>\r\n\r\n\r\n                                <td><input type=\"text\" class=\"form-control Remarksfield\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 7132, "\"", 7153, 1);
#line 232 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\Transaction_JournalVoucher\ATransaction_JournalVoucher.cshtml"
WriteAttributeValue("", 7140, item.Remarks, 7140, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7154, 96, true);
            WriteLiteral("></td>\r\n\r\n                                <td><input type=\"text\" class=\"form-control Debitfield\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 7250, "\"", 7269, 1);
#line 234 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\Transaction_JournalVoucher\ATransaction_JournalVoucher.cshtml"
WriteAttributeValue("", 7258, item.DEBIT, 7258, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7270, 95, true);
            WriteLiteral("></td>\r\n                                <td><input type=\"text\" class=\"form-control Creditfield\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 7365, "\"", 7385, 1);
#line 235 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\Transaction_JournalVoucher\ATransaction_JournalVoucher.cshtml"
WriteAttributeValue("", 7373, item.CREDIT, 7373, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7386, 50, true);
            WriteLiteral("></td>\r\n\r\n\r\n                                <td><a");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 7436, "\"", 7441, 0);
            EndWriteAttribute();
            BeginContext(7442, 100, true);
            WriteLiteral("><i class=\"icon-trash removeitem text-danger-600\"></i></a></td>\r\n                            </tr>\r\n");
            EndContext();
#line 240 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\Transaction_JournalVoucher\ATransaction_JournalVoucher.cshtml"
                        }
                    }

#line default
#line hidden
            BeginContext(7592, 242, true);
            WriteLiteral("\r\n                </tbody>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n                <tfoot>\r\n                    <tr>\r\n\r\n                        <td colspan=\"1\"></td>\r\n                        <td class=\"text-right\">Total Amount</td>\r\n                        <td>");
            EndContext();
            BeginContext(7835, 107, false);
#line 259 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\Transaction_JournalVoucher\ATransaction_JournalVoucher.cshtml"
                       Write(Html.TextBoxFor(m => m.TDebitAmt, new { @class = "form-control", type = "number", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(7942, 41, true);
            WriteLiteral("</td>\r\n\r\n\r\n\r\n                        <td>");
            EndContext();
            BeginContext(7984, 108, false);
#line 263 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\Transaction_JournalVoucher\ATransaction_JournalVoucher.cshtml"
                       Write(Html.TextBoxFor(m => m.TCreditAmt, new { @class = "form-control", type = "number", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(8092, 531, true);
            WriteLiteral(@"</td>



                    </tr>

                </tfoot>
















            </table>




        </div>


    </div>

















    <div class=""modal-footer mt-10 no-padding no-border"">



        <button type=""button"" class=""btn btn-danger btn-xs"" data-dismiss=""modal""><i class=""icon-cross""></i>Close</button>
        <button type=""button"" data-submit="""" class=""btn btn-primary  btn-xs  SaveBtn""><i class=""icon-floppy-disk position-left""></i>Save</button>
");
            EndContext();
            BeginContext(8773, 82, true);
            WriteLiteral("\r\n    </div>\r\n\r\n</form>\r\n<script>\r\n\r\n\r\n    $(\'#VOUCHER_MODE\').val(\'JV\')\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SMSERP.Areas.Transaction.Models.Transaction_VoucherMaster> Html { get; private set; }
    }
}
#pragma warning restore 1591