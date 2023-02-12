var head = $("#head").val();
var next = $("#next").val();
var last = $("#last").val();
var Before = $("#Before").val();
var Notification_Error = $("#Notification_Error").val();
var Nofitication_Success = $("#Nofitication_Success").val();
var Notaskwith_codefound = $("#Notaskwith_codefound").val();
var not_received = $("#not_received").val();
var Received = $("#Received").val();
var Cancelled = $("#Cancelled").val();
var Thetask_expired = $("#Thetask_expired").val();
var Thetask_expiredyet = $("#Thetask_expiredyet").val();
var Havendone_yet = $("#Havendone_yet").val();
var Dowload = $("#Dowload").val();
var Edit_files = $("#Edit_files").val();
var Tasktitle_empty = $("#Tasktitle_empty").val();
var Contenttask_empty = $("#Contenttask_empty").val();
var Updatetask_successfully = $("#Updatetask_successfully").val();
var NotFindStaff = $("#NotFindStaff").val();
var notHave_Role = $("#notHave_Role").val();
var File_mismatch = $("#File_mismatch").val();
var Edit_File = $("#Edit_File").val();
var Sytstem_File = $("#Sytstem_File").val();
var Select_Dates = $("#Select_Dates").val();
var Select_Time = $("#Select_Time").val();
var NotFind_Info = $("#NotFind_Info").val();
var Renewaldate_EndDate = $("#Renewaldate_EndDate").val();
var UpdateDate_TimeSucc = $("#UpdateDate_TimeSucc").val();
var Assign_Task = $("#Assign_Task").val();
var task_assigned = $("#task_assigned").val();
var Assignsuccessful_tasks = $("#Assignsuccessful_tasks").val();
var EmployeeCode_Invalid = $("#EmployeeCode_Invalid").val();
var Complete_Task = $("#Complete_Task").val();
var DownloadFile_Successfully = $("#DownloadFile_Successfully").val();
var Unable_download = $("#Unable_download").val();

$(document).ready(function () {
    LoadDataDetail();
});

//load data detail plan
function LoadDataDetail() {
    $.ajax({
        url: "/ManagerPlans/DetailPlanByIdUser",
        type: "get",
        data: {
            IdPlan: $("#IdPlan").val()
        },
        success: function (result) {
            console.log(result);
            switch (result.nameRole) {
                case "AD":
                    LoadDataDetail_AD(result.detailPlan);
                    break;
                case "NV":
                    LoadDataDetail_NV(result.detailPlan);
                    break;
                default:
                    toastr.error(Notaskwith_codefound, Notification_Error);
                    break;
            }
            return;
        }
    })
}

