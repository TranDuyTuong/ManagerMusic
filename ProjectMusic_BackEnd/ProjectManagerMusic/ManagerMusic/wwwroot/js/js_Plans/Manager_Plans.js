var head = $("#head").val();
var next = $("#next").val();
var last = $("#last").val();
var Before = $("#Before").val();
var Notification_Error = $("#Notification_Error").val();
var Nofitication_Success = $("#Nofitication_Success").val();
var NotFindStaff = $("#NotFindStaff").val();
var Notaskfound_employee = $("#Notaskfound_employee").val();
var EXPIRED = $("#EXPIRED").val();
var not_received = $("#not_received").val();
var Received = $("#Received").val();
var Cancelled = $("#Cancelled").val();
var View_task = $("#View_task").val();
var Clear_task = $("#Clear_task").val();
var Taking_mission = $("#Taking_mission").val();
var Cancel_task = $("#Cancel_task").val();
var passed_match = $("#passed_match").val();
var Notaskwith_codefound = $("#Notaskwith_codefound").val();
var Successfultask_received = $("#Successfultask_received").val();
var EmployeeCode_Invalid = $("#EmployeeCode_Invalid").val();
var Pleaseenter_accepttask = $("#Pleaseenter_accepttask").val();
var Failedaccepttask_successfully = $("#Failedaccepttask_successfully").val();
var Choose_Status = $("#Choose_Status").val();
var Cleartask_successfully = $("#Cleartask_successfully").val();

$(document).ready(function () {
    LoadPlansByIdUser();
    String_DateCreate = null;
    String_DateCompelete = null;
    IdStatus = null;
});

var Page_Index = 1;
var Page_Size = 10;
function LoadPlansByIdUser() {
    $("#Body_Data").empty();
    $("#TxtTotalPlan").empty();
    $("#ItemInPage").empty();
    $("#TotalItem").empty();
    $.ajax({
        url: "/ManagerPlans/GetAllPlansByIdUser",
        type: "get",
        data: {
            IdUser: $("#IdUser").val(),
            PageIndex: Page_Index,
            PageSize: Page_Size,
            DateCreate: String_DateCreate,
            DateCompelete: String_DateCompelete,
            IdStatus: IdStatus
        },
        success: function (result) {
            switch (result.nameRole) {
                case "AD":
                    LoadAmountNotificationPlan();
                    $("#TxtTotalPlan").append(result.totalPlan);
                    LoadPlansList_AD(result.l_Plans, result.totalPlan)
                    break;
                case "NV":
                    $("#TxtTotalPlan").append(result.totalPlan);
                    document.getElementById('TotalCancelPlans').style.display = 'none';
                    LoadPlansList_NV(result.l_Plans, result.totalPlan)
                    break;
                default:
                    toastr.error(Notaskfound_employee, Notification_Error);
                    break;
            }
            return;
        }
    })
    
}

