//varlidate
var dayNow;
var mothNow;
var yearNow;
var HourNow;
var MinutesNow;
var SecondsNow;
var MessageValidate = "Không được bỏ trống!";
var MessageValidateSelect = "Vui lòng chọn một giá trị!"
var Hmtl = '<i class="fas fa-check"></i>';

var DataSelectTextSeason;
var DataSelectValueSeason;


//-------------------------------------------------
$(document).ready(function(){

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
$("#btn-createFileMusic").click(function(){
	var Get_NameMusic = $("#TxtNameMusic").val();
	var Get_NameAuthor = $("#TxtNemAuthor").val();
	var Get_SeasonSelect = $("#SelectSeason").val();
	var Get_StatusSelect = $("#SelectStatus").val();
	var Get_SainsSelect = $("#SelectSainst").val();
	var Get_IdAdmin = $("#TxtIdAdmin").val();
	var Get_NameAdmin = $("#TxtNameAdmin").val();
	var Get_CurrenDay = $("#TxtCreateCurrenDay").val();
	var Get_Time = $("#TxtCreateTime").val();
	$("#modal_LoadingCreateMusic").show();
});

//--------------------------------------------------------
//funtion read content file
$("#btn-readcontentfile").click(function(){
	$("#modal-ShowContentFileDox").show();
});
//funtion close modal read content file
$("#btn-closecontentfile").click(function(){
	$("#modal-ShowContentFileDox").hide();
});