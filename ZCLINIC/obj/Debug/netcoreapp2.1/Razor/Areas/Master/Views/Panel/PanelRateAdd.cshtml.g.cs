#pragma checksum "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\Panel\PanelRateAdd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54e2567ebf594928ace6e9ef868806676505ed32"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Master_Views_Panel_PanelRateAdd), @"mvc.1.0.view", @"/Areas/Master/Views/Panel/PanelRateAdd.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Master/Views/Panel/PanelRateAdd.cshtml", typeof(AspNetCore.Areas_Master_Views_Panel_PanelRateAdd))]
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
#line 3 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\Panel\PanelRateAdd.cshtml"
using ZCLINIC;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54e2567ebf594928ace6e9ef868806676505ed32", @"/Areas/Master/Views/Panel/PanelRateAdd.cshtml")]
    public class Areas_Master_Views_Panel_PanelRateAdd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ZCLINIC.Areas.Master.Models.PanelRate>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(66, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\Panel\PanelRateAdd.cshtml"
  
    string URL = Model == null ? "/Master/PanelRate/SavePanelRate" : "/Master/PanelRate/UpdatePanelRate";

    List<ZCLINIC.Areas.Master.Models.ClinicServices> ClinicServices = new ZCLINIC.Areas.Master.Models.ClinicServices().Master_ClinicServicesGetAll(Context.Session.GetBValues(), Context.GetIP(), Context.GetCInfo());



#line default
#line hidden
            BeginContext(404, 45, true);
            WriteLiteral("\r\n<form class=\"form-horizontal\" method=\"post\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 449, "\"", 454, 0);
            EndWriteAttribute();
            BeginContext(455, 11, true);
            WriteLiteral(" data-url=\"");
            EndContext();
            BeginContext(467, 3, false);
#line 14 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\Panel\PanelRateAdd.cshtml"
                                                       Write(URL);

#line default
#line hidden
            EndContext();
            BeginContext(470, 69, true);
            WriteLiteral("\" data-display=\"Master\" data-rurl=\"/Master/Master_Deparment\">\r\n\r\n    ");
            EndContext();
            BeginContext(540, 25, false);
#line 16 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\Panel\PanelRateAdd.cshtml"
Write(Html.HiddenFor(m => m.Id));

#line default
#line hidden
            EndContext();
            BeginContext(565, 255, true);
            WriteLiteral("\r\n\r\n    <div class=\"row\">\r\n\r\n        <div class=\"form-group form-group-xs\">\r\n            <label class=\"control-label col-sm-4\">Panel Id<b class=\"wysiwyg-color-red\">*</b></label>\r\n            <div class=\"form-group has-feedback col-sm-4\">\r\n                ");
            EndContext();
            BeginContext(821, 115, false);
#line 23 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\Panel\PanelRateAdd.cshtml"
           Write(Html.TextBoxFor(m => m.PanelId, new { @class = "form-control input-group", type = "text", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(936, 55, true);
            WriteLiteral("\r\n                <div class=\"form-control-feedback\"><i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 991, "\"", 999, 0);
            EndWriteAttribute();
            BeginContext(1000, 280, true);
            WriteLiteral(@"></i></div>
            </div>
        </div>

        <div class=""form-group form-group-xs"">
            <label class=""control-label col-sm-4"">Panel Name <b class=""wysiwyg-color-red"">*</b></label>
            <div class=""form-group has-feedback col-sm-8"">
                ");
            EndContext();
            BeginContext(1281, 168, false);
#line 31 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\Panel\PanelRateAdd.cshtml"
           Write(Html.TextBoxFor(m => m.PanelName, new { @class = "form-control input-group", placeholder = "Panel Name", type = "text", required = "required", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(1449, 55, true);
            WriteLiteral("\r\n                <div class=\"form-control-feedback\"><i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1504, "\"", 1512, 0);
            EndWriteAttribute();
            BeginContext(1513, 53, true);
            WriteLiteral("></i></div>\r\n            </div>\r\n        </div>\r\n\r\n\r\n");
            EndContext();
            BeginContext(2007, 849, true);
            WriteLiteral(@"




        <div class=""table-responsive container-fluid quotaiontable"">
            <table class=""table table-xxs table-md table-bordered table-striped table-hover bg-lightgray dataTables_scrollBody"">




                <thead>
                    <tr class=""bg-blue-800"">

                        <th class=""col-lg-3"">Services  Name</th>
                        <th class=""col-lg-1"">Rate</th>
                        

                        <th class=""col-lg-1"">Actions</th>



                    </tr>

                    <tr>
                        <th class=""col-lg-4"">
                            <select id=""ServicesId"" class=""form-control bootstrap-select"" data-style=""btn-default btn-xs"" data-search=""true"" data-width=""100%"">
                                <option value=""0"">--Select Services--</option>
");
            EndContext();
#line 69 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\Panel\PanelRateAdd.cshtml"
                                 foreach (var item in ClinicServices)
                                {

#line default
#line hidden
            BeginContext(2962, 43, true);
            WriteLiteral("                                    <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3005, "\"", 3029, 1);
#line 71 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\Panel\PanelRateAdd.cshtml"
WriteAttributeValue("", 3013, item.ServicesId, 3013, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3030, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(3032, 17, false);
#line 71 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\Panel\PanelRateAdd.cshtml"
                                                                Write(item.ServicesName);

#line default
#line hidden
            EndContext();
            BeginContext(3049, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 72 "C:\Users\Administrator\Documents\GitHub\CLINIC\ZCLINIC\Areas\Master\Views\Panel\PanelRateAdd.cshtml"
                                }

#line default
#line hidden
            BeginContext(3095, 599, true);
            WriteLiteral(@"                            </select>

                        </th>





                        

                        <th><input class=""form-control"" id=""Rate"" type=""number"" /></th>


                        


                        













                        <td>

                            <a id=""btn_add"" class=""text-primary-600""><i class=""icon-add""></i></a>

                        </td>

                    </tr>


                </thead>


                <tbody id=""tbodytable"">
                </tbody>










");
            EndContext();
            BeginContext(4065, 110, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n            </table>\r\n\r\n\r\n\r\n\r\n        </div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            EndContext();
            BeginContext(4536, 4606, true);
            WriteLiteral(@"
    </div>

</form>
<script>



    var PanelId = $('#PanelId').val();
    ServicesDetail(PanelId);




    $('#btn_add').on('click', function () {

        var ServicesId = $('#ServicesId').val();
        var Rate = $('#Rate').val();
       

        //var Session_ID = $('#Session_ID').val();


        var check = false;






        if (ServicesId == 0 || ServicesId == null) {
            ErrorAlert(""Enter Service  Name"");
            check = true;
        }

        if (Rate == null || Rate == 0) {
            ErrorAlert(""Enter Rate"");
            check = true;
        }

   


        if (!check) {


            // GetSchoolFee(Supcode, MonthID, Session_ID);












            var model = []



            model = {
                PanelId: $('#PanelId').val(),
                Id: ""0"",
                Code: ""0"",

                serId: parseInt($('#ServicesId option:selected').val()),
                Rate: $('#Rate').val(),
     ");
            WriteLiteral(@"          









            }








            console.log(model);
            ///console.log(PurchaseDetail);













            debugger;
            GetJSONRequest('/Master/PanelRate/SavePanelRate', 'POST', { model }, function (data) {



                if (data == ""OK"") {
                 SuccessAlert(""Data Saved"");
                var PanelId = $('#PanelId').val();
                ServicesDetail(PanelId);


                $('#ServicesId').val(0);

                $('#ServicesId').select2();


                $('#Rate').val('');
                }
                else {
                    ErrorAlert(data);
                }
               
             
              



            });


        }













    });



    function ServicesDetail(id) {



        GetJSONRequest('/Master/PanelRate/GetAllPanelRate', 'GET', { id }, data => {


            debugger;
            let i = 0;


         ");
            WriteLiteral(@"   $('#tbodytable').empty();
            if (data && data.length > 0) {

                for (const item of data) {
                    i++;
                    let markup = `<tr>

	
                     <td><input hidden class=""serId"" readonly value=""${item.serId}"" />${item.ServicesName}</td>
                     <td><input class=""Rate form-control"" readonly value=""${item.Rate}"" /></td>
                     
                    </td>
                    
                    <td><a class=""btn_delete text-danger-600""><i class=""icon-trash""></i></a></td>



			
                  </tr>`;

                    $('#tbodytable').append(markup);

                }


                debugger;
             ///   CalculateTotalAmount();
                // console.log(data);
                ///   DropDown2Initializers();
                //    $('#Supcode').val(data[0].Supcode).change();

                //$('#Remarks').val(data[0].Remarks);
                //$('#ItemId').val(data[0].ItemId)");
            WriteLiteral(@".change();
                //$('#Category').val(data[0].Category).change();
                //	$('#ReqDate').val(data[0].ReqDate);



                return;
            }
            ErrorAlert('No Record Found');
        })

    }



    function CalculateTotalAmount() {
        let TotalAmount = 0;
        $('.Amount').each(function () {
            TotalAmount += parseFloat($(this).val());
        })
        $('#TAmt').val(TotalAmount);
    }





    $('#tbodytable').delegate('.btn_delete', 'click', function () {
        const SerId = parseInt($(this).closest('tr').children().eq(0).find('.serId').val());
        const PId = $('#PanelId').val();




        debugger
        GetJSONRequest('/Master/PanelRate/DeletePanelRate', 'POST', { PId, SerId }, function (data) {
            SuccessAlert(""Data Saved"");

           
            ServicesDetail(PId);



        })


    })


    $('#ServicesId').change(function () {
        let Id = parseInt($('#ServicesId");
            WriteLiteral(@"').val());

        //debugger;

        $('#SevicesId').val(Id)


        GetJSONRequest('/Master/ClinicServices/Master_ClinicServicesGetIdServicesPanel', 'GET', { Id }, data => {

            if (data && data.length > 0) {




                $('#Rate').val(data[0].Rate);



            }

            else {
                ErrorAlert(""No Records Found"");
            }





            /// $('#Comp_id').attr('disabled', 'true')

        })


    })






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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ZCLINIC.Areas.Master.Models.PanelRate> Html { get; private set; }
    }
}
#pragma warning restore 1591
