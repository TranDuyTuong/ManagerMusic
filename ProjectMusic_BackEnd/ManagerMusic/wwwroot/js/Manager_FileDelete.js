var head = $("#head").val();
var next = $("#next").val();
var last = $("#last").val();
var Before = $("#Before").val();
var Notification_Error = $("#Notification_Error").val();
var Nofitication_Success = $("#Nofitication_Success").val();
var NotfindMusic = $("#NotfindMusic").val();
var TotalMusic = $("#TotalMusic").val();
var WasFind = $("#WasFind").val();
var results = $("#results").val();
var selectline_back = $("#selectline_back").val();
var Employeeid_empty = $("#Employeeid_empty").val();
var ListMusic_Null = $("#ListMusic_Null").val();
var songcode_empty = $("#songcode_empty").val();
var errormusic_recovery = $("#errormusic_recovery").val();
var NotFind_Deletmusic = $("#NotFind_Deletmusic").val();
var recoverdeleted_successfully = $("#recoverdeleted_successfully").val();
var recoverdeletedA_successfully = $("#recoverdeletedA_successfully").val();
var Takeback_song = $("#Takeback_song").val();

$(document).ready(function () {
    document.getElementById('SeachMusic-Admin').style.display = 'none';
    document.getElementById('Modal_ShowSelectSumer').style.display = 'none';
    LoadDataMusic();
    Static_IdSelect = 0;
    Static_Seach = null;
});

