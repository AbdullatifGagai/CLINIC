
//document.getElementById('VOUCHAR_DATE').valueAsDate = new Date();






$('#OrderById').val($('#personId').val())
$('#VOUCHER_MODE').val('BPV')
debugger;

if ($('#PurchaseInward_Id').val() > 0) {
   
    
       
       
  
    $('#tbodytable tr').each(function () {

        debugger;
      let store = $(this).children().eq(15);
     
        $(store).find('.Store').val($(store).find('.StoreId').val()).change();
    })

        //document.getElementById('OrderDate').valueAsDate = new Date();
        //document.getElementById('Send_Date').valueAsDate = new Date();
        //document.getElementById('Bill_Date').valueAsDate = new Date();
     

  
}
else {

    document.getElementById('PurInward_Date').valueAsDate = new Date();
    document.getElementById('PDate').valueAsDate = new Date();

    //$('tbody.tbodytable tr').each(function () {
    //    let store = $(this).children().eq(15);
    //    $(store).find('.Store').val($(store).find('.StoreId').val()).change();
    //})
    //debugger;
    //$('#UserName').val($('#personName').text());
    //$('#UserId').val($('#personId').val())
 

}


$(document).ready(function () {

    debugger;

    $('#OrBookId').val($('#personId').val())
    $('#UserName').val($('#personName').text())
   /* $('#VOUCHER_MODE').val('BPV').text()*/
})





    
function Clear() {
    $('#ProductName').val(0)
    $('#ProductName').select2()
   
    $('#Unit').val('')
    $('#TPRate').val('')
    $('#RetailRate').val('')
    $('#UnitPkt').val('')
    $('#UnitQty').val('')
    $('#Amount').val('')
    $('#Stax').val('')
    $('#Discount').val('')
    $('#Rate').val('')
    $('#Fttax').val('')
    $('#Advtax').val('')
    $('#TotalAmount').val('')





   // $('#creditaccount').select2()
 //   $('#expenseaccount').select2()
}



function AddTotal() {
    var sum = 0;
    $(".TotalAmount").each(function () {
        if (!isNaN(this.value) && this.value.length != 0) {
            sum += parseFloat(this.value);
        }
    });

    $("#TotalA").val(sum.toFixed(2));
}




function GenerateSerialNo(a) {

    const rows = $('tbody.BankVoucherDetails tr');
    let counter = 0;
    $(rows).each(function () {
        counter += 1;
        $(this).children().eq(0).text('000' + counter);
    })



}



