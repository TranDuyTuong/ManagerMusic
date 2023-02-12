"use strict";
// Creating a connection to SignalR Hub
var connection = new signalR.HubConnectionBuilder().withUrl("/signalr-hubrs").build();

// Starting the connection with server
connection.start().then(function () { }).catch(function (err) {
    return console.error(err.toString());
});

var head = $("#head").val();
var next = $("#next").val();
var last = $("#last").val();
var Before = $("#Before").val();
var NotFindSong = $("#NotFindSong").val();
var WasFind = $("#WasFind").val();
var the_song = $("#the_song").val();
var IdMusices = $("#IdMusic").val();
var namesong = $("#namesong").val();
var Music_composer = $("#Music_composer").val();
var Seasons = $("#Seasons").val();
var Name_Saint = $("#Name_Saint").val();
var datecreate = $("#datecreate").val();
var Youliked = $("#Youliked").val();
var GetQR_code = $("#GetQR_code").val();
var See_rating = $("#See_rating").val();
var ViewDetailSong = $("#ViewDetailSong").val();
var Likes = $("#Likes").val();
var Downloads = $("#Downloads").val();
var Starrating = $("#Starrating").val();
var Log_function = $("#Log_function").val();
var Notification_Error = $("#Notification_Error").val();
var Nofitication_Success = $("#Nofitication_Success").val();
var usercode_valid = $("#usercode_valid").val();
var alreadylike_song = $("#alreadylike_song").val();
var Likesong_success = $("#Likesong_success").val;
var least1stat_moststars = $("#least1stat_moststars").val();
var first_review = $("#first_review").val();
var canrate_anymore = $("#canrate_anymore").val();
var Successful_rating = $("#Successful_rating").val();
var Yourated_this = $("#Yourated_this").val();
var starsAd = $("#stars").val();
var improveourselves = $("#improveourselves").val();
var Choose_the_Season_You_Need = $("#Choose_the_Season_You_Need").val();
var Select_saint = $("#Select_saint").val();
var Rating_VL;
var IdMuisc;

$(document).ready(function () {
    SelectViewer = 0;
    SelectSeason = 0;
    SelectSaint = 0;
    SeachMusic = null;
    LoadDataMusic();
    ResetRating();
    LoadSeasonMuisc();
    LoadMuiscYesterday();
})

