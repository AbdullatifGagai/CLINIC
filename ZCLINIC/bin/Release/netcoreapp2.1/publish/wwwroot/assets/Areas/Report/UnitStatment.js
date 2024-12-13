

document.getElementById('FromDate').valueAsDate = new Date();
document.getElementById('ToDate').valueAsDate = new Date();

$('#UnitN').focus();




//$('#Master_Code').change(() => {


 
//    if ($('#Master_Code').val() != '') {




//        var Id = $('#Master_Code').val()






//        GetJSONRequest('/Master/Master_SubAccount/GetMasterIdSubAccount', 'GET', { Id }, function (data) {

//            if (data && data.length > 0) {
//                $('#FAccountName').empty();
//                $('#ToAccountName').empty();

//                for (const elem of data) {
//                    $('#FAccountName').append($("<option></option>").attr("value", elem.Sub_accountCode).text(elem.Subacc_Name));
//                    $('#FAccountId').val(data[0].Sub_ID);
//                    $('#FAccountCode').val(data[0].Sub_accountCode);

//                    $('#ToAccountName').append($("<option></option>").attr("value", elem.Sub_accountCode).text(elem.Subacc_Name));
//                    $('#TAccountId').val(data[0].Sub_ID);
//                    $('#TAccountCode').val(data[0].Sub_accountCode);
//                }
//                //const selectedId = Math.max(...data.map(d => d.CustomerId));
//                //$('#RDId').val(selectedId).change();
//            }


     
//            else {

//                ErrorAlert("No Data Found");
//                $('#FAccountName').empty();
//                $('#ToAccountName').empty();
//                $('#FAccountId').val('');
//                $('#FAccountCode').val('');
//                $('#TAccountId').val('');
//                $('#TAccountCode').val('');
//                //$('#DebitAcc').val('')
//                //$('#CrditAcc').val('')
//                //$('#CreditAccName').val('')
//                //$('#DebitAccName').val('')


//            }



//         })


//    }

//    else {
//        ErrorAlert("Missing Value");
//    }

//})





//$('#FAccountName').change(() => {


    
//    if ($('#FAccountName').val() != '') {




//        var Id = $('#FAccountName').val()





//        GetJSONRequest('/Master/Master_SubAccount/GetSubIdSubAccount', 'GET', { Id }, function (data) {

//            if (data && data.length > 0) {

//                debugger;

//                $('#FAccountId').val(data[0].Sub_ID);
//                $('#FAccountCode').val(data[0].Sub_accountCode);


//                //$('#CreditAccName').val(data[0].SubNamecredit);
//                //$('#CrditAcc').val(data[0].SubCodecredit);


//            }
//            else {

//                ErrorAlert("No Data Found");

//                //$('#DebitAcc').val('')
//                //$('#CrditAcc').val('')
//                //$('#CreditAccName').val('')
//                //$('#DebitAccName').val('')


//            }



//        })


//    }

//    else {
//        ErrorAlert("Missing Value");
//    }

//})







//$('#ToAccountName').change(() => {



//    if ($('#ToAccountName').val() != '') {




//        var Id = $('#ToAccountName').val()





//        GetJSONRequest('/Master/Master_SubAccount/GetSubIdSubAccount', 'GET', { Id }, function (data) {

//            if (data && data.length > 0) {

//                debugger;

//                $('#TAccountCode').val(data[0].Sub_accountCode);
//                $('#TAccountId').val(data[0].Sub_ID);


//                //$('#CreditAccName').val(data[0].SubNamecredit);
//                //$('#CrditAcc').val(data[0].SubCodecredit);


//            }
//            else {

//                ErrorAlert("No Data Found");

//                //$('#DebitAcc').val('')
//                //$('#CrditAcc').val('')
//                //$('#CreditAccName').val('')
//                //$('#DebitAccName').val('')


//            }



//        })


//    }

//    else {
//        ErrorAlert("Missing Value");
//    }

//})


