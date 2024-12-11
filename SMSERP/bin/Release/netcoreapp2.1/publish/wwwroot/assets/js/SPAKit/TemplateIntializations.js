//$("#btnSubmit").click(function () {
//    if ($("#frm").valid()) {
//        $("#btnSubmit").attr('data-submit', 'true');
//    }
//});

const { alert } = require("bootbox");

   
//data-submit="true"
//$('form').delegate('.btn-success', 'click', function () {
    
//    if (('form').valid())
//    {
        
//        $(".btn-success").attr('data-submit', 'true');
//    }

//});\


var table;





function ApplyTemplateInitializers(html)
{
    
	// Added by Yousuf
	$('.Status').unbind('change');

    $('.Status').change(function () {
        debugger;
		const current = $(this);
		const id = current.parent().parent().attr('data-rowid');
		const url = current.attr('data-customurl');
		const identifier = current.attr('data-identifier');
		const payload = {};
		payload[identifier] = id;

		GetJSONRequest(url, 'POST', { model: payload }, response => {
            console.log(response);
            const Statuselem = $(current).closest('td').find('span');
            if ($(Statuselem).text() == 'Yes') {
                $(Statuselem).text("No").removeClass('text-blue').addClass('text-danger');
                const tr = $(Statuselem).closest('tr');
                table.rows(tr).invalidate().draw();
            }
            else {
                $(Statuselem).text("Yes").removeClass('text-danger').addClass("text-blue");
                const tr = $(Statuselem).closest('tr');
                table.rows(tr).invalidate().draw();

            }
		});
	});
	//End

    if ($(html).has('.datatable-basic').length)
    {
        
        BasicDataTableInitializers();  
        console.log('Here Table');
    }
    $('select').select2();
    if ($(html).has('form').length)
    {
        DropDown2Initializers();
       // MaskInitializers();
    }
}


function MaskInitializers() {
    $('input[data-format]').each(function (i, elem) { var format = $(elem).data('format'); $(elem).formatter({ pattern: format, persistent: true }); });
}

function DropDown2Initializers()
{
    $('select').select2({
        // options
    });


}


function BasicDataTableInitializers()
{
   
   //for responsive datatable
    $.extend($.fn.dataTable.defaults, {
        responsive: true,
        autoWidth: false,
      
        dom: '<"datatable-header"B><"datatable-scroll-wrap"t><"datatable-footer"lip>',

    });

     table = $('.datatable-basic').DataTable({
        //< "datatable-header"fl ><"datatable-scroll"t><"datatable-footer"lp>
    
        //buttons: {
        //    //dom: {
        //    //    button: {
        //    //        className: 'btn btn-default'
        //    //    }
        //    //},
        //    //buttons: [

        //    //    'excelHtml5',
        //    //    'csvHtml5',
        //    //    {
        //    //        extend: 'pdfHtml5',
        //    //        orientation: 'portrait',
        //    //        pageSize: 'A4',
        //    //        exportOptions: {
        //    //            columns: ':not(:last-child)',
        //    //        },
        //    //        customize: function (doc) {
        //    //            doc.defaultStyle.fontSize = 7;
        //    //        }
        //    //    }        ]
        
        //},
     //   dom: '<"datatable-scroll"t><"datatable-footer"lip>',
        language: {
        //    search: '<span>Filter:</span> _INPUT_',
                lengthMenu: '_MENU_',
        //    //paginate: { 'first': 'First', 'last': 'Last', 'next': '→', 'previous': '←' }
        },
        "lengthMenu": [[10, 25, 50, -1], [10, 25, 50, "All"]]
        //drawCallback: function () {
        //    $(this).find('tbody tr').slice(-3).find('.dropdown, .btn-group').addClass('dropup');
        //},
        //preDrawCallback: function () {
        //    $(this).find('tbody tr').slice(-3).find('.dropdown, .btn-group').removeClass('dropup');
        //}
    });

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

    $('#FilterInput').on('keyup', function () {
            table.search(this.value).draw();
    });

    //for datasearch from datatable that is inside of modal view
    //$('#ModalBody').delegate('#FilterInputpages','keyup', function () {
    //    table.search(this.value).draw();
    //});
}



function BindCombo(dropdown, BindingDetails, data)
{
    alert(Data);
    alert(BindingDetails[0]);
    alert(BindingDetails[1]);
    var DDownBody = '';
    $(Data).each(function (index, element) {
        DDownBody = DDownBody + '<option value=' + element[BindingDetails[0]] + '> ' + element[BindingDetails[1]] + '<option/>';
    });
    $(dropdown).html(DDownBody);
}


//Button
//Table
//Table Action Column Components

