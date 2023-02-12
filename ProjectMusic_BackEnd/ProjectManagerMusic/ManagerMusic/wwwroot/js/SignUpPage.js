toastr.options = {
    "closeButton": false,
    "debug": false,
    "newestOnTop": false,
    "progressBar": false,
    "positionClass": "toast-top-left",
    "preventDuplicates": false,
    "onclick": null,
    "showDuration": "300",
    "hideDuration": "1000",
    "timeOut": "5000",
    "extendedTimeOut": "1000",
    "showEasing": "swing",
    "hideEasing": "linear",
    "showMethod": "fadeIn",
    "hideMethod": "fadeOut"
}
//validate form signup
var MessageValidate = $("#ErrorNulData").val();
var Hmtl = '<i class="fas fa-check"></i>';
var ErrorPassword = $("#ErrorMaximunlength").val();
var Error_Gender = $("#ErrorGender").val();
var ErrorCity = $("#ErrorChooseCity").val();
var ErrorDistrict = $("#ErrorDistrict").val();
var Notification_Error = $("#NotificationError").val();
var Notification_Success = $("#NotificationSuccess").val();
var C_EmailAlreadyExists = $("#EmailAlreadyExists").val();
var C_RegiterSuccess = $("#EmailRegiterSuccess").val();
var C_RegiterError = $("#ErrorRegiterFail").val();
var C_ErrorEmailsyntax = $("#ErrorEmailsyntax").val();
var ErrorPasswordCN = $("#Passwordcharacterandnumber").val();
var ErrorPasswordUppercase = $("#PasswordUppercase").val();

var D_Name;
var D_BrithDay_Day;
var D_BrithDay_Month;
var D_BrithDay_Year;
var D_Email;
var D_Password;

//loading
$(document).ready(function () {
    LoadingCity();
    D_Name = "";
    D_BrithDay_Day = "";
    D_BrithDay_Month = "";
    D_BrithDay_Year = "";
    D_Email = "";
    D_Password = "";
});

//loading city
function LoadingCity() {
    var OptionCity = $("#S_City").val();
    var OptionDistrict = $("#S_District").val();
    $("#SelectDistrict").append('<option value="0">' + OptionDistrict + '</option>')
    $("#SelectDistrict").prop('disabled', true);
    $.ajax({
        url: "/Account/JsonGetAllCity",
        type: "get",
        success: function (result) {
            var SelectCity = $("#SelectCity").empty();
            SelectCity.append('<option value="0">' + OptionCity + '</option>')
            $.each(result, function (key, item) {
                var CityHtml = "";
                CityHtml += '<option value="' + item.idCity + '">' + item.nameCity + '</option>';
                SelectCity.append(CityHtml);
            })
        }
    })
}

//select city
$("#SelectCity").change(function () {
    var GetCity = $("#SelectCity").val();
    var ErrorAddress = $("#ValidaAddress").empty();
    if (GetCity == 0) {
        $("#SelectDistrict").prop('disabled', true);
        ErrorAddress.append(ErrorCity);
        return;
    } else {
        $.ajax({
            url: "/Account/JsonGetAllDistrictById",
            type: "post",
            data: {
                Id: GetCity
            },
            success: function (result) {
                if (result.status == false) {
                    $("#SelectDistrict").prop('disabled', true);
                    toastr.Error(ErrorDistrict, Notification_Error)
                    $("#ToastsMessage").toast("show");
                    return;
                } else {
                    var SelectDistrict = $("#SelectDistrict").empty();
                    SelectDistrict.prop('disabled', false);

                    $.each(result.l_District, function (key, item) {
                        var DistrictHtml = "";
                        DistrictHtml += '<option value="' + item.idDistrict + '">' + item.nameDistrict + '</option>';
                        SelectDistrict.append(DistrictHtml);
                    })
                }
            }
        })
       
    }
});

//validate Name
function checkvalueName() {
    var NameUser = $("#Txt_Name").val();
    var ValidateName = $("#ValidaName").empty();
    var ValiDateNameDone = $("#checkOkName").empty();
    if (NameUser.length == 0) {
        ValidateName.append(MessageValidate);
        D_Name = "";
        return;
    } else {
        ValiDateNameDone.html(Hmtl);
        D_Name = NameUser;
        return;
    }
}

//validate Birthday
function checkvalueBirthday() {
    var Get_Date = new Date($("#Txt_Birthday").val());
    D_BrithDay_Day = Get_Date.getDate();
    D_BrithDay_Month = Get_Date.getMonth() + 1;
    D_BrithDay_Year = Get_Date.getFullYear();
    var ValidateBirthdayDone = $("#checkOkBirthday").empty();
    ValidateBirthdayDone.html(Hmtl);
    return;
}

//valiadate Email
function checkvalueGmail() {
    var GmailUser = $("#Txt_Gmail").val();
    var ValidateGmail = $("#ValidaGmail").empty();
    var ValidateEmailDone = $("#checkOkGmail").empty();
    if (GmailUser.length == 0) {
        ValidateGmail.append(MessageValidate);
        D_Email = "";
        return;
    } else {
        ValidateEmailDone.html(Hmtl);
        D_Email = GmailUser;
        return;
    }
}

