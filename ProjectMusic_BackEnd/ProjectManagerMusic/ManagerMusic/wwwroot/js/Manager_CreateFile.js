//varlidate
var dayNow;
var mothNow;
var yearNow;
var HourNow;
var MinutesNow;
var SecondsNow;
var MessageValidate = $("#NotNull_Data").val();
var MessageValidateSelect = $("#Choose_avalue").val();
var Hmtl = '<i class="fas fa-check"></i>';
var Notification_Error = $("#Notification_Error").val();
var NotFind_StatusMusic = $("#NotFind_StatusMusic").val();
var SystemRequest = $("#SystemRequest").val();
var CreateMusic_Success = $("#CreateMusic_Success").val();
var Nofitication_Success = $("#Nofitication_Success").val();
var CreateMusic_Error = $("#CreateMusic_Error").val();
var Notification_Error = $("#Notification_Error").val();
var songAlready_exists = $("#songAlready_exists").val();
var NotFindIdUser_Create = $("#NotFindIdUser_Create").val();
var Choose_the_Season_You_Need = $("#Choose_the_Season_You_Need").val();
var Choose_Status = $("#Choose_Status").val();

var DataSelectTextSeason;
var DataSelectValueSeason;


//-------------------------------------------------
$(document).ready(function(){
	LoadAllSaint();
	LoadStatusMusic();
});

//-------------------------------------------------
//funtion get all saint
function LoadAllSaint() {
	$.ajax({
		url: "/ManagerSaint/JsonGetAllSaintActiver",
		type: "get",
		success: function (result) {
			if (result == 0) {

			} else {
				var SelectSaint = $("#SelectSainst").empty();
				var HtmlDefaul = '<option selected value="0">' + Choose_the_Season_You_Need + ' ...</option>'
				SelectSaint.append(HtmlDefaul);
				$.each(result, function (key, item) {
					var html = "";
					html += '<option value="' + item.idSaint + '">' + item.nameSaint + '</option>';
					SelectSaint.append(html);
				})
				return;
            }
        }
    })
}

//-------------------------------------------------
//funtion an diplay select season = 6
$("#SelectSeason").change(function () {
	var itemData = $("#SelectSeason").val();
	if (itemData == 6) {
		$("#SelectSainst").prop('disabled', false);
	} else {
		$("#SelectSainst").prop('disabled', true);
		LoadAllSaint()
	}
	return;
});

//-------------------------------------------------
//funtion get all status music
function LoadStatusMusic() {
	var SelectStatus = $("#SelectStatus").empty();
	$.ajax({
		url: "/ManagerData/GetAllStatusMusic",
		type: "get",
		success: function (result) {
			if (result == 0) {
				toastr.error(NotFind_StatusMusic, Notification_Error);
			} else {
				var htmlSelect = '<option selected value="0">' + Choose_Status + ' ...</option>';
				SelectStatus.append(htmlSelect);
				$.each(result, function (key, item) {
					var html = "";
					html += '<option value="' + item.idStatusMusic + '">' + item.name + '</option>';
					SelectStatus.append(html);
				});
			}
			return;
        }
    })
}

//-------------------------------------------------
//funtion check vaule and name file
$("#FileExport").change(function () {
	var filename = document.getElementById("FileExport").files[0].name;
	var SeachValue = filename.search(".pdf");
	if (SeachValue == -1) {
		toastr.error(SystemRequest, Notification_Error);
	} else {
		var checkvaule = $("#checkOkFile").empty();
		checkvaule.append(Hmtl);
    }
	return;
});

//-------------------------------------------------
//funtion check vaule image
$("#ImageExport").change(function () {
	var filename = document.getElementById("ImageExport").files[0].name;
	if (filename == null) {
		toastr.error(MessageValidate, Notification_Error);
	} else {
		var checkvaule = $("#checkOkImage").empty();
		checkvaule.append(Hmtl);
	}
	return;
});

//--------------------------------------------------
//funtion check value name music
function CheckValueNameMusic(){
	var getValueNameMusic = $("#Txt_EnterNameMusic").val();
	$("#ValidaNameMusic").empty();
	$("#checkOkNameMusic").empty();
	if (getValueNameMusic.length == 0) {
		$("#ValidaNameMusic").append(MessageValidate);
		return;
	}else{
		$("#checkOkNameMusic").append(Hmtl);
		return;
	}	
}

//funtion check value name Author
function CheckValueNameAuthor() {
	var getValueNameAuthor = $("#Txt_EnterNameAuthor").val();
	$("#checkOkNameAuthor").empty();
	$("#ValidaNameAuthor").empty();
	if (getValueNameAuthor.length == 0) {
		$("#ValidaNameAuthor").append(MessageValidate);
		return;
	}else{
		$("#checkOkNameAuthor").append(Hmtl);
		return;
	}
}

