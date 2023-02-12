var title_Remove = $("#btn_ReomveData").val();
var head = $("#head").val();
var next = $("#next").val();
var last = $("#last").val();
var Before = $("#Before").val();
var watched = $("#watched").val();
var not_seen = $("#not_seen").val();
var ChooseRow = $("#ChooseRow").val();
var Notification_Error = $("#Notification_Error").val();
var RemoveError = $("#RemoveError").val();
var Nofitication_Success = $("#Nofitication_Success").val();
var RemoveSuccess = $("#RemoveSuccess").val();

var Size = 20;
var Index = 1;
$(document).ready(function () {
    LoadNotifcation();
});
//load data
function LoadNotifcation() {
    var ItemInPage = $("#ItemInPage").empty();
    var Totalitem = $("#TotalItem").empty();
    var Bdy_Tc = $("#T_bodyNotification").empty();
    $.ajax({
        url: "/Notification/GetAllNotificationByIdUser",
        type: "get",
        data: {
            PageSize: Size,
            PageIndex: Index
        },
        success: function (result) {
            var count = 0;
            var Num_Notification = $("#NumberNotification").empty();
            if (result == 0) {
                Num_Notification.append(count);
            } else {
                $.each(result.l_Notification, function (key, item) {
                    count++;
                    var html = ""
                    html += '<tr>';
                    html += '<th scope="row">';
                    html += '<input type="checkbox" class="case" name="case" value="' + item.idNotification + '"/>';
                    html += '</th>';
                    html += '<th scope="row">' + count + '</th>';
                    html += '<td>' + item.titleNotification + '</td>';
                    html += '<td>' + item.authorNotification + '</td>';
                    html += '<td>' + item.timeCreate + '</td>';
                    html += '<td>' + item.dateCreate + '</td>';
                    if (item.idViewNotification == 2) {
                        html += '<td>' + not_seen + '</td>';
                    } else {
                        html += '<td>' + watched + '</td>';
                    }                    
                    html += '<td>';
                    html += '<button onclick="btnReomve_Anotification(' + item.idNotification + ')" type="button" class="btn btn-outline-secondary" data-bs-toggle="tooltip" data-bs-placement="right" title="' + title_Remove + '" style="border: none;"> <i class="fas fa-trash"></i></button>';
                    html += '</td>';
                    html += '</tr>';
                    Bdy_Tc.append(html);
                })
                Num_Notification.append(result.totalNotification);
                ItemInPage.append(count);
                Totalitem.append(Index)
                //paing
                paging(result.totalNotification, function () {
                    LoadNotifcation();
                })
            }
            return;
        }
    })
}

//----------------------------------------------
//paing
function paging(totalRoll, callback) {
    var totalPage = Math.ceil(totalRoll / Size);
    $('#pagination').twbsPagination({
        totalPages: (totalPage == 0) ? 1 : totalPage,
        first: head,
        next: next,
        last: last,
        prev: Before,
        visiblePages: 10,
        onPageClick: function (event, page) {
            Index = page;
            setTimeout(callback, 200);
        }
    });
}

//show modal activer file
$("#btn_remove").click(function () {
    var checkbox = document.getElementsByName('case');
    var myArrayActiver = new Array();
    for (var i = 0; i < checkbox.length; i++) {
        if (checkbox[i].checked === true) {
            var partNumber = Number(checkbox[i].value);
            myArrayActiver.push(partNumber);
        }
    }
    if (myArrayActiver.length == 0) {
        toastr.error(ChooseRow, Notification_Error);
        return;
    } else {
        $("#modal_Loading").show();
        $.ajax({
            url: "/Notification/JsonDeleteNotification",
            type: "post",
            data: {
                Id: myArrayActiver
            },
            success: function (result) {
                $("#modal_Loading").hide();
                if (result == false) {                   
                    toastr.error(RemoveError, Notification_Error)
                } else {
                    toastr.success(RemoveSuccess, Nofitication_Success)
                    location.reload();
                }
                return;
            }
        })
    }
});

//funtion choose all checkbox option
$("#selectall").click(function () {
    $('.case').attr('checked', this.checked);
});

$(".case").click(function () {
    if ($(".case").length == $(".case:checked").length) {
        $("#selectall").attr("checked", "checked");
    } else {
        $("#selectall").removeAttr("checked");
    }

});

//remove a notification by id user
function btnReomve_Anotification(Id) {
    $.ajax({
        url: "/Notification/JsonDeleteNotification",
        type: "post",
        data: {
            IdNotification: Id
        },
        success: function (result) {
            if (result == false) {
                toastr.error(RemoveError, Notification_Error)
            } else {
                toastr.success(RemoveSuccess, Nofitication_Success)
                location.reload();
            }
            return;
        }
    })
}