



//var ConNo = $('#FCode').val();


debugger;
RespCallback();


//$('#NicNo').formatter({
//    pattern: '{{99999}}-{{9999999}}-{{9}}'
//});
//$('#ContactNo').formatter({
//    pattern: '{{9999}}-{{9999999}}'
//});



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










 ///   document.getElementById('DOB').valueAsDate = new Date();


  //  $('tbody.BankVoucherDetails tr').each(function () {
     
              
   //     let store = $(this).children().eq(0);
     //   $(store).find('.Store').val($(store).find('.SalesId').val()).change();
      
  
         //$('tbody.saleOrderDetail tr').each(function () {
    //  //  let eyeside = $(this).children().eq(3)
    //  ///  let store = $(this).children().eq(7);
    // ///   $(eyeside).find('.EyeSideDrop').val($(eyeside).find('.EyeSide').val()).change();
    //  ///  $(store).find('.Store').val($(store).find('.StoreId').val()).change();
    //})

  
     

 



//$(document).ready(function () {

//    debugger;

//    $('#OrBookId').val($('#personId').val())
//    $('#UserName').val($('#personName').text())
 


//    /* $('#VOUCHER_MODE').val('BPV').text()*/
//})



//$('#AddItemBtn').click(() => { AddRow(); })




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


















$("#ReceiptDetail").delegate(".Edititem", "click", function () {


    if (editview) {


    debugger;
    var row = $(this).closest("tr");



    let MCode = parseFloat(row.find(".ReceiptId").val())






    if (MCode != '') {




        var id = MCode


      

        



        GetJSONRequest('/Transaction/Receipt/Transaction_ReceiptGetReceiptId', 'GET', { id }, function (data) {

            debugger;
                if (data && data.length > 0) {



                    $('#ReceiptCode').val(data[0].ReceiptCode);
                    $('#ReceiptId').val(data[0].ReceiptId);
                    $('#RefId').val(data[0].RefId);
                    $('#RDate').val(data[0].RDate);

                    $('#MonId').val(data[0].MonId);
                    $('#MonId').select2();

                    $('#BankId').val(data[0].BankId);
                    $('#BankId').select2();


                    $('#Amt').val(data[0].Amt);







                    //$('#MonId').val(data[0].MonId);
                    //$('#BankId').val(data[0].BankId);
                   

                 //   $('#CreditAccName').val(data[0].SubNamecredit);
                   // $('#CrditAcc').val(data[0].SubCodecredit);


                }
                else {

                    ErrorAlert("No Data Found");

                    //$('#DebitAcc').val('')
                    //$('#CrditAcc').val('')
                    //$('#CreditAccName').val('')
                    //$('#DebitAccName').val('')


                }



            })


        }

        else {
            ErrorAlert("Missing Value");
        }

    }

    else {
        ErrorAlert('Not Allowed');
    }


    })
  


$("#ReceiptDetail").delegate(".removeitem", "click", function () {



    if (deleteview) {

    



    debugger;
    var row = $(this).closest("tr");



    let MCode = parseFloat(row.find(".ReceiptId").val())



    var id = MCode;


    GetJSONRequest('/Transaction/Receipt/DeleteReceipt', 'POST', { id }, (data) => {

        if (data == 'OK') {
            $(this).closest('tr').remove();
            SuccessAlert("Deleted Successfully");
            return;
        }
        ErrorAlert('Something went wrong while Serving The Request');
    })


   }

    else {
        ErrorAlert('Not Allowed');
    }







})
  





$("tbody.BankVoucherDetails").delegate(".Discountfield", "click", function () {
    CalculateTotalDiscount();
});

$('#ProductId').change(function () { $('#ProductCode').val('00' + $(this).find('option:selected').val()) })
$('#StoreId').change(function () {

    debugger;

    $('#StoreCode').val($(this).find('option:selected').data('code'));
})




//$('.SaveBtn').click(() => {
        