$('#ProductName').change(function () {

    clean()
    var Id = $('#ProductName').val() || 0;

   
    GetJSONRequest('/Master/Product/GetProductName', 'GET', { Id }, function (data) {
      



        if (data && data.length > 0) {









            $('#Unit').val(data[0].UnitName);
            $('#TPRate').val(data[0].TPRate);
            $('#RetailRate').val(data[0].RetailRate);



            //      $('#ProductId').val(data[0].ProductId);




        }
        else {

        

            ErrorAlert("No Data Found");


           

        }
    })

    //const Price = $('#UnitPrice').val() || 0;
    //const Discout = $('#Discount').val() || 0;
    //const OrderAmt = $('#OrderAmt').val() || 0;

    //var tAmt = 0;



    //tAmt = parseInt($('#Qty').val()) * parseInt(Price);
    //$('#Amount').val(parseInt(tAmt) - parseInt(Discout));
    //$('#OrderAmt').val(parseInt(tAmt));


})
$('#PCode').keyup(function (e) {
    

    var id = $(this).val();

 
    if (id != '' && e.keyCode == 13)
        GetPurchaseByOrderNo(id);
})
function GetPurchaseByOrderNo(id) {

    GetJSONRequest('/Transaction/PurchaseOrder/PurchaseOrderGetPId', 'GET', { id }, data => {
      //  console.log(data);

        debugger;

        let i = 0;
        if (data && data.length > 0) {
            $('#tbodytable').empty();
            for (const item of data) {
                i++;

                const markup = `
                            <tr>
                               
                                <td><input type="hidden" class="form-control ProductId" value="${item.Product_ID}"/>${item.ProductName}</td>
                                <td><input type="hidden" class="Unit_ID" value="${item.Unit_ID}"/>${item.UnitName}</td>
                                
                                <td><input type="text" class="form-control OrderQty" readonly value="${item.Qty}">
                                <input type="hidden" class="form-control PackQty" readonly value="${item.PackQty}">
                                </td>
                                <td><input type="text" class="form-control OrderRate" readonly value="${item.Rate}"></td>
                                <td><input type="text" class="form-control TPRate" readonly value="${item.TPRate}"></td>
                                <td><input type="text" class="form-control RetailRate" readonly value="${item.RetailRate}"></td>
                                <td><input type="text" class="form-control PKTQty" value="0"></td>
                                <td><input type="text" class="form-control RecQty" value="0"></td>
                                <td><input type="text" class="form-control RecRate" value="${item.Rate}"></td>
                                <td><input type="text" class="form-control saletax" value="0"></td>
                                <td><input type="text" class="form-control DisAmt" value="0"></td>
                                <td><input type="text" class="form-control  Amount"  readonly value="0"></td>
                                
                                <td><input type="text" class="form-control FTtax" value="0"></td>
                                <td><input type="text" class="form-control advtax" value="0"></td>
                                <td><input type="text" class="form-control  Amt" readonly value="0"></td>
                                <td><select class="bootstrap-select form-control Store" data_live_search = "true", data_width = "100%" id="${'Store' + i}">${$('#Store').html()}</td>

                               
                                <td><a id=""><i class="icon-trash removeitem text-danger-600"></i></a></td>
                            </tr>`;
                $('#tbodytable').append(markup);

            }
            //<td><a class="ml-5"><i class="icon-eye selectItem text-blue-600"  id="serialArea" PurchaseReceiveId="@item.PurchaseReceiveId"></i></a></td>

            //CalculateTotalAmount();
            //CalculateTotalDiscount();
            //CalculateBalQty();
            //DropDown2Initializers();

            //const supId = data[0].SupplierId || 0;
            //$('#SupplierId').val(supId).change();
            $('#SupId').val(data[0].SupplierID);
            $('#SupplyName').val(data[0].SupplyName);




            $('#PDate').val(data[0].PODate);
            $('#PId').val(data[0].PID);


            //$('#Remarks').val(data[0].Remarks);

            //const refid = data[0].RefId || 0;
            //$('#RefId').val(refid).change();

          //  return;
        }

        else {
            ErrorAlert('No Purchase Found');
        }
       
    })
}



