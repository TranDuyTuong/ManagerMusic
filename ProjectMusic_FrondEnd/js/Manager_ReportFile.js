var Apply = "Áp Dụng"
var Cancel = "Hủy Bỏ"
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