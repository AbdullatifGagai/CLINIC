
$('#OpQty,#Rate').change(function () {

    debugger;

    const Rate = $('#Rate').val() || 0;
   // const Discout = $('#Discount').val() || 0;
  //  const OrderAmt = $('#OrderAmt').val() || 0;

    var tAmt = 0;



    tAmt = parseFloat($('#OpQty').val()) * parseFloat(Rate);
    $('#Amt').val(parseFloat(tAmt).toFixed(2));

})