var PageSize = 12;
var PageIndex = 1;
var SelectViewer = 0;
var SelectSeason = 0;
var SelectSaint = 0;
var SeachMusic;
    //load data music
    function LoadDataMusic() {
        $("#TotalMuiscL").empty();
        $("#BodyMuisc").empty();
        $("#TotalItem").empty();
        $("#ItemInPage").empty();
        $.ajax({
            url: "/ClientListMusic/JsonGetListMusic",
            type: "get",
            data: {
                PageSize: PageSize,
                PageIndex: PageIndex,
                S_Viewer: SelectViewer,
                S_Season: SelectSeason,
                S_Saint: SelectSaint,
                S_Seach: SeachMusic
            },
            success: function (result) {
                if (SeachMusic != null) {                   
                    if (result.totalMusic == 0) {
                        $("#TxtTitleSeach").append(NotFindSong)
                    } else {
                        $("#TxtTitleSeach").append(WasFind + ' ' + result.totalMusic + ' ' + the_song)
                    }
                }
                var count = 0;
                switch (result.statusCase) {
                    case 1:
                        $.each(result.l_MusicClient, function (key, item) {
                            var html = "";
                            count++;
                            html += '<div class="col-sm-4">';
                            html += '<div class="card hoverCard">';
                            html += '<div class="card-body">';
                            html += ' <h5 class="card-title">';
                            html += '<p style="text-align: center; font-family: initial;">' + IdMusices +': ' + item.noMusic + '</p>';
                            html += '' + namesong + ': ' + item.nameMusic;
                            html += '</h5>';
                            html += '<p class="card-text">' + Music_composer + ': ' + item.author + '</p>';
                            html += '<p class="card-text">' + Seasons + ': <b>' + item.nameSeason + '</b></p>';
                            html += '<p class="card-text">' + Name_Saint + ': <b>' + item.nameSaint + '</b></p>';
                            html += '<p class="card-text" style="text-align: right;">' + datecreate + ': <b>' + item.str_DateCreate + '</b></p>';
                            html += '<div class="row">';
                            html += '<div class="col-md-6">';
                            html += '<p>';
                            html += '<input type="hidden" id="GetIdMuisc' + count + '" value="' + item.idMuisc + '" />'
                            if (item.userLike == 2) {
                                html += '<a class="btn btn-outline-success" data-bs-toggle="tooltip" data-bs-placement="right" title="' + Youliked + '" style="border: none;"><i class="fas fa-check"></i></a>';
                            } else {               
                                html += '<a onclick="likeMusicData(' + count + ')" class="btn btn-outline-primary" style="border: none;"><i class="fas fa-thumbs-up"></i></a>';
                            }
                            html += '<a onclick="QRcoreData(' + count + ')" class="btn btn-outline-success" data-bs-toggle="tooltip" data-bs-placement="top" title="' + GetQR_code + '" style="border: none;"><i class="fas fa-qrcode"></i></a>';
                            html += '<button type="button" onclick="funShowModal(' + count + ')" class="btn btn-outline-danger" data-bs-toggle="tooltip" data-bs-placement="top" title="' + See_rating + '" style="border: none;"><i class="fas fa-star"></i></button>';
                            html += '</p>';
                            html += '</div>';
                            html += '<div class="col-md-6">';
                            html += '<a href="/ClientListMusic/PageDetailMuisc/?IdMusic=' + item.idMuisc + '" class="btn btn-primary" style="border-radius: 10px;">' + ViewDetailSong + '</a>';
                            html += '</div>';
                            html += '</div>';
                            html += '<hr/>';
                            html += '<p class="card-text">' + Likes + ': <b style="color: blue;"><i class="fas fa-thumbs-up"></i> ' + item.like + '</b> - ' + Downloads + ': <b style="color: black;"><i class="fas fa-download"></i> ' + item.dowload + '</b> - ' + Starrating + ': <b style="color: black;"><i onclick="btn_rating(' + count + ')" class="far fa-star"></i></b></p>';
                            html += '</div>';
                            html += '</div>';
                            html += '</div>';
                            $("#BodyMuisc").append(html);
                        })
                        break;
                    case 2:
                        $.each(result.l_MusicClient, function (key, item) {
                            var html = "";
                            count++;
                            html += '<div class="col-sm-4">';
                            html += '<div class="card hoverCard">';
                            html += '<div class="card-body">';
                            html += ' <h5 class="card-title">';
                            html += '<p style="text-align: center; font-family: initial;">' + IdMusices + ': ' + item.noMusic + '</p>';
                            html += '' + namesong + ': ' + item.nameMusic;
                            html += '</h5>';
                            html += '<p class="card-text">' + Music_composer + ': ' + item.author + '</p>';
                            html += '<p class="card-text">' + Seasons + ': <b>' + item.nameSeason + '</b></p>';
                            html += '<p class="card-text">' + Name_Saint + ': <b>' + item.nameSaint + '</b></p>';
                            html += '<p class="card-text" style="text-align: right;">' + datecreate + ': <b>' + item.str_DateCreate + '</b></p>';
                            html += '<div class="row">';
                            html += '<div class="col-md-6">';
                            html += '<p>';
                            html += '<input type="hidden" id="GetIdMuisc' + count + '" value="' + item.idMuisc + '" />'
                            html += '<a class="btn btn-outline-primary" data-bs-toggle="tooltip" data-bs-placement="top" title="' + Log_function + '" style="border: none;"><i class="fas fa-lock"></i></a>';
                            html += '<a onclick="QRcoreData(' + count + ')" class="btn btn-outline-success" data-bs-toggle="tooltip" data-bs-placement="top" title="' + GetQR_code + '" style="border: none;"><i class="fas fa-qrcode"></i></a>';
                            html += '<button type="button" onclick="funShowModal(' + count + ')" class="btn btn-outline-danger" data-bs-toggle="tooltip" data-bs-placement="top" title="' + See_rating + '" style="border: none;"><i class="fas fa-star"></i></button>';
                            html += '</p>';
                            html += '</div>';
                            html += '<div class="col-md-6">';
                            html += '<a href="/ClientListMusic/PageDetailMuisc/?IdMusic=' + item.idMuisc + '" class="btn btn-primary" style="border-radius: 10px;">' + ViewDetailSong + '</a>';
                            html += '</div>';
                            html += '</div>';
                            html += '<hr/>';
                            html += '<p class="card-text">' + Likes + ': <b style="color: blue;"><i class="fas fa-thumbs-up"></i> ' + item.like + '</b> - ' + Downloads + ': <b style="color: black;"><i class="fas fa-download"></i> ' + item.dowload + '</b></p>';
                            html += '</div>';
                            html += '</div>';
                            html += '</div>';
                            $("#BodyMuisc").append(html);
                        })
                        break;
                }
                $("#TotalItem").append(PageIndex)
                $("#ItemInPage").append(count)
                $("#TotalMuiscL").append(result.totalMusic)
                //paing
                paging(result.totalMusic, function () {
                    LoadDataMusic();
                })
            }
        })
    };
    //----------------------------------------------
    //paing
