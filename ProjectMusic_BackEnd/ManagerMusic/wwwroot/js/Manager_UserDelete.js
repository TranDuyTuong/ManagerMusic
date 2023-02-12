
//loading data
$(document).ready(function(){
	document.getElementById('SeachMusic-Admin').style.display = 'none';
});


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
     	alert("vui lòng chọn một trường để tiến hành xóa người dùng!");
     	return;
     }else{
     	$("#modal-ShowChooseActiverFile").show();
     	console.log(myArrayActiver);
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

//---------------------------------------------------
//funtion an block user
$("#btn_anlock").click(function(){
	$("#modal_ShowAnblock").show();
}) 
$("#btn_closeAnBlock").click(function(){
	$("#modal_ShowAnblock").hide();
})
