var head = $("#head").val();
var next = $("#next").val();
var last = $("#last").val();
var Before = $("#Before").val();

var pageSize = 20;
var pageIndex = 1;
var seach;
var OrderBy = 0;

$("#btn_Seach").click(function () {
    seach = $("#TxtSeachValue").val();
    LoadCitys();
});

function LoadCitys() {
    $("#body_Citys").empty();
    $("#TotalCitys").empty();
    $("#TotalItem").empty();
    $("#ItemInPage").empty();
    $("#SeachCitys").empty();
    var count = 0;
    $.ajax({
        url: "/ManagerAddress/JsonGetAllCitys",
        type: "get",
        data: {
            pageSize: pageSize,
            pageIndex: pageIndex,
            seach: seach,
            OrderBy: OrderBy
        },
        success: function (result) {
            if (result.totalSeach != 0) {
                var strMessage = "Từ Khóa Tìm Kiếm: " + seach + " - - " + " Đã Tìm Thấy: " + result.totalSeach + " Kết Quả";
                $("#SeachCitys").append(strMessage);
            }
            $.each(result.l_Citys, function (key, item) {
                var html = "";
                count++;
                html += '<tr id="' + item.cityId + '">';
                html += '<th scope="row">';
                html += '<input type="checkbox" class="case" name="case" value="' + item.cityId + '"/>';
                html += '</th>';
                html += '<td>' + item.cityId + '</td>';
                html += '<td>' + item.cityName + '</td>';
                html += '<td>' + item.createDate + '</td>';
                html += '<td>' + item.timeCreate + '</td>';
                html += '<td>' + item.symbol + '</td>';
                html += '<td>' + item.areaCode + '</td>';
                html += '<td>';
                html += '<button type="button" style="border: none;" name="ChangeStatus" class="btn btn-outline-secondary" ata-bs-toggle="tooltip" data-bs-placement="top"><i class="fas fa-sync"></i></button>';
                html += '<button type="button" style="border: none;" name="ViewListMusic" class="btn btn-outline-secondary" ata-bs-toggle="tooltip" data-bs-placement="top"><i class="fas fa-folder-open"></i></button>';
                html += '</td>';
                html += '</tr>';
                $("#body_Citys").append(html);
            })
            $("#TotalItem").append(pageIndex)
            $("#ItemInPage").append(count)
            $("#TotalCitys").append(result.totalCitys)
            //paing
            paging(result.totalCitys, function () {
                LoadCitys();
            })
        }
    })
}

//----------------------------------------------
//paing
function paging(totalRoll, callback) {
    var totalPage = Math.ceil(totalRoll / pageSize);
    $('#pagination').twbsPagination({
        totalPages: (totalPage == 0) ? 1 : totalPage,
        first: head,
        next: next,
        last: last,
        prev: Before,
        visiblePages: 10,
        onPageClick: function (event, page) {
            pageIndex = page;
            setTimeout(callback, 200);
        }
    });
}