function paging(totalRoll, callback) {
        var totalPage = Math.ceil(totalRoll / PageSize);
        $('#pagination').twbsPagination({
            totalPages: (totalPage == 0) ? 1 : totalPage,
            first: head,
            next: next,
            last: last,
            prev: Before,
            visiblePages: 10,
            onPageClick: function (event, page) {
                PageIndex = page;
                setTimeout(callback, 200);
            }
        });
    }

    //like muisc user
function likeMusicData(id) {
        var values = document.getElementById('GetIdMuisc' + id).value;
        $.ajax({
            url: "/ClientListMusic/PlusLikeMusic/",
            type: "post",
            data: {
                IdMuisc: values
            },
            success: function (result) {
                switch (result.idSatus) {
                    case 1:
                        toastr.error(NotFindSong, Notification_Error);
                        break;
                    case 2:
                        toastr.error(usercode_valid, Notification_Error);
                        break;
                    case 3:
                        toastr.error(alreadylike_song, Notification_Error);
                        break;
                    default:                       
                        LoadDataMusic();
                        toastr.success(Likesong_success, Nofitication_Success);
                        break;
                }
            }
        })
    }

    //ratring--------------------------------------------------------
connection.on("ReceiveRating", function (result) {
        LoadRatingWasSent(result)
});

    // Sending the message from Client
document.getElementById("btn_RatingM").addEventListener("click", function (event) {
        if (Rating_VL == 0) {
            toastr.error(least1stat_moststars, Notification_Error)
        } else {
            connection.invoke("SendRatings", IdMuisc, Rating_VL).catch(function (err) {
                return console.error(err.toString());
            });
            event.preventDefault();
        }
        return;
    });

