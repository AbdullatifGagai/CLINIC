$('#CellNo').formatter({
    pattern: '{{9999}}-{{9999999}}'
});

$('#PhoneNo').formatter({
    pattern: '{{9999}}-{{9999999}}'
});



if ($('#GRId').val() > 0) {


}
else {

    document.getElementById('DOBrith').valueAsDate = new Date();
    document.getElementById('AdDate').valueAsDate = new Date();
    document.getElementById('DateLeaving').valueAsDate = new Date();


    //$('#UserName').val($('#personName').text());
    //$('#UserId').val($('#personId').val())


}


$('.file-input').change(function (e) {

    debugger;
    if (this.files.length == 0) {
        $('#PhotoPath').val("");

        return;
    }



    var filename = e.target.value;

    var allowed_extensions = new Array("jpg", "png", "jpeg");
    var file_extension = filename.split('.').pop().toLowerCase();
    var result = false;
    for (var i = 0; i <= allowed_extensions.length; i++) {
        if (allowed_extensions[i] == file_extension) {
            result = true;
            break;
        } else {
            result = false
        }
    }
    if (result === false) {
        ErrorAlert("Upload Only Image")
    } else {


        var formData = new FormData();
        formData.append("file", e.target.files[0]);
        $.ajax({
            url: "/Master/Student/UploadImage",
            type: 'POST',
            cache: false,
            contentType: false,
            processData: false,
            data: formData,
            success: function (response) {
                $('#PhotoPath').val(response);


            }
        });



    }



})


var image = $('#PhotoPath').val() == "" || $('#PhotoPath').val() == null ? "" : "/StudentPhoto/"  + $('#PhotoPath').val()






//var image = $('#PhotoPath').val() == "" || $('#PhotoPath').val() == null ? "" : "D:/Photo/cc4b1277-74e9-4fd5-b2f7-bacbc1613716_5d079167-28a9-4db0-b579-94ffaabf7889_tree-736885__480.jpg"

debugger;
$('.file-input').fileinput({
    browseLabel: 'Select',
    browseIcon: '<i class="icon-image2 position-left"></i>',
    removeIcon: '<i class="icon-cross3"></i>',
    initialPreview: image,
    initialPreviewAsData: true,

});
$('body').find('.fileinput-remove,.fileinput-remove-button').click(function () {
    $('#PhotoPath').val("");
})