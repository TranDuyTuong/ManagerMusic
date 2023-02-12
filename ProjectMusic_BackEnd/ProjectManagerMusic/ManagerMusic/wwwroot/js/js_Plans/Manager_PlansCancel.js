var head = $("#head").val();
var next = $("#next").val();
var last = $("#last").val();
var Before = $("#Before").val();

$(document).ready(function () {
    LoadNotificationPlan();
});

var Page_Index = 1;
var Page_Size = 10;
//load notification plan cancel
function LoadNotificationPlan() {
    $("#TxtTotalPlan").empty();
    $("#Body_Data").empty();
    $("#ItemInPage").empty();
    $("#TotalItem").empty();
    $.ajax({
        url: "/ManagerPlans/GetAllNotificationPlanCancel",
        type: "get",
        data: {
            PageIndex: Page_Index,
            PageSize: Page_Size
        },
        success: function (result) {
            var count = 0;
            $.each(result.l_NotificationPlan, function (key, item) {
                var html = "";
                count++;
                html += '<tr>';
                html += '<th scope="row">' + count + '</th>';
                html += '<td><a style="text-align:center;" href="/ManagerPlans/Page_DetailPlan/?IdPlan=' + item.idPlan + '">' + item.idPlan + '</a></td>';
                html += '<td>' + item.nameUserPlan + '</td>';
                html += '<td>' + item.nameUserRequest + '</td>';
                html += '<td>' + item.dateCreate_Str + '</td>';
                html += '<td>' + item.contentCancel + '</td>';
                html += '</tr>';
                $("#Body_Data").append(html);
            })
            $("#TxtTotalPlan").append(result.totalNotification);
            $("#ItemInPage").append(Page_Index);
            $("#TotalItem").append(count);
            //paing
            paging(result.totalNotification, function () {
                LoadNotificationPlan();
            })
        }
    })
}

//----------------------------------------------
//paing
function paging(totalRoll, callback) {
    var totalPage = Math.ceil(totalRoll / Page_Size);
    $('#pagination').twbsPagination({
        totalPages: (totalPage == 0) ? 1 : totalPage,
        first: head,
        next: next,
        last: last,
        prev: Before,
        visiblePages: 10,
        onPageClick: function (event, page) {
            Page_Index = page;
            setTimeout(callback, 200);
        }
    });
}