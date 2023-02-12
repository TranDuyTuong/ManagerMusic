var Hmtl = '<i class="fas fa-check"></i>';
var MessageValidate = "Không được bỏ trống!";
var D_Email;

//loading
$(document).ready(function(){
	D_Email = "";
});

//check validate gmail
function CheckvalueEmail(){
	var Email_User = $("#Txt_Email").val();
	var Validate_Gmail = $("#ValidateEmail").empty();
	var CheckOk_Gmail = $("#checkOkEmail").empty();
	if (Email_User == "") {
		Validate_Gmail.append(MessageValidate);
		D_Email = "";
		return;
	}else{
		CheckOk_Gmail.html(Hmtl);
		D_Email = Email_User;
		return;
	}
};

//sent data email
$("#Btn_SignIn").click(function(){
	var GetData_Email = D_Email;
	var Validate_Gmail = $("#ValidateEmail").empty();
	if (GetData_Email == "") {
		Validate_Gmail.append(MessageValidate);
		return;
	}
	$("#modal_LoadingForgotPassword").show();
	$("#modal_LoadingForgotPassword").hide();
	$("#modal_ShowEmailForgorPassword").show();

});

//Close modal show Email Forgot Password
$("#Btn_Close").click(function(){
	$("#modal_ShowEmailForgorPassword").hide();
});