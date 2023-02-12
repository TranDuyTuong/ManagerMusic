//value
var setDataCheck;
var setDataCheckActiver;
var PageSize = 15;
var PageIndex = 1;
var NotfindMusic = $("#NotfindMusic").val();
var TotalMusic = $("#TotalMusic").val();
var head = $("#head").val();
var next = $("#next").val();
var last = $("#last").val();
var Before = $("#Before").val();
var ViewDetailSong = $("#ViewDetailSong").val();
var NotFindInfothis_Music = $("#NotFindInfothis_Music").val();
var Notification_Error = $("#Notification_Error").val();
var Nofitication_Success = $("#Nofitication_Success").val();
var Employeeid_empty = $("#Employeeid_empty").val();
var DeleteErorr = $("#DeleteErorr").val();
var DeleteSuccess = $("#DeleteSuccess").val();
var DeleteMiptiMusic = $("#DeleteMiptiMusic").val();
var ticksong_changestatus = $("#ticksong_changestatus").val();
var ListMusic_Null = $("#ListMusic_Null").val();
var NotFindListMusic_Anactiver = $("#NotFindListMusic_Anactiver").val();
var Activer_Success = $("#Activer_Success").val();
var selectstatus_filter = $("#selectstatus_filter").val();
var select_status = $("#select_status").val();

var Static_IdSelect = 0;
var Static_Seach;
var Select_Status = 0;
var Sort_No = 1



//loading data
$(document).ready(function () {
    $("#modal-ShowChooseOption").hide();
    $("#modal-ShowChooseActiverFile").hide();
    document.getElementById('SeachMusic-Admin').style.display = 'none';
    document.getElementById('Modal_ShowSelectSumer').style.display = 'none';
    GetAllMusic();
    Static_IdSelect = 0;
    Static_Seach = null;
    Select_Status = 0;
    Sort_No = 1;
    Count_No = 0;
});