function LoadDataDetail_AD(Item_Data) {
    $("#TxtNamePlan").empty();
    $("#TxtNamePlan").append(Item_Data.titlePlan);
    $("#TxtZipCode").val(Item_Data.idPlan);
    $("#StaffPlan").val(Item_Data.nameUserPlan);
    $("#AdminRequest").val(Item_Data.nameUserRequest);
    $("#TxtDateCreate").val(Item_Data.dateCreate_Str);
    $("#TxtDateTimeUp").val(Item_Data.dateComplete_Str);
    if (Item_Data.timeCompele.minutes == 0) {
        $("#TxtTimeUp").val(Item_Data.timeCompele.hours + ':0' + Item_Data.timeCompele.minutes);
    } else {
        $("#TxtTimeUp").val(Item_Data.timeCompele.hours + ':' + Item_Data.timeCompele.minutes);
    }
    $("#TxtContentPlan").val(Item_Data.contentPlan);

    switch (Item_Data.idAcceptPlan) {
        case 0:
            document.getElementById("TxtStatusPlan").style.color = "blue";
            $("#TxtStatusPlan").val(not_received);
            break;
        case 1:
            document.getElementById("TxtStatusPlan").style.color = "green";
            $("#TxtStatusPlan").val(Received);
            break;
        case 2:
            document.getElementById("TxtStatusPlan").style.color = "red";
            $("#TxtStatusPlan").val(Cancelled);
            break;
    }

    if (Item_Data.timeUp == true) {
        document.getElementById("TxtNameTimeUp").style.color = "red";
        $("#TxtNameTimeUp").val(Thetask_expired);
    } else {
        document.getElementById("TxtNameTimeUp").style.color = "blue";
        $("#TxtNameTimeUp").val(Thetask_expiredyet);
    }

    $("#ProgessDataPlan").empty();
    var html = '';
    switch (Item_Data.idStatus) {
        case 1:
            $("#TxtProgressing").val(Item_Data.nameStatus);
            html += '<div class="progress-bar bg-success" role="progressbar" style="width: 100%;" aria-valuenow="100" aria-valuemin="0" aria-valuemax="100">100%</div>';
            break;
        case 2:
            $("#TxtProgressing").val(Item_Data.nameStatus);
            html += '<div class="progress-bar bg-danger" role="progressbar" style="width: 5%;" aria-valuenow="5" aria-valuemin="0" aria-valuemax="100">5%</div>';
            break;
        case 3:
            $("#TxtProgressing").val(Item_Data.nameStatus);
            html += '<div class="progress-bar bg-warning" role="progressbar" style="width: 20%;" aria-valuenow="20" aria-valuemin="0" aria-valuemax="100">20%</div>';
            break;
        case 4:
            $("#TxtProgressing").val(Item_Data.nameStatus);
            html += '<div class="progress-bar" role="progressbar" style="width: 50%;" aria-valuenow="50" aria-valuemin="0" aria-valuemax="100">50%</div>';
            break;
        case 5:
            $("#TxtProgressing").val(Havendone_yet);
            html += '<div class="progress-bar" role="progressbar" style="width: 0%;" aria-valuenow="0" aria-valuemin="0" aria-valuemax="100">0%</div>';
            break;
        default:
            $("#TxtProgressing").val(Havendone_yet);
            html += '<div class="progress-bar" role="progressbar" style="width: 0%;" aria-valuenow="0" aria-valuemin="0" aria-valuemax="100">0%</div>';
            break;
    }
    $("#ProgessDataPlan").append(html);
    $("#Body_Data").empty();
    var count = 0;
    $.each(Item_Data.l_FilePlans, function (key, item) {
        var htmlTable = '';
        count++;
        htmlTable += '<tr>';
        htmlTable += '<th scope="row">' + count + '</th>';
        htmlTable += '<td>' + item.nameFile + '</td>';
        htmlTable += '<td>' + item.dateCreate_Str + '</td>';
        htmlTable += '<td>' + item.typeFile + '</td>';
        htmlTable += '<td>'
            + '<button onclick="FunctionDowLoadFile(' + item.id + ')" style="background: none; color: black;" type="button" class="btn btn-secondary" data-bs-toggle="tooltip" data-bs-placement="right" title="' + Dowload + '">'
                    + '<i class="fas fa-download" ></i >' + '</button >';
                    + '</td>';
        htmlTable += '</tr>';
        $("#Body_Data").append(htmlTable);
    })
    
}

