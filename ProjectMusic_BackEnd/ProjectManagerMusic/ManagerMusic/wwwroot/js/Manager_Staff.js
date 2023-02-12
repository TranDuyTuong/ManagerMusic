var PageIndex = 1;
var PageSize = 10;
var NotFindStaff = $("#NotFindStaff").val();
var head = $("#head").val();
var next = $("#next").val();
var last = $("#last").val();
var Before = $("#Before").val();
var Edit_staff = $("#Edit_staff").val();
var Employee_Details = $("#Employee_Details").val();
var Role_Selection = $("#Role_Selection").val();
var Notification_Error = $("#Notification_Error").val();
var select_field = $("#select_field").val();

//loading data
$(document).ready(function () {
	LoadStaff();
	LoadRole();
	document.getElementById('SeachMusic-Admin').style.display = 'none';
	document.getElementById('Modal-ShowSelectSumer').style.display = 'none';
});

//-------------------------------------------------------------------
//funtion load staff
function LoadStaff() {
	$("#Body_Data").empty();
	$("#TxtTotalSatff").empty();
	$("#TileNotification").empty()
	$("#ItemInPage").empty();
	$("#TotalItem").empty();
	var count = 0;
	$.ajax({
		url: "/User/JsonGetAllSatff",
		type: "get",
		data: {
			PageIndex: PageIndex,
			PageSize: PageSize
		},
		success: function (result) {
			if (result == 0) {
				$("#TileNotification").append(NotFindStaff);
			} else {
				$.each(result.l_Staff, function (key, item) {
					count++;
					var html = ""
					html += '<tr>';
					html += ' <th scope="row">';
					html += '<input type="checkbox" class="case" name="case" value="' + item.idUser + '"/>';
					html += ' </th>';
					html += '<td>' + item.idStaff + '</td>';
					html += '<td>' + item.fullName + '</td>';
					html += '<td> ' + item.dateCreate + '</td>';
					if (item.imageStaff != null) {
						switch (item.typeImage) {
							case "JPG":
								html += '<td>' + '<img src="data:image/JPG;base64,' + item.imageStaff + '" style="width: 100px;"/>' + '</td>';
                                break;
							case "jpg":
								html += '<td>' + '<img src="data:image/jpg;base64,' + item.imageStaff + '" style="width: 100px;"/>' + '</td>';
                                break;
							case "JPEG":
								html += '<td>' + '<img src="data:image/JPEG;base64,' + item.imageStaff + '" style="width: 100px;"/>' + '</td>';
                                break;
							case "jpeg":
								html += '<td>' + '<img src="data:image/jpeg;base64,' + item.imageStaff + '" style="width: 100px;"/>' + '</td>';
                                break;
							case "PNG":
								html += '<td>' + '<img src="data:image/PNG;base64,' + item.imageStaff + '" style="width: 100px;"/>' + '</td>';
                                break;
							case "png":
								html += '<td>' + '<img src="data:image/png;base64,' + item.imageStaff + '" style="width: 100px;"/>' + '</td>';
                                break;
							case "GIF":
								html += '<td>' + '<img src="data:image/GIF;base64,' + item.imageStaff + '" style="width: 100px;"/>' + '</td>';
                                break;
							case "gif":
								html += '<td>' + '<img src="data:image/gif;base64,' + item.imageStaff + '" style="width: 100px;"/>' + '</td>';
                                break;
                        }
					}
					html += '<td>' + item.nameRole + '</td>';
					if (item.idAccountActiver == 1) {
						html += '<td style="color: green">' + item.accountActiver + '</td>';
					} else {
						html += '<td style="color: red">' + item.accountActiver + '</td>';
                    }
					html += '<td>';
					html += '<a href="/User/Page_UpdateStaff/?IdUser=' + item.idUser + '" style="border: none;" class="btn btn-outline-secondary" ata-bs-toggle="tooltip" data-bs-placement="top" title="' + Edit_staff + '"><i class="fas fa-user-edit"></i></a>';
					html += '<a href="/User/Page_DetailStaff/?IdUser=' + item.idUser + '" style="border: none;" class="btn btn-outline-secondary" ata-bs-toggle="tooltip" data-bs-placement="top" title="' + Employee_Details + '"><i class="fas fa-folder-open"></i></a>';
					html += '</td>';
					html += '</tr>';
					$("#Body_Data").append(html);
				})
				$("#TotalItem").append(result.totalStaff)
				$("#ItemInPage").append(count)
				//paing
				paging(result.totalStaff, function () {
					LoadStaff();
				})
			}
			$("#TxtTotalSatff").append(result.totalStaff);
			return;
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

//----------------------------------------------------------------------
//funtion load role
function LoadRole() {
	var SelectRole = $("#SelectRole").empty();
	$.ajax({
		url: "/User/JsonGetAllRole",
		type: "get",
		success: function (result) {
			if (result != 0) {
				var htmlDefaul = '<option selected value="0">' + Role_Selection + '</option>';
				SelectRole.append(htmlDefaul);
				$.each(result, function (key, item) {
					var html = "";
					html += '<option value="' + item.idRole + '">' + item.roleName + '</option>';
					SelectRole.append(html);
				});
            }
			return;
        }
    })
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
function eventSeachMusic() {
	var getdata = $("#TxtInputMusic").val();
	console.log(getdata);
}

//---------------------------------------------------------------------------
//show modal activer account
$("#btn-showModalActiverFile").click(function(){
	var checkbox = document.getElementsByName('case');
	var myArrayActiver = new Array();
     for (var i = 0; i < checkbox.length; i++){
         if (checkbox[i].checked === true){
         	var partNumber = Number(checkbox[i].value);
         	myArrayActiver.push(partNumber);
         }
     }
	if (myArrayActiver.length == 0) {
		toastr.error(select_field, Notification_Error);
     	return;
     }else{
     	$("#modal-ShowChooseActiverFile").show();
     	return;
     }
});

//funtion close Anactiver account
$("#btn-closeactiver").click(function(){
	$("#modal-ShowChooseActiverFile").hide();
});


//--------------------------------------------------------------------------
//funtion choose all checkbox option
$("#selectall").click(function () {
	$('.case').attr('checked', this.checked);
});

$(".case").click(function(){
	if($(".case").length == $(".case:checked").length) {
		$("#selectall").attr("checked", "checked");
	} else {
		$("#selectall").removeAttr("checked");
	}

});

//----------------------------------------------------------------
//funtion show html select option seach
$("#btn-ShowModalSelect").click(function(){
	document.getElementById('Modal-ShowSelectSumer').style.display = 'block';
});
$("#btn-closeModalSelect").click(function(){
	document.getElementById('Modal-ShowSelectSumer').style.display = 'none';
});