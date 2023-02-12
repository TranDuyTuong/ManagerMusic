var Message = "Vui lòng chọn hướng giải quyết!";
var IdRequest = $("#IdRequest").val();
$(document).ready(function () {
    LoadDataRequestUser();
});

//load data request
function LoadDataRequestUser() {
    $("#TitleNameUser").empty();
    $("#StatsuRequest").empty();
    $("#TxtContentRequest").empty();
    $("#TxtSuccessRequest").empty();
    $.ajax({
        url: "/ManagerRequestUser/JsonDetailRequestUser",
        type: "get",
        data: {
            IdRequest: IdRequest
        },
        success: function (result) {
            switch (result.detailRequest_User.statusFindData) {
                case true:
                    $("#TitleNameUser").append(result.detailRequest_User.nameRole + " - " + result.detailRequest_User.nameUser);
                    $("#TxtNameUser").val(result.detailRequest_User.nameUser);
                    $("#TxtGmails").val(result.detailRequest_User.gmail);
                    $("#TxtDateSentse").val(result.detailRequest_User.stR_DateRequest);
                    $("#TxtTitleRequest").val(result.detailRequest_User.titleRequest);
                    $("#TxtContentRequest").append(result.detailRequest_User.contentRequest);
                    $("#IdRequestUsers").val(result.detailRequest_User.idRequest);
                    $("#IdUsers").val(result.detailRequest_User.idUser);
                    $("#StatsuRequest").append(result.detailRequest_User.nameRecende)

                    //Receive Request
                    switch (result.detailRequest_User.idRecende) {
                        case 1:
                            //setdata for select
                            $("#Selectsolution").empty();
                            var HmtlDefaul = '<option selected value="0">Chọn hướng xử lý</option>';
                            $("#Selectsolution").append(HmtlDefaul);
                            $.each(result.l_StatusRequest, function (key, item) {
                                var html = '';
                                html += '<option value="' + item.idStatus + '">' + item.nameStatus + '</option>'
                                $("#Selectsolution").append(html);
                            })
                            document.getElementById('btn_HandledRequest').style.display = 'none';
                            break;
                        case 2:
                            //show name Recende
                            document.getElementById("Selectsolution").style.display = 'none';
                            document.getElementById("TxtNameTypeSent").style.display = 'block';
                            $("#TxtNameTypeSent").val(result.detailRequest_User.nameTypeSent);
                            //show Date Handled
                            document.getElementById("DateHandled").style.display = 'block';
                            $("#TxtDateHandled").val(result.detailRequest_User.str_DateHandled);
                            $("#TxtIdTypeSent").val(result.detailRequest_User.idTypeSent);
                            //show button
                            document.getElementById('btn_AcceptRequest').style.display = 'none';
                            document.getElementById('btn_RemoveRequest').style.display = 'none';
                            document.getElementById('btn_HandledRequest').style.display = 'block';
                            break;
                        case 3:
                            //show name Recende
                            document.getElementById("Selectsolution").style.display = 'none';
                            document.getElementById("TxtNameTypeSent").style.display = 'block';
                            $("#TxtNameTypeSent").val(result.detailRequest_User.nameTypeSent);
                            //show Date Handled
                            document.getElementById("DateHandled").style.display = 'block';
                            $("#TxtDateHandled").val(result.detailRequest_User.str_DateHandled);
                            $("#TxtIdTypeSent").val(result.detailRequest_User.idTypeSent);
                            //show button
                            document.getElementById('btn_AcceptRequest').style.display = 'none';
                            document.getElementById('btn_RemoveRequest').style.display = 'none';
                            document.getElementById('btn_HandledRequest').style.display = 'none';
                            //Show Date Successs
                            document.getElementById("DateSuccess").style.display = 'block';
                            $("#TxtDateSuccess").val(result.detailRequest_User.str_DateSuccess);
                            $("#TxtSuccessRequest").append("Đã Xử Lý Thành Công Yêu Cầu Này")
                            break;
                    }
                    break;
                default:
                    $("#BodyDetailData").empty();
                    var html = "<p>Không tìm thấy thông tin dữ liệu bạn yêu cầu vui lòng kiểm tra lại. Xin cảm ơn!<p/>"
                    $("#BodyDetailData").append(html);
                    break;
            }
        }
    })
};

