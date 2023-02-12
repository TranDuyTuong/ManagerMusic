"use strict";
// Creating a connection to SignalR Hub
var connection = new signalR.HubConnectionBuilder().withUrl("/signalr-hub").build();

// Starting the connection with server
connection.start().then(function () { }).catch(function (err) {
    return console.error(err.toString());
});

//load ding data
$(document).ready(function () {
    LoadingData();
    SortId = 1;
    DateFulter = null;
    Page_Index = 1;
})
var head = $("#head").val();
var next = $("#next").val();
var last = $("#last").val();
var Before = $("#Before").val();
var SentMessage_Error = $("#SentMessage_Error").val();
var Notification_Error = $("#Notification_Error").val();
var enter_content = $("#enter_content").val();
var Cannotsend_10files = $("#Cannotsend_10files").val();
var selectfilesend = $("#selectfilesend").val();
var Nomessages_employee = $("#Nomessages_employee").val();
var select_date = $("#select_date").val();
var Noimages_Id = $("#Noimages_Id").val();
var see_more = $("#see_more").val();
var Dowload = $("#Dowload").val();
var select_date = $("#select_date").val();
var Sender = $("#Sender").val();

var Page_Index = 1;
var Page_Size = 20;

function LoadingData() {
    var IdUser = document.getElementById("IdUser").value;
    $("#modalShowFilter").hide();
    $("#totalUser").empty();
    $.ajax({
        url: "/User/LoadingMessage",
        type: "get",
        data: {
            IdUser: IdUser,
            FulterDate: DateFulter,
            Size: Page_Size,
            Index: Page_Index
        },
        success: function (result) {
            if (result.status == false) {
                toastr.error(SentMessage_Error, Notification_Error)
            } else {
                LoadMesage(result)
                $("#totalUser").append(result.totalUser);
            }

        }
    })
}

// Sending the message from Client
document.getElementById("btnSend").addEventListener("click", function (event) {
    var IdUser = document.getElementById("IdUser").value;
    var FullName = document.getElementById("FullName").value;
    var message = document.getElementById("message").value;
    if (message.length == 0) {
        toastr.error(enter_content, Notification_Error)
    } else {
        connection.invoke("SendMessage", IdUser, FullName, message).catch(function (err) {
            return console.error(err.toString());
        });
        $("#message").val('');
        document.getElementById("message").focus();
        event.preventDefault();
    }
});

//-----------------------------------------------
var LikeHtml = '<i class="fas fa-thumbs-up"></i>';
//cretae chat like message
document.getElementById("MessageLike").addEventListener("click", function (event) {
    var IdUser = document.getElementById("IdUser").value;
    var FullName = document.getElementById("FullName").value;
    connection.invoke("SendLikeMessage", IdUser, FullName, LikeHtml).catch(function (err) {
        return console.error(err.toString());
    });
    document.getElementById("message").focus();
    event.preventDefault();
});

//-----------------------------------------------
var FunnyHtml = '<i class="far fa-grin-squint-tears"></i>';
//create chat funny message
document.getElementById("sentIconFun").addEventListener("click", function (event) {
    var IdUser = document.getElementById("IdUser").value;
    var FullName = document.getElementById("FullName").value;
    connection.invoke("SendFunnyMessage", IdUser, FullName, FunnyHtml).catch(function (err) {
        return console.error(err.toString());
    });
    document.getElementById("message").focus();
    event.preventDefault();
});

//----------------------------------------------
var SadHtml = '<i class="far fa-frown"></i>'
//create chat sad message
document.getElementById("sentIconSad").addEventListener("click", function (event) {
    var IdUser = document.getElementById("IdUser").value;
    var FullName = document.getElementById("FullName").value;
    connection.invoke("SendSadMessage", IdUser, FullName, SadHtml).catch(function (err) {
        return console.error(err.toString());
    });
    document.getElementById("message").focus();
    event.preventDefault();
});

//----------------------------------------------
var LoveHtml = '<i class="fas fa-kiss-wink-heart"></i>'
//create chat love message
document.getElementById("sentIconLove").addEventListener("click", function (event) {
    var IdUser = document.getElementById("IdUser").value;
    var FullName = document.getElementById("FullName").value;
    connection.invoke("SendLoveMessage", IdUser, FullName, LoveHtml).catch(function (err) {
        return console.error(err.toString());
    });
    document.getElementById("message").focus();
    event.preventDefault();
});

//-----------------------------------------------
//sent mupltie images
$("#Images").change(function () {
    var dataImage = [];
    var dataProcessBarID = [];
    var processBar = "";
    var totalfiles = document.getElementById('Images').files.length;
    if (totalfiles > 0) {
        var formData = new FormData();
        var IdUser = document.getElementById("IdUser").value;
        var FullName = document.getElementById("FullName").value;
        var files = $("#Images").prop("files")
        var InfoUser = {
            IdUser: IdUser,
            NameUser: FullName
        };

        for (var i = 0; i < files.length; i++) {
            formData.append("L_File", files[i]);
        }
        formData.append("InfoUser", JSON.stringify(InfoUser));

        $.ajax({
            url: "/User/GetImageChat",
            type: "post",
            data: formData,
            contentType: false,
            processData: false,
            success: function (result) {
                switch (result) {
                    case 1:
                        for (var i = 0; i < totalfiles; i++) {
                            var nameFile = document.getElementById('Images').files[i];
                            dataImage[i] = nameFile;
                            var processID = "processID_" + i;
                            processBar += "<label class=\"label label-primary\">File:" + nameFile.name + "</label><br/><div class=\"progress\">" +
                                "<div id='" + processID + "' class=\"progress-bar progress-bar-success\" role=\"progressbar\" aria-valuenow=\"0\" aria-valuemin=\"0\" aria-valuemax=\"100\" style=\"width:100%\">" +
                                "100% Complete (success)" +
                                "</div>" +
                                "</div>";
                            dataProcessBarID[i] = processID;
                        }
                        $("#filelist").html(processBar);
                        break;
                    case 0:
                        toastr.error(Cannotsend_10files, Notification_Error);
                        break;
                }
                return;
            }
        })

    }
})
//create mesage images
document.getElementById("btnSubmitImage").addEventListener("click", function (event) {
    $("#modal_LoadingCreateMusic").show();
    var total_files = document.getElementById('Images').files.length;
    if (total_files == 0) {
        toastr.error(selectfilesend, Notification_Error);
        $("#modal_LoadingCreateMusic").hide();
        return;
    } else {
        var IdUser = document.getElementById("IdUser").value;
        var FullName = document.getElementById("FullName").value;
        var Message = "Images";
        connection.invoke("SendImages", IdUser, FullName, Message).catch(function (err) {
            return console.error(err.toString());
        });
        $("#Images").val('');
        $("#modalIamge").hide();
        $("#modal_LoadingCreateMusic").hide();
        document.getElementById("message").focus();
        event.preventDefault();
    }
});

//------------------------------------------------
// Subscribing to the messages broadcasted by Hub every time when a new message is pushed to it
connection.on("BroadcastMessage", function (result) {
    LoadMesage(result)
});

//--------------------------------------
var PageIndex = 1;
var PageSize = 10;
var SortId = 1;
var Idchat = 0;
//show info user
function eventShowInfo(id) {
    $("#TxtNameStaff").empty();
    $("#TxtRoleNameStaff").empty();
    $("#TxtToalComment").empty();
    $("#AvataImg").empty();
    $("#body_Message").empty();
    $("#TotalItem").empty();
    $("#ItemInPage").empty();
    $("#TotalChat").empty();
    Idchat = id;
    $.ajax({
        url: "/User/JsonInfoStaffChat",
        type: "get",
        data: {
            IdChat: id,
            PageIndex: PageIndex,
            PageSize: PageSize,
            Sort: SortId
        },
        success: function (result) {
            if (result.totalChat == 0) {
                toastr.error(Nomessages_employee, Notification_Error);
            } else {
                var Avata_User = '<img src="data: image/jpg;base64, ' + result.avata + '" class="img-thumbnail" style="max-width: 35%;"/>';
                $("#TxtNameStaff").val(result.nameUser);
                $("#TxtRoleNameStaff").val(result.nameRole);
                $("#TxtToalComment").val(result.totalChat);
                $("#AvataImg").append(Avata_User);
                //set list comment
                var count = 0;
                $.each(result.l_Chat, function (key, item) {
                    var html = "";
                    count++;
                    html += '<tr id="' + item.id + '">';
                    html += '<th scope="row">' + item.id + '</th>';
                    html += '<td>' + item.message + '</td>';
                    html += '<td>' + item.dateCreate_C + ' - ' + item.timeCreate + '</td>';
                    html += '<td>' + result.nameRole + '</td>';
                    html += '</tr>';
                    $("#body_Message").append(html);
                })
                $("#TotalItem").append(PageIndex);
                $("#ItemInPage").append(count);
                $("#TotalChat").append(result.totalChat)
                //paing
                paging(result.totalChat, function () {
                    eventShowInfo(id)
                })
            }
            $("#modalShowInfoUser").show();
            return;
        }
    })
}

