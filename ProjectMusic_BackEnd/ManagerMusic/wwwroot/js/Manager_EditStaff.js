var Hmtl = '<i class="fas fa-check"></i>';
var MessageValidate = $("#NotNull_Data").val();
var BackEmployee_List = $("#BackEmployee_List").val();
var Notification_Error = $("#Notification_Error").val();
var IDemployee_couldnotfound = $("#IDemployee_couldnotfound").val();
var EmptyCode_Employee = $("#EmptyCode_Employee").val();
var NotChooseNew_Avata = $("#NotChooseNew_Avata").val();
var ImageNot_Format = $("#ImageNot_Format").val();
var IdEmployeeAndIdStaff_notnull = $("#IdEmployeeAndIdStaff_notnull").val();
var Staffnot_found = $("#Staffnot_found").val();
var ReviewNew_Updates = $("#ReviewNew_Updates").val();
var Nofitication_Success = $("#Nofitication_Success").val();
var Editemployee_successfully = $("#Editemployee_successfully").val();

$(document).ready(function () {
	LoadDataIdUser();
});

//----------------------------------------
//funtion load data by id user
function LoadDataIdUser() {
	var G = $("#Id_User").val();
	$.ajax({
		url: "/User/Get_UpdateStaff",
		type: "get",
		data: {
			IdUser: G
		},
		success: function (result) {
			console.log(result);
			var html = "";
			switch (result.idStaff) {
				case "0":
					$("#ViewRowUpdate").empty();
					html += '<a href="/User/Page_Staff">' + BackEmployee_List + '</a>'
					$("#ViewRowUpdate").append(html);
					toastr.error(IDemployee_couldnotfound, Notification_Error);
					break;
				case "1":
					$("#ViewRowUpdate").empty();
					html += '<a href="/User/Page_Staff">' + BackEmployee_List + '</a>'
					$("#ViewRowUpdate").append(html);
					toastr.error(EmptyCode_Employee, Notification_Error)
					break;
				default:
					//select marriage
					$("#Txt_SelectMarriage").empty();
					var htmlSelect = "";
					htmlSelect += '<option selected value="' + result.idMarriage + '">' + result.nameMarrige + '</option>'
					$("#Txt_SelectMarriage").append(htmlSelect);
					$.each(result.l_Marriage, function (key, item) {
						htmlSelect = "";
						htmlSelect += '<option value="' + item.id + '">' + item.name + '</option>'
						$("#Txt_SelectMarriage").append(htmlSelect);
					})
					//address
					$("#TxtAddresss").val(result.addressUser);
					//gmail
					$("#TxtGmailStaff").val(result.gmail);
					//phone
					$("#TxtPhoneNumber").val(result.phoneNumber)

					$("#FullName").empty();
					$("#CodeStaff").empty();
					$("#FullName").append(result.fullName);
					$("#CodeStaff").append(result.idStaff);

					//avata
					$("#ImageAvata").empty();
					var HtmlImg = '<img style="max-with: 50%" src="data: image/jpg;base64, ' + result.avataUser + '" class="img-thumbnail" alt="...">'
					$("#ImageAvata").append(HtmlImg);
					break;
            }
        }
    })
}

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
//-----------------------------------------------
//funtion view image
var Save_Url;
//create url for image
document.getElementById('Input_Img').onchange = e => {
	if (Save_Url != null) {
		URL.revokeObjectURL(Save_Url);
	}
	const file = e.target.files[0]; // this Object holds a reference to the file on disk
	const url = URL.createObjectURL(file); // this points to the File object we just created
	Save_Url = url;
	document.getElementById('img_NewAvata').src = url
	return;
};

$("#btn_ViewImg").click(function () {
	var get_Img = $("#Input_Img").val();
	if (get_Img.length == 0) {
		toastr.error(NotChooseNew_Avata, Notification_Error);
	} else {
		$("#modal_V_Image").show();
    }
})
$("#btn_closeImage").click(function () {
	if (Save_Url != null) {
		URL.revokeObjectURL(Save_Url);
	}
	$("#modal_V_Image").hide();
})

//------------------------------------------------
//funtion create staff
$("#btn_EditStaff").click(function(){

	//Id User
	var getIdUser = $("#Id_User").val();

	//Id Staff
	var getIdStaff = $("#CodeStaff").text();

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

	//file avata
	var files = $("#Input_Img").prop("files")
	var formData = new FormData();
	for (var i = 0; i < files.length; i++) {
		formData.append("ImgAvata", files[i]);
	}

	var Update_Staff = {
		IdUser: getIdUser,
		IdStaff: getIdStaff,
		IdMarriage: getVal_data,
		AddressUser: GetValue_AddressStaff,
		Gmail: GetValue_GmailStaff,
		PhoneNumber: GetValue_PhoneMunberStaff,
	};
	formData.append("UpdateStaff_Json", JSON.stringify(Update_Staff));
	$("#modal_LoadingSignUp").show();

	$.ajax({
		url: "/User/Post_UpdateStaff",
		type: "post",
		data: formData,
		contentType: false,
		processData: false,
		success: function (result) {
			$("#modal_LoadingSignUp").hide();
			switch (result.idNotification) {
				case 0:
					toastr.error(ImageNot_Format, Notification_Error);
					break;
				case 1:
					toastr.error(IdEmployeeAndIdStaff_notnull, Notification_Error);
					break;
				case 2:
					toastr.error(Staffnot_found, Notification_Error);
					break;
				case 3:
					if (Save_Url != null) {
						URL.revokeObjectURL(Save_Url);
					}
					$("#ViewRowUpdate").empty();
					var html = '<a style="border-radius: 10px;" href="/User/Page_UpdateStaff/?IdUser=' + getIdUser + '" class="btn btn-outline-success">' + ReviewNew_Updates + '<a>';
					$("#ViewRowUpdate").append(html);
					toastr.success(Editemployee_successfully, Nofitication_Success);
					break;
			}
			return;
        }
    })
});