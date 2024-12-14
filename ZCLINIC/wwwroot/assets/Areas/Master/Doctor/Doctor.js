

debugger;


if ($('#FeeId').val() > 0) {
   

    //$('#MonthId').attr('disabled', 'true')
    //$('#LevelId').attr('disabled', 'true')
    //$('#StudentN').attr('disabled', 'true')
    //$('#LeaveF').attr('disabled', 'true')
    //$('#AddItemBtn').attr('disabled', 'true')
    //$('#BankId').attr('disabled', 'true')

    //var Feeid = $('#FeeId').val()

    //FeeVoucherDetail(Feeid);















   
}
else {

    //document.getElementById('VouDate').valueAsDate = new Date();
    //document.getElementById('DueDate').valueAsDate = new Date();


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
                                 <td><input type="text" class="form-control AdmAmt"  readonly value="${item.AdAmt}" /></td>
                                 <td><input type="text" class="form-control AnnualAmt" readonly value="${item.AnnAmt}" /></td>

                                 
                                   <td><input type="text" class="form-control MonthlyAmt"  readonly value="${item.MontlyAmt}" /></td>
                                    <td><input type="text" class="form-control MDisAmt"   value="${item.MDisAmt}" /></td>
                                    <td><input type="text" class="form-control TotalAmt" readonly value="${item.TAmount}" /></td>
                                    <td><input type="text" class="form-control ChallanNo" readonly value="${item.ChallanNo}" /></td>

                                    <td><a id=""><i class="icon-trash removeitem text-danger-600"></i></a>



                 </tr>`;

                $('tbody.VoucherDetail').append(markup);
           
            }


            debugger;

          


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





//    if (e.keyCode == 13) {
//        AddRow();
//        $("#ProductCode").focus();
//    }
//})

$('#AddItemBtn').click(function () {


    debugger;

    if ($('#DayId').val() == "0") {
        ErrorAlert("Product Name is Required")
    }
   
   

    else
    {
        let markup = `<tr>
                      <td><input hidden class="DId" readonly value="${$('#DId').val()}"/>${$('#DId option:selected').text()}</td>
                       <td><input class="TimeIn form-control" readonly value="${$('#TimeIn').val()}" /></td>
                       <td><input class="TimeOut form-control" readonly value="${$('#TimeOut').val()}" /></td>
                      

                   
                      <td><a class="btn_delete text-danger-600"><i class="icon-trash"></i></a></td>
                      </tr>`
        $('.VoucherDetail').append(markup)

     
       

    }
})













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































































$('tbody.VoucherDetail').delegate(".removeitem", "click", function () {
    debugger;


    $(this).closest('tr').remove();





   

});






$('.SaveBtn').on('click', function () {
    var MonthId = $('#MonthId').val();
    var LevelId = $('#LevelId').val();
    var BankId = $('#BankId').val();
   
   


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

            AdAmt: $('#AdAmt').val(),
            AnnAmt: $('#AnnAmt').val(),
            MontlyAmt: $('#MontlyAmt').val(),
            MDisAmt: $('#MDisAmt').val(),

            OtherAmt: 0,
            TAmount: $('#TAmount').val(),
            RefId: $('#RefId').val(),
            penaltyAmt: $('#penaltyAmt').val(),
            VouMode: 1,






            //  StudentN: parseInt($('#StudentN option:selected').val()),
          

        }


        $('tbody.VoucherDetail tr').each(function () {

            FeeVoucherDetail.push({



                FeeId: $('#FeeId').val(),
                GRId: parseInt($(this).find(".GRId").val()),
                GrNo: parseInt($(this).find(".Grno").val()),
                PanelId: parseInt($(this).find(".PanelId").val()),
                AdAmt: parseFloat($(this).find(".AdmAmt").val()),
                AnnAmt: parseFloat($(this).find(".AnnualAmt").val()),
                MontlyAmt: parseFloat($(this).find(".MonthlyAmt").val()),
                MDisAmt: parseFloat($(this).find(".MDisAmt").val()),

                TAmount: parseFloat($(this).find(".TotalAmt").val()),
                ChallanNo: parseInt($(this).find(".ChallanNo").val()),
              




            });



        });


     


       
        console.log(FeeVoucher);
        console.log(FeeVoucherDetail);



        debugger;

        var FeeId = $('#FeeId').val();

        if (FeeId > 0) {

            debugger;
            GetJSONRequest('/Transaction/FeeVoucher/UpdateFeeVoucher', 'POST', { FeeVoucher, FeeVoucherDetail }, function (data) {
                SuccessAlert("Data Saved");
                $('.closeBtn').trigger('click');
            });
        }
        else {

            debugger;


            GetJSONRequest('/Transaction/FeeVoucher/SaveFeeVoucher', 'POST', { FeeVoucher, FeeVoucherDetail }, function (data) {
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




