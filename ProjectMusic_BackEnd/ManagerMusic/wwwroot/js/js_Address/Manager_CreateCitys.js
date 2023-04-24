var pageSize = 30;
var pageIndex = 1;
$("#BtnReadExcelFile").click(function () {
    var CheckImportFile = $("#formFile").val();
    $("#TotalCitys").empty();
    $("#body_Citys").empty();
    if (CheckImportFile.length == 0 || CheckImportFile == null || CheckImportFile == undefined) {
        toastr.error("Thông Báo Lỗi!", "Vui lòng chọn file Excel Cần Import");
    } else {
        $("#modal_LoadingCreateMusic").show();
        var files = $("#formFile").prop("files")
        var formData = new FormData();
        for (var i = 0; i < files.length; i++) {
            formData.append("FileExcel", files[i]);
        }
        $.ajax({
            url: "/ManagerAddress/JsonReadFileExcelCitys",
            type: "post",
            data: formData,
            contentType: false,
            processData: false,
            success: function (result) {
                $("#modal_LoadingCreateMusic").hide();
                var count = 0;
                switch (result.status) {
                    case 1:
                        $("#TotalCitys").val(result.totalCitys);
                        $.each(result.l_Citys, function (key, item) {
                            var html = "";
                            count++;
                            html += '<tr id="' + item.areaCode + '">';
                            html += '<th scope="row">';
                            html += '<input type="checkbox" class="case" name="case" value="' + item.areaCode + '"/>';
                            html += '</th>';
                            html += '<td>' + count + '</td>';
                            html += '<td>' + item.CityName + '</td>';
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
            }
        })
    }
    return;
});