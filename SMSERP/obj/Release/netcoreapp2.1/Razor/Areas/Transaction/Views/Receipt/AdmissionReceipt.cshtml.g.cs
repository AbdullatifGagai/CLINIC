#pragma checksum "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\Receipt\AdmissionReceipt.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a36c241ad78c1c9d189e6aa91e99ee4c089143a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Transaction_Views_Receipt_AdmissionReceipt), @"mvc.1.0.view", @"/Areas/Transaction/Views/Receipt/AdmissionReceipt.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Transaction/Views/Receipt/AdmissionReceipt.cshtml", typeof(AspNetCore.Areas_Transaction_Views_Receipt_AdmissionReceipt))]
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
#line 2 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\Receipt\AdmissionReceipt.cshtml"
using SMSERP;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a36c241ad78c1c9d189e6aa91e99ee4c089143a", @"/Areas/Transaction/Views/Receipt/AdmissionReceipt.cshtml")]
    public class Areas_Transaction_Views_Receipt_AdmissionReceipt : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SMSERP.Areas.Transaction.Models.Receipt>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(65, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\Receipt\AdmissionReceipt.cshtml"
  
    string URL = Model == null ? "/Transaction/Receipt/SaveReceipt" : "/Transaction/Receipt/UpdateReceipt";
    int counter = 0;



   
        bool addview = SMSERP.UserRights.URM_AddNew_IsAuthenticated(Context.Session.GetRoleId(), "68");
        bool editview = SMSERP.UserRights.URM_Update_IsAuthenticated(Context.Session.GetRoleId(), "68");
        bool deleteview = SMSERP.UserRights.URM_Delete_IsAuthenticated(Context.Session.GetRoleId(), "68");
        bool Printview = SMSERP.UserRights.URM_Print_IsAuthenticated(Context.Session.GetRoleId(), "68");
  


















#line default
#line hidden
            BeginContext(679, 373, true);
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
            BeginContext(1053, 3, false);
#line 51 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\Receipt\AdmissionReceipt.cshtml"
                         Write(URL);

#line default
#line hidden
            EndContext();
            BeginContext(1056, 83, true);
            WriteLiteral("\" data-rurl=\"/Transaction/Receipt\" data-display=\"Bank Payment Voucher\">\r\n\r\n\r\n\r\n    ");
            EndContext();
            BeginContext(1140, 32, false);
#line 55 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\Receipt\AdmissionReceipt.cshtml"
Write(Html.HiddenFor(m => m.ReceiptId));

#line default
#line hidden
            EndContext();
            BeginContext(1172, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(1179, 30, false);
#line 56 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\Receipt\AdmissionReceipt.cshtml"
Write(Html.HiddenFor(m => m.PanelId));

#line default
#line hidden
            EndContext();
            BeginContext(1209, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(1216, 27, false);
#line 57 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\Receipt\AdmissionReceipt.cshtml"
Write(Html.HiddenFor(m => m.GrId));

#line default
#line hidden
            EndContext();
            BeginContext(1243, 258, true);
            WriteLiteral(@"




    <div class=""row"">



        <div class=""form-group form-group-xs col-md-12"">




            <div class=""form-group form-group-xs col-md-2"">
                <label>Receipt No<b class=""wysiwyg-color-red""></b></label>
                ");
            EndContext();
            BeginContext(1502, 107, false);
#line 73 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\Receipt\AdmissionReceipt.cshtml"
           Write(Html.TextBoxFor(m => m.ReceiptCode, new { @class = "form-control", type = "text", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(1609, 171, true);
            WriteLiteral("\r\n\r\n            </div>\r\n            <div class=\"form-group form-group-xs col-md-2\">\r\n                <label>GRNO<b class=\"wysiwyg-color-red\"></b></label>\r\n                ");
            EndContext();
            BeginContext(1781, 100, false);
#line 78 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\Receipt\AdmissionReceipt.cshtml"
           Write(Html.TextBoxFor(m => m.GRNo, new { @class = "form-control", type = "text", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(1881, 184, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n\r\n            <div class=\"form-group form-group-xs col-md-2\">\r\n                <label>Receipt  Date<b class=\"wysiwyg-color-red\"></b></label>\r\n                ");
            EndContext();
            BeginContext(2066, 77, false);
#line 85 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\Receipt\AdmissionReceipt.cshtml"
           Write(Html.TextBoxFor(m => m.RDate, new { @class = "form-control", type = "date" }));

#line default
#line hidden
            EndContext();
            BeginContext(2143, 175, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n\r\n            <div class=\"form-group form-group-xs col-md-3\">\r\n                <label>Name<b class=\"wysiwyg-color-red\"></b></label>\r\n                ");
            EndContext();
            BeginContext(2319, 100, false);
#line 92 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\Receipt\AdmissionReceipt.cshtml"
           Write(Html.TextBoxFor(m => m.Name, new { @class = "form-control", type = "text", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(2419, 178, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n            <div class=\"form-group form-group-xs col-md-2\">\r\n                <label>Group Id <b class=\"wysiwyg-color-red\"></b></label>\r\n                ");
            EndContext();
            BeginContext(2598, 103, false);
#line 98 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\Receipt\AdmissionReceipt.cshtml"
           Write(Html.TextBoxFor(m => m.GroupId, new { @class = "form-control", type = "text", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(2701, 159, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n        </div>\r\n    </div>\r\n\r\n\r\n    <div class=\"row\">\r\n\r\n\r\n\r\n        <div class=\"form-group form-group-xs col-md-12\">\r\n\r\n");
            EndContext();
            BeginContext(3155, 138, true);
            WriteLiteral("\r\n            <div class=\"form-group form-group-xs col-md-4\">\r\n                <label>MonthName<b class=\"wysiwyg-color-red\"></b></label>\r\n");
            EndContext();
#line 126 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\Receipt\AdmissionReceipt.cshtml"
                  
                    List<SMSERP.Areas.Master.Models.AcadmicYear> AcadmicYear = new SMSERP.Areas.Master.Models.AcadmicYear().Master_AcadmicYearGetAll(Context.Session.GetBValues(), Context.GetIP(), Context.GetCInfo());
                    AcadmicYear.Insert(0, new SMSERP.Areas.Master.Models.AcadmicYear { Id = 0, FeesTerm = "Select Month  Name" });
                

#line default
#line hidden
            BeginContext(3682, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(3699, 154, false);
#line 130 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\Receipt\AdmissionReceipt.cshtml"
           Write(Html.DropDownList("MonId", AcadmicYear.Select(s => new SelectListItem() { Text = s.FeesTerm, Value = s.Id.ToString() }), new { @class = "form-control " }));

#line default
#line hidden
            EndContext();
            BeginContext(3853, 177, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n\r\n            <div class=\"form-group form-group-xs col-md-2\">\r\n                <label>Amount<b class=\"wysiwyg-color-red\"></b></label>\r\n                ");
            EndContext();
            BeginContext(4031, 75, false);
#line 137 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\Receipt\AdmissionReceipt.cshtml"
           Write(Html.TextBoxFor(m => m.Amt, new { @class = "form-control", type = "text" }));

#line default
#line hidden
            EndContext();
            BeginContext(4106, 174, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n            <div class=\"form-group form-group-xs col-md-2\">\r\n                <label>RefId<b class=\"wysiwyg-color-red\"></b></label>\r\n                ");
            EndContext();
            BeginContext(4281, 101, false);
#line 143 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\Receipt\AdmissionReceipt.cshtml"
           Write(Html.TextBoxFor(m => m.RefId, new { @class = "form-control", type = "text", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(4382, 164, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n\r\n            <div class=\"form-group form-group-xs col-md-4\">\r\n                <label>Bank Name<b class=\"wysiwyg-color-red\"></b></label>\r\n");
            EndContext();
#line 150 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\Receipt\AdmissionReceipt.cshtml"
                  
                    List<SMSERP.Areas.Master.Models.Master_SubAccount> SubAcc = new SMSERP.Areas.Master.Models.Master_SubAccount().Master_SubAccountGetBankMaster(Context.Session.GetBValues(), Context.GetIP(), Context.GetCInfo());
                    SubAcc.Insert(0, new SMSERP.Areas.Master.Models.Master_SubAccount { Com_id = 0, Subacc_Name = "Select Bank  Name" });
                

#line default
#line hidden
            BeginContext(4955, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(4972, 157, false);
#line 154 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\Receipt\AdmissionReceipt.cshtml"
           Write(Html.DropDownList("BankId", SubAcc.Select(s => new SelectListItem() { Text = s.Subacc_Name, Value = s.Com_id.ToString() }), new { @class = "form-control " }));

#line default
#line hidden
            EndContext();
            BeginContext(5129, 285, true);
            WriteLiteral(@"

            </div>






        </div>
    </div>
    <div class=""modal-footer mt-10 no-padding no-border"">



        <button type=""button"" data-submit="""" id=""SaveMClear"" class=""btn btn-success btn-xs""><i class=""icon-floppy-disk position-left""></i>Clear</button>

");
            EndContext();
#line 171 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\Receipt\AdmissionReceipt.cshtml"
         if (addview)
        {

#line default
#line hidden
            BeginContext(5448, 156, true);
            WriteLiteral("            <button type=\"button\" data-submit=\"\" id=\"SaveMcode\" class=\"btn btn-primary btn-xs\"><i class=\"icon-floppy-disk position-left\"></i>Save</button>\r\n");
            EndContext();
#line 174 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\Receipt\AdmissionReceipt.cshtml"
        }

#line default
#line hidden
            BeginContext(5615, 298, true);
            WriteLiteral(@"

        <button type=""button"" class=""btn btn-danger btn-xs"" data-dismiss=""modal""><i class=""icon-cross""></i>Close</button>
        <a class=""hidden"" id=""RowWiseReport"" data-toggle=""tooltip"" title=""Report"" href=""/Report/Reportrdlc/AReport?"" data-heading=""Daily Purchase"" target=""_blank""></a>

");
            EndContext();
            BeginContext(6063, 55, true);
            WriteLiteral("\r\n    </div>\r\n\r\n\r\n    <div style=\"display:none;\">\r\n\r\n\r\n");
            EndContext();
            BeginContext(6371, 934, true);
            WriteLiteral(@"











    </div>

    <div class=""clearfix""></div>


    <div class=""panel-body form-group panel panel-flat mt-5"" style=""height:250px; width:100%; overflow-y:auto;"" id=""table-div"">


        <div class=""table-responsive container-fluid quotaiontable"">
            <table class=""table table-xxs table-md table-bordered table-striped table-hover bg-lightgray dataTables_scrollBody"">
                <thead>
                    <tr class=""bg-blue-800"">

                        <th>Receipt No</th>
                        <th>Receipt Date</th>

                        <th>Amount</th>


                        <th>Actions</th>


                    </tr>



                </thead>


                <tbody id=""ReceiptDetail"">
                </tbody>


























            </table>




        </div>


    </div>


    <script>

");
            EndContext();
            BeginContext(7363, 19, true);
            WriteLiteral("    var editview = ");
            EndContext();
            BeginContext(7383, 34, false);
#line 275 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\Receipt\AdmissionReceipt.cshtml"
              Write(Html.Raw(Json.Serialize(editview)));

#line default
#line hidden
            EndContext();
            BeginContext(7417, 24, true);
            WriteLiteral(";\r\n    var deleteview = ");
            EndContext();
            BeginContext(7442, 36, false);
#line 276 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\Receipt\AdmissionReceipt.cshtml"
                Write(Html.Raw(Json.Serialize(deleteview)));

#line default
#line hidden
            EndContext();
            BeginContext(7478, 23, true);
            WriteLiteral(";\r\n    var Printview = ");
            EndContext();
            BeginContext(7502, 35, false);
#line 277 "C:\Users\Administrator\Documents\GitHub\SMSERP\SMSERP\Areas\Transaction\Views\Receipt\AdmissionReceipt.cshtml"
               Write(Html.Raw(Json.Serialize(Printview)));

#line default
#line hidden
            EndContext();
            BeginContext(7537, 51, true);
            WriteLiteral(";\r\n\r\n    </script>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n</form>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SMSERP.Areas.Transaction.Models.Receipt> Html { get; private set; }
    }
}
#pragma warning restore 1591