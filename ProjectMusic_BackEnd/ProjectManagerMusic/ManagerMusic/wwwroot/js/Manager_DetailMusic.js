var PageSize_Comment = 10;
var PageIndex_Comment = 1;

var PageSize_Rating = 10;
var PageIndex_Rating = 1;

var IdMusic = $("#IdMusic").val();
var NotFindInfothis_Music = $("#NotFindInfothis_Music").val();
var SaveImageMusic;
var TypeImageMusic;
var ChooseStatusMusic = $("#ChooseStatusMusic").val();
var Selectstatus_youwantchange = $("#Selectstatus_youwantchange").val();
var select_status = $("#select_status").val();
var htmlcheck = '<i class="fas fa-check"></i>';
var Notification_Error = $("#Notification_Error").val();
var Nofitication_Success = $("#Nofitication_Success").val();
var Employeeid_empty = $("#Employeeid_empty").val();
var NotFindSong = $("#NotFindSong").val();
var Staffnot_found = $("#Staffnot_found").val();
var Changesongstatus_successfully = $("#Changesongstatus_successfully").val();
var Changesongstatus_error = $("#Changesongstatus_error").val();
var IdMmusicNull = $("#IdMmusicNull").val();
var DeleteSuccess = $("#DeleteSuccess").val();
var DeleteErorr = $("#DeleteErorr").val();
var Songdownload_failed = $("#Songdownload_failed").val();
var DowloadMusic_Success = $("#DowloadMusic_Success").val();
var Related_Comment = $("#Related_Comment").val();

var head = $("#head").val();
var next = $("#next").val();
var last = $("#last").val();
var Before = $("#Before").val();

$(document).ready(function () {
    LoadDetailMusic();
    LoadCommentByIdMuisc();
    LoadRatingByIdMuisc();
});

//----------------------------------------
//load detail music
function LoadDetailMusic() {
    $("#Txt_EnterDateCreateMusic").empty();
    $("#Txt_EnterLike").empty();
    $("#Txt_EnterDowload").empty();
    $("#Txt_EnterUser").empty();
    $("#Txt_TimeCreate").empty();
    $("#Txt_EnterQRCore").empty();
    $("#Txt_EnterNameMusic").empty();
    $("#Txt_EnterNameAuthor").empty();
    $("#Txt_EnterNameSeason").empty();
    $("#Txt_EnterNameSaint").empty();
    $("#Txt_EnterNameStatus").empty();
    $("#Txt_EnterIdMusic").empty();
    $("#TxtNameFile").empty();
    $("#TitleNotification").empty();
    $("#Txt_EnterIdUser").empty();
    $("#Txt_EnterNameRole").empty();
    $("#FileFormName").empty();
    $.ajax({
        url: "/ManagerData/JsonDetailMusic",
        type: "post",
        data: {
            IdMusic: IdMusic
        },
        success: function (result) {
            if (result == 0) {
                $("#TitleNotification").append(NotFindInfothis_Music);
            } else {
                $("#TxtGuidIdMusic").val(result.idMusic);
                $("#Txt_EnterDateCreateMusic").val(result.dateCreate);
                $("#Txt_EnterLike").val(result.likeMusic);
                $("#Txt_EnterDowload").val(result.numberDowload);
                $("#Txt_EnterUser").val(result.nameStaff);
                $("#Txt_TimeCreate").val(result.timeCreate);
                $("#Txt_EnterQRCore").val(result.numberQR);
                $("#Txt_EnterNameMusic").val(result.nameMusic);
                $("#Txt_EnterNameAuthor").val(result.author);
                $("#Txt_EnterNameSeason").val(result.nameSeason);
                $("#Txt_EnterNameSaint").val(result.nameSaint);
                $("#Txt_EnterNameStatus").val(result.nameStatus);
                $("#Txt_EnterIdMusic").val(result.noMusic);
                $("#Txt_EnterIdUser").val(result.idStaff);
                $("#Txt_EnterNameRole").val(result.nameRole);
                $("#TxtNameFile").append(result.nameFile);
                SaveImageMusic = result.imageMusic;
                TypeImageMusic = result.typeImage;

            }
            return;
        }
    })
}

