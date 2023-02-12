var MessageValidate = "Không được bỏ trống!";
var MessageValidateEmail = "Bạn nhập định dạng email sai rồi (abc@gmail.com)";
var Hmtl = '<i class="fas fa-check"></i>';
var Save_OldBirthdayAdmin;
var Save_OldNameAdmin;
var Save_OldEmailAdmin;
var Day_Admin;
var Moth_Admin;
var Year_Admin;

//loading
$(document).ready(function () {
	Save_OldBirthdayAdmin = "";
	Save_OldNameAdmin = "";
	Save_OldEmailAdmin = "";

	Day_Admin = "";
	Moth_Admin = "";
	Year_Admin = "";
	//name
	$("#Save_NameAdmin").hide();
	$("#Edit_NameAdmin").show();
	$("#Remove_NameAdmin").hide();

	//birthday
	$("#Edit_BirthdayAdmin").show();
	$("#Save_BirthdayAdmin").hide();
	$("#Remove_BirthdayAdmin").hide();

	//email
	$("#Edit_EmailAdmin").show();
	$("#Save_EmailAdmin").hide();
	$("#Remove_EmailAdmin").hide();

});


//--------------------------------------------
$("#btn_LeverRole").click(function () {
	$("#modal_ShowLeverAccount").show();
	return;
});
//funtion close modal show lever account
$("#btn-closeLeverAccount").click(function () {
	$("#modal_ShowLeverAccount").hide();
	return;
});

//---------------------------------------------
var Save_Url;
//create url for image
document.getElementById('formFile').onchange = e => {
	if (Save_Url != null) {
		URL.revokeObjectURL(Save_Url);
	}
	const file = e.target.files[0]; // this Object holds a reference to the file on disk
	const url = URL.createObjectURL(file); // this points to the File object we just created
	Save_Url = url;
	document.getElementById('img_NewAvata').src = url
	return;
};
//show modal update Image Admin
$("#btn-UpdateImageAdmin").click(function () {
	$("#modal-ShowUpdateImage").show();
	return;
});
$("#btn-closeUpdateImgAdmin").click(function () {
	$("#modal-ShowUpdateImage").hide();
	return;
});

//funtion update Image Admin
$("#btn-UpdateImgAdminModal").click(function () {
	$("#modal_LoadingSignUp").show();
	return;
})

//funtion edit Name Admin
$("#Edit_NameAdmin").click(function () {
	var Get_DataNameAdmin = $("#Txt_EditNameAdmin").val();
	Save_OldNameAdmin = Get_DataNameAdmin;
	$("#Txt_EditNameAdmin").prop('disabled', false);
	$("#Edit_NameAdmin").hide();
	$("#Save_NameAdmin").show();
	$("#Remove_NameAdmin").show();
	return;
});

//funtion save Name Admin
$("#Save_NameAdmin").click(function () {
	var Get_DataNameAdmin = $("#Txt_EditNameAdmin").val();
	var Mess_ValidateNameAdmin = $("#ValidaNameAdmin").empty();
	if (Get_DataNameAdmin.length == 0) {
		Mess_ValidateNameAdmin.append(MessageValidate);
		return;
	}
	Save_OldNameAdmin = Get_DataNameAdmin;
	$("#Txt_EditNameAdmin").prop('disabled', true);
	$("#Edit_NameAdmin").show();
	$("#Save_NameAdmin").hide();
	$("#Remove_NameAdmin").hide();
	$("#checkOkNameAdmin").empty();
	return;
});

//funtion Cancel Name Admin
$("#Remove_NameAdmin").click(function () {
	$("#Txt_EditNameAdmin").val(Save_OldNameAdmin);
	$("#Txt_EditNameAdmin").prop('disabled', true);
	$("#Edit_NameAdmin").show();
	$("#Save_NameAdmin").hide();
	$("#Remove_NameAdmin").hide();
	$("#checkOkNameAdmin").empty();
	return;
});

//funtion edit Birthday Admin
$("#Edit_BirthdayAdmin").click(function () {
	var Get_BirthdayAdmin = $("#Txt_EditBirthdayAdmin").val();
	Save_OldBirthdayAdmin = Get_BirthdayAdmin;

	$("#Txt_EditBirthdayAdmin").prop('disabled', false);
	var input = document.querySelector('#Txt_EditBirthdayAdmin');
	if (input.type == "text") {
		input.type = "date";
	}
	$("#Save_BirthdayAdmin").show();
	$("#Edit_BirthdayAdmin").hide();
	$("#Remove_BirthdayAdmin").show();
	return;
});

//funtion cancel edit Birthday Admin
$("#Remove_BirthdayAdmin").click(function () {
	var input = document.querySelector('#Txt_EditBirthdayAdmin');
	if (input.type == "date") {
		input.type = "text";
	}
	$("#Txt_EditBirthdayAdmin").val(Save_OldBirthdayAdmin);
	$("#Txt_EditBirthdayAdmin").prop('disabled', true);

	$("#Save_BirthdayAdmin").hide();
	$("#Edit_BirthdayAdmin").show();
	$("#Remove_BirthdayAdmin").hide();
	return;
});

