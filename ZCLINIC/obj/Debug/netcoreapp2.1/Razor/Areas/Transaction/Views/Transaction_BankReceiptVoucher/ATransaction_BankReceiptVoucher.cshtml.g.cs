#pragma checksum "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\Transaction_BankReceiptVoucher\ATransaction_BankReceiptVoucher.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89659a9286d24d6edeed079fc1efcc1e3960ba43"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Transaction_Views_Transaction_BankReceiptVoucher_ATransaction_BankReceiptVoucher), @"mvc.1.0.view", @"/Areas/Transaction/Views/Transaction_BankReceiptVoucher/ATransaction_BankReceiptVoucher.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Transaction/Views/Transaction_BankReceiptVoucher/ATransaction_BankReceiptVoucher.cshtml", typeof(AspNetCore.Areas_Transaction_Views_Transaction_BankReceiptVoucher_ATransaction_BankReceiptVoucher))]
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
#line 1 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\Transaction_BankReceiptVoucher\ATransaction_BankReceiptVoucher.cshtml"
using ZCLINIC;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89659a9286d24d6edeed079fc1efcc1e3960ba43", @"/Areas/Transaction/Views/Transaction_BankReceiptVoucher/ATransaction_BankReceiptVoucher.cshtml")]
    public class Areas_Transaction_Views_Transaction_BankReceiptVoucher_ATransaction_BankReceiptVoucher : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ZCLINIC.Areas.Transaction.Models.Transaction_VoucherMaster>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(83, 12, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n");
            EndContext();
#line 9 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\Transaction_BankReceiptVoucher\ATransaction_BankReceiptVoucher.cshtml"
  
    string URL = Model == null ? "/Transaction/Transaction_BankReceiptVoucher/SaveTransaction_BankReceiptVoucher" : "/Transaction/Transaction_BankReceiptVoucher/UpdateTransaction_BankReceiptVoucher";
    int counter = 0;

#line default
#line hidden
            BeginContext(325, 373, true);
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
            BeginContext(699, 3, false);
#line 29 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\Transaction_BankReceiptVoucher\ATransaction_BankReceiptVoucher.cshtml"
                         Write(URL);

#line default
#line hidden
            EndContext();
            BeginContext(702, 106, true);
            WriteLiteral("\" data-rurl=\"/Transaction/Transaction_BankReceiptVoucher\" data-display=\"Bank Receipt Voucher\">\r\n\r\n\r\n\r\n    ");
            EndContext();
            BeginContext(809, 29, false);
#line 33 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\Transaction_BankReceiptVoucher\ATransaction_BankReceiptVoucher.cshtml"
Write(Html.HiddenFor(m => m.REF_ID));

#line default
#line hidden
            EndContext();
            BeginContext(838, 244, true);
            WriteLiteral("\r\n    <div class=\"row\">\r\n\r\n\r\n\r\n        <div class=\"form-group form-group-xs col-md-12\">\r\n\r\n            <div class=\"form-group form-group-xs col-md-2\">\r\n                <label>Voucher No<b class=\"wysiwyg-color-red\"></b></label>\r\n                ");
            EndContext();
            BeginContext(1083, 106, false);
#line 42 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\Transaction_BankReceiptVoucher\ATransaction_BankReceiptVoucher.cshtml"
           Write(Html.TextBoxFor(m => m.VOUCHER_NO, new { @class = "form-control", type = "text", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(1189, 181, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n            <div class=\"form-group form-group-xs col-md-2\">\r\n                <label>Voucher Date<b class=\"wysiwyg-color-red\"></b></label>\r\n                ");
            EndContext();
            BeginContext(1371, 84, false);
#line 48 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\Transaction_BankReceiptVoucher\ATransaction_BankReceiptVoucher.cshtml"
           Write(Html.TextBoxFor(m => m.VOUCHAR_DATE, new { @class = "form-control", type = "date" }));

#line default
#line hidden
            EndContext();
            BeginContext(1455, 26, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n");
            EndContext();
            BeginContext(2209, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
            BeginContext(2476, 156, true);
            WriteLiteral("\r\n\r\n            <div class=\"form-group form-group-xs col-md-4\">\r\n                <label>Cheque No<b class=\"wysiwyg-color-red\"></b></label>\r\n                ");
            EndContext();
            BeginContext(2633, 77, false);
#line 75 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\Transaction_BankReceiptVoucher\ATransaction_BankReceiptVoucher.cshtml"
           Write(Html.TextBoxFor(m => m.CHQ, new { @class = "form-control", type = "number" }));

#line default
#line hidden
            EndContext();
            BeginContext(2710, 307, true);
            WriteLiteral(@"

            </div>




        </div>
    </div>



    <div class=""row"">

        <div class=""form-group form-group-xs col-md-12"">



            <div class=""form-group form-group-xs col-md-5"">
                <label>Nurration<b class=""wysiwyg-color-red""></b></label>
                ");
            EndContext();
            BeginContext(3018, 134, false);
#line 95 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\Transaction_BankReceiptVoucher\ATransaction_BankReceiptVoucher.cshtml"
           Write(Html.TextAreaFor(m => m.Nurration, new { @class = "form-control", style = "width: 350px; height: 69px; resize: none", type = "text" }));

#line default
#line hidden
            EndContext();
            BeginContext(3152, 42, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n\r\n\r\n            ");
            EndContext();
            BeginContext(3195, 110, false);
#line 101 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\Transaction_BankReceiptVoucher\ATransaction_BankReceiptVoucher.cshtml"
       Write(Html.TextBoxFor(m => m.VOUCHER_MODE, new { @class = "form-control", type = "hidden", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(3305, 163, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n            <div class=\"form-group form-group-xs col-md-3\">\r\n                <label>UserName<b class=\"wysiwyg-color-red\"></b></label>\r\n                ");
            EndContext();
            BeginContext(3469, 105, false);
#line 109 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\Transaction_BankReceiptVoucher\ATransaction_BankReceiptVoucher.cshtml"
           Write(Html.TextBoxFor(m => m.User_name, new { @class = "form-control", type = "text", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(3574, 183, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n\r\n            <div class=\"form-group form-group-xs col-md-3\">\r\n                <label>Voucher Time<b class=\"wysiwyg-color-red\"></b></label>\r\n                ");
            EndContext();
            BeginContext(3758, 108, false);
#line 116 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\Transaction_BankReceiptVoucher\ATransaction_BankReceiptVoucher.cshtml"
           Write(Html.TextBoxFor(m => m.Voucher_time, new { @class = "form-control", type = "text", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(3866, 147, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n        </div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n    </div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n    <div style=\"display:none;\">\r\n\r\n\r\n");
            EndContext();
            BeginContext(4266, 10, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
            EndContext();
#line 162 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\Transaction_BankReceiptVoucher\ATransaction_BankReceiptVoucher.cshtml"
          
            List<ZCLINIC.Areas.Master.Models.Master_SubAccount> Master_SubAccount = new ZCLINIC.Areas.Master.Models.Master_SubAccount().Master_SubAccountGetAll(Context.Session.GetBValues(), Context.GetIP(), Context.GetCInfo());
          //  Master_SubAccount.Insert(0, new ZCLINIC.Areas.Master.Models.Master_SubAccount { Sub_accountCode = "0", Subacc_Name = "Select Account Name" });
        

#line default
#line hidden
            BeginContext(4686, 826, true);
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
            BeginContext(5513, 252, false);
#line 204 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\Transaction_BankReceiptVoucher\ATransaction_BankReceiptVoucher.cshtml"
                       Write(Html.DropDownList("SUB_CODE", Master_SubAccount.Select(p => new SelectListItem() { Text = p.Subacc_Name.ToString(), Value = p.Sub_accountCode.ToString() }), new { @class = "bootstrap-select vatratecal", data_live_search = "true", data_width = "100%" }));

#line default
#line hidden
            EndContext();
            BeginContext(5765, 638, true);
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
#line 219 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\Transaction_BankReceiptVoucher\ATransaction_BankReceiptVoucher.cshtml"
                     if (Model != null)
                    {
                        foreach (var item in Model.VoucherDetails)
                        {
                            counter++;



#line default
#line hidden
            BeginContext(6606, 94, true);
            WriteLiteral("                    <tr>\r\n\r\n\r\n\r\n\r\n                        <td>\r\n\r\n                            ");
            EndContext();
            BeginContext(6701, 288, false);
#line 233 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\Transaction_BankReceiptVoucher\ATransaction_BankReceiptVoucher.cshtml"
                       Write(Html.DropDownListFor(m => m.VoucherDetails[counter - 1].SUB_CODE, Master_SubAccount.Select(p => new SelectListItem() { Text = p.Subacc_Name.ToString(), Value = p.Sub_accountCode.ToString() }), new { @class = "bootstrap-select vatratecal", data_live_search = "true", data_width = "100%" }));

#line default
#line hidden
            EndContext();
            BeginContext(6989, 117, true);
            WriteLiteral("\r\n                        </td>\r\n\r\n\r\n                        <td><input type=\"text\" class=\"form-control Remarksfield\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 7106, "\"", 7127, 1);
#line 237 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\Transaction_BankReceiptVoucher\ATransaction_BankReceiptVoucher.cshtml"
WriteAttributeValue("", 7114, item.Remarks, 7114, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7128, 88, true);
            WriteLiteral("></td>\r\n\r\n                        <td><input type=\"text\" class=\"form-control Debitfield\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 7216, "\"", 7235, 1);
#line 239 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\Transaction_BankReceiptVoucher\ATransaction_BankReceiptVoucher.cshtml"
WriteAttributeValue("", 7224, item.DEBIT, 7224, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7236, 87, true);
            WriteLiteral("></td>\r\n                        <td><input type=\"text\" class=\"form-control Creditfield\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 7323, "\"", 7343, 1);
#line 240 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\Transaction_BankReceiptVoucher\ATransaction_BankReceiptVoucher.cshtml"
WriteAttributeValue("", 7331, item.CREDIT, 7331, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7344, 42, true);
            WriteLiteral("></td>\r\n\r\n\r\n                        <td><a");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 7386, "\"", 7391, 0);
            EndWriteAttribute();
            BeginContext(7392, 92, true);
            WriteLiteral("><i class=\"icon-trash removeitem text-danger-600\"></i></a></td>\r\n                    </tr>\r\n");
            EndContext();
#line 245 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\Transaction_BankReceiptVoucher\ATransaction_BankReceiptVoucher.cshtml"
                        }
                    }

#line default
#line hidden
            BeginContext(7534, 242, true);
            WriteLiteral("\r\n                </tbody>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n                <tfoot>\r\n                    <tr>\r\n\r\n                        <td colspan=\"1\"></td>\r\n                        <td class=\"text-right\">Total Amount</td>\r\n                        <td>");
            EndContext();
            BeginContext(7777, 107, false);
#line 264 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\Transaction_BankReceiptVoucher\ATransaction_BankReceiptVoucher.cshtml"
                       Write(Html.TextBoxFor(m => m.TDebitAmt, new { @class = "form-control", type = "number", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(7884, 41, true);
            WriteLiteral("</td>\r\n\r\n\r\n\r\n                        <td>");
            EndContext();
            BeginContext(7926, 108, false);
#line 268 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\Transaction_BankReceiptVoucher\ATransaction_BankReceiptVoucher.cshtml"
                       Write(Html.TextBoxFor(m => m.TCreditAmt, new { @class = "form-control", type = "number", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(8034, 531, true);
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
            BeginContext(8715, 83, true);
            WriteLiteral("\r\n    </div>\r\n\r\n</form>\r\n<script>\r\n\r\n\r\n    $(\'#VOUCHER_MODE\').val(\'BRV\')\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ZCLINIC.Areas.Transaction.Models.Transaction_VoucherMaster> Html { get; private set; }
    }
}
#pragma warning restore 1591
