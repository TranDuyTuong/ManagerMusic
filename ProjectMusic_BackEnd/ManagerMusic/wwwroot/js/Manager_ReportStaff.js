var Apply = $("#Apply").val();
var Cancel = $("#cancel").val();
$(document).ready(function(){
    $(".applyBtn").empty();
    $(".cancelBtn").empty();
    $(".applyBtn").append(Apply);
    $(".cancelBtn").append(Cancel);

});
//--------------------------------
//Season
$("#btn_ShowModalSeason").click(function(){
    $("#ModalSeasonView").show();
});
$("#btn_closeSeason").click(function(){
    $("#ModalSeasonView").hide();
});

//-------------------------------
//select saints
$("#btn_ShowModalsaints").click(function(){
    $("#ModalsaintsView").show();
});
$("#btn_closesaints").click(function(){
    $("#ModalsaintsView").hide();
})

//----------------------------
//select date
$('input[name="daterange"]').daterangepicker({
    opens: 'left'
  });
$("#btn_ShowModalDate").click(function(){
    $("#Modal_ShowFuilterDate").show();
})
$("#btn_CLoseFuilterDate").click(function(){
    $("#Modal_ShowFuilterDate").hide();
})

//--------------------------------------
//select gender
$("#btn_ShowModalGender").click(function(){
    $("#ModalGenderView").show();
})
$("#btn_closegender").click(function(){
    $("#ModalGenderView").hide();
})

//--------------------------------------
//select age
$("#btn_ShowModalAge").click(function(){
    $("#Modal_ShowFuilterAge").show();
});
$("#btn_CLoseFuilterAge").click(function(){
    $("#Modal_ShowFuilterAge").hide();
})
var MessageAge = "Chưa đủ tuổi lao động"
var MessageOld = "Quá độ tuổi lao động"
var Message = "Vui lòng nhập độ tuổi vào"

$("#btn_FuilterAge").click(function(){
    var from = $("#FromAge").val();
    var to = $("#EndAge").val();
    $("#ErorrFrom").empty();
    $("#ErorrTo").empty();
    if(from.length == 0){
        $("#ErorrFrom").append(Message);
        return;
    }
    if(to.length == 0){
        $("#ErorrTo").append(Message);
        return;
    }
    if(from < 18){
        $("#ErorrFrom").append(MessageAge);
        return;
    }
    if(to > 60){
        $("#ErorrTo").append(MessageOld);
        return
    }
})

//------------------------------------
//select address
$("#btn_ShowModalAddress").click(function(){
    $("#Modal_ShowFuilterAddress").show();
});
$("#btn_CLoseFuilterAddress").click(function(){
    $("#Modal_ShowFuilterAddress").hide();
})