//funtion Save Edit Birthday Admin
$("#Save_BirthdayAdmin").click(function () {
	var Get_DateInput = new Date($("#Txt_EditBirthdayAdmin").val());
	Day_Admin = Get_DateInput.getDate();
	Moth_Admin = Get_DateInput.getMonth() + 1;
	Year_Admin = Get_DateInput.getFullYear();
	var ValidateBirthdayAdmin = $("#ValidaBirthdayAdmin").empty();
	if (isNaN(Day_Admin) || isNaN(Moth_Admin) || isNaN(Year_Admin)) {
		ValidateBirthdayAdmin.append(MessageValidate);
		return;
	}
	var input = document.querySelector('#Txt_EditBirthdayAdmin');
	if (input.type == "date") {
		input.type = "text";
	}
	var CurrentBirthday = Day_Admin + "/" + Moth_Admin + "/" + Year_Admin;
	document.getElementById("Txt_EditBirthdayAdmin").value = CurrentBirthday;
	$("#Txt_EditBirthdayAdmin").prop('disabled', true);
	$("#Save_BirthdayAdmin").hide();
	$("#Edit_BirthdayAdmin").show();
	$("#Remove_BirthdayAdmin").hide();
	return;
});

//funtion Edit Email Admin
$("#Edit_EmailAdmin").click(function () {
	var Get_DataEmailAdmin = $("#Txt_EmailAdmin").val();
	Save_OldEmailAdmin = Get_DataEmailAdmin;
	$("#Txt_EmailAdmin").prop('disabled', false);
	$("#Edit_EmailAdmin").hide();
	$("#Save_EmailAdmin").show();
	$("#Remove_EmailAdmin").show();
});

//funtion save Email Admin
$("#Save_EmailAdmin").click(function () {
	var ConfiValidateEmail = /^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$/;
	var Get_DataEmailAdmin = $("#Txt_EmailAdmin").val();
	var Mess_ValidateNameAdmin = $("#ValidaEmailAdmin").empty();
	if (Get_DataEmailAdmin.length == 0) {
		Mess_ValidateNameAdmin.append(MessageValidate);
		return;
	}
	if (Get_DataEmailAdmin.match(ConfiValidateEmail)) {
		Save_OldEmailAdmin = Get_DataEmailAdmin;
		$("#Txt_EmailAdmin").prop('disabled', true);
		$("#Edit_EmailAdmin").show();
		$("#Save_EmailAdmin").hide();
		$("#checkOkEmailAdmin").empty();
		$("#Remove_EmailAdmin").hide();
	} else {
		$("#checkOkEmailAdmin").empty();
		Mess_ValidateNameAdmin.append(MessageValidateEmail);
	}
	return;
});

//funtion cancel Email Admin
$("#Remove_EmailAdmin").click(function () {
	$("#Txt_EmailAdmin").val(Save_OldEmailAdmin);
	$("#Txt_EmailAdmin").prop('disabled', true);
	$("#checkOkEmailAdmin").empty();
	$("#Edit_EmailAdmin").show();
	$("#Save_EmailAdmin").hide();
	$("#Remove_EmailAdmin").hide();
});



//-------------------------------------------------
//name
function checkvalueNameAdmin() {
	var Get_NameAdmin = $("#Txt_EditNameAdmin").val();
	var Html_CheckNameAdmin = $("#checkOkNameAdmin").empty();
	var Mess_ValidateNameAdmin = $("#ValidaNameAdmin").empty();
	if (Get_NameAdmin.length == 0) {
		Mess_ValidateNameAdmin.append(MessageValidate);
	} else {
		Html_CheckNameAdmin.html(Hmtl);
	}
	return;
};

//email
function checkvalueEmailAdmin() {
	var Get_EmailAdmin = $("#Txt_EmailAdmin").val();
	var Html_CheckNameAdmin = $("#checkOkEmailAdmin").empty();
	var Mess_ValidateNameAdmin = $("#ValidaEmailAdmin").empty();
	if (Get_EmailAdmin.length == 0) {
		Mess_ValidateNameAdmin.append(MessageValidate);
	} else {
		Html_CheckNameAdmin.html(Hmtl);
	}
	return;
}


//------------------------------------
//confim update infomation Admin
$("#btn_ConfimUpdateAdmin").click(function () {
	var CurrentDay = $("#Txt_EditBirthdayAdmin").val();
	$("#modal_LoadingSignUp").show();
	alert(CurrentDay);
});

//---------------------------------
///sent request user for admin
$("#btn_SentRequetUser").click(function(){
	$("#modal_RequestUser").show();
	return;
})
$("#close_Request").click(function(){
	$("#modal_RequestUser").hide();
	return;
})
