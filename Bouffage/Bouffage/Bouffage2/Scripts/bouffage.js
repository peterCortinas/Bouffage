

var bouffage = {
    page: { handlers: {} }
    , services: {}
    , layout: { handlers: {} }
    , utils: {}
    , admin: {
        module: {}
        , layout: { handlers: {} }
        , services: { users: {} }
        , controllers: { users: {} }
    }
};

bouffage.services = { organizations: {}, candidates: {}, content: {}, global: {}, photo: {}, users: {}, voters: {} };

// Admin specific start up
bouffage.admin.layout.handlers.startUp = function () {

    console.debug("bouffage.admin.layout.handlers.startUp");

    if (bouffage.page.startUp) {
        console.debug("bouffage.page.startUp");
        bouffage.page.startUp();
    }
}

bouffage.layout.handlers.startUp = function () {

    console.debug("bouffage.layout.handlers.startUp");

    //$('#showMoreEndorsements').on('click', electa.layout.fadeInEndorsements);

    //if (!electa.layout.removeFooterEndorsements) {
    //    electa.services.global.getRecentPost(electa.layout.renderPopularPost);
    //}
    //else {

    //    bouffage.layout.removeFooterEndorsements();

    //}
    //$('#modalContactButton').on('click', bouffage.layout.handlers.sendModalMessage);

    //$("#logoutuserbutton").on('click', electa.layout.handlers.logout);

    if (bouffage.page.startUp) {
        console.debug("bouffage.page.startUp");
        bouffage.page.startUp();
    }
}


//bouffage.layout.handlers.sendModalMessage = function () {

//    var messageValid = $('#modalcontactform').valid();

//    if (messageValid) {

//        var sendMessage = $('#modalcontactform').serialize();

//        bouffage.services.content.sendMessage(sendMessage, bouffage.layout.contactSuccess, bouffage.page.ajaxError);
//    }
//    console.log('message sent');
//};

//bouffage.layout.contactSuccess = function (data, status, xhr) {
//    $("#modalContactButton").attr('value', 'Message Sent');
//}




/*
Shows Server Side Error Messages in a Popup Modal Window

Args are "data" and "textStatus" in AjaxError callback

v1

*/

//bouffage.utils.errorMessageExposer = function (errorObj, text) {
//    if (errorObj["responseJSON"]["modelState"]) {

//        var modelmess = errorObj["responseJSON"]["modelState"]
//        var modelstatearray = $.map(modelmess, function (value, index) {
//            return [value];
//        });

//        $(".errormessages").html("");
//        $('h4.modal-title').text("Errors");
//        $("#modalmessage").text("Your request was not accepted and caused the following errors");
//        $('.errormessages').append("<li>" + text + "</li>");
//        $('.errormessages').append("<li>" + errorObj["responseJSON"]["message"] + "</li>");
//        $(modelstatearray).each(function () {
//            $('.errormessages').append("<li>" + this + "</li>");
//        })


//        $('#commentModal').modal('show');
//    }

//    else {
//        $("#modalmessage").text("Your request was not accepted");
//        $('#commentModal').modal('show');
//    }
//};

//bouffage.services.global.getRecentPost = function (onSuccess, onError) {




//    var url = "/api/candidates/messages/recent";
//    var settings = {
//        cache: false
//    , contentType: 'application/x-www-form-urlencoded; charset=UTF-8'
//    , dataType: "json"
//    , success: onSuccess
//    , error: onerror
//    , type: "GET"

//    };

//    $.ajax(url, settings);



//}


//electa.layout.logoutSuccess = function () {


//    window.location.replace("http://electa.dev")

//}

//electa.layout.handlers.logout = function () {

//    var url = "/api/users/logout";

//    var settings = {
//        cache: false
//            , contentType: "application/x-www-form-urlencoded; charset=UTF-8"
//            , dataType: "json"
//            , success: electa.layout.logoutSuccess
//            , error: electa.page.ajaxError
//            , type: "GET"
//    };

//    $.ajax(url, settings);
//}