//----------------------------------------------
//paing
function paging(totalRoll, callback) {
    var totalPage = Math.ceil(totalRoll / PageSize);
    $('#pagination').twbsPagination({
        totalPages: (totalPage == 0) ? 1 : totalPage,
        first: head,
        next: next,
        last: last,
        prev: Before,
        visiblePages: 10,
        onPageClick: function (event, page) {
            PageIndex = page;
            setTimeout(callback, 200);
        }
    });
}

$("#btnClose").click(function () {
    $("#modalShowInfoUser").hide();
});

$("#btn_ListComment").click(function () {
    $("#modalShowListComment").show();
    $("#modalShowInfoUser").hide();
})

$("#btnCloseList").click(function () {
    $("#modalShowListComment").hide();
    $("#modalShowInfoUser").show();
})

//----------------------------------------------
$("#SortId").click(function () {
    if (SortId == 1) {
        SortId = -1;
    } else {
        SortId = 1;
    }
    if (Idchat != 0) {
        eventShowInfo(Idchat)
    }
})

//-----------------------------
var DateFulter = null;
$("#FiterDate").click(function () {
    $("#modalShowFilter").show();
});
$("#btnCloseFilter").click(function () {
    $("#modalShowFilter").hide();
});
$("#SentFulter").click(function () {
    var getdata = $("#rangeDate").val();
    if (getdata.length == 0) {
        toastr.error(select_date, Notification_Error);
    } else {
        DateFulter = getdata;
        LoadingData();
    }
    return;
})
//datetime picker
$("#rangeDate").flatpickr({
    mode: 'range',
    dateFormat: "Y-m-d"
});

//-------------------------------------------------
//reset data
$("#resetData").click(function () {
    window.location.reload();
})

//show modal send image
$("#btnSendImage").click(function () {
    $("#modalIamge").show();
});

$("#btnCloseImage").click(function () {
    $("#filelist").empty();
    $("#Images").val('');
    $.ajax({
        url: "/User/CloseSentImageFile",
        type: "get",
        success: function (result) {
            $("#modalIamge").hide();
            window.location.reload();
        }
    })
    return;
})

//----------------------------------------
//show images message
function eventShowImg(id_Images) {
    $("#BodyImages").empty();
    $.ajax({
        url: "/User/GetImageBy_id",
        type: "get",
        data: {
            Id_File: id_Images
        },
        success: function (result) {
            if (result.id == 0) {
                toastr.error(Noimages_Id, Notification_Error);
            } else {
                LoadImageViewDetail(result.typeImage, result.contentImage_Doc);
                $("#modalShowListImageData").show();
            }
            return;
        }
    })
}

$("#btnCloseImages").click(function () {
    $("#modalShowListImageData").hide();
});

