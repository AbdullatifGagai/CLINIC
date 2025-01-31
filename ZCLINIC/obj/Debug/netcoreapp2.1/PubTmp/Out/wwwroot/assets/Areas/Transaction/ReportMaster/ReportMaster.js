


if ($('#ReportId').val() > 0) {

    //$('tbody.MonthlyProDetails tr').each(function () {


    //    //     let store = $(this).children().eq(0);
    //    //   $(store).find('.Store').val($(store).find('.SalesId').val()).change();


    //    //$('tbody.saleOrderDetail tr').each(function () {
    //    //  //  let eyeside = $(this).children().eq(3)
    //    //  ///  let store = $(this).children().eq(7);
    //    // ///   $(eyeside).find('.EyeSideDrop').val($(eyeside).find('.EyeSide').val()).change();
    //    //  ///  $(store).find('.Store').val($(store).find('.StoreId').val()).change();
    //    //})

    //    //document.getElementById('OrderDate').valueAsDate = new Date();
    //    //document.getElementById('Send_Date').valueAsDate = new Date();
    //    //document.getElementById('Bill_Date').valueAsDate = new Date();


    ReportDetail($('#ReportId').val());





    $('#ReceiptNo').attr('disabled', 'true')
    $('#Mrno').attr('disabled', 'true')
    $('#PName').attr('disabled', 'true')
    $('#Age').attr('disabled', 'true')
    $('#DepId').attr('disabled', 'true')
    $('#testId').attr('disabled', 'true')
 










    //})
}
else {

    document.getElementById('CollectedDate').valueAsDate = new Date();
    document.getElementById('ReportDate').valueAsDate = new Date();
    document.getElementById('RecDate').valueAsDate = new Date();

   

    /// document.getElementById('FMonth').valueAsDate = new Date();
   // document.getElementById('TMonth').valueAsDate = new Date();


    //$('#UserName').val($('#personName').text());
    //$('#UserId').val($('#personId').val())


}