function LoadRatingById(IdMuisc) {
        $("#Bodyrating").empty();
        $.ajax({
            url: "/ClientListMusic/GetRatingByIdMuisc/",
            type: "get",
            data: {
                IdMuisc: IdMuisc
            },
            success: function (result) {
                if (result.statusUser == 1) {
                    document.getElementById('btn_RatingM').style.display = "block";
                } else {
                    document.getElementById('btn_RatingM').style.display = "none";
                }

                if (result.l_Rating.length == 0) {
                    $("#Bodyrating").append(first_review);
                } else {
                    $.each(result.l_Rating, function (key, item) {
                        var html = "";
                        html += '<li class="list-group-item">';
                        html += '<div class="row">';
                        html += '<div class="col-md-10">';
                        html += '<p style="font-family: initial; font-size: 17px;">';
                        html += '<b><i class="fas fa-user"></i> ' + item.nameUser + ': </b>';
                        switch (item.ratings) {
                            case 1:
                                html += '<span class="fa fa-star checkedColor"></span>';
                                break;
                            case 2:
                                html += '<span class="fa fa-star checkedColor"></span>';
                                html += '<span class="fa fa-star checkedColor"></span>';
                                break;
                            case 3:
                                html += '<span class="fa fa-star checkedColor"></span>';
                                html += '<span class="fa fa-star checkedColor"></span>';
                                html += '<span class="fa fa-star checkedColor"></span>';
                                break;
                            case 4:
                                html += '<span class="fa fa-star checkedColor"></span>';
                                html += '<span class="fa fa-star checkedColor"></span>';
                                html += '<span class="fa fa-star checkedColor"></span>';
                                html += '<span class="fa fa-star checkedColor"></span>';
                                break;
                            case 5:
                                html += '<span class="fa fa-star checkedColor"></span>';
                                html += '<span class="fa fa-star checkedColor"></span>';
                                html += '<span class="fa fa-star checkedColor"></span>';
                                html += '<span class="fa fa-star checkedColor"></span>';
                                break;
                        }
                        html += '</p>';
                        html += '</div>';
                        html += '<div class="col-md-2">';
                        html += '<p style="text-align: right; color: #969696"><i>' + item.str_DateCreate + '</i></p>';
                        html += '</div>';
                        html += '</div>';
                        html += '</li>';
                        $("#Bodyrating").append(html);
                    })
                }

            }
        })
    }

function LoadRatingWasSent(result) {
        console.log(result);
        $("#Bodyrating").empty();
        switch (result.notification) {
            case 1:
                toastr.error(canrate_anymore, Notification_Error);
                $.each(result.l_Rating, function (key, item) {
                    var html = "";
                    html += '<li class="list-group-item">';
                    html += '<div class="row">';
                    html += '<div class="col-md-10">';
                    html += '<p style="font-family: initial; font-size: 17px;">';
                    html += '<b><i class="fas fa-user"></i> ' + item.nameUser + ': </b>';
                    switch (item.ratings) {
                        case 1:
                            html += '<span class="fa fa-star checkedColor"></span>';
                            break;
                        case 2:
                            html += '<span class="fa fa-star checkedColor"></span>';
                            html += '<span class="fa fa-star checkedColor"></span>';
                            break;
                        case 3:
                            html += '<span class="fa fa-star checkedColor"></span>';
                            html += '<span class="fa fa-star checkedColor"></span>';
                            html += '<span class="fa fa-star checkedColor"></span>';
                            break;
                        case 4:
                            html += '<span class="fa fa-star checkedColor"></span>';
                            html += '<span class="fa fa-star checkedColor"></span>';
                            html += '<span class="fa fa-star checkedColor"></span>';
                            html += '<span class="fa fa-star checkedColor"></span>';
                            break;
                        case 5:
                            html += '<span class="fa fa-star checkedColor"></span>';
                            html += '<span class="fa fa-star checkedColor"></span>';
                            html += '<span class="fa fa-star checkedColor"></span>';
                            html += '<span class="fa fa-star checkedColor"></span>';
                            break;
                    }
                    html += '</p>';
                    html += '</div>';
                    html += '<div class="col-md-2">';
                    html += '<p style="text-align: right; color: #969696"><i>' + item.str_DateCreate + '</i></p>';
                    html += '</div>';
                    html += '</div>';
                    html += '</li>';
                    $("#Bodyrating").append(html);
                })
                break;
            case 2:
                toastr.success(Successful_rating, Nofitication_Success);
                $.each(result.l_Rating, function (key, item) {
                    var html = "";
                    html += '<li class="list-group-item">';
                    html += '<div class="row">';
                    html += '<div class="col-md-10">';
                    html += '<p style="font-family: initial; font-size: 17px;">';
                    html += '<b><i class="fas fa-user"></i> ' + item.nameUser + ': </b>';
                    switch (item.ratings) {
                        case 1:
                            html += '<span class="fa fa-star checkedColor"></span>';
                            break;
                        case 2:
                            html += '<span class="fa fa-star checkedColor"></span>';
                            html += '<span class="fa fa-star checkedColor"></span>';
                            break;
                        case 3:
                            html += '<span class="fa fa-star checkedColor"></span>';
                            html += '<span class="fa fa-star checkedColor"></span>';
                            html += '<span class="fa fa-star checkedColor"></span>';
                            break;
                        case 4:
                            html += '<span class="fa fa-star checkedColor"></span>';
                            html += '<span class="fa fa-star checkedColor"></span>';
                            html += '<span class="fa fa-star checkedColor"></span>';
                            html += '<span class="fa fa-star checkedColor"></span>';
                            break;
                        case 5:
                            html += '<span class="fa fa-star checkedColor"></span>';
                            html += '<span class="fa fa-star checkedColor"></span>';
                            html += '<span class="fa fa-star checkedColor"></span>';
                            html += '<span class="fa fa-star checkedColor"></span>';
                            break;
                    }
                    html += '</p>';
                    html += '</div>';
                    html += '<div class="col-md-2">';
                    html += '<p style="text-align: right; color: #969696"><i>' + item.str_DateCreate + '</i></p>';
                    html += '</div>';
                    html += '</div>';
                    html += '</li>';
                    $("#Bodyrating").append(html);
                })
                break;
        }
        return;
    }

