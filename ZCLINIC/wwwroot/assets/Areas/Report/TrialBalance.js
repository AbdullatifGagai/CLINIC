

document.getElementById('FromDate').valueAsDate = new Date();
document.getElementById('ToDate').valueAsDate = new Date();





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







$('#Print').click(function (e) {


    //var format1 = 'Form Date: ' + moment($("#FromDate").val()).format('DD/MM/YYYY') +
    //    ' Up to Date: ' + moment($("#ToDate").val()).format('DD/MM/YYYY') +
    //    ' From Account Name: ' + $("#FAccountCode").val() + '-' + $('#FAccountName option:selected').text() +
    //    ' Upto Account Name: ' + $("#TAccountCode").val() + '-' + $('#TAccountName option:selected').text();

    debugger;

    var Date = 'Form Date: ' + moment($("#FromDate").val()).format('DD/MM/YYYY') +
        ' Up to Date: ' + moment($("#ToDate").val()).format('DD/MM/YYYY');
    
    



   


    //debugger;
    //console.log($('#ReportId').val())
  /*  if ($('#ReportId').val() == 1) {*/

    //const FAccountId = $('#FAccountId').val() || 0;
    //const TAccountId = $('#TAccountId').val() || 0;

    //debugger;

    //if (TAccountId > FAccountId) {

   

    var value = `/Report/Reportrdlc/AReport?rvalues.Name=8&rvalues.Value[0]=${$('#FromDate').val()}&rvalues.Value[1]=${$('#ToDate').val()}&rvalues.Value[2]=${$('#Master_Code').val()}&rvalues.Value[3]=''&rvalues.Value[4]=''&rvalues.Value[5]=''&rvalues.Value[6]=${Date}`
        $(this).attr('href', value)
        $(this).attr('target', "_blank")


    //}


    //else {
    //    ErrorAlert('Miss Value');
    //}





    /*  }*/
    //else if ($('#ReportId').val() == 2) {




    //    var value = `/Report/Reportrdlc/AReport?rvalues.Name=23&rvalues.Value[0]=${$('#LabId').val()}&rvalues.Value[1]=''&rvalues.Value[2]=${$('#ToDate').val()}&rvalues.Value[3]=''&rvalues.Value[4]=''&rvalues.Value[5]=''&rvalues.Value[6]=''`
    //    $(this).attr('href', value)
    //    $(this).attr('target', "_blank")
    //}



    //else {
    //    e.preventDefault();
    //    $(this).removeAttr('target')
    //    $(this).attr('href', "")
    //    ErrorAlert('No Select Report');
    //}
    //var value = `/Report/Reportrdlc/AccountLedgerReport?AccountId=${$('#AccountId').val()}&Fromdate=${$('#FromDate').val()}&ToDate=${$('#ToDate').val()}`

})