function CreateUIDefaultIndex(Data, ComponentToAppendIn)
{
    var HeadingPanel = '<div class="panel panel-flat">    <div class="panel-heading">        <h5 class="panel-title">' + Data.heading + '<a class="heading-elements-toggle"><i class="icon-more"></i></a></h5>        <div class="heading-elements">            <ul class="icons-list">                <li>' + GenerateAnchorButton(Data.addButton) + '</li>            </ul>        </div>    </div>';
    var TableHeading = '<thead><tr role="row" class="bg-green-800">  ' + CreateHeadingForTable(Data.x) + ' <th class="style=" width="100px;" aria-label="Actions">Actions</th>                </tr>            </thead>';
    var TableBody = '<tbody class="dytable">' + CreateTableBody(Data.x) + '</tbody>';
    var Table = '<div class="panel-body">        <table class="table datatable-basic table-hover dataTable">            ' + TableHeading + TableBody + '            </table></div></div>';
    var CompleteUI = '<div class="panel panel-flat"> ' + HeadingPanel + Table + ' </div>';
    $.when($.when((ComponentToAppendIn).html(CompleteUI)).then(AppendActionColumn(Data.editButton))).then(BasicDataTableInitializers());
}

function CreateHeadingForTable(Data)
{
    var Headings = '';
    var Keys = Object.keys(Data[0]);
    $(Keys).each(function (i, item) { if (i != 0) { Headings += '<th>' + item + '</th>'; } });
    return Headings;
}

function CreateTableBody(Data)
{
    var tbrows = '';
    var Keys = Object.keys(Data[0]);
    for(var a = 0; a < Data.length; a++ )
    {
        tbrows += '<tr data-rid=' + Data[a][Keys[0]] + '>'
        $(Keys).each(function (i, item) { if (i != 0) { tbrows += '<td>' + Data[a][item] + '</td>'; } });
        tbrows += '</tr>';
    }
    return tbrows;
}

function AppendActionColumn(Data)
{
    $('tbody[class*="dytable"]').children().each(function (i, item) { $(item).append('<td>' + GenerateAnchorButton(Data, $(item).data('rid')) + '</td>'); });
}

function GenerateAnchorButton(Button, EData)
{    
    if (!EData) { EData = ''; }
    if (Button.viewURL != '#') {
        var dturl = 'data-url="' + Button.viewURL + EData + '"';
    }    
    var bhtml = '<a class="' + Button.cssClass + '" data-modalhorizontal="' + Button.modalHorizontal + '" data-heading="' + Button.viewHeading + '" id="btn_Add" ' + dturl + ' data-script="' + Button.viewScript + '" data-modalsize="' + Button.modalSize +'"><b>' + Button.text + '</b></a>';
    return bhtml;
}

function PlaceElementOnSpecifiedColumnEveryRow(table, Element, ColumnNo)
{    
    $('tbody[class*="dytable"]').children().each(function (i, elem) {
        var component = GenerateAnchorButton(Element, $(elem).data('rid'));      
        $(elem).children().eq(ColumnNo).append(component);        
    });
}


////Added by Qasim
////For Success Alert
//function ErrorAlert(Message) {
//    Swal.fire({
//        title: Message,
//        html: '<i class="icon-cross3  error icon-2x"></i> Failed',
//        //icon: 'error',
//        showConfirmButton: false,
//        position: 'center',
//        timer: 5000,
//        timerProgressBar: true,
//        width: '300px',
//        background: 'rgba(255,255,255,0.8)'
//    });
//}

//function SuccessAlert(Message) {
//    Swal.fire({


//        title: Message,

//        icon: 'success',
//        timer: 2500
//    })
//}

//function DeleteAlert(_JsonObj, _URL, _Menu) {
//    Swal.fire({
//        title: 'Are you sure?',
//        text: ' You won"t be able to revert this!',
//        timer: 10000,
//        timerProgressBar: true,
//        showCancelButton: true,
//        allowOutsideClick: false,
//        confirmButtonText: '<i class="icon-bin icon-1x"></i> Delete',
//        cancelButtonText: '<i class="icon-cross3 icon-1x"></i> Cancel',
//        confirmButtonColor: 'Red',
//        cancelButtonColor: 'Green',
//    }).then((result) => {
//        if (result.value) {
//            $.ajax({
//                type: 'POST',
//                url: _URL,
//                data: _JsonObj,
//                success: function (results) {
//                    if (results == 'OK') {
//                        SuccessAlert("Success");
//                        // CloseTab($('#TabHead .active').find('.tabcross'));
//                        LoadPartial($.parseHTML($('.navigation li [data-display="' + _Menu + '"]').closest('li').html()));
//                    }
//                    else {
//                        ErrorAlert(results);

//                    }
//                    //$('.navigation li [data-display="' + _Menu + '"]').closest('li a').click();
//                }
//            });
//        }
//    })
//}

function ErrorAlert(Message) {
    Swal.fire({
        title: Message,
        html: '<i class="icon-cross3  error icon-2x"></i> Failed',
        //icon: 'error',
        showConfirmButton: false,
        position: 'center',
        timer: 5000,
        timerProgressBar: true,
        width: '300px',
        background: 'rgba(255,255,255,0.8)'
    });
}

