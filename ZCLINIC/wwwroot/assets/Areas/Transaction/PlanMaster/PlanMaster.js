
//document.getElementById('VOUCHAR_DATE').valueAsDate = new Date();


if ($('#PlanId').val() > 0) {

    var PlanId = $('#PlanId').val()
    var SId = $('#SId').val()
    GetPlanDetail(PlanId);
   // GetMonthName(SId);
   
}
else {

    document.getElementById('PlanDate').valueAsDate = new Date();
  
    Clear();

    //$('#UserName').val($('#personName').text());
    //$('#UserId').val($('#personId').val())
 

}


//$('#SId').change(function () {

//    let SId = parseInt($('#SId').val());
//    GetJSONRequest('/Master/AcadmicYear/Master_AcadmicYearSessionGetAll', 'GET', { SId }, data => {

//        /*if (data && data.length > 0) {*/
//            $('#FMonthId').empty();
//             $('#TMonthId').empty();

//        $('#FMonthId').append($('<option>').val(0).text("--Select Month Name--"))
//        $('#TMonthId').append($('<option>').val(0).text("--Select Month Name--"))



//        for (const model of data) {
//            $('#FMonthId').append(`<option value="${model.Id}">${model.FeesTerm}</option>`);
//            $('#TMonthId').append(`<option value="${model.Id}">${model.FeesTerm}</option>`);

//            }
//        $('#FMonthId').select2()
//        $('#TMonthId').select2()


//        return;
//        //}
//        //ErrorAlert("No Records Found");
//        //$('#FromMonth').empty();

//    })
//})


//function GetMonthName(SId) {



//  /*  let SId = parseInt($('#SId').val());*/
//    GetJSONRequest('/Master/AcadmicYear/Master_AcadmicYearSessionGetAll', 'GET', { SId }, data => {

//        /*if (data && data.length > 0) {*/
//        $('#FMonthId').empty();
//        $('#TMonthId').empty();

//        $('#FMonthId').append($('<option>').val(0).text("--Select Month Name--"))
//        $('#TMonthId').append($('<option>').val(0).text("--Select Month Name--"))



//        for (const model of data) {
//            $('#FMonthId').append(`<option value="${model.Id}">${model.FeesTerm}</option>`);
//            $('#TMonthId').append(`<option value="${model.Id}">${model.FeesTerm}</option>`);

//        }
//        $('#FMonthId').select2()
//        $('#TMonthId').select2()


//        return;
//        //}
//        //ErrorAlert("No Records Found");
//        //$('#FromMonth').empty();

//    })

//}