//GetAll Music
function GetAllMusic() {
    var count = 0;
    $("#titleNotification").empty();
    $("#body_Music").empty();
    $("#ItemInPage").empty();
    $("#TotalItem").empty();
    $.ajax({
        url: "/ManagerData/Json_Music",
        type: "get",
        data: {
            PageSize: PageSize,
            PageIndex: PageIndex,
            IdSeason: Static_IdSelect,
            SeachKey: Static_Seach,
            IdStatus: Select_Status,
            Sort_No: Sort_No
        },
        success: function (result) {
            if (result.total == 0) {
                $("#titleNotification").append(NotfindMusic);
            } else {
                $.each(result.l_Music, function (key, item) {
                    count++;
                    var html = ""
                    html += '<tr>';
                    html += '<th scope="row">';
                    html += '<input type="checkbox" class="case" name="case" value="' + item.idMusic + '"/>';
                    html += '</th>';
                    html += '<td>' + item.noMusic + '</td>';
                    html += '<td>' + item.nameMusic + '</td>';
                    html += '<td>' + item.c_dateCreate + '</td>';
                    html += '<td>' + item.nameSeason + '</td>';
                    html += '<td>';
                    if (item.idStatusMusic == 1) {
                        html += '<p style="font-family: inherit; color: green;">' + item.nameStatusMusic + '</p>';
                    } else {
                        html += '<p style="font-family: inherit; color: red;">' + item.nameStatusMusic + '</p>';
                    }
                    html += '</td>';
                    html += '<td>';
                    html += '<a href="/ManagerData/DetailMusic/?IdMusic=' + item.idMusic + '" style="border: none;" class="btn btn-outline-secondary" ata-bs-toggle="tooltip" data-bs-placement="top" title="' + ViewDetailSong + '"><i class="fas fa-folder-open"></i></a>';
                    html += '</td>';
                    html += '</tr>';
                    $("#body_Music").append(html);
                });
                $("#TotalItem").append(PageIndex)
                $("#ItemInPage").append(count)
                //paing
                paging(result.total, function () {
                    GetAllMusic();
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

// show choose option data
$("#btn-ShowChooseOption").click(function () {
    $("#modal-ShowChooseOption").show();
});
$("#btn-closeChooseOption").click(function () {
    $("#modal-ShowChooseOption").hide();
});


//-----------------------------------------------------------------------
//show form seach music
$("#btn-ShowFormSeachMusic").click(function () {
    document.getElementById('SeachMusic-Admin').style.display = 'block';
});
//close form seach music
$("#btn-closeSeachMusic").click(function () {
    document.getElementById('SeachMusic-Admin').style.display = 'none';
});
//funtion seach music
function eventSeachMusic() {
    Static_Seach = $("#TxtInputMusic").val();
    const myTimeout = setTimeout(GetAllMusic, 1000);
}

//---------------------------------------------------------------------------
//show modal activer file
$("#btn-showModalActiverFile").click(function () {
    var checkbox = document.getElementsByName('case');
    var myArrayActiver = new Array();
    for (var i = 0; i < checkbox.length; i++) {
        if (checkbox[i].checked === true) {
            var partNumber = checkbox[i].value;
            myArrayActiver.push(partNumber);
        }
    }
    if (myArrayActiver.length == 0) {
        toastr.error(ticksong_changestatus, Notification_Error);
    } else {
        $("#modal-ShowChooseActiverFile").show();
    }
    return;

});
//funtion close activer file
$("#btn_closeactiver").click(function () {
    $("#modal-ShowChooseActiverFile").hide();
});
//funtion Anactiver file
$("#btn_Anactiver").click(function () {
    $("#modal-ShowChooseActiverFile").hide();
});
//funtion activer file
$("#btn_Activer").click(function () {
    $("#modal_LoadingCreateMusic").show();
    var checkbox = document.getElementsByName('case');
    var myArrayActiver = new Array();
    for (var i = 0; i < checkbox.length; i++) {
        if (checkbox[i].checked === true) {
            var partNumber = checkbox[i].value;
            myArrayActiver.push(partNumber);
        }
    }
    $.ajax({
        url: "/ManagerData/JsonActiverFile",
        type: "post",
        data: {
            L_IdMusic: myArrayActiver
        },
        success: function (result) {
            $("#modal_LoadingCreateMusic").hide();
            $("#modal-ShowChooseActiverFile").hide();
            switch (result.isStatus) {
                case 1:
                    toastr.error(NotFindListMusic_Anactiver, Notification_Error);
                    break;
                case 2:
                    toastr.success(Activer_Success, Nofitication_Success);
                    location.reload();
                    break;
                case 3:
                    toastr.error(ListMusic_Null, Notification_Error);
                    break;
            }
            return;
        }
    })
    return;
})

//--------------------------------------------------------------------------
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

//funtion remove checkbox
$("#btn-RemoveCheckBox").click(function () {
    $("#modal_LoadingCreateMusic").show();
    var myArray = new Array();
    var checkbox = document.getElementsByName('case');
    for (var i = 0; i < checkbox.length; i++) {
        if (checkbox[i].checked === true) {
            var partNumber = checkbox[i].value;
            myArray.push(partNumber);
        }
    }
    if (myArray.length == 0) {
        toastr.error(DeleteMiptiMusic, Notification_Error);
        return;
    } else {
        $.ajax({
            url: "/ManagerData/DeleteMusic",
            type: "post",
            data: {
                L_IdMuisc: myArray
            },
            success: function (result) {
                $("#modal_LoadingCreateMusic").hide();
                switch (result.isStatus) {
                    case 2:
                        toastr.error(Employeeid_empty, Notification_Error);
                        break;
                    case 3:
                        toastr.success(DeleteSuccess, Nofitication_Success);
                        location.reload();
                        break;
                    case 4:
                        toastr.error(DeleteErorr, Notification_Error);
                        break;
                    case 5:
                        toastr.error(Employeeid_empty, Notification_Error);
                        break;
                    case 6:
                        toastr.error(NotFindInfothis_Music, Notification_Error);
                        break;
                    default:
                }
                return;
            }
        })
    }
});

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
    GetAllMusic();
});


//-------------------------------------------------------------
//function filter status music
$("#btn_filterStatus").click(function () {
    $("#SelectStatus").empty();
    $.ajax({
        url: "/ManagerData/JsonGetAllStatusMusic",
        type: "get",
        success: function (result) {
            var htmldefault = '<option selected value="0">--' + selectstatus_filter + '--</option>';
            $("#SelectStatus").append(htmldefault);
            $.each(result, function (key, item) {
                var html = "";
                html += '<option value="' + item.idStatusMusic + '">' + item.name + '</option>';
                $("#SelectStatus").append(html);
            })
            $("#modalStatusMusic").show();
            return;
        }
    })
});

$("#CLoseModalStatus").click(function () {
    $("#modalStatusMusic").hide();
})

// function filter list music by id status
$("#btn_FilterData").click(function () {
    $("#TextFilter").empty();
    var get_D = $("#SelectStatus").val();
    var get_Text = $("#SelectStatus option:selected").text();
    if (get_D == 0) {
        toastr.error(select_status, Notification_Error);
    } else {
        $("#TextFilter").append(get_Text);
        Select_Status = get_D;
        var timeout = setTimeout(GetAllMusic, 1000);
        $("#modalStatusMusic").hide();
    }
    return;
});

//---------------------------------------------
//sort id music
$("#Sort_No").click(function () {
    if (Sort_No == 1) {
        Sort_No = 2;
    } else {
        Sort_No = 1;
    }
    GetAllMusic();
})

