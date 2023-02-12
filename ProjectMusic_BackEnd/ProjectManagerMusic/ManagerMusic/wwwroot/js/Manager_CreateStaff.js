var Hmtl = '<i class="fas fa-check"></i>';
var MessageValidate = $("#ErrorNulData").val();
var Check_ValidateGmail = /^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$/;
var Choose_avalue = $("#Choose_avalue").val();
var Notification_Error = $("#NotificationError").val();
var Notification_Success = $("#NotificationSuccess").val();
var C_EmailAlreadyExists = $("#EmailAlreadyExists").val();
var C_RegiterSuccess = $("#EmailRegiterSuccess").val();
var C_RegiterError = $("#ErrorRegiterFail").val();
var C_ErrorEmailsyntax = $("#ErrorEmailsyntax").val();
var ErrorPasswordCN = $("#Passwordcharacterandnumber").val();
var ErrorPasswordUppercase = $("#PasswordUppercase").val();
var ErrorPassword = $("#ErrorMaximunlength").val();
var Password_incorrect = $("#Password_incorrect").val();

$(document).ready(function () {
	LoadRole();
	LoadStatusAccount();
	LoadGender();
	LoadMarriage();
	LoadCity();
	$("#Txt_IdLeverUser").empty();
	$("#Txt_LeverUser").empty();
});

//----------------------------------------
//funtion load role 
function LoadRole() {
	var SelectRole = $("#Txt_SelectRole").empty();
	$.ajax({
		url: "/User/JsonGetAllRole",
		type: "get",
		success: function (result) {
			if (result != 0) {
				var htmlDefaul = '<option selected value="0">' + Choose_avalue + '</option>';
				SelectRole.append(htmlDefaul);
				$.each(result, function (key, item) {
					var html = "";
					html += '<option value="' + item.idRole + '">' + item.roleName + '</option>';
					SelectRole.append(html);
				});
			}
			return;
		}
	})
}

//----------------------------------------
//funtion load status staff
function LoadStatusAccount() {
	var SelectStatus = $("#Txt_SelectStatusAccount").empty();
	$.ajax({
		url: "/User/JsonGetAllStatusAccount",
		type: "get",
		success: function (result) {
			if (result != 0) {
				var htmlDefaul = '<option selected value="0">' + Choose_avalue + '</option>';
				SelectStatus.append(htmlDefaul);
				$.each(result, function (key, item) {
					var html = "";
					html += '<option value="' + item.id + '">' + item.name + '</option>';
					SelectStatus.append(html);
				});
			}
			return;
		}
	})
}

//----------------------------------------
//funtion load gender
function LoadGender() {
	var SelectStatus = $("#Txt_SelectGender").empty();
	$.ajax({
		url: "/User/JsonGetAllGender",
		type: "get",
		success: function (result) {
			if (result != 0) {
				var htmlDefaul = '<option selected value="0">' + Choose_avalue + '</option>';
				SelectStatus.append(htmlDefaul);
				$.each(result, function (key, item) {
					var html = "";
					html += '<option value="' + item.id + '">' + item.name + '</option>';
					SelectStatus.append(html);
				});
			}
			return;
		}
	})
}

//----------------------------------------
//funtion load gender
function LoadMarriage() {
	var SelectStatus = $("#Txt_SelectMarriage").empty();
	$.ajax({
		url: "/User/JsonGetAllMarriage",
		type: "get",
		success: function (result) {
			if (result != 0) {
				var htmlDefaul = '<option selected value="0">' + Choose_avalue + '</option>';
				SelectStatus.append(htmlDefaul);
				$.each(result, function (key, item) {
					var html = "";
					html += '<option value="' + item.id + '">' + item.name + '</option>';
					SelectStatus.append(html);
				});
			}
			return;
		}
	})
}

