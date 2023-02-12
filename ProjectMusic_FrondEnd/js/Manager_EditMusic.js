
$(document).ready(function(){

	//name music
	$("#btn_EditNameMusic").show();
	$("#btn_SaveNameMusic").hide();
	$("#btn_RemoveNameMusic").hide();

	//name author
	$("#btn_EditNameAuthor").show();
	$("#btn_SaveNameAuthor").hide();
	$("#btn_RemoveNameAuthor").hide();

	//season
	$("#btn_EditSeason").show();
	$("#btn_SaveSeason").hide();

	//sainast
	$("#btn_EditSainst").show();
	$("#btn_SaveSainst").hide();

	//status
	$("#btn_EditStatus").show();
	$("#btn_SaveStatus").hide();

	//confim
	$("#btn_confimEdit").show();
});

//valiiablie
var Value_NameMusic;
var Value_NameAuthor;
var MessageValidate = "Không được bỏ trống!";
var Hmtl = '<i class="fas fa-check"></i>';

//-----------------------------------
//edit name music
$("#btn_EditNameMusic").click(function(){

	$("#btn_EditNameMusic").hide();
	$("#btn_SaveNameMusic").show();
	$("#btn_RemoveNameMusic").show();
	$("#Txt_EnterNameMusic").prop('disabled', false);
	$("#btn_confimEdit").hide();

	Value_NameMusic = $("#Txt_EnterNameMusic").val();
	var GetData_NameMusic = $("#Txt_EnterNameMusic").val();
	if (GetData_NameMusic.length == 0) {
		$("#ValidaNameMusic").empty();
		$("#ValidaNameMusic").append(MessageValidate);
		$("#checkOkNameMusic").empty();
		return;
	}else{
		$("#checkOkNameMusic").empty();
		$("#checkOkNameMusic").append(Hmtl);
		$("#ValidaNameMusic").empty();
		return;
	}
});

//save name music
$("#btn_SaveNameMusic").click(function(){

	var GetData_NameMusic = $("#Txt_EnterNameMusic").val();
	if (GetData_NameMusic.length == 0) {
		$("#ValidaNameMusic").empty();
		$("#ValidaNameMusic").append(MessageValidate);
		$("#checkOkNameMusic").empty();

		$("#btn_EditNameMusic").hide();
		$("#btn_SaveNameMusic").show();
		$("#btn_RemoveNameMusic").show();

		$("#btn_confimEdit").hide();
		return;
	}else{
		$("#checkOkNameMusic").empty();
		$("#checkOkNameMusic").append(Hmtl);
		$("#ValidaNameMusic").empty();

		$("#Txt_EnterNameMusic").prop('disabled', true);
		Value_NameMusic = $("#Txt_EnterNameMusic").val();

		$("#btn_EditNameMusic").show();
		$("#btn_SaveNameMusic").hide();
		$("#btn_RemoveNameMusic").hide();

		$("#btn_confimEdit").show();
		return;
	}
});

//remove name music
$("#btn_RemoveNameMusic").click(function(){

	$("#Txt_EnterNameMusic").prop('disabled', true);
	$("#Txt_EnterNameMusic").val(Value_NameMusic);

	$("#btn_EditNameMusic").show();
	$("#btn_SaveNameMusic").hide();
	$("#btn_RemoveNameMusic").hide();

	$("#checkOkNameMusic").empty();
	$("#ValidaNameMusic").empty();

	$("#btn_confimEdit").show();
	return;
});

//validate data in input type
function CheckValueNameMusic(){
	var GetData_NameMusic = $("#Txt_EnterNameMusic").val();
	if (GetData_NameMusic.length == 0) {
		$("#ValidaNameMusic").empty();
		$("#ValidaNameMusic").append(MessageValidate);
		$("#checkOkNameMusic").empty();
	}else{
		$("#checkOkNameMusic").empty();
		$("#checkOkNameMusic").append(Hmtl);
		$("#ValidaNameMusic").empty();
	}
	return;
};



//------------------------------------------------------------------------------------------------
//edit name author
$("#btn_EditNameAuthor").click(function(){
	$("#btn_EditNameAuthor").hide();
	$("#btn_SaveNameAuthor").show();
	$("#btn_RemoveNameAuthor").show();
	$("#Txt_EnterNameAuthor").prop('disabled', false);
	$("#btn_confimEdit").hide();

	Value_NameAuthor = $("#Txt_EnterNameAuthor").val();

	var GetData_NameAuthor = $("#Txt_EnterNameAuthor").val;
	if (GetData_NameAuthor.length == 0) {
		$("#ValidaNameAuthor").empty();
		$("#ValidaNameAuthor").append(MessageValidate);
		$("#checkOkNameAuthor").empty();
	}else{
		$("#checkOkNameAuthor").empty();
		$("#checkOkNameAuthor").append(Hmtl);
		$("#ValidaNameAuthor").empty();
	}
	return;
});

