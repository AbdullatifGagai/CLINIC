


if ($('#TestId').val() > 0) {

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


    ReceiptDetail($('#TestId').val());

    //})
}
else {

    //document.getElementById('ReceiptDate').valueAsDate = new Date();
    //document.getElementById('DateOfBirth').valueAsDate = new Date();

   

    /// document.getElementById('FMonth').valueAsDate = new Date();
   // document.getElementById('TMonth').valueAsDate = new Date();


    //$('#UserName').val($('#personName').text());
    //$('#UserId').val($('#personId').val())


}

function  ReceiptDetail(Id) {


    debugger;


    GetJSONRequest('/Master/LabtestDetail/LabtestDetailGetAll', 'GET', { Id }, data => {


        debugger;
        let i = 0;


        if (data && data.length > 0) {
            $('#tbodytable').empty();
            for (const item of data) {
                i++;
                const markup = `
               <tr>


                                
                                
                                    <td><input type="text" class="form-control Dis"  value="${item.Discri}" /></td>
                                    <td><input type="text" class="form-control Unit"  value="${item.Unit}" /></td>
                                  
                                    <td><input type="text" class="form-control Refvalue"  value="${item.Refvalue}" /></td>

                                    <td><a id=""><i class="icon-trash btn_delete text-danger-600"></i></a>



                 </tr>`;

                $('#tbodytable').append(markup);
                //calculateAdmAmt()
                //calculateAnnAmt()
                //calculateMonthlyAmt()
                //calculateDisTotalAmt()
                //calculateTotalAmt()

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























$('#RefNo').keyup(function (e) {
    if (e.keyCode == 13) {




        var Id = $('#RefNo').val();


        ReceiptRefno(Id);
       











    }
});








$('#PatientName').keyup(function (e) {
    if (e.keyCode == 13) {




        var PatientName = $('#PatientName').val();



        GetJSONRequest('/Master/PatientReg/GetPatientName', 'GET', { PatientName}, function (data) {

            if (data && data.length > 0) {


                debugger;



               


                AllowSearch(data);


            }
            else

                ErrorAlert("No Data Found");
        })












    }
});





function AllowSearch(data) {

    debugger;
    //$('#UnitId').val('');
    //$('#UnitName').val('');
    //$('#PlotNo').val('');
    //$('#SName').val('');


    $('#SModal').modal('show');
    $('.modal-dialog').addClass('modal-lg');

    $('#SModalTitle').text('Patient  List');
    let markup = `<div class="row">
         
                   <div class="col-sm-3">
                    <div class="input-group ">
                        <input type="text" class="form-control datasearch" placeholder="Filter" id="FilterInputoptpurchase">
                        <span class="input-group-addon bg-blue-800"><i class="icon-search4"></i></span>
                    </div>
                </div></div><table id="myTable" class="table datatable-basic table-xxs table-md table-bordered table-striped table-hover bg-lightgray dataTables_scrollBody">
				<thead>
					<tr class="bg-blue-800">
                        <th>MRId</th>
                        <th>MrNo</th>
                        <th>Patient Name</th>
                        <th>Father Name</th>
                        <th>Cell no</th>
                        <th>Date Of Birth</th>
                        <th>Age</th>
						
						





                        <th>Actions</th>

					</tr>
				</thead><tbody>`;

    data.forEach((item) => {
        markup += `<tr><td>${item.MRId}</td><td>${item.MrNo}</td><td>${item.Name}</td><td>${item.Fname}</td><td>${item.Cellno}</td><td>${item.Bdate}</td><td>${item.PAge}</td><td><button type="button" class="selectAllowId btn btn-primary" id=${item.MRId}>Select</button></td></tr>`

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


    
    $('#MrId').val('');
    $('#MrNo').val('');
    $('#PatientName').val('');
    $('#DateOfBirth').val('');
    $('#Age').val('');
       



        $('#MrId').val($(this).closest('tr').children().eq(0).text());
        $('#MrNo').val($(this).closest('tr').children().eq(1).text());
        $('#PatientName').val($(this).closest('tr').children().eq(2).text());
        $('#DateOfBirth').val($(this).closest('tr').children().eq(5).text());
        $('#age').val($(this).closest('tr').children().eq(6).text());





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
           
            

            

        }
        else

            ErrorAlert("No Data Found");
    })



  

});









$('#CategoryId').change(function () {
    let Id = parseInt($('#CategoryId').val());
    let PId = parseInt($('#PanelId').val());

    //debugger;

   


    GetJSONRequest('/Master/ClinicServices/Master_ClinicServicesGetServicesName', 'GET', { Id, PId }, data => {

        if (data && data.length > 0) {
            $('#SevicesId').empty();
            $('#SevicesId').append(`<option value="0">Select Services</option>`);
            for (const model of data) {

                $('#SevicesId').append(`<option value="${model.ServicesId}">${model.ServicesName}</option>`);

            }



             $('#CategoryId').attr('disabled', 'true')
            $('#PanelId').attr('disabled', 'true')

            $('#SevicesId').select2()
          


            return;



        }
        ErrorAlert("No Records Found");
        $('#SevicesId').empty();
       

        /// $('#Comp_id').attr('disabled', 'true')

    })


})


$('#SevicesId').change(function () {
    let Id = parseInt($('#SevicesId').val());
    let PId = parseInt($('#PanelId').val());
    //debugger;

    $('#SevicesId').val(Id)


    GetJSONRequest('/Master/ClinicServices/Master_ClinicServicesGetIdServices', 'GET', { Id, PId }, data => {

        if (data && data.length > 0) {
            



            $('#Rate').val(data[0].Rate);



        }

        else {
            ErrorAlert("No Records Found");
        }


    


        /// $('#Comp_id').attr('disabled', 'true')

    })


})































$('#age').change(function () {










    var PAge = $('#age').val();

    GetJSONRequest('/Master/PatientReg/Master_Daysbrith', 'GET', { PAge }, function (data) {



        if (data && data.length > 0) {













            $('#DateOfBirth').val(data[0].Bdate);



            //      $('#ProductId').val(data[0].ProductId);




        }
        else {



            ErrorAlert("No Data Found");


            //$('#Unit').val('');
            //$('#TPRate').val('');
            //$('#RetailRate').val('');

        }
    })







    //$('#Amount').val(parseInt(tAmt) - parseInt(Discout));
    //$('#OrderAmt').val(parseInt(tAmt));


})


$('#AddItemBtn').click(function () {




    //if ($('#SevicesId option:selected').val() == "0") {
    //    ErrorAlert("SevicesId Name is Required")


    //    debugger;
    //}




    //else if ($('#StoreName').val() == "0") {
    //    ErrorAlert("Store  is Required")
    //}

    if ($('#Dis').val() == '' || $('#Unit').val() == '' || $('#Refvalue').val() == '') {
        ErrorAlert("Miss Value")
    }



    else {
        let markup = `<tr>
                     
                     
                 
                     <td><input type="text" class="form-control  Dis"   value="${$('#Dis').val()}"></td>
                     <td><input type="text" class="form-control  Unit"   value="${$('#Unit').val()}"></td>
                     <td><input type="text" class="form-control  Refvalue" value="${$('#Refvalue').val()}"></td>
                    
                    
                  

                     
                      <td><a class="btn_delete text-danger-600"><i class="icon-trash"></i></a></td>
                      </tr>`
        $('#tbodytable').append(markup)

        //TotalSevAmt();
      
        $('#Dis').val('');
        $('#Unit').val('');
        $('#Refvalue').val('');
      
        //$('#SevicesId').val(0)
     
        //$('#SevicesId').select2()

        //  Total_DisAmt();
        //Total_Saletex();
        //Total_Amount();


    }
})
$('#tbodytable').delegate('.btn_delete', 'click', function () {

    debugger;



    ///lstif
    $(this).closest('tr').remove();
    TotalSevAmt();
})

function TotalSevAmt() {
    var sum = 0;


    let TotalAmount = 0;
    $('.Rate').each(function () {
        TotalAmount += parseFloat($(this).val()) || 0;
    })
    $('#ServicesAmt').val(TotalAmount);
    $('#CashAmt').val(TotalAmount);
    $('#DisAmt ').val(0);
    $('#BalanceAmt').val(0);




}




$('#DisAmt,#CashAmt,#BalanceAmt').change (function () {



    debugger;

    const ServicesAmt = $('#ServicesAmt').val() || 0;
    const DisAmt = $('#DisAmt').val() || 0;
    const CashAmt = $('#CashAmt').val() || 0;
  //  const BalanceAmt = $('#BalanceAmt').val() || 0;

    //var row = $(this).closest("tr");
    //var qty = parseFloat(row.find(".Qtyfield").val() || 0);
    //var price = parseFloat(row.find(".Pricefield").val() || 0);
    //var Discount = parseFloat(row.find(".Discountfield").val() || 0);

    var totalAmt = ServicesAmt - DisAmt - CashAmt ;
    //var Sumtotal = total - Discount;

    $('#BalanceAmt').val(parseFloat(totalAmt).toFixed(2));

    //row.find(".OrderAmtfield").val(isNaN(total) ? "" : total);
    //row.find(".Amountfield").val(isNaN(Sumtotal) ? "" : Sumtotal);


    //calculateDebitSumAmount();
    //calculateCrditSumAmount();




})







$('.SaveBtn').on('click', function () {
    //var PaymentM = $('#PaymentM').val();
    //var MrId = $('#MrId').val();
    //var MrNo = $('#MrNo').val();
    //var PatientName = $('#PatientName').val();
    //var age = $('#age').val();




   var check = false;




    //if (PaymentM == 0 || PaymentM == null) {


    //    ErrorAlert("Enter Payment Mode");
    //    check = true;

    //}

    //if (MrId ==  '' || MrNo == '' || PatientName == '', age == '') {


    //    ErrorAlert("Miss Value");
    //    check = true;

    //}

    debugger;
   
   




    if (!check) {















        var Labtest = [], LabtestDetail = [];



        Labtest = {
            TestId: $('#TestId').val(),
           
           
          
            TestCode: $('#TestCode').val(),
            SerId: parseInt($('#SerId option:selected').val()),
            DepId: parseInt($('#DepId option:selected').val()),
        



       
            





            //  StudentN: parseInt($('#StudentN option:selected').val()),


        }


        $('#tbodytable tr').each(function () {

            LabtestDetail.push({



                TestId: $('#TestId').val(),
                Discri: $(this).find('.Dis').val(),
                Unit: $(this).find('.Unit').val(),
                Refvalue: $(this).find('.Refvalue').val(),

              




            });



        });
      




        console.log(Labtest);
        console.log(LabtestDetail);



        debugger;

        var TestId = $('#TestId').val();

        if (TestId > 0) {

            debugger;
            GetJSONRequest('/Master/Labtest/UpdateLabtest', 'POST', { Labtest, LabtestDetail }, function (data) {
                SuccessAlert("Data Saved");
                $('.closeBtn').trigger('click');
            });
        }
        else {

            debugger;


            GetJSONRequest('/Master/Labtest/SaveLabtest', 'POST', { Labtest, LabtestDetail }, function (data) {
                SuccessAlert("Data Saved");
                $('.closeBtn').trigger('click');



            });
        }



    }





});
