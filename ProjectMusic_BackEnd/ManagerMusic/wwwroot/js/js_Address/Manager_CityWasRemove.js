$(document).ready(function () {
    LoadCitysRemove();
})

var PageIndex = 0;
var PageSize = 20;
//Load Citys delete
function LoadCitysRemove() {
    var count = 0;
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
        }
    })
}