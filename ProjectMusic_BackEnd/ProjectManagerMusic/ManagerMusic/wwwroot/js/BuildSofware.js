var Log_function = $("#Log_function").val();
var enter_contribution = $("#enter_contribution").val();
var Nofitication_Success = $("#Nofitication_Success").val();
var ErrorNotification = $("#ErrorNotification").val();
var submittedconstructive_comments = $("#submittedconstructive_comments").val();
var Submit_failed = $("#Submit_failed").val();


$(document).ready(function () {
    LoadUserLoginCheck()
});

//load check user login
function LoadUserLoginCheck() {
    $("#ErorrLogin").empty();
    $("#ErorrContent").empty();
    $.ajax({
        url: "/BuildSoftware/JsonBuildSoftware",
        type: "get",
        success: function (result) {
            if (result == 1) {
                document.getElementById('SentContribute').style.display = "none";
                $("#ErorrLogin").append(Log_function)
            } else {
                document.getElementById('SentContribute').style.display = "block";
            }
            return;
        }
    })
}

//sent contribute
$("#SentContribute").click(function (result) {
    $("#ErorrContent").empty();
    var Value = $("#TxtContent").val();
    if (Value.length == 0) {
        $("#ErorrContent").append(enter_contribution)
    } else {
        $.ajax({
            url: "/BuildSoftware/SentContributeUser/",
            type: "post",
            data: {
                Content: Value
            },
            success: function (result) {
                switch (result.idStatus) {
                    case 1:
                        toastr.success(submittedconstructive_comments, Nofitication_Success);
                        $("#TxtContent").val('');
                        document.getElementById("TxtContent").focus();
                        break;
                    default:
                        toastr.error(Submit_failed, ErrorNotification);
                        document.getElementById("TxtContent").focus();
                        break;
                }
                return;
            }
        })
    }
    return;
});