function GetPlanDetail(id) {



    GetJSONRequest('/Transaction/PlanDetail/GetPlanDetail', 'GET', { id }, data => {


        debugger;
        let i = 0;


        if (data && data.length > 0) {
            $('#tbodytable').empty();
            for (const item of data) {
                i++;
                let markup = `<tr>

	
                     <td><input hidden class="semesterId" readonly value="${item.semesterId}" />${item.semesterName}</td>

                  

                    
                  
                    <td><input type="text" class="form-control AdmissionFee"  value="${item.AdmissionFee}"></td>
                    
                     <td><input type="text" class="form-control TutionFee"  value="${item.TutionFee}"></td>
                     <td><input type="text" class="form-control AnnualFee"  value="${item.Annelfee}"></td>
                     <td><input type="text" class="form-control Enrollmentfee"  value="${item.Enrollmentfee}"></td>
                     <td><input type="text" class="form-control ExamFee"  value="${item.ExamFee}"></td>
                     <td><input type="text" class="form-control KUAFee"  value="${item.KUAFee}"></td>
                     <td><input type="text" class="form-control MisFee"  value="${item.MisFee}"></td>
                     <td><input type="text" class="form-control PenaltyFee"  value="${item.PenaltyFee}"></td>
                     <td><input type="text" class="form-control DisAmt"  value="${item.DisAmt}"></td>




                



                      <td><a class="btn_delete text-danger-600"><i class="icon-trash"></i></a></td>


        

			
                  </tr>`;

                $('#tbodytable').append(markup);
                Clear();
                TAdmissionfee();

                T_TutionFee();
                T_Annelfee();
                TotalAmount();
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






$('#AddItemBtn').click(function () {


    

    if ($('#semesterId option:selected').val() == "0") {
        ErrorAlert("Semester Name is Required")


        debugger;
    }




    //else if ($('#StoreName').val() == "0") {
    //    ErrorAlert("Store  is Required")
    //}

    else if ($('#AdmissionFee').val() == '' || $('#MonthlyFee').val() == '' || $('#AnnualFee').val() == '' || $('#Enrollmentfee').val() == '' || $('#ExamFee').val() == '' || $('#KUAFee').val() == '' || $('#MisFee').val() == '' || $('#PenaltyFee').val() == '' || $('#DisAmt').val() == '' )  {
        ErrorAlert("Miss Value")
    }



    else {
        let markup = `<tr>
                     
                     <td><input type="hidden" class="semesterId" value="${$('#semesterId option:selected').val()}"/>${$('#semesterId option:selected').text()}</td>
                 
                     <td><input type="text" class="form-control AdmissionFee"  value="${$('#AdmissionFee').val()}"></td>
                    
                     <td><input type="text" class="form-control TutionFee"  value="${$('#TutionFee').val()}"></td>
                     <td><input type="text" class="form-control AnnualFee"  value="${$('#AnnualFee').val()}"></td>
                     <td><input type="text" class="form-control Enrollmentfee"  value="${$('#Enrollmentfee').val()}"></td>
                     <td><input type="text" class="form-control ExamFee"  value="${$('#ExamFee').val()}"></td>
                     <td><input type="text" class="form-control KUAFee"  value="${$('#KUAFee').val()}"></td>
                     <td><input type="text" class="form-control MisFee"  value="${$('#MisFee').val()}"></td>
                     <td><input type="text" class="form-control PenaltyFee"  value="${$('#PenaltyFee').val()}"></td>
                     <td><input type="text" class="form-control DisAmt"  value="${$('#DisAmt').val()}"></td>
                  
                  

                     
                      <td><a class="btn_delete text-danger-600"><i class="icon-trash"></i></a></td>
                      </tr>`
        $('#tbodytable').append(markup)
      
            Clear();
        TAdmissionfee();

        T_TutionFee();
        T_Annelfee();
       

        TEnrollment();
        TExam();
        TKUA();
        TMis();
        TPenalty();
        TDis();
        TotalAmount();

        //Total_DisAmt();
        //Total_Saletex();
        //Total_Amount();


    }
})



    
function Clear() {
    $('#semesterId').val(0)
    $('#semesterId').select2()
    $('#FMonthId').val(0)
    $('#FMonthId').select2()
    $('#TMonthId').val(0)
    $('#TMonthId').select2()
   
   
    $('#AdmissionFee').val('0')
   
    $('#TutionFee').val('0')
    $('#AnnualFee').val('0')
    $('#Enrollmentfee').val('0')
    $('#ExamFee').val('0')
    $('#KUAFee').val('0')
    $('#MisFee').val('0')
    $('#PenaltyFee').val('0')
    $('#DisAmt').val('0')
  




   // $('#creditaccount').select2()
 //   $('#expenseaccount').select2()
}



function TAdmissionfee() {

   // debugger;
    var sum = 0;
    $(".AdmissionFee").each(function () {
        if (!isNaN(this.value) && this.value.length != 0) {
            sum += parseFloat(this.value);
        }
    });

    $("#TAdmissionFee").val(sum.toFixed(2));
}

function T_TutionFee() {

  //  debugger;
    var sum = 0;
    $(".TutionFee").each(function () {
        if (!isNaN(this.value) && this.value.length != 0) {
            sum += parseFloat(this.value);
        }
    });

    $("#T_TutionFee").val(sum.toFixed(2));
}


function T_Annelfee() {

   /// debugger;
    var sum = 0;
    $(".AnnualFee").each(function () {
        if (!isNaN(this.value) && this.value.length != 0) {
            sum += parseFloat(this.value);
        }
    });

    $("#T_Annelfee").val(sum.toFixed(2));
}


function TEnrollment() {

   /// debugger;
    var sum = 0;
    $(".Enrollmentfee").each(function () {
        if (!isNaN(this.value) && this.value.length != 0) {
            sum += parseFloat(this.value);
        }
    });

    $("#TEnrollment").val(sum.toFixed(2));
}


function TExam() {

   /// debugger;
    var sum = 0;
    $(".ExamFee").each(function () {
        if (!isNaN(this.value) && this.value.length != 0) {
            sum += parseFloat(this.value);
        }
    });

    $("#TExam").val(sum.toFixed(2));
}


function TKUA() {

   /// debugger;
    var sum = 0;
    $(".KUAFee").each(function () {
        if (!isNaN(this.value) && this.value.length != 0) {
            sum += parseFloat(this.value);
        }
    });

    $("#TKUA").val(sum.toFixed(2));
}

function TMis() {

   /// debugger;
    var sum = 0;
    $(".MisFee").each(function () {
        if (!isNaN(this.value) && this.value.length != 0) {
            sum += parseFloat(this.value);
        }
    });

    $("#TMis").val(sum.toFixed(2));
}

function TPenalty() {

   /// debugger;
    var sum = 0;
    $(".PenaltyFee").each(function () {
        if (!isNaN(this.value) && this.value.length != 0) {
            sum += parseFloat(this.value);
        }
    });

    $("#TPenalty").val(sum.toFixed(2));
}

function TDis() {

   /// debugger;
    var sum = 0;
    $(".DisAmt").each(function () {
        if (!isNaN(this.value) && this.value.length != 0) {
            sum += parseFloat(this.value);
        }
    });

    $("#TDis").val(sum.toFixed(2));
}







function TotalAmount() {

    var TAdmissionFee = $('#TAdmissionFee').val() || 0;
    var T_TutionFee = $('#T_TutionFee').val() || 0;
    var T_Annelfee = $('#T_Annelfee').val() || 0;
    var TEnrollment = $('#TEnrollment').val() || 0;
    var TExam = $('#TExam').val() || 0;
    var TKUA = $('#TKUA').val() || 0;
    var TMis = $('#TMis').val() || 0;
    var TPenalty = $('#TPenalty').val() || 0;
    var TDis = $('#TDis').val() || 0;




    /// var DisAmt = $('#DisAmt').val() || 0;


    //  var Qty = $('#Qty').val() || 0;

    var totalAmount = parseFloat(TAdmissionFee) + parseFloat(T_TutionFee) + parseFloat(T_Annelfee) + parseFloat(TEnrollment) + parseFloat(TExam) + parseFloat(TKUA) + parseFloat(TMis) + parseFloat(TPenalty) + parseFloat(TDis)  ;


    debugger;

    $("#TFees").val(totalAmount);
}


















    




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











(function () {

    calculateSumBal();


    debugger;


})















$('#tbodytable').delegate('.AdmissionFee,.TutionFee,.AnnualFee,.Enrollmentfee,.ExamFee,.KUAFee,.MisFee,.PenaltyFee,.DisAmt', 'change', function () {


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


    Clear();
    TAdmissionfee();

    T_TutionFee();
    T_Annelfee();


    TEnrollment();
    TExam();
    TKUA();
    TMis();
    TPenalty();
    TDis();
    TotalAmount();




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







//$("tbody.BankVoucherDetails").delegate(".", "click", function () {



//    $(this).closest('tr').remove();

//    debugger;



//    calculateDebitSumAmount();
//    calculateCrditSumAmount();

//});



$("tbody.BankVoucherDetails").delegate(".Discountfield", "click", function () {
    CalculateTotalDiscount();
});

$('#ProductId').change(function () { $('#ProductCode').val('00' + $(this).find('option:selected').val()) })
$('#StoreId').change(function () {

    debugger;

    $('#StoreCode').val($(this).find('option:selected').data('code'));
})




$('.SaveBtn').on('click', function () {
  
    //var GrId = $('#GrId').val();
   
    var PlanName = $('#PlanName').val();
    var DegreeId = $('#DegreeId').val();


    var check = false;




   

    if (PlanName == "" || PlanName == "") {
        ErrorAlert("Enter Plan Name");
        check = true;
    }

   
    if (DegreeId == 0 || DegreeId == null) {
        ErrorAlert("Enter Degree");
        check = true;
    }

   



    if (!check) {


       






        var PlanMaster = [], PlanDetail = [];



        PlanMaster = {
            PlanId: $('#PlanId').val(),
            PlanCode: $('#PlanCode').val(),
            PlanDate: $('#PlanDate').val(),
            PlanName: $('#PlanName').val(),
            DegreeId: parseInt($('#DegreeId option:selected').val()),
          

           
           
            TAdmissionFee: $('#TAdmissionFee').val(),
            T_Annelfee: $('#T_Annelfee').val(),



            T_TutionFee: $('#T_TutionFee').val(),
            TEnrollment: $('#TEnrollment').val(),
            TExam: $('#TExam').val(),
            TKUA: $('#TKUA').val(),
            TMis: $('#TMis').val(),
            TPenalty: $('#TPenalty').val(),
            TDis: $('#TDis').val(),
            TFees: $('#TFees').val(),
        

            


        

        }


        $('#tbodytable tr').each(function () {

            PlanDetail.push({



                PlanId: $('#PlanId').val(),

                semesterId: parseInt($(this).find(".semesterId").val()),
               
                AdmissionFee: parseFloat($(this).find(".AdmissionFee").val()),
                TutionFee: parseFloat($(this).find(".TutionFee").val()),
                Annelfee: parseFloat($(this).find(".AnnualFee").val()),
                Enrollmentfee: parseFloat($(this).find(".Enrollmentfee").val()),
                ExamFee: parseFloat($(this).find(".ExamFee").val()),
                KUAFee: parseFloat($(this).find(".KUAFee").val()),
                MisFee: parseFloat($(this).find(".MisFee").val()),
                PenaltyFee: parseFloat($(this).find(".PenaltyFee").val()),
                DisAmt: parseFloat($(this).find(".DisAmt").val()),
               
             
            });

        });


      
   

        console.log(PlanMaster);
        console.log(PlanDetail);


        debugger;






        var PlanId = $('#PlanId').val();

        if (PlanId > 0) {

            debugger;
            GetJSONRequest('/Transaction/PlanMaster/UpdatePlanMaster', 'POST', { PlanMaster, PlanDetail }, function (data) {


                SuccessAlert("Data Saved");
                $('.closeBtn').trigger('click');
             
            });
        }
        else {

            debugger;


            GetJSONRequest('/Transaction/PlanMaster/SavePlanMaster', 'POST', { PlanMaster, PlanDetail }, function (data) {




                if (data == 'OK') {



                    debugger;

                    SuccessAlert("Data Saved");
                    $('.closeBtn').trigger('click');

                }

                else {

                    debugger;

                    

                    ErrorAlert(data);
                }


            });
        }




    }
   







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

    debugger;



    ///lstif
    $(this).closest('tr').remove();
    TAdmissionfee();

    T_TutionFee();
    T_Annelfee();


    TEnrollment();
    TExam();
    TKUA();
    TMis();
    TPenalty();
    TDis();
    TotalAmount();
})