function ResetRating() {
    /* 1. Visualizing things on Hover - See next part for action on click */
    $('#stars li').on('mouseover', function () {
        var onStar = parseInt($(this).data('value'), 10); // The star currently mouse on
        // Now highlight all the stars that's not after the current hovered star
        $(this).parent().children('li.star').each(function (e) {
            if (e < onStar) {
                $(this).addClass('hover');
            }
            else {
                $(this).removeClass('hover');
            }
        });

    }).on('mouseout', function () {
        $(this).parent().children('li.star').each(function (e) {
            $(this).removeClass('hover');
        });
    });
    /* 2. Action to perform on click */
    $('#stars li').on('click', function () {
        var i;
        var onStar = parseInt($(this).data('value'), 10); // The star currently selected
        var stars = $(this).parent().children('li.star');

        for (i = 0; i < stars.length; i++) {
            $(stars[i]).removeClass('selected');
        }

        for (i = 0; i < onStar; i++) {
            $(stars[i]).addClass('selected');
        }

        // JUST RESPONSE (Not needed)
        var ratingValue = parseInt($('#stars li.selected').last().data('value'), 10);
        var msg = "";
        if (ratingValue > 1) {
            msg = Yourated_this + " " + ratingValue + " " + starsAd;
        }
        else {
            msg = improveourselves + " " + ratingValue + " " + starsAd;
        }
        Rating_VL = ratingValue;
        responseMessage(msg);
    })
};

function responseMessage(msg) {
        $('.success-box').fadeIn(200);
        $('.success-box div.text-message').html("<span>" + msg + "</span>");
}

function btn_rating(Id) {
    var value = document.getElementById('GetIdMuisc' + Id).value;
    IdMuisc = value;
    LoadRatingById(value);
    $("#modal_Rating").show();
    return;
}
$("#close_Rating").click(function () {
    $("#modal_Rating").hide();
    location.reload();
    return;
})