//        let counter = 0;
       
//       const DebitAmt = $('#TDebitAmt').val() || 0;
//       const CreditAmt = $('#TCreditAmt').val() || 0;

//        const GridBodyRows = $('tbody.BankVoucherDetails tr');
//        let check = false;
//        GridBodyRows.each(function () {
//          //  const keptqty = $(this).children().eq(0).find('.KeptQtyfield').val() || 0;
        

   

//            if ($(this).children().eq(0).find('.SUB_CODE').val() == 0) {
//                check = true;
//                return false;
//            }


          

//        })






//    if (!check && DebitAmt == CreditAmt) {

//            debugger;
//            GridBodyRows.each(function () {

//                $(this).children().eq(0).find('.SUB_CODE').attr('name', 'VoucherDetails[' + counter + '].SUB_CODE');
//               // $(this).children().eq(0).find('.Subacc_Name').attr('name', 'BankVoucherDetails[' + counter + '].SUB_NAME');

//                $(this).children().eq(1).find('.Remarksfield').attr('name', 'VoucherDetails[' + counter + '].Remarks');
//                $(this).children().eq(2).find('.Debitfield ').attr('name', 'VoucherDetails[' + counter + '].Debit');
//                $(this).children().eq(3).find('.Creditfield ').attr('name', 'VoucherDetails[' + counter + '].Credit');

//                counter++;


//                //$(this).children().eq(6).find('.Pricefield').attr('name', 'optpurchasereceivedetail[' + counter + '].UnitPrice');
//                //$(this).children().eq().find('.TDiscountfield').attr('name', 'optpurchasereceivedetail[' + counter + '].Discount');
//            })
//            $('.SaveBtn').attr('data-submit', true);
//        }
//        else {
//            ErrorAlert('Please Select Account Name Or Debit and Credit Not Equal')
//        }
//    })





















//$('#ReceiptDetail').delegate('.printeritem', 'click', function () {

//    debugger;
//    //var row = $(this).closest("tr");



//    //const MCode = row.find(".MCodefield").val();



//    //var value = `/Report/Reportrdlc/AReport?rvalues.Name=21&rvalues.Value[0]=''&rvalues.Value[1]=''&rvalues.Value[2]=''&rvalues.Value[3]=''&rvalues.Value[4]=''&rvalues.Value[5]=''&rvalues.Value[6]=''`
//    //$(this).attr('href', value)
//    //$(this).attr('target', "_blank")
//    var value = `/Report/Reportrdlc/AReport?rvalues.Name=65&rvalues.Value[0]=''&rvalues.Value[1]=''&rvalues.Value[2]=''&rvalues.Value[3]=''&rvalues.Value[4]=''&rvalues.Value[5]=''&rvalues.Value[6]=''`
//    $(this).attr('href', value)
//    $(this).attr('target', "_blank")



//});

