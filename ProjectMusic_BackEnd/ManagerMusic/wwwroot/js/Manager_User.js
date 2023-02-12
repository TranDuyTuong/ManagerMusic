var head = $("#head").val();
var next = $("#next").val();
var last = $("#last").val();
var Before = $("#Before").val();

$(document).ready(function(){
	document.getElementById('SeachMusic-Admin').style.display = 'none';
	SortId = true;
	SeachName = null;
	SeachNameUser = null;
	LoadBirthdayUser();
	LoadDataUsers();
	TotalRequestUser();
});

var Page_Index = 1;
var Page_Size = 15;
//load data
function LoadDataUsers() {
	$("#Body_Data").empty();
	$("#TxtTotalUser").empty();
	$("#ItemInPage").empty();
	$("#TotalItem").empty();
	$.ajax({
		url: "/User/GetAllUser",
		type: "get",
		data: {
			PageIndex: Page_Index,
			PageSize: Page_Size,
			SeachKey: SeachNameUser
		},
		success: function (result) {
			var count = 0;
			$.each(result.l_User, function (key, item) {
				count++;
				var html = "";
				html += '<tr id="' + item.idUser + '">'
				html += '<th scope="row">' + count + '</th>'
				html += '<td>' + item.nameUsers + '</td>'
				html += '<td>' + item.str_Birthday + '</td>'
				html += '<td>' + item.str_DateCreate + '</td>'
				html += '<td>' + item.nameStatus + '</td>'
				html += '<td>' + item.age + '</td>'
				html += '<td><a href="/User/Page_DetailUser/?Iduser=' + item.idUser + '" style="background: none; color: black;" class="btn btn-secondary" data-bs-toggle="tooltip" data-bs-placement="right" title="Xem Chi Tiết">'+
				'<i class="fas fa-folder-open"></i>' + '</a ></td>'
				html += '</tr>'
				$("#Body_Data").append(html);
			})
			$("#ItemInPage").append(Page_Index);
			$("#TotalItem").append(count);
			$("#TxtTotalUser").append(result.totalUser);
			//paing
			paging(result.totalUser, function () {
				LoadDataUsers();
			})
        }
    })
}
//paing
function paging(totalRoll, callback) {
	var totalPage = Math.ceil(totalRoll / Page_Size);
	$('#pagination').twbsPagination({
		totalPages: (totalPage == 0) ? 1 : totalPage,
		first: head,
		next: next,
		last: last,
		prev: Before,
		visiblePages: 10,
		onPageClick: function (event, page) {
			Page_Index = page;
			setTimeout(callback, 200);
		}
	});
}

//load birthday user
function LoadBirthdayUser() {
	$("#BirthdayToday").empty();
	$("#Body_DataBirthday").empty();
	$("#TotalBirthday").empty();
	$.ajax({
		url: "/User/GetAllUserBirthday",
		type: "get",
		success: function (result) {
			$("#BirthdayToday").append('( ' + result.length + ' )');
			var count = 0;
			$.each(result, function (key, item) {
				count++;
				var html = "";
				html += '<tr id="' + item.idUser + '">'
				html += '<th scope="row">' + count + '</th>'
				html += '<td>' + item.nameUsers + '</td>'
				html += '<td>' + item.str_Birthday + '</td>'
				html += '<td>' + item.age + '</td>'
				if (item.wasSentBirthday == 1) {
					html += '<td>' + '<i style="color:green" class="fas fa-check"></i>' + '</td>'
				} else {
					html += '<td><button name="SentBirthday" style="border:none; background: none; color: black;" type="button" class="btn btn-secondary" data-bs-toggle="tooltip" data-bs-placement="right" title="Gửi Lời Chúc Mừng">' +
						'<i class="fas fa-plane-departure"></i>' + '</button ></td>'
                }
				html += '</tr>'
				$("#Body_DataBirthday").append(html);
			})
			$("#TotalBirthday").append(result.length);
        }
    })
}

$("#btn_ModalBirthday").click(function () {
	$("#ModalBirthdayUser").show();
})
$("#btn_CloseBirthday").click(function () {
	$("#ModalBirthdayUser").hide();
	window.location.reload();
})

$(document).on('click', 'button[name="SentBirthday"]', function () {
	var IdUser = $(this).closest("tr").attr("id");
	$.ajax({
		url: "/User/GetInfoUserBirthday",
		type: "get",
		data: {
			IdUser: IdUser
		},
		success: function (result) {
			$("#TxtIdUser").val(result.idUser);
			$("#TxtGmails").val(result.gmail);
			$("#TxtNameUser").val(result.fullName)
			$("#ModalSentBirthdayUser").show();
        }
    })
})
$("#btn_CloseSentBirthday").click(function () {
	$("#ModalSentBirthdayUser").hide();
	$("#TxtTitle").val('');
	$("#TxtContent").val('');
	$("#TxtGmails").val('');
	$("#TxtNameUser").val('');
	$("#TxtIdUser").val('');
})