//Admin
function LoadPlansList_AD(L_Plans, totalPlan) {
    var count = 0;
    $.each(L_Plans, function (key, item) {
        count++;
        var html = '';
        html += '<tr>';
        html += '<th scope="row">' + item.idPlan + '</th>';
        html += '<td style="font-size: 11px; font-weight: 600; font-family: initial; text-align: center;">' + item.titlePlan + '</td>';
        html += '<td style="font-size: 15px; font-weight: 600; font-family: initial; text-align: center;">' + item.nameUserPlan + '</td>';
        html += '<td style="font-size: 15px; font-weight: 600; font-family: initial; text-align: center;">' + item.nameUserRequest + '</td>';
        html += '<td style="font-weight: 600; font-family: initial; font-size: 13px; text-align: center;">' + item.dateCreate_Str + '</td>';
        if (item.timeUp == true) {
            if (item.timeCompele.minutes == 0) {
                html += '<td style="background: #0000005c">' + item.dateComplete_Str +
                    '<br />' + '<p style="font-weight: 600; text-align: right; color: blue; font-family: initial;">' + item.timeCompele.hours + ':0' + item.timeCompele.minutes + '</p>'
                    + '<br />' + '<p style="font-weight: 600; text-align: center; color: red; font-family: initial;">' + EXPIRED + '</p>'
                    + '</td>';
            } else {
                html += '<td style="background: #0000005c">' + item.dateComplete_Str +
                    '<br />' + '<p style="font-weight: 600; text-align: right; color: blue; font-family: initial;">' + item.timeCompele.hours + ':' + item.timeCompele.minutes + '</p>'
                    + '<br />' + '<p style="font-weight: 600; text-align: center; color: red; font-family: initial;">' + EXPIRED + '</p>'
                    + '</td>';
            }
        } else {
            if (item.timeCompele.minutes == 0) {
                html += '<td>' + item.dateComplete_Str + '<br />' + '<p style="font-weight: 600; text-align: right; color: blue; font-family: initial;">' + item.timeCompele.hours + ':0' + item.timeCompele.minutes + '</p>' + '</td>';
            } else {
                html += '<td>' + item.dateComplete_Str + '<br />' + '<p style="font-weight: 600; text-align: right; color: blue; font-family: initial;">' + item.timeCompele.hours + ':' + item.timeCompele.minutes + '</p>' + '</td>';
            }
        }
        switch (item.idAcceptPlan) {
            case 0:
                html += '<td style="font-size: 11px; font-weight: 600; font-family: initial; color: blue; text-align: center;">' + not_received + '</td>';
                break;
            case 1:
                html += '<td style="font-size: 11px; font-weight: 600; font-family: initial; color: green; text-align: center;">' + Received + '</td>';
                break;
            case 2:
                html += '<td style="font-size: 11px; font-weight: 600; font-family: initial; color: red; text-align: center;">' + Cancelled + '</td>';
                break;
            default:
                html += '<td style="font-size: 11px; font-weight: 600; font-family: initial; color: blue; text-align: center;">' + not_received + '</td>';
                break;
        }
        switch (item.idStatus) {
            case 1:
                html += '<td>'
                    + '<div class="progress">' +
                    '<div class="progress-bar bg-success" role ="progressbar" style ="width: 100%" aria-valuenow="100" aria-valuemin="0" aria-valuemax="100"></div>'
                    + '</div>'
                    + '<br />' + '<p style="font-weight: 600; text-align: center; color: green; font-family: initial;">' + item.nameStatus + '</p>'
                    + '</td>';
                break;
            case 2:
                html += '<td>'
                    + '<div class="progress">' +
                    '<div class="progress-bar bg-danger" role = "progressbar" aria-valuenow="0" aria-valuemin="0" aria-valuemax="100"></div>'
                    + '</div>'
                    + '<br />' + '<p style="font-weight: 600; text-align: center; color: red; font-family: initial;">' + item.nameStatus + '</p>'
                    + '</td>';
                break;
            case 3:
                html += '<td>'
                    + '<div class="progress">' +
                    '<div class="progress-bar bg-warning" role ="progressbar" style ="width: 5%" aria-valuenow="5" aria-valuemin="0" aria-valuemax="100"></div>'
                    + '</div>'
                    + '<br />' + '<p style="font-weight: 600; text-align: center; color: yellow; font-family: initial;">' + item.nameStatus + '</p>'
                    + '</td>';
                break;
            case 4:
                html += '<td>'
                    + '<div class="progress">' +
                    '<div class="progress-bar" role ="progressbar" style ="width: 25%" aria-valuenow="25" aria-valuemin="0" aria-valuemax="100"></div>'
                    + '</div>'
                    + '<br />' + '<p style="font-weight: 600; text-align: center; color: blue; font-family: initial;">' + item.nameStatus + '</p>'
                    + '</td>';
                break;
            case 5:
                html += '<td>'
                    + '<div class="progress">' +
                    '<div class="progress-bar bg-danger" role = "progressbar" style ="width: 1%" aria-valuenow="1" aria-valuemin="0" aria-valuemax="100"></div>'
                    + '</div>'
                    + '<br />' + '<p style="font-weight: 600; text-align: center; color: red; font-family: initial;">' + item.nameStatus + '</p>'
                    + '</td>';
                break;
            default:
                html += '<td style="text-align: center;">' + '----' + '</td>';
                break
        }
        html += '<td>'
            + '<a href="/ManagerPlans/Page_DetailPlan/?IdPlan=' + item.idPlan + '" style="border: none; font-size: 10px;" data-bs-toggle="tooltip" data-bs-placement="right" title="' + View_task + '" class="btn btn-outline-secondary"><i class="fas fa-folder-open"></i></a>' +
            '<button onclick="funtionRemovePlan(' + item.idPlan + ')" style="border: none; font-size: 10px;" data-bs-toggle="tooltip" data-bs-placement="right" title="' + Clear_task + '" type="button" class="btn btn-outline-secondary"><i class="fas fa-trash-alt"></i></button>' +
                '</td>';

        html += '</tr>';
        $("#Body_Data").append(html);
    })
    $("#ItemInPage").append(Page_Index);
    $("#TotalItem").append(count);
    //paing
    paging(totalPlan, function () {
        LoadPlansByIdUser();
    })
}

