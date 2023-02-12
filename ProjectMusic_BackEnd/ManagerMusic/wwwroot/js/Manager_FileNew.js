var PageSize = 6;
var PageIndex = 1;
var NotfindMusic = $("#NotfindMusic").val();
var TotalMusic = $("#TotalMusic").val();
var ViewDetailSong = $("#ViewDetailSong").val();
var head = $("#head").val();
var next = $("#next").val();
var last = $("#last").val();
var Before = $("#Before").val();

$(document).ready(function () {

});

//--------------------------------------------------
//function load data
function LoadData() {
    var count = 0;
    $("#titleNotification").empty();
    $("#body_Music").empty();
    $("#ItemInPage").empty();
    $("#TotalItem").empty();
    $.ajax({
        url: "/ManagerData/JsonGetNewMusic",
        type: "get",
        data: {
            PageSize: PageSize,
            PageIndex: PageIndex,
        },
        success: function (result) {
            if (result.total == 0) {
                $("#titleNotification").append(NotfindMusic);
            } else {
                $.each(result.l_Music, function (key, item) {
                    count++;
                    var html = ""
                    html += '<tr>';
                    html += '<th scope="row">' + item.noMusic +'</th>';
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
                $("#TotalItem").append(result.total)
                $("#ItemInPage").append(count)
                //paing
                paging(result.total, function () {
                    LoadData();
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