//------------------------------------------------
//load comment music by id 
function LoadCommentByIdMuisc() {
    $("#BodyComment").empty();
    $("#TotalComment").empty();
    $("#ItemInPage").empty();
    $("#TotalItem").empty();
    var count = 0;
    $.ajax({
        url: "/ManagerData/JsonGetCommentByIdMusic",
        type: "post",
        data: {
            IdMusic: IdMusic,
            PageSize: PageSize_Comment,
            PageIndex: PageIndex_Comment
        },
        success: function (result) {
            if (result == 0) {
                $("#TotalComment").append(count);
            } else {
                $.each(result.l_Comments, function (key, item) {
                    count++;
                    var html = "";
                    html += '<tr id="' + item.id + '">';
                    html += '<th scope="row">' + item.id + '</th>';
                    html += '<td>' + item.nameUser + '</td>';
                    html += '<td>' + item.nameRole + '</td>';
                    html += '<td>' + item.comment + '</td>';
                    html += '<td>' + item.dateCreate + '</td>';
                    html += '<td>' + item.timeCreate + '</td>';
                    html += '<td>' + '<button data-bs-toggle="tooltip" data-bs-placement="right" data-bs-title="' + Related_Comment + '" style="border-radius: 5px;" class="btn btn-outline-secondary"><i class="fas fa-comments"></i></button>' + '</td>';
                    html += '</tr>';
                    $("#BodyComment").append(html);
                })
                $("#ItemInPage").append(count);
                $("#TotalItem").append(result.totalComment);
                $("#TotalComment").append(result.totalComment);
                //paing
                pagingComment(result.totalComment, function () {
                    LoadCommentByIdMuisc();
                })
            }
            return;
        }
    })
}

//----------------------------------------------
//paing comment
function pagingComment(totalRoll, callback) {
    var totalPage = Math.ceil(totalRoll / PageSize_Comment);
    $('#paginationComment').twbsPagination({
        totalPages: (totalPage == 0) ? 1 : totalPage,
        first: head,
        next: next,
        last: last,
        prev: Before,
        visiblePages: 10,
        onPageClick: function (event, page) {
            PageIndex_Comment = page;
            setTimeout(callback, 200);
        }
    });
}

//------------------------------------------------
//load rating music by id 
function LoadRatingByIdMuisc() {
    $("#bodyRatings").empty();
    $("#TotalRating").empty();
    $("#ItemInPageRating").empty();
    $("#TotalItemRating").empty();
    var count = 0;
    $.ajax({
        url: "/ManagerData/JsonGetRatingByIdMusic",
        type: "post",
        data: {
            IdMusic: IdMusic,
            PageSize: PageSize_Rating,
            PageIndex: PageIndex_Rating
        },
        success: function (result) {
            if (result == 0) {
                $("#TotalRating").append(count);
            } else {
                $.each(result.l_Ratings, function (key, item) {
                    count++;
                    var html = "";
                    html += '<tr id="' + item.id + '">';
                    html += '<th scope="row">' + item.id + '</th>';
                    html += '<td>' + item.rating + '</td>';
                    html += '<td>' + item.nameUser + '</td>';
                    html += '<td>' + item.nameRole + '</td>';
                    html += '<td>' + item.dateCreate + '</td>';
                    html += '<td>' + item.timeCreate + '</td>';
                    html += '</tr>';
                    $("#bodyRatings").append(html);
                })
                $("#ItemInPageRating").append(count);
                $("#TotalItemRating").append(result.totalRatings);
                $("#TotalRating").append(result.totalRatings);
                //paing
                pagingRating(result.totalRatings, function () {
                    LoadRatingByIdMuisc();
                })
            }
            return;
        }
    })
}

//----------------------------------------------
//paing rating
function pagingRating(totalRoll, callback) {
    var totalPage = Math.ceil(totalRoll / PageSize_Rating);
    $('#paginationRating').twbsPagination({
        totalPages: (totalPage == 0) ? 1 : totalPage,
        first: head,
        next: next,
        last: last,
        prev: Before,
        visiblePages: 10,
        onPageClick: function (event, page) {
            PageIndex_Rating = page;
            setTimeout(callback, 200);
        }
    });
}


//------------------------------------------------
//read content file .doc
$("#btn_readcontentfile").click(function () {
    //If Document not NULL, render it.
    if (SaveImageMusic != null) {
        var SetImage;
        switch (TypeImageMusic) {
            case "jpg":
                SetImage = '<img src="data:image/jpg;base64,' + SaveImageMusic + '" style="width: auto; height: auto; margin-left: 10%;"/>';
                break;
            case "png":
                SetImage = '<img src="data:image/png;base64,' + SaveImageMusic + '" style="width: auto; height: auto; margin-left: 10%;"/>';
                break;
            case "PNG":
                SetImage = '<img src="data:image/PNG;base64,' + SaveImageMusic + '" style="width: auto; height: auto; margin-left: 10%;"/>';
                break;
            case "JPG":
                SetImage = '<img src="data:image/JPG;base64,' + SaveImageMusic + '" style="width: auto; height: auto; margin-left: 10%;"/>';
                break;
        }       
        $("#ImageMusicBody").empty();
        $("#ImageMusicBody").append(SetImage)
    }
    $("#modal-ShowContentFileDox").show();
});
$("#btn-closecontentfile").click(function () {
    $("#modal-ShowContentFileDox").hide();
});