$('#tbodytable').delegate('.PKTQty,.RecRate,.RecQty,.saletax,.DisAmt,.Amt,.FTtax,.advtax', 'change', function () {

    // var Id = $('.ProductId').val() || 0;
    // var UnitPkt = $('.PKTQty').val() || 0;
    //  var Qty = $('.Qty').val() || 0;

    debugger;




    const PackQty = parseFloat($(this).closest('tr').children().eq(2).find('.PackQty').val());
    const PKTQty = parseFloat($(this).closest('tr').children().eq(6).find('.PKTQty').val());
    const OrderQty = parseFloat($(this).closest('tr').children().eq(2).find('.OrderQty').val());
    const RecQty = parseFloat($(this).closest('tr').children().eq(7).find('.RecQty').val());
    const RecRate = parseFloat($(this).closest('tr').children().eq(8).find('.RecRate').val());
 

    const OrderRate = parseFloat($(this).closest('tr').children().eq(3).find('.OrderRate').val());


    /////Amount Calculator


    //const saletax = parseInt($(this).closest('tr').children().eq(10).find('.saletax').val());
    //const DisAmt = parseInt($(this).closest('tr').children().eq(11).find('.DisAmt').val());
    //  const Amount = parseInt($(this).closest('tr').children().eq(12).find('.Amount').val());









    // const RecRate = parseInt($(this).closest('tr').children().eq(9).find('.RecRate').val());
    // const RecRate = parseInt($(this).closest('tr').children().eq(9).find('.RecRate').val());
    // const RecRate = parseInt($(this).closest('tr').children().eq(9).find('.RecRate').val());








    const TPackQty = PackQty * PKTQty + RecQty;



    if (TPackQty > OrderQty) {


        $(this).closest('tr').children().eq(7).find('.RecQty').val(parseFloat($(this).closest('tr').children().eq(2).find('.OrderQty').val()));
        $(this).closest('tr').children().eq(6).find('.PKTQty').val(0);

    }

    else {

        $(this).closest('tr').children().eq(7).find('.RecQty').val(parseFloat(TPackQty));
    }


    if (RecRate > OrderRate) {


        $(this).closest('tr').children().eq(8).find('.RecRate').val(parseFloat($(this).closest('tr').children().eq(3).find('.OrderRate').val()));

    }


    else {
        $(this).closest('tr').children().eq(8).find('.RecRate').val();
    }



    $(this).closest('tr').children().eq(11).find('.Amount').val(parseFloat($(this).closest('tr').children().eq(7).find('.RecQty').val()) * parseFloat($(this).closest('tr').children().eq(8).find('.RecRate').val()) + parseInt($(this).closest('tr').children().eq(9).find('.saletax').val()) - parseFloat($(this).closest('tr').children().eq(10).find('.DisAmt').val()));
   
    $(this).closest('tr').children().eq(14).find('.Amt').val(parseFloat($(this).closest('tr').children().eq(11).find('.Amount').val()) + parseFloat($(this).closest('tr').children().eq(12).find('.FTtax').val()) + parseFloat($(this).closest('tr').children().eq(13).find('.advtax').val()) )



    




    
   CalculateTotalAmount();
});









//$('tbody.tbodytable').delegate('.RecQty', 'change', function () {

    
//    var Qty = $('.Qty').val() || 0;
//    var RecQty = $('.RecQty').val() || 0;


  
   
//    $('.PKTQty').val(0);

//    if (RecQty > Qty) {

//    $('.RecQty').val(Qty);




//    }

//    else {
//        $('.RecQty').val(RecQty);
//    }


 
//});


















function clean() {

    $('#Unit').val('');
    $('#TPRate').val('');
    $('#RetailRate').val('');
    $('#UnitPkt').val('');
    $('#UnitQty').val('');



}

function afterSerialChange() {
    emptygrids();

    $('.PurchaseReceiveDetail  tr').each(function (index, tr) {
        product = $(this).children('td').find('.ProductId').val();
        StoreId = $(this).children('td').find('.StoreId').val();
        productCode = $(this).children('td').find('.ProductCode').val();
        //  StoreId = $(this).children('td').find('.StoreId').val();

        lenData = $(this).children('td').find('.RecQtyfield').val();
        generaatingRow(index, product, lenData, productCode, StoreId);
        debugger;
    });  
}
//function clean() {

//      $(this).closest('tr').children().eq(9).find('.Amountfield').val($(this).closest('tr').children().eq(7).find('.Qtyfield').val() * $(this).closest('tr').children().eq(8).find('.Pricefield').val());
//      CalculateTotalAmount();



//}


function SumAmount() {

    $('#Unit').val('');
    $('#TPRate').val('');
    $('#RetailRate').val('');
    $('#UnitPkt').val('');
    $('#UnitQty').val('');



}











function CalculateTotalAmount() {
    let TotalAmount = 0;
    $('.Amt').each(function () {
        TotalAmount += parseFloat($(this).val());
    })
    $('#TotalAmt').val(TotalAmount);
}