function LoadDataDetail_NV(Item_Data) {
    document.getElementById('Btn_EditPlan').style.display = 'none';
    document.getElementById('Btn_EditDateTime').style.display = 'none';
    document.getElementById('Btn_UserPlan').style.display = 'none';
    $("#TxtNamePlan").empty();
    $("#TxtNamePlan").append(Item_Data.titlePlan);
    $("#TxtZipCode").val(Item_Data.idPlan);
    $("#StaffPlan").val(Item_Data.nameUserPlan);
    $("#AdminRequest").val(Item_Data.nameUserRequest);
    $("#TxtDateCreate").val(Item_Data.dateCreate_Str);
    $("#TxtDateTimeUp").val(Item_Data.dateComplete_Str);
    if (Item_Data.timeCompele.minutes == 0) {
        $("#TxtTimeUp").val(Item_Data.timeCompele.hours + ':0' + Item_Data.timeCompele.minutes);
    } else {
        $("#TxtTimeUp").val(Item_Data.timeCompele.hours + ':' + Item_Data.timeCompele.minutes);
    }
    $("#TxtContentPlan").val(Item_Data.contentPlan);

    switch (Item_Data.idAcceptPlan) {
        case 0:
            document.getElementById("TxtStatusPlan").style.color = "blue";
            $("#TxtStatusPlan").val(not_received);
            break;
        case 1:
            document.getElementById("TxtStatusPlan").style.color = "green";
            $("#TxtStatusPlan").val(Received);
            break;
        case 2:
            document.getElementById("TxtStatusPlan").style.color = "red";
            $("#TxtStatusPlan").val(Cancelled);
            break;
    }

    if (Item_Data.timeUp == true) {
        document.getElementById("TxtNameTimeUp").style.color = "red";
        $("#TxtNameTimeUp").val(Thetask_expired);
    } else {
        document.getElementById("TxtNameTimeUp").style.color = "blue";
        $("#TxtNameTimeUp").val(Thetask_expiredyet);
    }

    $("#ProgessDataPlan").empty();
    var html = '';
    switch (Item_Data.idStatus) {
        case 1:
            document.getElementById('Btn_EditPlan').style.display = 'none';
            document.getElementById('Btn_EditDateTime').style.display = 'none';
            document.getElementById('Btn_UserPlan').style.display = 'none';
            $("#TxtProgressing").val(Item_Data.nameStatus);
            html += '<div class="progress-bar bg-success" role="progressbar" style="width: 100%;" aria-valuenow="100" aria-valuemin="0" aria-valuemax="100">100%</div>';
            break;
        case 2:
            $("#TxtProgressing").val(Item_Data.nameStatus);
            html += '<div class="progress-bar bg-danger" role="progressbar" style="width: 5%;" aria-valuenow="5" aria-valuemin="0" aria-valuemax="100">5%</div>';
            break;
        case 3:
            $("#TxtProgressing").val(Item_Data.nameStatus);
            html += '<div class="progress-bar bg-warning" role="progressbar" style="width: 20%;" aria-valuenow="20" aria-valuemin="0" aria-valuemax="100">20%</div>';
            break;
        case 4:
            if (Item_Data.timeUp == false) { document.getElementById('btnSucessPlan').style.display = 'block'; }
            $("#TxtProgressing").val(Item_Data.nameStatus);
            html += '<div class="progress-bar" role="progressbar" style="width: 50%;" aria-valuenow="50" aria-valuemin="0" aria-valuemax="100">50%</div>';
            break;
        case 5:
            $("#TxtProgressing").val(Havendone_yet);
            html += '<div class="progress-bar" role="progressbar" style="width: 0%;" aria-valuenow="0" aria-valuemin="0" aria-valuemax="100">0%</div>';
            break;
        default:
            $("#TxtProgressing").val(Havendone_yet);
            html += '<div class="progress-bar" role="progressbar" style="width: 0%;" aria-valuenow="0" aria-valuemin="0" aria-valuemax="100">0%</div>';
            break;
    }
    $("#ProgessDataPlan").append(html);
    $("#Body_Data").empty();
    var count = 0;
    $.each(Item_Data.l_FilePlans, function (key, item) {
        var htmlTable = '';
        count++;
        htmlTable += '<tr>';
        htmlTable += '<th scope="row">' + count + '</th>';
        htmlTable += '<td>' + item.nameFile + '</td>';
        htmlTable += '<td>' + item.dateCreate_Str + '</td>';
        htmlTable += '<td>' + item.typeFile + '</td>';
        htmlTable += '<td>'
            + '<button onclick="FunctionDowLoadFile(' + item.id + ')" style="background: none; color: black;" type="button" class="btn btn-secondary" data-bs-toggle="tooltip" data-bs-placement="right" title="' + Dowload + '">'
            + '<i class="fas fa-download" ></i >' + '</button >';
        + '</td>';
        htmlTable += '</tr>';
        $("#Body_Data").append(htmlTable);
    })

}

//update plan by admin
$("#Btn_EditPlan").click(function () {
    $.ajax({
        url: "/ManagerPlans/UpdatePlanAdmin_Get",
        type: "get",
        data: {
            IdPlan: $("#TxtZipCode").val()
        },
        success: function (result) {
            $("#ModalShowUpdatePlan").show();
            $("#TxtIdPlan_Update").val(result.idPlan);
            $("#TxtTitlePlan_Update").val(result.namePlan);
            $("#TxtContentPlan_Update").val(result.contentPlan);
            $("#TxtBodyUpdate_Plan").empty();
            var count = 0;
            $.each(result.l_FilePlans, function (key, item) {
                count++;
                var html = '';
                html += '<tr id=' + item.id + '>';
                html += '<th scope="row">' + item.id + '</th>';
                html += '<td>' + '<p id="UpdateNameFile' + item.id +'">' + item.nameFile + '</p>' + '</td>';
                html += '<td>' + '<p id="UpdateTypeFile' + item.id + '">' + item.typeFile + '</p>' + '</td>';
                html += '<td>' + '<p id="UpdateDateFile' + item.id + '">' + item.dateCreate_Str + '</p>' + '</td>';
                html += '<td>'
                    + '<button onclick="FuntionUpdateFile(' + item.id + ')" style="background: none; color: black;" type="button" class="btn btn-secondary" data-bs-toggle="tooltip" data-bs-placement="right" title="' + Edit_files + '"><i class="fas fa-file"></i></button>'
                    + '<i style="display: none; color: green;" id="SticketCheck' + item.id +'" class="fas fa-check"></i>'
                    + '</td>';
                html += '</tr>';
                $("#TxtBodyUpdate_Plan").append(html);
            })
        }
    })
})