//---------------------------------------------
var L_ChatPust;
//funtion load message
function LoadMesage(result) {
    if (result.status == false) {
        toastr.error(SentMessage_Error, Notification_Error);
    } else {
        $("#CssUl").empty();
        if (Page_Index == 1) {
            var html = '<button class="btn btn-secondary" onclick="Id_LoadAddMessage()" style="border: none; background: none; text-align: center; margin-top: 20px; color: #000000a1; font-weight: 600; font-size: 15px; font-family: initial;">' + see_more + '</button>';
            $("#CssUl").append(html).scrollTop($("#CssUl").prop('scrollHeight'));

            L_ChatPust = result.l_Chat;
        } else {
            var html = '<button class="btn btn-secondary" onclick="Id_LoadAddMessage()" style="border: none; background: none; text-align: center; margin-top: 20px; color: #000000a1; font-weight: 600; font-size: 15px; font-family: initial;">' + see_more + '</button>';
            $("#CssUl").append(html).scrollTop($("#CssUl").prop('scrollHeight'));

            $.each(result.l_Chat, function (key, item) {
                L_ChatPust.unshift(item);
            })
        }
        if (result.fuilter_Date == "FuilterDate") {
            $("#CssUl").empty()
        }
        $.each(L_ChatPust, function (key, item) {
            var control = "";
            if (item.idUser == result.idUser) {
                switch (item.message) {
                    case LoveHtml:
                        control = '<li style="width:50%; margin: auto; margin-left: 445px">' +
                            '<a onclick="eventShowInfo(' + item.id + ')">' +
                            '<div class="msj-rta macro">' +
                            '<div class="text text-r">' +
                            '<p style="text-align: left; color: #FF00FF; font-size: 45px; margin-left: 5px;">' + item.message + '</p>' +
                            '<p style="text-align: left; color: black;"><small>' + item.dateCreate_C + ' - ' + item.timeCreate + '</small></p>' +
                            '</div>' +
                            '<div class="avatar" style="padding:0px 0px 0px 10px">' +
                            '<img class="img-circle" style="width: 40px; border-radius: 50%; margin-left: 0px;" src="data: image/jpg;base64, ' + item.imageAvata + '"/></div>' +
                            '</a>' +
                            '</li>';
                        $("#CssUl").append(control).scrollTop($("#CssUl").prop('scrollHeight'));
                        break;
                    case SadHtml:
                        control = '<li style="width:50%; margin: auto; margin-left: 445px">' +
                            '<a onclick="eventShowInfo(' + item.id + ')">' +
                            '<div class="msj-rta macro">' +
                            '<div class="text text-r">' +
                            '<p style="text-align: left; color: #FFFF00; font-size: 45px; margin-left: 5px;">' + item.message + '</p>' +
                            '<p style="text-align: left; color: black;"><small>' + item.dateCreate_C + ' - ' + item.timeCreate + '</small></p>' +
                            '</div>' +
                            '<div class="avatar" style="padding:0px 0px 0px 10px">' +
                            '<img class="img-circle" style="width: 40px; border-radius: 50%; margin-left: 0px;" src="data: image/jpg;base64, ' + item.imageAvata + '"/></div>' +
                            '</a>' +
                            '</li>';
                        $("#CssUl").append(control).scrollTop($("#CssUl").prop('scrollHeight'));
                        break;
                    case FunnyHtml:
                        control = '<li style="width:50%; margin: auto; margin-left: 445px">' +
                            '<a onclick="eventShowInfo(' + item.id + ')">' +
                            '<div class="msj-rta macro">' +
                            '<div class="text text-r">' +
                            '<p style="text-align: left; color: #FF3366; font-size: 45px; margin-left: 5px;">' + item.message + '</p>' +
                            '<p style="text-align: left; color: black;"><small>' + item.dateCreate_C + ' - ' + item.timeCreate + '</small></p>' +
                            '</div>' +
                            '<div class="avatar" style="padding:0px 0px 0px 10px">' +
                            '<img class="img-circle" style="width: 40px; border-radius: 50%; margin-left: 0px;" src="data: image/jpg;base64, ' + item.imageAvata + '"/></div>' +
                            '</a>' +
                            '</li>';
                        $("#CssUl").append(control).scrollTop($("#CssUl").prop('scrollHeight'));
                        break;
                    case LikeHtml:
                        control = '<li style="width:50%; margin: auto; margin-left: 445px">' +
                            '<a onclick="eventShowInfo(' + item.id + ')">' +
                            '<div class="msj-rta macro">' +
                            '<div class="text text-r">' +
                            '<p style="text-align: left; color: #0064ffad; font-size: 45px; margin-left: 5px;">' + item.message + '</p>' +
                            '<p style="text-align: left; color: black;"><small>' + item.dateCreate_C + ' - ' + item.timeCreate + '</small></p>' +
                            '</div>' +
                            '<div class="avatar" style="padding:0px 0px 0px 10px">' +
                            '<img class="img-circle" style="width: 40px; border-radius: 50%; margin-left: 0px;" src="data: image/jpg;base64, ' + item.imageAvata + '"/></div>' +
                            '</a>' +
                            '</li>';
                        $("#CssUl").append(control).scrollTop($("#CssUl").prop('scrollHeight'));
                        break;
                    case "Images":
                        $.each(item.l_Images, function (key, items) {
                            switch (items.typeImage) {
                                case "JPG":
                                    control = '<li style="width:50%; margin: auto; margin-left: 445px">' +
                                        '<a onclick="eventShowInfo(' + item.id + ')">' +
                                        '<div class="msj-rta macro">' +
                                        '<div class="text text-r">' +
                                        '<img style="width: 130px;" src="data: image/JPG;base64, ' + items.contentImage_Doc + '"/>' +
                                        '<p style="text-align: left; color: black;"><small>' + item.dateCreate_C + ' - ' + item.timeCreate + '</small></p>' +
                                        '</div>' +
                                        '<div class="avatar" style="padding:0px 0px 0px 10px">' +
                                        '<img class="img-circle" style="width: 40px; border-radius: 50%; margin-left: 0px;" src="data: image/jpg;base64, ' + item.imageAvata + '"/></div>' +
                                        '</a>' +
                                        '</li>' + '<button data-bs-toggle="tooltip" data-bs-placement="right" title="Xem hình" style="border:none; background: none; text-align:right; color: #0087ffc7;" onclick="eventShowImg(' + items.id + ')"><i class="fas fa-eye"></i></button>';
                                    $("#CssUl").append(control).scrollTop($("#CssUl").prop('scrollHeight'));
                                    break;
                                case "jpg":
                                    control = '<li style="width:50%; margin: auto; margin-left: 445px">' +
                                        '<a onclick="eventShowInfo(' + item.id + ')">' +
                                        '<div class="msj-rta macro">' +
                                        '<div class="text text-r">' +
                                        '<img style="width: 130px;" src="data: image/jpg;base64, ' + items.contentImage_Doc + '"/>' +
                                        '<p style="text-align: left; color: black;"><small>' + item.dateCreate_C + ' - ' + item.timeCreate + '</small></p>' +
                                        '</div>' +
                                        '<div class="avatar" style="padding:0px 0px 0px 10px">' +
                                        '<img class="img-circle" style="width: 40px; border-radius: 50%; margin-left: 0px;" src="data: image/jpg;base64, ' + item.imageAvata + '"/></div>' +
                                        '</a>' +
                                        '</li>' + '<button data-bs-toggle="tooltip" data-bs-placement="right" title="Xem hình" style="border:none; background: none; text-align:right; color: #0087ffc7;" onclick="eventShowImg(' + items.id + ')"><i class="fas fa-eye"></i></button>';
                                    $("#CssUl").append(control).scrollTop($("#CssUl").prop('scrollHeight'));
                                    break;
                                case "JPEG":
                                    control = '<li style="width:50%; margin: auto; margin-left: 445px">' +
                                        '<a onclick="eventShowInfo(' + item.id + ')">' +
                                        '<div class="msj-rta macro">' +
                                        '<div class="text text-r">' +
                                        '<img style="width: 130px;" src="data: image/JPEG;base64, ' + items.contentImage_Doc + '"/>' +
                                        '<p style="text-align: left; color: black;"><small>' + item.dateCreate_C + ' - ' + item.timeCreate + '</small></p>' +
                                        '</div>' +
                                        '<div class="avatar" style="padding:0px 0px 0px 10px">' +
                                        '<img class="img-circle" style="width: 40px; border-radius: 50%; margin-left: 0px;" src="data: image/jpg;base64, ' + item.imageAvata + '"/></div>' +
                                        '</a>' +
                                        '</li>' + '<button data-bs-toggle="tooltip" data-bs-placement="right" title="Xem hình" style="border:none; background: none; text-align:right; color: #0087ffc7;" onclick="eventShowImg(' + items.id + ')"><i class="fas fa-eye"></i></button>';
                                    $("#CssUl").append(control).scrollTop($("#CssUl").prop('scrollHeight'));
                                    break;
                                case "jpeg":
                                    control = '<li style="width:50%; margin: auto; margin-left: 445px">' +
                                        '<a onclick="eventShowInfo(' + item.id + ')">' +
                                        '<div class="msj-rta macro">' +
                                        '<div class="text text-r">' +
                                        '<img style="width: 130px;" src="data: image/jpeg;base64, ' + items.contentImage_Doc + '"/>' +
                                        '<p style="text-align: left; color: black;"><small>' + item.dateCreate_C + ' - ' + item.timeCreate + '</small></p>' +
                                        '</div>' +
                                        '<div class="avatar" style="padding:0px 0px 0px 10px">' +
                                        '<img class="img-circle" style="width: 40px; border-radius: 50%; margin-left: 0px;" src="data: image/jpg;base64, ' + item.imageAvata + '"/></div>' +
                                        '</a>' +
                                        '</li>' + '<button data-bs-toggle="tooltip" data-bs-placement="right" title="Xem hình" style="border:none; background: none; text-align:right; color: #0087ffc7;" onclick="eventShowImg(' + items.id + ')"><i class="fas fa-eye"></i></button>';
                                    $("#CssUl").append(control).scrollTop($("#CssUl").prop('scrollHeight'));
                                    break;
                                case "PNG":
                                    control = '<li style="width:50%; margin: auto; margin-left: 445px">' +
                                        '<a onclick="eventShowInfo(' + item.id + ')">' +
                                        '<div class="msj-rta macro">' +
                                        '<div class="text text-r">' +
                                        '<img style="width: 130px;" src="data: image/PNG;base64, ' + items.contentImage_Doc + '"/>' +
                                        '<p style="text-align: left; color: black;"><small>' + item.dateCreate_C + ' - ' + item.timeCreate + '</small></p>' +
                                        '</div>' +
                                        '<div class="avatar" style="padding:0px 0px 0px 10px">' +
                                        '<img class="img-circle" style="width: 40px; border-radius: 50%; margin-left: 0px;" src="data: image/jpg;base64, ' + item.imageAvata + '"/></div>' +
                                        '</a>' +
                                        '</li>' + '<button data-bs-toggle="tooltip" data-bs-placement="right" title="Xem hình" style="border:none; background: none; text-align:right; color: #0087ffc7;" onclick="eventShowImg(' + items.id + ')"><i class="fas fa-eye"></i></button>';
                                    $("#CssUl").append(control).scrollTop($("#CssUl").prop('scrollHeight'));
                                    break;
                                case "png":
                                    control = '<li style="width:50%; margin: auto; margin-left: 445px">' +
                                        '<a onclick="eventShowInfo(' + item.id + ')">' +
                                        '<div class="msj-rta macro">' +
                                        '<div class="text text-r">' +
                                        '<img style="width: 130px;" src="data: image/png;base64, ' + items.contentImage_Doc + '"/>' +
                                        '<p style="text-align: left; color: black;"><small>' + item.dateCreate_C + ' - ' + item.timeCreate + '</small></p>' +
                                        '</div>' +
                                        '<div class="avatar" style="padding:0px 0px 0px 10px">' +
                                        '<img class="img-circle" style="width: 40px; border-radius: 50%; margin-left: 0px;" src="data: image/jpg;base64, ' + item.imageAvata + '"/></div>' +
                                        '</a>' +
                                        '</li>' + '<button data-bs-toggle="tooltip" data-bs-placement="right" title="Xem hình" style="border:none; background: none; text-align:right; color: #0087ffc7;" onclick="eventShowImg(' + items.id + ')"><i class="fas fa-eye"></i></button>';
                                    $("#CssUl").append(control).scrollTop($("#CssUl").prop('scrollHeight'));
                                    break;
                                case "GIF":
                                    control = '<li style="width:50%; margin: auto; margin-left: 445px">' +
                                        '<a onclick="eventShowInfo(' + item.id + ')">' +
                                        '<div class="msj-rta macro">' +
                                        '<div class="text text-r">' +
                                        '<img style="width: 130px;" src="data: image/GIF;base64, ' + items.contentImage_Doc + '"/>' +
                                        '<p style="text-align: left; color: black;"><small>' + item.dateCreate_C + ' - ' + item.timeCreate + '</small></p>' +
                                        '</div>' +
                                        '<div class="avatar" style="padding:0px 0px 0px 10px">' +
                                        '<img class="img-circle" style="width: 40px; border-radius: 50%; margin-left: 0px;" src="data: image/jpg;base64, ' + item.imageAvata + '"/></div>' +
                                        '</a>' +
                                        '</li>' + '<button data-bs-toggle="tooltip" data-bs-placement="right" title="Xem hình" style="border:none; background: none; text-align:right; color: #0087ffc7;" onclick="eventShowImg(' + items.id + ')"><i class="fas fa-eye"></i></button>';
                                    $("#CssUl").append(control).scrollTop($("#CssUl").prop('scrollHeight'));
                                    break;
                                case "gif":
                                    control = '<li style="width:50%; margin: auto; margin-left: 445px">' +
                                        '<a onclick="eventShowInfo(' + item.id + ')">' +
                                        '<div class="msj-rta macro">' +
                                        '<div class="text text-r">' +
                                        '<img style="width: 130px;" src="data: image/gif;base64, ' + items.contentImage_Doc + '"/>' +
                                        '<p style="text-align: left; color: black;"><small>' + item.dateCreate_C + ' - ' + item.timeCreate + '</small></p>' +
                                        '</div>' +
                                        '<div class="avatar" style="padding:0px 0px 0px 10px">' +
                                        '<img class="img-circle" style="width: 40px; border-radius: 50%; margin-left: 0px;" src="data: image/jpg;base64, ' + item.imageAvata + '"/></div>' +
                                        '</a>' +
                                        '</li>' + '<button data-bs-toggle="tooltip" data-bs-placement="right" title="Xem hình" style="border:none; background: none; text-align:right; color: #0087ffc7;" onclick="eventShowImg(' + items.id + ')"><i class="fas fa-eye"></i></button>';
                                    $("#CssUl").append(control).scrollTop($("#CssUl").prop('scrollHeight'));
                                    break;
                                case "pdf":
                                    control = '<li style="width:50%; margin: auto; margin-left: 445px">' +
                                        '<a onclick="eventShowInfo(' + item.id + ')">' +
                                        '<div class="msj-rta macro">' +
                                        '<div class="text text-r">' +
                                        '<p style="text-align: left; color: red;">' + items.nameImage + '</p>' +
                                        '<p style="text-align: left; color: black;"><small>' + item.dateCreate_C + ' - ' + item.timeCreate + '</small></p>' +
                                        '</div>' +
                                        '<div class="avatar" style="padding:0px 0px 0px 10px">' +
                                        '<img class="img-circle" style="width: 40px; border-radius: 50%; margin-left: 0px;" src="data: image/jpg;base64, ' + item.imageAvata + '"/></div>' +
                                        '</a>' +
                                        '</li>' + '<a href="/User/DowloadFileInMessage/?Id_File=' + items.id + '" data-bs-toggle="tooltip" data-bs-placement="right" title="Tải File Về" style="border:none; background: none; text-align:right; color: #0087ffc7;" onclick="eventDowload(' + items.id + ')"><i class="fas fa-download"></i></a>';
                                    $("#CssUl").append(control).scrollTop($("#CssUl").prop('scrollHeight'));
                                    break;
                                case "docx":
                                    control = '<li style="width:50%; margin: auto; margin-left: 445px">' +
                                        '<a onclick="eventShowInfo(' + item.id + ')">' +
                                        '<div class="msj-rta macro">' +
                                        '<div class="text text-r">' +
                                        '<p style="text-align: left; color: blue;">' + items.nameImage + '</p>' +
                                        '<p style="text-align: left; color: black;"><small>' + item.dateCreate_C + ' - ' + item.timeCreate + '</small></p>' +
                                        '</div>' +
                                        '<div class="avatar" style="padding:0px 0px 0px 10px">' +
                                        '<img class="img-circle" style="width: 40px; border-radius: 50%; margin-left: 0px;" src="data: image/jpg;base64, ' + item.imageAvata + '"/></div>' +
                                        '</a>' +
                                        '</li>' + '<a href="/User/DowloadFileInMessage/?Id_File=' + items.id + '" data-bs-toggle="tooltip" data-bs-placement="right" title="Tải File Về" style="border:none; background: none; text-align:right; color: #0087ffc7;" onclick="eventDowload(' + items.id + ')"><i class="fas fa-download"></i></a>';
                                    $("#CssUl").append(control).scrollTop($("#CssUl").prop('scrollHeight'));
                                    break;
                                case "xlsx":
                                    control = '<li style="width:50%; margin: auto; margin-left: 445px">' +
                                        '<a onclick="eventShowInfo(' + item.id + ')">' +
                                        '<div class="msj-rta macro">' +
                                        '<div class="text text-r">' +
                                        '<p style="text-align: left; color: green;">' + items.nameImage + '</p>' +
                                        '<p style="text-align: left; color: black;"><small>' + item.dateCreate_C + ' - ' + item.timeCreate + '</small></p>' +
                                        '</div>' +
                                        '<div class="avatar" style="padding:0px 0px 0px 10px">' +
                                        '<img class="img-circle" style="width: 40px; border-radius: 50%; margin-left: 0px;" src="data: image/jpg;base64, ' + item.imageAvata + '"/></div>' +
                                        '</a>' +
                                        '</li>' + '<a href="/User/DowloadFileInMessage/?Id_File=' + items.id + '" data-bs-toggle="tooltip" data-bs-placement="right" title="Tải File Về" style="border:none; background: none; text-align:right; color: #0087ffc7;" onclick="eventDowload(' + items.id + ')"><i class="fas fa-download"></i></a>';
                                    $("#CssUl").append(control).scrollTop($("#CssUl").prop('scrollHeight'));
                                    break;
                            }
                        })
                        break;
                    default:
                        control = '<li style="width:50%; margin: auto; margin-left: 445px">' +
                            '<a onclick="eventShowInfo(' + item.id + ')">' +
                            '<div class="msj-rta macro">' +
                            '<div class="text text-r">' +
                            '<p style="text-align: left; color: black;">' + item.message + '</p>' +
                            '<p style="text-align: left; color: black;"><small>' + item.dateCreate_C + ' - ' + item.timeCreate + '</small></p>' +
                            '</div>' +
                            '<div class="avatar" style="padding:0px 0px 0px 10px">' +
                            '<img class="img-circle" style="width: 40px; border-radius: 50%; margin-left: 0px;" src="data: image/jpg;base64, ' + item.imageAvata + '"/></div>' +
                            '</a>' +
                            '</li>';
                        $("#CssUl").append(control).scrollTop($("#CssUl").prop('scrollHeight'));
                        break;
                }
            } else {
                switch (item.message) {
                    case LoveHtml:
                        control = '<li style="width:50%">' +
                            '<a onclick="eventShowInfo(' + item.id + ')">' +
                            '<div class="msj macro">' +
                            '<div class="avatar"><img class="img-circle" style="width: 40px; border-radius: 50%; margin-left: -30px;" src="data: image/jpg;base64, ' + item.imageAvata + '"/></div>' +
                            '<div class="text text-l">' +
                            '<p style="text-align: right; color: #FF00FF; font-size: 45px; margin-left: -80%;">' + item.message + '</p>' +
                            '<p style="text-align: right; margin-left: -50%;"><small>' + item.dateCreate_C + ' - ' + item.timeCreate + '</small></p>' +
                            '</div>' +
                            '</div>' +
                            '</a>' +
                            '</li>';
                        $("#CssUl").append(control).scrollTop($("#CssUl").prop('scrollHeight'));
                        break;
                    case SadHtml:
                        control = '<li style="width:50%">' +
                            '<a onclick="eventShowInfo(' + item.id + ')">' +
                            '<div class="msj macro">' +
                            '<div class="avatar"><img class="img-circle" style="width: 40px; border-radius: 50%; margin-left: -30px;" src="data: image/jpg;base64, ' + item.imageAvata + '"/></div>' +
                            '<div class="text text-l">' +
                            '<p style="text-align: right; color: #FFFF00; font-size: 45px; margin-left: -80%;">' + item.message + '</p>' +
                            '<p style="text-align: right; margin-left: -50%;"><small>' + item.dateCreate_C + ' - ' + item.timeCreate + '</small></p>' +
                            '</div>' +
                            '</div>' +
                            '</a>' +
                            '</li>';
                        $("#CssUl").append(control).scrollTop($("#CssUl").prop('scrollHeight'));
                        break;
                    case FunnyHtml:
                        control = '<li style="width:50%">' +
                            '<a onclick="eventShowInfo(' + item.id + ')">' +
                            '<div class="msj macro">' +
                            '<div class="avatar"><img class="img-circle" style="width: 40px; border-radius: 50%; margin-left: -30px;" src="data: image/jpg;base64, ' + item.imageAvata + '"/></div>' +
                            '<div class="text text-l">' +
                            '<p style="text-align: right; color: #FF3366; font-size: 45px; margin-left: -80%;">' + item.message + '</p>' +
                            '<p style="text-align: right; margin-left: -50%;"><small>' + item.dateCreate_C + ' - ' + item.timeCreate + '</small></p>' +
                            '</div>' +
                            '</div>' +
                            '</a>' +
                            '</li>';
                        $("#CssUl").append(control).scrollTop($("#CssUl").prop('scrollHeight'));
                        break;
                    case LikeHtml:
                        control = '<li style="width:50%">' +
                            '<a onclick="eventShowInfo(' + item.id + ')">' +
                            '<div class="msj macro">' +
                            '<div class="avatar"><img class="img-circle" style="width: 40px; border-radius: 50%; margin-left: -30px;" src="data: image/jpg;base64, ' + item.imageAvata + '"/></div>' +
                            '<div class="text text-l">' +
                            '<p style="text-align: right; color: #0064ffad; font-size: 45px; margin-left: -80%;">' + item.message + '</p>' +
                            '<p style="text-align: right; margin-left: -50%;"><small>' + item.dateCreate_C + ' - ' + item.timeCreate + '</small></p>' +
                            '</div>' +
                            '</div>' +
                            '</a>' +
                            '</li>';
                        $("#CssUl").append(control).scrollTop($("#CssUl").prop('scrollHeight'));
                        break;
                    case "Images":
                        $.each(item.l_Images, function (key, items) {
                            switch (items.typeImage) {
                                case "JPG":
                                    control = '<li style="width:50%;">' +
                                        '<a onclick="eventShowInfo(' + item.id + ')">' +
                                        '<div class="msj macro">' +
                                        '<div class="avatar"><img class="img-circle" style="width: 40px; border-radius: 50%; margin-left: -30px;" src="data: image/jpg;base64, ' + item.imageAvata + '"/></div>' +
                                        '<div class="text text-l">' +
                                        '<img style="width: 130px;" src="data: image/gif;base64, ' + items.contentImage_Doc + '"/>' +
                                        '<p style="text-align: right; color: black;"><small>' + item.dateCreate_C + ' - ' + item.timeCreate + '</small></p>' +
                                        '</div>' +
                                        '</div>' +
                                        '</a>' +
                                        '</li>' + '<button data-bs-toggle="tooltip" data-bs-placement="right" title="Xem hình" style="border:none; background: none; text-align:left; color: #0087ffc7;" onclick="eventShowImg(' + items.id + ')"><i class="fas fa-eye"></i></button>';
                                    $("#CssUl").append(control).scrollTop($("#CssUl").prop('scrollHeight'));
                                    break;
                                case "jpg":
                                    control = '<li style="width:50%;">' +
                                        '<a onclick="eventShowInfo(' + item.id + ')">' +
                                        '<div class="msj macro">' +
                                        '<div class="avatar"><img class="img-circle" style="width: 40px; border-radius: 50%; margin-left: -30px;" src="data: image/jpg;base64, ' + item.imageAvata + '"/></div>' +
                                        '<div class="text text-l">' +
                                        '<img style="width: 130px;" src="data: image/gif;base64, ' + items.contentImage_Doc + '"/>' +
                                        '<p style="text-align: right; color: black;"><small>' + item.dateCreate_C + ' - ' + item.timeCreate + '</small></p>' +
                                        '</div>' +
                                        '</div>' +
                                        '</a>' +
                                        '</li>' + '<button data-bs-toggle="tooltip" data-bs-placement="right" title="Xem hình" style="border:none; background: none; text-align:left; color: #0087ffc7;" onclick="eventShowImg(' + items.id + ')"><i class="fas fa-eye"></i></button>';
                                    $("#CssUl").append(control).scrollTop($("#CssUl").prop('scrollHeight'));
                                    break;
                                case "JPEG":
                                    control = '<li style="width:50%;">' +
                                        '<a onclick="eventShowInfo(' + item.id + ')">' +
                                        '<div class="msj macro">' +
                                        '<div class="avatar"><img class="img-circle" style="width: 40px; border-radius: 50%; margin-left: -30px;" src="data: image/jpg;base64, ' + item.imageAvata + '"/></div>' +
                                        '<div class="text text-l">' +
                                        '<img style="width: 130px;" src="data: image/gif;base64, ' + items.contentImage_Doc + '"/>' +
                                        '<p style="text-align: right; color: black;"><small>' + item.dateCreate_C + ' - ' + item.timeCreate + '</small></p>' +
                                        '</div>' +
                                        '</div>' +
                                        '</a>' +
                                        '</li>' + '<button data-bs-toggle="tooltip" data-bs-placement="right" title="Xem hình" style="border:none; background: none; text-align:left; color: #0087ffc7;" onclick="eventShowImg(' + items.id + ')"><i class="fas fa-eye"></i></button>';
                                    $("#CssUl").append(control).scrollTop($("#CssUl").prop('scrollHeight'));
                                    break;
                                case "jpeg":
                                    control = '<li style="width:50%;">' +
                                        '<a onclick="eventShowInfo(' + item.id + ')">' +
                                        '<div class="msj macro">' +
                                        '<div class="avatar"><img class="img-circle" style="width: 40px; border-radius: 50%; margin-left: -30px;" src="data: image/jpg;base64, ' + item.imageAvata + '"/></div>' +
                                        '<div class="text text-l">' +
                                        '<img style="width: 130px;" src="data: image/gif;base64, ' + items.contentImage_Doc + '"/>' +
                                        '<p style="text-align: right; color: black;"><small>' + item.dateCreate_C + ' - ' + item.timeCreate + '</small></p>' +
                                        '</div>' +
                                        '</div>' +
                                        '</a>' +
                                        '</li>' + '<button data-bs-toggle="tooltip" data-bs-placement="right" title="Xem hình" style="border:none; background: none; text-align:left; color: #0087ffc7;" onclick="eventShowImg(' + items.id + ')"><i class="fas fa-eye"></i></button>';
                                    $("#CssUl").append(control).scrollTop($("#CssUl").prop('scrollHeight'));
                                    break;
                                case "PNG":
                                    control = '<li style="width:50%;">' +
                                        '<a onclick="eventShowInfo(' + item.id + ')">' +
                                        '<div class="msj macro">' +
                                        '<div class="avatar"><img class="img-circle" style="width: 40px; border-radius: 50%; margin-left: -30px;" src="data: image/jpg;base64, ' + item.imageAvata + '"/></div>' +
                                        '<div class="text text-l">' +
                                        '<img style="width: 130px;" src="data: image/gif;base64, ' + items.contentImage_Doc + '"/>' +
                                        '<p style="text-align: right; color: black;"><small>' + item.dateCreate_C + ' - ' + item.timeCreate + '</small></p>' +
                                        '</div>' +
                                        '</div>' +
                                        '</a>' +
                                        '</li>' + '<button data-bs-toggle="tooltip" data-bs-placement="right" title="Xem hình" style="border:none; background: none; text-align:left; color: #0087ffc7;" onclick="eventShowImg(' + items.id + ')"><i class="fas fa-eye"></i></button>';
                                    $("#CssUl").append(control).scrollTop($("#CssUl").prop('scrollHeight'));
                                    break;
                                case "png":
                                    control = '<li style="width:50%;">' +
                                        '<a onclick="eventShowInfo(' + item.id + ')">' +
                                        '<div class="msj macro">' +
                                        '<div class="avatar"><img class="img-circle" style="width: 40px; border-radius: 50%; margin-left: -30px;" src="data: image/jpg;base64, ' + item.imageAvata + '"/></div>' +
                                        '<div class="text text-l">' +
                                        '<img style="width: 130px;" src="data: image/gif;base64, ' + items.contentImage_Doc + '"/>' +
                                        '<p style="text-align: right; color: black;"><small>' + item.dateCreate_C + ' - ' + item.timeCreate + '</small></p>' +
                                        '</div>' +
                                        '</div>' +
                                        '</a>' +
                                        '</li>' + '<button data-bs-toggle="tooltip" data-bs-placement="right" title="Xem hình" style="border:none; background: none; text-align:left; color: #0087ffc7;" onclick="eventShowImg(' + items.id + ')"><i class="fas fa-eye"></i></button>';
                                    $("#CssUl").append(control).scrollTop($("#CssUl").prop('scrollHeight'));
                                    break;
                                case "GIF":
                                    control = '<li style="width:50%;">' +
                                        '<a onclick="eventShowInfo(' + item.id + ')">' +
                                        '<div class="msj macro">' +
                                        '<div class="avatar"><img class="img-circle" style="width: 40px; border-radius: 50%; margin-left: -30px;" src="data: image/jpg;base64, ' + item.imageAvata + '"/></div>' +
                                        '<div class="text text-l">' +
                                        '<img style="width: 130px;" src="data: image/gif;base64, ' + items.contentImage_Doc + '"/>' +
                                        '<p style="text-align: right; color: black;"><small>' + item.dateCreate_C + ' - ' + item.timeCreate + '</small></p>' +
                                        '</div>' +
                                        '</div>' +
                                        '</a>' +
                                        '</li>' + '<button data-bs-toggle="tooltip" data-bs-placement="right" title="Xem hình" style="border:none; background: none; text-align:left; color: #0087ffc7;" onclick="eventShowImg(' + items.id + ')"><i class="fas fa-eye"></i></button>';
                                    $("#CssUl").append(control).scrollTop($("#CssUl").prop('scrollHeight'));
                                    break;
                                case "gif":
                                    control = '<li style="width:50%;">' +
                                        '<a onclick="eventShowInfo(' + item.id + ')">' +
                                        '<div class="msj macro">' +
                                        '<div class="avatar"><img class="img-circle" style="width: 40px; border-radius: 50%; margin-left: -30px;" src="data: image/jpg;base64, ' + item.imageAvata + '"/></div>' +
                                        '<div class="text text-l">' +
                                        '<img style="width: 130px;" src="data: image/gif;base64, ' + items.contentImage_Doc + '"/>' +
                                        '<p style="text-align: right; color: black;"><small>' + item.dateCreate_C + ' - ' + item.timeCreate + '</small></p>' +
                                        '</div>' +
                                        '</div>' +
                                        '</a>' +
                                        '</li>' + '<button data-bs-toggle="tooltip" data-bs-placement="right" title="Xem hình" style="border:none; background: none; text-align:left; color: #0087ffc7;" onclick="eventShowImg(' + items.id + ')"><i class="fas fa-eye"></i></button>';
                                    $("#CssUl").append(control).scrollTop($("#CssUl").prop('scrollHeight'));
                                    break;
                                case "pdf":
                                    control = '<li style="width:50%;">' +
                                        '<a onclick="eventShowInfo(' + item.id + ')">' +
                                        '<div class="msj macro">' +
                                        '<div class="avatar"><img class="img-circle" style="width: 40px; border-radius: 50%; margin-left: -30px;" src="data: image/jpg;base64, ' + item.imageAvata + '"/></div>' +
                                        '<div class="text text-l">' +
                                        '<p style="text-align: right; color: red;">' + items.nameImage + '</p>' +
                                        '<p style="text-align: right; color: black;"><small>' + item.dateCreate_C + ' - ' + item.timeCreate + '</small></p>' +
                                        '</div>' +
                                        '</div>' +
                                        '</a>' +
                                        '</li>' + '<a href="/User/DowloadFileInMessage/?Id_File=' + items.id + '" data-bs-toggle="tooltip" data-bs-placement="right" title="Tải File Về" style="border:none; background: none; text-align:left; color: #0087ffc7;" onclick="eventDowload(' + items.id + ')"><i class="fas fa-download"></i></a>';
                                    $("#CssUl").append(control).scrollTop($("#CssUl").prop('scrollHeight'));
                                    break;
                                case "docx":
                                    control = '<li style="width:50%;">' +
                                        '<a onclick="eventShowInfo(' + item.id + ')">' +
                                        '<div class="msj macro">' +
                                        '<div class="avatar"><img class="img-circle" style="width: 40px; border-radius: 50%; margin-left: -30px;" src="data: image/jpg;base64, ' + item.imageAvata + '"/></div>' +
                                        '<div class="text text-l">' +
                                        '<p style="text-align: right; color: blue;">' + items.nameImage + '</p>' +
                                        '<p style="text-align: right; color: black;"><small>' + item.dateCreate_C + ' - ' + item.timeCreate + '</small></p>' +
                                        '</div>' +
                                        '</div>' +
                                        '</a>' +
                                        '</li>' + '<a href="/User/DowloadFileInMessage/?Id_File=' + items.id + '" data-bs-toggle="tooltip" data-bs-placement="right" title="Tải File Về" style="border:none; background: none; text-align:left; color: #0087ffc7;" onclick="eventDowload(' + items.id + ')"><i class="fas fa-download"></i></a>';
                                    $("#CssUl").append(control).scrollTop($("#CssUl").prop('scrollHeight'));
                                    break;
                                case "xlsx":
                                    control = '<li style="width:50%;">' +
                                        '<a onclick="eventShowInfo(' + item.id + ')">' +
                                        '<div class="msj macro">' +
                                        '<div class="avatar"><img class="img-circle" style="width: 40px; border-radius: 50%; margin-left: -30px;" src="data: image/jpg;base64, ' + item.imageAvata + '"/></div>' +
                                        '<div class="text text-l">' +
                                        '<p style="text-align: right; color: green;">' + items.nameImage + '</p>' +
                                        '<p style="text-align: right; color: black;"><small>' + item.dateCreate_C + ' - ' + item.timeCreate + '</small></p>' +
                                        '</div>' +
                                        '</div>' +
                                        '</a>' +
                                        '</li>' + '<a href="/User/DowloadFileInMessage/?Id_File=' + items.id + '" data-bs-toggle="tooltip" data-bs-placement="right" title="Tải File Về" style="border:none; background: none; text-align:left; color: #0087ffc7;" onclick="eventDowload(' + items.id + ')"><i class="fas fa-download"></i></a>';
                                    $("#CssUl").append(control).scrollTop($("#CssUl").prop('scrollHeight'));
                                    break;
                            }
                        })
                        break;
                    default:
                        control = '<li style="width:50%">' +
                            '<a onclick="eventShowInfo(' + item.id + ')">' +
                            '<div class="msj macro">' +
                            '<div class="avatar"><img class="img-circle" style="width: 40px; border-radius: 50%; margin-left: -30px;" src="data: image/jpg;base64, ' + item.imageAvata + '"/></div>' +
                            '<div class="text text-l">' +
                            '<p style="text-align: right;">' + item.message + '</p>' +
                            '<p style="text-align: right;"><small>' + item.dateCreate_C + ' - ' + item.timeCreate + '</small></p>' +
                            '</div>' +
                            '</div>' +
                            '</a>' +
                            '</li>';
                        $("#CssUl").append(control).scrollTop($("#CssUl").prop('scrollHeight'));
                        break;
                }
            }
        })
    }
}

