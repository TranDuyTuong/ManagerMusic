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

//---------------------------------------------------------------------------
//show modal activer file
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
     	alert("vui lòng chọn một trường để tiến hành kích hoạt dữ liệu!");
     	return;
     }else{
     	$("#modal-ShowChooseActiverFile").show();
     	console.log(myArrayActiver);
     	return;
     }
});
$("#btn-closeactiver").click(function(){
	$("#modal-ShowChooseActiverFile").hide();
});

//-----------------------------------------------------------------------
//show modal list music buy season
$("#btn-ShowModalListMusic").click(function(){
	$("#modal-ShowListMusicBuySeason").show();
});
//close modal show list music buy season
$("#btn-closemodalSeason").click(function(){
	$("#modal-ShowListMusicBuySeason").hide();
});