var code = $("#code").val();
var Request_Date = $("#Request_Date").val();
var Processing_Date = $("#Processing_Date").val();
var Finish_Date = $("#Finish_Date").val();
$(document).ready(function () {
    LoadingData();
})

//load data
function LoadingData() {
    $("#Notresolved").empty();
    $("#Solving").empty();
    $("#Solved").empty();
    $("#TotalNotresolved").empty();
    $("#TotalSolving").empty();
    $("#TotalSolved").empty();
    $("#TotalProgress").empty();
    $.ajax({
        url: "/ManagerRequestUser/JsonProgressRequestUser/",
        type: "get",
        success: function (result) {
            $("#TotalNotresolved").append(result.l_Notresolved.length);
            $("#TotalSolving").append(result.l_Solving.length);
            $("#TotalSolved").append(result.l_Solved.length);
            var Count = result.l_Notresolved.length + result.l_Solving.length + result.l_Solved.length;
            $("#TotalProgress").append(Count);
            //L_Notresolved
            $.each(result.l_Notresolved, function (key, item) {
                var Html = "";
                Html += '<div style="margin: 15px 15px;">';
                Html += '<div class="az-content-breadcrumb">';
                Html += '<span><a href="#" style="color: black;">' + item.fullName + '</a></span>';
                Html += '<span><a href="#" style="color: black;">' + item.titleRequest + '</a></span>';
                Html += '<span><a href="#" style="color: black;">' + code + ': ' + item.id + '</a></span>';
                Html += '<span><a href="#" style="color: black;">' + Request_Date + ': ' + item.str_DateRequest + '</a></span>';
                Html += '</div>';
                Html += '<div class="progress">';
                Html += '<div class="progress-bar" role="progressbar" style="width: 33%" aria-valuenow="33" aria-valuemin="0" aria-valuemax="100"></div>';
                Html += '</div>';
                Html += '</div>';
                $("#Notresolved").append(Html);
            });

            //L_Solving
            $.each(result.l_Solving, function (key, item) {
                var Html = "";
                Html += '<div style="margin: 15px 15px;">';
                Html += '<div class="az-content-breadcrumb">';
                Html += '<span><a href="#" style="color: black;">' + item.fullName + '</a></span>';
                Html += '<span><a href="#" style="color: black;">' + item.titleRequest + '</a></span>';
                Html += '<span><a href="#" style="color: black;">' + code + ': ' + item.id + '</a></span>';
                Html += '<span><a href="#" style="color: black;">' + Processing_Date + ': ' + item.str_DateHandled + '</a></span>';
                Html += '</div>';
                Html += '<div class="progress">';
                Html += '<div class="progress-bar bg-warning" role="progressbar" style="width: 66%" aria-valuenow="66" aria-valuemin="0" aria-valuemax="100"></div>';
                Html += '</div>';
                Html += '</div>';
                $("#Solving").append(Html);
            });

            //L_Solved
            $.each(result.l_Solved, function (key, item) {
                var Html = "";
                Html += '<div style="margin: 15px 15px;">';
                Html += '<div class="az-content-breadcrumb">';
                Html += '<span><a href="#" style="color: black;">' + item.fullName + '</a></span>';
                Html += '<span><a href="#" style="color: black;">' + item.titleRequest + '</a></span>';
                Html += '<span><a href="#" style="color: black;">' + code + ': ' + item.id + '</a></span>';
                Html += '<span><a href="#" style="color: black;">' + Finish_Date + ': ' + item.str_DateSuccessFull + '</a></span>';
                Html += '</div>';
                Html += '<div class="progress">';
                Html += '<div class="progress-bar bg-success" role="progressbar" style="width: 100%" aria-valuenow="100" aria-valuemin="0" aria-valuemax="100"></div>';
                Html += '</div>';
                Html += '</div>';
                $("#Solved").append(Html);
            });

        }
    })
}

$("#ResetProgress").click(function () {
    window.location.reload();
});
