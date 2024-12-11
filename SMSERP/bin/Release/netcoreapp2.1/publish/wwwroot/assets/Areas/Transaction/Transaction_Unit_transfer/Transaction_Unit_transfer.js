





$('#Vmode').change(() => {


    debugger;
    if ($('#Vmode').val() != '') {




        var Id = $('#Vmode').val()






        GetJSONRequest('/Master/Master_Vmode/GetVmodeId', 'GET', { Id }, function (data) {

            if (data && data.length > 0) {



                $('#DebitAccName').val(data[0].SubNamedebit);
                $('#DebitAcc').val(data[0].SubCodedebit);


                $('#CreditAccName').val(data[0].SubNamecredit);
                $('#CrditAcc').val(data[0].SubCodecredit);


            }
            else {

                ErrorAlert("No Data Found");

                $('#DebitAcc').val('')
                $('#CrditAcc').val('')
                $('#CreditAccName').val('')
                $('#DebitAccName').val('')


            }

                

        })


    }

    else {
        ErrorAlert("Missing Value");
    }

})



$('#btnUpdate').click(() => {


        var Id = $('#Vmode').val()


     



        GetJSONRequest('/Transaction/Transaction_UnitAllow/GetUnitListM', 'GET', { Id }, function (data) {
         
            if (data && data.length > 0) {

                debugger;
                for (var item of data) {
                   
                    const markup = `
                            <tr>
                              
                              
                                <td>
                                         <input type="hidden" class="form-control UnitIdfield" readonly value="${item.Unit_Id}" />
                                         <input type="text" class="form-control UnitNamefield"  readonly value="${item.UnitName}" />
                                </td>
                              
                                
                                

                                 
                                     <td><input type="text" class="form-control  Amountfield" readonly  value="${item.Amount}"></td>
                              
                                <td><a id=""><i class="icon-trash removeitem text-danger-600"></i></a>
                            </tr>`;
                    $('tbody.MonthlyProDetails').append(markup);
                    calculateSumTotalAmt()
                }

             

            }
            else { 

                ErrorAlert("No Data Found");
            }

         })


    

})



function calculateSumTotalAmt() {
    var sum = 0;
    $(".Amountfield").each(function () {
        if (!isNaN(this.value) && this.value.length != 0) {
            sum += parseFloat(this.value);
        }
    });

    $("#TAmt").val(sum.toFixed(2));
}
















  



$(document).ready(function () {

    debugger;

    $('#OrBookId').val($('#personId').val())
    $('#UserName').val($('#personName').text())
 


    /* $('#VOUCHER_MODE').val('BPV').text()*/
})



$('#AddItemBtn').click(() => { AddRow(); })
//$('.remarkid').keyup(e => {

//    if (e.keyCode == 13) {
//        AddRow();
//        $("#ProductCode").focus();
//    }
//})

function AddRow() {
    debugger;
    
   // if ($('#AccountId').val() != '') {
    const TotalRows = $('tbody.MonthlyProDetails tr').length + 1; //serial no generation need to be resolved
        const markUp = `<tr>
                   
           
                    <td>
                   <input type="hidden" class="form-control UnitIdfield" readonly value="${$('#UnitId').val()}">
                    <input type="text" class="form-control UnitNamefield" readonly value="${$('#UnitId option:selected').text()}">
                    </td>

                     <td><input type="text" class="form-control Amountfield" value="${$('#Amount').val()}"></td>
           
                    <td><a id=""><i class="icon-trash removeitem text-danger-600"></i></a></td>
                   </tr>`;

    $('tbody.MonthlyProDetails').append(markUp);
    
    $('#UnitId').val(0).select2();


    /*  $('#UnitId' + TotalRows).val($('#UnitId').val()).change();*/
            

   



        $('.TxtBox').val('');
    calculateSumTotalAmt()
   // calculateDebitSumAmount();
  //  calculateCrditSumAmount();
  


}











$("tbody.MonthlyProDetails").delegate(".removeitem", "click", function () {



    $(this).closest('tr').remove();
    calculateSumTotalAmt()
    debugger;



  //  calculateDebitSumAmount();
//    calculateCrditSumAmount();

});