$("#CloseUpdatePlan").click(function () {
    LoadDataDetail();
    $("#ModalShowUpdatePlan").hide();
})

$("#btnUpdate_Plan").click(function () {
    var Id = $("#TxtIdPlan_Update").val();
    var Title = $("#TxtTitlePlan_Update").val();
    var Content = $("#TxtContentPlan_Update").val();
    if (Title.length == 0) {
        toastr.error(Tasktitle_empty, Notification_Error);
        return;
    }
    if (Content.length == 0) {
        toastr.error(Contenttask_empty, Notification_Error);
        return;
    }
    $("#modal_LoadingCreateMusic").show();
    $.ajax({
        url: "/ManagerPlans/UpdatePlanAdmin_Post",
        type: "post",
        data: {
            IdPlan: Id,
            TitlePlan: Title,
            ContentPlan: Content
        },
        success: function (result) {
            $("#modal_LoadingCreateMusic").hide();
            switch (result.idNotification) {
                case 0:
                    toastr.error(Notaskwith_codefound, Notification_Error);
                    break;
                case 1:
                    toastr.success(Updatetask_successfully, Nofitication_Success);
                    $("#ModalShowUpdatePlan").hide();
                    LoadDataDetail();
                    break;
                case 2:
                    toastr.error(Notaskwith_codefound + " , " + NotFindStaff, Notification_Error);
                    break;
                case 3:
                    toastr.error(NotFindStaff, Notification_Error);
                    break;
                case 4:
                    toastr.error(notHave_Role, Notification_Error);
                    break;
            }
            return;
        }
    })
});

//funtion update file
var IdPlan_UpdateFile;
function FuntionUpdateFile(IdFile) {
    if (IdFile != 0) {
        IdPlan_UpdateFile = IdFile;
        $("#ModalShowUpdateFile").show();
    } else {
        toastr.error(File_mismatch, Notification_Error);
    }
    return;
}

$("#BtnUpdate_File").click(function () {
    var GetFile = $("#TxtUpdate_File").val();
    if (GetFile.length == 0) {
        toastr.error(Edit_File, Notification_Error);
    } else {
        var files = $("#TxtUpdate_File").prop("files")
        var formData = new FormData();
        for (var i = 0; i < files.length; i++) {
            formData.append("FileUpdate", files[i]);
        }
        var Plan = {
            Id: IdPlan_UpdateFile
        }
        formData.append("IdPlan_Json", JSON.stringify(Plan));
        $.ajax({
            url: "/ManagerPlans/UpdateFile_Plan",
            type: "post",
            data: formData,
            contentType: false,
            processData: false,
            success: function (result) {
                switch (result.Id) {
                    case 0:
                        toastr.error(Sytstem_File, Notification_Error);
                        break;
                    default:
                        document.getElementById('SticketCheck' + IdPlan_UpdateFile).style.display = "initial";
                        var UpdateNameFile = 'UpdateNameFile' + IdPlan_UpdateFile;
                        var UpdateTypeFile = 'UpdateTypeFile' + IdPlan_UpdateFile;
                        var UpdateDateFile = 'UpdateDateFile' + IdPlan_UpdateFile;
                        $('#' + UpdateNameFile).empty();
                        $('#' + UpdateTypeFile).empty();
                        $('#' + UpdateDateFile).empty();
                        document.getElementById('UpdateNameFile' + IdPlan_UpdateFile).append(result.nameFile);
                        document.getElementById('UpdateTypeFile' + IdPlan_UpdateFile).append(result.typeFile);
                        document.getElementById('UpdateDateFile' + IdPlan_UpdateFile).append(result.dateCreate_Str);
                        $("#ModalShowUpdateFile").hide();
                        break;
                }
                return;
            }
        })
    }
});

