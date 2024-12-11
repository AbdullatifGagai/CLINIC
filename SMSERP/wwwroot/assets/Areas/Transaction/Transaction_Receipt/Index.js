
$(document).ready(() => {
   // debugger;

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
            
            "url": "/Transaction/Transaction_Receipt/Transaction_ReceiptGetAllWithPagination",
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

            { "data": "VoucherNo", "autoWidth": true },
            { "data": "Date", "autoWidth": true },
            { "data": "VModeName", "autoWidth": true },
            { "data": "MNo", "autoWidth": true },
            { "data": "RegID", "autoWidth": true },
            { "data": "RefId", "autoWidth": true },

            { "data": "Amount", "autoWidth": true },
           


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
                    return `<ul class="icons-list"> <li class="text-primary-600"><a data-modalhorizontal="true" data-modalsize="modal-lg" data-heading="Edit Customer" data-script="/assets/Areas/Transaction/Transaction_Receipt/Receipt.js" data-url="/Transaction/Transaction_Receipt/ATransaction_Receipt?Id=${full.ID}"><i class="icon-pencil7"></i></a></li><li class="text-danger-600"><a id="${full.ID}" Refid="${full.RefId}" class="DeleteBtn"><i class="icon-trash"></i></a></li><li class="text-green-600"><a id="${full.AllowId}" Rid="${full.ID}" class="smsBtn"><i class=" icon-file-upload"></i></a></li></ul>`;
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
    debugger;
    DeleteAlert({ 'Id': $(this).attr('id'), 'RefId': $(this).attr('Refid') }, '/Transaction/Transaction_Receipt/DeleteTransaction_Receipt', 'Receipt');

});





$('#body').delegate('.smsBtn', 'click', function () {
   
    SmsAlert({ 'AllowId': $(this).attr('id'), 'RId': $(this).attr('Rid'), 'ValdationId' : 1 }, '/Transaction/Transaction_Receipt/SendSms', 'Receipt');

});





