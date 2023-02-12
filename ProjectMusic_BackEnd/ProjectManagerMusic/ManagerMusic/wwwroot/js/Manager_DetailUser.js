var head = $("#head").val();
var next = $("#next").val();
var last = $("#last").val();
var Before = $("#Before").val();

$(document).ready(function () {
    $("#Modal_ShowAnswer").hide();
    $("#Modal_ShowTimeWorkuser").hide();
    $("#Modal_LockAccountUser").hide();
    $("#Modal_AnLockAccountUser").hide();
    $("#Modal_RemoveUser").hide();
    LoadDataUser();
    LoadRatingByIdUser();
    LoadCommentByIdUser();
    LoadDowloadMuisc();
});

//load data
function LoadDataUser() {
    $("#TxtIdNameUser").empty();
    $.ajax({
        url: "/User/JsonDetailUser",
        type: "get",
        data: {
            IdUser: $("#IdUser").val()
        },
        success: function (result) {
            $("#TxtIdNameUser").append(result.idUser + " - " + result.fullName)
            $("#TxtNameUser").val(result.fullName);
            $("#TxtBirthdays").val(result.str_Birthday);
            $("#TxtAge").val(result.age);
            $("#TxtEmail").val(result.email);
            $("#TxtGender").val(result.nameGender);
            $("#TxtRegiterDate").val(result.str_DateCreate);
            $("#TxtLever").val(result.nameLever);
            if (result.idAccountActiver == 1) {
                $("#TxtStatus").val("Hoạt Động");
            } else {
                $("#TxtStatus").val("Ngưng Hoạt Động");
            }
            $("#TxtTimeOnline").val(result.timeOnline + " Tiếng");
            if (result.str_DateUpdate != "") {
                $("#TxtUpdateInfo").val(result.str_DateUpdate);
            } else {
                $("#TxtUpdateInfo").val("Chưa Cập Nhật Lần Nào");
            }
            
        }
    })
}
//---------------------------------------------------
//funbtion answer
$("#btn_Answer").click(function () {
    $("#Modal_ShowAnswer").show();
});
$("#btn_CloseAnswer").click(function () {
    $("#Modal_ShowAnswer").hide();
});

//-----------------------------------------------
//futnion request
$("#btn_Request").click(function () {
    $("#Modal_ShowRequest").show();
});
$("#btn_CloseRequest").click(function () {
    $("#Modal_ShowRequest").hide();
});

//--------------------------------------------
//funtion modal work time user
$("#btn-ShowModalTimeWork").click(function () {
    LoadListTimeWoking();
    $("#Modal_ShowTimeWorkuser").show();
});
var PageIndex = 1;
var PageSize = 10;
function LoadListTimeWoking() {
    $("#Body_TimeWorking").empty();
    $("#TotalLogin").empty();
    $("#ItemInPage").empty();
    $("#TotalItem").empty();
    var count = 0;
    $.ajax({
        url: "/User/JsonGetTimeWorkingUser",
        type: "get",
        data: {
            Page: PageIndex,
            Size: PageSize,
            IdUser: $("#IdUser").val()
        },
        success: function (result) {
            $.each(result.l_WorkingTime, function (key, item) {
                count++;
                var html = "";
                html += '<tr id="' + item.iduser + '">';
                html += '<th scope="row">' + count + '</th>';
                html += '<th>' + item.dateLogin + '</th>';
                html += '<td>' + item.str_TimeLogin + '</td>';
                if (item.str_TimeOut == "00:00:00") {
                    html += '<td style="color: red; font-weight: 600;">' + 'Người Dùng Đóng Trình Duyệt Mà Không Thoát' + '</td>';
                } else {
                    html += '<td>' + item.str_TimeOut + '</td>';
                }
                html += '<td>' + item.totalWork + '</td>';
                html += '</tr>';
                $("#Body_TimeWorking").append(html);
            })
            $("#ItemInPage").append(count);
            $("#TotalItem").append(PageIndex);
            $("#TotalLogin").append(result.totalTimeWoking);
            //paing
            paging(result.totalTimeWoking, function () {
                LoadListTimeWoking();
            })
        }
    })
}
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

$("#btn_CloseWorkTime").click(function () {
    $("#Modal_ShowTimeWorkuser").hide();
    window.location.reload();
})

//--------------------------------------------
//funtion modal block account user
$("#btn-ShowModalLockAccount").click(function () {
    $("#Modal_LockAccountUser").show();
});
$("#btn_CloseOptionLock").click(function () {
    $("#Modal_LockAccountUser").hide();
})
$("#btn_AgrrenLock").click(function () {
    //logic code ..
    $("#modal_LoadingSignUp").show();
    $("#Modal_LockAccountUser").hide();
});
$("#btn_CancelLock").click(function () {
    $("#Modal_LockAccountUser").hide();
});

//---------------------------------------
//funtion modal an block account user
$("#btn-ShowModalAnLockAccount").click(function () {
    $("#Modal_AnLockAccountUser").show();
});
$("#btn_CloseOptionAnLock").click(function () {
    $("#Modal_AnLockAccountUser").hide();
});
$("#btn_AgrrenAnLock").click(function () {
    //logic code...
    $("#modal_LoadingSignUp").show();
    $("#Modal_AnLockAccountUser").hide();
});
$("#btn_CancelAnLock").click(function () {
    $("#Modal_AnLockAccountUser").hide();
})