$('#ReceiptDetail').delegate('.printeritem', 'click', function () {


    if (Printview) {

    

    //debugger;

    //const ReceiptId = parseInt($(this).closest('tr').children().eq(0).find('.ReceiptId').val());

    //  debugger;

    //var value = `/Report/Reportrdlc/AReport?rvalues.Name=50&rvalues.Value[0]=${$("#Branch_Id").val()}&rvalues.Value[1]=${$("#StoreId").val()}&rvalues.Value[2]=${$("#CategoryId").val()}&rvalues.Value[3]=${$("#SubCategoryId").val()}&rvalues.Value[4]=${$("#CompanyId").val()}&rvalues.Value[5]=${$("#HearingId").val()},${$("#TechnologyId").val()},${$("#ModelId").val()}&rvalues.Value[6]=${$("#ToDate").val()}`;

    //$(this).attr("href", value);
    //$(this).attr("target", "_blank");


    debugger;
    var row = $(this).closest("tr");



    const ReceiptId = row.find(".ReceiptId").val();



    //var value = `/Report/Reportrdlc/AReport?rvalues.Name=21&rvalues.Value[0]=''&rvalues.Value[1]=''&rvalues.Value[2]=''&rvalues.Value[3]=''&rvalues.Value[4]=''&rvalues.Value[5]=''&rvalues.Value[6]=''`
    //$(this).attr('href', value)
    //$(this).attr('target', "_blank")

    var value = `/Report/Reportrdlc/AReport?rvalues.Name=26&rvalues.Value[0]=${ReceiptId}&rvalues.Value[1]=''&rvalues.Value[2]=''&rvalues.Value[3]=''&rvalues.Value[4]=1&rvalues.Value[5]=''&rvalues.Value[6]=''`
    $(this).attr('href', value)
    $(this).attr('target', "_blank")

}


     else {
        ErrorAlert('Not Allowed');
    }

    //const str = '&rvalues.Value[1]=null&rvalues.Value[2]=null&rvalues.Value[3]=null&rvalues.Value[4]=null&rvalues.Value[5]=null&rvalues.Value[6]=null';
    //$('#RowWiseReport').prop('href', $('#RowWiseReport').prop('href') + '?rvalues.Name=' + '12' + '&rvalues.Value[0]=' + ReceiptId + str);
    //$('#RowWiseReport')[0].click();



    //let id = $(this).closest('tr').children().eq(0).find('.ReceiptId').val();
    //var str = '&rvalues.Value[1]=@DateTime.Now.ToString("dd/MM/yyyy")&rvalues.Value[2]=@DateTime.Now.ToString("dd/MM/yyyy")&rvalues.Value[3]=@a&rvalues.Value[4]=@a&rvalues.Value[5]=@a&rvalues.Value[6]=@a';


    //$('#RowWiseReport').prop('href', $('#RowWiseReport').prop('href') + '?rvalues.Name=' + '12' + '&rvalues.Value[0]=' + id + str);
  

});



$('#ReceiptDetail').delegate('.printerOneitem', 'click', function () {


    if (Printview) {

   

    //debugger;

    //const ReceiptId = parseInt($(this).closest('tr').children().eq(0).find('.ReceiptId').val());

    //  debugger;

    //var value = `/Report/Reportrdlc/AReport?rvalues.Name=50&rvalues.Value[0]=${$("#Branch_Id").val()}&rvalues.Value[1]=${$("#StoreId").val()}&rvalues.Value[2]=${$("#CategoryId").val()}&rvalues.Value[3]=${$("#SubCategoryId").val()}&rvalues.Value[4]=${$("#CompanyId").val()}&rvalues.Value[5]=${$("#HearingId").val()},${$("#TechnologyId").val()},${$("#ModelId").val()}&rvalues.Value[6]=${$("#ToDate").val()}`;

    //$(this).attr("href", value);
    //$(this).attr("target", "_blank");


    debugger;
    var row = $(this).closest("tr");



    const ReceiptId = row.find(".ReceiptId").val();



    //var value = `/Report/Reportrdlc/AReport?rvalues.Name=21&rvalues.Value[0]=''&rvalues.Value[1]=''&rvalues.Value[2]=''&rvalues.Value[3]=''&rvalues.Value[4]=''&rvalues.Value[5]=''&rvalues.Value[6]=''`
    //$(this).attr('href', value)
    //$(this).attr('target', "_blank")

    var value = `/Report/Reportrdlc/AReport?rvalues.Name=27&rvalues.Value[0]=${ReceiptId}&rvalues.Value[1]=''&rvalues.Value[2]=''&rvalues.Value[3]=''&rvalues.Value[4]=1&rvalues.Value[5]=''&rvalues.Value[6]=''`
    $(this).attr('href', value)
    $(this).attr('target', "_blank")


    //const str = '&rvalues.Value[1]=null&rvalues.Value[2]=null&rvalues.Value[3]=null&rvalues.Value[4]=null&rvalues.Value[5]=null&rvalues.Value[6]=null';
    //$('#RowWiseReport').prop('href', $('#RowWiseReport').prop('href') + '?rvalues.Name=' + '12' + '&rvalues.Value[0]=' + ReceiptId + str);
    //$('#RowWiseReport')[0].click();



    //let id = $(this).closest('tr').children().eq(0).find('.ReceiptId').val();
    //var str = '&rvalues.Value[1]=@DateTime.Now.ToString("dd/MM/yyyy")&rvalues.Value[2]=@DateTime.Now.ToString("dd/MM/yyyy")&rvalues.Value[3]=@a&rvalues.Value[4]=@a&rvalues.Value[5]=@a&rvalues.Value[6]=@a';


    //$('#RowWiseReport').prop('href', $('#RowWiseReport').prop('href') + '?rvalues.Name=' + '12' + '&rvalues.Value[0]=' + id + str);
    }

    else {
        ErrorAlert('Not Allowed');
    }
});














