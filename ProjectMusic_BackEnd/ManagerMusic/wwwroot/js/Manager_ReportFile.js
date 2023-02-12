var Apply = $("#Apply").val();
var Cancel = $("#cancel").val();
var head = $("#head").val();
var next = $("#next").val();
var last = $("#last").val();
var Before = $("#Before").val();
var Choose_the_Season_You_Need = $("#Choose_the_Season_You_Need").val();
var choosingdownload_seasonal = $("#choosingdownload_seasonal").val();
var Select_saint = $("#Select_saint").val();
var choosingdownload_saints = $("#choosingdownload_saints").val();
var choosingdownload_date = $("#choosingdownload_date").val();
var choosingdownload_All = $("#choosingdownload_All").val();
var Notification_Error = $("#Notification_Error").val();
var EnterNameAuthor = $("#EnterNameAuthor").val();
var choosingdownload_Author = $("#choosingdownload_Author").val();

$(document).ready(function(){
    $(".applyBtn").empty();
    $(".cancelBtn").empty();
    $(".applyBtn").append(Apply);
    $(".cancelBtn").append(Cancel);
    LoadDataMusic();
    document.getElementById('BtnDowLoadReport').style.display = 'none';
    IdFlap = 0;
    SeachItem = null;
    SeachSeason = null;
    SeachSaint = null;
    SeachDateCreate = null;
    $("#TxtNotification").empty();
});
var IdFlap = 0;
var SeachItem = null;
var SeachSeason = null;
var SeachSaint = null;
var SeachDateCreate = null;

var PageIndex = 1;
var PageSize = 15;
//load data music
function LoadDataMusic() {
    $("#bodyDataMusic").empty();
    $("#TotalMusics").empty();
    $("#TotalItem").empty();
    $("#ItemInPage").empty();
    var count = 0;
    $.ajax({
        url: "/Reports/JsonGetAllMusic",
        type: "get",
        data: {
            pageSize: PageSize,
            pageIndex: PageIndex,
            IdFlap: IdFlap,
            SeachAuthor: SeachItem,
            IdSeason: SeachSeason,
            IdSaints: SeachSaint,
            SeachDate: SeachDateCreate
        },
        success: function (result) {
            console.log(result);
            $.each(result.l_ReportMusic, function (key, item) {
                var html = "";
                count++;
                html += '<tr id="' + item.idMusic + '">';
                html += '<th scope="row">' + item.codeMusic + '</th>';
                html += '<td>' + item.name + '</td>';
                html += '<td>' + item.author + '</td>';
                html += '<td>' + item.str_DateCreate + '</td>';
                html += '<td>' + item.nameSeason + '</td>';
                html += '<td>' + item.nameSaint + '</td>';
                html += '<td>' + item.nameStaff + '</td>';
                html += '</tr>';
                $("#bodyDataMusic").append(html);
            })
            $("#TotalMusics").append(result.totalMusic);
            $("#TotalItem").append(PageIndex);
            $("#ItemInPage").append(count);
            //paing
            paging(result.totalMusic, function () {
                LoadDataMusic();
            })
        }
    })
}
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
//--------------------------------
//Season
$("#btn_ShowModalSeason").click(function () {
    $("#SelectSeason").empty();
    $.ajax({
        url: "/ManagerSeason/JsonGetAllSeasonNotPaing",
        type: "get",
        success: function (result) {
            var HtmlDefaul = '<option selected value="0">' + Choose_the_Season_You_Need + ' ...</option>';
            $("#SelectSeason").append(HtmlDefaul);
            $.each(result, function (key, item) {
                var html = "";
                html += '<option value="' + item.id + '">' + item.name + '</option>';
                $("#SelectSeason").append(html);
            })
            $("#ModalSeasonView").show();
        }
    })
});
$("#btn_closeSeason").click(function(){
    $("#ModalSeasonView").hide();
    window.location.reload();
});
$("#Btn_FindSeason").click(function () {
    IdFlap = 3;
    SeachSeason = $("#SelectSeason").val();
    LoadDataMusic();
    $("#ModalSeasonView").hide;
    $("#TxtNotification").empty();
    $("#TxtNotification").append(choosingdownload_seasonal);
    document.getElementById('BtnDowLoadReport').style.display = 'block';
    $("#ModalSeasonView").hide();
});

