////const { getJSON } = require("jquery");


$(document).ready( function () {
    $(document).on('click', '[data-submit="true"]', function (e) {
        e.preventDefault();
      //  var a = $(this).closest('form[data-url]').val();

        console.log($("form[data-url]"))
        //if ($("form[data-url]").valid()) {
        //    LoadPartial($('form[data-url]'), 'POST', $('form[data-url]').serialize());
        //}llll
       
        if ($(this).closest('form[data-url]').valid()) {

            var spin = "icon-spinner2 spinner icon-2x";
            $.LoadingOverlay("show",
                {
                    image: "",
                    fontawesome: spin,
                    backgroundColor: 'rgba(0,0,0,0.6)',
                });
            LoadPartial($(this).closest('form[data-url]'), 'POST', $(this).closest('form[data-url]').serialize());
            
        }
    });    
    $(document).delegate('[data-modalhorizontal="true"]', 'click', function () { ViewModalHorizontal($(this).data('heading'), this, null, { Id: $(this).data('IDPropperty') }, $(this).data('smodal')); });
    $(document).delegate('a[data-url][data-modalhorizontal !="true"]', 'click', function (e) { LoadPartial(e.currentTarget); });    
    $(document).delegate('select[data-jsonurl]', 'change', function () { var Reponse = GetJSONRequest($(this).data('jsonurl'), 'GET', { DataId: $('option:selected', this).val() }, function (data) { BindCombo($('#' + $(this).data('nextddown')), [$('#' + $(this).data('nextddown')).data('vmember'), $('#' + $(this).data('nextddown')).data('dmember')], data); }); });
});

function LoadPartial(Component, type, data, Container) {
    var _URL = $(Component).data('url');
    var scripts = $(Component).data('script') || '#';
    var returnurl = $(Component).data('rurl') || '';
    var display = $(Component).data('display');
    var IsModal = $(Component).data('modalhorizontal');
    var CallBack = $(Component).data('callback') || '';

    $.ajax({
        url: _URL,
       // datatype: 'H  TML',
        type: type || 'GET',
        data: data || {},
        cache: false,
        
        complete: function () {
            if (type == "POST") {
                $.LoadingOverlay("hide");
            }
        },
        success: function (Component, type, _URL, data) {
            if (type == 'POST') {
                var className = data == "OK" ? "panel-success" : "panel-danger";
                var newText = data == "OK" ? "Success" : "Failed";
                //var oldText = $('.panel-title').text();
                //$('.modal-header').addClass(className);
                //$('.modal-title').text(newText);
                var oldModalText = $(Component).parentsUntil('.modal-dialog').find('.modal-title').text();
                $(Component).parentsUntil('.modal-dialog').find('.modal-header').addClass(className);
                $(Component).parentsUntil('.modal-dialog').find('.modal-title').text(newText);

                
                setTimeout(function (className, oldText, data, _URL) {
                   // $('.modal-header').removeClass(className);
                   //$('.modal-title').text(oldText);
                    $(Component).parentsUntil('.modal-dialog').find('.modal-header').addClass(className);
                    $(Component).parentsUntil('.modal-dialog').find('.modal-title').text(oldText);

                    if (data == "OK") {
                        
                        SuccessAlert("Data Saved Successfully")
                        $('[data-url="' + _URL.split("?")[0] + '"]').click();
                        if (!$('#SModal').is(':visible')) {
                            $('#modal_form_horizontal').modal('toggle');
                        }
                        else {
                            $('#SModal').modal('toggle');

                        }
                    }
                    else {
                            if ($('#modal_form_horizontal').is(':visible')) {
                            $('.modal-header .modal-title').text(data);
                        }                        
                    }
                    if (returnurl) { var linker = '<a data-url="' + returnurl + '" data-script="' + scripts + '" data-display="' + display + '"></a>'; LoadPartial(linker); }
                    if (CallBack) { this[CallBack](data); }

                }.bind(this, className, oldModalText, data, _URL), 500);
                return;
            }
            if (CallBack) { $(data).find('form').removeAttr('data-rurl'); $(data).find('form').attr('data-CallBack', CallBack); }
            if (Container) {
                
                $(Container).html(data);
                ApplyTemplateInitializers(data);
            }
            else {
                if (typeof data == "object") {
                    
                    console.log(data);
                    CreateUIDefaultIndex(data, $('#body'));
                }
                else {
                  
                    
                    $('#body').html(data);    
                    ApplyTemplateInitializers(data);
                }
            }
            SetHeading(Component);
            RegisterScripts(scripts, data);
            //OnPageLoad();
        }.bind(this, Component, type, _URL),
        error: function (xhr, textStatus, errorThrown) {
            alert(errorThrown);
        }
    });

}
var allScripts = {};
function RegisterScripts(scripts, data) {
    
    if (scripts == "#") return;
    if (allScripts[scripts]) {
        eval(allScripts[scripts]);
        ApplyTemplateInitializers(data);
    } else {
        $.getScript(scripts)
            .done(function (scriptURL, script, textStatus) {
                allScripts[scriptURL] = script;
                ApplyTemplateInitializers(data);
                //init();
            }.bind(this, scripts))
            .fail(function (jqxhr, settings, exception) {
                alert('Failed' + exception);
            });
    }
}

