var Apply = "Áp Dụng"
var Cancel = "Hủy Bỏ"
$(document).ready(function(){
    $("#Modal_ShowFuilterDate").hide();
    $(".applyBtn").empty();
    $(".cancelBtn").empty();
    $(".applyBtn").append(Apply);
    $(".cancelBtn").append(Cancel);

});

//seach name user
function ChangeTextName(){
    var v = $("#TxtNameUser").val();
    console.log(v);
}
//------------------------------------------------
//setting date time
$('input[name="daterange"]').daterangepicker({
    opens: 'left'
  });

//fuilter date request
$("#modaFiulterDay").click(function(){
    $("#Modal_ShowFuilterDate").show();
    return;
});
var MessaeDate = "Vui lòng chọn ngày!";
$("#btn_FuilterDate").click(function(){
    var get_DateTime = $("#rangeDate").val();
    $("#TxtErrorData").empty();
    if (get_DateTime == null || get_DateTime.length == 0) {
        $("#TxtErrorData").append(MessaeDate);
        return;
    }else{
        alert(get_DateTime);
        return;
    }
});
$("#btn_CLoseFuilterDate").click(function(){
    $("#Modal_ShowFuilterDate").hide();
    return;
});