function Id_LoadAddMessage() {
    Page_Index++;
    LoadingData();
}


//----------------------------------------------------------
//show slider list images in message
$("#ViewImages").click(function () {
    $(".carousel-indicators").empty();
    $(".carousel-inner").empty();
    $.ajax({
        url: "/User/ListImagesInMessage",
        type: "get",
        success: function (result) {
            var count = 0;
            $.each(result, function (key, item) {
                var html = "";
                if (count == 0) {
                    html += '<li data-target="#carouselExampleCaptions" data-slide-to="' + count + '" class="active"></li>';
                } else {
                    html += '<li data-target="#carouselExampleCaptions" data-slide-to="' + count + '"></li>'
                }
                $(".carousel-indicators").append(html);
                count++;
                if (count == 1) {
                    LoadImageMessageAciver(item.typeImage, item.contentImage_Doc, item.nameImage, item.dateCreateStr);
                } else {
                    LoadImageMessage(item.typeImage, item.contentImage_Doc, item.nameImage, item.dateCreateStr);
                }
            })
            $("#modalShowSliderListImage").show();
        }
    })
    return;
});

//close slider
$("#btnCloseSlider").click(function () {
    $("#modalShowSliderListImage").hide();
});

//load images in message
function LoadImageMessageAciver(n, images_Doc, nameImage, datecreate) {
    var option = "";
    switch (n) {
        case "JPG":
            option += '<div class="carousel-item active">';
            option += '<img src="data: image/JPG;base64, ' + images_Doc + '" class="d-block w-100">';
            option += '<div class="carousel-caption d-none d-md-block">';
            option += '<h5 style="color:black">' + nameImage + '</h5>';
            option += '<p style="color:black">' + datecreate + '</p>';
            option += '</div>';
            option += '</div>';
            break;
        case "jpg":
            option += '<div class="carousel-item active">';
            option += '<img src="data: image/JPG;base64, ' + images_Doc + '" class="d-block w-100">';
            option += '<div class="carousel-caption d-none d-md-block">';
            option += '<h5 style="color:black">' + nameImage + '</h5>';
            option += '<p style="color:black">' + datecreate + '</p>';
            option += '</div>';
            option += '</div>';
            break;
        case "JPEG":
            option += '<div class="carousel-item active">';
            option += '<img src="data: image/JPG;base64, ' + images_Doc + '" class="d-block w-100">';
            option += '<div class="carousel-caption d-none d-md-block">';
            option += '<h5 style="color:black">' + nameImage + '</h5>';
            option += '<p style="color:black">' + datecreate + '</p>';
            option += '</div>';
            option += '</div>';
            break;
        case "jpeg":
            option += '<div class="carousel-item active">';
            option += '<img src="data: image/JPG;base64, ' + images_Doc + '" class="d-block w-100">';
            option += '<div class="carousel-caption d-none d-md-block">';
            option += '<h5 style="color:black">' + nameImage + '</h5>';
            option += '<p style="color:black">' + datecreate + '</p>';
            option += '</div>';
            option += '</div>';
            break;
        case "PNG":
            option += '<div class="carousel-item active">';
            option += '<img src="data: image/JPG;base64, ' + images_Doc + '" class="d-block w-100">';
            option += '<div class="carousel-caption d-none d-md-block">';
            option += '<h5 style="color:black">' + nameImage + '</h5>';
            option += '<p style="color:black">' + datecreate + '</p>';
            option += '</div>';
            option += '</div>';
            break;
        case "png":
            option += '<div class="carousel-item active">';
            option += '<img src="data: image/JPG;base64, ' + images_Doc + '" class="d-block w-100">';
            option += '<div class="carousel-caption d-none d-md-block">';
            option += '<h5 style="color:black">' + nameImage + '</h5>';
            option += '<p style="color:black">' + datecreate + '</p>';
            option += '</div>';
            option += '</div>';
            break;
        case "GIF":
            option += '<div class="carousel-item active">';
            option += '<img src="data: image/JPG;base64, ' + images_Doc + '" class="d-block w-100">';
            option += '<div class="carousel-caption d-none d-md-block">';
            option += '<h5 style="color:black">' + nameImage + '</h5>';
            option += '<p style="color:black">' + datecreate + '</p>';
            option += '</div>';
            option += '</div>';
            break;
        case "gif":
            option += '<div class="carousel-item active">';
            option += '<img src="data: image/JPG;base64, ' + images_Doc + '" class="d-block w-100">';
            option += '<div class="carousel-caption d-none d-md-block">';
            option += '<h5 style="color:black">' + nameImage + '</h5>';
            option += '<p style="color:black">' + datecreate + '</p>';
            option += '</div>';
            option += '</div>';
            break;
    }
    $(".carousel-inner").append(option);
}

