




























//$('.file-input').change(function (e) {

//    debugger;
//    if (this.files.length == 0) {
//        $('#ImagePath').val("");

//        return;
//    }



//    var filename = e.target.value;

//    var allowed_extensions = new Array("jpg", "png", "jpeg");
//    var file_extension = filename.split('.').pop().toLowerCase();
//    var result = false;
//    for (var i = 0; i <= allowed_extensions.length; i++) {
//        if (allowed_extensions[i] == file_extension) {
//            result = true;
//            break;
//        } else {
//            result = false
//        }
//    }
//    if (result === false) {
//        ErrorAlert("Upload Only Image")
//    } else {


//        var formData = new FormData();
//        formData.append("file", e.target.files[0]);
//        $.ajax({
//            url: "/Master/CPDDetail/UploadImage",
//            type: 'POST',
//            cache: false,
//            contentType: false,
//            processData: false,
//            data: formData,
//            success: function (response) {
//                $('#ImagePath').val(response);


//            }
//        });




if ($('#AllowID').val() > 0) {
   
    $('tbody.BankVoucherDetails tr').each(function () {
     
              
   //     let store = $(this).children().eq(0);
     //   $(store).find('.Store').val($(store).find('.SalesId').val()).change();
      
  
         //$('tbody.saleOrderDetail tr').each(function () {
    //  //  let eyeside = $(this).children().eq(3)
    //  ///  let store = $(this).children().eq(7);
    // ///   $(eyeside).find('.EyeSideDrop').val($(eyeside).find('.EyeSide').val()).change();
    //  ///  $(store).find('.Store').val($(store).find('.StoreId').val()).change();
    //})

       // /document.getElementById('Bill_Date').valueAsDate = new Date();
     

    })
}
else {
    //$('#NicNo').val($('#personName').text())
    //$('#NicNo').val($('#personName').text())

    document.getElementById('Wdate').valueAsDate = new Date();
  //  document.getElementById('DOB').valueAsDate = new Date();


    //  document.getElementById('NicNo').valueAsDate = new Date();

    //$('#UserName').val($('#personName').text());
    //$('#UserId').val($('#personId').val())
   
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
        const TotalRows = $('tbody.BankVoucherDetails tr').length + 1; //serial no generation need to be resolved
        const markUp = `<tr>
                   
           
            <td><input type="text" class="form-control" readonly value="${$('#SUB_CODE option:selected').text()}"><input type="hidden" class="SUB_CODE form-control" value="${$('#SUB_CODE').val()}"></td>
            
            <td><input type="text" class="form-control Remarksfield" value="${$('#Remarks').val()}"></td>
            <td><input type="text" class="form-control Debitfield" value="${$('#DebitAmt').val()}"></td>
            <td><input type="text" class="form-control Creditfield " value="${$('#CreditAmt').val()}"></td>
           
        
            
           
                    <td><a id=""><i class="icon-trash removeitem text-danger-600"></i></a></td>
                   </tr>`;

    $('tbody.BankVoucherDetails').append(markUp);
     // $('#AccountId' + TotalRows).val($('#AccountId').val()).change();
            




  



        $('.TxtBox').val('');
     
    calculateDebitSumAmount();
    calculateCrditSumAmount();
  


}










function GenerateSerialNo(a) {

    const rows = $('tbody.BankVoucherDetails tr');
    let counter = 0;
    $(rows).each(function () {
        counter += 1;
        $(this).children().eq(0).text('000' + counter);
    })



}



$('#UnitPrice,#Qty,#Discount').change(function () {



    const Price = $('#UnitPrice').val() || 0;
    const Discout = $('#Discount').val() || 0;
    const OrderAmt = $('#OrderAmt').val() || 0;

    var tAmt = 0;



    tAmt = parseInt($('#Qty').val()) * parseInt(Price);
    $('#Amount').val(parseInt(tAmt) - parseInt(Discout));
    $('#OrderAmt').val(parseInt(tAmt));


})



$('#TotalPartAmount,#TotalServicesAmount,#TotalAdvanceAmount,#TotalSpecialDiscount,#TotalPaymentAmount').change(function () {

    calculateSumBal();


    debugger;


})















$('tbody.BankVoucherDetails').delegate('.Debitfield,.Creditfield', 'change', function () {


   // const Price = $('#UnitPrice').val() || 0;
  ///  const Discout = $('#Discount').val() || 0;
   
    //var row = $(this).closest("tr");
    //var qty = parseFloat(row.find(".Qtyfield").val() || 0);
    //var price = parseFloat(row.find(".Pricefield").val() || 0);
    //var Discount = parseFloat(row.find(".Discountfield").val() || 0);

    //var total = qty * price;
    //var Sumtotal = total - Discount;



    //row.find(".OrderAmtfield").val(isNaN(total) ? "" : total);
    //row.find(".Amountfield").val(isNaN(Sumtotal) ? "" : Sumtotal);


    calculateDebitSumAmount();
    calculateCrditSumAmount();




})

function calculateDebitSumAmount() {
    var sum = 0;


    let TotalAmount = 0;
    $('.Debitfield').each(function () {
        TotalAmount += parseFloat($(this).val()) || 0;
    })
    $('#TDebitAmt').val(TotalAmount);


    //$(".Debit_field").each(function () {
    //    if (!isNaN(this.value) && this.value.length != 0) {
    //        sum += parseFloat(this.value);
    //    }
    //});

    //$("#DebitAmt").val(sum.toFixed(2));
 

}

function calculateCrditSumAmount() {
    var sum = 0;



    let TotalAmount = 0;
    $('.Creditfield').each(function () {
        TotalAmount += parseFloat($(this).val()) || 0;
    })
    $('#TCreditAmt').val(TotalAmount);

}




