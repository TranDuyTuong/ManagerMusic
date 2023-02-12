toastr.options = {
	"closeButton": false,
	"debug": false,
	"newestOnTop": false,
	"progressBar": false,
	"positionClass": "toast-top-left",
	"preventDuplicates": false,
	"onclick": null,
	"showDuration": "300",
	"hideDuration": "1000",
	"timeOut": "5000",
	"extendedTimeOut": "1000",
	"showEasing": "swing",
	"hideEasing": "linear",
	"showMethod": "fadeIn",
	"hideMethod": "fadeOut"
}

var Hmtl = '<i class="fas fa-check"></i>';
var MessageValidate = $("#ErrorNulData").val();
var ErrorEmailNotExit = $("#ErrorEmailNotExit").val();
var ErrorLoginFail = $("#ErrorLoginFail").val();
var Notification_Error = $("#Notification_Error").val();
var ErrorEmailsyntax = $("#ErrorEmailsyntax").val();
var account_haslocked = $("#account_haslocked").val();
var EnterSender_Name = $("#EnterSender_Name").val();
var enterregistered_email = $("#enterregistered_email").val();
var title_request = $("#title_request").val();
var content_request = $("#content_request").val();
var errorimage_file = $("#errorimage_file").val();
var Nofitication_Success = $("#Nofitication_Success").val();
var emailrequested_found = $("#emailrequested_found").val();
var requestsent_successfully = $("#requestsent_successfully").val();

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
//Show Password
function myFunction() {
	var x = document.getElementById("Txt_Password");
	if (x.type === "password") {
		x.type = "text";
	} else {
		x.type = "password";
	}
}

//SignIn Admin
$("#Btn_SignIn").click(function () {
	localStorage.setItem("IdFlaps", "1");
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
	var UrlPart = $("#requestpath").val();
	$.ajax({
		url: "/Account/LoginSystem",
		type: "post",
		data: {
			Email: D_Account,
			Password: D_Password,
			Requestpath: UrlPart
		},
		success: function (result) {
			$("#modal_LoadingSignIn").hide();
			switch (result.message) {
				case 1:
					toastr.error(ErrorEmailNotExit, Notification_Error)
					break;
				case 2:
					toastr.error(ErrorLoginFail, Notification_Error)
					break;
				case 3:
					toastr.error(ErrorEmailsyntax, Notification_Error)
					break;
				case 4:
					toastr.error(account_haslocked, Notification_Error)
					break;
				default:
					window.location.href = result.linkUrl
					break;
			}
			return;
        }
    })
});

//modal sent error account
$("#btn_modalError").click(function(){
	$("#modal_Notification_Error").show();
	return;
})
$("#Close_NotificationError").click(function(){
	$("#modal_Notification_Error").hide();
	window.location.reload();
	return;
})
$("#SentBugLogin").click(function () {
	var Value_Name = $("#TxtNameSent").val();
	var Value_Email = $("#TxtEmailRegiter").val();
	var Value_Title = $("#TxtTileSent").val();
	var Value_Content = $("#TxtContentSent").val();
	var Value_File = $("#img_Avata").val();

	$("#Error_NameSent").empty();
	$("#Error_EmailRegiter").empty();
	$("#Error_TitleSent").empty();
	$("#Error_ContentSent").empty();
	$("#Error_Img").empty();

	if (Value_Name.length == 0) {
		$("#Error_NameSent").append(EnterSender_Name)
		return;
	}

	if (Value_Email.length == 0) {
		$("#Error_EmailRegiter").append(enterregistered_email);
		return;
	}

	if (Value_Title.length == 0) {
		$("#Error_TitleSent").append(title_request);
		return;
	}

	if (Value_Content.length == 0) {
		$("#Error_ContentSent").append(content_request);
		return;
	}

	if (Value_File.length == 0) {
		$("#Error_Img").append(errorimage_file);
		return;
	}

	var files = $("#img_Avata").prop("files")
	var formData = new FormData();
	for (var i = 0; i < files.length; i++) {
		formData.append("ImageBug", files[i]);
	}
	var Create_Report = {
		NameSent: Value_Name,
		EmailRegiter: Value_Email,
		TitleReprot: Value_Title,
		ContentReport: Value_Content
	}
	formData.append("SentReportBugClient_V", JSON.stringify(Create_Report));
	$.ajax({
		url: "/ReportBugClient/SentReportBugClient/",
		type: "post",
		data: formData,
		contentType: false,
		processData: false,
		success: function (result) {
			switch (result.idStatus) {
				case 1:
					toastr.error(emailrequested_found, Notification_Error)
					break;
				case 2:
					toastr.success(requestsent_successfully, Nofitication_Success);
					$("#TxtNameSent").val('');
					$("#TxtEmailRegiter").val('');
					$("#TxtTileSent").val('');
					$("#TxtContentSent").val('');
					$("#img_Avata").val('');
					$("#modal_Notification_Error").hide();
					document.getElementById('Src_Avata').src = null;
					break;
			}
			return;
        }
    })
})

//sent img error
var Save_Url;
$("#img_Avata").change(function(e){
	if (Save_Url != null) {
		URL.revokeObjectURL(Save_Url);
	}
	const file = e.target.files[0] // this Object holds a reference to the file on disk
	const url = URL.createObjectURL(file); // this points to the File object we just created
	Save_Url = url;
	document.getElementById('Src_Avata').src = url
})