$("#CloseUpdateFile").click(function () {
    $.ajax({
        url: "/ManagerPlans/CloseUpdateFile_Plan",
        type: "post",
        success: function (result) {
            LoadDataDetail();
            $("#ModalShowUpdateFile").hide();
        }
    })
})

//edit date time -------------------------------------------
$("#Btn_EditDateTime").click(function () {
    $("#ModalShowUpdateDateTime").show();
})
$("#CloseUpdateDateTime").click(function () {
    location.reload();
})

$("#BtnUpdate_DateTime").click(function () {
    var GetDate = $("#TxtUpdate_Date").val();
    var GetTime = $("#TxtUpdate_Time").val();
    var GetId = $("#TxtZipCode").val();
    if (GetDate.length == 0) {
        toastr.error(Select_Dates, Notification_Error)
        return;
    }
    if (GetTime.length == 0) {
        toastr.error(Select_Time, Notification_Error)
        return;
    }
    $("#modal_LoadingCreateMusic").show();
    $("#ModalShowUpdateDateTime").hide();
    $.ajax({
        url: "/ManagerPlans/UpdateDateTimePlan",
        type: "post",
        data: {
            IdPlan: GetId,
            DateRequest: GetDate,
            TimeRequest: GetTime
        },
        success: function (result) {
            $("#modal_LoadingCreateMusic").hide();
            switch (result.idNotification) {
                case 0:
                    toastr.error(Notaskwith_codefound, Notification_Error);
                    $("#ModalShowUpdateDateTime").show();
                    break;
                case 1:
                    toastr.error(NotFind_Info, Notification_Error);
                    $("#ModalShowUpdateDateTime").show();
                    break;
                case 2:
                    toastr.error(Renewaldate_EndDate, Notification_Error)
                    $("#ModalShowUpdateDateTime").show();
                    break;
                case 3:
                    toastr.success(UpdateDate_TimeSucc, Nofitication_Success);
                    $("#ModalShowUpdateDateTime").hide();
                    LoadDataDetail();
                    break;
                case 4:
                    toastr.error(Notaskwith_codefound + " , " + NotFindStaff, Notification_Error);
                    $("#ModalShowUpdateDateTime").show();
                    break;
            }
            return;
        }
    })
})

//role plan for staff
var PageIndex = 1;
var PageSize = 3;
$("#Btn_UserPlan").click(function () {
    $("#ModalShowRolePlanStaff").show();
    LoadGetAllStaff();
})

$("#CloseRolePlanStaff").click(function () {
    $("#ModalShowRolePlanStaff").hide();
    location.reload();
})

function LoadGetAllStaff() {
    $("#BodyUser").empty();
    $("#ItemInPage").empty();
    $("#TotalItem").empty();
    $("#TotalStaff").empty();
    var count = 0;
    $.ajax({
        url: "/ManagerPlans/GetAllStaffRolePlan",
        type: "get",
        data: {
            PageIndex: PageIndex,
            PageSize: PageSize,
            KeySeach: SeachKeyAll,
            IdPlan: $("#TxtZipCode").val()
        },
        success: function (result) {
            $.each(result.l_UserRolePlan, function (key, item) {
                count++;
                var Html = '';
                Html += '<tr id="' + item.idUser + '">';
                Html += '<th scope="row">' + item.idStaff + '</th>';
                Html += '<td>' + item.fullName + '</td>';
                switch (item.typeImage) {
                    case "JPG":
                        Html += '<td>' + '<img style="width: 70px;" src="data: image/JPG;base64, ' + item.avata + '"/>' + '</td>';
                        break;
                    case "jpg":
                        Html += '<td>' + '<img style="width: 70px;" src="data: image/jpg;base64, ' + item.avata + '"/>' + '</td>';
                        break;
                    case "JPEG":
                        Html += '<td>' + '<img style="width: 70px;" src="data: image/JPEG;base64, ' + item.avata + '"/>' + '</td>';
                        break;
                    case "jpeg":
                        Html += '<td>' + '<img style="width: 70px;" src="data: image/jpeg;base64, ' + item.avata + '"/>' + '</td>';
                        break;
                    case "PNG":
                        Html += '<td>' + '<img style="width: 70px;" src="data: image/PNG;base64, ' + item.avata + '"/>' + '</td>';
                        break;
                    case "png":
                        Html += '<td>' + '<img style="width: 70px;" src="data: image/png;base64, ' + item.avata + '"/>' + '</td>';
                        break;
                    case "GIF":
                        Html += '<td>' + '<img style="width: 70px;" src="data: image/GIF;base64, ' + item.avata + '"/>' + '</td>';
                        break;
                    case "gif":
                        Html += '<td>' + '<img style="width: 70px;" src="data: image/gif;base64, ' + item.avata + '"/>' + '</td>';
                        break;
                    default:
                        Html += '<td>Không có hình</td>';
                        break;
                }
                Html += '<td>' + item.roleName + '</td>';
                Html += '<td>' + item.totalPlanCurrent + '</td>';
                if (item.userCurrentPlan == true) {
                    Html += '<td>' + '<i class="fas fa-user-check" style="color: green;"></i>' + '</td>';
                } else {
                    Html += '<td>' + '<button name="EditRolePlanUser" style="background: none; color: black;" type="button" class="btn btn-secondary" data-bs-toggle="tooltip" data-bs-placement="right" title="' + Assign_Task + '"><i class="fas fa-plane-departure"></i></button>' + '</td>';
                }
                Html += '</tr>';
                $("#BodyUser").append(Html);
            })
            $("#ItemInPage").append(PageIndex);
            $("#TotalItem").append(count);
            $("#TotalStaff").append(result.totalUser);
            //paing
            paging(result.totalUser, function () {
                LoadGetAllStaff();
            })
        }
    })
}

