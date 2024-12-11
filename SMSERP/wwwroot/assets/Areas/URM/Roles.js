////$(document).ready(()=>{
////    $('.dt-buttons').empty();
////    $('#ModalBody').delegate('.pagecheck').unbind('change');
////})

//page permission starts from here

//$("#ModalBody").delegate('.pagecheck','change',function (e) {
//    debugger;
//    e.stopPropagation();
//    const PageId = $(this).val();
//    const MenuId = $(this).closest('tr').attr('data-rowid')
//    const RoleId = $('#RoleId').val();
//    const isChecked = $(this).is(':Checked');
//    const isViewPage = $(this).attr('id');
//    const model = { PageId, MenuId, RoleId, isViewPage }

//    if (isChecked) {
//        GetJSONRequest('/URM/Role/SavePagePermission', 'POST', { model }, data => {
//            console.log(data);
//            //if (data !='OK')
//            //    ErrorAlert("Something went wrong while Processing the Request");
//        })
//    }
//    else {
//        GetJSONRequest('/URM/Role/DeletePagePermission', 'POST', { model }, data => {
//            console.log(data);
//            //if (data!='OK')
//            //    ErrorAlert("Something went wrong while Processing the Request");
//        })
//    }

//})


//if ($('#Roles_ID').val() > 0) {

//    debugger;
//}
//else {
//    GetJSONRequest('/Transaction/Transaction_UnitAllow/GetUnitListM', 'GET', null, function (data) {

//        if (data && data.length > 0) {

//            debugger;
//            for (var item of data) {

//                const markup = `
//                            <tr>
                              
                              
//                                <td>
//                                         <input type="hidden" class="form-control UnitIdfield" readonly value="${item.Unit_Id}" />
//                                         <input type="text" class="form-control UnitNamefield"  readonly value="${item.UnitName}" />
//                                </td>
                              
                                
                                

                                 
//                                     <td><input type="text" class="form-control  Amountfield" readonly  value="${item.Amount}"></td>
                              
//                                <td><a id=""><i class="icon-trash removeitem text-danger-600"></i></a>
//                            </tr>`;
//                $('tbody.MonthlyProDetails').append(markup);
            
//            }



//        }
//        else {

//           // ErrorAlert("No Data Found");
//        }

//    })
//}
$('.SaveBtn').click(() => {




    var counter = 0;

    //const DebitAmt = $('#TDebitAmt').val() || 0;
    //const CreditAmt = $('#TCreditAmt').val() || 0;

    var GridBodyRows = $('tbody.MenuLists tr');
    let check = false;
    GridBodyRows.each(function () {
        //  const keptqty = $(this).children().eq(0).find('.KeptQtyfield').val() || 0;




      

        //if ($(this).children().eq(0).find('.SUB_CODE').val() == 0) {
        //    check = true;
        //    return false;
        //}




    })


  




    if (!check) {

        //  debugger;
        GridBodyRows.each(function () {
            debugger;
            
            //  $(this).children().eq(1).find('.UnitId').attr('name', 'MonthlyProDetails[' + counter + '].UnitId');
            $(this).children().eq(0).find('.MuneIdfield').attr('name', 'MenuList[' + counter + '].MuneId');
            $(this).children().eq(0).find('.MenuNamefield').attr('name', 'MenuList[' + counter + '].MenuName');
            var value = $(this).children().eq(1).find('.R_Privileges').prop('checked') ? 1 : 0;
            $(this).children().eq(1).find('.R_Privileges').attr('value', value);
;            $(this).children().eq(1).find('.R_Privileges').attr('name', 'MenuList[' + counter + '].R_Privileges');

            var value = $(this).children().eq(2).find('.R_save').prop('checked') ? 1 : 0;
            $(this).children().eq(2).find('.R_save').attr('value', value);
            ; $(this).children().eq(2).find('.R_save').attr('name', 'MenuList[' + counter + '].R_save');


            var value = $(this).children().eq(3).find('.R_Update').prop('checked') ? 1 : 0;
            $(this).children().eq(3).find('.R_Update').attr('value', value);
            ; $(this).children().eq(3).find('.R_Update').attr('name', 'MenuList[' + counter + '].R_Update');


            var value = $(this).children().eq(4).find('.R_delete').prop('checked') ? 1 : 0;
            $(this).children().eq(4).find('.R_delete').attr('value', value);
            ; $(this).children().eq(4).find('.R_delete').attr('name', 'MenuList[' + counter + '].R_delete');



            var value = $(this).children().eq(5).find('.R_Print').prop('checked') ? 1 : 0;
            $(this).children().eq(5).find('.R_Print').attr('value', value);
            ; $(this).children().eq(5).find('.R_Print').attr('name', 'MenuList[' + counter + '].R_Print');







            //$(this).children().eq(2).find('.R_savefield').attr('name', 'MenuList[' + counter + '].R_savefield');
            //$(this).children().eq(3).find('.R_Update').attr('name', 'MenuList[' + counter + '].R_Update');
            //$(this).children().eq(4).find('.R_delete').attr('name', 'MenuList[' + counter + '].R_delete');
            //$(this).children().eq(5).find('.R_Print').attr('name', 'MenuList[' + counter + '].R_Print');



            //  $(this).children().eq(1).find('.Amountfield').attr('name', 'MenuList[' + counter + '].Amt');



            counter++;

            debugger;

        })

       

        $('.SaveBtn').attr('data-submit', true);


    }
    else {
        ErrorAlert('Please Select Account Name Or Debit and Credit Not Equal')
    }
})




//var rows = table.rows({ 'search': 'applied' }).nodes();

//$('input[type="checkbox"]', rows).each(function () {
//    if ($(this).prop('checked')) {
//        var tablerow = $(this).closest('tr')

//        var message = $('#messagebox').val();
//        message = message.replaceAll("{{CustomerName}}", $(tablerow).children('td').eq(0).text() + " " + $(tablerow).children('td').eq(1).text())
//        list.push({ SMSTo: $(tablerow).children('td').eq(3).text(), SMSMessage: message })
//    }
//})

$('#SaveAll').on('change', function () {
    // From the other examples
    if (this.checked) {
        ErrorAlert('OK')
       
    }

    else {
        ErrorAlert('Not OK')
    }


});