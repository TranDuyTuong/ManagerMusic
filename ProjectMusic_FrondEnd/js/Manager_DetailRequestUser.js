var Message = "Vui lòng chọn hướng giải quyết!";
//accept request user
$("#btn_AcceptRequest").click(function(){
    var D = $("#Selectsolution").val();
    $("#ErrorData").empty();
    if(D.length == 0 || D == 0){
        $("#ErrorData").append(Message);
        return
    }
    $("#modal_LoadingSignUp").show();
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