$('#SaveMcode').click(() => { SaveRow(); })
/*$('#btnClear').click(() => { clear(); })*/



function SaveRow() {

    debugger;

    var MonId = $('#MonId').val();
    var BankId = $('#BankId').val();

    var check = false;




    if ($('#Name').val() == "") {


        ErrorAlert("Enter Name");
        check = true;

    }
    if ($('#Amt').val() == "0") {


        ErrorAlert("Enter Amt");
        check = true;

    }


    if (MonId == 0 || MonId == null) {


        ErrorAlert("Enter Month  Name");
        check = true;

    }

    if (BankId == 0 || BankId == null) {


        ErrorAlert("Enter Bank  Name");
        check = true;

    }


   









    if (!check) {






   


      
       
   

        var model = {
        ReceiptId: $('#ReceiptId').val(),
        ReceiptCode: $('#ReceiptCode').val(),
        RDate: $('#RDate').val(),
        GrId: $('#GrId').val(),
        GRNo: $('#GRNo').val(),
        RDate: $('#RDate').val(),
       
         MonId: $('#MonId option:selected').val(),
         BankId: $('#BankId option:selected').val(),
         Amt: $('#Amt').val(),
         GroupId: $('#GroupId').val(),
         RefId: $('#RefId').val(),
      




    }



        debugger;
        console.log(model);

        //const model = {
            //    //Date: $('#Date').val(),
            //    Receipt: detailObj
            //}


    if ($('#ReceiptCode').val() > 0) {
        
     


        GetJSONRequest('/Transaction/Receipt/UpdateReceipt', 'POST', model, RespCallback)
        


    }

    else {

       
        GetJSONRequest('/Transaction/Receipt/SaveReceipt', 'POST', model, RespCallback)
    }



  }

  

}

