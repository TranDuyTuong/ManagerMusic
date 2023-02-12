var head = $("#head").val();
var next = $("#next").val();
var last = $("#last").val();
var Before = $("#Before").val();
var Notification_Error = $("#Notification_Error").val();
var Nofitication_Success = $("#Nofitication_Success").val();
var IdSeason_Null = $("#IdSeason_Null").val();
var NotFindIdSeason = $("#NotFindIdSeason").val();
var ChangeStatus_SeasonSuccess = $("#ChangeStatus_SeasonSuccess").val();
var NotfindID_Status = $("#NotfindID_Status").val();
var Update_Funtion = $("#Update_Funtion").val();
var NotfindMusic = $("#NotfindMusic").val();
var TotalMusic = $("#TotalMusic").val();
var ViewDetailSong = $("#ViewDetailSong").val();
var Choose_Status = $("#Choose_Status").val();
var Change_Status = $("#Change_Status").val();
var Viewlist_files = $("#Viewlist_files").val();

$(document).ready(function () {
    LoadDataSeason();
    Sort_Id = 1;
    Sort_Name = 2;
    SortId = 1;
    SortName = 2;
    SortDate = 3;
    SortStatus = 4;
});

var PageIndex = 1;
var PageSize = 10;
var Sort_Id = 1;
var Sort_Name = 2;
//-------------------------------------
//load data
function LoadDataSeason() {
    $("#bodyData").empty();
    $("#Total_Season").empty();
    $("#ItemInPage").empty();
    $("#TotalItem").empty();
    var count = 0;
    $.ajax({
        url: "/ManagerSeason/JsonGetAllSeason",
        type: "get",
        data: {
            PageIndex: PageIndex,
            PageSize: PageSize,
            Sort_Id: Sort_Id
        },
        success: function (result) {
            $.each(result.l_Season, function (key, item) {
                var html = "";
                count++;
                html += '<tr id="' + item.id + '">';
                html += '<th scope="row">';
                html += item.id;
                html += '</th>';
                html += '<td>' + item.name + '</td>';
                html += '<td>' + item.dateCreate + '</td>';
                html += '<td>' + item.timeCreate + '</td>';
                if (item.idStatusSeason == 1) {
                    html += '<td>';
                    html += '<p style="font-family: inherit; color: green;">';
                    html += '<i class="fas fa-plus-circle"></i> ';
                    html += item.nameStatus;
                    html += '</p>';
                    html += '</td>';
                } else {
                    html += '<td>';
                    html += '<p style="font-family: inherit; color: red;">';
                    html += '<i class="fas fa-plus-circle"></i> ';
                    html += item.nameStatus;
                    html += '</p>';
                    html += '</td>';
                }
                html += '<td>';
                html += '<button type="button" style="border: none;" name="ChangeStatus" class="btn btn-outline-secondary" ata-bs-toggle="tooltip" data-bs-placement="top" title="' + Change_Status + '"><i class="fas fa-sync"></i></button>';
                html += '<button type="button" style="border: none;" name="ViewListMusic" class="btn btn-outline-secondary" ata-bs-toggle="tooltip" data-bs-placement="top" title="' + Viewlist_files + '"><i class="fas fa-folder-open"></i></button>';
                html += '</td>';
                html += '</tr>';
                $("#bodyData").append(html);
            })
            $("#TotalItem").append(PageIndex)
            $("#ItemInPage").append(count)
            $("#Total_Season").append(result.total)
            //paing
            paging(result.total, function () {
                LoadDataSeason();
            })
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

//-----------------------------------------------
var IdSeasons = 0;
//change status
$(document).on('click', 'button[name="ChangeStatus"]', function () {
    var IdSeason = $(this).closest("tr").attr("id");
    if (IdSeason == 0) {
        toastr.error(IdSeason_Null, Notification_Error)
    } else {
        $("#SelectStatus").empty();
        $.ajax({
            url: "/ManagerSeason/JsonGetAllStatusSeason",
            type: "get",
            success: function (result) {
                var HtmlDefault = '<option selected>--' + Choose_Status + '--</option>';
                $("#SelectStatus").append(HtmlDefault);
                $.each(result, function (key, item) {
                    var html = "";
                    html += '<option value="' + item.id + '">' + item.name + '</option>';
                    $("#SelectStatus").append(html);
                })
            }
        })
        IdSeasons = IdSeason;
        $("#modal_ShowChangeStatus").show();
    }
    return;
});

$("#btn_close").click(function () {
    IdSeasons = 0;
    $("#modal_ShowChangeStatus").hide();
})

$("#btn_changestatusSeason").click(function () {
    var IdStatus = $("#SelectStatus").val();
    if (IdSeasons == 0 || IdStatus == 0) {
        toastr.error(IdSeason_Null, Notification_Error);
    } else {
        toastr.error(Update_Funtion, Notification_Error);
        $("#modal_ShowChangeStatus").hide();
    }
    return;
})

//sort id
$("#Sort_Id").click(function () {
    if (Sort_Id == 1) {
        Sort_Id = -1;
    } else {
        Sort_Id = 1
    }
    LoadDataSeason();
});

//sort name
$("#Sort_Name").click(function () {
    if (Sort_Name == 2) {
        Sort_Id = -2
        Sort_Name = -2
    } else {
        Sort_Id = 2
        Sort_Name = 2
    }
    LoadDataSeason();
})

//-----------------------------------------------
var Page = 10;
var Index = 1;
var Pu_IdSeason;
// load data music by id season
function LoadDataByIdSeason(IdSeason) {
    $("#ItemInPage_List").empty();
    $("#TotalItem_List").empty();
    $("#bodyDetail").empty();
    $("#titleNotification").empty();
    var count = 0;
    $.ajax({
        url: "/ManagerSeason/JsonListMusicByIdSeason",
        type: "post",
        data: {
            PageSize: Page,
            PageIndex: Index,
            IdSeason: IdSeason,
            Sort: SortId
        },
        success: function (result) {
            if (result.total == 0) {
                $("#titleNotification").append(NotfindMusic);
            } else {
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
                    $("#bodyDetail").append(html);
                });
                $("#TotalItem_List").append(Index)
                $("#ItemInPage_List").append(count)
                //paing
                pagingViewList(result.total, function () {
                    LoadDataByIdSeason(Pu_IdSeason)
                })
                $("#titleNotification").append(TotalMusic + " " + result.total);
            }
            return;
        }
    })
}
//view list music by id season
$(document).on('click', 'button[name="ViewListMusic"]', function () {
    var IdSeason = $(this).closest("tr").attr("id");
    if (IdSeason == 0) {
        toastr.error(IdSeason_Null, Notification_Error)
    } else {
        Pu_IdSeason = IdSeason
        LoadDataByIdSeason(Pu_IdSeason);
        $("#modal_ShowListMusicBuySeason").show();
    }
});

//----------------------------------------------
//paing
function pagingViewList(totalRoll, callback) {
    var totalPage = Math.ceil(totalRoll / Page);
    $('#paginationViewList').twbsPagination({
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

$("#btn_closemodalList").click(function () {
    Pu_IdSeason = 0;
    $("#modal_ShowListMusicBuySeason").hide();
});

//--------------------------
var SortId = 1;
var SortName = 2;
var SortDate = 3;
var SortStatus = 4;
$("#sort_idList").click(function () {
    if (SortId == 1) {
        SortId = -1;
    } else {
        SortId = 1;
    }
    LoadDataByIdSeason(Pu_IdSeason);
});

$("#sort_name").click(function () {
    if (SortName == 2) {
        SortId = -2;
        SortName = -2;
    } else {
        SortId = 2;
        SortName = 2;
    }
    LoadDataByIdSeason(Pu_IdSeason);
});

$("#sort_datcreate").click(function () {
    if (SortDate == 3) {
        SortId = -3;
        SortDate = -3;
    } else {
        SortId = 3;
        SortDate = 3;
    }
    LoadDataByIdSeason(Pu_IdSeason);
})

$("#sort_status").click(function () {
    if (SortStatus == 4) {
        SortId = -4;
        SortStatus = -4;
    } else {
        SortId = 4;
        SortStatus = 4;
    }
    LoadDataByIdSeason(Pu_IdSeason);
})