$('#Amount,#UnitQty,#Discount,#Stax,#Fttax,#Advtax').change(function () {
   
    var Amount = $('#Amount').val() || 0;
    var Saletax = $('#Stax').val() || 0;
    var Discount = $('#Discount').val() || 0;
    var Rate = $('#Rate').val() || 0;
    var Fttax = $('#Fttax').val() || 0;
    var Advtax = $('#Advtax').val() || 0;
    var UnitQty = $('#UnitQty').val() || 0;

    var TotalAmount = $('#TotalAmount').val() || 0;
    var Fttax = $('#Fttax').val() || 0;
    var Advtax = $('#Advtax').val() || 0;



    var SAmt = 0;
    var  TAmt = 0;
   var  TotalAmt = 0;


    SAmt = parseFloat(Amount) + parseFloat(Saletax) - parseFloat(Discount);
    TAmt = SAmt / UnitQty;
    TotalAmt = SAmt + parseFloat(Fttax) + parseFloat(Advtax);



    $('#Rate').val(TAmt.toFixed(2));
     $('#TotalAmount').val(TotalAmt.toFixed(0));

    debugger;







   // $('#TotalAmount').val(parseInt($(this).val()) * parseInt(Price));
})


$('#Amount,#UnitQty,#Discount,#Stax,#Fttax,#Advtax').change(function () {
   
    var Amount = $('#Amount').val() || 0;
    var Saletax = $('#Stax').val() || 0;
    var Discount = $('#Discount').val() || 0;
    var Rate = $('#Rate').val() || 0;
    var Fttax = $('#Fttax').val() || 0;
    var Advtax = $('#Advtax').val() || 0;
    var UnitQty = $('#UnitQty').val() || 0;

    var TotalAmount = $('#TotalAmount').val() || 0;
    var Fttax = $('#Fttax').val() || 0;
    var Advtax = $('#Advtax').val() || 0;



    var SAmt = 0;
    var  TAmt = 0;
   var  TotalAmt = 0;


    SAmt = parseFloat(Amount) + parseFloat(Saletax) - parseFloat(Discount);
    TAmt = SAmt / UnitQty;
    TotalAmt = SAmt + parseFloat(Fttax) + parseFloat(Advtax);



    $('#Rate').val(TAmt.toFixed(2));
     $('#TotalAmount').val(TotalAmt.toFixed(0));

    debugger;

    





   // $('#TotalAmount').val(parseInt($(this).val()) * parseInt(Price));
})




//$('.Amount,.UnitQty,.Discount,.Stax,.Fttax,.Advtax').change(function () {

//    var Amount1 = $('.Amount').val() || 0;
//    var Saletax1= $('.Stax').val() || 0;
//    var Discount1 = $('.Discount').val() || 0;
//    var Rate1 = $('.Rate').val() || 0;
//    var Fttax1 = $('.Fttax').val() || 0;
//    var Advtax1 = $('.Advtax').val() || 0;
//    var UnitQty1 = $('.UnitQty').val() || 0;

//    var TotalAmount1 = $('.TotalAmount').val() || 0;
//    var Fttax1 = $('.Fttax').val() || 0;
//    var Advtax1 = $('.Advtax').val() || 0;



//    var SAmt1 = 0;
//    var TAmt1 = 0;
//    var TotalAmt1 = 0;


//    SAmt = parseFloat(Amount1) + parseFloat(Saletax1) - parseFloat(Discount1);
//    TAmt1 = SAmt1 / UnitQty1;
//    TotalAmt1 = SAmt1 + parseFloat(Fttax1) + parseFloat(Advtax1);



//    $('.Rate').val(TAmt1.toFixed(2));
//    $('.TotalAmount').val(TotalAmt1.toFixed(0));

//    debugger;




//    AddTotal();


//    // $('#TotalAmount').val(parseInt($(this).val()) * parseInt(Price));
//})











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







