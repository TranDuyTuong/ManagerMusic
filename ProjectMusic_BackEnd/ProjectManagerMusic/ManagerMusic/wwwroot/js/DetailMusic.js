"use strict";
// Creating a connection to SignalR Hub
var connection = new signalR.HubConnectionBuilder().withUrl("/signalr-hubs").build();

// Starting the connection with server
connection.start().then(function () { }).catch(function (err) {
	return console.error(err.toString());
});

var IdMuisc = $("#IdMusic_D").val();
var first_comment = $("#first_comment").val();
var Notification_Error = $("#Notification_Error").val();
var entercomment_text = $("#entercomment_text").val();
var Rating_VL;

$(document).ready(function () {
	LoadDetailMusic();
});

//load data muisc
var UrlFile;
var TypeFile;
function LoadDetailMusic() {
	$("#Txt_TitleMusic").empty();
	$(".dragscroll").empty();
	$.ajax({
		url: "/ClientListMusic/DetailMuiscClient",
		type: "get",
		data: {
			IdMuisc: IdMuisc
		},
        success: function (result) {
			var control = "";
			UrlFile = result.contetnFile;
			TypeFile = result.typeFile;
            switch (result.typeFile) {
                case "JPG":
					control = '<img id="map" class="img-fluid" src="data: image/JPG;base64, ' + result.contetnFile + '"/>'
                    break;
                case "jpg":
					control = '<img id="map" class="img-fluid" src="data: image/jpg;base64, ' + result.contetnFile + '"/>'
                    break;
                case "JPEG":
					control = '<img id="map" class="img-fluid" src="data: image/JPEG;base64, ' + result.contetnFile + '"/>'
                    break;
                case "jpeg":
					control = '<img id="map" class="img-fluid" src="data: image/jpeg;base64, ' + result.contetnFile + '"/>'
                    break;
                case "PNG":
					control = '<img id="map" class="img-fluid" src="data: image/PNG;base64, ' + result.contetnFile + '"/>'
                    break;
                case "png":
					control = '<img id="map" class="img-fluid" src="data: image/png;base64, ' + result.contetnFile + '"/>'
                    break;
                case "GIF":
					control = '<img id="map" class="img-fluid" src="data: image/GIF;base64, ' + result.contetnFile + '"/>'
                    break;
                case "gif":
					control = '<img id="map" class="img-fluid" src="data: image/gif;base64, ' + result.contetnFile + '"/>'
                    break;
			}
			$(".dragscroll").append(control);

			$("#Txt_TitleMusic").append(result.nameMusic);
			$("#TxtIdMuiscs").val(result.noMuisc)
			$("#TxtAuthor").val(result.author)
			$("#TxtDateCreate").val(result.str_DateCreate)
			$("#TxtFileName").val(result.fileName)
			$("#TxtNameSeason").val(result.nameSeason)
			$("#TxtNameSaint").val(result.nameSaint)
			$("#TxtTotalLike").val(result.totalLike)
			$("#TxtTotalDowload").val(result.totalDowload)
			$("#TxtTotalComment").val(result.totalComment)
        }
    })
}

//zoom image
function zoomin() {
	var myImg = document.getElementById("map");
	var currWidth = myImg.clientWidth;
	//if(currWidth == 2500) return false;
	// else{
	//    myImg.style.width = (currWidth + 100) + "px";
	//} 
	myImg.style.width = (currWidth + 100) + "px";
}
function zoomout() {
	var myImg = document.getElementById("map");
	var currWidth = myImg.clientWidth;
	if (currWidth == 100) return false;
	else {
		myImg.style.width = (currWidth - 100) + "px";
	}
}

//full screen
function FullCreen() {
	var control = "";
	$("#BodayImage").empty();
	switch (TypeFile) {
		case "JPG":
			control = '<img class="img-fluid" src="data: image/JPG;base64, ' + UrlFile + '"/>'
			break;
		case "jpg":
			control = '<img class="img-fluid" src="data: image/jpg;base64, ' + UrlFile + '"/>'
			break;
		case "JPEG":
			control = '<img class="img-fluid" src="data: image/JPEG;base64, ' + UrlFile + '"/>'
			break;
		case "jpeg":
			control = '<img class="img-fluid" src="data: image/jpeg;base64, ' + UrlFile + '"/>'
			break;
		case "PNG":
			control = '<img class="img-fluid" src="data: image/PNG;base64, ' + UrlFile + '"/>'
			break;
		case "png":
			control = '<img class="img-fluid" src="data: image/png;base64, ' + UrlFile + '"/>'
			break;
		case "GIF":
			control = '<img class="img-fluid" src="data: image/GIF;base64, ' + UrlFile + '"/>'
			break;
		case "gif":
			control = '<img class="img-fluid" src="data: image/gif;base64, ' + UrlFile + '"/>'
			break;
	}
	$("#BodayImage").append(control);
	$("#modalFull_Screen").show();
}
$("#CloseScreen").click(function () {
	$("#modalFull_Screen").hide();
	window.location.reload();
})

