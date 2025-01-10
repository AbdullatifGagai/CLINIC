


if ($('#ReceiptId').val() > 0) {

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


    ReceiptDetail($('#ReceiptId').val());

    //})
}
else {

    document.getElementById('ReceiptDate').valueAsDate = new Date();
    document.getElementById('DateOfBirth').valueAsDate = new Date();

   

    /// document.getElementById('FMonth').valueAsDate = new Date();
   // document.getElementById('TMonth').valueAsDate = new Date();


    //$('#UserName').val($('#personName').text());
    //$('#UserId').val($('#personId').val())


}

function  ReceiptDetail(id) {



    GetJSONRequest('/Transaction/ReceiptDetail/ReceiptDetailGetAll', 'GET', { id }, data => {


        debugger;
        let i = 0;


        if (data && data.length > 0) {
            $('#tbodytable').empty();
            for (const item of data) {
                i++;
                const markup = `
               <tr>


                                <td>
                                         <input type="hidden" class="form-control ServicesId" readonly value="${item.ServicesId}" />
                                         <input type="text" class="form-control ServicesName"  readonly value="${item.ServicesName}" />
                                </td>
                                
                                
                                    <td><input type="text" class="form-control Rate" readonly value="${item.Rate}" /></td>

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





function  ReceiptDetail(id) {



    GetJSONRequest('/Transaction/ReceiptDetail/ReceiptDetailGetAll', 'GET', { id }, data => {


        debugger;
        let i = 0;


        if (data && data.length > 0) {
            $('#tbodytable').empty();
            for (const item of data) {
                i++;
                const markup = `
               <tr>


                                <td>
                                         <input type="hidden" class="form-control ServicesId" readonly value="${item.ServicesId}" />
                                         <input type="text" class="form-control ServicesName"  readonly value="${item.ServicesName}" />
                                </td>
                                
                                
                                    <td><input type="text" class="form-control Rate" readonly value="${item.Rate}" /></td>

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











function ReceiptDetail(id) {



    GetJSONRequest('/Transaction/ReceiptDetail/ReceiptDetailGetAll', 'GET', { id }, data => {


        debugger;
        let i = 0;


        if (data && data.length > 0) {
            $('#tbodytable').empty();
            for (const item of data) {
                i++;
                const markup = `
               <tr>


                                <td>
                                         <input type="hidden" class="form-control ServicesId" readonly value="${item.ServicesId}" />
                                         <input type="text" class="form-control ServicesName"  readonly value="${item.ServicesName}" />
                                </td>
                                
                                
                                    <td><input type="text" class="form-control Rate" readonly value="${item.Rate}" /></td>

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


function ReceiptRefno(Id) {



    GetJSONRequest('/Transaction/ReceiptMaster/Transaction_ReceiptMasterGetRefNO', 'GET', { Id }, data => {


        debugger;
        let i = 0;


        if (data && data.length > 0) {
            $('#tbodytable').empty();
            for (const item of data) {
                i++;
                const markup = `
               <tr>


                                <td>
                                         <input type="hidden" class="form-control ServicesId" readonly value="${item.ServicesId}" />
                                         <input type="text" class="form-control ServicesName"  readonly value="${item.ServicesName}" />
                                </td>
                                
                                
                                    <td><input type="text" class="form-control Rate" readonly value="${item.Rate}" /></td>

                                


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

            $('#DocId').val(data[0].DocId);



            $('#DocId').val(data[0].DocId).change();
            $('#MrId').val(data[0].MrId);
            $('#MrNo').val(data[0].MrNo);
            $('#PatientName').val(data[0].PatientName);
            $('#PanelId').val(data[0].PanelId);
            $('#CategoryId').val(data[0].CategoryId).change();
            $('#DateOfBirth').val(data[0].DateOfBirth);
            $('#age').val(data[0].age);
            $('#ServicesAmt').val(data[0].ServicesAmt);
            $('#DisAmt').val(data[0].DisAmt);
            $('#BalanceAmt').val(data[0].BalanceAmt);
            $('#CashAmt').val(data[0].CashAmt);








            $('#CategoryId').attr('disabled', 'true')

            $('#DocId').attr('disabled', 'true');
            $('#MrId').attr('disabled', 'true');
            $('#MrNo').attr('disabled', 'true');
            $('#PatientName').attr('disabled', 'true');
            $('#PanelId').attr('disabled', 'true');
            $('#CategoryId').attr('disabled', 'true');
            $('#DateOfBirth').attr('disabled', 'true');
            $('#age').attr('disabled', 'true');
            $('#ServicesAmt').attr('disabled', 'true');
            $('#DisAmt').attr('disabled', 'true');
            $('#BalanceAmt').attr('disabled', 'true');
            $('#CashAmt').attr('disabled', 'true');



















            //$('#ItemId').val(data[0].ItemId).change();
            //$('#Category').val(data[0].Category).change();
            //	$('#ReqDate').val(data[0].ReqDate);



            return;
        }
        ErrorAlert('No Record Found');
    })

}





$('#RefNo').keyup(function (e) {
    if (e.keyCode == 13) {




        var Id = $('#RefNo').val();


        ReceiptRefno(Id);
       











    }
});








$('#PatientName').keyup(function (e) {
    if (e.keyCode == 13) {




        var PatientName = $('#PatientName').val();



        GetJSONRequest('/Master/PatientReg/GetPatientName', 'GET', { PatientName}, function (data) {

            if (data && data.length > 0) {


                debugger;



               


                AllowSearch(data);


            }
            else

                ErrorAlert("No Data Found");
        })












    }
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
                        <th>MRId</th>
                        <th>MrNo</th>
                        <th>Patient Name</th>
                        <th>Father Name</th>
                        <th>Cell no</th>
                        <th>Date Of Birth</th>
                        <th>Age</th>
						
						





                        <th>Actions</th>

					</tr>
				</thead><tbody>`;

    data.forEach((item) => {
        markup += `<tr><td>${item.MRId}</td><td>${item.MrNo}</td><td>${item.Name}</td><td>${item.Fname}</td><td>${item.Cellno}</td><td>${item.Bdate}</td><td>${item.PAge}</td><td><button type="button" class="selectAllowId btn btn-primary" id=${item.MRId}>Select</button></td></tr>`

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


    
    $('#MrId').val('');
    $('#MrNo').val('');
    $('#PatientName').val('');
    $('#DateOfBirth').val('');
    $('#Age').val('');
       



        $('#MrId').val($(this).closest('tr').children().eq(0).text());
        $('#MrNo').val($(this).closest('tr').children().eq(1).text());
        $('#PatientName').val($(this).closest('tr').children().eq(2).text());
        $('#DateOfBirth').val($(this).closest('tr').children().eq(5).text());
        $('#age').val($(this).closest('tr').children().eq(6).text());





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









$('#CategoryId').change(function () {
    let Id = parseInt($('#CategoryId').val());

    //debugger;

    $('#CategoryId').val(Id)


    GetJSONRequest('/Master/ClinicServices/Master_ClinicServicesGetServicesName', 'GET', { Id }, data => {

        if (data && data.length > 0) {
            $('#SevicesId').empty();
            $('#SevicesId').append(`<option value="0">Select Services</option>`);
            for (const model of data) {

                $('#SevicesId').append(`<option value="${model.ServicesId}">${model.ServicesName}</option>`);

            }



             $('#CategoryId').attr('disabled', 'true')
            $('#PanelId').attr('disabled', 'true')

            $('#SevicesId').select2()
          


            return;



        }
        ErrorAlert("No Records Found");
        $('#SevicesId').empty();
       

        /// $('#Comp_id').attr('disabled', 'true')

    })


})


$('#SevicesId').change(function () {
    let Id = parseInt($('#SevicesId').val());

    //debugger;

    $('#SevicesId').val(Id)


    GetJSONRequest('/Master/ClinicServices/Master_ClinicServicesGetIdServices', 'GET', { Id }, data => {

        if (data && data.length > 0) {
            



            $('#Rate').val(data[0].Rate);



        }

        else {
            ErrorAlert("No Records Found");
        }


    


        /// $('#Comp_id').attr('disabled', 'true')

    })


})































$('#age').change(function () {










    var PAge = $('#age').val();

    GetJSONRequest('/Master/PatientReg/Master_Daysbrith', 'GET', { PAge }, function (data) {



        if (data && data.length > 0) {













            $('#DateOfBirth').val(data[0].Bdate);



            //      $('#ProductId').val(data[0].ProductId);




        }
        else {



            ErrorAlert("No Data Found");


            //$('#Unit').val('');
            //$('#TPRate').val('');
            //$('#RetailRate').val('');

        }
    })







    //$('#Amount').val(parseInt(tAmt) - parseInt(Discout));
    //$('#OrderAmt').val(parseInt(tAmt));


})


$('#AddItemBtn').click(function () {




    if ($('#SevicesId option:selected').val() == "0") {
        ErrorAlert("SevicesId Name is Required")


        debugger;
    }




    //else if ($('#StoreName').val() == "0") {
    //    ErrorAlert("Store  is Required")
    //}

    else if ($('#Rate').val() == '') {
        ErrorAlert("Miss Value")
    }



    else {
        let markup = `<tr>
                     
                     <td><input type="hidden" class="form-control ServicesId" value="${$('#SevicesId option:selected').val()}"/>${$('#SevicesId option:selected').text()}</td>
                 
                     <td><input type="text" class="form-control  Rate"  readonly value="${$('#Rate').val()}"></td>
                    
                    
                  

                     
                      <td><a class="btn_delete text-danger-600"><i class="icon-trash"></i></a></td>
                      </tr>`
        $('#tbodytable').append(markup)

        TotalSevAmt();
      
        $('#Rate').val('');
      
        $('#SevicesId').val(0)
     
        $('#SevicesId').select2()

        //  Total_DisAmt();
        //Total_Saletex();
        //Total_Amount();


    }
})
$('#tbodytable').delegate('.btn_delete', 'click', function () {

    debugger;



    ///lstif
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







$('.SaveBtn').on('click', function () {
    var PaymentM = $('#PaymentM').val();




    var check = false;




    if (PaymentM == 0 || PaymentM == null) {


        ErrorAlert("Enter Payment Mode");
        check = true;

    }

    if (PanelId == 0 || PanelId == null) {


        ErrorAlert("Enter Panel    Name");
        check = true;

    }

   




    if (!check) {















        var ReceiptMaster = [], ReceiptDetail = [];



        ReceiptMaster = {
            ReceiptId: $('#ReceiptId').val(),
            ReceiptNo: $('#ReceiptNo').val(),
            RefNo: $('#RefNo').val(),
            RefNo: $('#RefNo').val(),
            DocId: parseInt($('#DocId option:selected').val()),
            MrId: $('#MrId').val(),
            MrNo: $('#MrNo').val(),
            PatientName: $('#PatientName').val(),
            PaymentM: parseInt($('#PaymentM option:selected').val()),
            PanelId: parseInt($('#PanelId option:selected').val()),
            CategoryId: parseInt($('#CategoryId option:selected').val()),
          



            DateOfBirth: $('#DateOfBirth').val(),
            age: $('#age').val(),
            ServicesAmt: $('#ServicesAmt').val(),
            DisAmt: $('#DisAmt').val(),
            CashAmt: $('#CashAmt').val(),
            BalanceAmt: $('#BalanceAmt').val(),
            age: $('#age').val(),



            





            //  StudentN: parseInt($('#StudentN option:selected').val()),


        }


        $('#tbodytable tr').each(function () {

            ReceiptDetail.push({



                ReceiptId: $('#ReceiptId').val(),
                ServicesId: parseInt($(this).find(".ServicesId").val()),
                Rate: parseFloat($(this).find(".Rate").val()),
                CategoryId: parseInt($('#CategoryId option:selected').val()),

              




            });



        });
      




        console.log(ReceiptMaster);
        console.log(ReceiptDetail);



        debugger;

        var ReceiptId = $('#ReceiptId').val();

        if (ReceiptId > 0) {

            debugger;
            GetJSONRequest('/Transaction/ReceiptMaster/UpdateReceiptMaster', 'POST', { ReceiptMaster, ReceiptDetail }, function (data) {
                SuccessAlert("Data Saved");
                $('.closeBtn').trigger('click');
            });
        }
        else {

            debugger;


            GetJSONRequest('/Transaction/ReceiptMaster/SaveReceiptMaster', 'POST', { ReceiptMaster, ReceiptDetail }, function (data) {
                SuccessAlert("Data Saved");
                $('.closeBtn').trigger('click');



            });
        }



    }





});