function SuccessAlert(Message) {
    Swal.fire({
        title: '',
        html: '<i class="icon-checkmark4 text-success icon-2x"></i> Successful',
        //icon: 'success',
        showConfirmButton: false,
        position: 'center',
        timer: 800,
        timerProgressBar: true,
        width: '300px',
        background: 'rgba(255,255,255,0.8)'
    });
}

function RevertAlert(_JsonObj, _URL, _Menu, _FileNumber) {
    Swal.fire({
        title: 'Are you sure?',
        text: ' You won"t be able to revert ' + _FileNumber,
        timer: 10000,
        timerProgressBar: true,
        showCancelButton: true,
        allowOutsideClick: false,
        confirmButtonText: '<i class="icon-bin icon-1x"></i> Revert',
        cancelButtonText: '<i class="icon-cross3 icon-1x"></i> Cancel',
        confirmButtonColor: 'Red',
        cancelButtonColor: 'Green',
    }).then((result) => {
        if (result.value) {
            $.ajax({
                type: 'POST',
                url: _URL,
                data: _JsonObj,
                success: function (results) {
                    if (results == 'OK') {
                        SuccessAlert("Success");
                        CloseTab($('#TabHead .active').find('.tabcross'));
                        LoadPartial($.parseHTML($('.navigation li [data-display="' + _Menu + '"]').closest('li').html()));
                    }
                    else {
                        ErrorAlert(results);

                    }
                    //$('.navigation li [data-display="' + _Menu + '"]').closest('li a').click();
                }
            });
        }
    })
}



function DeleteAlert(_JsonObj, _URL, _Menu) {
    Swal.fire({
        title: 'Are you sure?',
        text: ' You won"t be able to revert this!',
        timer: 10000,
        timerProgressBar: true,
        showCancelButton: true,
        allowOutsideClick: false,
        confirmButtonText: '<i class="icon-bin icon-1x"></i> Delete',
        cancelButtonText: '<i class="icon-cross3 icon-1x"></i> Cancel',
        confirmButtonColor: 'Red',
        cancelButtonColor: 'Green',
    }).then((result) => {
        if (result.value) {
            $.ajax({
                type: 'POST',
                url: _URL,
                data: _JsonObj,
                success: function (results) {
                    if (results == 'OK') {
                        SuccessAlert("Success");
                       // CloseTab($('#TabHead .active').find('.tabcross'));
                        LoadPartial($.parseHTML($('.navigation li [data-display="' + _Menu + '"]').closest('li').html()));
                    }
                    else {
                        ErrorAlert(results);

                    }
                    //$('.navigation li [data-display="' + _Menu + '"]').closest('li a').click();
                }
            });
        }
    })
}




function SmsAlert(_JsonObj, _URL, _Menu) {
    Swal.fire({
        title: 'Are you sure Send Sms?',
        text: ' You won"t be able to revert this!',
        timer: 10000,
        timerProgressBar: true,
        showCancelButton: true,
        allowOutsideClick: false,
        confirmButtonText: '<i class="icon-pencil7 icon-1x"></i> Send Sms',
        cancelButtonText: '<i class="icon-cross3 icon-1x"></i> Cancel',
        confirmButtonColor: 'Green',
        cancelButtonColor: 'Red',
    }).then((result) => {
        if (result.value) {
            $.ajax({
                type: 'POST',
                url: _URL,
                data: _JsonObj,
                success: function (results) {
                    if (results == 'OK') {
                        SuccessAlert("Success");
                        // CloseTab($('#TabHead .active').find('.tabcross'));
                     //   LoadPartial($.parseHTML($('.navigation li [data-display="' + _Menu + '"]').closest('li').html()));
                    }
                    else {
                     //   ErrorAlert(results);

                        SuccessAlert("Success");

                    }
                    //$('.navigation li [data-display="' + _Menu + '"]').closest('li a').click();
                }
            });
        }
    })
}










function TransferFormAlert(_JsonObj, _URL, _Menu) {
    Swal.fire({
        title: 'Are you sure?',
        text: 'TRANSFER FORM RECEIVED!',
        timer: 10000,
        timerProgressBar: true,
        showCancelButton: true,
        allowOutsideClick: false,
        confirmButtonText: '<i class="icon-bin icon-1x"></i> Yes',
        cancelButtonText: '<i class="icon-cross3 icon-1x"></i> No',
        confirmButtonColor: 'Green',
        cancelButtonColor: 'Red',
    }).then((result) => {
        if (result.value) {
            $.ajax({
                type: 'POST',
                url: _URL,
                data: _JsonObj,
                success: function (results) {
                    if (results == 'OK') {
                        SuccessAlert("Success");
                        // CloseTab($('#TabHead .active').find('.tabcross'));
                        LoadPartial($.parseHTML($('.navigation li [data-display="' + _Menu + '"]').closest('li').html()));
                    }
                    else {
                        ErrorAlert(results);

                    }
                    //$('.navigation li [data-display="' + _Menu + '"]').closest('li a').click();
                }
            });
        }
    })
}
