#pragma checksum "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\FeeVoucher\AFeeVoucher.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "babc3188151cbdf3300b8fc19835c49a0532082f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Transaction_Views_FeeVoucher_AFeeVoucher), @"mvc.1.0.view", @"/Areas/Transaction/Views/FeeVoucher/AFeeVoucher.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Transaction/Views/FeeVoucher/AFeeVoucher.cshtml", typeof(AspNetCore.Areas_Transaction_Views_FeeVoucher_AFeeVoucher))]
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
#line 1 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\FeeVoucher\AFeeVoucher.cshtml"
using ZCLINIC;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"babc3188151cbdf3300b8fc19835c49a0532082f", @"/Areas/Transaction/Views/FeeVoucher/AFeeVoucher.cshtml")]
    public class Areas_Transaction_Views_FeeVoucher_AFeeVoucher : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ZCLINIC.Areas.Transaction.Models.FeeVoucher>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(68, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\FeeVoucher\AFeeVoucher.cshtml"
  
    string URL = Model == null ? "/Transaction/FeeVoucher/SaveFeeVoucher" : "/Transaction/FeeVoucher/UpdateFeeVoucher";
    int counter = 0;

#line default
#line hidden
            BeginContext(220, 373, true);
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
            BeginContext(594, 3, false);
#line 24 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\FeeVoucher\AFeeVoucher.cshtml"
                         Write(URL);

#line default
#line hidden
            EndContext();
            BeginContext(597, 76, true);
            WriteLiteral("\" data-rurl=\"/Transaction/FeeVoucher\" data-display=\"FeeVoucher\">\r\n\r\n\r\n\r\n    ");
            EndContext();
            BeginContext(674, 28, false);
#line 28 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\FeeVoucher\AFeeVoucher.cshtml"
Write(Html.HiddenFor(m => m.FeeId));

#line default
#line hidden
            EndContext();
            BeginContext(702, 244, true);
            WriteLiteral("\r\n    <div class=\"row\">\r\n\r\n\r\n\r\n        <div class=\"form-group form-group-xs col-md-12\">\r\n\r\n            <div class=\"form-group form-group-xs col-md-2\">\r\n                <label>Voucher No<b class=\"wysiwyg-color-red\"></b></label>\r\n                ");
            EndContext();
            BeginContext(947, 101, false);
#line 37 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\FeeVoucher\AFeeVoucher.cshtml"
           Write(Html.TextBoxFor(m => m.FeeId, new { @class = "form-control", type = "text", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(1048, 181, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n            <div class=\"form-group form-group-xs col-md-2\">\r\n                <label>Voucher Date<b class=\"wysiwyg-color-red\"></b></label>\r\n                ");
            EndContext();
            BeginContext(1230, 103, false);
#line 43 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\FeeVoucher\AFeeVoucher.cshtml"
           Write(Html.TextBoxFor(m => m.VouDate, new { @class = "form-control", type = "date", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(1333, 165, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n\r\n            <div class=\"form-group form-group-xs col-md-4\">\r\n                <label>Month Name<b class=\"wysiwyg-color-red\"></b></label>\r\n");
            EndContext();
#line 50 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\FeeVoucher\AFeeVoucher.cshtml"
                  
                    List<ZCLINIC.Areas.Master.Models.AcadmicYear> AcadmicYear = new ZCLINIC.Areas.Master.Models.AcadmicYear().Master_AcadmicYearGetAll(Context.Session.GetBValues(), Context.GetIP(), Context.GetCInfo());
                    AcadmicYear.Insert(0, new ZCLINIC.Areas.Master.Models.AcadmicYear { Id = 0, FeesTerm = "Select Month  Name" });
                

#line default
#line hidden
            BeginContext(1890, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(1907, 156, false);
#line 54 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\FeeVoucher\AFeeVoucher.cshtml"
           Write(Html.DropDownList("MonthId", AcadmicYear.Select(s => new SelectListItem() { Text = s.FeesTerm, Value = s.Id.ToString() }), new { @class = "form-control " }));

#line default
#line hidden
            EndContext();
            BeginContext(2063, 161, true);
            WriteLiteral("\r\n\r\n            </div>\r\n            <div class=\"form-group form-group-xs col-md-4\">\r\n                <label>Level Name<b class=\"wysiwyg-color-red\"></b></label>\r\n");
            EndContext();
#line 59 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\FeeVoucher\AFeeVoucher.cshtml"
                  
                    List<ZCLINIC.Areas.Master.Models.Levels> Levels = new ZCLINIC.Areas.Master.Models.Levels().Master_LevelsGetAll(Context.Session.GetBValues(), Context.GetIP(), Context.GetCInfo());
                    Levels.Insert(0, new ZCLINIC.Areas.Master.Models.Levels { LId = 0, LevelName = "Select Level  Name" });
                

#line default
#line hidden
            BeginContext(2588, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(2605, 153, false);
#line 63 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\FeeVoucher\AFeeVoucher.cshtml"
           Write(Html.DropDownList("LevelId", Levels.Select(s => new SelectListItem() { Text = s.LevelName, Value = s.LId.ToString() }), new { @class = "form-control " }));

#line default
#line hidden
            EndContext();
            BeginContext(2758, 557, true);
            WriteLiteral(@"

            </div>







        </div>
    </div>

    <div class=""row"">



        <div class=""form-group form-group-xs col-md-12"">

            <div class=""form-group form-group-xs col-md-3"">
                <label>Student Name<b class=""wysiwyg-color-red""></b></label>
                <select class=""form-control combo-box"" id=""StudentN"" type=2 name=""ModelId""></select>

            </div>


            <div class=""form-group form-group-xs col-md-3"">
                <label>Status<b class=""wysiwyg-color-red""></b></label>
");
            EndContext();
#line 91 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\FeeVoucher\AFeeVoucher.cshtml"
                  

                    var Status = new List<(int Id, string Name)>();
                    Status.Add((Id: 0, Name: "All"));
                    Status.Add((Id: 1, Name: "Admission Fee"));
                    Status.Add((Id: 2, Name: "Annual Fee"));
                    Status.Add((Id: 3, Name: "Montly Fee"));



                

#line default
#line hidden
            BeginContext(3675, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(3692, 239, false);
#line 102 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\FeeVoucher\AFeeVoucher.cshtml"
           Write(Html.DropDownList("LeaveF", Status.Select(p => new SelectListItem() { Text = p.Name, Value = p.Id.ToString() }), new { @class = "form-control", data_style = "btn-default btn-xs", tabindex = '4', data_search = "true", data_width = "100%" }));

#line default
#line hidden
            EndContext();
            BeginContext(3931, 179, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n\r\n            <div class=\"form-group form-group-xs col-md-2\">\r\n                <label>Due Date<b class=\"wysiwyg-color-red\"></b></label>\r\n                ");
            EndContext();
            BeginContext(4111, 79, false);
#line 109 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\FeeVoucher\AFeeVoucher.cshtml"
           Write(Html.TextBoxFor(m => m.DueDate, new { @class = "form-control", type = "date" }));

#line default
#line hidden
            EndContext();
            BeginContext(4190, 174, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n            <div class=\"form-group form-group-xs col-md-2\">\r\n                <label>RefId<b class=\"wysiwyg-color-red\"></b></label>\r\n                ");
            EndContext();
            BeginContext(4365, 101, false);
#line 115 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\FeeVoucher\AFeeVoucher.cshtml"
           Write(Html.TextBoxFor(m => m.RefId, new { @class = "form-control", type = "text", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(4466, 506, true);
            WriteLiteral(@"

            </div>






            <div class=""form-group form-group-xs mt-20 col-md-1"">
                <a class=""btn btn-info btn-sm"" id=""AddItemBtn"" data-script=""#""><i class=""icon-add mr-5""></i>Add</a>
            </div>




        </div>
    </div>

    <div class=""row"">



        <div class=""form-group form-group-xs col-md-12"">

            <div class=""form-group form-group-xs col-md-4"">
                <label>Account Name<b class=""wysiwyg-color-red""></b></label>
");
            EndContext();
#line 142 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\FeeVoucher\AFeeVoucher.cshtml"
                  
                    List<ZCLINIC.Areas.Master.Models.Master_SubAccount> SubAcc = new ZCLINIC.Areas.Master.Models.Master_SubAccount().Master_SubAccountGetBankMaster(Context.Session.GetBValues(), Context.GetIP(), Context.GetCInfo());
                    SubAcc.Insert(0, new ZCLINIC.Areas.Master.Models.Master_SubAccount { Com_id = 0, Subacc_Name = "Select Bank  Name" });
                

#line default
#line hidden
            BeginContext(5384, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(5401, 157, false);
#line 146 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\FeeVoucher\AFeeVoucher.cshtml"
           Write(Html.DropDownList("BankId", SubAcc.Select(s => new SelectListItem() { Text = s.Subacc_Name, Value = s.Com_id.ToString() }), new { @class = "form-control " }));

#line default
#line hidden
            EndContext();
            BeginContext(5558, 191, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n\r\n\r\n\r\n\r\n            <div class=\"form-group form-group-xs col-md-2\">\r\n                <label>Penalty Amount<b class=\"wysiwyg-color-red\"></b></label>\r\n                ");
            EndContext();
            BeginContext(5750, 82, false);
#line 156 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\FeeVoucher\AFeeVoucher.cshtml"
           Write(Html.TextBoxFor(m => m.penaltyAmt, new { @class = "form-control", type = "text" }));

#line default
#line hidden
            EndContext();
            BeginContext(5832, 1260, true);
            WriteLiteral(@"

            </div>










        </div>
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    </div>


    <div class=""clearfix""></div>


    <div class=""panel-body form-group panel panel-flat mt-5"" style=""height:322px; width:100%; overflow-y:auto;"" id=""table-div"">


        <div class=""table-responsive container-fluid quotaiontable"">
            <table class=""table table-xxs table-md table-bordered table-striped table-hover bg-lightgray dataTables_scrollBody"">




                <thead>
                    <tr class=""bg-blue-800"">

                        <th class=""col-lg-2"">Student</th>
                        <th class=""col-lg-2"">Panel Name</th>

                        <th class=""col-lg-1"">GrNO</th>
                        <th class=""col-lg-1"">Adm.Amt</th>
                        <th class=""col-lg-1"">Ann.Amt</th>
                        <th class=""col-lg-1"">Monthly</th>
                        <th class=""col");
            WriteLiteral("-lg-1\">Discount</th>\r\n\r\n                        <th class=\"col-lg-1\">TotalAmt</th>\r\n                        <th class=\"col-lg-1\">ChNo</th>\r\n\r\n                        <th class=\"col-lg-1\">Actions</th>\r\n\r\n\r\n\r\n                    </tr>\r\n\r\n");
            EndContext();
            BeginContext(7498, 81, true);
            WriteLiteral("\r\n\r\n                </thead>\r\n\r\n\r\n                <tbody class=\"VoucherDetail\">\r\n");
            EndContext();
            BeginContext(8429, 242, true);
            WriteLiteral("\r\n                </tbody>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n                <tfoot>\r\n                    <tr>\r\n\r\n                        <td colspan=\"2\"></td>\r\n                        <td class=\"text-right\">Total Amount</td>\r\n                        <td>");
            EndContext();
            BeginContext(8672, 103, false);
#line 290 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\FeeVoucher\AFeeVoucher.cshtml"
                       Write(Html.TextBoxFor(m => m.AdAmt, new { @class = "form-control", type = "number", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(8775, 41, true);
            WriteLiteral("</td>\r\n\r\n\r\n\r\n                        <td>");
            EndContext();
            BeginContext(8817, 104, false);
#line 294 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\FeeVoucher\AFeeVoucher.cshtml"
                       Write(Html.TextBoxFor(m => m.AnnAmt, new { @class = "form-control", type = "number", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(8921, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(8957, 107, false);
#line 295 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\FeeVoucher\AFeeVoucher.cshtml"
                       Write(Html.TextBoxFor(m => m.MontlyAmt, new { @class = "form-control", type = "number", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(9064, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(9100, 105, false);
#line 296 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\FeeVoucher\AFeeVoucher.cshtml"
                       Write(Html.TextBoxFor(m => m.MDisAmt, new { @class = "form-control", type = "number", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(9205, 37, true);
            WriteLiteral("</td>\r\n\r\n                        <td>");
            EndContext();
            BeginContext(9243, 105, false);
#line 298 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Transaction\Views\FeeVoucher\AFeeVoucher.cshtml"
                       Write(Html.TextBoxFor(m => m.TAmount, new { @class = "form-control", type = "number", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(9348, 578, true);
            WriteLiteral(@"</td>



                    </tr>

                </tfoot>
















            </table>




        </div>


    </div>

















    <div class=""modal-footer mt-10 no-padding no-border"">




        <a data-url=""/Transaction/FeeVoucher"" data-script=""#"" class=""btn btn-danger btn-xs  closeBtn"" data-dismiss=""modal""><i class=""icon-cross""></i>Close</a>




        <button type=""button"" data-submit="""" class=""btn btn-primary  btn-xs  SaveBtn""><i class=""icon-floppy-disk position-left""></i>Save</button>
");
            EndContext();
            BeginContext(10076, 25, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ZCLINIC.Areas.Transaction.Models.FeeVoucher> Html { get; private set; }
    }
}
#pragma warning restore 1591