$("#tbodytable").delegate(".removeitem", "click", function () {



    $(this).closest('tr').remove();

    debugger;


    CalculateTotalAmount();
   // calculateDebitSumAmount();
    //calculateCrditSumAmount();

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
    let counter = 0;

   //const SupplierName = $('#SupplierID').val() || 0;
    //const CreditAmt = $('#TCreditAmt').val() || 0;

    var GridBodyRows = $('#tbodytable tr');
    let check = false;
    GridBodyRows.each(function () {
        const StoreId = $(this).children().eq(15).find('.Store').val() || 0;

       // ErrorAlert(keptqty)


        if (StoreId == 0) {
            check = true;
            return false;
        }




    })

   // if (!check && SupplierName > 0) {
    if (!check) {


        $('#tbodytable tr').each(function (index, element) {

            debugger;
            $(element).children('td').find('.ProductId').attr('name', `PurchaseInwardDetail[${index}].ProductId`)
            $(element).children('td').find('.Unit_ID').attr('name', `PurchaseInwardDetail[${index}].UnitId`)
            $(element).children('td').find('.OrderQty').attr('name', `PurchaseInwardDetail[${index}].OrderQty`)
            $(element).children('td').find('.OrderRate').attr('name', `PurchaseInwardDetail[${index}].OrderRate`)
            $(element).children('td').find('.TPRate').attr('name', `PurchaseInwardDetail[${index}].TPRate`)
            $(element).children('td').find('.RetailRate').attr('name', `PurchaseInwardDetail[${index}].Retail_Rate`)
            $(element).children('td').find('.PKTQty').attr('name', `PurchaseInwardDetail[${index}].PktQty`)
            $(element).children('td').find('.RecQty').attr('name', `PurchaseInwardDetail[${index}].RecQty`)
            $(element).children('td').find('.RecRate').attr('name', `PurchaseInwardDetail[${index}].RecRate`)
            $(element).children('td').find('.saletax').attr('name', `PurchaseInwardDetail[${index}].Saletax`)
            $(element).children('td').find('.DisAmt').attr('name', `PurchaseInwardDetail[${index}].Discount`)
            $(element).children('td').find('.Amount').attr('name', `PurchaseInwardDetail[${index}].Amt`)
            $(element).children('td').find('.FTtax').attr('name', `PurchaseInwardDetail[${index}].Fttax`)
            $(element).children('td').find('.advtax').attr('name', `PurchaseInwardDetail[${index}].Advtax`)
            $(element).children('td').find('.Amt').attr('name', `PurchaseInwardDetail[${index}].TotalAmt`)
            $(element).children('td').find('.Store').attr('name', `PurchaseInwardDetail[${index}].StoreId`)


            //$(element).children('td').find('.TPRate').attr('name', `PurchaseOrderDetail[${index}].TPRate`)
            //$(element).children('td').find('.RetailRate').attr('name', `PurchaseOrderDetail[${index}].RetailRate`)
            //$(element).children('td').find('.UnitPkt').attr('name', `PurchaseOrderDetail[${index}].UnitPkt`)
            //$(element).children('td').find('.UnitQty').attr('name', `PurchaseOrderDetail[${index}].Qty`)
            //$(element).children('td').find('.Amount').attr('name', `PurchaseOrderDetail[${index}].Amount`)
            //$(element).children('td').find('.Rate').attr('name', `PurchaseOrderDetail[${index}].Rate`)

            //$(element).children('td').find('.Stax').attr('name', `PurchaseOrderDetail[${index}].SaleTaxAmount`)
            //$(element).children('td').find('.Discount ').attr('name', `PurchaseOrderDetail[${index}].DisAmount`)
            //$(element).children('td').find('.Advtax').attr('name', `PurchaseOrderDetail[${index}].Advtax`)
            //$(element).children('td').find('.Fttax').attr('name', `PurchaseOrderDetail[${index}].FTtax`)

            //$(element).children('td').find('.TotalAmount').attr('name', `PurchaseOrderDetail[${index}].TAmount`)


        })






        $('.SaveBtn').attr('data-submit', true);


    }


    else {
        ErrorAlert('Miss Vlues')
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
$('#tbodytable').delegate('.btn_delete', 'click', function () {
    $(this).closest('tr').remove();
    AddTotal();
})