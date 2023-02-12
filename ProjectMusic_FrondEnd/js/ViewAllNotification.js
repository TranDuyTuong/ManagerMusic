//show modal activer file
$("#btn_remove").click(function(){
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
     	$("#modal_Loading").show();
     	console.log(myArrayActiver);
     	return;
     }
});

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