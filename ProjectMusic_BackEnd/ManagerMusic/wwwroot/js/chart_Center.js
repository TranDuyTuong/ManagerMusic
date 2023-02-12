var ErrorNotification = $("#ErrorNotification").val();
var datafo_year = $("#datafo_year").val();
var Month = $("#Month").val();
var the_song = $("#the_song").val();

$(document).ready(function () {
    GetYear = new Date().getFullYear();
    GetDataYesterday();
    GetDataToday();
    GetDataTomorow();
    LoadNewMusicInMonth();
    LoadUpAndDownMuisc();
})
var GetYear;
google.charts.load('current', { 'packages': ['bar'] });
google.charts.setOnLoadCallback(drawChart);

function drawChart() {
    $("#titleYear").empty();
    var January = {
        month: "1", total: 0
    }, February = {
        month: "2", total: 0
    }, Maths = {
        month: "3", total: 0
    }, April = {
        month: "4", total: 0
    }, May = {
        month: "5", total: 0
    }, Jun = {
        month: "6", total: 0
    }, Junly = {
        month: "7", total: 0
    }, August = {
        month: "8", total: 0
    }, September = {
        month: "9", total: 0
    }, October = {
        month: "10", total: 0
    }, November = {
        month: "11", total: 0
    }, December = {
        month: "12", total: 0
    }
    $.ajax({
        url: "/Home/GetDataForChart",
        type: "get",
        data: {
            Year: GetYear
        },
        success: function (result) {
            $("#titleYear").append(GetYear);
            if (result.length == 0) {
                toastr.error(datafo_year, ErrorNotification);
            } else {
                $.each(result, function (key, item) {
                    switch (item.month) {
                        case '1':
                            January.total = item.totalMusic;
                            break;
                        case '2':
                            February.total = item.totalMusic;
                            break;
                        case '3':
                            Maths.total = item.totalMusic;
                            break;
                        case '4':
                            April.total = item.totalMusic;
                            break;
                        case '5':
                            May.total = item.totalMusic;
                            break;
                        case '6':
                            Jun.total = item.totalMusic;
                            break;
                        case '7':
                            Junly.total = item.totalMusic;
                            break;
                        case '8':
                            August.total = item.totalMusic;
                            break;
                        case '9':
                            September.total = item.totalMusic;
                            break;
                        case '10':
                            October.total = item.totalMusic;
                            break;
                        case '11':
                            November.total = item.totalMusic;
                            break;
                        case '12':
                            December.total = item.totalMusic;
                            break;
                    }
                });
                var data = google.visualization.arrayToDataTable([
                    [Month, the_song],
                    [January.month, January.total],
                    [February.month, February.total],
                    [Maths.month, Maths.total],
                    [April.month, April.total],
                    [May.month, May.total],
                    [Jun.month, Jun.total],
                    [Junly.month, Junly.total],
                    [August.month, August.total],
                    [September.month, September.total],
                    [October.month, October.total],
                    [November.month, November.total],
                    [December.month, December.total]
                ]);

                var options = {
                    chart: {
                        title: '',
                        subtitle: '',
                    }
                };

                var chart = new google.charts.Bar(document.getElementById('columnchart_material'));

                chart.draw(data, google.charts.Bar.convertOptions(options));
            }
            return;
        }
    })
}

function SelectDataYear() {
    var select = $(".select_OptionYear").val();
    GetYear = select;
    drawChart();
}

//load get yesterday
function GetDataYesterday() {
    $("#Get_Yesterday").empty();
    var yesterday = new Date(new Date().setDate(new Date().getDate() - 1));
    $("#Get_Yesterday").append(yesterday.toDateString());
}

//load get today
function GetDataToday() {
    $("#Get_Today").empty();
    var today = new Date();
    $("#Get_Today").append(today.toDateString());
}

//load get tomorow
function GetDataTomorow() {
    $("#Get_Tomorow").empty();
    var tomorow = new Date(new Date().setDate(new Date().getDate() + 1));
    $("#Get_Tomorow").append(tomorow.toDateString());
}

//load new muisc in month
function LoadNewMusicInMonth() {
    $("#MuiscMonth").empty();
    $.ajax({
        url: "/Home/GetTotalMusicInMonth",
        type: "get",
        success: function (result) {
            $("#MuiscMonth").append(result);
            LoadMusicLastMonth();
        }
    })
}

//load new muisc last month
function LoadMusicLastMonth() {
    $("#MusicLastMonth").empty();
    var NowMonth = $("#MuiscMonth").text();
    $.ajax({
        url: "/Home/GetTotalMusicLastMonth",
        type: "get",
        success: function (result) {
            if (result < Number(NowMonth)) {
                document.getElementById('trendData').style.display = "block";
            } else if (result > Number(NowMonth)) {
                document.getElementById('DownData').style.display = "block";
            } else if (result == Number(NowMonth)) {
                document.getElementById('EqualData').style.display = "block";
            }
            $("#MusicLastMonth").append(result);
        }
    })
}

//total up and down muisc
function LoadUpAndDownMuisc() {
    $("#TotalDowMuisc").empty();
    $("#TotalUpMuisc").empty();
    $.ajax({
        url: "/Home/TotalDowloadAndUpMuisc",
        type: "get",
        success: function (result) {
            console.log(result);
            $("#TotalDowMuisc").append(result.totalDown);
            $("#TotalUpMuisc").append(result.totalUp);
        }
    })
}