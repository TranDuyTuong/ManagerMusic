
let myarray = ["A", "B", "C", "D", "E", "F"]
myarray.splice(1, 2, "Z");
console.log(myarray);


$(document).ready(function(){

})

//qr core
$("#btn_QRcode").click(function(){
	$("#modal_QRCode").show();
})
$("#colse_QRcode").click(function(){
	$("#modal_QRCode").hide();
})

//comment
$("#btn_Comment").click(function(){
	$("#modal_Comment").show();
})
$("#colse_Comment").click(function(){
	$("#modal_Comment").hide();
})

//rating
$("#btn_rating").click(function(){
	$("#modal_Rating").show();
})
$("#colse_Rating").click(function(){
	$("#modal_Rating").hide();
})
//link
$("#btn_link").click(function(){
	$("#modal_link").show();
})
$("#colse_link").click(function(){
	$("#modal_link").hide();
})