function LoadImageMessage(n, images_Doc, nameImage, datecreate) {
    var option = "";
    switch (n) {
        case "JPG":
            option += '<div class="carousel-item">';
            option += '<img src="data: image/JPG;base64, ' + images_Doc + '" class="d-block w-100">';
            option += '<div class="carousel-caption d-none d-md-block">';
            option += '<h5 style="color:black">' + nameImage + '</h5>';
            option += '<p style="color:black">' + datecreate + '</p>';
            option += '</div>';
            option += '</div>';
            break;
        case "jpg":
            option += '<div class="carousel-item">';
            option += '<img src="data: image/JPG;base64, ' + images_Doc + '" class="d-block w-100">';
            option += '<div class="carousel-caption d-none d-md-block">';
            option += '<h5 style="color:black">' + nameImage + '</h5>';
            option += '<p style="color:black">' + datecreate + '</p>';
            option += '</div>';
            option += '</div>';
            break;
        case "JPEG":
            option += '<div class="carousel-item">';
            option += '<img src="data: image/JPG;base64, ' + images_Doc + '" class="d-block w-100">';
            option += '<div class="carousel-caption d-none d-md-block">';
            option += '<h5 style="color:black">' + nameImage + '</h5>';
            option += '<p style="color:black">' + datecreate + '</p>';
            option += '</div>';
            option += '</div>';
            break;
        case "jpeg":
            option += '<div class="carousel-item">';
            option += '<img src="data: image/JPG;base64, ' + images_Doc + '" class="d-block w-100">';
            option += '<div class="carousel-caption d-none d-md-block">';
            option += '<h5 style="color:black">' + nameImage + '</h5>';
            option += '<p style="color:black">' + datecreate + '</p>';
            option += '</div>';
            option += '</div>';
            break;
        case "PNG":
            option += '<div class="carousel-item">';
            option += '<img src="data: image/JPG;base64, ' + images_Doc + '" class="d-block w-100">';
            option += '<div class="carousel-caption d-none d-md-block">';
            option += '<h5 style="color:black">' + nameImage + '</h5>';
            option += '<p style="color:black">' + datecreate + '</p>';
            option += '</div>';
            option += '</div>';
            break;
        case "png":
            option += '<div class="carousel-item">';
            option += '<img src="data: image/JPG;base64, ' + images_Doc + '" class="d-block w-100">';
            option += '<div class="carousel-caption d-none d-md-block">';
            option += '<h5 style="color:black">' + nameImage + '</h5>';
            option += '<p style="color:black">' + datecreate + '</p>';
            option += '</div>';
            option += '</div>';
            break;
        case "GIF":
            option += '<div class="carousel-item">';
            option += '<img src="data: image/JPG;base64, ' + images_Doc + '" class="d-block w-100">';
            option += '<div class="carousel-caption d-none d-md-block">';
            option += '<h5 style="color:black">' + nameImage + '</h5>';
            option += '<p style="color:black">' + datecreate + '</p>';
            option += '</div>';
            option += '</div>';
            break;
        case "gif":
            option += '<div class="carousel-item">';
            option += '<img src="data: image/JPG;base64, ' + images_Doc + '" class="d-block w-100">';
            option += '<div class="carousel-caption d-none d-md-block">';
            option += '<h5 style="color:black">' + nameImage + '</h5>';
            option += '<p style="color:black">' + datecreate + '</p>';
            option += '</div>';
            option += '</div>';
            break;
    }
    $(".carousel-inner").append(option);
}