$('#Clean').click(function (e) {
    $('#UnitN').val('');
    $('#AllowId').val('');
    $('#CardId').val('');
    $('#RegNo').val('');
    $('#Mno').val('');
    $('#AllowName').val('');
    $('#UnitN').focus();



})

$('#AccDetail').click(function (e) {

    debugger;
    
    var Date = 'Form Date: ' + moment($("#FromDate").val()).format('DD/MM/YYYY') +
        ' Up to Date: ' + moment($("#ToDate").val()).format('DD/MM/YYYY');



    var SatUp = 'Statement Of : ' + $('#VMode option:selected').text();

    var value = `/Report/Reportrdlc/AReport?rvalues.Name=9&rvalues.Value[0]=${$('#FromDate').val()}&rvalues.Value[1]=${$('#ToDate').val()}&rvalues.Value[2]=${$('#VMode').val()}&rvalues.Value[3]=${$('#AllowId').val()}&rvalues.Value[4]=''&rvalues.Value[5]=${SatUp}&rvalues.Value[6]=${Date}`
        $(this).attr('href', value)
        $(this).attr('target', "_blank")


   



   

})


$('#AccSummary').click(function (e) {

    debugger;
    
   

    var value = `/Report/Reportrdlc/AReport?rvalues.Name=10&rvalues.Value[0]=${$('#AllowId').val()}&rvalues.Value[1]=''&rvalues.Value[2]=''&rvalues.Value[3]=''&rvalues.Value[4]=''&rvalues.Value[5]=''&rvalues.Value[6]=''`
        $(this).attr('href', value)
        $(this).attr('target', "_blank")


   



   

})




$('#UnitN').keydown(function (e) {
    if (e.keyCode == 13) {

        var Id = $('#UnitN').val()

        debugger;

        if (Id != "") {

       



        GetJSONRequest('/Transaction/Transaction_UnitAllow/GetAllowmentSearch', 'GET', { Id }, function (data) {

            if (data && data.length > 0) {

                debugger;

              ///  $('#MNo').val(data[0].MNo);
              ///  $('#RegID').val(data[0].RegID);
                SearchAllow(data);

            }
            else

                ErrorAlert("No Data Found");
        })

        }


        else {
            ErrorAlert("Miss Value Found");
        }

        
    }
});






function SearchAllow(data) {

    debugger;
    $('#UnitN').val('');
    $('#AllowId').val('');
    $('#CardId').val('');
    $('#RegNo').val('');
    $('#Mno').val('');
    $('#AllowName').val('');
 




    $('#SModal').modal('show');
    $('.modal-dialog').addClass('modal-lg');

    $('#SModalTitle').text('Allowment  List');
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
						<th>Name</th>
					    <th>Father Name</th>
                        <th>Unit Name</th>
                        <th>MNo</th>
                        <th>RegId</th>
                        <th>Card Id</th>
						
                        
                        <th>Actions</th>

					</tr>
				</thead><tbody>`;

    data.forEach((item) => {
        markup += `<tr><td>${item.AllowID}</td><td>${item.Name}</td><td>${item.Fname}</td><td>${item.UnitName}</td><td>${item.MNo}</td><td>${item.RegID}</td><td>${item.Cardid}</td><td><button  type="button" class="selectAllowBtn btn btn-primary" id=${item.UnitId}>Select</button></td></tr>`

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


$('#SModalBody').delegate('.selectAllowBtn', 'click', function () {


   



    $('#AllowId').val($(this).closest('tr').children().eq(0).text());


    $('#UnitN').val($(this).closest('tr').children().eq(3).text());
    $('#RegNo').val($(this).closest('tr').children().eq(5).text());
    $('#Mno').val($(this).closest('tr').children().eq(4).text());
    $('#AllowName').val($(this).closest('tr').children().eq(1).text());
    $('#CardId').val($(this).closest('tr').children().eq(6).text());
   

   
    //$('#Transfermobile').val($(this).closest('tr').children().eq(5).text());
    //$('#TransferNic').val($(this).closest('tr').children().eq(4).text());



    // $('#ProductId').val($(this).attr('id'));
    $('#SModal').modal('hide');
})


