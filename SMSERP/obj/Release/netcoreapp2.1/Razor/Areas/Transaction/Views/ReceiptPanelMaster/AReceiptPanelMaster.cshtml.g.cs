#pragma checksum "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\ReceiptPanelMaster\AReceiptPanelMaster.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2dbd85fc6fb7b8d5e8d4cf4130a83e5a9db1b93"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Transaction_Views_ReceiptPanelMaster_AReceiptPanelMaster), @"mvc.1.0.view", @"/Areas/Transaction/Views/ReceiptPanelMaster/AReceiptPanelMaster.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Transaction/Views/ReceiptPanelMaster/AReceiptPanelMaster.cshtml", typeof(AspNetCore.Areas_Transaction_Views_ReceiptPanelMaster_AReceiptPanelMaster))]
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
#line 1 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\ReceiptPanelMaster\AReceiptPanelMaster.cshtml"
using SMSERP;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2dbd85fc6fb7b8d5e8d4cf4130a83e5a9db1b93", @"/Areas/Transaction/Views/ReceiptPanelMaster/AReceiptPanelMaster.cshtml")]
    public class Areas_Transaction_Views_ReceiptPanelMaster_AReceiptPanelMaster : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SMSERP.Areas.Transaction.Models.ReceiptPanelMaster>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(74, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\ReceiptPanelMaster\AReceiptPanelMaster.cshtml"
  
    string URL = Model == null ? "/Transaction/ReceiptPanelMaster/SaveReceiptPanelMaster" : "/Transaction/ReceiptPanelMaster/UpdateReceiptPanelMaster";
    int counter = 0;

#line default
#line hidden
            BeginContext(258, 373, true);
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
            BeginContext(632, 3, false);
#line 24 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\ReceiptPanelMaster\AReceiptPanelMaster.cshtml"
                         Write(URL);

#line default
#line hidden
            EndContext();
            BeginContext(635, 84, true);
            WriteLiteral("\" data-rurl=\"/Transaction/ReceiptPanelMaster\" data-display=\"FeeVoucher\">\r\n\r\n\r\n\r\n    ");
            EndContext();
            BeginContext(720, 32, false);
#line 28 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\ReceiptPanelMaster\AReceiptPanelMaster.cshtml"
Write(Html.HiddenFor(m => m.ReceiptId));

#line default
#line hidden
            EndContext();
            BeginContext(752, 245, true);
            WriteLiteral("\r\n    <div class=\"row\">\r\n\r\n\r\n\r\n        <div class=\"form-group form-group-xs col-md-12\">\r\n\r\n            <div class=\"form-group form-group-xs col-md-2\">\r\n                <label>Receipt  No<b class=\"wysiwyg-color-red\"></b></label>\r\n                ");
            EndContext();
            BeginContext(998, 107, false);
#line 37 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\ReceiptPanelMaster\AReceiptPanelMaster.cshtml"
           Write(Html.TextBoxFor(m => m.ReceiptCode, new { @class = "form-control", type = "text", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(1105, 181, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n            <div class=\"form-group form-group-xs col-md-2\">\r\n                <label>Receipt Date<b class=\"wysiwyg-color-red\"></b></label>\r\n                ");
            EndContext();
            BeginContext(1287, 101, false);
#line 43 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\ReceiptPanelMaster\AReceiptPanelMaster.cshtml"
           Write(Html.TextBoxFor(m => m.RDate, new { @class = "form-control", type = "date", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(1388, 165, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n\r\n            <div class=\"form-group form-group-xs col-md-4\">\r\n                <label>Month Name<b class=\"wysiwyg-color-red\"></b></label>\r\n");
            EndContext();
#line 50 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\ReceiptPanelMaster\AReceiptPanelMaster.cshtml"
                  
                    List<SMSERP.Areas.Master.Models.AcadmicYear> AcadmicYear = new SMSERP.Areas.Master.Models.AcadmicYear().Master_AcadmicYearGetAll(Context.Session.GetBValues(), Context.GetIP(), Context.GetCInfo());
                    AcadmicYear.Insert(0, new SMSERP.Areas.Master.Models.AcadmicYear { Id = 0, FeesTerm = "Select Month  Name" });
                

#line default
#line hidden
            BeginContext(1942, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(1959, 154, false);
#line 54 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\ReceiptPanelMaster\AReceiptPanelMaster.cshtml"
           Write(Html.DropDownList("MonId", AcadmicYear.Select(s => new SelectListItem() { Text = s.FeesTerm, Value = s.Id.ToString() }), new { @class = "form-control " }));

#line default
#line hidden
            EndContext();
            BeginContext(2113, 162, true);
            WriteLiteral("\r\n\r\n            </div>\r\n            <div class=\"form-group form-group-xs col-md-4\">\r\n                <label>Panel  Name<b class=\"wysiwyg-color-red\"></b></label>\r\n");
            EndContext();
#line 59 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\ReceiptPanelMaster\AReceiptPanelMaster.cshtml"
                  
                    List<SMSERP.Areas.Master.Models.Panel> Panel = new SMSERP.Areas.Master.Models.Panel().Master_PanelGetAll(Context.Session.GetBValues(), Context.GetIP(), Context.GetCInfo());

                

#line default
#line hidden
            BeginContext(2510, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(2527, 148, false);
#line 63 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\ReceiptPanelMaster\AReceiptPanelMaster.cshtml"
           Write(Html.DropDownList("PanelId", Panel.Select(s => new SelectListItem() { Text = s.PName, Value = s.PId.ToString() }), new { @class = "form-control " }));

#line default
#line hidden
            EndContext();
            BeginContext(2675, 317, true);
            WriteLiteral(@"

            </div>







        </div>
    </div>

    <div class=""row"">



        <div class=""form-group form-group-xs col-md-12"">







            <div class=""form-group form-group-xs col-md-2"">
                <label>RefId<b class=""wysiwyg-color-red""></b></label>
                ");
            EndContext();
            BeginContext(2993, 101, false);
#line 90 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\ReceiptPanelMaster\AReceiptPanelMaster.cshtml"
           Write(Html.TextBoxFor(m => m.RefId, new { @class = "form-control", type = "text", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(3094, 178, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n\r\n            <div class=\"form-group form-group-xs col-md-4\">\r\n                <label>Remarks<b class=\"wysiwyg-color-red\"></b></label>\r\n                ");
            EndContext();
            BeginContext(3273, 79, false);
#line 97 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\ReceiptPanelMaster\AReceiptPanelMaster.cshtml"
           Write(Html.TextBoxFor(m => m.Remarks, new { @class = "form-control", type = "text" }));

#line default
#line hidden
            EndContext();
            BeginContext(3352, 609, true);
            WriteLiteral(@"

            </div>














            <div class=""form-group form-group-xs col-md-6"">
                <label>Student Name<b class=""wysiwyg-color-red""></b></label>
                <select class=""form-control combo-box"" id=""StudentN"" type=2 name=""ModelId""></select>

            </div>


        </div>
    </div>




    <div class=""row"">



        <div class=""form-group form-group-xs col-md-12"">







          

            <div class=""form-group form-group-xs col-md-6"">
                <label>Account Name<b class=""wysiwyg-color-red""></b></label>
");
            EndContext();
#line 143 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\ReceiptPanelMaster\AReceiptPanelMaster.cshtml"
                  
                    List<SMSERP.Areas.Master.Models.Master_SubAccount> SubAcc = new SMSERP.Areas.Master.Models.Master_SubAccount().Master_SubAccountGetBankMaster(Context.Session.GetBValues(), Context.GetIP(), Context.GetCInfo());
                    SubAcc.Insert(0, new SMSERP.Areas.Master.Models.Master_SubAccount { Com_id = 0, Subacc_Name = "Select Bank  Name" });
                

#line default
#line hidden
            BeginContext(4370, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(4387, 157, false);
#line 147 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\ReceiptPanelMaster\AReceiptPanelMaster.cshtml"
           Write(Html.DropDownList("BankId", SubAcc.Select(s => new SelectListItem() { Text = s.Subacc_Name, Value = s.Com_id.ToString() }), new { @class = "form-control " }));

#line default
#line hidden
            EndContext();
            BeginContext(4544, 1229, true);
            WriteLiteral(@"

            </div>



            <div class=""form-group form-group-xs mt-20 col-md-1"">
                <a class=""btn btn-info btn-sm"" id=""AddItemBtn"" data-script=""#""><i class=""icon-add mr-5""></i>Add</a>
            </div>




        </div>
    </div>




    <div class=""clearfix""></div>


    <div class=""panel-body form-group panel panel-flat mt-5"" style=""height:322px; width:100%; overflow-y:auto;"" id=""table-div"">


        <div class=""table-responsive container-fluid quotaiontable"">
            <table class=""table table-xxs table-md table-bordered table-striped table-hover bg-lightgray dataTables_scrollBody"">




                <thead>
                    <tr class=""bg-blue-800"">

                        <th class=""col-lg-4"">Student</th>




                        <th class=""col-lg-1"">Amount</th>


                        <th class=""col-lg-1"">Actions</th>



                    </tr>



                </thead>


                <tbody class=""Voucher");
            WriteLiteral("Detail\">\r\n                </tbody>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n                <tfoot>\r\n                    <tr>\r\n\r\n\r\n                        <td class=\"text-right\">Total Amount</td>\r\n                        <td>");
            EndContext();
            BeginContext(5774, 101, false);
#line 217 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\ReceiptPanelMaster\AReceiptPanelMaster.cshtml"
                       Write(Html.TextBoxFor(m => m.Amt, new { @class = "form-control", type = "number", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(5875, 592, true);
            WriteLiteral(@"</td>






                    </tr>

                </tfoot>
















            </table>




        </div>


    </div>

















    <div class=""modal-footer mt-10 no-padding no-border"">




        <a data-url=""/Transaction/ReceiptPanelMaster"" data-script=""#"" class=""btn btn-danger btn-xs  closeBtn"" data-dismiss=""modal""><i class=""icon-cross""></i>Close</a>




        <button type=""button"" data-submit="""" class=""btn btn-primary  btn-xs  SaveBtn""><i class=""icon-floppy-disk position-left""></i>Save</button>
");
            EndContext();
            BeginContext(6617, 25, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SMSERP.Areas.Transaction.Models.ReceiptPanelMaster> Html { get; private set; }
    }
}
#pragma warning restore 1591