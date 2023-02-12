var IdMuisc = $("#IdMuisc").val();
var Notification_Error = $("#Notification_Error").val();
var Nofitication_Success = $("#Nofitication_Success").val();
var NotFindSong = $("#NotFindSong").val();
var IdMmusicNull = $("#IdMmusicNull").val();
var Younot_selectedimage = $("#Younot_selectedimage").val();
var SystemRequest = $("#SystemRequest").val();
var ImageNot_Null = $("#ImageNot_Null").val();
var NotFindIdUser_Create = $("#NotFindIdUser_Create").val();
var UpdateMusic_Success = $("#UpdateMusic_Success").val();
var UpdateMusic_Erorr = $("#UpdateMusic_Erorr").val();

$(document).ready(function(){
	LoadDataUpdate();
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
	$("#btn_EditSainst").hide();
	$("#btn_SaveSainst").hide();


	//confim
	$("#btn_confimEdit").show();
});

//------------------------------------------
var Urlimage;
//load data update
function LoadDataUpdate() {
	$("#CurrentFile").empty();
	$("#Txt_EnterNameMusic").empty();
	$("#Txt_EnterNameAuthor").empty();
	$("#SelectSeason").empty();
	$("#SelectSainst").empty();
	$.ajax({
		url: "/ManagerData/JsonLoadUpdateMuisc",
		type: "post",
		data: {
			IdMuisc: IdMuisc
		},
		success: function (result) {
			switch (result) {
				case 0:
					toastr.error(NotFindSong, Notification_Error)
					break;
				case 1:
					toastr.error(IdMmusicNull, Notification_Error)
					break;
				default:
					$("#CurrentFile").append(result.nameFile);
					$("#Txt_EnterNameMusic").val(result.nameMuisc);
					$("#Txt_EnterNameAuthor").val(result.author);
					//season
					var HtmlDefault = '<option selected value="' + result.idSeason + '">' + result.nameSeason + '</option>';
					$("#SelectSeason").append(HtmlDefault);
					$.each(result.l_Season, function (key, item) {
						var html = "";
						html += '<option value="' + item.id + '">' + item.name + '</option>';
						$("#SelectSeason").append(html);
					})
					//saints
					var HtmlSaints = '<option selected value="' + result.idSaint + '">' + result.nameSaint + '</option>';
					$("#SelectSainst").append(HtmlSaints);
					$.each(result.l_Saint, function (key, item) {
						var html = "";
						html += '<option value="' + item.idSaint + '">' + item.nameSaint + '</option>';
						$("#SelectSainst").append(html);
					})
					//Image
					Urlimage = result.contentImage;
			}
			return;
        }
    })
}

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
//select season
$("#SelectSeason").change(function () {
	var GetId = $("#SelectSeason").val();
	if (GetId == 6) {
		$("#btn_EditSainst").show();
		$("#btn_SaveSainst").hide();
	} else {
		$("#btn_EditSainst").hide();
		$("#btn_SaveSainst").hide();
		$("#SelectSainst").prop('disabled', true);
    }
});

//---------------------------------------------------------------------
//edit saint
$("#btn_EditSainst").click(function(){
	$("#btn_EditSainst").hide();
	$("#btn_SaveSainst").show();

	$("#btn_confimEdit").hide();
	$("#SelectSainst").prop('disabled', false);
});
//save saint
$("#btn_SaveSainst").click(function(){
	$("#btn_SaveSainst").hide();
	$("#btn_EditSainst").show();

	$("#btn_confimEdit").show();
	$("#SelectSainst").prop('disabled', true);
});

//-------------------------------------------------------------------
//change file doc
$("#FileExport").change(function () {
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
	$("#TxtNameFile").empty();
	$("#TxtNameFile").append(Get_NameFile);
	return;
});


//change Imgae doc
var Save_Url;
document.getElementById('FileImageExport').onchange = e => {
	if (Save_Url != null) {
		URL.revokeObjectURL(Save_Url);
	}
	const file = e.target.files[0]; // this Object holds a reference to the file on disk
	const url = URL.createObjectURL(file); // this points to the File object we just created
	Save_Url = url;
	document.getElementById('img_NewAvata').src = url
	return;
};

//view image
$("#ViewImage").click(function () {
	var getdata = $("#FileImageExport").val();
	if (getdata == null) {
		$("#ImageMusic_DataUpdate").empty();
		var html = '<p>' + Younot_selectedimage + '<p/>';
		$("#ImageMusic_DataUpdate").append(html);
	}
	$("#modal_ShowContentFileUpdate").show();
});
$("#btn_closecontentfileImage").click(function () {
	$("#modal_ShowContentFileUpdate").hide();
});

//---------------------------------------------------------------------
//confim edit music
$("#btn_confimEdit").click(function () {
	var Get_NameMusic = $("#Txt_EnterNameMusic").val();
	var Get_NameAuthor = $("#Txt_EnterNameAuthor").val();
	var Get_IdSeason = $("#SelectSeason").val();
	var Get_IdSaint = $("#SelectSainst").val();

	var CheckImage = document.getElementById("FileImageExport").files[0]
	var CheckDoc = document.getElementById("FileExport").files[0]

	if (CheckDoc != null) {
		var filename = document.getElementById("FileExport").files[0].name;
		var SeachValue = filename.search(".doc");
		if (SeachValue == -1) {
			toastr.error(SystemRequest, Notification_Error);
			return;
		} else {
			if (CheckImage == null) {
				toastr.error(ImageNot_Null, Notification_Error);
				return;
			}
		}
	}
	if (CheckImage != null) {
		if (CheckDoc == null) {
			toastr.error(SystemRequest, Notification_Error);
			return;
        }
	}

	var files_Image = $("#FileImageExport").prop("files");
	var files_Doc = $("#FileExport").prop("files");
	var formData = new FormData();
	for (var i = 0; i < files_Doc.length; i++) {
		formData.append("FileMusic", files_Doc[i]);
	}
	for (var i = 0; i < files_Image.length; i++) {
		formData.append("FileImage", files_Image[i]);
	}
	var UpdateMusic = {
		IdMuisc: IdMuisc,
		NameMuisc: Get_NameMusic,
		Author: Get_NameAuthor,
		IdSeason: Get_IdSeason,
		IdSaint: Get_IdSaint
	}
	formData.append("UpdateMuisc_V", JSON.stringify(UpdateMusic));
	$("#modal_LoadingCreateMusic").show();
	$.ajax({
		url: "/ManagerData/JsonUpdateMuisc",
		type: "post",
		data: formData,
		contentType: false,
		processData: false,
		success: function (result) {
			$("#modal_LoadingCreateMusic").hide();
			switch (result.isStatus) {
				case 1:
					toastr.error(NotFindSong, Notification_Error);
					break;
				case 2:
					toastr.error(NotFindIdUser_Create, Notification_Error)
					break;
				case 3:
					toastr.success(UpdateMusic_Success, Nofitication_Success)
					LoadDataUpdate();
					break;
				case 4:
					toastr.error(UpdateMusic_Erorr, Notification_Error)
					break;
				case 5:
					toastr.error(IdMmusicNull, Notification_Error)
					break;
            }
			return;
        }
    })
});

//read image music
$("#CurrentFile").click(function () {
	$("#ImageMusic_Data").empty();
	var img = '<img src="data:image/jpg;base64,' + Urlimage + '" style="width: auto; height: auto;"/>'
	$("#ImageMusic_Data").append(img);
	$("#modal-ShowContentFileDox").show();
	return;
});
$("#btn_closecontentfile").click(function () {
	$("#modal-ShowContentFileDox").hide();
	return;
});