//view type file pdf
function ViewPDFfile() {
	window.location.href = "/ClientListMusic/DisplayPDFMusic/?IdMuisc_PDF=" + IdMuisc;
}

//dowload file pdf
function Btn_DowloadFilePDF() {
	window.location = window.location.origin + "/ClientListMusic/DowloadPdfClient/?IdMuisc=" + IdMuisc;
}

//qr core
$("#btn_QRcode").click(function () {
	$("#modal_QRCode").show();
	return;
})
$("#colse_QRcode").click(function(){
	$("#modal_QRCode").hide();
	return;
})

//comment--------------------------------------------------------------------------------------------------
// Subscribing to the messages broadcasted by Hub every time when a new message is pushed to it
connection.on("ReceiveMessage", function (result) {
	LoadAllComment_AffterSent(result);
});
// Sending the message from Client
document.getElementById("Btn_SentComment").addEventListener("click", function (event) {
	var GetText = $("#TxtCommentMusic").val();
	if (GetText.length == 0) {
		toastr.error(entercomment_text, Notification_Error)
	} else {
		connection.invoke("SendComment", IdMuisc, GetText).catch(function (err) {
			return console.error(err.toString());
		});
		$("#TxtCommentMusic").val('');
		document.getElementById("TxtCommentMusic").focus();
		event.preventDefault();
	}
	return;
});

function LoadAllComment_Reaload() {
	$("#BodyComment").empty();
	$("#TotalComment").empty();
	$.ajax({
		url: "/ClientListMusic/GetCommentByIdMuisc/",
		type: "get",
		data: {
			IdMuisc: IdMuisc
		},
		success: function (result) {
			$("#TotalComment").append(result.totalComment)
			if (result.userStatus == 1) {
				document.getElementById('Btn_SentComment').style.display = "block";
			} else {
				document.getElementById('Btn_SentComment').style.display = "none";
			}
			if (result.totalComment == 0) {
				var HtmlDefaul = first_comment;
				$("#BodyComment").append(HtmlDefaul);
			} else {
				$.each(result.l_CommentMuisc, function (key, item) {
					var html = "";
					html += '<li class="list-group-item">';
					html += '<div class="row">';
					html += '<div class="col-md-10">';
					html += '<p style="font-family: initial; font-size: 17px;">';
					html += '<b><i class="fas fa-user"></i> ' + item.nameUser + ': </b>';
					html += '' + item.content + ' <i class="fas fa-pen"></i>';
					html += '</p>';
					html += '</div>';
					html += '<div class="col-md-2">';
					html += '<p style="text-align: right; color: #969696"><i>' + item.str_DateCreate + '</i></p>';
					html += '</div>';
					html += '</div>';
					html += '</li>';
					$("#BodyComment").append(html);
				})
			}
		}
	})
}

function LoadAllComment_AffterSent(result) {
	$("#BodyComment").empty();
	$("#TotalComment").empty();
	$("#TotalComment").append(result.length);
	$.each(result, function (key, item) {
		var html = "";
		html += '<li class="list-group-item">';
		html += '<div class="row">';
		html += '<div class="col-md-10">';
		html += '<p style="font-family: initial; font-size: 17px;">';
		html += '<b><i class="fas fa-user"></i> ' + item.nameUser + ': </b>';
		html += '' + item.content + ' <i class="fas fa-pen"></i>';
		html += '</p>';
		html += '</div>';
		html += '<div class="col-md-2">';
		html += '<p style="text-align: right; color: #969696"><i>' + item.str_DateCreate + '</i></p>';
		html += '</div>';
		html += '</div>';
		html += '</li>';
		$("#BodyComment").append(html);
	})
}

$("#btn_Comment").click(function () {
	LoadAllComment_Reaload();
	$("#modal_Comment").show();
	return;
})
$("#colse_Comment").click(function () {
	$("#modal_Comment").hide();
	window.location.reload();
	return;
})
