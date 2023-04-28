var head = $("#head").val();
var next = $("#next").val();
var last = $("#last").val();
var Before = $("#Before").val();

$(document).ready(function () {
    LoadingDetailCity();
    document.querySelector("#btn_Confirm").disabled = true
    document.querySelector("#btn_Cancel").disabled = true
    document.querySelector("#btn_Edit").disabled = false
})

// Loading Data
function LoadingDetailCity() {
    $("#body_District").empty();
    $("#body_User").empty();
    $("#TotalDistrict").empty();
    var count = 0;
    $.ajax({
        url: "/ManagerAddress/JsonDetailCitys",
        type: "get",
        data: {
            IdCitys: $("#IdCity").val()
        },
        success: function (result) {
            $("#Txt_Id").val(result.id);
            $("#Txt_Name").val(result.nameCity);
            $("#Txt_Date").val(result.createDate);
            $("#Txt_Symbol").val(result.symbol);
            $("#Txt_Area").val(result.areaCode);
            $("#Txt_Time").val(result.timeCraete);
            $.each(result.l_District, function (key, item) {
                count++;
                var html = "";
                html += '<tr id="' + item.districtId + '">';
                html += '<td>' + item.districtId + '</td>';
                html += '<td>' + item.nameDistrict + '</td>';
                html += '<td>' + item.dateCreate + '</td>';
                html += '<td>';
                html += '<a href="/ManagerAddress/PageDetailCity/?IdCitys=' + item.cityId + '" style="border: none;" lass="btn btn-outline-secondary" ata-bs-toggle="tooltip" data-bs-placement="top"><i class="fas fa-folder-open"></i></a>';
                html += '</td>';
                html += '</tr>';
                $("#body_District").append(html);
            })
            $("#TotalDistrict").append(count);
            // Show button Remove or Activer city
            if (result.status == true) {
                document.querySelector("#Btn_RemoveCity").disabled = false;
                document.querySelector("#Btn_ActiverCity").disabled = true;
            } else {
                document.querySelector("#Btn_RemoveCity").disabled = true;
                document.querySelector("#Btn_ActiverCity").disabled = false;
            }
        }
    })
}
// edit City
var Old_CityName;
var Old_Symbol;
var Old_AreaCode;

$("#btn_Edit").click(function () {
    document.querySelector("#btn_Edit").disabled = true;
    document.querySelector("#btn_Confirm").disabled = false;
    document.querySelector("#btn_Cancel").disabled = false;

    document.querySelector("#Txt_Symbol").disabled = false;
    document.querySelector("#Txt_Name").disabled = false;
    document.querySelector("#Txt_Area").disabled = false;

    Old_CityName = $("#Txt_Name").val();
    Old_Symbol = $("#Txt_Symbol").val();
    Old_AreaCode = $("#Txt_Area").val();
});

//Cancel Edit
$("#btn_Cancel").click(function () {
    document.querySelector("#btn_Edit").disabled = false;
    document.querySelector("#btn_Confirm").disabled = true;
    document.querySelector("#btn_Cancel").disabled = true;

    document.querySelector("#Txt_Symbol").disabled = true;
    document.querySelector("#Txt_Name").disabled = true;
    document.querySelector("#Txt_Area").disabled = true;

    $("#Txt_Name").val(Old_CityName);
    $("#Txt_Symbol").val(Old_Symbol);
    $("#Txt_Area").val(Old_AreaCode);
})

//Confitm Edit City
$("#btn_Confirm").click(function () {
    var name = $("#Txt_Name").val();
    var sysmbol = $("#Txt_Symbol").val();
    var area = $("#Txt_Area").val();
    if (name.length == 0 || name == null || name == "") {
        toastr.error("Thông Báo Lỗi!", "Vui lòng không bỏ trống tên Tỉnh/Tp");
        document.getElementById("Txt_Name").focus();
        return;
    }
    if (sysmbol.length == 0 || sysmbol == null || sysmbol == "") {
        toastr.error("Thông Báo Lỗi!", "Vui lòng không bỏ trống Ký Hiệu");
        document.getElementById("Txt_Symbol").focus();
        return;
    }
    if (area.length == 0 || area == 0 || area == null) {
        toastr.error("Thông Báo Lỗi!", "Vui lòng không bỏ trống Mã Khu Vực");
        document.getElementById("Txt_Area").focus();
        return;
    }
    $("#modal_LoadingCreateMusic").show();
    $.ajax({
        url: "/ManagerAddress/JsonEditCitys",
        type: "post",
        data: {
            IdCitys: $("#IdCity").val(),
            nameCity: name,
            symbol: sysmbol,
            areaCode: area
        },
        success: function (result) {
            $("#modal_LoadingCreateMusic").hide();
            switch (result.status) {
                case 1:
                    toastr.error("Thông Báo Lỗi", "Không Tìm Thấy Danh Sách Tỉnh/Tp Trong CSDL!");
                    break;
                case 2:
                    toastr.error("Thông Báo Lỗi", "Không Tìm Thấy Tỉnh/Tp Yêu Cầu Trong CSDL!");
                    break;
                case 3:
                    toastr.error("Thông Báo Lỗi", "Mã Vùng Đã Tồn Tại Vui Lòng Nhập Mã Vùng Khác!");
                    break;
                case 4:
                    toastr.success("Thông Báo Thành Công", "Cập Nhật Tỉnh/Tp Thành Công");
                    LoadingDetailCity();
                    document.querySelector("#btn_Edit").disabled = false;
                    document.querySelector("#btn_Confirm").disabled = true;
                    document.querySelector("#btn_Cancel").disabled = true;

                    document.querySelector("#Txt_Symbol").disabled = true;
                    document.querySelector("#Txt_Name").disabled = true;
                    document.querySelector("#Txt_Area").disabled = true;
                    break;
                default:
                    toastr.error("Thông Báo Lỗi", "Cập Nhật Tỉnh/Tp Thất Bại Vui Lòng Thử Lại!")
                    break;
            }
            return;
        }
    })
});
// Remove city
$("#Btn_RemoveCity").click(function () {
    $("#modal-RemoveCity").show();
});