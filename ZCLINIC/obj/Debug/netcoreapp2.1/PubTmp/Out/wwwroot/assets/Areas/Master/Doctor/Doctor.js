


debugger;


if ($('#DocId').val() > 0) {
   

    //$('#MonthId').attr('disabled', 'true')
    //$('#LevelId').attr('disabled', 'true')
    //$('#StudentN').attr('disabled', 'true')
    //$('#LeaveF').attr('disabled', 'true')
    //$('#AddItemBtn').attr('disabled', 'true')
    //$('#BankId').attr('disabled', 'true')

    var DocId = $('#DocId').val()

    //FeeVoucherDetail(Feeid);



    DoctorDaysDetails(DocId);











   
}
else {

    //document.getElementById('VouDate').valueAsDate = new Date();
    //document.getElementById('DueDate').valueAsDate = new Date();


    //$('#UserName').val($('#personName').text());
    //$('#UserId').val($('#personId').val())
   

}

function DoctorDaysDetails(id) {



    GetJSONRequest('/Master/DoctorDayDatails/GetDoctorIdDaysDetail', 'GET', { id }, data => {


        debugger;
        let i = 0;


        if (data && data.length > 0) {
            $('tbody.VoucherDetail').empty();
            for (const item of data) {
                i++;
                const markup = `
               <tr>



                      <td><input hidden class="DId" readonly value="${item.DId}" />${item.DaysName}</td>
                      
                       <td><input type="text" class="form-control TimeIn"  readonly value="${item.TimeIn}" /></td>

                        <td><input type="text" class="form-control TimeOut"  readonly value="${item.TimeOut}" /></td>



                      <td><a class="removeitem text-danger-600"><i class="icon-trash"></i></a></td>





                 </tr>`;

                $('tbody.VoucherDetail').append(markup);
           
            }


            debugger;

          


            return;
        }
        ErrorAlert('No Record Found');
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

                        


                       <td><input type="time" class="TimeIn form-control" readonly value="${$('#TimeIn').val()}" /></td>
                       <td><input  type="time"  class="TimeOut form-control"  readonly value="${$('#TimeOut').val()}" /></td>
                      

                   
                      <td><a class="removeitem text-danger-600"><i class="icon-trash"></i></a></td>
                      </tr>`
        $('tbody.VoucherDetail').append(markup)

     
       

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
    var DoctorName = $('#DoctorName').val();
   

    var check = false;




    if (DoctorName == 0 || DoctorName == null) {


        ErrorAlert("Enter DoctorName  Name");
        check = true;

    }

    

    
   


    if (!check) {

        
       












        var Doctor = [], DoctorDayDatails = [];



        Doctor = {
            DocId: $('#DocId').val(),
            DocCode: $('#DocCode').val(),
            DoctorName: $('#DoctorName').val(),

            SpId: parseInt($('#SpId option:selected').val()),
         
            DocOPDShare: $('#DocOPDShare').val(),
            LPatient: $('#LPatient').val(),
            OPDRate: $('#OPDRate').val(),
            Remarks: $('#Remarks').val(),
         

        }


        $('tbody.VoucherDetail tr').each(function () {

            DoctorDayDatails.push({



                DocId: $('#DocId').val(),
                DId: $(this).find(".DId").val(),

                TimeIn: $(this).find(".TimeIn").val(),
                TimeOut: $(this).find(".TimeOut").val(),

               

               // TimeIn: Moment($(this).find(".TimeIn").val(), 'HH:mm:ss'),
              
              

              


            });



        });


     


       
        //console.log(DoctorMaster);
        //console.log(DoctorDetails);



        debugger;

        var DocId = $('#DocId').val();

        if (DocId > 0) {


            GetJSONRequest('/Master/Doctor/UpdateDoctor', 'POST', { Doctor, DoctorDayDatails }, function (data) {
                SuccessAlert("Data Saved");
                $('.closeBtn').trigger('click');
            });
        }
        else {




            GetJSONRequest('/Master/Doctor/SaveDoctor', 'POST', { Doctor, DoctorDayDatails }, function (data) {


                debugger;



                if (data =="OK") {
                    SuccessAlert("Data Saved");
                    $('.closeBtn').trigger('click');
                }
                else {
                    

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




