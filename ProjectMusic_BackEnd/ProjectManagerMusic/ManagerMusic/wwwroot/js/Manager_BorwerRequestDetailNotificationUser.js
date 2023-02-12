var Message = "Không được bỏ trống!";
var Html = '<i class="fas fa-check"></i>';
$(document).ready(function(){
	$("#modal_SentGmailPassword").hide();
})

//sent gmail password
$("#btn_BcRequestPassword").click(function(){
	$("#modal_SentGmailPassword").show();
});
$("#btn_closeGmail").click(function(){
	$("#modal_SentGmailPassword").hide();
})
function TxtUser(){
	var Get_User = $("#TxtUser").val();
	$("#Ok_User").empty();
	$("#Error_User").empty();
	if(Get_User.length == 0 || Get_User == null){
		$("#Error_User").append(Message);
		return
	}else{
		$("#Ok_User").append(Html);
		return;
	}
}
function TxtContent(){
	var Get_Content = $("#TxtContent").val();
	$("#Ok_Content").empty();
	$("#Error_Content").empty();
	if (Get_Content.length == 0 || Get_Content == null) {
		$("#Error_Content").append(Message);
		return
	}else{
		$("#Ok_Content").append(Html);
		return;
	}
}
$("#btn_SentGmail").click(function(){
	var Get_User = $("#TxtUser").val();
	if(Get_User.length == 0 || Get_User == null){
		$("#Ok_User").empty();
		$("#Error_User").empty();
		$("#Error_User").append(Message);
		return;
	}
	var Get_Content = $("#TxtContent").val();
	if (Get_Content.length == 0 || Get_Content == null) {
		$("#Ok_Content").empty();
	$("#Error_Content").empty();
		$("#Error_Content").append(Message);
		return
	}
	$("#modal_LoadingSignUp").show();
	$("#modal_SentGmailPassword").hide();
});

//---------------------------------------------------
//anlock user
$("#btn_BcRequestAnlock").click(function(){
	$("#modal_AnLockPassword").show();
});
$("#btn_closeblock").click(function(){
	$("#modal_AnLockPassword").hide();
})
function TxtUserblock(){
	var Get_User = $("#TxtUserblock").val();
	$("#Ok_Userblock").empty();
	$("#Error_Userblock").empty();
	if(Get_User.length == 0 || Get_User == null){
		$("#Error_Userblock").append(Message);
		return
	}else{
		$("#Ok_Userblock").append(Html);
		return;
	}
}
function TxtContentblock(){
	var Get_Content = $("#TxtContentblock").val();
	$("#Ok_Contentblock").empty();
	$("#Error_Contentblock").empty();
	if (Get_Content.length == 0 || Get_Content == null) {
		$("#Error_Contentblock").append(Message);
		return
	}else{
		$("#Ok_Contentblock").append(Html);
		return;
	}
}
$("#btn_Anlock").click(function(){

	var Get_User = $("#TxtUserblock").val();
	if(Get_User.length == 0 || Get_User == null){
		$("#Ok_Userblock").empty();
		$("#Error_Userblock").empty();
		$("#Error_Userblock").append(Message);
		return
	}

	var Get_Content = $("#TxtContentblock").val();
	if (Get_Content.length == 0 || Get_Content == null) {
		$("#Ok_Contentblock").empty();
		$("#Error_Contentblock").empty();
		$("#Error_Contentblock").append(Message);
		return
	}
	
	$("#modal_LoadingSignUp").show();
	$("#modal_AnLockPassword").hide();
})