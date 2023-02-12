
$(document).ready(function(){
	document.getElementById("show-htmlSeachMusicQR").style.display = 'none';
});



//-----------------------------------------------------------------------
//close html seach music QR
$("#btn-closehtmlMusicQR").click(function(){
	document.getElementById("show-htmlSeachMusicQR").style.display = 'none';
});
//show html seach music QR
$("#btn-showModalSeachMusicQR").click(function(){
	document.getElementById("show-htmlSeachMusicQR").style.display = 'block';
});

//----------------------------------------------------------------------
//show modal activer file
$("#btn-showModalCreateQR").click(function(){
	var checkbox = document.getElementsByName('case');
	var myArrayActiver = new Array();
     for (var i = 0; i < checkbox.length; i++){
         if (checkbox[i].checked === true){
         	var partNumber = Number(checkbox[i].value);
         	myArrayActiver.push(partNumber);
         }
     }
     if (myArrayActiver.length == 0) {
     	alert("vui lòng chọn một trường để tiến hành kích hoạt dữ liệu!");
     	return;
     }else{
     	$("#modal-ShowChooseCreateQR").show();
     	console.log(myArrayActiver);
     	return;
     }
});
//close modal create QR core
$("#btn-closeCreateQRCore").click(function(){
	$("#modal-ShowChooseCreateQR").hide();
});

//----------------------------------------------------------------------
//Show modal choose option dowload QR Core Music
$("#btn-ShowChooseOption").click(function(){
	$("#modal-ShowChooseOption").show();
});
//close modal option dowload QR Core
$("#btn-closeChooseOption").click(function(){
	$("#modal-ShowChooseOption").hide();
});

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