//Staff
function LoadPlansList_NV(L_Plans, totalPlan) {
    var count = 0;
    $.each(L_Plans, function (key, item) {
        count++;
        var html = '';
        html += '<tr>';
        html += '<th scope="row">' + item.idPlan + '</th>';
        html += '<td style="font-size: 11px; font-weight: 600; font-family: initial; text-align: center;">' + item.titlePlan + '</td>';
        html += '<td style="font-size: 15px; font-weight: 600; font-family: initial; text-align: center;">' + item.nameUserPlan + '</td>';
        html += '<td style="font-size: 15px; font-weight: 600; font-family: initial; text-align: center;">' + item.nameUserRequest + '</td>';
        html += '<td style="font-weight: 600; font-family: initial; font-size: 13px; text-align: center;">' + item.dateCreate_Str + '</td>';
        if (item.timeUp == true) {
            if (item.timeCompele.minutes == 0) {
                html += '<td style="background: #0000005c">' + item.dateComplete_Str +
                    '<br />' + '<p style="font-weight: 600; text-align: right; color: blue; font-family: initial;">' + item.timeCompele.hours + ':0' + item.timeCompele.minutes + '</p>'
                    + '<br />' + '<p style="font-weight: 600; text-align: center; color: red; font-family: initial;">' + EXPIRED + '</p>'
                    + '</td>';
            } else {
                html += '<td style="background: #0000005c">' + item.dateComplete_Str +
                    '<br />' + '<p style="font-weight: 600; text-align: right; color: blue; font-family: initial;">' + item.timeCompele.hours + ':' + item.timeCompele.minutes + '</p>'
                    + '<br />' + '<p style="font-weight: 600; text-align: center; color: red; font-family: initial;">' + EXPIRED + '</p>'
                    + '</td>';
            }
        } else {
            if (item.timeCompele.minutes == 0) {
                html += '<td>' + item.dateComplete_Str + '<br />' + '<p style="font-weight: 600; text-align: right; color: blue; font-family: initial;">' + item.timeCompele.hours + ':0' + item.timeCompele.minutes + '</p>' + '</td>';
            } else {
                html += '<td>' + item.dateComplete_Str + '<br />' + '<p style="font-weight: 600; text-align: right; color: blue; font-family: initial;">' + item.timeCompele.hours + ':' + item.timeCompele.minutes + '</p>' + '</td>';
            }
        }
        if (item.idAcceptPlan == 0 || item.idAcceptPlan == null) {
            html += '<td style="font-size: 11px; font-weight: 600; font-family: initial; color: blue; text-align: center;">' + not_received + '</td>';
        } else {
            html += '<td style="font-size: 11px; font-weight: 600; font-family: initial; color: red; text-align: center;">' + Received + '</td>';
        }
        switch (item.idStatus) {
            case 1:
                html += '<td>'
                        + '<div class="progress">' + 
                        '<div class="progress-bar bg-success" role ="progressbar" style ="width: 100%" aria-valuenow="100" aria-valuemin="0" aria-valuemax="100"></div>'
                    + '</div>'
                    + '<br />' + '<p style="font-weight: 600; text-align: center; color: green; font-family: initial;">' + item.nameStatus + '</p>'
                    + '</td>';
                break;
            case 2:
                html += '<td>'
                    + '<div class="progress">' +
                    '<div class="progress-bar bg-danger" role = "progressbar" aria-valuenow="0" aria-valuemin="0" aria-valuemax="100"></div>'
                    + '</div>'
                    + '<br />' + '<p style="font-weight: 600; text-align: center; color: red; font-family: initial;">' + item.nameStatus + '</p>'
                    + '</td>';
                break;
            case 3:
                html += '<td>'
                    + '<div class="progress">' +
                    '<div class="progress-bar bg-warning" role ="progressbar" style ="width: 5%" aria-valuenow="5" aria-valuemin="0" aria-valuemax="100"></div>'
                    + '</div>'
                    + '<br />' + '<p style="font-weight: 600; text-align: center; color: yellow; font-family: initial;">' + item.nameStatus + '</p>'
                    + '</td>';
                break;
            case 4:
                html += '<td>'
                    + '<div class="progress">' +
                    '<div class="progress-bar" role ="progressbar" style ="width: 25%" aria-valuenow="25" aria-valuemin="0" aria-valuemax="100"></div>'
                    + '</div>'
                    + '<br />' + '<p style="font-weight: 600; text-align: center; color: blue; font-family: initial;">' + item.nameStatus + '</p>'
                    + '</td>';
                break;
            case 5:
                html += '<td>'
                    + '<div class="progress">' +
                    '<div class="progress-bar bg-danger" role = "progressbar" style ="width: 1%" aria-valuenow="1" aria-valuemin="0" aria-valuemax="100"></div>'
                    + '</div>'
                    + '<br />' + '<p style="font-weight: 600; text-align: center; color: red; font-family: initial;">' + item.nameStatus + '</p>'
                    + '</td>';
                break;
            default:
                html += '<td style="text-align: center;">' + '----' + '</td>';
                break
        }
        if (item.timeUp == true) {
            html += '<td>'
                + '<button style="border: none; font-size: 10px;" data-bs-toggle="tooltip" data-bs-placement="right" title="' + View_task + '" type="button" class="btn btn-outline-secondary"><i class="fas fa-folder-open"></i></button>' +
                '</td>';
        } else {
            if (item.idAcceptPlan == 0 || item.idAcceptPlan == null) {
                html += '<td>'
                    + '<a href="/ManagerPlans/Page_DetailPlan/?IdPlan=' + item.idPlan + '" style="border: none; font-size: 10px;" data-bs-toggle="tooltip" data-bs-placement="right" title="' + View_task + '" class="btn btn-outline-secondary"><i class="fas fa-folder-open"></i></a>' +
                    '<button onclick="FunctionTakePlans(' + item.idPlan + ')" style="border: none; font-size: 10px;" data-bs-toggle="tooltip" data-bs-placement="right" title="' + Taking_mission + '" type="button" class="btn btn-outline-secondary"><i class="fas fa-check-circle"></i></button>' +
                    '<button onclick="FunctionCancelPlans(' + item.idPlan + ')" style="border: none; font-size: 10px;" data-bs-toggle="tooltip" data-bs-placement="right" title="' + Cancel_task + '" type="button" class="btn btn-outline-secondary"><i class="fas fa-window-close"></i></button>' +
                    '</td>';
            } else {
                html += '<td>'
                    + '<a href="/ManagerPlans/Page_DetailPlan/?IdPlan=' + item.idPlan + '" style="border: none; font-size: 10px;" data-bs-toggle="tooltip" data-bs-placement="right" title="' + View_task + '" class="btn btn-outline-secondary"><i class="fas fa-folder-open"></i></a>' +
                    '</td>';
            }
        }
        html += '</tr>';
        $("#Body_Data").append(html);
    })
    $("#ItemInPage").append(Page_Index);
    $("#TotalItem").append(count);
    //paing
    paging(totalPlan, function () {
        LoadPlansByIdUser();
    })
}

