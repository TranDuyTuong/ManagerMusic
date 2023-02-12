//value
var setDataCheck;
var setDataCheckActiver;



//loading data
$(document).ready(function(){
	$("#modal-ShowChooseOption").hide();
	$("#modal-ShowChooseActiverFile").hide();
	document.getElementById('SeachMusic-Admin').style.display = 'none';
	document.getElementById('Modal-ShowSelectSumer').style.display = 'none';
});

// show choose option data
$("#btn-ShowChooseOption").click(function(){
	$("#modal-ShowChooseOption").show();
});
$("#btn-closeChooseOption").click(function(){
	$("#modal-ShowChooseOption").hide();
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
//funtion close Anactiver file
$("#btn-AnactiverFile").click(function(){
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

//funtion remove checkbox
$("#btn-RemoveCheckBox").click(function(){
	var myArray = new Array();
    var checkbox = document.getElementsByName('case');
     for (var i = 0; i < checkbox.length; i++){
         if (checkbox[i].checked === true){
         		var partNumber = Number(checkbox[i].value);
                myArray.push(partNumber);
         }
     }
     if (myArray.length == 0) {
     	alert("vui lòng chọn một trường để xóa dữ liệu!");
     	return;
     }else{
     	console.log(myArray);
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