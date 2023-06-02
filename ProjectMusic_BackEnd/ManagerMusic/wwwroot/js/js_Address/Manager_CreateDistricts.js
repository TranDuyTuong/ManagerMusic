var head = $("#head").val();
var next = $("#next").val();
var last = $("#last").val();
var Before = $("#Before").val();

var pageSize = 20;
var pageIndex = 1;
$("#BtnReadExcelFile").click(function () {
    var CheckImportFile = $("#formFile").val();
    if (CheckImportFile.length == 0 || CheckImportFile == null || CheckImportFile == undefined) {
        toastr.error("Thông Báo Lỗi!", "Vui lòng chọn file Excel Cần Import");
    } else {
        LoadDistricts();
    }
});

//Load data in file excel import
function LoadDistricts() {
    $("#TotalDistricts").empty();
    $("#body_Districts").empty();
    $("#TotalItem").empty()
    $("#ItemInPage").empty()

    $("#modal_LoadingCreateMusic").show();
    var files = $("#formFile").prop("files")
    var formData = new FormData();
    for (var i = 0; i < files.length; i++) {
        formData.append("FileExcel", files[i]);
    }
    formData.append("PageIndex", pageIndex);
    formData.append("PageSize", pageSize);
    $.ajax({
        url: "/ManagerAddress/JsonReadFileExcelDistricts",
        type: "post",
        data: formData,
        contentType: false,
        processData: false,
        success: function (result) {
            console.log(result);
            $("#modal_LoadingCreateMusic").hide();
            var count = 0;
            switch (result.status) {
                case 0:
                    $.each(result.l_Districts, function (key, item) {
                        var html = "";
                        count++;
                        html += '<tr>';
                        html += '<td>' + item.identifier + '</td>';
                        html += '<td>' + item.nameDistrict + '</td>';
                        html += '<td>' + item.nameCity + '</td>';
                        html += '<td>' + item.dateCreate + '</td>';
                        html += '<td>' + item.timeCreate + '</td>';
                        html += '</tr>';
                        $("#body_Districts").append(html);
                    })
                    break;
                default:
                    $("#TotalDistricts").val(0);
                    break;
            }
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

//Check data Import citys
$("#BtnCheckDataImport").click(function () {
    $("#Check_Districts").empty();
    $("#TotalCheck").empty();
    $("#NotDuplicate").empty();
    var count = 0;
    $("#modal_LoadingCreateMusic").show();
    $.ajax({
        url: "/ManagerAddress/JsonCheckDataBaseDistrict",
        type: "get",
        success: function (result) {
            $("#modal_LoadingCreateMusic").hide();
            switch (result.status) {
                case 1:
                    toastr.error("Thông Báo Lỗi!", "Không Có Danh Sách Quận/Huyện So Sánh");
                    break;
                default:
                    $("#modal_CheckData").show();
                    if (result.totalDistricts == 0) {
                        $("#NotDuplicate").append("Không Có Dữ Liệu Trùng Lặp")
                    } else {
                        $.each(result.l_Districts, function (key, item) {
                            count++;
                            var html = "";
                            html += '<tr id="' + count + '">';
                            html += '<td>' + item.nameDistrict + '</td>';
                            html += '<td>' + item.nameCity + '</td>';
                            html += '<td>' + item.dateCreate + '</td>';
                            html += '<td>' + item.timeCreate + '</td>';
                            html += '<td>' + item.status + '</td>';
                            html += '<td>' + item.identifier + '</td>';
                            html += '</tr>';
                            $("#Check_Districts").append(html);
                        })
                    }
                    $("#TotalCheck").append(result.totalDistricts);
                    break;
            }
            return;
        }
    })
})

//Create Citys In Data
$("#BtnConfim").click(function () {
    $("#TotalCreateSuccess").empty();
    $.ajax({
        url: "/ManagerAddress/JsonCreateDistricts",
        type: "get",
        success: function (result) {
            switch (result.status) {
                case 0:
                    toastr.error("Thông Báo Thất Bại", "Tạo Mới Quận/Huyện Thất Bại!");
                    document.getElementById('TotalCreateSuccess').style.color = 'red';
                    $("#TotalCreateSuccess").append("Đã Tạo Mới Thất Bại Có: " + result.totalCreateSuccess + " Quận/Huyện Được Tạo");
                    break;
                case 1:
                    toastr.success("Thông Báo Thành Công", "Tạo Mới Thành Công!");
                    $("#TotalCreateSuccess").append("Đã Tạo Mới Thành Công: " + result.totalCreateSuccess + " Quận/Huyện");
                    break;
                default:
                    toastr.error("Thông Báo Lỗi", "Danh Sách Import Tỉnh/Tp Bị Trống!");
                    break;
            }
            return;
        }
    })
});