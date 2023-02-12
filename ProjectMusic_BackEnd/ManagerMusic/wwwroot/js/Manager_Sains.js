var head = $("#head").val();
var next = $("#next").val();
var last = $("#last").val();
var Before = $("#Before").val();
var Notification_Error = $("#Notification_Error").val();
var Nofitication_Success = $("#Nofitication_Success").val();
var Employeeid_empty = $("#Employeeid_empty").val();
var Create_SaintSuccess = $("#Create_SaintSuccess").val();
var NotFind_IdSaint = $("#NotFind_IdSaint").val();
var UpdateSaint_Success = $("#UpdateSaint_Success").val();
var IDsaintOrIDstatus_Null = $("#IDsaintOrIDstatus_Null").val();
var NotFind_IDstatus = $("#NotFind_IDstatus").val();
var ChangeStatus_SeasonSuccess = $("#ChangeStatus_SeasonSuccess").val();
var ViewDetailSong = $("#ViewDetailSong").val();
var Update = $("#Update").val();
var Change_Status = $("#Change_Status").val();
var View_List = $("#View_List").val();
var NameSaint_NotNull = $("#NameSaint_NotNull").val();

$(document).ready(function () {
    LoadDat_Saint()
    sort_Defaul = 1;
    sort_Name = 2;
    sort_Date = 3;
    sort_Status = 4;
    IDSORT = 1;
    NAMESORT = 2;
    DATESORT = 3;
    STATUSSORT = 4;
    SEACHVALUE = null;
});

var PageIndex = 1;
var PageSize = 10;
var PageIndex_Music = 1;
var PageSize_Music = 10;
var sort_Defaul = 1;
var sort_Name = 2;
var sort_Date = 3;
var sort_Status = 4;
var SEACHVALUE;

function LoadDat_Saint() {
    $("#body_Saint").empty();
    $("#titleNotification").empty();
    $("#ItemInPage").empty();
    $("#TotalItem").empty();
    $("#Total_Season").empty();
    var count = 0;
    $.ajax({
        url: "/ManagerSaint/JsonGetAllSaint",
        type: "get",
        data: {
            PageIndex: PageIndex,
            PageSize: PageSize,
            sort: sort_Defaul,
            Seach: SEACHVALUE
        },
        success: function (result) {
            $.each(result.l_Saint, function (key, item) {
                count++;
                var html = "";
                html += '<tr id="' + item.idSaint + '">';
                html += '<th scope="row">' + item.idSaint + '</th>';
                html += '<td>' + item.nameSaint + '</td>';
                html += '<td>' + item.date_Create + '</td>';
                html += '<td>' + item.time_Create + '</td>';
                if (item.idStatuSaint == 1) {
                    html += '<td>' + '<p style="font-family: inherit; color: green;"><i class="fas fa-plus-circle"></i> ' + item.name_Status + ' </p>' + '</td>';
                } else {
                    html += '<td>' + '<p style="font-family: inherit; color: red;"><i class="fas fa-minus-circle"></i> ' + item.name_Status + ' </p>' + '</td>';
                }
                html += '<td>'
                    + '<button name="UpdateSaint" style="border: none;" class="btn btn-outline-secondary" ata-bs-toggle="tooltip" data-bs-placement="top" title="' + Update + '"><i class="fas fa-edit"></i></button>'
                    + '<button name="ChangeStatusSaint" style="border: none;" class="btn btn-outline-secondary" ata-bs-toggle="tooltip" data-bs-placement="top" title="' + Change_Status + '"><i class="fas fa-sync"></i></button>'
                    + '<button name="ListMusicBySaint" style="border: none;" class="btn btn-outline-secondary" ata-bs-toggle="tooltip" data-bs-placement="top" title="' + View_List + '"><i class="fas fa-folder-open"></i></button>'
                        + '</td>';
                html += '</tr>';
                $("#body_Saint").append(html);
            })
            $("#TotalItem").append(PageIndex)
            $("#ItemInPage").append(count)
            $("#Total_Season").append(result.total)
            //paing
            paging(result.total, function () {
                LoadDat_Saint();
            })
        }
    })
}