function SetHeading(Component) {
    $('#breadCrumbHeading').html($(Component).data('display'));
    var $img = $('#mainHeading').find('*');
    $('#mainHeading').html($(Component).data('display'));
    $('#mainHeading').prepend($img);
}

var defModalSize = 'modal-lg';
//-- For Modal
function ViewModalHorizontal(heading, component, footer, data, smodal) {
    
    var ModalId = (smodal == true) ? '#SModal' : '#modal_form_horizontal';
    var ModalBody = (smodal == true) ? '#SModalBody' : '#ModalBody';
    $(ModalBody).empty()
    LoadPartial(component, null, data, $(ModalBody));
    var ModalSize = $(component).data('modalsize');
    $(ModalId).modal().find('.modal-title').text(heading); 
    $(ModalId).children().eq(0).removeClass();
    $(ModalId).children().eq(0).addClass('modal-dialog');
    //Bhund needs to be resolved
    if (ModalSize != "undefined") {
        $(ModalId).children().eq(0).addClass(ModalSize);
    }
}



// For Adding Dynamic Buttons in Modal Footer
function AddFooterButtons(id, cssclass, formpostURL, value) {
    $('.modal-footer').append('<input id="' + id + '" type="button" class="btn ' + cssclass + '" data-formpost="' + formpostURL + '" value="' + value + '" />')
}
//$('#ModalPopup').modal().find('.modal-footer').append('<input id="send" type="button" class="btn btn-success" data-formpost="/SKMS/Category/Index" value="Submit" />');
//Modal Footer Cleansing
function AfterModalClose() {
    $('.modal-footer').html('<button type="button" class="btn btn-default" data-dismiss="modal">Close</button>');
}
// For any Modal with or without data
function ShowModal(URL, script, heading, obj) {
    $.ajax({
        url: URL,
        datatype: 'HTML',
        data: obj,
        success: function (data) { RegisterScripts(script); ViewModal(data, heading); },
        error: function (xhr, textStatus, errorThrown) { alert(errorThrown); }
    });
}


function GetJSONRequest(URL, Type, obj, CallBack) {
    var Message;
    var spin = "icon-spinner2 spinner icon-2x";
    $.ajax({
        url: URL,
        datatype: 'JSON',
        type: Type,
        data: obj,
        //success: function (data) { if (CallBack) { CallBack(data); } else {  return data; }}
        //For loader
        beforeSend: function () {
            $.LoadingOverlay("show",
                {
                    image: "",
                    fontawesome: spin,
                    backgroundColor: 'rgba(0,0,0,0.6)',
                });
        },
        complete: function () { $.LoadingOverlay("hide"); },
        success: function (data) { if (CallBack) { CallBack(data); } else { return data; } },
        error: function () { } //GetJSONRequest(URL, Type, obj, CallBack); }
    });
}
//$('[data-dismiss=modal]').click(function () {
//    alert("Hello")
//})