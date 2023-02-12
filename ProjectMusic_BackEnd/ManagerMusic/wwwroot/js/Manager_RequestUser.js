var Apply = "Áp Dụng"
var Cancel = "Hủy Bỏ"
var head = $("#head").val();
var next = $("#next").val();
var last = $("#last").val();
var Before = $("#Before").val();

$(document).ready(function(){
    $("#Modal_ShowFuilterDate").hide();
    $(".applyBtn").empty();
    $(".cancelBtn").empty();
    $(".applyBtn").append(Apply);
    $(".cancelBtn").append(Cancel);
    SelectStatus = 1;
    LoadDataRequestUser();
    LoadSelectStatus();
});

var Page = 1;
var Size = 15;
var SelectStatus = 1;
//load data request user
function LoadDataRequestUser() {
    $("#BodyRequestUser").empty();
    $("#TotalItem").empty();
    $("#ItemInPage").empty();
    $("#TotalRequest").empty();
    $.ajax({
        url: "/ManagerRequestUser/JsonManagerRequestUser/",
        type: "get",
        data: {
            Page: Page,
            Size: Size,
            Selecter: SelectStatus
        },
        success: function (result) {
            var count = 0;
            $.each(result.l_RequestUser, function (key, item) {
                var html = "";
                count++;
                html += '<tr id="' + item.id + '">';
                html += '<td>' + count + '</td>';
                html += '<td>' + item.nameUser + '</td>';
                html += '<td>' + item.title + '</td>';
                html += '<td>' + item.str_DateRequest + '</td>';
                switch (item.idReceive) {
                    case 1:
                        html += '<td style="color: red;">' + item.nameReceive + '</td>';
                        break;
                    case 2:
                        html += '<td style="color: blue;">' + item.nameReceive + '</td>';
                        break;
                    case 3:
                        html += '<td style="color: green;">' + item.nameReceive + '</td>';
                        break;
                }
                html += '<td><a href="/ManagerRequestUser/Page_DetailRequestUser/?IdRequest=' + item.id + '" style="border: none;" class="btn btn-outline-secondary" ata-bs-toggle="tooltip" data-bs-placement="top" title ="Chi Tết Yêu Cầu"><i class="fas fa-folder-open"></i></a></td>';
                html += '</tr>';
                $("#BodyRequestUser").append(html);
            })
            $("#TotalItem").append(result.totalRequestUser);
            $("#ItemInPage").append(count);
            $("#TotalRequest").append(result.totalRequestUser);
            //paing
            paging(result.totalRequestUser, function () {
                LoadDataRequestUser();
            })
        }
    })
}
//paing
function paging(totalRoll, callback) {
    var totalPage = Math.ceil(totalRoll / Size);
    $('#pagination').twbsPagination({
        totalPages: (totalPage == 0) ? 1 : totalPage,
        first: head,
        next: next,
        last: last,
        prev: Before,
        visiblePages: 10,
        onPageClick: function (event, page) {
            Page = page;
            setTimeout(callback, 200);
        }
    });
}

//-------------------------------------------------
//load select status 
function LoadSelectStatus() {
    $("#SelectStatusRequest").empty();
    var htmlDefaul = '<option selected value="0">Lựa Chọn Trạng Thái ...</option>';
    $("#SelectStatusRequest").append(htmlDefaul);
    $.ajax({
        url: "/ManagerRequestUser/JsonGetAllRevice",
        type: "get",
        success: function (result) {
            $.each(result, function (key, item) {
                var html = "";
                html += '<option value="' + item.id + '">' + item.name + '</option>';
                $("#SelectStatusRequest").append(html);
            })
        }
    })
}
//select status
$("#SelectStatusRequest").change(function () {
    var Value = $(this).val();
    if (Value == 0) {
        toastr.error("Vui Lòng Lựa Chọn Một Trạng Thái", "Thông Báo Lỗi!");
    } else {
        SelectStatus = Value;
        LoadDataRequestUser();
    }
    return;
});
//seach name user
function ChangeTextName(){
    var v = $("#TxtNameUser").val();
    console.log(v);
}
//------------------------------------------------
//setting date time
$('input[name="daterange"]').daterangepicker({
    opens: 'left'
  });

//fuilter date request
$("#modaFiulterDay").click(function(){
    $("#Modal_ShowFuilterDate").show();
    return;
});
var MessaeDate = "Vui lòng chọn ngày!";
$("#btn_FuilterDate").click(function(){
    var get_DateTime = $("#rangeDate").val();
    $("#TxtErrorData").empty();
    if (get_DateTime == null || get_DateTime.length == 0) {
        $("#TxtErrorData").append(MessaeDate);
        return;
    }else{
        alert(get_DateTime);
        return;
    }
});
$("#btn_CLoseFuilterDate").click(function(){
    $("#Modal_ShowFuilterDate").hide();
    return;
});