//-----------------------------------------
//funtion remove account user
$("#btn-ShowModalRemoveUser").click(function(){
    $("#Modal_RemoveUser").show();
});
$("#btn_CloseOptionRemove").click(function(){
    $("#Modal_RemoveUser").hide();
});
$("#btn_AgrrenRemove").click(function(){
    //logic code...
    $("#modal_LoadingSignUp").show();
    $("#Modal_RemoveUser").hide();
});
$("#btn_CancelRemove").click(function(){
    $("#Modal_RemoveUser").hide();
});

//reset
function ResetPageDetail() {
    window.location.reload();
}

//-----------------------------------------
var PageRating = 1;
var SizeRating = 6;
//load Rating
function LoadRatingByIdUser() {
    $("#BodyRating").empty();
    $("#ItemPageRating").empty();
    $("#TotalItemRating").empty();
    $.ajax({
        url: "/User/JsonGetRatingtUser/",
        type: "get",
        data: {
            Page: PageRating,
            Size: SizeRating,
            IdUser: $("#IdUser").val()
        },
        success: function (result) {
            var count = 0;
            $.each(result.l_Rating, function (key, item) {
                var Html = '';
                count++;
                Html += '<tr>';
                Html += '<th scope="row">' + item.id + '</th>';
                Html += '<td>' + item.nameMuisc + '</td>';
                Html += '<td>' + item.str_DateCreate + '</td>';
                Html += '<td style="color: orange; font-size: 20px; font-weight: 600;">' + item.totalRating + '</td>';
                Html += '</tr>';
                $("#BodyRating").append(Html);
            })
            $("#ItemPageRating").append(count);
            $("#TotalItemRating").append(result.totalRating)
            //paing
            pagingRating(result.totalRating, function () {
                LoadRatingByIdUser();
            })
        }
    })
}
//paing
function pagingRating(totalRoll, callback) {
    var totalPage = Math.ceil(totalRoll / SizeRating);
    $('#paginationRating').twbsPagination({
        totalPages: (totalPage == 0) ? 1 : totalPage,
        first: head,
        next: next,
        last: last,
        prev: Before,
        visiblePages: 10,
        onPageClick: function (event, page) {
            PageRating = page;
            setTimeout(callback, 200);
        }
    });
}

//-----------------------------------------------------------
var PageComment = 1;
var SizeComment = 6;
//loading comment
function LoadCommentByIdUser() {
    $("#BodyComment").empty();
    $("#ItemPageComment").empty();
    $("#TotalItemComment").empty();
    $.ajax({
        url: "/User/JsonGetCommentUser/",
        type: "get",
        data: {
            Page: PageComment,
            Size: SizeComment,
            IdUser: $("#IdUser").val()
        },
        success: function (result) {
            var count = 0;
            $.each(result.l_Comment, function (key, item) {
                count++;
                var html = "";
                html += '<tr>';
                html += '<th scope="row">' + item.id + '</th>';
                html += '<td>' + item.nameMuisc + '</td>';
                html += '<td>' + item.dateCreate + '</td>';
                html += '<td>' + item.comment + '</td>';
                html += '<td>';
                html += '<button id="btn_Answer" type="button" class="btn btn-outline-secondary" data-bs-toggle="tooltip" data-bs-placement="right" title ="Xem Câu Trả Lời" style ="border: none;" >';
                html += '<i class="fas fa-comments"></i>';
                html += '</button>';
                html += '</td>';
                html += '</tr>';
                $("#BodyComment").append(html);
            })
            $("#ItemPageComment").append(count);
            $("#TotalItemComment").append(result.totalComment);
            //paing
            pagingComment(result.totalComment, function () {
                LoadCommentByIdUser();
            })
        }
    })
}
//paing
function pagingComment(totalRoll, callback) {
    var totalPage = Math.ceil(totalRoll / SizeComment);
    $('#paginationComment').twbsPagination({
        totalPages: (totalPage == 0) ? 1 : totalPage,
        first: head,
        next: next,
        last: last,
        prev: Before,
        visiblePages: 10,
        onPageClick: function (event, page) {
            PageComment = page;
            setTimeout(callback, 200);
        }
    });
}

//-----------------------------------------------------
var PageDowload = 1;
var SizeDowload = 6;
//load dowload muisc
function LoadDowloadMuisc() {
    $("#BodyDowload").empty();
    $("#ItemPageDowload").empty();
    $("#TotalItemDowload").empty();
    $.ajax({
        url: "/User/JsonGetDowloadUser/",
        type: "get",
        data: {
            Page: PageDowload,
            Size: SizeDowload,
            IdUser: $("#IdUser").val()
        },
        success: function (result) {
            var count = 0;
            $.each(result.l_DowloadMuisc, function (key, item) {
                var html = "";
                count++;
                html += '<tr>';
                html += '<th scope="row">' + item.id + '</th>';
                html += '<td>' + item.nameMuisc + '</td>';
                html += '<td>' + item.dateDowload + '</td>';
                html += '</tr>';
                $("#BodyDowload").append(html);
            })
            $("#ItemPageDowload").append(count);
            $("#TotalItemDowload").append(result.totalDowload);
            //paing
            pagingDowload(result.totalDowload, function () {
                LoadDowloadMuisc();
            })
        }
    })
}
//paing
function pagingDowload(totalRoll, callback) {
    var totalPage = Math.ceil(totalRoll / SizeDowload);
    $('#paginationDowload').twbsPagination({
        totalPages: (totalPage == 0) ? 1 : totalPage,
        first: head,
        next: next,
        last: last,
        prev: Before,
        visiblePages: 10,
        onPageClick: function (event, page) {
            PageDowload = page;
            setTimeout(callback, 200);
        }
    });
}