$(document).ready(function(){
	$("#modal_CheckInfomation").hide();
	$("#Md_Brquest").hide();
	$("#Md_CRequest").hide();
});

//-----------------------------------------------
//seach infomation data
$("#btn_searchInfomation").click(function(){
	$("#modal_CheckInfomation").show();
});
$("#btn_closeCheckInfomation").click(function(){
	$("#modal_CheckInfomation").hide();
});

//-----------------------------------------------
//borwer request 
$("#btn_BcRequest").click(function(){
	$("#Md_Brquest").show();
});
$("#btn_Cmdrequest").click(function(){
	$("#Md_Brquest").hide();
})

function F_gText(){
	var D = $("#Txt_VBrequest").val();
	$("#ErorBrequest").empty();
	$("#C_OkBrequest").empty();
	if (D.length == 0 || D == null) {
		$("#ErorBrequest").append("Không được bỏ trống!");
		return;
	}else{
		$("#C_OkBrequest").append('<i class="fas fa-check"></i>')
	}
}
$("#btn_Brquest").click(function(){
	var D = $("#Txt_VBrequest").val();
	$("#ErorBrequest").empty();
	$("#C_OkBrequest").empty();
	if (D.length == 0 || D == null) {
		$("#ErorBrequest").append("Không được bỏ trống!");
		return;
	}
	$("#modal_LoadingSignUp").show();
	$("#Md_Brquest").hide();
})

//------------------------------------------------
//cancel bower request
$("#btn_Cbrequest").click(function(){
	$("#Md_CRequest").show();
});
$("#btn_Yes").click(function(){
	$("#modal_LoadingSignUp").show();
	$("#Md_CRequest").hide();
})
$("#btn_No").click(function(){
	$("#Md_CRequest").hide();
})