function LoadImageViewDetail(TypeImage, images_base64) {
    var html = "";
    switch (TypeImage) {
        case "JPG":
            html += '<img style="Max-width: 100%;" src="data: image/JPG;base64, ' + images_base64 + '"/>';
            break;
        case "jpg":
            html += '<img style="Max-width: 100%;" src="data: image/jpg;base64, ' + images_base64 + '"/>';
            break;
        case "JPEG":
            html += '<img style="Max-width: 100%;" src="data: image/JPEG;base64, ' + images_base64 + '"/>';
            break;
        case "jpeg":
            html += '<img style="Max-width: 100%;" src="data: image/jpeg;base64, ' + images_base64 + '"/>';
            break;
        case "PNG":
            html += '<img style="Max-width: 100%;" src="data: image/PNG;base64, ' + images_base64 + '"/>';
            break;
        case "png":
            html += '<img style="Max-width: 100%;" src="data: image/png;base64, ' + images_base64 + '"/>';
            break;
        case "GIF":
            html += '<img style="Max-width: 100%;" src="data: image/GIF;base64, ' + images_base64 + '"/>';
            break;
        case "gif":
            html += '<img style="Max-width: 100%;" src="data: image/gif;base64, ' + images_base64 + '"/>';
            break;
    }
    $("#BodyImages").append(html);
}

