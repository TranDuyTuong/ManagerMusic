var Hmtl = '<i class="fas fa-check"></i>';
var MessageValidate = "Không được bỏ trống!";
var D_Account;
var D_Password;

$(document).ready(function(){
	D_Account = "";
	D_Password = "";
});

//validate account
function CheckvalueAccount(){
	var NameUser = $("#Txt_Account").val();
	var ValidateAccount = $("#ValidaAccount").empty();
	var ValiDateAccountDone = $("#checkOkEmail").empty();
	if (NameUser.length == 0) {
		ValidateAccount.append(MessageValidate);
		D_Account = "";
		return;
	}else{
		ValiDateAccountDone.html(Hmtl);
		D_Account = NameUser;
		return;
	}
};

//validate password
function checkvaluePassword(){
	var PasswordUser = $("#Txt_Password").val();
	var ValidatePassword = $("#ValidaPassword").empty();
	var ValiDatePasswordDone = $("#checkOkPassword").empty();
	if (PasswordUser.length == 0) {
		ValidatePassword.append(MessageValidate);
		D_Password = "";
		return;
	}else{
		ValiDatePasswordDone.html(Hmtl);
		D_Password = PasswordUser;
		return;
	}
};

//SignIn Admin
$("#Btn_SignIn").click(function(){
	if (D_Account == "" || D_Password == "") {
		var ValidatePassword = $("#ValidaPassword").empty();
		var ValidateAccount = $("#ValidaAccount").empty();
		if(D_Account == ""){
			ValidateAccount.append(MessageValidate);
		}
		if(D_Password == ""){
			ValidatePassword.append(MessageValidate);
		}
		return;
	}
	$("#modal_LoadingSignIn").show();
	return;
});

//modal sent error account
$("#btn_modalError").click(function(){
	$("#modal_Notification_Error").show();
	return;
})
$("#Close_NotificationError").click(function(){
	$("#modal_Notification_Error").hide();
	return;
})

//sent img error
var Save_Url;
$("#img_Avata").change(function(e){
	if (Save_Url != null) {
		URL.revokeObjectURL(Save_Url);
	}
	const file = e.target.files[0] // this Object holds a reference to the file on disk
	console.log(file);
	const url = URL.createObjectURL(file); // this points to the File object we just created
	Save_Url = url;
	document.getElementById('Src_Avata').src = url
})