//----------------------------------------
//funtion load city
function LoadCity() {
	var OptionCity = $("#S_City").val();
	var OptionDistrict = $("#S_District").val();
	$("#Txt_SelectDistrict").append('<option value="0">' + OptionDistrict + '</option>')
	$("#Txt_SelectDistrict").prop('disabled', true);
	$.ajax({
		url: "/Account/JsonGetAllCity",
		type: "get",
		success: function (result) {
			var SelectCity = $("#Txt_SelectCity").empty();
			SelectCity.append('<option value="0">' + OptionCity + '</option>')
			$.each(result, function (key, item) {
				var CityHtml = "";
				CityHtml += '<option value="' + item.idCity + '">' + item.nameCity + '</option>';
				SelectCity.append(CityHtml);
			})
		}
	})
}

//-----------------------------------------------
//funtion select city 
$("#Txt_SelectCity").change(function () {
	var GetCity = $("#Txt_SelectCity").val();
	if (GetCity == 0) {
		$("#checkOkcity").empty();
		$("#Validatecity").empty();
		$("#Txt_SelectDistrict").prop('disabled', true);
		$("#Validatecity").append(MessageValidate);
		return;
	} else {
		$.ajax({
			url: "/Account/JsonGetAllDistrictById",
			type: "post",
			data: {
				Id: GetCity
			},
			success: function (result) {
				if (result.status == false) {
					$("#Txt_SelectDistrict").prop('disabled', true);
					$("#checkOkcity").empty();
					$("#Validatecity").empty();
					return;
				} else {
					$("#checkOkcity").empty();
					$("#Validatecity").empty();
					var SelectDistrict = $("#Txt_SelectDistrict").empty();
					SelectDistrict.prop('disabled', false);
					$.each(result.l_District, function (key, item) {
						var DistrictHtml = "";
						DistrictHtml += '<option value="' + item.idDistrict + '">' + item.nameDistrict + '</option>';
						SelectDistrict.append(DistrictHtml);
					})
					$("#checkOkcity").append(Hmtl);
				}
			}
		})

	}
});

//--------------------------------------------
//funtion check value file image staff
function checkvalueFileImageStaff(){
	var filename = $('#Txt_InportFileNameStaff').val();
	if (filename.length == 0) {
		$("#ValidateFileNameStaff").empty();
		$("#ValidateFileNameStaff").append(MessageValidate);
		return;
	}else{
		$("#ValidateFileNameStaff").empty();
		$("#checkOkFileInportStaff").empty();
		$("#checkOkFileInportStaff").append(Hmtl);
		return;
	}
}

//--------------------------------------------
//funtion check value role staff
$("#Txt_SelectRole").change(function(){
	var getVal_data = $("#Txt_SelectRole").val();
	if (getVal_data == '0') {
		$("#checkOkRoleStaff").empty();
		$("#ValidateRoleStaff").empty();
		$("#Txt_IdLeverUser").empty();
		$("#Txt_LeverUser").empty();
		$("#ValidateRoleStaff").append(MessageValidate);
		return;
	} else {
		$.ajax({
			url: "/User/JsonGetLeverByIdRole",
			type: "get",
			data: {
				IdRole: getVal_data
			},
			success: function (result) {
				if (result != 0) {
					var Txt_IdLeverUser = $("#Txt_IdLeverUser").empty();
					var Txt_LeverUser = $("#Txt_LeverUser").empty();
					Txt_IdLeverUser.val(result.id)
					Txt_LeverUser.val(result.nameLever)
					$("#checkOkRoleStaff").empty();
					$("#ValidateRoleStaff").empty();
					$("#checkOkRoleStaff").append(Hmtl);
                }
            }
        })
		return;
	}
});

//----------------------------------------------
//funtion check value status account
$("#Txt_SelectStatusAccount").change(function(){
	var getVal_DataStatus = $("#Txt_SelectStatusAccount").val();
	if (getVal_DataStatus == '0') {
		$("#checkOkStatusAccount").empty();
		$("#ValidateStatusAccount").empty();
		$("#ValidateStatusAccount").append(MessageValidate);
		return;
	}else{
		$("#checkOkStatusAccount").empty();
		$("#ValidateStatusAccount").empty();
		$("#checkOkStatusAccount").append(Hmtl);
		return;
	}
});

//--------------------------------------------
//funtion validate name staff
function ValidateTxtNameStaff(){
	var GetValue_NameStaff = $("#TxtNameStaff").val();
	$("#checkOkNameStaff").empty();
	$("#ValidateNameStaff").empty();
	if (GetValue_NameStaff.length == 0) {
		$("#ValidateNameStaff").append(MessageValidate);
		return;
	}else{
		$("#checkOkNameStaff").append(Hmtl);
		return;
	}
};

