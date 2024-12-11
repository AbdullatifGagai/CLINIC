




if ($('#FeeId').val() > 0) {
   

    $('#MonthId').attr('disabled', 'true')
    $('#LevelId').attr('disabled', 'true')
    $('#StudentN').attr('disabled', 'true')
    $('#LeaveF').attr('disabled', 'true')
    $('#AddItemBtn').attr('disabled', 'true')
    $('#BankId').attr('disabled', 'true')
    $('#ServicesId').attr('disabled', 'true')

    var Feeid = $('#FeeId').val()





    FeeVoucherDetail(Feeid);















   
}
else {

    document.getElementById('VouDate').valueAsDate = new Date();
    document.getElementById('DueDate').valueAsDate = new Date();


    //$('#UserName').val($('#personName').text());
    //$('#UserId').val($('#personId').val())
 

}

function FeeVoucherDetail(id) {



    GetJSONRequest('/Transaction/FeeVoucherDetail/GetFeeVoucherDetail', 'GET', { id }, data => {


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
                                </td>
                                
                                  <td>
                                         <input type="hidden" class="form-control PanelId" readonly value="${item.PanelId}" />
                                         <input type="text" class="form-control PanelN"  readonly value="${item.PanelN}" />
                                </td>
                                <td><input type="text" class="form-control Grno"  readonly value="${item.GrNo}" /></td>
                                
                                    <td><input type="text" class="form-control TotalAmt" readonly value="${item.TAmount}" /></td>
                                    <td><input type="text" class="form-control ChallanNo" readonly value="${item.ChallanNo}" /></td>

                                    <td><a id=""><i class="icon-trash removeitem text-danger-600"></i></a>



                 </tr>`;

                $('tbody.VoucherDetail').append(markup);
             

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
$('#PenItemBtn').click(() => { AddRowPen(); })



//$('.remarkid').keyup(e => {

//    if (e.keyCode == 13) {
//        AddRow();
//        $("#ProductCode").focus();
//    }
//})

function AddRow() {
  
    
    let Id = parseInt($('#LevelId').val());
    let SId = parseInt($('#StudentN').val());
    var LeaveF = parseInt($('#LeaveF').val());
    debugger;

    //debugger;

  //  $('#LevelId').val(Id)


    GetJSONRequest('/Master/Student/StudentGetVou', 'GET', { Id, SId, LeaveF }, data => {

        if (data && data.length > 0) {

            debugger;
            console.log(data);
         //   $('tbody.VoucherDetail').empty();
            for (var item of data) {
               
               /// var Total = item.AdmissionFee + item.MonthlyFee;

                









                const markup = `
                            <tr>
                              
                              
                                <td>
                                         <input type="hidden" class="form-control GRId" readonly value="${item.GRId}" />
                                         <input type="text" class="form-control StudentName"  readonly value="${item.StudentName}" />
                                </td>
                                <td>
                                         <input type="hidden" class="form-control PanelId" readonly value="${item.PanelId}" />
                                         <input type="text" class="form-control PanelN"  readonly value="${item.PanelN}" />
                                </td>


                                        
                            

                              <td><input type="text" class="form-control Grno"  readonly value="${item.Grno}" /></td>
                              <td><input type="text" class="form-control TotalAmt"  value="0" /></td>
                              <td><input type="text" class="form-control ChallanNo" readonly value="0" /></td>

                             
                            
                                
                                

                                 
                                   
                              
                                <td><a id=""><i class="icon-trash removeitem text-danger-600"></i></a>



                 </tr>`;
                $('tbody.VoucherDetail').append(markup);
                //calculateAdmAmt()
                //calculateAnnAmt()
                //calculateMonthlyAmt()
                //calculateDisTotalAmt()
                //calculateTotalAmt()

            }



        }
        else {

            ErrorAlert("No Data Found");
        }

    })



  






}



function AddRowPen() {


    let Id = parseInt($('#MonthId').val());
    
    debugger;

    //debugger;

    //  $('#LevelId').val(Id)


    GetJSONRequest('/Master/Student/StudentGetVouPen', 'GET', { Id }, data => {

        if (data && data.length > 0) {

            debugger;
            console.log(data);
            //   $('tbody.VoucherDetail').empty();
            for (var item of data) {

                /// var Total = item.AdmissionFee + item.MonthlyFee;











                const markup = `
                            <tr>
                              
                              
                                <td>
                                         <input type="hidden" class="form-control GRId" readonly value="${item.GRId}" />
                                         <input type="text" class="form-control StudentName"  readonly value="${item.StudentName}" />
                                </td>
                                <td>
                                         <input type="hidden" class="form-control PanelId" readonly value="${item.PanelId}" />
                                         <input type="text" class="form-control PanelN"  readonly value="${item.PanelN}" />
                                </td>


                                        
                            

                              <td><input type="text" class="form-control Grno"  readonly value="${item.Grno}" /></td>
                              <td><input type="text" class="form-control TotalAmt"  value="${item.Amount}" /></td>
                              <td><input type="text" class="form-control ChallanNo" readonly value="0" /></td>

                             
                            
                                
                                

                                 
                                   
                              
                                <td><a id=""><i class="icon-trash removeitem text-danger-600"></i></a>



                 </tr>`;
                $('tbody.VoucherDetail').append(markup);
                //calculateAdmAmt()
                //calculateAnnAmt()
                //calculateMonthlyAmt()
                //calculateDisTotalAmt()
                calculateTotalAmt()

            }



        }
        else {

            ErrorAlert("No Data Found");
        }

    })










}









//$('#UnitPrice,#Qty,#Discount').change(function () {



//    const Price = $('#UnitPrice').val() || 0;
//    const Discout = $('#Discount').val() || 0;
//    const OrderAmt = $('#OrderAmt').val() || 0;

//    var tAmt = 0;



//    tAmt = parseInt($('#Qty').val()) * parseInt(Price);
//    $('#Amount').val(parseInt(tAmt) - parseInt(Discout));
//    $('#OrderAmt').val(parseInt(tAmt));


//})

























$('#LevelId').change(function () {
    let Id = parseInt($('#LevelId').val());

    //debugger;

    $('#LevelId').val(Id)


    GetJSONRequest('/Master/Student/Master_StudentGetLevelId', 'GET', { Id }, data => {

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













$('tbody.VoucherDetail').delegate('.TotalAmt', 'change', function () {


    var sum = 0;


    let TotalAmount = 0;
    $('.TotalAmt').each(function () {
        TotalAmount += parseFloat($(this).val()) || 0;
    })
    $('#TAmount').val(TotalAmount);




})

function calculateAdmAmt() {
    var sum = 0;


    let TotalAmount = 0;
    $('.AdmAmt').each(function () {
        TotalAmount += parseFloat($(this).val()) || 0;
    })
    $('#AdAmt').val(TotalAmount);


 

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





    calculateAdmAmt()
    calculateAnnAmt()
    calculateMonthlyAmt()
    calculateDisTotalAmt()
    calculateTotalAmt()

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
    var MonthId = $('#MonthId').val();
    var LevelId = $('#LevelId').val();
    var BankId = $('#BankId').val();
    var ServicesId = $('#ServicesId').val();
   
   


    var check = false;




    if (MonthId == 0 || MonthId == null) {


        ErrorAlert("Enter Month  Name");
        check = true;

    }

    if (LevelId == 0 || LevelId == null) {


        ErrorAlert("Enter Level   Name");
        check = true;

    }

    if (BankId == 0 || BankId == null) {


        ErrorAlert("Enter Bank Name");
        check = true;

    }

    if (ServicesId == 0 || ServicesId == null) {


        ErrorAlert("Enter Account Name");
        check = true;

    }

   


    if (!check) {

        
       












        var FeeVoucher = [], FeeVoucherDetail = [];



        FeeVoucher = {
            FeeId: $('#FeeId').val(),
            voudate: $('#VouDate').val(),
            DueDate: $('#DueDate').val(),

            MonthId: parseInt($('#MonthId option:selected').val()),
            LeaveF: parseInt($('#LeaveF option:selected').val()),
            LevelId: parseInt($('#LevelId option:selected').val()),
            BankId: parseInt($('#BankId option:selected').val()),

            AdAmt: 0,
            AnnAmt: 0,
            MontlyAmt: 0,
            MDisAmt: 0,

            OtherAmt: 0,
            TAmount: $('#TAmount').val(),
            RefId: $('#RefId').val(),
            ServicesId: $('#ServicesId').val(),


            VouMode: 2,






            //  StudentN: parseInt($('#StudentN option:selected').val()),
          

        }


        $('tbody.VoucherDetail tr').each(function () {

            FeeVoucherDetail.push({



                FeeId: $('#FeeId').val(),
                GRId: parseInt($(this).find(".GRId").val()),
                GrNo: parseInt($(this).find(".Grno").val()),
                PanelId: parseInt($(this).find(".PanelId").val()),
                AdAmt: 0,
                AnnAmt: 0,
                MontlyAmt: 0,
                MDisAmt: 0,

                TAmount: parseFloat($(this).find(".TotalAmt").val()),
                OtherAmt: parseFloat($(this).find(".TotalAmt").val()),
                ChallanNo: parseInt($(this).find(".ChallanNo").val()),
              




            });



        });


     


       
        console.log(FeeVoucher);
        console.log(FeeVoucherDetail);



        debugger;

        var FeeId = $('#FeeId').val();

        if (FeeId > 0) {

            debugger;
            GetJSONRequest('/Transaction/FeeVoucher/UpdateCusFeeVoucher', 'POST', { FeeVoucher, FeeVoucherDetail }, function (data) {
                SuccessAlert("Data Saved");
                $('.closeBtn').trigger('click');
            });
        }
        else {

            debugger;


            GetJSONRequest('/Transaction/FeeVoucher/SaveCusFeeVoucher', 'POST', { FeeVoucher, FeeVoucherDetail }, function (data) {
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


















$('#QuotationCode').keyup(function (e) {
    debugger;
    const no = $(this).val();
    if (no != '') {
        if (e.keyCode == 13) {

            GetJSONRequest('/Transaction/ENTQuotation/GetENTQuotationByNo', 'GET', { no }, data => {
                console.log(data);
                let i = 0;

                if (data && data.length > 0) {
                    $('tbody.BankVoucherDetails').empty();
                    for (const item of data) {
                        i++;
                        const markup = `
                            <tr>
                                <td>${"000" + i}</td>
                                <td>${item.ProductCode}</td>
                                <td><input type="hidden" class="ProductId" value="${item.ProductId}" />${item.ProductName}</td>
                                  <td><select class="bootstrap-select form-control EyeSide" data_live_search = "true", data_width = "100%" id="${'EyeSide' + i}">${$('#EyeSide').html()}</select> </td>

                                <td><input type="text" class="form-control Qtyfield" value="${item.Qty}"></td>
                                <td><input type="text" class="form-control Pricefield" value="${item.UnitPrice}"></td>
                                <td><input type="text" class="form-control Amountfield" readonly value="${item.Amount}"></td>
                            <td><select class="bootstrap-select form-control Store" data_live_search = "true", data_width = "100%" id="${'StoreId' + i}">${$('#StoreId').html()}</td>
                                <td><input type="date" class="form-control DeliveryDate"/></td>
                                <td><input type="text" class="form-control SerialNo"/></td>
                                <td><input type="text" class="form-control Discountfield" value="${item.Discount}"></td>  

                                <td><input type="text" class="Remarks form-control" value="${item.Remarks}" /></td>
                                <td><a id=""><i class="icon-trash removeitem text-danger-600"></i></a></td>
                            </tr>`;
                        $('tbody.BankVoucherDetails').append(markup);
                        $('#EyeSide' + i).val(item.EyeSide).change();

                    }
                    DropDown2Initializers();

                    CalculateTotalAmount();
                    CalculateTotalDiscount();

                    const custId = data[0].CustomerId || 0;
                    $('#CustomerId').val(custId).change();
                    $('#Address').val(data[0].Address);
                    $('#MobileNo').val(data[0].MobileNo);
                    $('#QuotationId').val(data[0].QuotationId);
                    return;
                }
                ErrorAlert('No Quotation Found');
            })
        }

    }
})


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
