
var head = $("#head").val();
var next = $("#next").val();
var last = $("#last").val();
var Before = $("#Before").val();

$(document).ready(function () {
    LoadCitysRemove();
    checkData = 0;
})

var PageIndex = 0;
var PageSize = 20;
var checkData = 0;
//Load Citys delete
function LoadCitysRemove() {
    checkData = 0;
    var count = 0;
    $("#SeachCitys").empty();
    $("#body_Citys").empty();
    $("#TotalCitys").empty();
    $("#TotalItem").empty();
    $("#ItemInPage").empty();
    $.ajax({
        url: "/ManagerAddress/JsonGetAllCitysRemove",
        type: "get",
        data: {
            pageIndex: PageIndex,
            pageSize: PageSize,
            seach: $("#TxtSeachValue").val()
        },
        success: function (result) {
            console.log(result);
            if (result.totalSeach != 0) {
                var strMessage = "Mã Tỉnh/Tp Tìm Kiếm: " + $("#TxtSeachValue").val() + " - - " + " Đã Tìm Thấy: " + result.totalSeach + " Kết Quả";
                $("#SeachCitys").append(strMessage);
            }
            $.each(result.l_Citys, function (key, item) {
                var html = "";
                count++;
                html += '<tr id="' + item.cityId + '">';
                html += '<th scope="row">';
                html += '<input type="checkbox" onclick="funcCheckCity()" class="case" name="case" value="' + item.cityId + '"/>';
                html += '</th>';
                html += '<td>' + item.cityId + '</td>';
                html += '<td>' + item.cityName + '</td>';
                html += '<td>' + item.createDate + '</td>';
                html += '<td>' + item.timeCreate + '</td>';
                html += '<td>' + item.symbol + '</td>';
                html += '<td>' + item.areaCode + '</td>';
                html += '</tr>';
                $("#body_Citys").append(html);
            })
            $("#TotalItem").append(PageIndex)
            $("#ItemInPage").append(count)
            $("#TotalCitys").append(result.totalCitys)
            //paing
            paging(result.totalCitys, function () {
                LoadCitysRemove();
            })
        }
    })
}
//----------------------------------------------
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

//Seach Citys
$("#btn_Seach").click(function () {
    LoadCitysRemove();
})

//--------------------------------------------------------------------------
//funtion choose all checkbox option
document.getElementById('selectall').onclick = function (e) {
    var checkbox = document.getElementsByName('case');
    if (this.checked) {
        for (var i = 0; i < checkbox.length; i++) {
            checkbox[i].checked = true
        }
    }
    else {
        for (var i = 0; i < checkbox.length; i++) {
            checkbox[i].checked = false
        }
    }
    validatecheckbox();
};


document.getElementsByName('case').onclick = function (e) {
    console.log("tui")
}

function validatecheckbox() {
    var checkbox = document.getElementsByName('case');
    var countcheck = 0;
    for (var i = 0; i < checkbox.length; i++) {
        if (checkbox[i].checked === true) {
            countcheck = 1;
        }
    }
    if (countcheck != 0) {
        document.querySelector("#btn_activerCityRemove").disabled = false;
    } else {
        document.querySelector("#btn_activerCityRemove").disabled = true;
    }
}