//validate data in input type
function CheckValueNameAuthor(){
	var GetData_NameAuthor = $("#Txt_EnterNameAuthor").val();
	if (GetData_NameAuthor.length == 0) {
		$("#ValidaNameAuthor").empty();
		$("#ValidaNameAuthor").append(MessageValidate);
		$("#checkOkNameAuthor").empty();
	}else{
		$("#checkOkNameAuthor").empty();
		$("#checkOkNameAuthor").append(Hmtl);
		$("#ValidaNameAuthor").empty();
	}
	return;
};

//save name author
$("#btn_SaveNameAuthor").click(function(){

	var GetData_NameMusic = $("#Txt_EnterNameAuthor").val();
	if (GetData_NameMusic.length == 0) {
		$("#ValidaNameAuthor").empty();
		$("#ValidaNameAuthor").append(MessageValidate);
		$("#checkOkNameAuthor").empty();

		$("#btn_EditNameAuthor").hide();
		$("#btn_SaveNameAuthor").show();
		$("#btn_RemoveNameAuthor").show();

		$("#btn_confimEdit").hide();
		return;
	}else{
		$("#checkOkNameAuthor").empty();
		$("#checkOkNameAuthor").append(Hmtl);
		$("#ValidaNameAuthor").empty();

		$("#Txt_EnterNameAuthor").prop('disabled', true);
		Value_NameAuthor = $("#Txt_EnterNameAuthor").val();

		$("#btn_EditNameAuthor").show();
		$("#btn_SaveNameAuthor").hide();
		$("#btn_RemoveNameAuthor").hide();

		$("#btn_confimEdit").show();
		return;
	}
});

//remove name author
$("#btn_RemoveNameAuthor").click(function(){

	$("#Txt_EnterNameAuthor").prop('disabled', true);
	$("#Txt_EnterNameAuthor").val(Value_NameAuthor);

	$("#btn_EditNameAuthor").show();
	$("#btn_SaveNameAuthor").hide();
	$("#btn_RemoveNameAuthor").hide();

	$("#checkOkNameAuthor").empty();
	$("#ValidaNameAuthor").empty();

	$("#btn_confimEdit").show();
	return;
});

//-----------------------------------------------------------------
//edit season
$("#btn_EditSeason").click(function(){
	$("#btn_SaveSeason").show();
	$("#btn_EditSeason").hide();

	$("#btn_confimEdit").hide();
	$("#SelectSeason").prop('disabled', false);
});
//save season
$("#btn_SaveSeason").click(function(){
	$("#btn_SaveSeason").hide();
	$("#btn_EditSeason").show();

	$("#btn_confimEdit").show();
	$("#SelectSeason").prop('disabled', true);
});

//---------------------------------------------------------------------
//edit saint
$("#btn_EditSainst").click(function(){
	$("#btn_EditSainst").hide();
	$("#btn_SaveSainst").show();

	$("#btn_confimEdit").hide();
	$("#SelectSainst").prop('disabled', false);
});
//save season
$("#btn_SaveSainst").click(function(){
	$("#btn_SaveSainst").hide();
	$("#btn_EditSainst").show();

	$("#btn_confimEdit").show();
	$("#SelectSainst").prop('disabled', true);
});

//-------------------------------------------------------------------
//edit status
$("#btn_EditStatus").click(function(){
	$("#btn_EditStatus").hide();
	$("#btn_SaveStatus").show();

	$("#btn_confimEdit").hide();
	$("#SelectStatus").prop('disabled', false);
});
//save status
$("#btn_SaveStatus").click(function(){
	$("#btn_SaveStatus").hide();
	$("#btn_EditStatus").show();

	$("#btn_confimEdit").show();
	$("#SelectStatus").prop('disabled', true);
});

//---------------------------------------------------------------------
//confim edit music
$("#btn_confimEdit").click(function(){
	var Get_NameMusic = $("#Txt_EnterNameMusic").val();
	var Get_NameAuthor = $("#Txt_EnterNameAuthor").val();
	var Get_IdSeason = $("#SelectSeason").val();
	var Get_IdSaint = $("#SelectSainst").val();
	var Get_Status = $("#SelectStatus").val();

	//setting file
	var Get_NameFile;
	var Get_DataFile = $("#FileExport").val();
	if (Get_DataFile.length != 0) {
    	var startIndex = (Get_DataFile.indexOf('\\') >= 0 ? Get_DataFile.lastIndexOf('\\') : Get_DataFile.lastIndexOf('/'));
    		var filename = Get_DataFile.substring(startIndex);
			    if (filename.indexOf('\\') === 0 || filename.indexOf('/') === 0) {
			        filename = filename.substring(1);
			    	}
    					Get_NameFile = filename;
	}
	var form_data = new FormData();
	var Get_ContentFileName = document.getElementById("FileExport").files[0];
	form_data.append("FileExport", Get_ContentFileName);
	console.log(form_data);
	$("#modal_LoadingCreateMusic").show();
	return;
});