//----------------------------------------------
//paing
function paging(totalRoll, callback) {
    var totalPage = Math.ceil(totalRoll / Page_Size);
    $('#pagination').twbsPagination({
        totalPages: (totalPage == 0) ? 1 : totalPage,
        first: head,
        next: next,
        last: last,
        prev: Before,
        visiblePages: 10,
        onPageClick: function (event, page) {
            Page_Index = page;
            setTimeout(callback, 200);
        }
    });
}


//take plan
var GetPlan;
function FunctionTakePlans(IdPlan) {
    if (IdPlan != 0) {
        GetPlan = IdPlan;
        $("#modal_ShowPlan").show();
    } else {
        toastr.error(passed_match, Notification_Error);
    }
    return;
}
$("#btn_TakePlan").click(function () {
    $("#modal_LoadingCreateMusic").show();
    $("#modal_ShowPlan").hide();
    $.ajax({
        url: "/ManagerPlans/TakePlansByIdUser",
        type: "post",
        data: {
            IdPlan: GetPlan
        },
        success: function (result) {
            $("#modal_LoadingCreateMusic").hide();
            switch (result.idNotification) {
                case 0:
                    toastr.error(NotFindStaff, Notification_Error);
                    break;
                case 1:
                    toastr.error(Notaskwith_codefound, Notification_Error);
                    break;
                case 2:
                    toastr.success(Successfultask_received, Nofitication_Success);
                    LoadPlansByIdUser();
                    break;
                case 3:
                    toastr.error(EmployeeCode_Invalid, Notification_Error);
                    break;
                case 4:
                    break;
                default:
                    break;
            }
            return;
        }
    })
});
//close plan
$("#btn_closePlan").click(function () {
    $("#modal_ShowPlan").hide();
    GetPlan = 0;
    LoadPlansByIdUser()
});
$("#btn_CancelPlan").click(function () {
    $("#modal_ShowPlan").hide();
    GetPlan = 0;
    LoadPlansByIdUser()
});

//cancel plan
var IdPlan_Get
function FunctionCancelPlans(IdPlan) {
    if (IdPlan != 0) {
        IdPlan_Get = IdPlan;
        $("#modal_ShowCancelPlan").show();
    } else {
        toastr.error(passed_match, Notification_Error);
    }
    return;
}