$("#Btn_SentMessageBirthday").click(function () {
	var GetTitle = $("#TxtTitle").val();
	var GetContent = $("#TxtContent").val();
	var GetFile = $("#TxtFile").val();
	$("#ErorrTitle").empty();
	$("#ErorrContent").empty();
	$("#ErorrFile").empty();
	if (GetTitle.length == 0) {
		$("#ErorrTitle").append("Không được bỏ trống!")
		return;
	}
	if (GetContent.length == 0) {
		$("#ErorrContent").append("Không được bỏ trống!")
		return;
	}
	if (GetFile.length == 0) {
		$("#ErorrFile").append("Không được bỏ trống!")
		return;
	}
	var files = $("#TxtFile").prop("files")
	var formData = new FormData();
	for (var i = 0; i < files.length; i++) {
		formData.append("file", files[i]);
	}
	var GetInfoUser = {
		IdUser: $("#TxtIdUser").val(),
		FullName: $("#TxtNameUser").val(),
		Gmail: $("#TxtGmails").val(),
		Title: GetTitle,
		Content: GetContent
	}
	formData.append("GetInfoUserBirthday_V", JSON.stringify(GetInfoUser));
	$("#modal_LoadingCreateMusic").show();
	$.ajax({
		url: "/User/SentBirthday",
		type: "post",
		data: formData,
		contentType: false,
		processData: false,
		success: function (result) {
			$("#modal_LoadingCreateMusic").hide();
			switch (result.idNotification) {
				case 1:
					toastr.success("Gửi lời chúc mừng thành công", "Thông Báo Thành Công!");
					$("#ModalSentBirthdayUser").hide();
					LoadBirthdayUser();
					break;
				case 2:
					toastr.error("Gửi lời chúc mừng thất bại", "Thông Báo Lỗi!")
					break;
				case 3:
					toastr.error("Id người dùng không phù hợp", "Thông Báo Lỗi!")
					break;
			}
			return;
        }
    })
});

var PageIndex = 1;
var PageSize = 8;
//view history sent gmail birthday
$("#btn_HistorySent").click(function () {
	$("#ModalSentMessageBirthday").show();
	LoadDataSentMessageBirthday();
})
$("#btn_CloseSentMessage").click(function () {
	$("#ModalSentMessageBirthday").hide();
})
function LoadDataSentMessageBirthday() {
	$("#Body_SentDataBirthday").empty();
	$("#TotalSentBirthday").empty();
	$("#ItemInPageSent").empty();
	$("#TotalItemSent").empty();
	var count = 0;
	$.ajax({
		url: "/User/GetAllSentMessageBirthday",
		type: "get",
		data: {
			PageIndex: PageIndex,
			PageSize: PageSize,
			SortId: SortId,
			SeachName: SeachName
		},
		success: function (result) {
			$.each(result.l_MessageSent, function (key, item) {
				var html = "";
				count++;
				html += '<tr id="' + item.idUser + '">'
				html += '<th scope="row">' + count + '</th>'
				html += '<td>' + item.nameUser + '</td>'
				html += '<td>' + item.str_Birthday + '</td>'
				html += '<td>' + item.titleSent + '</td>'
				html += '<td>' + item.contentSent + '</td>'
				html += '<td>' + item.str_DateSent + '</td>'
				html += '</tr>'
				$("#Body_SentDataBirthday").append(html);
			})
			$("#TotalItemSent").append(count)
			$("#ItemInPageSent").append(PageIndex);
			$("#TotalSentBirthday").append(result.totalMessage);
			//paing
			pagingSentMessage(result.totalMessage, function () {
				LoadDataSentMessageBirthday();
			})
        }
    })
}
function pagingSentMessage(totalRoll, callback) {
	var totalPage = Math.ceil(totalRoll / PageSize);
	$('#paginationSent').twbsPagination({
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

//sort no
var SortId = true;
$("#SortNo").click(function () {
	if (SortId == true) {
		SortId = false;
	} else {
		SortId = true;
	}
	LoadDataSentMessageBirthday()
})

//seach name user
var SeachName = null;
function seachNameUser() {
	SeachName = $("#TxtSeachName").val();
	LoadDataSentMessageBirthday();
}
//-----------------------------------------------------------------------
//show form seach music
$("#btn-ShowFormSeachMusic").click(function(){
	document.getElementById('SeachMusic-Admin').style.display = 'block';
});
//close form seach music
$("#btn-closeSeachMusic").click(function(){
	document.getElementById('SeachMusic-Admin').style.display = 'none';
});
//seach music
var SeachNameUser = null;
function eventSeachUser() {
	SeachNameUser = $("#TxtInputUser").val();
	LoadDataUsers();
}

//get total request User
function TotalRequestUser() {
	var html = '<i class="far fa-flag"></i>';
	$("#RequestUsers").empty();
	$.ajax({
		url: "/ManagerRequestUser/JsonTotalRequestUser/",
		type: "get",
		success: function (result) {
			$("#RequestUsers").append(html + " " + "(" + result + ")");
			return;
        }
    })
}