$('.SaveBtn').click(() => {



    debugger;
    let counter = 0;

    //const DebitAmt = $('#TDebitAmt').val() || 0;
    //const CreditAmt = $('#TCreditAmt').val() || 0;

    var  GridBodyRows = $('tbody.MonthlyProDetails tr');
    let check = false;
    GridBodyRows.each(function () {
        //  const keptqty = $(this).children().eq(0).find('.KeptQtyfield').val() || 0;




        //if ($(this).children().eq(0).find('.SUB_CODE').val() == 0) {
        //    check = true;
        //    return false;
        //}




    })






    if (!check) {

      //  debugger;
        GridBodyRows.each(function () {

          //  $(this).children().eq(1).find('.UnitId').attr('name', 'MonthlyProDetails[' + counter + '].UnitId');
            $(this).children().eq(0).find('.UnitIdfield').attr('name', 'MonthlyProDetail[' + counter + '].UnitId');
            $(this).children().eq(1).find('.Amountfield').attr('name', 'MonthlyProDetail[' + counter + '].Amt');

           

            counter++;

           
           
        })
        $('.SaveBtn').attr('data-submit', true);
     

    }
    else {
        ErrorAlert('Please Select Account Name Or Debit and Credit Not Equal')
    }
})














$('#btnCPDList').click(() => {





    GetJSONRequest('/Transaction/Transaction_CPDForm/GetAllList', 'GET', '', function (data) {

        if (data && data.length > 0) {

            CPDIDSearch(data);


        }
        else

            ErrorAlert("No Data Found");
    })




})



$('#AllotmentList').click(() => {





    GetJSONRequest('/Transaction/Transaction_UnitAllow/GetAllowment', 'GET', '', function (data) {

        if (data && data.length > 0) {


            debugger;

              AllowSearch(data);


        }
        else

            ErrorAlert("No Data Found");
    })




})
























