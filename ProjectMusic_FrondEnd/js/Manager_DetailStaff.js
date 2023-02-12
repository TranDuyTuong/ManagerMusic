$(document).ready(function(){
	$("#modal-LockAccountStaff").hide();
	$("#modal_HireStaff").hide();
	$("#modal_ChangePasswordStaff").hide();
});

//-----------------------------------------------------
//modal lock aacount staff
$("#btn-ShowModallockAccount").click(function(){
	$("#modal-LockAccountStaff").show();
});
$("#btn_closeLockAccount").click(function(){
	$("#modal-LockAccountStaff").hide();
});


//------------------------------------------------------------
//modal cancel hire staff
$("#btn-ShowModalHideStaff").click(function(){
	$("#modal_HireStaff").show();
});
$("#btn_closeHireStaff").click(function(){
	$("#modal_HireStaff").hide();
});

//---------------------------------------------------------
//modal role staff
$("#btn-ShowModalRoleStaff").click(function(){
	$("#modal_RoleStaff").show();
});
$("#btn_closeRoleStaff").click(function(){
	$("#modal_RoleStaff").hide();
});
$("#btn_RoleStaff").click(function(){
	var get_DataValue = $("#SelectRoleStaff").val();
	$("#Error_Data").empty();
	if (get_DataValue == 0) {
		$("#Error_Data").append("Vui lòng chọn một quyền!");
		return;
	}
	$("#modal_LoadingSignUp").show();
	$("#modal_RoleStaff").hide();
});

//-------------------------------------------------------
//modal take again password staff
var MessageError = "Không được bỏ trống!";
var Hmtl = '<i class="fas fa-check"></i>';

$("#btn-ShowModalTakeAgainPassword").click(function(){
	$("#modal_TakeAgainPasswordStaff").show();
});
$("#btn_closeTakeAgainPasswordStaff").click(function(){
	$("#modal_TakeAgainPasswordStaff").hide();
})
function ValidateTxtEmail(){
	var get_data = $("#TxtEmailStaff").val();
	$("#Error_Data").empty();
	$("#data_Success").empty();
	if (get_data.length == 0 || get_data == null) {
		$("#Error_Data").append(MessageError);
	}else{
		$("#data_Success").append(Hmtl);
	}
}

$("#btn_SentData").click(function(){
	var get_data = $("#TxtEmailStaff").val();
	$("#Error_Data").empty();
	$("#data_Success").empty();
	if (get_data.length == 0 || get_data == null) {
		$("#Error_Data").append(MessageError);
		return
	}else{
		$("#data_Success").append(Hmtl);
	}
	$("#modal_LoadingSignUp").show();
	$("#modal_TakeAgainPasswordStaff").hide();
})


//---------------------------------------------
//modal change password
$("#btn-ShowModalChangePassword").click(function(){
	$("#modal_ChangePasswordStaff").show();
});
$("#btn_closeChangePasswordStaff").click(function(){
	$("#modal_ChangePasswordStaff").hide();
})
function ValidateTxtEmailPassword(){
	var get_data = $("#TxtChangeEmailStaff").val();
	$("#Error_DataChange").empty();
	$("#data_SuccessChange").empty();
	if (get_data.length == 0 || get_data == null) {
		$("#Error_DataChange").append(MessageError);
		return;
	}else{
		$("#data_SuccessChange").append(Hmtl);
		return;
	}
}
function ValidateTxtPassword(){
	var get_data = $("#TxtChangePasswordStaff").val();
	$("#Error_PasswordDataChange").empty();
	$("#data_PasswordSuccessChange").empty();
	if (get_data.length == 0 || get_data == null) {
		$("#Error_PasswordDataChange").append(MessageError);
		return;
	}else{
		$("#data_PasswordSuccessChange").append(Hmtl);
		return;
	}
}
function ValidateTxtPasswordConfim(){
	var get_data = $("#TxtChangePasswordConfimStaff").val();
	var get_dataPassword = $("#TxtChangePasswordStaff").val();

	$("#data_PasswordConfimSuccessChange").empty();
	$("#Error_PasswordConfimDataChange").empty();
	if (get_data != get_dataPassword) {
		$("#Error_PasswordConfimDataChange").append("Mật khẩu không trùng khớp");
		return;
	}else{
		$("#data_PasswordConfimSuccessChange").append(Hmtl);
		return;
	}
}
$("#btn_SentDataPassword").click(function(){

	var get_data = $("#TxtChangeEmailStaff").val();
	if (get_data.length == 0 || get_data == null) {
		$("#Error_DataChange").empty();
		$("#data_SuccessChange").empty();
		$("#Error_DataChange").append(MessageError);
		return;
	}

	var get_data = $("#TxtChangePasswordStaff").val();
	if (get_data.length == 0 || get_data == null) {
		$("#Error_PasswordDataChange").empty();
		$("#data_PasswordSuccessChange").empty();
		$("#Error_PasswordDataChange").append(MessageError);
		return;
	}

	var get_data = $("#TxtChangePasswordConfimStaff").val();
	var get_dataPassword = $("#TxtChangePasswordStaff").val();

	if (get_data != get_dataPassword) {
		$("#data_PasswordConfimSuccessChange").empty();
		$("#Error_PasswordConfimDataChange").empty();
		$("#Error_PasswordConfimDataChange").append("Mật khẩu không trùng khớp");
		return;
	}

	$("#modal_LoadingSignUp").show();
	$("#modal_ChangePasswordStaff").hide();
});