function funShowModal(Id) {
    $("#Body_1Start").empty();
    $("#Body_2Start").empty();
    $("#Body_3Start").empty();
    $("#Body_4Start").empty();
    $("#Body_5Start").empty();
    $("#Totla_1Star").empty();
    $("#Totla_2Star").empty();
    $("#Totla_3Star").empty();
    $("#Totla_4Star").empty();
    $("#Totla_5Star").empty();
    var value = document.getElementById('GetIdMuisc' + Id).value;
    $.ajax({
        url: "/ClientListMusic/ViewAllRatingMuiscById/",
        type: "get",
        data: {
            IdMuisc: value
        },
        success: function (result) {
            $.each(result, function (key, item) {
                var html = "";
                switch (item.defaultStart) {
                    case 1:
                        if (item.l_Ratings.length == 0) {
                            html += 'Không có đánh giá 1 sao';
                        } else {
                            $.each(item.l_Ratings, function (key, item) {
                                html += '<p>';
                                html += '<i style="font-weight: 600;">' + item.nameUser + '</i> -';
                                html += '<b style="color: black;">';
                                html += '<i class="fas fa-star"></i>';
                                html += '</b>';
                                html += '<i style="margin-left: 40px; color: #7b7575;">';
                                html += 'Ngày: ' + item.str_DateCreate + '';
                                html += '</i>';
                                html += '</p>';
                            })
                        }
                        $("#Body_1Start").append(html);
                        $("#Totla_1Star").append(item.l_Ratings.length);
                        break;
                    case 2:
                        if (item.l_Ratings.length == 0) {
                            html += 'Không có đánh giá 2 sao';
                        } else {
                            $.each(item.l_Ratings, function (key, item) {
                                html += '<p>';
                                html += '<i style="font-weight: 600;">' + item.nameUser + '</i> -';
                                html += '<b style="color: red;">';
                                html += '<i class="fas fa-star"></i>';
                                html += '<i class="fas fa-star"></i>';
                                html += '</b>';
                                html += '<i style="margin-left: 40px; color: #7b7575;">';
                                html += 'Ngày: ' + item.str_DateCreate + '';
                                html += '</i>';
                                html += '</p>';
                            })
                        }
                        $("#Body_2Start").append(html);
                        $("#Totla_2Star").append(item.l_Ratings.length);
                        break;
                    case 3:
                        if (item.l_Ratings.length == 0) {
                            html += 'Không có đánh giá 3 sao';
                        } else {
                            $.each(item.l_Ratings, function (key, item) {
                                html += '<p>';
                                html += '<i style="font-weight: 600;">' + item.nameUser + '</i> -';
                                html += '<b style="color: #00a6ff;">';
                                html += '<i class="fas fa-star"></i>';
                                html += '<i class="fas fa-star"></i>';
                                html += '<i class="fas fa-star"></i>';
                                html += '</b>';
                                html += '<i style="margin-left: 40px; color: #7b7575;">';
                                html += 'Ngày: ' + item.str_DateCreate + '';
                                html += '</i>';
                                html += '</p>';
                            })
                        }                     
                        $("#Body_3Start").append(html);
                        $("#Totla_3Star").append(item.l_Ratings.length);
                        break;
                    case 4:
                        if (item.l_Ratings.length == 0) {
                            html += 'Không có đánh giá 4 sao';
                        } else {
                            $.each(item.l_Ratings, function (key, item) {
                                html += '<p>';
                                html += '<i style="font-weight: 600;">' + item.nameUser + '</i> -';
                                html += '<b style="color: green;">';
                                html += '<i class="fas fa-star"></i>';
                                html += '<i class="fas fa-star"></i>';
                                html += '<i class="fas fa-star"></i>';
                                html += '<i class="fas fa-star"></i>';
                                html += '</b>';
                                html += '<i style="margin-left: 40px; color: #7b7575;">';
                                html += 'Ngày: ' + item.str_DateCreate + '';
                                html += '</i>';
                                html += '</p>';
                            })
                        }
                        $("#Body_4Start").append(html);
                        $("#Totla_4Star").append(item.l_Ratings.length);
                        break;
                    case 5:
                        if (item.l_Ratings.length == 0) {
                            html += 'Không có đánh giá 5 sao';
                        } else {
                            $.each(item.l_Ratings, function (key, item) {
                                html += '<p>';
                                html += '<i style="font-weight: 600;">' + item.nameUser + '</i> -';
                                html += '<b style="color: orange;">';
                                html += '<i class="fas fa-star"></i>';
                                html += '<i class="fas fa-star"></i>';
                                html += '<i class="fas fa-star"></i>';
                                html += '<i class="fas fa-star"></i>';
                                html += '</b>';
                                html += '<i style="margin-left: 40px; color: #7b7575;">';
                                html += 'Ngày: ' + item.str_DateCreate + '';
                                html += '</i>';
                                html += '</p>';
                            })
                        }
                        $("#Body_5Start").append(html);
                        $("#Totla_5Star").append(item.l_Ratings.length);
                        break;
                }
            })
            $("#modalViewRating").show();
        }
    })
}

