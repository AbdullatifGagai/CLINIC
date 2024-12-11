

debugger;


if ($('#ReceiptId').val() > 0) {
   

    $('#PanelId').attr('disabled', 'true')
    //$('#LevelId').attr('disabled', 'true')
    //$('#StudentN').attr('disabled', 'true')
    //$('#LeaveF').attr('disabled', 'true')
    //$('#AddItemBtn').attr('disabled', 'true')
    //$('#BankId').attr('disabled', 'true')

    var Feeid = $('#ReceiptId').val()

    FeeVoucherDetail(Feeid);















   
}
else {



    debugger;

    document.getElementById('RDate').valueAsDate = new Date();
    


    //$('#UserName').val($('#personName').text());
    //$('#UserId').val($('#personId').val())
 

}

function FeeVoucherDetail(id) {



    GetJSONRequest('/Transaction/ReceiptPanelDetail/ReceiptPanelDetailGetById', 'GET', { id }, data => {


        debugger;
        let i = 0;


        if (data && data.length > 0) {
            $('tbody.VoucherDetail').empty();
            for (const item of data) {
                i++;
                const markup = `
               <tr>




                                <td>
                                         <input type="hidden" class="form-control GRId" readonly value="${item.GRId}" />
                                         <input type="text" class="form-control StudentName"  readonly value="${item.StudentName}" />
                                         <input type="hidden" class="form-control Grno"  readonly value="${item.GrNo}" />
                                </td>
                              

                            

                             
                              <td><input type="text" class="form-control CloseingAmt"  readonly value="${item.Amt}" /></td>
                            
                            
                                
                                

                                 
                                   
                              
                                <td><a id=""><i class="icon-trash removeitem text-danger-600"></i></a>



                 </tr>`;
                $('tbody.VoucherDetail').append(markup);
                calculatePanelAmt()




               

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
  
   
   
    var MonthId = parseInt($('#MonId').val());
    var PanelId = parseInt($('#PanelId').val());


    debugger;

    //debugger;

  //  $('#LevelId').val(Id)


    GetJSONRequest('/Master/Student/StudentlistPanelGrId', 'GET', { MonthId, PanelId }, data => {

        if (data && data.length > 0) {

            debugger;
            console.log(data);
            $('tbody.VoucherDetail').empty();
            for (var item of data) {
               
               /// var Total = item.AdmissionFee + item.MonthlyFee;

                var AdAmt, AnnAmt, MonthAmt, Total;

             
               









                const markup = `
                            <tr>
                              
                              
                                <td>
                                         <input type="hidden" class="form-control GRId" readonly value="${item.GRId}" />
                                         <input type="text" class="form-control StudentName"  readonly value="${item.StudentName}" />
                                         <input type="hidden" class="form-control Grno"  readonly value="${item.Grno}" />
                                </td>
                              

                            

                             
                              <td><input type="text" class="form-control CloseingAmt"  readonly value="${item.CloseingAmt}" /></td>
                            
                            
                                
                                

                                 
                                   
                              
                                <td><a id=""><i class="icon-trash removeitem text-danger-600"></i></a>



                 </tr>`;
                $('tbody.VoucherDetail').append(markup);
                calculatePanelAmt()
            

            }



        }
        else {

            ErrorAlert("No Data Found");
            $('tbody.VoucherDetail').empty();


        }

    })



  






}













//('tbody.VoucherDetail').delegate('.MDisAmt', 'change', function () {

//    debugger;

//    const AdAmt = $('.AdAmt').val() || 0;
//    const AnnualAmt = $('.AnnualAmt').val() || 0;
//    const MonthlyAmt = $('.MonthlyAmt').val() || 0;
//    const MDisAmt = $('.MDisAmt').val() || 0;

//    var tAmt = 0;



//    tAmt = parseInt(AdAmt + AnnualAmt + MonthlyAmt - MDisAmt);
//    $('.TotalAmt').val(parseInt(tAmt));
//    calculateAdmAmt()
//    calculateAnnAmt()
//    calculateMonthlyAmt()
//    calculateDisTotalAmt()
//    calculateTotalAmt()


//})

























$('#LevelId').change(function () {
    let Id = parseInt($('#LevelId').val());

    //debugger;

    $('#LevelId').val(Id)


    GetJSONRequest('/Master/Student/Master_StudentGetPanelId', 'GET', { Id }, data => {

        if (data && data.length > 0) {
            $('#StudentN').empty();
            $('#StudentN').append(`<option value="0">All Student</option>`);
            for (const model of data) {

                $('#StudentN').append(`<option value="${model.GRId}">${model.StudentName}</option>`);

            }



          //  $('#LevelId').attr('disabled', 'true')
            $('#StudentN').select2()
            $('tbody.FeeVoucherDetail').empty();
       

            return;



        }
        ErrorAlert("No Records Found");
        $('#StudentN').empty();
        $('tbody.FeeVoucherDetail').empty();

        /// $('#Comp_id').attr('disabled', 'true')

    })

   
})













$('tbody.VoucherDetail').delegate('.MDisAmt', 'change', function () {

    debugger;
   // const Price = $('#UnitPrice').val() || 0;
  ///  const Discout = $('#Discount').val() || 0;
   
    var row = $(this).closest("tr");
    var AdAmt = parseFloat(row.find(".AdAmt").val() || 0);
    var AnnualAmt = parseFloat(row.find(".AnnualAmt").val() || 0);
    var MonthlyAmt = parseFloat(row.find(".MonthlyAmt").val() || 0);
    var MDisAmt = parseFloat(row.find(".MDisAmt").val() || 0);

    var total = parseFloat(AdAmt + AnnualAmt + MonthlyAmt - MDisAmt);
    //var Sumtotal = total - Discount;



    row.find(".TotalAmt").val(isNaN(total) ? "" : total);
    //row.find(".Amountfield").val(isNaN(Sumtotal) ? "" : Sumtotal);

    calculateAdmAmt()
    calculateAnnAmt()
    calculateMonthlyAmt()
    calculateDisTotalAmt()
    calculateTotalAmt()


 //   const AdAmt = $('.AdAmt').val() || 0;
//    const AnnualAmt = $('.AnnualAmt').val() || 0;
//    const MonthlyAmt = $('.MonthlyAmt').val() || 0;
//    const MDisAmt = $('.MDisAmt').val() || 0;

//    var tAmt = 0;



//    tAmt = parseInt(AdAmt + AnnualAmt + MonthlyAmt - MDisAmt);
//    $('.TotalAmt').val(parseInt(tAmt));
//    calculateAdmAmt()
//    calculateAnnAmt()
//    calculateMonthlyAmt()
//    calculateDisTotalAmt()
//    calculateTotalAmt()




})

function calculatePanelAmt() {
    var sum = 0;


    let TotalAmount = 0;
    $('.CloseingAmt').each(function () {
        TotalAmount += parseFloat($(this).val()) || 0;
    })
    $('#Amt').val(TotalAmount);


 

}



function calculateAnnAmt() {
    var sum = 0;


    let TotalAmount = 0;
    $('.AnnualAmt').each(function () {
        TotalAmount += parseFloat($(this).val()) || 0;
    })
    $('#AnnAmt').val(TotalAmount);




}

function calculateMonthlyAmt() {
    var sum = 0;


    let TotalAmount = 0;
    $('.MonthlyAmt').each(function () {
        TotalAmount += parseFloat($(this).val()) || 0;
    })
    $('#MontlyAmt').val(TotalAmount);




}


function calculateTotalAmt() {
    var sum = 0;


    let TotalAmount = 0;
    $('.TotalAmt').each(function () {
        TotalAmount += parseFloat($(this).val()) || 0;
    })
    $('#TAmount').val(TotalAmount);




}



function calculateDisTotalAmt() {
    var sum = 0;


    let TotalAmount = 0;
    $('.MDisAmt').each(function () {
        TotalAmount += parseFloat($(this).val()) || 0;
    })
    $('#MDisAmt').val(TotalAmount);




}















$('tbody.VoucherDetail').delegate(".removeitem", "click", function () {
    debugger;


    $(this).closest('tr').remove();




    calculatePanelAmt()
   

});



$("tbody.BankVoucherDetails").delegate(".Discountfield", "click", function () {
    CalculateTotalDiscount();
});

$('#ProductId').change(function () { $('#ProductCode').val('00' + $(this).find('option:selected').val()) })
$('#StoreId').change(function () {

    debugger;

    $('#StoreCode').val($(this).find('option:selected').data('code'));
})




$('.SaveBtn').on('click', function () {
    var MonId = $('#MonId').val();
    var LevelId = $('#LevelId').val();
    var BankId = $('#BankId').val();
   
   


    var check = false;




    if (MonId == 0 || MonId == null) {


        ErrorAlert("Enter Month  Name");
        check = true;

    }

   

    if (BankId == 0 || BankId == null) {


        ErrorAlert("Enter Bank Name");
        check = true;

    }

   


    if (!check) {

        
       












        var ReceiptPanelMaster = [], ReceiptPanelDetail = [];



        ReceiptPanelMaster = {
            ReceiptId: $('#ReceiptId').val(),
            ReceiptCode: $('#ReceiptCode').val(),


            RDate: $('#RDate').val(),
           
            

            MonId: parseInt($('#MonId option:selected').val()),
           
            Amt: $('#Amt').val(),
            PanelId: $('#PanelId').val(),
            Remarks: $('#Remarks').val(),



            RefId: $('#RefId').val(),


            BankId: parseInt($('#BankId option:selected').val()),



            //  StudentN: parseInt($('#StudentN option:selected').val()),
          

        }


        $('tbody.VoucherDetail tr').each(function () {

            ReceiptPanelDetail.push({



                ReceiptId: $('#ReceiptId').val(),
                GRId: parseInt($(this).find(".GRId").val()),
                GrNo: $(this).find(".Grno").val(),
                Amt: parseFloat($(this).find(".CloseingAmt").val()),
              




            });



        });


     


       
        console.log(ReceiptPanelMaster);
        console.log(ReceiptPanelDetail);



        debugger;

        var ReceiptId = $('#ReceiptId').val();

        if (ReceiptId > 0) {

            debugger;
            GetJSONRequest('/Transaction/ReceiptPanelMaster/UpdateReceiptPanelMaster', 'POST', { ReceiptPanelMaster, ReceiptPanelDetail }, function (data) {
                SuccessAlert("Data Saved");
                $('.closeBtn').trigger('click');
            });
        }
        else {

            debugger;


            GetJSONRequest('/Transaction/ReceiptPanelMaster/SaveReceiptPanelMaster', 'POST', { ReceiptPanelMaster, ReceiptPanelDetail}, function (data) {
                SuccessAlert("Data Saved");
                $('.closeBtn').trigger('click');



            });
        }




    }
    //else {
    //    ErrorAlert("Miss value");
    //}










});



















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





















////for product search
//var searchtxt;








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




