
//document.getElementById('VOUCHAR_DATE').valueAsDate = new Date();

$('#OrderById').val($('#personId').val())
$('#VOUCHER_MODE').val('JV')
debugger;

if ($('#VOUCHER_NO').val() > 0) {
   
    $('tbody.BankVoucherDetails tr').each(function () {
     
              
   //     let store = $(this).children().eq(0);
     //   $(store).find('.Store').val($(store).find('.SalesId').val()).change();
      
  
         //$('tbody.saleOrderDetail tr').each(function () {
    //  //  let eyeside = $(this).children().eq(3)
    //  ///  let store = $(this).children().eq(7);
    // ///   $(eyeside).find('.EyeSideDrop').val($(eyeside).find('.EyeSide').val()).change();
    //  ///  $(store).find('.Store').val($(store).find('.StoreId').val()).change();
    //})

        //document.getElementById('OrderDate').valueAsDate = new Date();
        //document.getElementById('Send_Date').valueAsDate = new Date();
        //document.getElementById('Bill_Date').valueAsDate = new Date();
     

    })
}
else {









    document.getElementById('VOUCHAR_DATE').valueAsDate = new Date();


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
         $('#AccountId' + TotalRows).val($('#AccountId').val()).change();
            




  



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
        
        let counter = 0;
       
       const DebitAmt = $('#TDebitAmt').val() || 0;
       const CreditAmt = $('#TCreditAmt').val() || 0;

        const GridBodyRows = $('tbody.BankVoucherDetails tr');
        let check = false;
        GridBodyRows.each(function () {
          //  const keptqty = $(this).children().eq(0).find('.KeptQtyfield').val() || 0;
        

   

            if ($(this).children().eq(0).find('.SUB_CODE').val() == 0) {
                check = true;
                return false;
            }


          

        })






    if (!check && DebitAmt == CreditAmt) {

            debugger;
            GridBodyRows.each(function () {

                $(this).children().eq(0).find('.SUB_CODE').attr('name', 'VoucherDetails[' + counter + '].SUB_CODE');
               // $(this).children().eq(0).find('.Subacc_Name').attr('name', 'BankVoucherDetails[' + counter + '].SUB_NAME');

                $(this).children().eq(1).find('.Remarksfield').attr('name', 'VoucherDetails[' + counter + '].Remarks');
                $(this).children().eq(2).find('.Debitfield ').attr('name', 'VoucherDetails[' + counter + '].Debit');
                $(this).children().eq(3).find('.Creditfield ').attr('name', 'VoucherDetails[' + counter + '].Credit');

                counter++;


                //$(this).children().eq(6).find('.Pricefield').attr('name', 'optpurchasereceivedetail[' + counter + '].UnitPrice');
                //$(this).children().eq().find('.TDiscountfield').attr('name', 'optpurchasereceivedetail[' + counter + '].Discount');
            })
            $('.SaveBtn').attr('data-submit', true);
        }
        else {
            ErrorAlert('Please Select Account Name Or Debit and Credit Not Equal')
        }
    })




















//$('.SaveBtn').click(() => {
//    let counter = 0;
//    debugger;
//    $('tbody.OptPurchaseDetail tr').each(function () {
//        $(this).children().eq(1).find('.ItemCode').attr('name', 'optpurchasedetail[' + counter + '].ItemCode');
//        $(this).children().eq(1).find('.ItemId').attr('name', 'optpurchasedetail[' + counter + '].ItemId');
//        $(this).children().eq(3).find('.Qtyfield').attr('name', 'optpurchasedetail[' + counter + '].Qty');
//        $(this).children().eq(4).find('.Pricefield').attr('name', 'optpurchasedetail[' + counter + '].UnitPrice');
//        $(this).children().eq(5).find('.Amountfield').attr('name', 'optpurchasedetail[' + counter + '].TotalAmount');
//        $(this).children().eq(6).find('.Discountfield').attr('name', 'optpurchasedetail[' + counter + '].TotalDiscount');
//        $(this).children().eq(7).find('.Remarksfield').attr('name', 'optpurchasedetail[' + counter + '].Remarks');
//        counter++;
//    })
//})


















//$('#QuotationCode').keyup(function (e) {
//    debugger;
//    const no = $(this).val();
//    if (no != '') {
//        if (e.keyCode == 13) {

//            GetJSONRequest('/Transaction/ENTQuotation/GetENTQuotationByNo', 'GET', { no }, data => {
//                console.log(data);
//                let i = 0;

