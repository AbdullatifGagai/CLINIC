


if ($('#VoucherNo').val() > 0) {

    //$('tbody.MonthlyProDetails tr').each(function () {


    //    //     let store = $(this).children().eq(0);
    //    //   $(store).find('.Store').val($(store).find('.SalesId').val()).change();


    //    //$('tbody.saleOrderDetail tr').each(function () {
    //    //  //  let eyeside = $(this).children().eq(3)
    //    //  ///  let store = $(this).children().eq(7);
    //    // ///   $(eyeside).find('.EyeSideDrop').val($(eyeside).find('.EyeSide').val()).change();
    //    //  ///  $(store).find('.Store').val($(store).find('.StoreId').val()).change();
    //    //})

    //    //document.getElementById('OrderDate').valueAsDate = new Date();
    //    //document.getElementById('Send_Date').valueAsDate = new Date();
    //    //document.getElementById('Bill_Date').valueAsDate = new Date();


    //})
}
else {

    document.getElementById('Date').valueAsDate = new Date();
    document.getElementById('FMonth').valueAsDate = new Date();
    document.getElementById('TMonth').valueAsDate = new Date();


    //$('#UserName').val($('#personName').text());
    //$('#UserId').val($('#personId').val())


}

$('#VMode').change(() => {


    debugger;
    if ($('#VMode').val() != '') {




        var Id = $('#VMode').val()






        GetJSONRequest('/Master/Master_VMode/GetVModeReceiptId', 'GET', { Id }, function (data) {

            if (data && data.length > 0) {



                $('#DebitName').val(data[0].SubNamedebit);
                $('#DebitCode').val(data[0].SubCode1Debit);


                $('#CreditName').val(data[0].SubNamecredit);
                $('#CreditCode').val(data[0].SubCode1Credit);


            }
            else {

                ErrorAlert("No Data Found");

                $('#DebitCode').val('')
                $('#CreditCode').val('')
                $('#CreditName').val('')
                $('#DebitName').val('')


            }



        })


    }

    else {
        ErrorAlert("Missing Value");




    }

})






$('#btnAllow').click(() => {





    GetJSONRequest('/Transaction/Transaction_UnitAllow/GetAllowment', 'GET', '', function (data) {

        if (data && data.length > 0) {


            debugger;

            AllowSearch(data);


        }
        else

            ErrorAlert("No Data Found");
    })




})








function AllowSearch(data) {

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
                        <th>AllowID</th>
						<th>Unit_id</th>
						<th>UnitName</th>
						<th>CPDID</th>
						<th>Name</th>

                       
                        <th>MNo</th>
                        <th>RegID</th>
						
                        
                        <th>Actions</th>

					</tr>
				</thead><tbody>`;

    data.forEach((item) => {
        markup += `<tr><td>${item.AllowID}</td><td>${item.Unit_Id}</td><td>${item.UnitName}</td><td>${item.CPDID}</td><td>${item.Name}</td><td>${item.MNo}</td><td>${item.RegID}</td><td><button type="button" class="selectAllowId btn btn-primary" id=${item.AllowID}>Select</button></td></tr>`

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


    // $('#AllowID').val($(this).closest('tr').children().eq(0).text());

    $('#UnitId').val($(this).closest('tr').children().eq(1).text());
    $('#UnitName').val($(this).closest('tr').children().eq(2).text());
    $('#CPDID').val($(this).closest('tr').children().eq(3).text());
    $('#Name').val($(this).closest('tr').children().eq(4).text());
    $('#MNo').val($(this).closest('tr').children().eq(5).text());
    $('#RegID').val($(this).closest('tr').children().eq(6).text());
    $('#AllowId').val($(this).closest('tr').children().eq(0).text());


    debugger;


    // $('#ProductId').val($(this).attr('id'));
    $('#SModal').modal('hide');
})

