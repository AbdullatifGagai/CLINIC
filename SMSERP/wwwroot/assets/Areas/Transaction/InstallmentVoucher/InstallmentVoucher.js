


if ($('#InsCode').val() > 0) {

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

    document.getElementById('InsDate').valueAsDate = new Date();
    document.getElementById('IntDueDate').valueAsDate = new Date();


    /// document.getElementById('FMonth').valueAsDate = new Date();
   // document.getElementById('TMonth').valueAsDate = new Date();


    //$('#UserName').val($('#personName').text());
    //$('#UserId').val($('#personId').val())


}







$('#AddItemBtn').click(() => {



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
                        <th>SeatNo</th>
						
						





                        <th>Actions</th>

					</tr>
				</thead><tbody>`;

    data.forEach((item) => {
        markup += `<tr><td>${item.Grno}</td><td>${item.StudentName}</td><td>${item.LevelName}</td><td>${item.Shift}</td><td>${item.SeatNo}</td><td><button type="button" class="selectAllowId btn btn-primary" id=${item.GRId}>Select</button></td></tr>`

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

    GetJSONRequest('/Master/Student/StudentGetVoucher', 'GET', { GrId }, function (data) {

        if (data && data.length > 0) {

            debugger;
            console.log(data);
          /*  $('tbody.ChaDetails').empty();*/
           /* for (var item of data) {*/

              


                //const markup = `
                //            <tr>
                              
                              
                //                <td>
                //                         <input type="text" class="form-control ChallanNo" readonly value="${item.ChallanNo}"/>
                                         
                //                </td>
                              

                                        
                            

                //              <td><input type="text" class="form-control MonthName"  readonly value="${item.MonthName}" /></td>
                //              <td><input type="text" class="form-control VMode"  readonly value="${item.VMode}" /></td>
                //              <td><input type="text" class="form-control Amount"  readonly value="${item.Amount}" /></td>
                             
                                
                                

                                 
                                   
                              
                //                <td><a id=""><i class="icon-circle-right2 VoucherNO text-primary-600"></i></a>



                // </tr>`;
                //$('tbody.ChaDetails').append(markup);

            $('#Name').val(data[0].StudentName);
           
            $('#Grno').val(data[0].Grno);
            $('#GrId').val(data[0].GRId);


                //calculateAdmAmt()
                //calculateAnnAmt()
                //calculateMonthlyAmt()
                //calculateDisTotalAmt()
                //calculateTotalAmt()

           /* }*/



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