$('#btnPandingReceive').click(() => {



    //debugger;
    //searchtxt = $(searchElem).val();

    //if (searchtxt == '')
    //    return;

    GetJSONRequest('/Transaction/Transaction_UnitAllow/UnitList', 'GET', '', function (data) {
        
        if (data && data.length > 0) {
           
           
            RenderDataOnTable(data);

        }
        else

            ErrorAlert("No Data Found");
    })







})




$('#btnGeneId').click(() => {



    if ($('#SName').val() != '') {




    var SocN = $('#SName').val()



  


    GetJSONRequest('/Transaction/Transaction_UnitAllow/GetregId', 'GET', { SocN }, function (data) {

        if (data && data.length > 0) {



            $('#MNo').val(data[0].MNo);
            $('#RegID').val(data[0].RegID);


        }
        else

            ErrorAlert("No Data Found");
    })


    }

    else {
        ErrorAlert("Missing Value");
    }

})






$('#btncpdId').click(() => {




   
    GetJSONRequest('/Transaction/Transaction_CPDForm/GetAllList', 'GET', '', function (data) {

            if (data && data.length > 0) {

                CPDIDSearch(data);


            }
            else

                ErrorAlert("No Data Found");
        })


  

})








function calculateSumorderAmt() {
    var sum = 0;
    $(".OrderAmtfield").each(function () {
        if (!isNaN(this.value) && this.value.length != 0) {
            sum += parseFloat(this.value);
        }
    });

    $("#TotalOrderAmt").val(sum.toFixed(2));
}







$("tbody.BankVoucherDetails").delegate(".removeitem", "click", function () {



    $(this).closest('tr').remove();

    debugger;



    calculateDebitSumAmount();
    calculateCrditSumAmount();

});



$("tbody.BankVoucherDetails").delegate(".Discountfield", "click", function () {
    CalculateTotalDiscount();
});

$('#ProductId').change(function () { $('#ProductCode').val('00' + $(this).find('option:selected').val()) })
$('#StoreId').change(function () {

    debugger;

    $('#StoreCode').val($(this).find('option:selected').data('code'));
})




$('.SaveBtn').click(() => {

    debugger;






    if ($('#Unit_Id').val() != "" && $('#MNo').val() != "" && $('#RegID').val() != "" && $('#CPDID').val() != "") {

           
           
            $('.SaveBtn').attr('data-submit', true);
        }
        else {
            ErrorAlert('Miss Values')
        }

    
})







































function CPDIDSearch(data) {

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




function RenderDataOnTable(data) {

    debugger;
    $('#Unit_Id').val('');
    $('#UnitName').val('');
    $('#PlotNo').val('');
    $('#SName').val('');
    $('#MNo').val('');
    $('#RegID').val('');


    $('#SModal').modal('show');
        $('.modal-dialog').addClass('modal-lg');
   
    $('#SModalTitle').text('Unit List');
    let markup = `<div class="row">
         
                   <div class="col-sm-3">
                    <div class="input-group ">
                        <input type="text" class="form-control datasearch" placeholder="Filter" id="FilterInputoptpurchase">
                        <span class="input-group-addon bg-blue-800"><i class="icon-search4"></i></span>
                    </div>
                </div></div><table id="myTable" class="table datatable-basic table-xxs table-md table-bordered table-striped table-hover bg-lightgray dataTables_scrollBody">
				<thead>
					<tr class="bg-blue-800">
                        <th>Unit Id</th>
						<th>Unit Name</th>
                        <th>Plot No</th>
                        <th>Project Name</th>
                        <th>Actions</th>

					</tr>
				</thead><tbody>`;

    data.forEach((item) => {
        markup += `<tr><td>${item.UnitId}</td><td>${item.UnitName}</td><td>${item.PlotNo}</td><td>${item.SName}</td><td><button  type="button" class="selectBtn btn btn-primary" id=${item.UnitId}>Select</button></td></tr>`

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



$('#SModalBody').delegate('.selectBtn', 'click', function () {

    $('#Unit_Id').val($(this).closest('tr').children().eq(0).text());
    $('#UnitName').val($(this).closest('tr').children().eq(1).text());
    $('#PlotNo').val($(this).closest('tr').children().eq(2).text());
    $('#SName').val($(this).closest('tr').children().eq(3).text());

   // $('#ProductId').val($(this).attr('id'));
    $('#SModal').modal('hide');
})

$('#SModalBody').delegate('.selectCPDBtn', 'click', function () {

    $('#CPDID').val($(this).closest('tr').children().eq(0).text());
    $('#Name').val($(this).closest('tr').children().eq(1).text());
    $('#Int').val($(this).closest('tr').children().eq(2).text());
    $('#Fname').val($(this).closest('tr').children().eq(3).text());
    $('#NicNo').val($(this).closest('tr').children().eq(4).text());
    $('#Mobileno').val($(this).closest('tr').children().eq(5).text());
   

   // $('#ProductId').val($(this).attr('id'));
    $('#SModal').modal('hide');
})




$('#ReferenceId').val('00' + $('#RefId option:selected').val());

$('#RefId').change(function () {

    $('#ReferenceId').val('00' + $(this).val());
})



//function saveData() {
//    var EntRepairing = {}, BankVoucherDetails = []; 

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
//        BankVoucherDetails: BankVoucherDetails,
//        ServicesAmt: 0,
//        TotalDiscount: 0,
//        TotalAmount: 0
//    }

//    $('.BankVoucherDetails tr').each(function () {
//        BankVoucherDetails.push({
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
