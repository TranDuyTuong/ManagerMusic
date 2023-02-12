var PageIndex = 1;
var PageSize = 20;
var IdMusic = $("#IdMusic").val();
var head = $("#head").val();
var next = $("#next").val();
var last = $("#last").val();
var Before = $("#Before").val();
var OldSong_Name = $("#OldSong_Name").val();
var NewSong_Name = $("#NewSong_Name").val();
var Old_Content = $("#Old_Content").val();
var New_Content = $("#New_Content").val();
var Old_Author = $("#Old_Author").val();
var New_Author = $("#New_Author").val();

$(document).ready(function () {
    LoadDataHistory();
});

//load data
function LoadDataHistory() {
    $("#bodyHistory").empty();
    $("#ItemInPageHistory").empty();
    $("#TotalItemHistory").empty();
    $("#TotalHistory").empty();
    var count = 0;
    $.ajax({
        url: "/ManagerData/JsonGetUpdateHistory",
        type: "post",
        data: {
            IdMusic: IdMusic,
            PageIndex: PageIndex,
            PageSize: PageSize,
        },
        success: function (result) {
            if (result == 0) {
                $("#TotalHistory").append(count);
            } else {
                $.each(result.l_HistoryUpdate, function (key, item) {
                    count++;
                    var html = "";
                    html += '<tr id="' + item.id + '">';
                    html += '<th scope="row">' + item.id + '</th>';
                    html += '<td>' + item.nameUser + '</td>';
                    html += '<td>' +
                        '<p style="font-size: 13px; font-family: initial; font-weight: 600;">' + OldSong_Name + ': ' + item.nameMusicOld + '</p><br/>' +
                        '<p style="font-size: 13px; font-family: initial; font-weight: 600;">' + NewSong_Name + ': ' + item.nameMuiscNew + '</p>'
                        + '</td>';
                    html += '<td>' +
                        '<p style="font-size: 13px; font-family: initial; font-weight: 600;">' + Old_Content + ': ' + item.fileNameOld + '</p><br/>' +
                        '<p style="font-size: 13px; font-family: initial; font-weight: 600;">' + New_Content + ': ' + item.fileNameNew + '</p>'
                        + '</td>';
                    html += '<td>' +
                        '<p style="font-size: 13px; font-family: initial; font-weight: 600;">' + Old_Author + ': ' + item.authorOld + '</p><br/>' +
                        '<p style="font-size: 13px; font-family: initial; font-weight: 600;">' + New_Author + ': ' + item.authorNew + '</p>'
                        + '</td>';
                    html += '<td>' + item.nameSeason + '</td>';
                    html += '<td>' + item.nameSaint + '</td>';
                    html += '<td>' + item.dateUpdate + '</td>';
                    $("#bodyHistory").append(html);
                });
                $("#ItemInPageHistory").append(count);
                $("#TotalItemHistory").append(result.total);
                $("#TotalHistory").append(result.total)
                //paing
                pagingHistory(result.total, function () {
                    LoadDataHistory();
                })

            }
            return;

        }
    })
}

//----------------------------------------------
//paing
function pagingHistory(totalRoll, callback) {
    var totalPage = Math.ceil(totalRoll / PageSize);
    $('#paginationHitory').twbsPagination({
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