$("#colse_Rating").click(function () {
    $("#modalViewRating").hide();
})

//qr code
function QRcoreData(Id) {
    var value = document.getElementById('GetIdMuisc' + Id).value;
    $("#BodyShowImgQR").empty();
    $.ajax({
        url: "/ClientListMusic/CreateQRcoreMuisc",
        type: "get",
        data: {
            IdMuisc: value
        },
        success: function (result) {
            var htmlDefault = '<img src="' + result + '" class="img-fluid" alt="QRCODE">'
            $("#BodyShowImgQR").append(htmlDefault);
            $("#modal_QRCode").show();
        }
    })
}
$("#colse_QRcode").click(function () {
    $("#modal_QRCode").hide();
})

//select viewer music
$("#SelectViewer").change(function () {
    var Value = $("#SelectViewer").val();
    SelectViewer = Value;
    LoadDataMusic();
});

//load data season
function LoadSeasonMuisc() {
    $("#SelectSeason").empty();
    $.ajax({
        url: "/ClientListMusic/GetAllSeasonMusic",
        type: "get",
        success: function (result) {
            var HtmlDefaul = '<option selected value="0">' + Choose_the_Season_You_Need + ' ...</option>';
            $("#SelectSeason").append(HtmlDefaul);
            $.each(result, function (key, item) {
                var html = "";
                html += '<option value="' + item.id + '">' + item.name + '</option>';
                $("#SelectSeason").append(html);
            })
        }
    })
}

//select season muisc
$("#SelectSeason").change(function () {
    var Value = $("#SelectSeason").val();
    SelectSeason = Value;
    LoadDataMusic();
    LoadSaintMuisc(Value);
});
//load data saint
function LoadSaintMuisc(Id) {
    $("#SelectSaint").empty();
    $.ajax({
        url: "/ClientListMusic/GetAllSaintMuisc",
        type: "get",
        data: {
            TypeValue : Id
        },
        success: function (result) {
            var HtmlDefaul = '<option selected value="0">' + Select_saint + ' ...</option>';
            $("#SelectSaint").append(HtmlDefaul);
            $.each(result, function (key, item) {
                var html = "";
                html += '<option value="' + item.id + '">' + item.name + '</option>';
                $("#SelectSaint").append(html);
            });
            if (SelectSeason == 0 || SelectSeason != 6) {
                document.getElementById("SelectSaint").style.display = "none";
            } else {
                document.getElementById("SelectSaint").style.display = "block";
            }
        }
    })
}

$("#SelectSaint").change(function () {
    var Value = $("#SelectSaint").val();
    SelectSaint = Value;
    LoadDataMusic();
})

$("#btn_Reload").click(function () {
    window.location.reload();
});

//muisc yesterday
function LoadMuiscYesterday() {
    $("#TotalMusicYesterday").empty();
    var html = '<i class="fas fa-microphone"></i>';
    $.ajax({
        url: "/ClientListMusic/TotalMuiscYesterday",
        type: "get",
        success: function (result) {
            $("#TotalMusicYesterday").append(html + " " + result);
        }
    })
}

//Seach muisc client
function SeachMuiscClien() {
    SelectSeason = 0;
    SelectSaint = 0;
    var Seach_V = $("#TxtSeach").val();
    $("#TxtTitleSeach").empty();
    if (Seach_V.length == 0) {
        SeachMusic = null;
    } else {
        SeachMusic = Seach_V;
    }
    LoadDataMusic()
}