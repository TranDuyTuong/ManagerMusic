//valiable
var ErrorNotification = $("#ErrorNotification").val();
var ViewDetail = $("#ViewDetail").val();
var Dowload = $("#Dowload").val();
var Seasons_Year_round = $("#Seasons_Year_round").val();
var Christmas_season = $("#Christmas_season").val();
var Lent = $("#Lent").val();
var Easter_season = $("#Easter_season").val();
var Advent = $("#Advent").val();
var Outside_of_the_calendar = $("#Outside_of_the_calendar").val();
var turn = $("#turn").val();
var Choose_the_Season_You_Need = $("#Choose_the_Season_You_Need").val();
var keyword_search = $("#keyword_search").val();

$(document).ready(function () {
	LoadTotalRatingsComment();
	LoadDataProgsesMuisc();
	LoadMuiscDowloadMoreMonth();
	LoadTotalUserHaveAccount();
	SeachKey = null;
	SeachSeason = null;
	Flap = 0;
})
var Flap;

//show list music were dowload
$("#showListMusic_Dowload").click(function () {
	LoadDataMuiscDowload();
});
$("#btn-closeModalDowload").click(function(){
	$("#modal-ShowMusic-Dowload").hide();
	window.location.reload();
});
//funtion load data muisc dowload
function LoadDataMuiscDowload() {
	$("#BodyDowload").empty();
	$.ajax({
		url: "/Home/GetAllMusicDowload",
		type: "get",
		data: {
			SeachKey: SeachKey,
			Flap: Flap,
			IdSeason: SeachSeason
        },
		success: function (result) {
			var count = 0;
			$.each(result, function (key, item) {
				var html = "";
				count++;
				html += '<tr id="' + item.idMusic + '">';
				html += '<th scope="row">' + count + '</th>';
				html += '<td>' + item.nameMuisc + '</td>';
				html += '<td>' + item.nameSeason + '</td>';
				html += '<td>' + item.totalDowload + '</td>';
				html += '<td>';
				html += '<button name="DetailDowload_M" class="btn-detail" type="button" data-bs-toggle="tooltip" data-bs-placement="top" title="' + ViewDetail + '"><i class="fas fa-folder-open"></i></button>';
				html += '</td>';
				html += '</tr>';
				$("#BodyDowload").append(html);
			})
			$("#modal-ShowMusic-Dowload").show();
			return;
		}
	})
}

//reset data
$("#Btn_reset").click(function () {
	SeachKey = null;
	SeachSeason = null;
	Flap = 0;
	LoadDataMuiscDowload();
})

//show detail music by id
$(document).on('click', 'button[name="DetailDowload_M"]', function () {
	var IdMusic = $(this).closest("tr").attr("id");
	$("#BodyDetailDowload").empty();
	$.ajax({
		url: "/Home/DetailMuiscDowload",
		type: "get",
		data: {
			IdMuisc: IdMusic
		},
		success: function (result) {
			var count = 0;
			$.each(result, function (key, item) {
				var html = "";
				count++;
				html += '<tr id="' + item.idMusic + '">';
				html += '<th scope="row">' + count + '</th>';
				html += '<td>' + item.nameMuisc + '</td>';
				html += '<td>' + item.nameSeason + '</td>';
				html += '<td>' + item.dateDowload + '</td>';
				html += '<td>' + item.timeDowload + '</td>';
				html += '<td>';
				html += '<button class="btn-dowload" type="button" data-bs-toggle="tooltip" data-bs-placement="top" title="' + Dowload + '"><i class="fas fa-file-download"></i></button>';
				html += '</td>';
				html += '</tr>';
				$("#BodyDetailDowload").append(html);
			})
			$("#modal-ShowMusic-Dowload").hide();
			$("#ShowMusicDetailDowload").show();
        }
    })
	return;
});
$("#closeDetailDowload").click(function () {
	$("#ShowMusicDetailDowload").hide();
	$("#modal-ShowMusic-Dowload").show();
})

//show modal option choose seach name music dowload
$("#btn-SeachNameMusicOption-Dowload").click(function(){
	$("#modal-ShowOption-SeachMusicDowload").show();
});
$("#btn-CloseModalOption-SeachMusicDowload").click(function(){
	$("#modal-ShowOption-SeachMusicDowload").hide();
});
var SeachSeason;
$("#Btn_SeachMusicDowload").click(function () {
	var GetIdSeason = $("#SelectSeason").val();
	if (GetIdSeason == 0) {
		toastr.error(Choose_the_Season_You_Need, ErrorNotification);
	} else {
		SeachSeason = GetIdSeason
		Flap = 2;
		$("#seachNameMusic-Dowload").val('');
		SeachKey = null;
		LoadDataMuiscDowload();
		$("#modal-ShowOption-SeachMusicDowload").hide();
    }
	return;
});

//seach name muisc dowload nomal
var SeachKey;
function SeachMuiscDowloadNomal() {
	SeachKey = $(".seachNameMusic-Dowload").val();
	if (SeachKey == null || SeachKey == "") {
		toastr.error(keyword_search, ErrorNotification);
		Flap = 0;
	} else {
		Flap = 1;
	}
	LoadDataMuiscDowload();
	return;
}