//------------------------------------------------
//change status music
$("#F_ChangeStatusMuisc").click(function () {
    $("#emailHelp").empty();
    $("#emailHelp").append(Selectstatus_youwantchange);
    $.ajax({
        url: "/ManagerData/GetAllStatusMusic",
        type: "get",
        success: function (result) {
            $("#SelectStatus").empty();
            var htmlDefault = '<option selected value="0">' + ChooseStatusMusic + '</option>';
            $("#SelectStatus").append(htmlDefault);
            $.each(result, function (key, item) {
                var html = "";
                html += '<option value="' + item.idStatusMusic + '">' + item.name + '</option>';
                $("#SelectStatus").append(html);
            });
            $("#modal_ShowChangeStatusMusic").show();
            return;
        }
    })
});
$("#btn_closestatusmusic").click(function () {
    $("#modal_ShowChangeStatusMusic").hide();
    return;
});

$("#SelectStatus").change(function () {
    $("#emailHelp").empty();
    var GetVAL = $("#SelectStatus").val();
    if (GetVAL == 0) {       
        $("#emailHelp").append(select_status);
    } else {
        $("#successCheck").empty();
        $("#successCheck").append(htmlcheck);
    }
    return;
});

$("#btn_changeStatus").click(function () {
    $("#emailHelp").empty();
    var GetVAL = $("#SelectStatus").val();
    if (GetVAL == 0) {
        $("#successCheck").empty();
        $("#emailHelp").append(select_status);
        return;
    }
    $.ajax({
        url: "/ManagerData/ChangeStatusMusic",
        type: "post",
        data: {
            IdStatus: GetVAL,
            IdMusic: IdMusic
        },
        success: function (result) {
                switch (result.isStatus) {
                    case 5:
                        toastr.error(Employeeid_empty, Notification_Error);
                        break;
                    case 1:
                        toastr.error(NotFindSong, Notification_Error);
                        break;
                    case 2:
                        toastr.error(Staffnot_found, Notification_Error);
                        break;
                    case 3:
                        toastr.success(Changesongstatus_successfully, Nofitication_Success)
                        location.reload();
                        break;
                    case 4:
                        toastr.error(Changesongstatus_error, Nofitication_Success)
                        break;
            }
            $("#modal_ShowChangeStatusMusic").hide();
            return;
            
        }
    })
});

//----------------------------------------------------
//delete music
$("#F_DeleteMusic").click(function () {
    $("#modal_ShowDeleteMusic").show();
});

$("#btn_closeDelete").click(function () {
    $("#modal_ShowDeleteMusic").hide();
});

$("#agree_Delete").click(function () {
    $.ajax({
        url: "/ManagerData/DeleteMusic",
        type: "post",
        data: {
            IdMusic: IdMusic
        },
        success: function (result) {
            switch (result.isStatus) {
                case 6:
                    toastr.error(IdMmusicNull, Notification_Error);
                    break;
                case 5:
                    toastr.error(Employeeid_empty, Notification_Error);
                    break;
                case 1:
                    toastr.error(NotFindSong, Notification_Error);
                    break;
                case 2:
                    toastr.error(Staffnot_found, Notification_Error);
                    break;
                case 3:
                    toastr.success(DeleteSuccess, Nofitication_Success)
                    location.reload();
                    break;
                case 4:
                    toastr.error(DeleteErorr, Nofitication_Success)
                    break;
            }
            $("#modal_ShowDeleteMusic").hide();
            return;
        }
    })
});

$("#cancel_Delete").click(function () {
    $("#modal_ShowDeleteMusic").hide();
});

//----------------------------------
//dowload music
$("#F_DowloadMusic").click(function () {
    $.ajax({
        url: "/ManagerData/DowloadMusicStaff",
        type: "post",
        data: {
            IdMusic: IdMusic
        },
        success: function (result) {
            switch (result.isStatus) {
                case 6:
                    toastr.error(IdMmusicNull, Notification_Error);
                    break;
                case 5:
                    toastr.error(Employeeid_empty, Notification_Error);
                    break;
                case 1:
                    toastr.error(NotFindSong, Notification_Error);
                    break;
                case 2:
                    toastr.error(Staffnot_found, Notification_Error);
                    break;
                case 3:
                    toastr.success(DowloadMusic_Success, Nofitication_Success)
                    LoadDetailMusic();
                    window.location = window.location.origin + '/ManagerData/FileDowload';                   
                    break;
                case 4:
                    toastr.error(Songdownload_failed, Nofitication_Success)
                    break;
            }           
            return;
        }
    })
});
