#pragma checksum "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\CustomerFeeVoucher\ACustomerSaleInvoiceFeeVoucher.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3428691e3c23568b234318c50db1a5ef686c874f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Transaction_Views_CustomerFeeVoucher_ACustomerSaleInvoiceFeeVoucher), @"mvc.1.0.view", @"/Areas/Transaction/Views/CustomerFeeVoucher/ACustomerSaleInvoiceFeeVoucher.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Transaction/Views/CustomerFeeVoucher/ACustomerSaleInvoiceFeeVoucher.cshtml", typeof(AspNetCore.Areas_Transaction_Views_CustomerFeeVoucher_ACustomerSaleInvoiceFeeVoucher))]
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
#line 1 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\CustomerFeeVoucher\ACustomerSaleInvoiceFeeVoucher.cshtml"
using SMSERP;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3428691e3c23568b234318c50db1a5ef686c874f", @"/Areas/Transaction/Views/CustomerFeeVoucher/ACustomerSaleInvoiceFeeVoucher.cshtml")]
    public class Areas_Transaction_Views_CustomerFeeVoucher_ACustomerSaleInvoiceFeeVoucher : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SMSERP.Areas.Transaction.Models.FeeVoucher>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(66, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\CustomerFeeVoucher\ACustomerSaleInvoiceFeeVoucher.cshtml"
  
    string URL = Model == null ? "/Transaction/FeeVoucher/SaveFeeVoucher" : "/Transaction/FeeVoucher/UpdateFeeVoucher";
    int counter = 0;

#line default
#line hidden
            BeginContext(218, 373, true);
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
            BeginContext(592, 3, false);
#line 24 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\CustomerFeeVoucher\ACustomerSaleInvoiceFeeVoucher.cshtml"
                         Write(URL);

#line default
#line hidden
            EndContext();
            BeginContext(595, 84, true);
            WriteLiteral("\" data-rurl=\"/Transaction/CustomerFeeVoucher\" data-display=\"FeeVoucher\">\r\n\r\n\r\n\r\n    ");
            EndContext();
            BeginContext(680, 28, false);
#line 28 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\CustomerFeeVoucher\ACustomerSaleInvoiceFeeVoucher.cshtml"
Write(Html.HiddenFor(m => m.FeeId));

#line default
#line hidden
            EndContext();
            BeginContext(708, 244, true);
            WriteLiteral("\r\n    <div class=\"row\">\r\n\r\n\r\n\r\n        <div class=\"form-group form-group-xs col-md-12\">\r\n\r\n            <div class=\"form-group form-group-xs col-md-2\">\r\n                <label>Voucher No<b class=\"wysiwyg-color-red\"></b></label>\r\n                ");
            EndContext();
            BeginContext(953, 101, false);
#line 37 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\CustomerFeeVoucher\ACustomerSaleInvoiceFeeVoucher.cshtml"
           Write(Html.TextBoxFor(m => m.FeeId, new { @class = "form-control", type = "text", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(1054, 181, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n            <div class=\"form-group form-group-xs col-md-2\">\r\n                <label>Voucher Date<b class=\"wysiwyg-color-red\"></b></label>\r\n                ");
            EndContext();
            BeginContext(1236, 103, false);
#line 43 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\CustomerFeeVoucher\ACustomerSaleInvoiceFeeVoucher.cshtml"
           Write(Html.TextBoxFor(m => m.VouDate, new { @class = "form-control", type = "date", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(1339, 165, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n\r\n            <div class=\"form-group form-group-xs col-md-4\">\r\n                <label>Month Name<b class=\"wysiwyg-color-red\"></b></label>\r\n");
            EndContext();
#line 50 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\CustomerFeeVoucher\ACustomerSaleInvoiceFeeVoucher.cshtml"
                  
                    List<SMSERP.Areas.Master.Models.AcadmicYear> AcadmicYear = new SMSERP.Areas.Master.Models.AcadmicYear().Master_AcadmicYearGetAll(Context.Session.GetBValues(), Context.GetIP(), Context.GetCInfo());
                    AcadmicYear.Insert(0, new SMSERP.Areas.Master.Models.AcadmicYear { Id = 0, FeesTerm = "Select Month  Name" });
                

#line default
#line hidden
            BeginContext(1893, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(1910, 156, false);
#line 54 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\CustomerFeeVoucher\ACustomerSaleInvoiceFeeVoucher.cshtml"
           Write(Html.DropDownList("MonthId", AcadmicYear.Select(s => new SelectListItem() { Text = s.FeesTerm, Value = s.Id.ToString() }), new { @class = "form-control " }));

#line default
#line hidden
            EndContext();
            BeginContext(2066, 167, true);
            WriteLiteral("\r\n\r\n            </div>\r\n            \r\n\r\n\r\n\r\n\r\n\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n\r\n\r\n\r\n        <div class=\"form-group form-group-xs col-md-12\">\r\n\r\n");
            EndContext();
            BeginContext(2488, 157, true);
            WriteLiteral("\r\n\r\n\r\n            <div class=\"form-group form-group-xs col-md-2\">\r\n                <label>Due Date<b class=\"wysiwyg-color-red\"></b></label>\r\n                ");
            EndContext();
            BeginContext(2646, 79, false);
#line 82 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\CustomerFeeVoucher\ACustomerSaleInvoiceFeeVoucher.cshtml"
           Write(Html.TextBoxFor(m => m.DueDate, new { @class = "form-control", type = "date" }));

#line default
#line hidden
            EndContext();
            BeginContext(2725, 174, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n            <div class=\"form-group form-group-xs col-md-2\">\r\n                <label>RefId<b class=\"wysiwyg-color-red\"></b></label>\r\n                ");
            EndContext();
            BeginContext(2900, 101, false);
#line 88 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\CustomerFeeVoucher\ACustomerSaleInvoiceFeeVoucher.cshtml"
           Write(Html.TextBoxFor(m => m.RefId, new { @class = "form-control", type = "text", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(3001, 164, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n\r\n            <div class=\"form-group form-group-xs col-md-4\">\r\n                <label>Bank Name<b class=\"wysiwyg-color-red\"></b></label>\r\n");
            EndContext();
#line 95 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\CustomerFeeVoucher\ACustomerSaleInvoiceFeeVoucher.cshtml"
                  
                    List<SMSERP.Areas.Master.Models.Master_SubAccount> SubAcc = new SMSERP.Areas.Master.Models.Master_SubAccount().Master_SubAccountGetBankMaster(Context.Session.GetBValues(), Context.GetIP(), Context.GetCInfo());
                    SubAcc.Insert(0, new SMSERP.Areas.Master.Models.Master_SubAccount { Com_id = 0, Subacc_Name = "Select Bank  Name" });
                

#line default
#line hidden
            BeginContext(3574, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(3591, 157, false);
#line 99 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\CustomerFeeVoucher\ACustomerSaleInvoiceFeeVoucher.cshtml"
           Write(Html.DropDownList("BankId", SubAcc.Select(s => new SelectListItem() { Text = s.Subacc_Name, Value = s.Com_id.ToString() }), new { @class = "form-control " }));

#line default
#line hidden
            EndContext();
            BeginContext(3748, 179, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n\r\n\r\n            <div class=\"form-group form-group-xs col-md-2\">\r\n                <label>SaleId<b class=\"wysiwyg-color-red\"></b></label>\r\n                ");
            EndContext();
            BeginContext(3928, 103, false);
#line 107 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\CustomerFeeVoucher\ACustomerSaleInvoiceFeeVoucher.cshtml"
           Write(Html.TextBoxFor(m => m.SalesId, new { @class = "form-control", type = "text", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(4031, 64, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n\r\n\r\n\r\n\r\n        </div>\r\n    </div>\r\n\r\n");
            EndContext();
            BeginContext(4990, 847, true);
            WriteLiteral(@"

    <div class=""clearfix""></div>


    <div class=""panel-body form-group panel panel-flat mt-5"" style=""height:322px; width:100%; overflow-y:auto;"" id=""table-div"">


        <div class=""table-responsive container-fluid quotaiontable"">
            <table class=""table table-xxs table-md table-bordered table-striped table-hover bg-lightgray dataTables_scrollBody"">




                <thead>
                    <tr class=""bg-blue-800"">

                        <th class=""col-lg-2"">Student</th>
                        <th class=""col-lg-2"">Panel Name</th>

                        <th class=""col-lg-1"">GrNO</th>
                        <th class=""col-lg-1"">TotalAmt</th>
                        <th class=""col-lg-1"">ChNo</th>

                        <th class=""col-lg-1"">Actions</th>



                    </tr>

");
            EndContext();
            BeginContext(6243, 81, true);
            WriteLiteral("\r\n\r\n                </thead>\r\n\r\n\r\n                <tbody class=\"VoucherDetail\">\r\n");
            EndContext();
            BeginContext(7174, 244, true);
            WriteLiteral("\r\n                </tbody>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n                <tfoot>\r\n                    <tr>\r\n\r\n                        <td colspan=\"2\"></td>\r\n                        <td class=\"text-right\">Total Amount</td>\r\n\r\n                        <td>");
            EndContext();
            BeginContext(7419, 105, false);
#line 234 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\CustomerFeeVoucher\ACustomerSaleInvoiceFeeVoucher.cshtml"
                       Write(Html.TextBoxFor(m => m.TAmount, new { @class = "form-control", type = "number", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(7524, 586, true);
            WriteLiteral(@"</td>



                    </tr>

                </tfoot>
















            </table>




        </div>


    </div>

















    <div class=""modal-footer mt-10 no-padding no-border"">




        <a data-url=""/Transaction/CustomerFeeVoucher"" data-script=""#"" class=""btn btn-danger btn-xs  closeBtn"" data-dismiss=""modal""><i class=""icon-cross""></i>Close</a>




        <button type=""button"" data-submit="""" class=""btn btn-primary  btn-xs  SaveBtn""><i class=""icon-floppy-disk position-left""></i>Save</button>
");
            EndContext();
            BeginContext(8260, 5677, true);
            WriteLiteral(@"
    </div>

</form>

<script>


    document.getElementById('VouDate').valueAsDate = new Date();
    document.getElementById('DueDate').valueAsDate = new Date();


    let Id = parseInt($('#SalesId').val());
    debugger;

    SaleInvoiceGetGRId(Id);

    function SaleInvoiceGetGRId(id) {

       

        GetJSONRequest('/Transaction/FeeVoucherDetail/GetGrIdSaleId', 'GET', { id }, data => {
            

            debugger;
            let i = 0;


            if (data && data.length > 0) {
                $('tbody.VoucherDetail').empty();
                for (const item of data) {
                    i++;
                    const markup = `
               <tr>


                                <td>
                                         <input type=""hidden"" class=""form-control GRId"" readonly value=""${item.GRId}"" />
                                         <input type=""text"" class=""form-control StudentName""  readonly value=""${item.StudentName}"" />
                ");
            WriteLiteral(@"                </td>
                                
                                  <td>
                                         <input type=""hidden"" class=""form-control PanelId"" readonly value=""${item.PanelId}"" />
                                         <input type=""text"" class=""form-control PanelN""  readonly value=""${item.PanelN}"" />
                                </td>
                                <td><input type=""text"" class=""form-control Grno""  readonly value=""${item.GrNo}"" /></td>
                                
                                    <td><input type=""text"" class=""form-control TotalAmt"" readonly value=""${item.TAmount}"" /></td>
                                     <td> </td>

                                    <td><a id=""""><i class=""icon-trash removeitem text-danger-600""></i></a>



                 </tr>`;

                    $('tbody.VoucherDetail').append(markup);
                    calculateTotalAmt();


                }


                debugger;");
            WriteLiteral(@"

                // console.log(data);
                ///   DropDown2Initializers();
                //    $('#Supcode').val(data[0].Supcode).change();

                //$('#Remarks').val(data[0].Remarks);
                //$('#ItemId').val(data[0].ItemId).change();
                //$('#Category').val(data[0].Category).change();
                //	$('#ReqDate').val(data[0].ReqDate);



                return;
            }
            ErrorAlert('No Purchase Receive Found');
        })

    }



    function calculateTotalAmt() {
        var sum = 0;


        let TotalAmount = 0;
        $('.TotalAmt').each(function () {
            TotalAmount += parseFloat($(this).val()) || 0;
        })
        $('#TAmount').val(TotalAmount);




    }


    $('.SaveBtn').on('click', function () {
        var MonthId = $('#MonthId').val();
        var LevelId = $('#LevelId').val();
        var BankId = $('#BankId').val();
        var ServicesId = $('#ServicesId').val();



            WriteLiteral(@"

        var check = false;




        if (MonthId == 0 || MonthId == null) {


            ErrorAlert(""Enter Month  Name"");
            check = true;

        }

        

        if (BankId == 0 || BankId == null) {


            ErrorAlert(""Enter Bank Name"");
            check = true;

        }

      


        if (!check) {















            var FeeVoucher = [], FeeVoucherDetail = [];



            FeeVoucher = {
                FeeId: $('#FeeId').val(),
                voudate: $('#VouDate').val(),
                DueDate: $('#DueDate').val(),

                MonthId: parseInt($('#MonthId option:selected').val()),
                LeaveF: parseInt(0),
                LevelId: parseInt(0),
                BankId: parseInt($('#BankId option:selected').val()),

                AdAmt: 0,
                AnnAmt: 0,
                MontlyAmt: 0,
                MDisAmt: 0,

                OtherAmt: 0,
                TAmount: $('#TAm");
            WriteLiteral(@"ount').val(),
                RefId: $('#RefId').val(),
                ServicesId: $('#ServicesId').val(),


                VouMode: 2,






                //  StudentN: parseInt($('#StudentN option:selected').val()),


            }


            $('tbody.VoucherDetail tr').each(function () {

                FeeVoucherDetail.push({



                    FeeId: $('#FeeId').val(),
                    GRId: parseInt($(this).find("".GRId"").val()),
                    GrNo: parseInt($(this).find("".Grno"").val()),
                    PanelId: parseInt($(this).find("".PanelId"").val()),
                    AdAmt: 0,
                    AnnAmt: 0,
                    MontlyAmt: 0,
                    MDisAmt: 0,

                    TAmount: parseFloat($(this).find("".TotalAmt"").val()),
                    OtherAmt: parseFloat($(this).find("".TotalAmt"").val()),
                    ChallanNo: parseInt($(this).find("".ChallanNo"").val()),





                });



         ");
            WriteLiteral(@"   });






           

            let SaleId = parseInt($('#SalesId').val());

           

             
            GetJSONRequest('/Transaction/FeeVoucher/SaveSaleInvoiveFeeVoucher', 'POST', { FeeVoucher, FeeVoucherDetail, SaleId}, function (data) {
                    SuccessAlert(""Data Saved"");
                    $('.closeBtn').trigger('click');
                });
          
            



        }
        //else {
        //    ErrorAlert(""Miss value"");
        //}










    });




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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SMSERP.Areas.Transaction.Models.FeeVoucher> Html { get; private set; }
    }
}
#pragma warning restore 1591