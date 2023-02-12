$(document).ready(function(){
	$("#Modal-ShowSelectSumer").hide();
	$("#modal-ShowChooseOption").hide();
});

//-----------------------------------
//click show modal select
$("#btn-ShowModalSelect").click(function(){
	$("#Modal-ShowSelectSumer").show();
});
//close modal select
$("#btn-closeModalSelect").click(function(){
	$("#Modal-ShowSelectSumer").hide();
});

//-----------------------------------------
//show modal choose option
$("#btn-ShowChooseOption").click(function(){
	$("#modal-ShowChooseOption").show();
});
//close modal choose option
$("#btn-closeChooseOption").click(function(){
	$("#modal-ShowChooseOption").hide();
});