function ReportDetail(id) {



    GetJSONRequest('/Transaction/ReportDetail/Transaction_ReportDetailGetAll', 'GET', { id }, data => {


        debugger;
        let i = 0;


        if (data && data.length > 0) {
            $('#tbodytable').empty();
            for (const item of data) {
                i++;
                const markup = `
               <tr>


                                <td>
                                         <input type="hidden" class="form-control SerId" readonly value="${item.SerId}" />
                                         <input type="text" class="form-control ServicesName"  readonly value="${item.ServicesName}" />
                                </td>
                              

                                 <td>
                                         <input type="text" class="form-control Discri" readonly value="${item.Dis}" />
                                      
                                </td>
                      

                                   <td>
                                        <input type="text" class="form-control CutOff"  value="${item.CutOff}" />

                                </td>

            
                                 <td>
                                        <input type="text" class="form-control Result" value="${item.result}" />
                                      
                                </td>

                                  <td>
                                         <input type="text" class="form-control Unit" readonly value="${item.Unit}" />

                                </td>


                             
                            
                                    <td>
                                         <input type="text" class="form-control Refvalue" readonly value="${item.RefValue}" />

                                </td>

                                    <td>
                                         <input type="hidden" class="form-control HGroup" readonly value="${item.HGroup}" />

                                </td>




                             <td><a id=""><i class="icon-trash btn_delete text-danger-600"></i></a>




                 </tr>`;

                $('#tbodytable').append(markup);
                //calculateAdmAmt()
                //calculateAnnAmt()
                //calculateMonthlyAmt()
                //calculateDisTotalAmt()
                //calculateTotalAmt()

            }


            debugger;

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
































$('#AddItemPatient').click(function (e) {
   




      //  var id = $('#ReceiptNo').val();

    debugger;

    GetJSONRequest('/Transaction/ReceiptMaster/ReceiptMasterGetLabReceiptId', 'GET', null, function (data) {

            if (data && data.length > 0) {


                debugger;



               


                AllowSearch(data);


            }
            else

                ErrorAlert("No Data Found");
        })











 
});





function AllowSearch(data) {

    debugger;
    //$('#UnitId').val('');
    //$('#UnitName').val('');
    //$('#PlotNo').val('');
    //$('#SName').val('');


    $('#SModal').modal('show');
    $('.modal-dialog').addClass('modal-lg');

    $('#SModalTitle').text('Patient  List');
    let markup = `<div class="row">
         
                   <div class="col-sm-3">
                    <div class="input-group ">
                        <input type="text" class="form-control datasearch" placeholder="Filter" id="FilterInputoptpurchase">
                        <span class="input-group-addon bg-blue-800"><i class="icon-search4"></i></span>
                    </div>
                </div></div><table id="myTable" class="table datatable-basic table-xxs table-md table-bordered table-striped table-hover bg-lightgray dataTables_scrollBody">
				<thead>
					<tr class="bg-blue-800">
                        <th>ReceiptNo</th>
                        <th>ReceiptDate</th>
                        <th>MrNo</th>
                        <th>Patient Name</th>
                        <th>Services Name</th>



                        <th hidden>Age</th>
                        <th hidden>ReceiptId</th>
                        <th hidden>MrId</th>
                       
                        




                        <th>Actions</th>

					</tr>
				</thead><tbody>`;

    data.forEach((item) => {
        markup += `<tr><td>${item.ReceiptNo}</td><td>${item.ReceiptDate}</td><td>${item.MrNo}</td><td>${item.PatientName}</td><td>${item.ServicesName}</td><td hidden>${item.age}</td><td hidden>${item.ReceiptId}</td><td hidden>${item.MrId}</td><td><button type="button" class="selectAllowId btn btn-primary" id=${item.ReceiptId}>Select</button></td></tr>`

    })
    markup += `</tbody>`;
    $('#SModalBody').empty();

    $('#SModalBody').append(markup);

    $.extend($.fn.dataTable.defaults, {
        responsive: true,
        autoWidth: false,

        dom: '<"datatable-header"><"datatable-scroll-wrap"t><"datatable-footer"lip>',

    });

    purchasetable = $('.datatable-basic').DataTable({

        buttons: {
            dom: {
                button: {
                    className: 'btn btn-default'
                }
            },
            buttons: [

                'excelHtml5',
                'csvHtml5',
                {
                    extend: 'pdfHtml5',
                    orientation: 'portrait',
                    pageSize: 'A4',
                    exportOptions: {
                        columns: ':not(:last-child)',
                    },
                    customize: function (doc) {
                        doc.defaultStyle.fontSize = 7;
                    }
                }]

        },
        language: {
            search: '<span>Filter:</span> _INPUT_',
            lengthMenu: '_MENU_',
        },
        "lengthMenu": [[10, 25, 50, -1], [10, 25, 50, "All"]]

    });

    $('#SModalBody').delegate('#FilterInputoptpurchase', 'keyup', function () {
        debugger;

        purchasetable.search(this.value).draw();
    });

    $('#SModal').on('hidden.bs.modal', function (e) {
        debugger;
        purchasetable.search('').draw();
    })
}


$('#SModalBody').delegate('.selectAllowId', 'click', function () {


    
    $('#ReceiptId').val('');
    $('#ReceiptNo').val('');
    $('#Mrno').val('');
    $('#PName').val('');
    $('#Age').val('');
    $('#ReceiptId').val('');
    $('#MrId').val('');

    document.getElementById('CollectedDate').valueAsDate = new Date();


   // $('#ReceiptId').val($(this).closest('tr').children().eq(0).text());
    $('#ReceiptNo').val($(this).closest('tr').children().eq(0).text());
    $('#CollectedDate').val($(this).closest('tr').children().eq(1).text());
    $('#Mrno').val($(this).closest('tr').children().eq(2).text());
    $('#PName').val($(this).closest('tr').children().eq(3).text());
    $('#Age').val($(this).closest('tr').children().eq(5).text());
    $('#ReceiptId').val($(this).closest('tr').children().eq(6).text());
    $('#MrId').val($(this).closest('tr').children().eq(7).text());



    //$('#MrNo').val($(this).closest('tr').children().eq(1).text());
        //$('#PatientName').val($(this).closest('tr').children().eq(2).text());
        //$('#DateOfBirth').val($(this).closest('tr').children().eq(5).text());
        //$('#age').val($(this).closest('tr').children().eq(6).text());





    // $('#ProductId').val($(this).attr('id'));
    $('#SModal').modal('hide');
})

$('tbody.ChaDetails').delegate(".VoucherNO", "click", function () {
    debugger;



    const VoucherId = parseInt($(this).closest('tr').children().eq(0).find('.ChallanNo').val());

    console.log(VoucherId);

    GetJSONRequest('/Transaction/FeeVoucher/GetFeeVoucherNo', 'GET', { VoucherId }, function (data) {
        debugger;
        if (data && data.length > 0) {
            
            $('#MonthName').val(data[0].MonthName);
            $('#Amt').val(data[0].VoucherAmt);
            $('#MonId').val(data[0].MonthId);
           
            

            

        }
        else

            ErrorAlert("No Data Found");
    })



  

});





$('#AddItemBtn').click(() => { AddRow(); })





function AddRow() {




    debugger;
    var check = false;


    let Id = parseInt($('#testId').val());


    if (Id == 0 || Id == null) {


        ErrorAlert("Enter Test Name");
        check = true;

    }



    if (!check) {

       

        GetJSONRequest('/Master/Labtest/LabtestGetRefId', 'GET', { Id }, data => {

            if (data && data.length > 0) {

                //debugger;
                //console.log(data);
///              
                for (var item of data) {

                    
                 





                    const markup = `
                            <tr>
                              
                              
                                <td>
                                         <input type="hidden" class="form-control SerId" readonly value="${item.SerId}" />
                                         <input type="text" class="form-control ServicesName"  readonly value="${item.ServicesName}" />
                                </td>
                              

                                 <td>
                                         <input type="text" class="form-control Discri" readonly value="${item.Discri}" />
                                      
                                </td>


                               <td>
                                        <input type="text" class="form-control CutOff"  value="" />

                                </td>
            
                                 <td>
                                        <input type="text" class="form-control Result"  value="" />
                                      
                                </td>






<td>
                                         <input type="text" class="form-control Unit" readonly value="${item.Unit}" />

                                </td>


                             
                            

                                <td>
                                         <input type="text" class="form-control Refvalue" readonly value="${item.Refvalue}" />

                                </td>


                                <td>
                                         <input type="hidden" class="form-control HGroup" readonly value="${item.HGroup}" />

                                </td>


                             
                            
                                
                                

                                 
                                   
                              


                 </tr>`;
                    $('#tbodytable').append(markup);
                   
                }



            }
            else {

                ErrorAlert("No Data Found");
             ///   $('tbody.VoucherDetail').empty();


            }









        })




    }





}











































$('#tbodytable').delegate('.btn_delete', 'click', function () {

    debugger;



  
    $(this).closest('tr').remove();
    TotalSevAmt();
})

function TotalSevAmt() {
    var sum = 0;


    let TotalAmount = 0;
    $('.Rate').each(function () {
        TotalAmount += parseFloat($(this).val()) || 0;
    })
    $('#ServicesAmt').val(TotalAmount);
    $('#CashAmt').val(TotalAmount);
    $('#DisAmt ').val(0);
    $('#BalanceAmt').val(0);




}




$('#DisAmt,#CashAmt,#BalanceAmt').change (function () {



    debugger;

    const ServicesAmt = $('#ServicesAmt').val() || 0;
    const DisAmt = $('#DisAmt').val() || 0;
    const CashAmt = $('#CashAmt').val() || 0;
  //  const BalanceAmt = $('#BalanceAmt').val() || 0;

    //var row = $(this).closest("tr");
    //var qty = parseFloat(row.find(".Qtyfield").val() || 0);
    //var price = parseFloat(row.find(".Pricefield").val() || 0);
    //var Discount = parseFloat(row.find(".Discountfield").val() || 0);

    var totalAmt = ServicesAmt - DisAmt - CashAmt ;
    //var Sumtotal = total - Discount;

    $('#BalanceAmt').val(parseFloat(totalAmt).toFixed(2));

    //row.find(".OrderAmtfield").val(isNaN(total) ? "" : total);
    //row.find(".Amountfield").val(isNaN(Sumtotal) ? "" : Sumtotal);


    //calculateDebitSumAmount();
    //calculateCrditSumAmount();




})

$('#DepId').change(function () {
    let Id = parseInt($('#DepId').val());
    let RId = parseInt($('#ReceiptId').val());

    //  let PId = parseInt($('#PanelId').val());

    debugger;




    GetJSONRequest('/Master/Labtest/LabtestGetLabServices', 'GET', { Id, RId }, data => {

        if (data && data.length > 0) {
            $('#testId').empty();
            $('#testId').append(`<option value="0">Select Test Name</option>`);
            for (const model of data) {

                $('#testId').append(`<option value="${model.SerId}">${model.ServicesName}</option>`);

            }



            $('#DepId').attr('disabled', 'true')
       

            $('#testId').select2()



            return;



        }
        ErrorAlert("No Records Found");
        $('#testId').empty();


        /// $('#Comp_id').attr('disabled', 'true')

    })


})


















$('.SaveBtn').on('click', function () {
    //var PaymentM = $('#PaymentM').val();
    //var MrId = $('#MrId').val();
    //var MrNo = $('#MrNo').val();
    //var PatientName = $('#PatientName').val();
    //var age = $('#age').val();




    var check = false;




    //if (PaymentM == 0 || PaymentM == null) {


    //    ErrorAlert("Enter Payment Mode");
    //    check = true;

    //}

    //if (MrId ==  '' || MrNo == '' || PatientName == '', age == '') {


    //    ErrorAlert("Miss Value");
    //    check = true;

    //}

   
   
   




    if (!check) {




        debugger;










        var ReportMaster = [], ReportDetail = [];



        ReportMaster = {
            ReportId: $('#ReportId').val(),
            ReportCode: $('#ReportCode').val(),
            ReportNo: $('#ReportNo').val(),
            ReceiptId: $('#ReceiptId').val(),
            ReceiptNo: $('#ReceiptNo').val(),
            MrId: $('#MrId').val(),
            Mrno: $('#Mrno').val(),
            PName: $('#PName').val(),
            Age: $('#Age').val(),


            CollectedDate: $('#CollectedDate').val(),
            RecDate: $('#RecDate').val(),
            ReportDate: $('#ReportDate').val(),
            ReportTime: $('#ReportTime').val(),
            DepId: parseInt($('#DepId option:selected').val()),
            SerId: parseInt($('#testId option:selected').val()),
            Remarks: $('#Remarks').val(),
            FID: $('#FID').val(),
            MoId: parseInt($('#MoId option:selected').val()),












         



          





            //  StudentN: parseInt($('#StudentN option:selected').val()),


        }


        $('#tbodytable tr').each(function () {

            ReportDetail.push({



                ReportId: $('#ReportId').val(),
                Dis: $(this).find(".Discri").val(),
                Unit: $(this).find(".Unit").val(),

                CutOff: $(this).find(".CutOff").val(),

                result: $(this).find(".Result").val(),
                


                RefValue: $(this).find(".Refvalue").val(),
                SevId: parseInt($(this).find(".SerId").val()),
                HGroup: $(this).find(".HGroup").val(),

              




            });



        });
      




        console.log(ReportMaster);
        console.log(ReportDetail);



        debugger;

        var ReportId = $('#ReportId').val();

        if (ReportId > 0) {

            debugger;
            GetJSONRequest('/Transaction/ReportMaster/UpdateReportMaster', 'POST', { ReportMaster, ReportDetail }, function (data) {
                SuccessAlert("Data Saved");
                $('.closeBtn').trigger('click');
            });
        }
        else {

            debugger;


            GetJSONRequest('/Transaction/ReportMaster/SaveReportMaster', 'POST', { ReportMaster, ReportDetail }, function (data) {
                SuccessAlert("Data Saved");
                $('.closeBtn').trigger('click');



            });
        }



    }





});
