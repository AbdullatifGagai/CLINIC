$(document).ready(()=>{
    $('.dt-buttons').empty();
    $('#ModalBody').delegate('.pagecheck').unbind('change');
})

//page permission starts from here

$("#ModalBody").delegate('.pagecheck','change',function (e) {
    debugger;
    e.stopPropagation();
    const PageId = $(this).val();
    const MenuId = $(this).closest('tr').attr('data-rowid')
    const RoleId = $('#RoleId').val();
    const isChecked = $(this).is(':Checked');
    const isViewPage = $(this).attr('id');
    const model = { PageId, MenuId, RoleId, isViewPage }

    if (isChecked) {
        GetJSONRequest('/URM/Role/SavePagePermission', 'POST', { model }, data => {
            console.log(data);
            //if (data !='OK')
            //    ErrorAlert("Something went wrong while Processing the Request");
        })
    }
    else {
        GetJSONRequest('/URM/Role/DeletePagePermission', 'POST', { model }, data => {
            console.log(data);
            //if (data!='OK')
            //    ErrorAlert("Something went wrong while Processing the Request");
        })
    }

})