//-------------------------------------------
//funtion validate birthday staff
function ValidateTxtDateBirthday(){
	var GetValue_BirthdayStaff = $("#TxtBirthdayStaff").val();
	$("#ValidateBirtdayStaff").empty();
	$("#checkOkBirthdayStaff").empty();
	if(GetValue_BirthdayStaff.length == 0 || GetValue_BirthdayStaff == null){
		$("#ValidateBirtdayStaff").append(MessageValidate);
		return;
	}else{
		$("#checkOkBirthdayStaff").append(Hmtl);
		return;
	}
};

//---------------------------------------
//funtion validate gmail staff
function ValidateTxtGmailStaff(){
	var GetValue_GmailStaff = $("#TxtGmailStaff").val();
		$("#checkOkGmailStaff").empty();
		$("#ValidateGmailStaff").empty();
	if(GetValue_GmailStaff.length == 0 || GetValue_GmailStaff == null){
		$("#ValidateGmailStaff").append(MessageValidate);
		return;
	}else{
		$("#checkOkGmailStaff").append(Hmtl);
		return;
	}
}

//----------------------------------------
//funtion validate password
function ValidateTxtPassword(){
	var GetValue_PasswordStaff = $("#TxtPassword").val();
	$("#checkOkPasswordStaff").empty();
	$("#ValidatePasswordStaff").empty();

	if (GetValue_PasswordStaff.length == 0 || GetValue_PasswordStaff == null) {
		$("#ValidatePasswordStaff").append(MessageValidate);
		return;
	}
	if (GetValue_PasswordStaff.length >= 10) {
		$("#ValidatePasswordStaff").append(ErrorPassword);
		return;
	}
	$("#checkOkPasswordStaff").html(Hmtl);
	return;
}

//-----------------------------------------
//funtion validate password confim
function ValidateTxtComfimPassword(){
	var GetPassword_Confim = $("#TxtPasswordConfim").val();
	var GetValue_PasswordStaff = $("#TxtPassword").val();
	$("#checkOkPasswordConfimStaff").empty();
	$("#ValidatePasswordConfimStaff").empty();

	if (GetPassword_Confim.length == 0 || GetPassword_Confim == null) {
		$("#ValidatePasswordConfimStaff").append(MessageValidate);
		return;
	}
	if (GetPassword_Confim.length >= 10) {
		$("#ValidatePasswordConfimStaff").append(ErrorPassword);
		return;
	}
	if (GetPassword_Confim == GetValue_PasswordStaff) {
		$("#checkOkPasswordConfimStaff").append(Hmtl);
		return;
	}else{
		$("#ValidatePasswordConfimStaff").append(Password_incorrect);
		return;
	}
}

//-----------------------------------------------------------
//funtion validate address staff
function ValidateTxtAddresss(){
	var GetValue_AddressStaff = $("#TxtAddresss").val();
	$("#checkOkAddressStaff").empty();
	$("#ValidateAddressStaff").empty();
	if (GetValue_AddressStaff.length == 0 || GetValue_AddressStaff == null) {
		$("#ValidateAddressStaff").append(MessageValidate);
		return;
	}else{
		$("#checkOkAddressStaff").append(Hmtl);
		return;
	}
} 

//---------------------------------------------------------
//funtion validate phonenumber staff
function ValidatePhoneNumberStaff(){
	var GetValue_PhoneMunberStaff = $("#TxtPhoneNumber").val();
	$("#checkOkPhoneNumberStaff").empty();
	$("#ValidatePhoneNumberStaff").empty();
	if (GetValue_PhoneMunberStaff.length == 0 || GetValue_PhoneMunberStaff == null) {
		$("#ValidatePhoneNumberStaff").append(MessageValidate);
		return;
	}
	if (GetValue_PhoneMunberStaff.length > 10) {
		$("#ValidatePhoneNumberStaff").append(ErrorPassword);
		return;
    }
		$("#checkOkPhoneNumberStaff").append(Hmtl);
		return;
}