//Show modal show rule Infomation website
$("#btn-InfomationWebsite").click(function(){
	$("#modal-InfomationWabsite-Music").show();
});
$("#btn-closeInfomation").click(function(){
	$("#modal-InfomationWabsite-Music").hide();
});

//get total muisc by season proseing
function LoadDataProgsesMuisc() {
	$("#BodyProgress").empty();
	$.ajax({
		url: "/Home/GetTotalMusicBySeason",
		type: "get",
		success: function (result) {
			$.each(result, function (key, item) {
				var html = "";
				switch (item.idSeason) {
					case 1:
						html += '<div class="az-traffic-detail-item">';
						html += '<div>';
						html += '<span>' + Seasons_Year_round + '</span>';
						html += '<span>' + item.totalMusic + '</span>';
						html += '</div>';
						html += '<div class="progress">';
						html += '<div class="progress-bar bg-success wd-' + item.totalMusic + 'p" role="progressbar" aria-valuenow="' + item.totalMusic + '" aria-valuemin="0" aria-valuemax="0"></div>';
						html += '</div>';
						html += '</div>';
						break;
					case 2:
						html += '<div class="az-traffic-detail-item">';
						html += '<div>';
						html += '<span>' + Advent + '</span>';
						html += '<span>' + item.totalMusic + '</span>';
						html += '</div>';
						html += '<div class="progress">';
						html += '<div class="progress-bar bg-danger wd-' + item.totalMusic + 'p" role="progressbar" aria-valuenow="' + item.totalMusic + '" aria-valuemin="0" aria-valuemax="0"></div>';
						html += '</div>';
						html += '</div>';
						break;
					case 3:
						html += '<div class="az-traffic-detail-item">';
						html += '<div>';
						html += '<span>' + Christmas_season + '</span>';
						html += '<span>' + item.totalMusic + '</span>';
						html += '</div>';
						html += '<div class="progress">';
						html += '<div class="progress-bar bg-info wd-' + item.totalMusic + 'p" role="progressbar" aria-valuenow="' + item.totalMusic + '" aria-valuemin="0" aria-valuemax="0"></div>';
						html += '</div>';
						html += '</div>';
						break;
					case 4:
						html += '<div class="az-traffic-detail-item">';
						html += '<div>';
						html += '<span>' + Easter_season + '</span>';
						html += '<span>' + item.totalMusic + '</span>';
						html += '</div>';
						html += '<div class="progress">';
						html += '<div class="progress-bar bg-warning wd-' + item.totalMusic + 'p" role="progressbar" aria-valuenow="' + item.totalMusic + '" aria-valuemin="0" aria-valuemax="0"></div>';
						html += '</div>';
						html += '</div>';
						break;
					case 5:
						html += '<div class="az-traffic-detail-item">';
						html += '<div>';
						html += '<span>' + Lent + '</span>';
						html += '<span>' + item.totalMusic + '</span>';
						html += '</div>';
						html += '<div class="progress">';
						html += '<div class="progress-bar bg-purple wd-' + item.totalMusic + 'p" role="progressbar" aria-valuenow="' + item.totalMusic + '" aria-valuemin="0" aria-valuemax="0"></div>';
						html += '</div>';
						html += '</div>';
						break;
					case 6:
						html += '<div class="az-traffic-detail-item">';
						html += '<div>';
						html += '<span>' + Outside_of_the_calendar + '</span>';
						html += '<span>' + item.totalMusic + '</span>';
						html += '</div>';
						html += '<div class="progress">';
						html += '<div class="progress-bar bg-gray-500 wd-' + item.totalMusic + 'p" role="progressbar" aria-valuenow="' + item.totalMusic + '" aria-valuemin="0" aria-valuemax="0"></div>';
						html += '</div>';
						html += '</div>';
						break;
				}
				$("#BodyProgress").append(html);
            })
        }
    })
};

//funtion load muisc dowload more in month
function LoadMuiscDowloadMoreMonth() {
	$("#MusicDowloadMoreMonth").empty();
	$.ajax({
		url: "/Home/GetMuiscDowloadMoreMonth",
		type: "get",
		success: function (result) {
			$.each(result, function (key, item) {
				var html = "";
				html += '<div class="az-list-item">';
				html += '<div>';
				html += '<h6>' + item.nameMuisc + '</h6>';
				html += '<span>' + item.nameAuthor + '</span>';
				html += '</div>';
				html += '<div>';
				html += '<h6 class="tx-primary">' + item.totalDowload + ' - ' + turn + '</h6>';
				html += '<span>' + item.nameSeason + '</span>';
				html += '</div>';
				html += '</div>';
				$("#MusicDowloadMoreMonth").append(html);
            })
        }
    })
};

//funtion total user have account
function LoadTotalUserHaveAccount() {
	$("#UserAccount").empty();
	$.ajax({
		url: "/Home/GetTotalUserAccount",
		type: "get",
		success: function (result) {
			$("#UserAccount").append(result);
        }
    })
}

//funtion load total ratings
function LoadTotalRatingsComment() {
	$("#TotalRatings").empty();
	$("#TotalComments").empty();
	$.ajax({
		url: "/Home/TotalRatingAndComment/",
		type: "get",
		success: function (result) {
			$("#TotalRatings").append(result.totalRating);
			$("#TotalComments").append(result.totalComment);
        }
    })
}