//--------------------------------------------------------
//get all file in message
$("#ViewFiles").click(function () {
    $.ajax({
        url: "/User/ListFileInMessage",
        type: "get",
        success: function (result) {
            LoadViewListFile(result);
        }
    })
});

function LoadViewListFile(result) {
    $("#BodyListFile").empty();
    $("#modalShowListFile").show();
    var count = 0;
    $.each(result, function (key, item) {
        count++;
        if (count == 1) {
            var HtmlDateDefault = '<p>' + item.date_String + '</p>';
            $("#BodyListFile").append(HtmlDateDefault);
            $.each(item.lFile_Message, function (key, items) {
                var HtmlDefault = "";
                switch (items.typeImage) {
                    case "pdf":
                        HtmlDefault += '<div class="card" style="width: 18rem; float: left; margin: 10px 10px;">';
                        HtmlDefault += '<div class="card-body">';
                        HtmlDefault += '<h6 class="card-title" style="color: red;">' + items.nameImage + '</h6>';
                        HtmlDefault += '<h6 class="card-subtitle mb-2 text-muted">File PDF</h6>';
                        HtmlDefault += '<p class="card-text"><b>' + Sender + ' </b> ' + items.nameUser + '</p> ';
                        HtmlDefault += '<a class="card-link" style="color: black;">' + items.dateCreateStr + ' / ' + items.timeCreate + '</a>';
                        HtmlDefault += '<a href="/User/DowloadFileInMessage/?Id_File=' + items.id + '" class="card-link"><i class="fas fa-file-download"></i> ' + Dowload + '</a>';
                        HtmlDefault += '</div>';
                        HtmlDefault += '</div>';
                        break;
                    case "docx":
                        HtmlDefault += '<div class="card" style="width: 18rem; float: left; margin: 10px 10px;">';
                        HtmlDefault += '<div class="card-body">';
                        HtmlDefault += '<h6 class="card-title" style="color: blue;">' + items.nameImage + '</h6>';
                        HtmlDefault += '<h6 class="card-subtitle mb-2 text-muted">File WORD</h6>';
                        HtmlDefault += '<p class="card-text"><b>' + Sender + ' </b> ' + items.nameUser + '</p> ';
                        HtmlDefault += '<a class="card-link" style="color: black;">' + items.dateCreateStr + ' / ' + items.timeCreate + '</a>';
                        HtmlDefault += '<a href="/User/DowloadFileInMessage/?Id_File=' + items.id + '" class="card-link"><i class="fas fa-file-download"></i> ' + Dowload + '</a>';
                        HtmlDefault += '</div>';
                        HtmlDefault += '</div>';
                        break;
                    case "xlsx":
                        HtmlDefault += '<div class="card" style="width: 18rem; float: left; margin: 10px 10px;">';
                        HtmlDefault += '<div class="card-body">';
                        HtmlDefault += '<h6 class="card-title" style="color: green;">' + items.nameImage + '</h6>';
                        HtmlDefault += '<h6 class="card-subtitle mb-2 text-muted">File EXCEL</h6>';
                        HtmlDefault += '<p class="card-text"><b>' + Sender + ' </b> ' + items.nameUser + '</p> ';
                        HtmlDefault += '<a class="card-link" style="color: black;">' + items.dateCreateStr + ' / ' + items.timeCreate + '</a>';
                        HtmlDefault += '<a href="/User/DowloadFileInMessage/?Id_File=' + items.id + '" class="card-link"><i class="fas fa-file-download"></i> ' + Dowload + '</a>';
                        HtmlDefault += '</div>';
                        HtmlDefault += '</div>';
                        break;
                }
                $("#BodyListFile").append(HtmlDefault);
            })
        } else {
            var HtmlSecond = "";
            var HtmlSecond = '<p style="clear: both;">' + item.date_String + '</p>';
            $("#BodyListFile").append(HtmlSecond);
            $.each(item.lFile_Message, function (key, items) {
                var HtmlContent = "";
                switch (items.typeImage) {
                    case "pdf":
                        HtmlContent += '<div class="card" style="width: 18rem; float: left; margin: 10px 10px;">';
                        HtmlContent += '<div class="card-body">';
                        HtmlContent += '<h6 class="card-title" style="color: red;">' + items.nameImage + '</h6>';
                        HtmlContent += '<h6 class="card-subtitle mb-2 text-muted">File PDF</h6>';
                        HtmlContent += '<p class="card-text"><b>' + Sender + ' </b> ' + items.nameUser + '</p> ';
                        HtmlContent += '<a class="card-link" style="color: black;">' + items.dateCreateStr + ' / ' + items.timeCreate + '</a>';
                        HtmlContent += '<a href="/User/DowloadFileInMessage/?Id_File=' + items.id + '" class="card-link"><i class="fas fa-file-download"></i> ' + Dowload + '</a>';
                        HtmlContent += '</div>';
                        HtmlContent += '</div>';
                        break;
                    case "docx":
                        HtmlContent += '<div class="card" style="width: 18rem; float: left; margin: 10px 10px;">';
                        HtmlContent += '<div class="card-body">';
                        HtmlContent += '<h6 class="card-title" style="color: blue;">' + items.nameImage + '</h6>';
                        HtmlContent += '<h6 class="card-subtitle mb-2 text-muted">File WORD</h6>';
                        HtmlContent += '<p class="card-text"><b>' + Sender + ' </b> ' + items.nameUser + '</p> ';
                        HtmlContent += '<a class="card-link" style="color: black;">' + items.dateCreateStr + ' / ' + items.timeCreate + '</a>';
                        HtmlContent += '<a href="/User/DowloadFileInMessage/?Id_File=' + items.id + '" class="card-link"><i class="fas fa-file-download"></i> ' + Dowload + '</a>';
                        HtmlContent += '</div>';
                        HtmlContent += '</div>';
                        break;
                    case "xlsx":
                        HtmlContent += '<div class="card" style="width: 18rem; float: left; margin: 10px 10px;">';
                        HtmlContent += '<div class="card-body">';
                        HtmlContent += '<h6 class="card-title" style="color: green;">' + items.nameImage + '</h6>';
                        HtmlContent += '<h6 class="card-subtitle mb-2 text-muted">File EXCEL</h6>';
                        HtmlContent += '<p class="card-text"><b>' + Sender + ' </b> ' + items.nameUser + '</p> ';
                        HtmlContent += '<a class="card-link" style="color: black;">' + items.dateCreateStr + ' / ' + items.timeCreate + '</a>';
                        HtmlContent += '<a href="/User/DowloadFileInMessage/?Id_File=' + items.id + '" class="card-link"><i class="fas fa-file-download"></i> ' + Dowload + '</a>';
                        HtmlContent += '</div>';
                        HtmlContent += '</div>';
                        break;
                }
                $("#BodyListFile").append(HtmlContent);
            })
        }
    })
}

$("#btnCloseFle_L").click(function () {
    $("#BodyListFile").empty();
    $("#modalShowListFile").hide();
});

//datetime picker
$("#rangeDate_File").flatpickr({
    mode: 'range',
    dateFormat: "Y-m-d"
});

//------------------------------------------------------------------------------------------------------
$("#btn_FilterDate").click(function () {
    var Get_n = $("#rangeDate_File").val();
    if (Get_n.length == 0) {
        toastr.error(select_date, Notification_Error);
    } else {
        $.ajax({
            url: "/User/Fuilter_ListFile",
            type: "get",
            data: {
                DateFuilter: $("#rangeDate_File").val()
            },
            success: function (result) {
                LoadViewListFile(result);
            }
        })
    }
    return;
})