function CPDIDSearch(data) {

    debugger;
    //$('#UnitId').val('');
    //$('#UnitName').val('');
    //$('#PlotNo').val('');
    //$('#SName').val('');
    $('#Tran_MID').val('');
    $('#TransferName').val('');
    $('#Transfermobile').val('');
    $('#TransferNic').val('');

    $('#SModal').modal('show');
    $('.modal-dialog').addClass('modal-lg');

    $('#SModalTitle').text('CPD List');
    let markup = `<div class="row">
         
                   <div class="col-sm-3">
                    <div class="input-group ">
                        <input type="text" class="form-control datasearch" placeholder="Filter" id="FilterInputoptpurchase">
                        <span class="input-group-addon bg-blue-800"><i class="icon-search4"></i></span>
                    </div>
                </div></div><table id="myTable" class="table datatable-basic table-xxs table-md table-bordered table-striped table-hover bg-lightgray dataTables_scrollBody">
				<thead>
					<tr class="bg-blue-800">
                        <th>CPDID</th>
						<th>Name</th>
						<th>Int</th>
						<th>Father Name</th>

                        <th>NICNo</th>
                        <th>Mobile</th>
						
                        
                        <th>Actions</th>

					</tr>
				</thead><tbody>`;

    data.forEach((item) => {
        markup += `<tr><td>${item.CPDID}</td><td>${item.Name}</td><td>${item.Int}</td><td>${item.Fname}</td><td>${item.NicNo}</td><td>${item.Mobileno}</td><td><button  type="button" class="selectCPDBtn btn btn-primary" id=${item.UnitId}>Select</button></td></tr>`

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


$('#SModalBody').delegate('.selectCPDBtn', 'click', function () {

    $('#Tran_MID').val($(this).closest('tr').children().eq(0).text());
    $('#TransferName').val($(this).closest('tr').children().eq(1).text());
    $('#Transfermobile').val($(this).closest('tr').children().eq(5).text());
    $('#TransferNic').val($(this).closest('tr').children().eq(4).text());


   
    // $('#ProductId').val($(this).attr('id'));
    $('#SModal').modal('hide');
})



function AllowSearch(data) {

    debugger;
    //$('#UnitId').val('');
    //$('#UnitName').val('');
    //$('#PlotNo').val('');
    //$('#SName').val('');
  

    $('#SModal').modal('show');
    $('.modal-dialog').addClass('modal-lg');

    $('#SModalTitle').text('CPD List');
    let markup = `<div class="row">
         
                   <div class="col-sm-3">
                    <div class="input-group ">
                        <input type="text" class="form-control datasearch" placeholder="Filter" id="FilterInputoptpurchase">
                        <span class="input-group-addon bg-blue-800"><i class="icon-search4"></i></span>
                    </div>
                </div></div><table id="myTable" class="table datatable-basic table-xxs table-md table-bordered table-striped table-hover bg-lightgray dataTables_scrollBody">
				<thead>
					<tr class="bg-blue-800">
                        <th>AllowID</th>
						<th>Unit_id</th>
						<th>UnitName</th>
						<th>CPDID</th>
						<th>Name</th>

                        <th>NicNo</th>
                        <th>Mobile</th>
						
                        
                        <th>Actions</th>

					</tr>
				</thead><tbody>`;

    data.forEach((item) => {
        markup += `<tr><td>${item.AllowID}</td><td>${item.Unit_Id}</td><td>${item.UnitName}</td><td>${item.CPDID}</td><td>${item.Name}</td><td>${item.NicNo}</td><td>${item.Mobileno}</td><td><button  type="button" class="selectAllowId btn btn-primary" id=${item.AllowID}>Select</button></td></tr>`

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


    $('#AllowID').val($(this).closest('tr').children().eq(0).text());

    $('#UnitId').val($(this).closest('tr').children().eq(1).text());
    $('#UnitName').val($(this).closest('tr').children().eq(2).text());
  
    $('#Allow_MID').val($(this).closest('tr').children().eq(3).text());
    $('#AllowName').val($(this).closest('tr').children().eq(4).text());
    $('#CNIC').val($(this).closest('tr').children().eq(5).text());
    $('#Mobile').val($(this).closest('tr').children().eq(6).text());

    debugger;


    // $('#ProductId').val($(this).attr('id'));
    $('#SModal').modal('hide');
})











$('#ReferenceId').val('00' + $('#RefId option:selected').val());

$('#RefId').change(function () {

    $('#ReferenceId').val('00' + $(this).val());
})



//function saveData() {
//    var EntRepairing = {}, MonthlyProDetails = []; 

//    EntRepairing = {
//        OrderCode: $('#OrderCode').val(),
//        OrderRef: $('#OrderRef').val(),
//        RefRemarks: $('#RefRemarks').val(),
//        LabDate: $('#LabDate').val(),
//        DeliveryDate: $('#DeliveryDate').val(),
//        CustomerID: parseInt($('#CustomerId option:selected').val()),
//        Address: $('#Address').val(),
//        MobileNo: $('#MobileNo').val(),
//        RefID: parseInt($('#RefId  option:selected').val()),
//        PaymentId: parseInt($('#PaymentId option:selected').val()),
//        MonthlyProDetails: MonthlyProDetails,
//        ServicesAmt: 0,
//        TotalDiscount: 0,
//        TotalAmount: 0
//    }

//    $('.MonthlyProDetails tr').each(function () {
//        MonthlyProDetails.push({
//            ProductName: $(this).find('td:eq(2)').text(),
//            Qty: $(this).find('.Qtyfield').val(),
//            UnitPrice: $(this).find('.Pricefield').val(),
//            Discount: $(this).find('.Discountfield').val(),
//            Amount: $(this).find('.Amountfield').val(),
//            StoreId: $(this).find('.StoreId1 option:selected').val(),
//            Complain: $(this).find('.Complainfield').val(),
//            Accessories: $(this).find('.Accessoriesfield').val(),
//        });
//    });

//    console.log(EntRepairing);

//    GetJSONRequest('/Transaction/ENTRepairing/SaveENTRepairing', 'POST', EntRepairing, function (data) {

//    });
//}


//$('#btn_save').on('click', function () {
//    saveData();
//});
if ($('#TranID').val() > 0) {

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


    //})
}
else {

    document.getElementById('W_date').valueAsDate = new Date();


    //$('#UserName').val($('#personName').text());
    //$('#UserId').val($('#personId').val())


}
