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
        LoadCitys();
    }
});

//Load data in file excel import
function LoadCitys() {
    $("#TotalCitys").empty();
    $("#body_Citys").empty();
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
        url: "/ManagerAddress/JsonReadFileExcelCitys",
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
                    $.each(result.l_Citys, function (key, item) {
                        var html = "";
                        count++;
                        html += '<tr id="' + item.areaCode + '">';
                        html += '<th scope="row">';
                        html += '<input type="checkbox" class="case" name="case" value="' + item.areaCode + '"/>';
                        html += '</th>';
                        html += '<td>' + count + '</td>';
                        html += '<td>' + item.cityName + '</td>';
                        html += '<td>' + item.createDate + '</td>';
                        html += '<td>' + item.symbol + '</td>';
                        html += '<td>' + item.areaCode + '</td>';
                        html += '<td>';
                        html += '<button type="button" style="border: none;" name="ChangeStatus" class="btn btn-outline-secondary" ata-bs-toggle="tooltip" data-bs-placement="top"><i class="fas fa-sync"></i></button>';
                        html += '<button type="button" style="border: none;" name="ViewListMusic" class="btn btn-outline-secondary" ata-bs-toggle="tooltip" data-bs-placement="top"><i class="fas fa-folder-open"></i></button>';
                        html += '</td>';
                        html += '</tr>';
                        $("#body_Citys").append(html);
                    })
                    break;
                default:
                    $("#TotalCitys").val(0);
                    break;
            }
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

//Check data Import citys
$("#BtnCheckDataImport").click(function () {
    $("#Check_Citys").empty();
    $("#TotalCheck").empty();
    $("#NotDuplicate").empty();
    var count = 0;
    $("#modal_LoadingCreateMusic").show();
    $.ajax({
        url: "/ManagerAddress/JsonCheckDataBase",
        type: "get",
        success: function (result) {
            $("#modal_LoadingCreateMusic").hide();
            switch (result.status) {
                case 1:
                    toastr.error("Thông Báo Lỗi!", "Không Có Danh Sách Tỉnh/Tp So Sánh");
                    break;
                default:
                    $("#modal_CheckData").show();
                    if (result.totalCitys == 0) {
                        $("#NotDuplicate").append("Không Có Dữ Liệu Trùng Lặp")
                    } else {
                        $.each(result.l_Citys, function (key, item) {
                            count++;
                            var html = "";
                            html += '<tr id="' + item.areaCode + '">';
                            html += '<td>' + count + '</td>';
                            html += '<td>' + item.cityName + '</td>';
                            html += '<td>' + item.createDate + '</td>';
                            html += '<td>' + item.symbol + '</td>';
                            html += '<td>' + item.areaCode + '</td>';
                            html += '</tr>';
                            $("#Check_Citys").append(html);
                        })
                    }
                    $("#TotalCheck").append(result.totalCitys);
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
        url: "/ManagerAddress/JsonCreateCitys",
        type: "get",
        success: function (result) {
            switch (result.status) {
                case 1:
                    toastr.success("Thông Báo Thành Công", "Tạo Mới Thành Công!");
                    $("#TotalCreateSuccess").append("Đã Tạo Mới Thành Công: " + result.totalCreateSuccess + " Tỉnh/Tp");
                    break;
                default:
                    toastr.error("Thông Báo Lỗi", "Danh Sách Import Tỉnh/Tp Bị Trống!");
                    break;
            }
            return;
        }
    })
});
//Close Create modal data
$("#BtnClose").click(function () {
    $("#modal_CheckData").hide();
    window.location.reload();
});