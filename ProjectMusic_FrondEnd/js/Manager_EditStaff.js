var Hmtl = '<i class="fas fa-check"></i>';
var MessageValidate = "Không được bỏ trống!";

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

//------------------------------------------------
//funtion create staff
$("#btn_EditStaff").click(function(){

	//marriage staff
	var getVal_data = $("#Txt_SelectMarriage").val();
	if (getVal_data == '0') {
		$("#checkOkMarriageStaff").empty();
		$("#ValidateMarriageStaff").empty();
		$("#ValidateMarriageStaff").append(MessageValidate);
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

	//gmail staff
	var GetValue_GmailStaff = $("#TxtGmailStaff").val();
	if(GetValue_GmailStaff.length == 0 || GetValue_GmailStaff == null){
		$("#checkOkGmailStaff").empty();
		$("#ValidateGmailStaff").empty();
		$("#ValidateGmailStaff").append(MessageValidate);
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

	$("#modal_LoadingSignUp").show();
});