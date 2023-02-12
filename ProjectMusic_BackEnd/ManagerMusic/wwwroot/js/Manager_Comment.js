
//loading data
$(document).ready(function(){

});


//---------------------------------------------------------------------------
//show modal activer file
$("#btn-ActiverRemoveComment").click(function(){
	var checkbox = document.getElementsByName('case');
	var myArrayActiver = new Array();
     for (var i = 0; i < checkbox.length; i++){
         if (checkbox[i].checked === true){
         	var partNumber = Number(checkbox[i].value);
         	myArrayActiver.push(partNumber);
         }
     }
     if (myArrayActiver.length == 0) {
     	alert("vui lòng chọn một trường để tiến hành xóa bình luận!");
     	return;
     }else{
     	$("#modal-ShowChooseActiverFile").show();
     	console.log(myArrayActiver);
     	return;
     }
});
//funtion close Anactiver file
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

//-------------------------------------------------------------
//funtion show choose option modal
$("#btn-ShowChooseOption").click(function(){
	$("#modal-ShowChooseOption").show();
});
//funtion close choose option modal
$("#btn-closeChooseOption").click(function(){
	$("#modal-ShowChooseOption").hide();
});


//---------------------------------------------------------
//funtion close modal Answer Commet
$("#btn-closemodalAnswerComment").click(function(){
	$("#modal-ShowAnswerComment").hide();
});
//funtion show modal Answer Comment
$("#btn-showModalViewAnswerComment").click(function(){
	$("#modal-ShowAnswerComment").show();
});