$(document).on('click', 'button[name="EditRolePlanUser"]', function () {
    var IdUser = $(this).closest("tr").attr("id");
    $("#modal_LoadingCreateMusic").show();
    $.ajax({
        url: "/ManagerPlans/UpdateRolePlanUser",
        type: "post",
        data: {
            IdPlan: $("#TxtZipCode").val(),
            Iduser: IdUser
        },
        success: function (result) {
            $("#modal_LoadingCreateMusic").hide();
            switch (result.idNotification) {
                case 0:
                    toastr.error(Notaskwith_codefound, Notification_Error);
                    break;
                case 1:
                    toastr.error(NotFindStaff, Notification_Error);
                    break;
                case 2:
                    toastr.error(notHave_Role, Notification_Error);
                    break;
                case 3:
                    toastr.error(task_assigned, Notification_Error);
                    break;
                case 4:
                    toastr.success(Assignsuccessful_tasks, Nofitication_Success);
                    $("#ModalShowRolePlanStaff").hide();
                    LoadDataDetail();
                    break;
                case 5:
                    toastr.error(Notaskwith_codefound, Notification_Error);
                    break;
                case 6:
                    toastr.error(EmployeeCode_Invalid, Notification_Error);
                    break;
                case 7:
                    toastr.error(EmployeeCode_Invalid, Notification_Error);
                    break;
            }
            return;
        }
    })
})

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

var SeachKeyAll;
//seach name staff
$("#btn_SeachName").click(function () {
    SeachKeyAll = $("#TxtSeacdCodeOrName").val();
    LoadGetAllStaff()
})

// was success plan
$("#btnSucessPlan").click(function () {
    $("#modal_LoadingCreateMusic").show();
    $.ajax({
        url: "/ManagerPlans/SuccessPlanByStaff",
        type: "post",
        data: {
            IdPlan: $("#TxtZipCode").val()
        },
        success: function (result) {
            $("#modal_LoadingCreateMusic").hide();
            switch (result.idNotification) {
                case 0:
                    toastr.error(Notaskwith_codefound, Notification_Error)
                    break;
                case 1:
                    toastr.success(Complete_Task, Nofitication_Success)
                    $("#ModalShowRolePlanStaff").hide();
                    LoadDataDetail();
                    break;
                case 2:
                    toastr.error(Notaskwith_codefound, Notification_Error);
                    break;
            }
            return;
        }
    })
})

//dow load file plan
function FunctionDowLoadFile(IdFile) {
    $.ajax({
        url: "/ManagerPlans/CallDowloadFilePlan",
        type: "get",
        data: {
            IdFile: IdFile,
            IdPlan: $("#TxtZipCode").val()
        },
        success: function (result) {
            if (result == true) {
                toastr.success(DownloadFile_Successfully, Nofitication_Success);
                window.location = window.location.origin + '/ManagerPlans/DowloadFilePlan/?IdFile=' + IdFile;
            } else {
                toastr.error(Unable_download, Notification_Error);
            }
            return;
        }
    })
}

//reset detail plan
$("#Btn_Reload").click(function () {
    window.location.reload();
});