//                if (data && data.length > 0) {
//                    $('tbody.BankVoucherDetails').empty();
//                    for (const item of data) {
//                        i++;
//                        const markup = `
//                            <tr>
//                                <td>${"000" + i}</td>
//                                <td>${item.ProductCode}</td>
//                                <td><input type="hidden" class="ProductId" value="${item.ProductId}" />${item.ProductName}</td>
//                                  <td><select class="bootstrap-select form-control EyeSide" data_live_search = "true", data_width = "100%" id="${'EyeSide' + i}">${$('#EyeSide').html()}</select> </td>

//                                <td><input type="text" class="form-control Qtyfield" value="${item.Qty}"></td>
//                                <td><input type="text" class="form-control Pricefield" value="${item.UnitPrice}"></td>
//                                <td><input type="text" class="form-control Amountfield" readonly value="${item.Amount}"></td>
//                            <td><select class="bootstrap-select form-control Store" data_live_search = "true", data_width = "100%" id="${'StoreId' + i}">${$('#StoreId').html()}</td>
//                                <td><input type="date" class="form-control DeliveryDate"/></td>
//                                <td><input type="text" class="form-control SerialNo"/></td>
//                                <td><input type="text" class="form-control Discountfield" value="${item.Discount}"></td>  

//                                <td><input type="text" class="Remarks form-control" value="${item.Remarks}" /></td>
//                                <td><a id=""><i class="icon-trash removeitem text-danger-600"></i></a></td>
//                            </tr>`;
//                        $('tbody.BankVoucherDetails').append(markup);
//                        $('#EyeSide' + i).val(item.EyeSide).change();

//                    }
//                    DropDown2Initializers();

//                    CalculateTotalAmount();
//                    CalculateTotalDiscount();

//                    const custId = data[0].CustomerId || 0;
//                    $('#CustomerId').val(custId).change();
//                    $('#Address').val(data[0].Address);
//                    $('#MobileNo').val(data[0].MobileNo);
//                    $('#QuotationId').val(data[0].QuotationId);
//                    return;
//                }
//                ErrorAlert('No Quotation Found');
//            })
//        }

//    }
//})


////for product search
//var searchtxt;
function GetItems(type, searchElem, typeval) {
    debugger;
    searchtxt = $(searchElem).val();

    if (searchtxt == '')
        return;

    GetJSONRequest('/Product/ENTProduct/GetAllENTProducts', 'GET', { searchtxt, type: typeval }, function (data) {
        debugger;
        if (data && data.length > 0) {
            if (typeval == 1) {
                $('#ProductName').val(data[0].ProductPrimaryName);
                $('#ProductId').val(data[0].ProductId);


            }
            else
                RenderDataOnTable(data, type);

        }
        else

            ErrorAlert("No Data Found");
    })

}


$('#ProductCode').keypress(function (e) {
    if (e.keyCode == 13)
        GetItems(true, $(this), 1)
})


$('#ProductName').keydown(function (e) {
    if (e.keyCode == 13) {
        $(this).focusout();
        GetItems(true, $(this), 0);
    }
})


$('#SModalBody').delegate('#SearchItem', 'keydown', function (e) {
    if (e.keyCode == 13) {
        GetItems(false, $(this), 0);
    }

});





function RenderDataOnTable(data, type) {
    if (type) {
        $('#SModal').modal('show');
        $('.modal-dialog').addClass('modal-lg');
    }
    $('#SModalTitle').text('ENT Products');
    let markup = `<div class="row">
           <div class="col-sm-4">
              <div class="input-group">
                        <input type="text" class="form-control" placeholder="Search" value="${searchtxt}" id="SearchItem">
                    </div>
              </div>
<div class="col-sm-5"></div><div class="col-sm-3">
                    <div class="input-group ">
                        <input type="text" class="form-control datasearch" placeholder="Filter" id="FilterInputoptpurchase">
                        <span class="input-group-addon bg-danger-800"><i class="icon-search4"></i></span>
                    </div>
                </div></div><table id="myTable" class="table datatable-basic table-xxs table-md table-bordered table-striped table-hover bg-lightgray dataTables_scrollBody">
				<thead>
					<tr class="bg-danger-800">
                        <th>Product Code</th>
						<th>Product Name</th>
						<th>Actions</th>

					</tr>
				</thead><tbody>`;

    data.forEach((item) => {
        markup += `<tr><td>${item.ProductCode}</td><td>${item.ProductPrimaryName}</td><td><button  type="button" class="selectBtn btn btn-primary" id=${item.ProductId}>Select</button></td></tr>`

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

    $('#ProductName').val($(this).closest('tr').children().eq(1).text());
    $('#ProductCode').val($(this).closest('tr').children().eq(0).text());

    $('#ProductId').val($(this).attr('id'));
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