//---------------------------------------------------
//funtion create music file
$("#btn_confimCreate").click(function(){

	//check data validate Name Music
	var getNameMusic = $("#Txt_EnterNameMusic").val();
	if (getNameMusic.length == 0) {
		$("#ValidaNameMusic").append(MessageValidate);
		return;
	}

	//check data validate Name Author
	var getNameAuthor = $("#Txt_EnterNameAuthor").val();
	if (getNameAuthor.length == 0) {
		$("#ValidaNameAuthor").append(MessageValidate);
		return;
	}

	//check validate data Season
	var getTextSelect = $("#SelectSeason option:selected").text();
	var getValueSelect = $("#SelectSeason").val();
	$("#ValidaSelectSeason").empty();
	if(getValueSelect == 0){
		$("#ValidaSelectSeason").append(MessageValidateSelect);
		return;
	}

	//check validate data status
	var getTextSelectStatus = $("#SelectStatus option:selected").text();
	var getValueSelectStatus = $("#SelectStatus").val();
	$("#ValidaSelectStatus").empty();
	if (getValueSelectStatus == 0) {
		$("#ValidaSelectStatus").append(MessageValidateSelect);
		return;
	}

	//check validate data Sainst
	var getTextSelectSainst = $("#SelectSainst option:selected").text();
	var getValueSelectSains = $("#SelectSainst").val();

	//check validate data Name Music
	var getData_NameMusic = $("#Txt_EnterNameMusic").val();
	if (getData_NameMusic.length == 0) {
		$("#ValidaNameMusic").empty();
		$("#ValidaNameMusic").append(MessageValidate);
		return;
	}
	//check validate data Name Author
	var getData_NameAuthor = $("#Txt_EnterNameAuthor").val();
	if (getData_NameAuthor.length == 0) {
		$("#ValidaNameAuthor").empty();
		$("#ValidaNameAuthor").append(MessageValidate);
		return;
	}

	//check file music
	var filename = $('#FileExport').val();
	if (filename.length == 0) {
		$("#ValidaFileNameMusic").empty();
		$("#ValidaFileNameMusic").append(MessageValidate);
		return;
	}

	var getdates = new Date();
	dayNow = getdates.getDate();
	mothNow = (getdates.getMonth()+1);
	yearNow = getdates.getFullYear();

	HourNow = getdates.getHours();
	MinutesNow = getdates.getMinutes();
	SecondsNow = getdates.getSeconds();

	$("#TxtCreateCurrenDay").empty();
	var Stringdate = mothNow + '/' + dayNow + '/' + yearNow;
	$("#TxtCreateCurrenDay").val(Stringdate);

	$("#TxtCreateTime").empty();
	var StingTime = HourNow + ':' + MinutesNow + ':' + SecondsNow;
	$("#TxtCreateTime").val(StingTime);

	//append data view modal
	$("#TxtNameMusic").val(getNameMusic);
	$("#TxtNemAuthor").val(getNameAuthor);
	$("#TxtSeason").val(getTextSelect);
	$("#TxtSainst").val(getTextSelectSainst);
	$("#TxtStatus").val(getTextSelectStatus);
	$("#TxtCreateNameFile").val(filename);
	$("#modal-showconfimcreatemusic").show();
});
//funtion close music file
$("#btn-closemodalcreatemusic").click(function(){
	$("#modal-showconfimcreatemusic").hide();
})

//funtion create music
$("#btn-createFileMusic").click(function () {
	$("#modal_LoadingCreateMusic").show();
	var Get_NameMusic = $("#TxtNameMusic").val();
	var Get_NameAuthor = $("#TxtNemAuthor").val();
	var Get_SeasonSelect = $("#SelectSeason").val();
	var Get_StatusSelect = $("#SelectStatus").val();
	var Get_SainsSelect = $("#SelectSainst").val();
	var getdates = new Date();
	dayNow = getdates.getDate();
	mothNow = (getdates.getMonth() + 1);
	yearNow = getdates.getFullYear();

	var filename = document.getElementById("ImageExport").files[0].name;
	if (filename == null) {
		toastr.error(MessageValidate, Notification_Error);
		return;
	} else {
		var checkvaule = $("#checkOkImage").empty();
		checkvaule.append(Hmtl);
	}

	var files = $("#FileExport").prop("files")
	var formData = new FormData();
	for (var i = 0; i < files.length; i++) {
		formData.append("fileDoc", files[i]);
	}

	var fileImages = $("#ImageExport").prop("files")
	for (var i = 0; i < fileImages.length; i++) {
		formData.append("fileImage", fileImages[i]);
	}

	var Create_Music = {
		NameMusic: Get_NameMusic,
		AuthorMusic: Get_NameAuthor,
		IdSeason: Get_SeasonSelect,
		IdStatusMusic: Get_StatusSelect,
		IdSaints: Get_SainsSelect,
		Date: dayNow,
		Month: mothNow,
		Year: yearNow
	};
	formData.append("Music", JSON.stringify(Create_Music));
	$.ajax({
		url: "/ManagerData/JsonCreateMusic",
		type: "post",
		data: formData,
		contentType: false,
		processData: false,
		success: function (result) {
			$("#modal_LoadingCreateMusic").hide();
			$("#modal-showconfimcreatemusic").hide();
			switch (result.isStatus) {
				case 1:
					toastr.success(CreateMusic_Success, Nofitication_Success)
					break;
				case 2:
					toastr.error(CreateMusic_Error, Notification_Error)
					break;
				case 3:
					toastr.error(songAlready_exists, Notification_Error)
					break;
				case 4:
					toastr.error(NotFindIdUser_Create, Notification_Error)
					break;
				default:
			}
			return;
        }
    })
});

//---------------------------------------------
var Save_Url;
//create url for image
document.getElementById('ImageExport').onchange = e => {
	if (Save_Url != null) {
		URL.revokeObjectURL(Save_Url);
	}
	const file = e.target.files[0]; // this Object holds a reference to the file on disk
	console.log(file);
	const url = URL.createObjectURL(file); // this points to the File object we just created
	Save_Url = url;
	document.getElementById('img_NewAvata').src = url
	return;
};
//funtion read content file
$("#btn-readcontentfile").click(function () {
	$("#modal-ShowContentFileDox").show();

});
//funtion close modal read content file
$("#btn-closecontentfile").click(function(){
	$("#modal-ShowContentFileDox").hide();
});