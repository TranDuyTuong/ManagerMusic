var Notification_Error = $("#Notification_Error").val();
var datafo_year = $("#datafo_year").val();

$(document).ready(function () {
    CurentYear = new Date().getFullYear();
});
var CurentYear;

google.charts.load("current", { packages: ["calendar"] });
google.charts.setOnLoadCallback(drawChart);

function drawChart() {
    $("#TotalSatff").empty();
    $.ajax({
        url: "/Reports/JsonGetAllUserChart",
        type: "get",
        data: {
            Year: CurentYear
        },
        success: function (result) {
            var count = 0;
            if (result.length == 0) {
                toastr.error(datafo_year, Notification_Error);
            } else {
                var dataTable = new google.visualization.DataTable();
                dataTable.addColumn({ type: 'date', id: 'Date' });
                dataTable.addColumn({ type: 'number', id: 'Won/Loss' });
                $.each(result, function (key, item) {
                    var sum = item.totalMuisc;
                    count = count + sum;
                    dataTable.addRows([
                        //trong database ra sau đó đổ ra chart thì trừ 1
                        [new Date(item.year, item.month - 1, item.day), item.totalMuisc],
                    ]);
                })

                var chart = new google.visualization.Calendar(document.getElementById('calendar_basic'));
                var options = {
                    height: 500,
                    calendar: {
                        monthLabel: {
                            fontName: 'Times-Roman',
                            fontSize: 12,
                            color: '#981b48',
                            bold: true,
                            italic: true
                        },
                        monthOutlineColor: {
                            stroke: '#981b48',
                            strokeOpacity: 0.8,
                            strokeWidth: 2
                        },
                        unusedMonthOutlineColor: {
                            stroke: '#bc5679',
                            strokeOpacity: 0.8,
                            strokeWidth: 1
                        },
                        cellSize: 15,
                        underMonthSpace: 16,
                        yearLabel: {
                            fontName: 'Times-Roman',
                            fontSize: 32,
                            color: '#1A8763',
                            bold: true,
                            italic: true
                        }
                    }
                };

                chart.draw(dataTable, options);
            }
            $("#TotalSatff").append(count);
        }
    })
}

//select year
$("#Btn_SelectYear").click(function () {
    var Getyear = $("#SelectValue").val();
    CurentYear = Getyear;
    google.charts.load("current", { packages: ["calendar"] });
    google.charts.setOnLoadCallback(drawChart);
})

//reset
$("#btn_Reload").click(function () {
    window.location.reload();
})