function RespCallback(data) {

    debugger;
    let Id = $('#GrId').val();
    GetJSONRequest('/Transaction/Receipt/Transaction_ReceiptGetAllAdmission', 'GET', { id: Id }, mydata => {
       
        let i = 0;
        if (mydata && mydata.length > 0) {
            console.log(mydata)
           
            debugger;


               
               
            $('#ReceiptDetail').empty();
            for (const item of mydata) {
                i++;
                const markup = `
                            <tr>
                               
                                <td><input type="text" class="form-control ReceiptId" readonly value="${item.ReceiptId}"/></td>
                                <td><input type="text" class="form-control RDate" readonly value="${item.RDate}"/></td>
                                <td><input type="text" class="form-control Amt" readonly value="${item.Amt}"/></td>
                                
                              
                     <td>


                       
                        <a><i class="icon-trash removeitem text-danger-600"></i></a>



                        <a><i class="icon-pencil7 Edititem text-blue-600"></i></a>
                         <a <i class="icon-printer printeritem text-blue-600"></i></a>
                         <a <i class="icon-printer printerOneitem text-green-600"></i></a>
                        
                        </td>


                    



                           
                            </tr>`;
                $('#ReceiptDetail').append(markup);

               

            }

                
            //Clear();
          
            //$('tbody.OptCounterSaleDetail').html(html)
            //$('#ProductCode').val('');
            //$('.TxtBox').val('');
            //$('#ProductCode').focus();
            //$('#SerialNo').empty();

            //CalculateTotalAmount();
            SuccessAlert();
            clear();

            ;

        }
        else {

          
        ErrorAlert();
        }
        

    })

    //if (data) {
    //    $('#SlipNo').val(data);
    //    $('tbody.OptCounterSaleDetail').append(`<tr>
    //               <td>${'000' + ($('tbody.OptCounterSaleDetail tr').length + 1)}</td>
    //                <input type="text" class="SlipNo" value="${$('#SlipNo').val()}">
    //               <td><input type="hidden" class="CustomerId form-control" value="${$('#CustomerId').val()}">${$('#CustomerId').val() == 0 ? '' : $('#CustomerId option:selected').text()}</td>
    //              <td><input type="hidden" class="Category" value="${$('#CategoryId').val()}" />${$('#CategoryId').val() == 0 ? '' : $('#CategoryId option:selected').text()} </td>
    //              <td><input type="hidden" class="ItemId form-control" value="${$('#ProductId').val()}">${$('#ProductName').val()}</td>
    //               <td><input type="hidden" class="Store form-control" value="${$('#StoreId').val()}">${$('#StoreId').val() == 0 ? '' : $('#StoreId option:selected').text()}</td>
    //              <td><input type="text" class="form-control Qtyfield" value="${$('#Qty').val()}"></td>
    //               <td><input type="text" class="form-control Pricefield" value="${$('#Price').val()}"></td>
    //               <td><input type="text" class="form-control Amountfield" readonly value="${$('#Amount').val()}"></td>
    //                <td><input type="text" class="form-control Discountfield" value="${$('#Discount').val()}"></td>
    //                <td><input type="text" class="form-control SerialNofield" value="${$('#SerialNo').val()}"></td>

    //                 <td><a id=""><i class="icon-trash removeitem text-danger-600"></i></a></td>
    //                 <td><a id=""><i class="icon-eye Detailsitem text-blue-600"></i></a></td>


    //                </tr>`);

    //    $('#ProductCode').val('');
    //    $('.TxtBox').val('');
    //    $('#ProductCode').focus();
    //    CalculateTotalAmount();
    //    SuccessAlert();
    //    return;
    //}
    



    //    <td><input type="text" class="form-control RemAmount" readonly value="${$('#RemAmount').val()}"></td>
    //    <td><input type="date" class="form-control RecDate" readonly value="${$('#RecDate').val()}"></td>
    //   <td><input type="text" class="form-control RecAmount" readonly value="${$('#RecAmount').val()}"></td>
    //<td><input type="text" class="form-control Balance" readonly value="${$('#Balance').val()}"></td>
    //<td><input type="hidden" class="PaymentType form-control" value="${$('#SaleType').val()}">${$('#SaleType').val() == 0 ? '' : $('#SaleType option:selected').text()}</td>
    // <td><input type="hidden" readonly class="form-control Remarks" value="${$('#Remarks').val()}"></td>
    // <td><input type="hidden" readonly class="form-control Remarks" value="${$('#SerialNo').val()}"></td>





}

function clear() {
    debugger;

  //  $('#MonId').select2.(0);
   // $('#MonId').select2(0);
    $('#MonId').val(0).select2();
    $('#BankId').val(0).select2();
    $('#Amt').val(0);
    $('#ReceiptCode').val('');



 //   document.getElementById('DOB').valueAsDate = new Date();

   // $('#Name').focus();

}



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
$('#SaveMClear').click(function () {

    clear();

  
});


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



//function savesaveData() {
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
