
//--------------------------------------------------------------------
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

//-----------------------------------------------------------------
//funtion remove all file music was delete
$("#btn-RemoveAllFileMusic").click(function(){
	var checkbox = document.getElementsByName('case');
	var MyArray = new Array();
	for (var i = 0; i < checkbox.length; i++) {
		if (checkbox[i].checked == true) {
			var PartNumber = Number(checkbox[i].value);
			MyArray.push(PartNumber);
		}
	}
	if(MyArray.length == 0){
		alert("Vui Lòng Chọn Vào Bài Hát Muốn Xóa!");
		return;
	}else{
		$("#modal-ShowChooseRemoveAllFileMusic").show();
		console.log(MyArray);
		return;
	}
});

//funtion close remove all file music was delete
$("#btn-RemoveAllMusic").click(function(){
	$("#modal-ShowChooseRemoveAllFileMusic").hide();
});

//-------------------------------------------------------------------
//funtion take again all file music was delete
$("#btn-showModalTakeAllMusic").click(function(){
	var MyArrayTakeAgain = new Array();
	var checkbox = document.getElementsByName('case');
	for (var i = 0; i < checkbox.length; i++) {
		if (checkbox[i].checked == true) {
			var PartNumber = Number(checkbox[i].value);
			MyArrayTakeAgain.push(PartNumber);
		}
	}
	if(MyArrayTakeAgain.length == 0){
		alert("Vui Lòng Chọn Vào Bài Hát Muốn Lấy Lại!");
		return;
	}else{
		$("#modal-ShowChooseTakeAgainAllFileMusic").show();
		console.log(MyArrayTakeAgain);
		return;
	}
});

//funtion cancel Take Again All File music was delete
$("#btn-TakeAgainAllMusic").click(function(){
	$("#modal-ShowChooseTakeAgainAllFileMusic").hide();
});

//-------------------------------------------------------------------
//funtion show option choose remove file music
$("#btn-ShowChooseOption").click(function(){
	$("#modal-ShowChooseOption").show();
});
//funtion close option choose remove file music
$("#btn-closeChooseOption").click(function(){
	$("#modal-ShowChooseOption").hide();
});