$("#btn_1CancelPlan").click(function () {
    var Get_Content = $("#ContentTxt").val();
    if (Get_Content.length == 0) {
        toastr.error(Pleaseenter_accepttask, Notification_Error);
        return;
    }
    if (IdPlan_Get == 0) {
        toastr.error(passed_match, Notification_Error);
    } else {
        $.ajax({
            url: "/ManagerPlans/CancelPLanByIdUser",
            type: "post",
            data: {
                IdPlan: IdPlan_Get,
                Content: $("#ContentTxt").val()
            },
            success: function (result) {
                switch (result.idNotification) {
                    case 0:
                        toastr.error(NotFindStaff, Notification_Error);
                        break;
                    case 1:
                        toastr.error(Notaskwith_codefound, Notification_Error);
                        break;
                    case 2:
                        $("#modal_ShowCancelPlan").hide();
                        toastr.success(Failedaccepttask_successfully, Nofitication_Success);
                        LoadPlansByIdUser()
                        break;
                    case 3:
                        toastr.error(passed_match, Notification_Error);
                        break;
                }
                return;
            }
        })
    }
});

$("#btn_2CancelPlan").click(function () {
    IdPlan_Get = 0;
    $("#modal_ShowCancelPlan").hide();
    LoadPlansByIdUser()
});

//funtion load amount notification plan for admin
function LoadAmountNotificationPlan() {
    $("#TotalNotificationPlan").empty();
    $.ajax({
        url: "/ManagerPlans/AmountNotificationPlans",
        type: "get",
        success: function (result) {
            $("#TotalNotificationPlan").append('(' + result + ')');
            return;
        }
    })
}

//funtion fuilter date create plan
$("#rangeDate").flatpickr({
    mode: 'range',
    dateFormat: "Y-m-d"
});

$("#Btn_FulterDate").click(function () {
    $("#modal_FuliterDate").show();
})

// date create
var String_DateCreate = null;
$("#Btn_FuilterDateTime").click(function () {
    String_DateCompelete = null;
    String_DateCreate = $("#rangeDate").val();
    LoadPlansByIdUser();
    $("#modal_FuliterDate").hide();
    return;
})

//date compelete
var String_DateCompelete = null;
$("#Btn_FuilterDateCompelete").click(function () {
    String_DateCreate = null;
    String_DateCompelete = $("#rangeDate").val();
    LoadPlansByIdUser();
    $("#modal_FuliterDate").hide();
    return;
})

$("#BtnCloseFulter").click(function () {
    window.location.reload();
});

//const allowDrinksRadio = document.getElementById("checkbox_1");
//const drinkSelect = document.getElementById("rangeDate");

//allowDrinksRadio.addEventListener("change", (event) => {
//    drinkSelect.disabled = !event.target.checked;
//}, false);

//select plans by status
$("#Btn_SelectStatus").click(function () {
    $.ajax({
        url: "/ManagerPlans/GetAllStatusPlan",
        type: "get",
        success: function (result) {
            $("#Select_Status").empty();
            var htmlDefault = '';
            htmlDefault += '<option selected>' + Choose_Status + '</option>';
            $("#Select_Status").append(htmlDefault);
            $.each(result, function (key, item) {
                var html = '';
                html += '<option value="' + item.id + '">' + item.nameStatus + '</option>';
                $("#Select_Status").append(html);
            })
            $("#modal_SelectStatusPlan").show();
        }
    })
})
$("#Btn_CloseSelectStatus").click(function () {
    window.location.reload();
    IdStatus = null;
});

var IdStatus = null;
$("#Btn_SeachStatus").click(function () {
    IdStatus = $("#Select_Status").val();
    LoadPlansByIdUser();
    $("#modal_SelectStatusPlan").hide();
    return;
})

//reomve plans
function funtionRemovePlan(IdPlan) {
    $("#modal_LoadingCreateMusic").show();
    $.ajax({
        url: "/ManagerPlans/ReomvePlan",
        type: "post",
        data: {
            IdPlan: IdPlan
        },
        success: function (result) {
            $("#modal_LoadingCreateMusic").hide();
            switch (result.idNotification) {
                case 0:
                    toastr.error(Notaskwith_codefound, Notification_Error);
                    break;
                case 1:
                    toastr.success(Cleartask_successfully, Nofitication_Success);
                    LoadPlansByIdUser();
                    break;
                case 2:
                    toastr.error(passed_match, Notification_Error);
                    break;
            }
            return;
        }
    })
};