//-------------------------------
//select saints
$("#btn_ShowModalsaints").click(function () {
    $("#SelectSaints").empty();
    $.ajax({
        url: "/ManagerSaint/JsonGetAllSaintActiver",
        type: "get",
        success: function (result) {
            var htmlDefaul = '<option selected value="0">' + Select_saint + ' ...</option>';
            $("#SelectSaints").append(htmlDefaul);
            $.each(result, function (key, item) {
                var html = "";
                html += '<option value="' + item.idSaint + '">' + item.nameSaint + '</option>';
                $("#SelectSaints").append(html);
            });
            $("#ModalsaintsView").show();
        }
    })
});
$("#btn_closesaints").click(function () {
    $("#ModalsaintsView").hide();
    window.location.reload();
});
$("#BtnSeach_Saints").click(function () {
    $("#TxtNotification").empty();
    IdFlap = 4;
    SeachSaint = $("#SelectSaints").val();
    LoadDataMusic();
    $("#TxtNotification").append(choosingdownload_saints);
    document.getElementById('BtnDowLoadReport').style.display = 'block';
    $("#ModalsaintsView").hide();
});

//----------------------------
//select date
//datetime picker
$("#rangeDate").flatpickr({
    mode: 'range',
    dateFormat: "Y-m-d"
});
$("#btn_ShowModalDate").click(function(){
    $("#Modal_ShowFuilterDate").show();
})
$("#btn_FuilterDate").click(function () {
    $("#TxtNotification").empty();
    IdFlap = 5;
    SeachDateCreate = $("#rangeDate").val();
    LoadDataMusic();
    $("#TxtNotification").append(choosingdownload_date);
    document.getElementById('BtnDowLoadReport').style.display = 'block';
    $("#Modal_ShowFuilterDate").hide();
});
$("#btn_CLoseFuilterDate").click(function(){
    $("#Modal_ShowFuilterDate").hide();
    window.location.reload();
})

//reset
$("#BtnReset").click(function () {
    window.location.reload();
})

//Dowload all file music
$("#DowLoadAllFile_Music").click(function () {
    $("#TxtNotification").empty();
    IdFlap = 1;
    LoadDataMusic();
    $("#TxtNotification").append(choosingdownload_All);
    document.getElementById('BtnDowLoadReport').style.display = 'block';
});
$("#BtnDowLoadReport").click(function () {
    switch (IdFlap) {
        case 1:
            window.location.href = "/Reports/DowLoadAllMusic";
            break;
        case 2:
            window.location.href = "/Reports/DowMusicByAuthor";
            break;
        case 3:
            window.location.href = "/Reports/DowMusicBySeason";
            break;
        case 4:
            window.location.href = "/Reports/DowMusicBySaints";
        case 5:
            window.location.href = "/Reports/DowMusicByDate";
    }
})

//Dowload Music by author
$("#DowloadBuAuthor").click(function () {
    $("#ModalSeachAuthor").show();
})
$("#BtnSeach_Author").click(function () {
    var SeachData = $("#TxtNameAuthor").val();
    if (SeachData.length == 0) {
        toastr.error(EnterNameAuthor, Notification_Error)
        return;
    }
    $("#TxtNotification").empty();
    IdFlap = 2;
    SeachItem = SeachData;
    LoadDataMusic();
    $("#TxtNotification").append(choosingdownload_Author);
    document.getElementById('BtnDowLoadReport').style.display = 'block';
    $("#ModalSeachAuthor").hide();
});
$("#CloseAuthor").click(function () {
    $("#ModalSeachAuthor").hide();
    window.location.reload();
});