var PageIndex = 1;
var PageSize = 20;
var Static_IdSelect = 0;
var Static_Seach = null;
//----------------------------------------
//function load data
function LoadDataMusic() {
    var count = 0;
    $("#titleNotification").empty();
    $("#body_Music").empty();
    $("#ItemInPage").empty();
    $("#TotalItem").empty();
    $("#TitleFindResult").empty();
    $.ajax({
        url: "/ManagerData/JsonGetAllMusicDelete",
        type: "get",
        data: {
            PageIndex: PageIndex,
            PageSize: PageSize,
            SelectSeason: Static_IdSelect,
            Seach: Static_Seach
        },
        success: function (result) {
            if (result.total == 0) {
                $("#titleNotification").append(TotalMusic + " " + result.total);
                toastr.error(NotfindMusic, Notification_Error);
            } else {
                $.each(result.l_Music, function (key, item) {
                    count++;
                    var html = "";
                    html += '<tr id="' + item.idMusic+ '">';
                    html += '<th scope="row">';
                    html += '<input type="checkbox" class="case" name="case" value="' + item.idMusic + '"/>';
                    html += '</th>';
                    html += '<td>' + item.noMusic + '</td>';
                    html += '<td>' + item.nameMusic + '</td>';
                    html += '<td>' + item.c_dateCreate + '</td>';
                    html += '<td>' + item.nameSeason + '</td>';
                    html += '<td>';
                    html += '<p style="font-family: inherit; color: red;">' + item.nameStatusMusic + '</p>';
                    html += '</td>';
                    html += '<td>';
                    html += '<button name="btn_RecoverMusic" style="border: none;" class="btn btn-outline-secondary" data-bs-toggle="tooltip" data-bs-placement="top" title="' + Takeback_song + '"><i class="fas fa-redo"></i></button>'
                    html += '</td>';
                    html += '</tr>';
                    $("#body_Music").append(html);
                })
                if (Static_IdSelect != 0 || Static_Seach != null) {
                    $("#TitleFindResult").append(WasFind + count + " " + results);
                }
                $("#TotalItem").append(result.total)
                $("#ItemInPage").append(count)
                //paing
                paging(result.total, function () {
                    LoadDataMusic();
                })
                $("#titleNotification").append(TotalMusic + " " + result.total);
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

//--------------------------------------------------------------
//checked
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

//--------------------------------------------------------------------
//show form seach music
$("#btn-ShowFormSeachMusic").click(function () {
    document.getElementById('SeachMusic-Admin').style.display = 'block';
});
//close form seach music
$("#btn-closeSeachMusic").click(function () {
    document.getElementById('SeachMusic-Admin').style.display = 'none';
});
//seach music
function eventSeachMusic() {
    var getdata = $("#TxtInputMusic").val();
    console.log(getdata);
}

//----------------------------------------------------------------
//funtion show html select option seach
$("#btn_ShowModalSelect").click(function () {
    document.getElementById('Modal_ShowSelectSumer').style.display = 'block';
});
$("#btn_closeModalSelect").click(function () {
    document.getElementById('Modal_ShowSelectSumer').style.display = 'none';
});

//-------------------------------------------------------------------
//funtion select season and seach muisc
$("#selectSeason").change(function () {
    var IdSeason = $("#selectSeason").val();
    Static_IdSelect = IdSeason;
    LoadDataMusic();
});

//-------------------------------------------------------
//funtion seach music
function eventSeachMusic() {
    Static_Seach = $("#TxtInputMusic").val();
    const myTimeout = setTimeout(LoadDataMusic, 1000);
}

//---------------------------------------------
//funtion recover list music delete
$("#btn_TakeCheckBox").click(function () {
    $("#modal_LoadingCreateMusic").show();
    var checkbox = document.getElementsByName('case');
    var myArrayActiver = new Array();
    for (var i = 0; i < checkbox.length; i++) {
        if (checkbox[i].checked === true) {
            var partNumber = checkbox[i].value;
            myArrayActiver.push(partNumber);
        }
    }
    if (myArrayActiver.length == 0) {
        $("#modal_LoadingCreateMusic").hide();
        toastr.error(selectline_back, Notification_Error);
    } else {
        $.ajax({
            url: "/ManagerData/JsonRecoverMusicDelete",
            type: "post",
            data: {
                L_IdMusic: myArrayActiver,
                flag: 1
            },
            success: function (result) {
                $("#modal_LoadingCreateMusic").hide();
                switch (result.isStatus) {
                    case 1:
                        toastr.error(ListMusic_Null, Notification_Error);
                        break;
                    case 2:
                        toastr.error(songcode_empty, Notification_Error);
                        break;
                    case 3:
                        toastr.error(NotFind_Deletmusic, Notification_Error);
                        break;
                    case 4:
                        location.reload();
                        toastr.success(recoverdeleted_successfully, Notification_Success);
                        break;
                    case 5:
                        location.reload();
                        toastr.success(recoverdeletedA_successfully, Notification_Success);
                        break;
                    case 6:
                        toastr.error(errormusic_recovery, Notification_Error);
                        break;
                    case 7:
                        //id user null
                        toastr.error(Employeeid_empty, Notification_Error);
                        break;
                }

            }
        })
    }
    return;
});

//funtion recover muisc
$(document).on('click', 'button[name="btn_RecoverMusic"]', function () {
    var IdMusic = $(this).closest("tr").attr("id");
    if (IdMusic.length == 0) {
        $("#modal_LoadingCreateMusic").hide();
        toastr.error(selectline_back, Notification_Error);
    } else {
        $.ajax({
            url: "/ManagerData/JsonRecoverMusicDelete",
            type: "post",
            data: {
                idMusic: IdMusic,
                flag: 2
            },
            success: function (result) {
                $("#modal_LoadingCreateMusic").hide();
                switch (result.isStatus) {
                    case 1:
                        toastr.error(ListMusic_Null, Notification_Error);
                        break;
                    case 2:
                        toastr.error(songcode_empty, Notification_Error);
                        break;
                    case 3:
                        toastr.error(NotFind_Deletmusic, Notification_Error);
                        break;
                    case 4:
                        location.reload();
                        toastr.success(recoverdeleted_successfully, Notification_Success);
                        break;
                    case 5:
                        location.reload();
                        toastr.success(recoverdeletedA_successfully, Notification_Success);
                        break;
                    case 6:
                        toastr.error(errormusic_recovery, Notification_Error);
                        break;
                    case 7:
                        //id user null
                        toastr.error(Employeeid_empty, Notification_Error);
                        break;
                }

            }
        })
    }
    return;
});