//--------------------------------------------
//funtion check value marriage staff
$("#Txt_SelectMarriage").change(function(){
	var getVal_data = $("#Txt_SelectMarriage").val();
	if (getVal_data == '0') {
		$("#checkOkMarriageStaff").empty();
		$("#ValidateMarriageStaff").empty();
		$("#ValidateMarriageStaff").append(MessageValidate);
		return;
	}else{
		$("#checkOkMarriageStaff").empty();
		$("#ValidateMarriageStaff").empty();
		$("#checkOkMarriageStaff").append(Hmtl);
		return;
	}
});

//--------------------------------------------
//funtion check value gender staff
$("#Txt_SelectGender").change(function(){
	var getVal_data = $("#Txt_SelectGender").val();
	if (getVal_data == '0') {
		$("#checkOkGenderStaff").empty();
		$("#ValidateGenderStaff").empty();
		$("#ValidateGenderStaff").append(MessageValidate);
		return;
	}else{
		$("#checkOkGenderStaff").empty();
		$("#ValidateGenderStaff").empty();
		$("#checkOkGenderStaff").append(Hmtl);
		return;
	}
});


//------------------------------------------------
///funtion create staff
$("#btn_CreateStaff").click(function(){

	var filename = $('#Txt_InportFileNameStaff').val();
	if (filename.length == 0) {
		$("#ValidateFileNameStaff").empty();
		$("#ValidateFileNameStaff").append(MessageValidate);
		return;
	}
	//role
	var getVal_dataRole = $("#Txt_SelectRole").val();
	if (getVal_dataRole == '0') {
		$("#checkOkRoleStaff").empty();
		$("#ValidateRoleStaff").empty();
		$("#ValidateRoleStaff").append(MessageValidate);
		return;
	}
	//status account
	var getVal_DataStatus = $("#Txt_SelectStatusAccount").val();
	if (getVal_DataStatus == '0') {
		$("#checkOkStatusAccount").empty();
		$("#ValidateStatusAccount").empty();
		$("#ValidateStatusAccount").append(MessageValidate);
		return;
	}
	//name staff
	var GetValue_NameStaff = $("#TxtNameStaff").val();
	if (GetValue_NameStaff.length == 0) {
		$("#checkOkNameStaff").empty();
		$("#ValidateNameStaff").empty();
		$("#ValidateNameStaff").append(MessageValidate);
		return;
	}
	//birthday staff
	var GetValue_BirthdayStaff = $("#TxtBirthdayStaff").val();
	if(GetValue_BirthdayStaff.length == 0 || GetValue_BirthdayStaff == null){
		$("#ValidateBirtdayStaff").empty();
		$("#checkOkBirthdayStaff").empty();
		$("#ValidateBirtdayStaff").append(MessageValidate);
		return;
	}
	//gmail staff
	var GetValue_GmailStaff = $("#TxtGmailStaff").val();
	if(GetValue_GmailStaff.length == 0 || GetValue_GmailStaff == null){
		$("#checkOkGmailStaff").empty();
		$("#ValidateGmailStaff").empty();
		$("#ValidateGmailStaff").append(MessageValidate);
		return;
	}

	//password staff
	var GetValue_PasswordStaff = $("#TxtPassword").val();
	if (GetValue_PasswordStaff.length == 0 || GetValue_PasswordStaff == null) {
		$("#checkOkPasswordStaff").empty();
		$("#ValidatePasswordStaff").empty();
		$("#ValidatePasswordStaff").append(MessageValidate);
		return;
	}

	//password special character
	var regularExpression = /^(?=.*[0-9])(?=.*[!@#$%^&*])[a-zA-Z0-9!@#$%^&*]{6,16}$/;
	if (!regularExpression.test(GetValue_PasswordStaff)) {
		var ValidatePassword = $("#ValidatePasswordStaff").empty();
		ValidatePassword.append(ErrorPasswordCN);
		return;
	}
	//password upperCase
	if (GetValue_PasswordStaff.search(/[A-Z]/) == -1) {
		var ValidatePassword = $("#ValidatePasswordStaff").empty();
		ValidatePassword.append(ErrorPasswordUppercase);
		return;
	}

	//confim password staff
	var GetPassword_Confim = $("#TxtPasswordConfim").val();
	if (GetPassword_Confim.length == 0 || GetPassword_Confim == null) {
		$("#checkOkPasswordConfimStaff").empty();
		$("#ValidatePasswordConfimStaff").empty();
		$("#ValidatePasswordConfimStaff").append(MessageValidate);
		return;
	}
	if (GetPassword_Confim != GetValue_PasswordStaff) {
		$("#checkOkPasswordConfimStaff").empty();
		$("#ValidatePasswordConfimStaff").empty();
		$("#ValidatePasswordConfimStaff").append(Password_incorrect);
		return;
	}

	//address staff
	var GetValue_AddressStaff = $("#TxtAddresss").val();
	if (GetValue_AddressStaff.length == 0 || GetValue_AddressStaff == null) {
		$("#checkOkAddressStaff").empty();
		$("#ValidateAddressStaff").empty();
		$("#ValidateAddressStaff").append(MessageValidate);
		return;
	}

	//phone Number staff
	var GetValue_PhoneMunberStaff = $("#TxtPhoneNumber").val();
	if (GetValue_PhoneMunberStaff.length == 0 || GetValue_PhoneMunberStaff == null) {
		$("#checkOkPhoneNumberStaff").empty();
		$("#ValidatePhoneNumberStaff").empty();
		$("#ValidatePhoneNumberStaff").append(MessageValidate);
		return;
	}

	//marriage staff
	var getVal_Marriage = $("#Txt_SelectMarriage").val();
	if (getVal_Marriage == '0') {
		$("#checkOkMarriageStaff").empty();
		$("#ValidateMarriageStaff").empty();
		$("#ValidateMarriageStaff").append(MessageValidate);
		return;
	}

	//gender staff
	var getVal_Gender = $("#Txt_SelectGender").val();
	if (getVal_Gender == '0') {
		$("#checkOkGenderStaff").empty();
		$("#ValidateGenderStaff").empty();
		$("#ValidateGenderStaff").append(MessageValidate);
		return;
	}

	//city
	var getVal_City = $("#Txt_SelectCity").val();
	if (getVal_City == '0') {
		$("#checkOkcity").empty();
		$("#Validatecity").empty();
		$("#Validatecity").append(MessageValidate);
		return;
	}
	//district
	var getVal_District = $("#Txt_SelectDistrict").val();
	//lever
	var Txt_IdLeverUser = $("#Txt_IdLeverUser").val();

	//image 
	$("#modal_LoadingSignUp").show();
	var files = $("#Txt_InportFileNameStaff").prop("files")
	var formData = new FormData();
	for (var i = 0; i < files.length; i++) {
		formData.append("file", files[i]);
	}
	var Create_Staff = {
		IdAccountActiver: getVal_DataStatus,
		IdLever: Txt_IdLeverUser,
		IdMarriage: getVal_Marriage,
		IdGender: getVal_Gender,
		IdCity: getVal_City,
		IdRole: getVal_dataRole,
		IdDistrict: getVal_District,
		Birthday: GetValue_BirthdayStaff,
		FullName: GetValue_NameStaff,
		AddressSatff: GetValue_AddressStaff,
		PhoneStaff: GetValue_PhoneMunberStaff,
		Email: GetValue_GmailStaff,
		Password: GetValue_PasswordStaff
	}
	formData.append("Satff", JSON.stringify(Create_Staff));

	$.ajax({
		url: "/User/JsonCreateStaff",
		type: "post",
		data: formData,
		contentType: false,
		processData: false,
		success: function (result) {
			$("#modal_LoadingSignUp").hide();
			if (result.status == false) {
				if (result.isStatus == 1) {
					toastr.error(C_EmailAlreadyExists, Notification_Error)
				}
				if (result.isStatus == 3) {
					toastr.error(C_RegiterError, Notification_Error)
				}
				if (result.isStatus == 4) {
					toastr.error(C_ErrorEmailsyntax, Notification_Error)
				}
			} else {
				if (result.isStatus == 2) {
					toastr.success(C_RegiterSuccess, Notification_Success)
				}
			}
			return
        }
    })
});