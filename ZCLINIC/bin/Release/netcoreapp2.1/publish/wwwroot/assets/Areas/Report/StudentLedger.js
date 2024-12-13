


document.getElementById('FromDate').valueAsDate = new Date();
document.getElementById('ToDate').valueAsDate = new Date();


$('#ClearItemBtn').click(() => {




    $('#Name').val('');

    $('#Grno').val('');
    $('#GrId').val('');

 



})




$('#AddItemBtn').click(() => {

    $('#Name').val('');

    $('#Grno').val('');
    $('#GrId').val('');


    debugger;

    GetJSONRequest('/Master/Student/StudentGetReceipt', 'GET', '', function (data) {

        if (data && data.length > 0) {


            debugger;

            AllowSearch(data);


        }
        else

            ErrorAlert("No Data Found");
    })




})




$('#FeeId').click(function (e) {


    //var format1 = 'Form Date: ' + moment($("#FromDate").val()).format('DD/MM/YYYY') +
    //    ' Up to Date: ' + moment($("#ToDate").val()).format('DD/MM/YYYY') +
    //    ' From Account Name: ' + $("#FAccountCode").val() + '-' + $('#FAccountName option:selected').text() +
    //    ' Upto Account Name: ' + $("#TAccountCode").val() + '-' + $('#TAccountName option:selected').text();


    //var RecId = $('#FId').val();


    debugger


    var value = `/Report/Reportrdlc/AReport?rvalues.Name=24&rvalues.Value[0]=${$('#GrId').val()}&rvalues.Value[1]=${$('#FromDate').val()}&rvalues.Value[2]=${$('#ToDate').val()}&rvalues.Value[3]=''&rvalues.Value[4]=''&rvalues.Value[5]=''&rvalues.Value[6]=''`
    $(this).attr('href', value)
    $(this).attr('target', "_blank")




})



function AllowSearch(data) {

    debugger;
    //$('#UnitId').val('');
    //$('#UnitName').val('');
    //$('#PlotNo').val('');
    //$('#SName').val('');


    $('#SModal').modal('show');
    $('.modal-dialog').addClass('modal-lg');

    $('#SModalTitle').text('Student List');
    let markup = `<div class="row">
         
                   <div class="col-sm-3">
                    <div class="input-group ">
                        <input type="text" class="form-control datasearch" placeholder="Filter" id="FilterInputoptpurchase">
                        <span class="input-group-addon bg-blue-800"><i class="icon-search4"></i></span>
                    </div>
                </div></div><table id="myTable" class="table datatable-basic table-xxs table-md table-bordered table-striped table-hover bg-lightgray dataTables_scrollBody">
				<thead>
					<tr class="bg-blue-800">
                        <th>GrNo</th>
                        <th>Student Name</th>
                        <th>Class Name</th>
                        <th>Shift</th>
						
						
                        
                        <th>Actions</th>

					</tr>
				</thead><tbody>`;

    data.forEach((item) => {
        markup += `<tr><td>${item.Grno}</td><td>${item.StudentName}</td><td>${item.LevelName}</td><td>${item.Shift}</td><td><button type="button" class="selectAllowId btn btn-primary" id=${item.GRId}>Select</button></td></tr>`

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


    var GrId = $(this).attr('id');


    // $('#AllowID').val($(this).closest('tr').children().eq(0).text());

    console.log(GrId);

    GetJSONRequest('/Master/Student/StudentGetReportLedger', 'GET', { GrId }, function (data) {

        if (data && data.length > 0) {

          
          

               

            $('#Name').val(data[0].StudentName);
         
            $('#Grno').val(data[0].Grno);
            $('#GrId').val(data[0].GRId);


                //calculateAdmAmt()
                //calculateAnnAmt()
                //calculateMonthlyAmt()
                //calculateDisTotalAmt()
                //calculateTotalAmt()

          



        }
















        else {

            ErrorAlert("No Data Found");

            //$('#DebitAcc').val('')
            //$('#CrditAcc').val('')
            //$('#CreditAccName').val('')
            //$('#DebitAccName').val('')


        }

                    //$('#Name').val(data[0].StudentName);
            //$('#PName').val(data[0].PanelN);
            //$('#GRNo').val(data[0].Grno);
            //$('#GrId').val(data[0].GRId);

    })




















    // $('#ProductId').val($(this).attr('id'));
    $('#SModal').modal('hide');
})

$('tbody.ChaDetails').delegate(".VoucherNO", "click", function () {
    debugger;



    const VoucherId = parseInt($(this).closest('tr').children().eq(0).find('.ChallanNo').val());

    console.log(VoucherId);

    GetJSONRequest('/Transaction/FeeVoucher/GetFeeVoucherNo', 'GET', { VoucherId }, function (data) {
        debugger;
        if (data && data.length > 0) {
            
            $('#MonthName').val(data[0].MonthName);
            $('#Amt').val(data[0].VoucherAmt);
            $('#MonId').val(data[0].MonthId);
            $('#ChaNo').val(data[0].ChallanNo);
            

            

        }
        else

            ErrorAlert("No Data Found");
    })



  

});