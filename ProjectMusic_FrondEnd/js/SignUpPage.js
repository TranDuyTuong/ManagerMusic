//validate form signup
var MessageValidate = "Không được bỏ trống!";
var Hmtl = '<i class="fas fa-check"></i>';
var D_Name;
var D_BrithDay_Day;
var D_BrithDay_Month;
var D_BrithDay_Year;
var D_Email;
var D_Password;

//loading
$(document).ready(function(){
	D_Name = "";
	D_BrithDay_Day = "";
	D_BrithDay_Month = "";
	D_BrithDay_Year = "";
	D_Email = "";
	D_Password = "";
});

//validate Name
function checkvalueName(){
	var NameUser = $("#Txt_Name").val();
	var ValidateName = $("#ValidaName").empty();
	var ValiDateNameDone = $("#checkOkName").empty();
	if (NameUser.length == 0) {
		ValidateName.append(MessageValidate);
		D_Name = "";
		return;
	}else{
		ValiDateNameDone.html(Hmtl);
		D_Name = NameUser;
		return;
	}
}

//validate Birthday
function checkvalueBirthday(){
	var Get_Date = new Date($("#Txt_Birthday").val());
	D_BrithDay_Day = Get_Date.getDate();
	D_BrithDay_Month = Get_Date.getMonth() + 1;
	D_BrithDay_Year = Get_Date.getFullYear();
	var ValidateBirthdayDone = $("#checkOkBirthday").empty();
	ValidateBirthdayDone.html(Hmtl);
	return;
}

//valiadate Email
function checkvalueGmail(){
	var GmailUser = $("#Txt_Gmail").val();
	var ValidateGmail = $("#ValidaGmail").empty();
	var ValidateEmailDone = $("#checkOkGmail").empty();
	if (GmailUser.length == 0) {
		ValidateGmail.append(MessageValidate);
		D_Email = "";
		return;
	}else{
		ValidateEmailDone.html(Hmtl);
		D_Email = GmailUser;
		return;
	}
}

//validate Password
function checkvaluePassword(){
	var PasswordUser = $("#Txt_Password").val();
	var ValidatePassword = $("#ValidaPassword").empty();
	var ValidatePasswordDone = $("#checkOkPassword").empty();
	if (PasswordUser.length == 0) {
		ValidatePassword.append(MessageValidate);
		D_Password = "";
		return;
	}else{
		ValidatePasswordDone.html(Hmtl);
		D_Password = PasswordUser;
		return;
	}
}

//SignUp Admin
$("#btn_SignUp").click(function(){

	var Get_Date = new Date($("#Txt_Birthday").val());
	D_BrithDay_Day = Get_Date.getDate();
	D_BrithDay_Month = Get_Date.getMonth() + 1;
	D_BrithDay_Year = Get_Date.getFullYear();
	if(isNaN(D_BrithDay_Day) || isNaN(D_BrithDay_Month) || isNaN(D_BrithDay_Year)){
		var ValidateBirthday = $("#ValidaBirthday").empty();
		ValidateBirthday.append(MessageValidate);
		return;
	}else{
		$("#ValidaBirthday").empty();
		var ValidateBirthdayDone = $("#checkOkBirthday").empty();
		ValidateBirthdayDone.html(Hmtl);
	}

	var GetName_User = D_Name;
	var GetGmail_User = D_Email;
	var GetPassword_User = D_Password;
	if (GetName_User == "" || GetGmail_User == "" || GetPassword_User == "") {
		//name
		if (GetName_User == "") {
			var ValidateName = $("#ValidaName").empty();
			ValidateName.append(MessageValidate);
			D_Name = "";
		}
		//email
		if (GetGmail_User == "") {
			var ValidateGmail = $("#ValidaGmail").empty();
			ValidateGmail.append(MessageValidate);
			D_Email = "";
		}
		//password
		if(GetPassword_User == ""){
			var ValidatePassword = $("#ValidaPassword").empty();
			ValidatePassword.append(MessageValidate);
			D_Password = "";
		}
		return;
	}
	$("#modal_LoadingSignUp").show();
});