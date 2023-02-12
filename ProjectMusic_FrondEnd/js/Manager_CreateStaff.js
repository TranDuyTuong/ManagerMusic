var Hmtl = '<i class="fas fa-check"></i>';
var MessageValidate = "Không được bỏ trống!";
var Check_ValidateGmail= /^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$/;

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
		$("#ValidateRoleStaff").append(MessageValidate);
		return;
	}else{
		$("#checkOkRoleStaff").empty();
		$("#ValidateRoleStaff").empty();
		$("#checkOkRoleStaff").append(Hmtl);
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
	}else{
		$("#checkOkPasswordStaff").append(Hmtl);
		return;
	}
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
	if (GetPassword_Confim == GetValue_PasswordStaff) {
		$("#checkOkPasswordConfimStaff").append(Hmtl);
		return;
	}else{
		$("#ValidatePasswordConfimStaff").append("Mật khẩu không khớp!");
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
	}else{
		$("#checkOkPhoneNumberStaff").append(Hmtl);
		return;
	}
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
	//image 
	var form_data = new FormData();
	var Get_Img = document.getElementById("Txt_InportFileNameStaff").files[0];
	form_data.append("Txt_InportFileNameStaff", Get_Img);

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
		$("#ValidatePasswordConfimStaff").append("Mật khẩu không khớp!");
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
	var getVal_data = $("#Txt_SelectMarriage").val();
	if (getVal_data == '0') {
		$("#checkOkMarriageStaff").empty();
		$("#ValidateMarriageStaff").empty();
		$("#ValidateMarriageStaff").append(MessageValidate);
		return;
	}

	//gender staff
	var getVal_data = $("#Txt_SelectGender").val();
	if (getVal_data == '0') {
		$("#checkOkGenderStaff").empty();
		$("#ValidateGenderStaff").empty();
		$("#ValidateGenderStaff").append(MessageValidate);
		return;
	}

	$("#modal_LoadingSignUp").show();
});