//validate Password
function checkvaluePassword() {
    var PasswordUser = $("#Txt_Password").val();
    var ValidatePassword = $("#ValidaPassword").empty();
    var ValidatePasswordDone = $("#checkOkPassword").empty();

    if (PasswordUser.length == 0) {
        ValidatePassword.append(MessageValidate);
        D_Password = "";
        return;
    }
    if (PasswordUser.length >= 10) {
        ValidatePassword.append(ErrorPassword);
        D_Password = "";
        return;
    }
    ValidatePasswordDone.html(Hmtl);
    D_Password = PasswordUser;
    return;
}

//Show Password
function myFunction() {
    var x = document.getElementById("Txt_Password");
    if (x.type === "password") {
        x.type = "text";
    } else {
        x.type = "password";
    }
}


//SignUp Admin
$("#btn_SignUp").click(function () {

    var Get_Date = new Date($("#Txt_Birthday").val());

    var GetName_User = D_Name;
    var GetGmail_User = D_Email;
    var GetPassword_User = D_Password;
    if (GetName_User == "" || GetGmail_User == "" || GetPassword_User == "") {
        //name
        if (GetName_User == "") {
            var ValidateName = $("#ValidaName").empty();
            ValidateName.append(MessageValidate);
            D_Name = "";
        }
        //email
        if (GetGmail_User == "") {
            var ValidateGmail = $("#ValidaGmail").empty();
            ValidateGmail.append(MessageValidate);
            D_Email = "";
        }
        //password
        if (GetPassword_User == "") {
            var ValidatePassword = $("#ValidaPassword").empty();
            ValidatePassword.append(MessageValidate);
            D_Password = "";
        }      
        return;
    }
    //password special character
    var regularExpression = /^(?=.*[0-9])(?=.*[!@#$%^&*])[a-zA-Z0-9!@#$%^&*]{6,16}$/;
    if (!regularExpression.test(GetPassword_User)) {
        var ValidatePassword = $("#ValidaPassword").empty();
        ValidatePassword.append(ErrorPasswordCN);
        D_Password = "";
        return;
    }
    //password upperCase
    if (GetPassword_User.search(/[A-Z]/) == -1) {
        var ValidatePassword = $("#ValidaPassword").empty();
        ValidatePassword.append(ErrorPasswordUppercase);
        D_Password = "";
        return;
    } 
   

    //validate birthday
    D_BrithDay_Day = Get_Date.getDate();
    D_BrithDay_Month = Get_Date.getMonth() + 1;
    D_BrithDay_Year = Get_Date.getFullYear();
    if (isNaN(D_BrithDay_Day) || isNaN(D_BrithDay_Month) || isNaN(D_BrithDay_Year)) {
        var ValidateBirthday = $("#ValidaBirthday").empty();
        ValidateBirthday.append(MessageValidate);
        return;
    } else {
        $("#ValidaBirthday").empty();
        var ValidateBirthdayDone = $("#checkOkBirthday").empty();
        ValidateBirthdayDone.html(Hmtl);
    }

    //validate gender
    var GetGender = 0
    var Okgender = $("#checkOkGender").empty();
    var Errorgender = $("#ValidaGender").empty();
    if ($("#Checkman").is(":checked")) {
        GetGender = $("#Checkman").val();
        Okgender.html(Hmtl);
    }
    if ($("#Checkwoment").is(":checked")) {
        GetGender = $("#Checkwoment").val();
        Okgender.html(Hmtl);
    }
    if (GetGender == 0) {
        Errorgender.append(Error_Gender);
        return;
    }
    //validate address
    var GetCity = $("#SelectCity").val();
    var GetDistrict = $("#SelectDistrict").val();
    var ErrorAddress = $("#ValidaAddress").empty();
    if (GetCity == 0) {
        $("#SelectDistrict").prop('disabled', true);
        ErrorAddress.append(ErrorCity);
        return;
    }
    $("#modal_LoadingSignUp").show();
    $.ajax({
        url: "/Account/JsonRegiterUser",
        type: "post",
        data: {
            FullName: D_Name,
            Email: D_Email,
            Password: D_Password,
            Gender: GetGender,
            IdCity: GetCity,
            IdDitrict: GetDistrict,
            Date: D_BrithDay_Day,
            Month: D_BrithDay_Month,
            Year: D_BrithDay_Year
        }, success: function (result) {
            $("#modal_LoadingSignUp").hide();
            if (result.status == false) {              
                if (result.isStatus == 1) {   
                    
                    toastr.error(C_EmailAlreadyExists, Notification_Error)             
                }
                if (result.isStatus == 3) {
                    toastr.error(C_RegiterError, Notification_Error)             
                }
                if (result.isStatus == 4) {
                    toastr.error(C_ErrorEmailsyntax, Notification_Error)    
                }
                
            } else {
                if (result.isStatus == 2) {
                    toastr.success(C_RegiterSuccess, Notification_Success)
                }
            }
            return

        }
    })   
});