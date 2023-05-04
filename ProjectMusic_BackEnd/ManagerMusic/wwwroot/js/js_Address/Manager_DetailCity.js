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

function ChangeSelection() {
    var idSelection = $("#TxtSelection").val();
    $("#TitleData").empty();
    $("#BodyRemove").empty();
    $("#TotalCount").empty();
    var count = 0;
    $.ajax({
        url: "/ManagerAddress/GetAllDistrictOrStaffByCity",
        type: "get",
        data: {
            IdCity: $("#IdCity").val(),
            Selection: idSelection
        },
        success: function (result) {
            var htmlTitle = "";
            switch (result.status) {
                case 1:
                    toastr.error("Thông Báo Lỗi", "Không tìm thấy thông tin của Tỉnh/Tp này!");
                    break;
                case 2:
                    $("#TitleData").append("Danh Sách Các Quận/Huyện Liên Quan")
                    htmlTitle += '<table class="table">'
                    htmlTitle +='<thead>'    
                    htmlTitle +='<tr>'      
                    htmlTitle +='<th scope="col">Mã Quận/Huyện</th>'          
                    htmlTitle +='<th scope="col">Tên Quận/Huyện</th>'        
                    htmlTitle +='<th scope="col">Tên Tỉnh/Tp</th>'             
                    htmlTitle +='</tr>'      
                    htmlTitle +='</thead>'   
                    htmlTitle +='<tbody id="BodyDistrict">'  
                    htmlTitle +='</tbody>'    
                    htmlTitle += '</table>'
                    $("#BodyRemove").append(htmlTitle);
                    $("#BodyDistrict").empty();
                    $.each(result.selectedDistricts, function (key, item) {
                        count++;
                        var html = "";
                        html += '<tr>';
                        html += '<th scope="row">' + item.idDistrict + '</th>';
                        html += '<td>' + item.nameDistrict + '</td>';
                        html += '<td>' + item.nameCity + '</td>';   
                        html += '</tr>';
                        $("#BodyDistrict").append(html);
                    })
                    $("#TotalCount").append("Tổng Số Quận/Huyện Trực Thuộc: " + count);
                    break;
                case 3:
                    $("#TitleData").append("Danh Sách Các Nhân Viên Liên Quan")
                    htmlTitle += '<table class="table">'
                    htmlTitle += '<thead>'
                    htmlTitle += '<tr>'
                    htmlTitle += '<th scope="col">Mã</th>'
                    htmlTitle += '<th scope="col">Tên Nhân Viên</th>'
                    htmlTitle += '<th scope="col">Tên Tỉnh/Tp</th>'
                    htmlTitle += '</tr>'
                    htmlTitle += '</thead>'
                    htmlTitle += '<tbody id="BodyStaff">'
                    htmlTitle += '</tbody>'
                    htmlTitle += '</table>'
                    $("#BodyRemove").append(htmlTitle);
                    $("#BodyStaff").empty();
                    $.each(result.selectedStaffs, function (key, item) {
                        count++;
                        var html = "";
                        html += '<tr>';
                        html += '<th scope="row">' + item.idUser + '</th>';
                        html += '<td>' + item.nameStaff + '</td>';
                        html += '<td>' + item.nameCity + '</td>';
                        html += '</tr>';
                        $("#BodyStaff").append(html);
                    })
                    $("#TotalCount").append("Tổng Số Nhân Viên Trực Thuộc: " + count);
                    break;
                default:
                    toastr.error("Thông Báo Lỗi!", "Dữ liệu bạn cần tìm kiếm không tồn tại vui lòng kiểm tra lại");
                    break;
            }
            return;
        }
    })
}
$("#Btn_CloseRemove").click(function () {
    window.location.reload();
})
$("#Btn_SubmitRemove").click(function () {

});