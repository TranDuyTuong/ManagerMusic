$(document).ready(function () {
    $("#Modal_ShowAnswer").hide();
    $("#Modal_ShowTimeWorkuser").hide();
    $("#Modal_LockAccountUser").hide();
    $("#Modal_AnLockAccountUser").hide();
    $("#Modal_RemoveUser").hide();
});

//---------------------------------------------------
//funbtion answer
$("#btn_Answer").click(function () {
    $("#Modal_ShowAnswer").show();
});
$("#btn_CloseAnswer").click(function () {
    $("#Modal_ShowAnswer").hide();
});

//-----------------------------------------------
//futnion request
$("#btn_Request").click(function () {
    $("#Modal_ShowRequest").show();
});
$("#btn_CloseRequest").click(function () {
    $("#Modal_ShowRequest").hide();
});

//--------------------------------------------
//funtion modal work time user
$("#btn-ShowModalTimeWork").click(function () {
    $("#Modal_ShowTimeWorkuser").show();
});
$("#btn_CloseWorkTime").click(function () {
    $("#Modal_ShowTimeWorkuser").hide();
})

//--------------------------------------------
//funtion modal block account user
$("#btn-ShowModalLockAccount").click(function () {
    $("#Modal_LockAccountUser").show();
});
$("#btn_CloseOptionLock").click(function () {
    $("#Modal_LockAccountUser").hide();
})
$("#btn_AgrrenLock").click(function () {
    //logic code ..
    $("#modal_LoadingSignUp").show();
    $("#Modal_LockAccountUser").hide();
});
$("#btn_CancelLock").click(function () {
    $("#Modal_LockAccountUser").hide();
});

//---------------------------------------
//funtion modal an block account user
$("#btn-ShowModalAnLockAccount").click(function () {
    $("#Modal_AnLockAccountUser").show();
});
$("#btn_CloseOptionAnLock").click(function () {
    $("#Modal_AnLockAccountUser").hide();
});
$("#btn_AgrrenAnLock").click(function () {
    //logic code...
    $("#modal_LoadingSignUp").show();
    $("#Modal_AnLockAccountUser").hide();
});
$("#btn_CancelAnLock").click(function () {
    $("#Modal_AnLockAccountUser").hide();
})

//-----------------------------------------
//funtion remove account user
$("#btn-ShowModalRemoveUser").click(function(){
    $("#Modal_RemoveUser").show();
});
$("#btn_CloseOptionRemove").click(function(){
    $("#Modal_RemoveUser").hide();
});
$("#btn_AgrrenRemove").click(function(){
    //logic code...
    $("#modal_LoadingSignUp").show();
    $("#Modal_RemoveUser").hide();
});
$("#btn_CancelRemove").click(function(){
    $("#Modal_RemoveUser").hide();
});