//----------------------------------
//sort id data
$("#sort_Id").click(function () {
    if (sort_Defaul == 1) {
        sort_Defaul = -1
    } else {
        sort_Defaul = 1
    }
    LoadDat_Saint();
});
//sort name
$("#sort_Name").click(function () {
    if (sort_Name == 2) {
        sort_Defaul = -2
        sort_Name = -2
    } else {
        sort_Defaul = 2
        sort_Name = 2
    }
    LoadDat_Saint();
})
//sort date
$("#sort_Date").click(function () {
    if (sort_Date == 3) {
        sort_Defaul = -3
        sort_Date = -3
    } else {
        sort_Defaul = 3
        sort_Date = 3
    }
    LoadDat_Saint();
})
//sort status 
$("#sort_Status").click(function () {
    if (sort_Status == 4) {
        sort_Defaul = -4
        sort_Status = -4
    } else {
        sort_Defaul = 4
        sort_Status = 4
    }
    LoadDat_Saint();
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

//--------------------------------------------
//create saint
$("#Btn_Create").click(function () {
    $("#modal_CreateSaint").show();
});
$("#btn_closeCreate").click(function () {
    $("#modal_CreateSaint").hide();
});
function functionGetText() {
    var TextData = $("#TxtSaint").val();
    $("#errorData").empty();
    if (TextData.length == 0) {
        $("#errorData").append(NameSaint_NotNull);
    }
    return;
}

$("#btn_CreateNewSaint").click(function () {
    var TextData = $("#TxtSaint").val();
    $("#errorData").empty();
    if (TextData.length == 0) {
        $("#errorData").append(NameSaint_NotNull);
    } else {
        $("#modal_LoadingCreateMusic").show();
        $.ajax({
            url: "/ManagerSaint/JsonCreateSaint",
            type: "post",
            data: {
                NameSaint: TextData
            },
            success: function (result) {
                $("#modal_LoadingCreateMusic").hide();
                switch (result.isStatus) {
                    case 1:
                        toastr.error(Employeeid_empty, Notification_Error);
                        break;
                    case 3:
                        $("#modal_CreateSaint").hide();
                        $("#TxtSaint").append("");
                        toastr.success(Create_SaintSuccess, Nofitication_Success);
                        LoadDat_Saint();
                        break;
                }
            }
        })
    }
    return;
});

//--------------------------------------
//update saint
$(document).on('click', 'button[name="UpdateSaint"]', function () {
    var IdSaint = $(this).closest("tr").attr("id");
    $.ajax({
        url: "/ManagerSaint/JsonGetUpdateSaint",
        type: "get",
        data: {
            IdSaint: IdSaint
        },
        success: function (result) {
            if (result.idSaint == 0) {
                toastr.error(NotFind_IdSaint, Notification_Error);
            } else {
                $("#TxtIdSaint").val(result.idSaint)
                $("#TxtNameSaint").val(result.nameSaint);
                $("#TxtDate").val(result.date_Create);
                $("#TxtTime").val(result.time_Create);
                $("#TxtStatus").val(result.name_Status);
                $("#modal_UpdateSaint").show();
            }
            return;
        }
    })
});
$("#btn_closeUpdate").click(function () {
    $("#modal_UpdateSaint").hide();
    return;
})

function functionNameSaint() {
    var TextData = $("#TxtNameSaint").val();
    $("#errorName").empty();
    if (TextData.length == 0) {
        $("#errorData").append(NameSaint_NotNull);
    }
    return;
}

$("#btn_UpdateSaint").click(function () {
    var id = $("#TxtIdSaint").val();
    var TextData = $("#TxtNameSaint").val();
    $("#errorName").empty();
    if (TextData.length == 0) {
        $("#errorName").append(NameSaint_NotNull);
    } else {
        $("#modal_LoadingCreateMusic").show();
        $.ajax({
            url: "/ManagerSaint/JsonUpdateSaint",
            type: "post",
            data: {
                NameSaint: TextData,
                IdSaint: id
            },
            success: function (result) {
                $("#modal_LoadingCreateMusic").hide();
                switch (result.isStatus) {
                    case 1:
                        toastr.error(NotFind_IdSaint, Notification_Error);
                        break;
                    case 2:
                        $("#modal_UpdateSaint").hide();
                        toastr.success(UpdateSaint_Success, Nofitication_Success);
                        LoadDat_Saint();
                        break;
                }
            }
        })
    }
    return;
})

//-------------------------------------
var Id_Saint = 0;
//change stauts saint
$(document).on('click', 'button[name="ChangeStatusSaint"]', function () {
    var IdSaint = $(this).closest("tr").attr("id");
    $("#TxtSelect").empty();
    $.ajax({
        url: "/ManagerSaint/JsonGetAllSatusSaint",
        type: "get",
        data: {
            IdSaint: IdSaint
        },
        success: function (result) {
            var count = 0;
            $.each(result, function (key, item) {
                count++;
                var html = "";
                if (count == 1) {
                    html += '<option selected value="' + item.id + '">' + item.name + '</option>';
                } else {
                    html += '<option value="' + item.id + '">' + item.name + '</option>';
                }
                $("#TxtSelect").append(html);
            })
            Id_Saint = IdSaint;
            $("#modal_ChangeStatus").show();
        }
    })
})
$("#btn_closeChangeStatus").click(function () {
    $("#modal_ChangeStatus").hide();
})

$("#btn_ChangeStatus").click(function () {
    var Id = $("#TxtSelect").val();
    if (Id == 0 || Id_Saint == 0) {
        toastr.error(IDsaintOrIDstatus_Null, Notification_Error);
    } else {
        $("#modal_LoadingCreateMusic").show();
        $.ajax({
            url: "/ManagerSaint/JsonChangeSatusSaint",
            type: "post",
            data: {
                IdSaint: Id_Saint,
                IdStatus: Id
            },
            success: function (result) {
                $("#modal_LoadingCreateMusic").hide();
                switch (result.isStatus) {
                    case 1:
                        toastr.error(NotFind_IdSaint, Notification_Error);
                        break;
                    case 2:
                        toastr.error(NotFind_IDstatus, Notification_Error)
                        break;
                    case 3:
                        $("#modal_ChangeStatus").hide();
                        toastr.success(ChangeStatus_SeasonSuccess, Nofitication_Success);
                        LoadDat_Saint();
                        break;
                }
            }
        })
    }
    return;
})

//----------------------------------------
var Saint_ID = 0;
var IDSORT = 1;
var NAMESORT = 2;
var DATESORT = 3;
var STATUSSORT = 4;
//get list music by id saint
$(document).on('click', 'button[name="ListMusicBySaint"]', function () {
    var IdSaint = $(this).closest("tr").attr("id");
    if (IdSaint == 0) {
        toastr.error(NotFind_IdSaint, Notification_Error);
    } else {
        $("#modal_ShowListMusicBuySaint").show();
        LoadDatMusic_Saint(IdSaint)
        Saint_ID = IdSaint;
    }
    return;
})

function LoadDatMusic_Saint(IdSaint) {
    $("#Body_SaintListMusic").empty();
    var count = 0;
    $("#Total_Music").empty();
    $("#TotalItem_List").empty();
    $("#ItemInPage_List").empty();
    $.ajax({
        url: "/ManagerSaint/JsonGetAllMusicByIdSaint",
        type: "get",
        data: {
            PageIndex: PageIndex_Music,
            PageSize: PageSize_Music,
            IdSaint: IdSaint,
            sort: IDSORT
        },
        success: function (result) {
            $.each(result.l_Music, function (key, item) {
                count++;
                var html = ""
                html += '<tr id="' + item.idMusic + '">';
                html += '<th scope="row">' + item.noMusic + '</th>';
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
                $("#Body_SaintListMusic").append(html);
            });
            $("#TotalItem_List").append(PageIndex_Music)
            $("#ItemInPage_List").append(count)
            $("#Total_Music").append(result.total)
            //paing
            pagingViewList(result.total, function () {
                LoadDatMusic_Saint(IdSaint)
            })

        }
    })
}

$("#btn_closemodalSaint").click(function () {
    $("#modal_ShowListMusicBuySaint").hide();
})

//----------------------------------------------
//paing
function pagingViewList(totalRoll, callback) {
    var totalPage = Math.ceil(totalRoll / PageSize_Music);
    $('#paginationViewList').twbsPagination({
        totalPages: (totalPage == 0) ? 1 : totalPage,
        first: head,
        next: next,
        last: last,
        prev: Before,
        visiblePages: 10,
        onPageClick: function (event, page) {
            PageIndex_Music = page;
            setTimeout(callback, 200);
        }
    });
}

//-------------------------------------------
//SORT ID
$("#IDsort").click(function () {
    if (IDSORT == 1) {
        IDSORT = -1;
    } else {
        IDSORT = 1;
    }
    if (Saint_ID != 0) {
        LoadDatMusic_Saint(Saint_ID)
    }
});

//SORT NAME
$("#NAMEsort").click(function () {
    if (NAMESORT == 2) {
        IDSORT = -2;
        NAMESORT = -2;
    } else {
        IDSORT = 2;
        NAMESORT = 2;
    }
    if (Saint_ID != 0) {
        LoadDatMusic_Saint(Saint_ID)
    }
});

//SORT DATE
$("#DATEsort").click(function () {
    if (DATESORT == 3) {
        IDSORT = -3;
        DATESORT = -3;
    } else {
        IDSORT = 3;
        DATESORT = 3;
    }
    if (Saint_ID != 0) {
        LoadDatMusic_Saint(Saint_ID)
    }
});

//SORT STATUS
$("#STATUSsort").click(function () {
    if (STATUSSORT == 4) {
        IDSORT = -4;
        STATUSSORT = -4;
    } else {
        IDSORT = 4;
        STATUSSORT = 4;
    }
    if (Saint_ID != 0) {
        LoadDatMusic_Saint(Saint_ID)
    }
})

//---------------------------------------
//SeachData
function eventSeachMusic() {
    SEACHVALUE = $("#TxtSeach").val();
    const myTimeout = setTimeout(LoadDat_Saint, 1000);
}