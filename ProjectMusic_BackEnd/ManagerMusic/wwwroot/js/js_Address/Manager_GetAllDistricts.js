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
    LoadDistricts();
});

function LoadDistricts() {
    $("#body_Districts").empty();
    $("#TotalDistricts").empty();
    $("#TotalItem").empty();
    $("#ItemInPage").empty();
    $("#SeachCitys").empty();
    var count = 0;
    $.ajax({
        url: "/ManagerAddress/JsonGetAllDistricts",
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
            $.each(result.l_Districts, function (key, item) {
                var html = "";
                count++;
                html += '<tr id="' + item.districtId + '">';
                html += '<th scope="row">';
                html += '<input type="checkbox" class="case" name="case" value="' + item.districtId + '"/>';
                html += '</th>';
                html += '<td>' + item.districtId + '</td>';
                html += '<td>' + item.nameDistrict + '</td>';
                html += '<td>' + item.nameCity + '</td>';
                html += '<td>' + item.dateCreate + '</td>';
                html += '<td>' + item.timeCreate + '</td>';
                if (item.status == true) {
                    html += '<td>' + 'Hoạt Động' + '</td>';
                } else {
                    html += '<td>' + 'Ngưng Hoạt Động' + '</td>';
                }
                html += '<td>';
                html += '<a href="/ManagerAddress/PageDetailCity/?IdCitys=' + item.districtId + '" style="border: none;" lass="btn btn-outline-secondary" ata-bs-toggle="tooltip" data-bs-placement="top"><i class="fas fa-folder-open"></i></a>';
                html += '</td>';
                html += '</tr>';
                $("#body_Districts").append(html);
            })
            $("#TotalItem").append(pageIndex)
            $("#ItemInPage").append(count)
            $("#TotalDistricts").append(result.totalDistricts)
            //paing
            paging(result.totalDistricts, function () {
                LoadDistricts();
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