//accept request user
$("#btn_AcceptRequest").click(function(){
    var D = $("#Selectsolution").val();
    $("#ErrorData").empty();
    if(D.length == 0 || D == 0){
        $("#ErrorData").append(Message);
        return
    }
    $("#modal_LoadingSignUp").show();
    $.ajax({
        url: "/ManagerRequestUser/JsonAcceptRequestUser/",
        type: "post",
        data: {
            IdRequest: $("#IdRequestUsers").val(),
            IdUser: $("#IdUsers").val(),
            TypeSent: D
        },
        success: function (result) {
            $("#modal_LoadingSignUp").hide();
            switch (result.id_Notifi) {
                case 1:
                    toastr.error("Không tìm thấy mã yêu cầu này", "Thông Báo Lỗi!");
                    break;
                case 2:
                    toastr.success("Tiếp nhận yêu cầu của người dùng thành công!", "Thông Báo Thành Công!");
                    LoadDataRequestUser();
                    break;
                case 3:
                    toastr.error("Không tìm thấy mã loại gửi này", "Thông Báo Lỗi!");
                    break;
            }
        }
    })
});

//--------------------------------
//remove request
$("#btn_RemoveRequest").click(function(){
    $("#modal_CancelRequest").show();
});
$("#btn_closeCancel").click(function(){
    $("#modal_CancelRequest").hide();
})
$("#btn_Agrren").click(function(){
    $("#modal_LoadingSignUp").show();
    $("#modal_CancelRequest").hide();
});
$("#btn_Cancel").click(function(){
    $("#modal_CancelRequest").hide();
});

//------------------------------------
//handled request
$("#btn_HandledRequest").click(function () {
    var Id = $("#TxtIdTypeSent").val();
    $.ajax({
        url: "/ManagerRequestUser/JsonCheckTypeSentUser/",
        type: 'get',
        data: {
            IdTypeSent: Id
        },
        success: function (result) {
            switch (result.idTypeSent) {
                case 1:
                    toastr.error("Không tìm thấy mã loại xử lý này", "Thông Báo Lỗi!");
                    break;
                case 2:
                    toastr.error("Loại xử lý này tạm thời bị khóa", "Thông Báo Lỗi!");
                    break;
                case 3:
                    $("#modal_SentGmailRequest").show();
                    break;
            }
            return;
        }
    })
})
$("#btn_close").click(function () {
    $("#modal_SentGmailRequest").hide();
    window.location.reload();
})
$("#BtnSentGmailRequest").click(function () {
    var Value = $("#TxtContentSent").val();
    if (Value.length == 0) {
        toastr.error("Vui lòng nhập nội dung của thư", "Thông Báo Lỗi!");
    } else {
        var files = $("#FileValue").prop("files")
        var formData = new FormData();
        for (var i = 0; i < files.length; i++) {
            formData.append("L_File", files[i]);
        }
        var Create_Gmail = {
            ContentSent: Value,
            TitleSent: 'Trả lời yêu cầu của người dùng ' + $("#TxtNameUser").val() + ' được yêu cầu vào ngày ' + $("#TxtDateSentse").val(),
            IdTypeSent: $("#TxtIdTypeSent").val(),
            IdUser: $("#IdUsers").val(),
            IdRequest: IdRequest,
            IdRead: 1,
            Email: $("#TxtGmails").val()
        }
        formData.append("ContentAnswerSentRequestUser", JSON.stringify(Create_Gmail));
        $("#modal_LoadingSignUp").show();
        $.ajax({
            url: "/ManagerRequestUser/JsonSentGmailRequestUser/",
            type: "post",
            data: formData,
            contentType: false,
            processData: false,
            success: function (result) {
                $("#modal_LoadingSignUp").hide();
                switch (result.id_Notifi) {
                    case 1:
                        toastr.error("Không tìm thấy mã yêu cầu này, vui lòng kiểm tra lại", "Thông Báo Lỗi!");
                        break
                    case 2:
                        toastr.error("Không tìm thấy Email mà người dùng yêu cầu, vui lòng kiểm tra lại", "Thông Báo Lỗi");
                        break;
                    case 3:
                        toastr.success("Gửi Email trả lời yêu cầu người dùng thành công", "Thông Báo Thành Công!");
                        $("#modal_SentGmailRequest").hide();
                        $("#TxtContentSent").empty();
                        $("#FileValue").val('');
                        LoadDataRequestUser();
                        break;
                    case 4:
                        toastr.error("Gửi Email thất bại, vui lòng kiểm tra lại", "Thông Báo Lỗi!");
                        break;
                }
            }
        })
    }
    return;
})