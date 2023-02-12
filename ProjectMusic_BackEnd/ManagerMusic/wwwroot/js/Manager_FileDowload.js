var PageIndex = 1;
var PageSize = 20;
var SeachData = null;
var Staff = $("#Staff").val();
var User = $("#User").val();
var head = $("#head").val();
var next = $("#next").val();
var last = $("#last").val();
var Before = $("#Before").val();
var Notification_Error = $("#Notification_Error").val();
var Nofitication_Success = $("#Nofitication_Success").val();
var TickRow_DeleteMusicDowload = $("#TickRow_DeleteMusicDowload").val();
var Null_ListDowloadMusic = $("#Null_ListDowloadMusic").val();
var Notfind_ListDowloadMusic = $("#Notfind_ListDowloadMusic").val();
var Delete_ListMusicDowloadSuccess = $("#Delete_ListMusicDowloadSuccess").val();
var DeleteDowload_musicError = $("#DeleteDowload_musicError").val();
var HistoryDowloadMusic_Success = $("#HistoryDowloadMusic_Success").val();
var ViewDetail = $("#ViewDetail").val();
var Remove_downloads = $("#Remove_downloads").val();

$(document).ready(function () {
    LoadDataDowload();
    SeachData = null;
});

//load data
function LoadDataDowload() {
    $("#body_Data").empty();
    $("#TotalDowload").empty();
    $("#ItemInPage").empty();
    $("#TotalItem").empty();
    var count = 0;
    $.ajax({
        url: "/ManagerData/JsonGetAllFileDowload",
        type: "post",
        data: {
            pageSize: PageSize,
            pageIndex: PageIndex,
            SeachKey: SeachData
        },
        success: function (result) {
            if (result.total == 0) {
                $("#TotalDowload").append(count);
            } else {
                $.each(result.l_Dowload, function (key, item) {
                    count++;
                    var html = "";
                    html += '<tr id="' + item.id + '">';
                    html += '<th scope="row">';
                    html += '<input type="checkbox" class="case" name="case" value="' + item.id + '"/>';
                    html += '</th>';
                    html += '<td>' + count + '</td>';
                    html += '<td style="color:red; font-weight: 600;" >' + item.noMusic + '</td>';
                    html += '<td>' + item.nameMusic + '</td>';
                    html += '<td>' + item.fullName + '</td>';
                    html += '<td>' + item.dateDowload + '</td>';
                    html += '<td>';
                    if (item.idStaff != null) {
                        html += '<p style="font-family: inherit; text-align: center; font-weight: 600; color: green;">';
                        html += '<i class="fas fa-user-cog"></i>' + " - " + Staff;
                        html += '</p>';
                    } else {
                        html += '<p style="font-family: inherit; text-align: center; font-weight: 600; color: red;">';
                        html += '<i class="fas fa-user"></i>' + " - " + User;
                        html += '</p>';
                    }
                    html += '</td>';
                    html += '<td>';
                    html += '<a onclick="DeleteADowloadMusic(' + item.id + ')" style="border: none;" class="btn btn-outline-secondary" ata-bs-toggle="tooltip" data-bs-placement="top" title="' + Remove_downloads + '"><i class="fas fa-backspace"></i></a>';
                    html += '<a onclick="DetailADowloadMusic(' + item.id + ')" style="border: none;" class="btn btn-outline-secondary" ata-bs-toggle="tooltip" data-bs-placement="top" title="' + ViewDetail + '"><i class="fas fa-folder-open"></i></a>';
                    html += '</td>';
                    html += '</tr>';
                    $("#body_Data").append(html);
                })
                $("#TotalItem").append(result.total)
                $("#ItemInPage").append(count)
                $("#TotalDowload").append(count);
                //paing
                paging(result.total, function () {
                    LoadDataDowload();
                })
            }
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

//-------------------------------------------
//seach
function AutoSeachData() {
    SeachData = $("#TxtSeachData").val();
    var timeout = setTimeout(LoadDataDowload, 1000);
}

//--------------------------------------------
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

//delete list dowload music
$("#Btn_DeleteDowLoadMusic").click(function () {
    $("#modal_LoadingCreateMusic").show();
    var checkbox = document.getElementsByName('case');
    var myArrayActiver = new Array();
    for (var i = 0; i < checkbox.length; i++) {
        if (checkbox[i].checked === true) {
            var partNumber = Number(checkbox[i].value);
            myArrayActiver.push(partNumber);
        }
    }
    if (myArrayActiver.length == 0) {
        $("#modal_LoadingCreateMusic").hide();
        toastr.error(TickRow_DeleteMusicDowload, Notification_Error);
    } else {
        $.ajax({
            url: "/ManagerData/JsonDeleteDowloadMusic",
            type: "post",
            data: {
                L_Music: myArrayActiver
            },
            success: function (result) {
                $("#modal_LoadingCreateMusic").hide();
                switch (result.isStatus) {
                    case 1:
                        toastr.error(Notfind_ListDowloadMusic, Notification_Error);
                        break;
                    case 2:
                        toastr.success(Delete_ListMusicDowloadSuccess, Nofitication_Success);
                        LoadDataDowload();
                        break;
                    case 3:
                        toastr.error(Null_ListDowloadMusic, Notification_Error);
                        break;
                    case 5:
                        toastr.error(DeleteDowload_musicError, Notification_Error);
                }
            }
        })
    }
    return;

});

//delete a item dowload music
function DeleteADowloadMusic(IdDowload) {
    $.ajax({
        url: "/ManagerData/JsonDeleteDowloadMusic",
        type: "post",
        data: {
            IdDowload: IdDowload
        },
        success: function (result) {
            switch (result.isStatus) {
                case 1:
                    toastr.error(Notfind_ListDowloadMusic, Notification_Error);
                    break;
                case 4:
                    toastr.success(HistoryDowloadMusic_Success, Nofitication_Success);
                    LoadDataDowload();
                    break;
                case 3:
                    toastr.error(Null_ListDowloadMusic, Notification_Error);
                    break;
                case 5:
                    toastr.error(DeleteDowload_musicError, Notification_Error);
            }
            return;
        }
    })
}

//------------------------------------
//funtion detail dowload music
function DetailADowloadMusic(IdDowload) {
    $("#ModalShowDetailDowloadMusic").show();
    $.ajax({
        url: "/ManagerData/JsonDetailDowloadMusic",
        type: "get",
        data: {
            IdDowload: IdDowload
        },
        success: function (result) {
            console.log(result);
            $("#TxtId").val(result.id);
            $("#TxtNoMusic").val(result.noMusic);
            $("#TxtNameMusic").val(result.nameMusic);
            $("#TxtAuthor").val(result.author);
            $("#TxtNameUser").val(result.fullName);
            if (result.idStaff != null) {
                $("#TxtStaff_User").val(Staff);
            } else {
                $("#TxtStaff_User").val(User);
            }
            $("#TxtDateDowload").val(result.dateDowload);
            $("#TxtTimeDowload").val(result.timeDowload);
            $("#AvataImageMusic").empty();
            var SetImage;
            switch (result.typeImage) {
                case "jpg":
                    SetImage = '<img src="data:image/jpg;base64,' + result.contentImage + '" style="width: auto; height: auto; margin-left: 10%;"/>';
                    break;
                case "PNG":
                    SetImage = '<img src="data:image/PNG;base64,' + result.contentImage + '" style="width: auto; height: auto; margin-left: 10%;"/>';
                    break;
                case "JPG":
                    SetImage = '<img src="data:image/JPG;base64,' + result.contentImage + '" style="width: auto; height: auto; margin-left: 10%;"/>';
                    break;
            }
            $("#AvataImageMusic").append(SetImage);
            return;
        }
    })
};

$("#CloseDowloadDetailMusic").click(function () {
    $("#ModalShowDetailDowloadMusic").hide();
})