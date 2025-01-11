

debugger;


$(document).ready(() => {



    debugger;



    $.extend($.fn.dataTable.defaults, {
        responsive: true,
        autoWidth: false,

        dom: '<"datatable-header"B><"datatable-scroll-wrap"t><"datatable-footer"lip>',

    });


    const table = $('.ServerSidePagination').DataTable({

        "drawCallback": function (settings) {
            table.search('');

        },

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
                }
            ]

        },
        "processing": true,
        "serverSide": true,
        "filter": true,
        "ajax": {

            "url": "/Transaction/ReceiptMaster/Transaction_ReceiptGetAll",
            "type": "POST",
            "datatype": "json",
            "data": function (d) { d.Status = $('#StatusFilter option:selected').val() }
        },
        "columnDefs": [{
            "targets": [0],
            "visible": true,
            "searchable": false,
            "targets": ['_all'], "orderable": false
        }],
        "columns": [

            { "data": "ReceiptNo", "autoWidth": true },
            { "data": "ReceiptDate", "autoWidth": true },
            { "data": "MrNo", "autoWidth": true },
            { "data": "PatientName", "autoWidth": true },
            { "data": "CashAmt", "autoWidth": true },
            { "data": "Shift", "autoWidth": true },
            //{ "data": "VOUCHER_NO", "autoWidth": true },






            //  { "data": "RDate", "autoWidth": true },






            //{ "data": "Name", "autoWidth": true },
            //{ "data": "ReceiptDate", "autoWidth": true },
            //{ "data": "Amt", "autoWidth": true },



            // { "data": "LevelName", "autoWidth": true },





            //<td>@s.Receipt_ID</td>
            //            <td>@s.Receipt_Code</td>
            //            <td>@s.Name</td>
            //            <td>@s.r_date</td>
            //            <td>@s.Amount</td>
            //            <td>@s.AidName</td>

            //  { "data": "AccountId", "autoWidth": true },
            //{ "data": "ContactPersonName", "autoWidth": true },
            //{ "data": "CPMobileNo", "autoWidth": true },

            //{
            //    //rendering explicit columns like status and actions button etc,this method is offically available in datatable documentation
            //    "render": (data, row, full) => {

            //        debugger;
            //        if (full.Status == 1) return `<input type="checkbox" class="Status" value="${full.CustomerId}" checked="checked" data-identifier="CustomerId" data-customurl="/Master/Customer/ToggleStatusCustomer" />`;
            //        return `<input type="checkbox" class="Status" value="${full.CustomerId}" data-identifier="CustomerId" data-customurl="/Master/Customer/ToggleStatusCustomer" />`

            //    }
            //},
            {
                "render": (data, row, full) => {
                    let markup = `<ul class="icons-list">`;



                    if (deleteview) {
                        markup += `<li class="text-danger-600"><a onclick="DeleteAlert({ 'Id':${full.ReceiptId}}, '/Transaction/ReceiptMaster/DeleteReceiptMaster', 'Receipt')"><i class="icon-trash"></i></a></li>`



                    }






                    if (editview) {
                        markup += `<li class="text-primary-600"><a data-modalhorizontal="true" data-modalsize="modal-lg" data-heading="Edit Fees Receipt" data-script="/assets/Areas/Transaction/ReceiptMaster/ReceiptMaster.js" data-url="/Transaction/ReceiptMaster/AReceiptMaster?Id=${full.ReceiptId}"><i class="icon-pencil7"></i></a></li>`

                          

                    }



                    if (Printview) {
                        markup += `<li class="text-primary-600"><a id="${full.ReceiptId}"  class="PrintBtn"><i class="icon-printer"></i></a></li>`
                    }











                    //markup += `<li class="text-danger-600"><a id="${full.ID}" Refid="${full.RefId}" class="DeleteBtn"><i class="icon-trash"></i></a></li>
                    //        <li class="text-primary-600"><a id="${full.ID}" VMode="${full.VMode}" class="PrintBtn"><i class="icon-printer"></i></a></li>
                    //        <li class="text-green-600"><a id="${full.AllowId}" Rid="${full.ID}" class="smsBtn"><i class=" icon-file-upload"></i></a></li>
                    //    </ul>`

                    return markup;





                    ;
                }
            },

        ]
        , "lengthMenu": [[10, 50, 150, 500, 1000], [10, 50, 150, 500, 1000]]
    })

    $(".dataTables_length").css('clear', 'none');
    $(".dataTables_length").css('float', 'left');
    $(".dataTables_length select").select2();

    $(".dataTables_info").css('clear', 'none');
    $(".dataTables_info").css('padding', '6px');
    $.fn.dataTable.ext.errMode = 'none';
    $('.datatable-basic').on('error.dt', function (e, settings, techNote, message) {
        //console.log('An error has been reported by DataTables: ', message);
        console.log('An error has been reported by DataTables: ');
    });

    $('#FilterInput').on('keyup', function (e) {
        debugger;
        if (e.keyCode === 13)
            table.search(this.value).draw();

    });

    $('#body').delegate('.Status').unbind('change');

    $('#body').delegate('#StatusFilter', 'change', () => { table.draw(); });
})









//status

//$('#body').delegate('.Status', 'change', function (e) {

//    const current = $(this);
//    const id = current.val();
//    const url = current.attr('data-customurl');
//    const identifier = current.attr('data-identifier');
//    const payload = {};
//    payload[identifier] = id;

//    GetJSONRequest(url, 'POST', { model: payload }, response => {
//        console.log(response);
//    });
//});

//delete

$('#body').delegate('.DeleteBtn', 'click', function () {
    const id = $(this).attr('id');
    const Refid = $(this).attr('Refid');




    // debugger;
    //  DeleteAlert({ 'Id': $(this).attr('id'), 'RefId': $(this).attr('Refid') }, '/Transaction/Transaction_Receipt/DeleteTransaction_Receipt', 'Receipt');

});


$('#body').delegate('.PrintBtn', 'click', function () {
    debugger;
    const id = $(this).attr('id');

    var value = `/Report/Reportrdlc/AReport?rvalues.Name=49&rvalues.Value[0]=${id}&rvalues.Value[1]=''&rvalues.Value[2]=''&rvalues.Value[3]=''&rvalues.Value[4]=1&rvalues.Value[5]=''&rvalues.Value[6]=''`



    $(this).attr('href', value)
    $(this).attr('target', "_blank")

});





//$('#body').delegate('.smsBtn', 'click', function () {

//    SmsAlert({ 'AllowId': $(this).attr('id'), 'RId': $(this).attr('Rid'), 'ValdationId': 1 }, '/Transaction/Transaction_Receipt/SendSms', 'Receipt');

//});





