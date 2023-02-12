var BackEmployee_List = $("#BackEmployee_List").val();
var NotFindStaff = $("#NotFindStaff").val();
var EmployeeCode_Invalid = $("#EmployeeCode_Invalid").val();
var EmployeeHiring_Status = $("#EmployeeHiring_Status").val();
var IdStaffs = $("#IdStaffs").val();
var Account = $("#Account").val();
var Employee_level = $("#Employee_level").val();
var Notification_Error = $("#Notification_Error").val();
var Nofitication_Success = $("#Nofitication_Success").val();
var EmptyCode_Employee = $("#EmptyCode_Employee").val();
var Lockedemployee_successfully = $("#Lockedemployee_successfully").val();
var Unlockemployee_successfully = $("#Unlockemployee_successfully").val();
var Choose_Role = $("#Choose_Role").val();
var Rolecode_found = $("#Rolecode_found").val();
var Currentrole_found = $("#Currentrole_found").val();
var Roleupdate_successful = $("#Roleupdate_successful").val();
var Gmailrequested_found = $("#Gmailrequested_found").val();
var gmailinfo_found = $("#gmailinfo_found").val();
var Maximun_length = $("#Maximun_length").val();
var Password_incorrect = $("#Password_incorrect").val();
var Password_characterandnumber = $("#Password_characterandnumber").val();
var Password_uppercase = $("#Password_uppercase").val();
var Changepassword_successfully = $("#Changepassword_successfully").val();
var Changepassword_failed = $("#Changepassword_failed").val();
var employeecanceled_successfully = $("#employeecanceled_successfully").val();
var Dividetaskssuccessful_employees = $("#Dividetaskssuccessful_employees").val();
var NotNull_Data = $("#NotNull_Data").val();
var NotSendMore_5File = $("#NotSendMore_5File").val();

$(document).ready(function () {
    $("#modal-LockAccountStaff").hide();
    $("#modal_HireStaff").hide();
    $("#modal_ChangePasswordStaff").hide();
    LoadDataUser();
});

//-------------------------------------------
//load data
function LoadDataUser() {
    $.ajax({
        url: "/User/Get_DetailStaff",
        type: "get",
        data: {
            IdUser: $("#IdUser").val()
        },
        success: function (result) {
            var html = "";
            switch (result.idStaff) {
                case "0":
                    $("#BodyDetail").empty();
                    html += '<p style="text-align: center;">' + NotFindStaff + '</p>';
                    html += '<a href="/User/Page_Staff" type="button" class="btn btn-danger">' + BackEmployee_List + '</a>';
                    $("#BodyDetail").append(html);
                    break;
                case "1":
                    $("#BodyDetail").empty();
                    html += '<p style="text-align: center;">' + EmployeeCode_Invalid + '</p>';
                    html += '<a href="/User/Page_Staff" type="button" class="btn btn-danger">' + BackEmployee_List + '</a>';
                    $("#BodyDetail").append(html);
                    break;
                default:
                    $("#ImgAvata").empty();
                    var Html_Img = "";
                    switch (result.typeImage) {
                        case "JPG":
                            if (result.hideStaff == 1) {
                                Html_Img += '<img src="data: image/JPG;base64, ' + result.avataImage + '" class="rounded mx-auto d-block" style="max-width: 100%;">'
                            } else {
                                Html_Img += '<img src="data: image/JPG;base64, ' + result.avataImage + '" class="rounded mx-auto d-block" style="max-width: 100%; filter:brightness(50%);">'
                            }
                            break;
                        case "jpg":
                            if (result.hideStaff == 1) {
                                Html_Img += '<img src="data: image/jpg;base64, ' + result.avataImage + '" class="rounded mx-auto d-block" style="max-width: 100%;">'
                            } else {
                                Html_Img += '<img src="data: image/jpg;base64, ' + result.avataImage + '" class="rounded mx-auto d-block" style="max-width: 100%; filter:brightness(50%);">'
                            }
                            break;
                        case "JPEG":
                            if (result.hideStaff == 1) {
                                Html_Img += '<img src="data: image/JPEG;base64, ' + result.avataImage + '" class="rounded mx-auto d-block" style="max-width: 100%;">'
                            } else {
                                Html_Img += '<img src="data: image/JPEG;base64, ' + result.avataImage + '" class="rounded mx-auto d-block" style="max-width: 100%; filter:brightness(50%);">'
                            }
                            break;
                        case "jpeg":
                            if (result.hideStaff == 1) {
                                Html_Img += '<img src="data: image/jpeg;base64, ' + result.avataImage + '" class="rounded mx-auto d-block" style="max-width: 100%;">'
                            } else {
                                Html_Img += '<img src="data: image/jpeg;base64, ' + result.avataImage + '" class="rounded mx-auto d-block" style="max-width: 100%; filter:brightness(50%);">'
                            }
                            break;
                        case "PNG":
                            if (result.hideStaff == 1) {
                                Html_Img += '<img src="data: image/PNG;base64, ' + result.avataImage + '" class="rounded mx-auto d-block" style="max-width: 100%;">'
                            } else {
                                Html_Img += '<img src="data: image/PNG;base64, ' + result.avataImage + '" class="rounded mx-auto d-block" style="max-width: 100%; filter:brightness(50%);">'
                            }
                            break;
                        case "png":
                            if (result.hideStaff == 1) {
                                Html_Img += '<img src="data: image/png;base64, ' + result.avataImage + '" class="rounded mx-auto d-block" style="max-width: 100%;">'
                            } else {
                                Html_Img += '<img src="data: image/png;base64, ' + result.avataImage + '" class="rounded mx-auto d-block" style="max-width: 100%; filter:brightness(50%);">'
                            }
                            break;
                        case "GIF":
                            if (result.hideStaff == 1) {
                                Html_Img += '<img src="data: image/GIF;base64, ' + result.avataImage + '" class="rounded mx-auto d-block" style="max-width: 100%;">'
                            } else {
                                Html_Img += '<img src="data: image/GIF;base64, ' + result.avataImage + '" class="rounded mx-auto d-block" style="max-width: 100%; filter:brightness(50%);">'
                            }
                            break;
                        case "gif":
                            if (result.hideStaff == 1) {
                                Html_Img += '<img src="data: image/gif;base64, ' + result.avataImage + '" class="rounded mx-auto d-block" style="max-width: 100%;">'
                            } else {
                                Html_Img += '<img src="data: image/gif;base64, ' + result.avataImage + '" class="rounded mx-auto d-block" style="max-width: 100%; filter:brightness(50%);">'
                            }
                            break;
                    }
                    $("#ImgAvata").append(Html_Img);
                    //namerole
                    $("#NameRole").empty();
                    $("#NameRole").append(result.nameRole);
                    $("#IdRole").val(result.idRole);
                    //activer
                    $("#NameActiver").empty();
                    $("#NameActiver").append(Account + " : " + result.nameActiver);
                    if (result.idActiver == 1) {
                        document.getElementById("btn-ShowModallockAccount").style.display = "initial";
                        document.getElementById("btn-ShowModalOpenlock").style.display = "none";
                        document.getElementById('NameActiver').style.color = "green";
                    } else {
                        document.getElementById("btn-ShowModallockAccount").style.display = "none";
                        document.getElementById("btn-ShowModalOpenlock").style.display = "initial";
                        document.getElementById('NameActiver').style.color = "red";
                    }
                    //Lever
                    $("#LeverStaff").empty();
                    $("#LeverStaff").append(Employee_level + " : " + result.nameLever);
                    //FullName
                    $("#TxtFullName").val(result.fullName);
                    //Birthday
                    $("#TxtbirthdayStaff").val(result.birthday);
                    //gmail
                    $("#TxtgmailStaff").val(result.gmail);
                    //Address
                    $("#TxtAddress").val(result.address);
                    //Phone
                    $("#TxtPhone").val(result.phone);
                    //Marriage
                    $("#TxtMarriage").val(result.nameMariage);
                    //Gender
                    $("#TxtGender").val(result.gender);
                    //District
                    $("#TxtDistrict").val(result.district);
                    //City
                    $("#TxtCity").val(result.city)
                    //hide staff
                    $("#HideStaff").empty();
                    if (result.hideStaff == 1) {
                        $("#HideStaff").append(EmployeeHiring_Status + " : " + result.nameHideStaff);
                        document.getElementById('HideStaff').style.color = "blue"
                    } else {
                        $("#HideStaff").append(EmployeeHiring_Status + " : " + result.nameHideStaff);
                        document.getElementById('HideStaff').style.color = "red"
                    }
                    //Id Staff
                    $("#IdStaffGet").empty();
                    $("#IdStaffGet").append(IdStaffs + " : " + result.idStaff);
            }
        }
    })
}

//-----------------------------------------------------
//modal lock aacount staff
$("#btn-ShowModallockAccount").click(function () {
    $("#modal-LockAccountStaff").show();
});
$("#btn_closeLockAccount").click(function () {
    $("#modal-LockAccountStaff").hide();
});
$("#Btn_AgreenBlock").click(function () {
    $("#modal-LockAccountStaff").hide();
    $("#modal_LoadingSignUp").show();
    $.ajax({
        url: "/User/BlockAccountStaff",
        type: "post",
        data: {
            IdUser: $("#IdUser").val()
        },
        success: function (result) {
            $("#modal_LoadingSignUp").hide();
            $("#modal-LockAccountStaff").hide();
            switch (result.idNotification) {
                case 0:
                    toastr.error(NotFindStaff, Notification_Error)
                    break;
                case 1:
                    LoadDataUser();
                    toastr.success(Lockedemployee_successfully, Nofitication_Success);
                    break;
                case 2:
                    toastr.error(EmptyCode_Employee, Notification_Error);
                    break;
            }
            return;
        }
    })
});
$("#Btn_AnagreenBlock").click(function () {
    $("#modal-LockAccountStaff").hide();
})

//-------------------------------------------------
//modal open lock account staff
$("#btn-ShowModalOpenlock").click(function () {
    $("#modal_LockOpenAccountStaff").show();
});
$("#btn_closeOpenLockAccount").click(function () {
    $("#modal_LockOpenAccountStaff").hide();
})
$("#Btn_OpenAnagreenBlock").click(function () {
    $("#modal_LockOpenAccountStaff").hide();
})
$("#Btn_OpenAgreenBlock").click(function () {
    $("#modal_LoadingSignUp").show();
    $("#modal_LockOpenAccountStaff").hide();
    $.ajax({
        url: "/User/OpenlockAccountStaff",
        type: "post",
        data: {
            IdUser: $("#IdUser").val()
        },
        success: function (result) {
            $("#modal_LoadingSignUp").hide();
            switch (result.idNotification) {
                case 0:
                    toastr.error(NotFindStaff, Notification_Error)
                    break;
                case 1:
                    LoadDataUser();
                    toastr.success(Unlockemployee_successfully, Nofitication_Success);
                    break;
                case 2:
                    toastr.error(EmptyCode_Employee, Notification_Error);
                    break;
            }
            return;
        }
    })
})


//------------------------------------------------------------
//modal cancel hire staff
$("#btn-ShowModalHideStaff").click(function () {
    $("#modal_HireStaff").show();
});
$("#btn_closeHireStaff").click(function () {
    $("#modal_HireStaff").hide();
});

//---------------------------------------------------------
//modal role staff
$("#btn-ShowModalRoleStaff").click(function () {
    $("#SelectRoleStaff").empty();
    $("#Body_HistoryRole").empty();
    $.ajax({
        url: "/User/GetDecenRoleSatff",
        type: "get",
        data: {
            IdUser: $("#IdUser").val()
        },
        success: function (result) {
            switch (result.fullName) {
                case "NotFindUser":
                    toastr.error(NotFindStaff, Notification_Error);
                    break;
                case "IdUserIllegal":
                    toastr.error(EmployeeCode_Invalid, Notification_Error);
                    break;
                default:
                    //current role
                    $("#TxtRoleCurent").val(result.nameRoleCurrent);
                    //list role
                    var html = '<option selected value="' + 0 + '">' + Choose_Role + '</option>';
                    $("#SelectRoleStaff").append(html);
                    $.each(result.l_Role, function (key, item) {
                        var htmlSelect = '';
                        htmlSelect += '<option value="' + item.idRole + '">' + item.roleName + '</option>';
                        $("#SelectRoleStaff").append(htmlSelect);
                    })
                    //list history role staff
                    var count = 0;
                    $.each(result.l_HistoryRole, function (key, item) {
                        count++;
                        var HtmlListHistory = '';
                        HtmlListHistory += '<tr>';
                        HtmlListHistory += '<th scope="row">' + count + '</th>';
                        HtmlListHistory += '<td>' + item.nameRole + '</td>';
                        HtmlListHistory += '<td>' + item.startDate_Str + '</td>';
                        HtmlListHistory += '<td>' + item.endDate_Str + '</td>';
                        HtmlListHistory += '<td>' + item.nameStaff_DecenRole + '</td>';
                        HtmlListHistory += '<td>' + item.startDate_Str + '</td>';
                        HtmlListHistory += '<td>' + item.timeSart + '</td>';
                        HtmlListHistory += '</tr>';
                        $("#Body_HistoryRole").append(HtmlListHistory);
                    })
                    $("#modal_RoleStaff").show();
                    break;
            }
            return;
        }
    })
});
$("#btn_closeRoleStaff").click(function () {
    $("#Error_Data").empty();
    $("#modal_RoleStaff").hide();
    LoadDataUser();
});
$("#btn_RoleStaff").click(function () {
    var get_DataValue = $("#SelectRoleStaff").val();
    $("#Error_Data").empty();
    if (get_DataValue == 0) {
        $("#Error_Data").append(Choose_Role);
        return;
    }
    $("#modal_LoadingSignUp").show();
    $("#modal_RoleStaff").hide();
    $.ajax({
        url: "/User/ChangeRoleStaff",
        type: "post",
        data: {
            IdUser: $("#IdUser").val(),
            IdRole: get_DataValue,
            IdRoleCurrent: $("#IdRole").val()
        },
        success: function (result) {
            $("#modal_LoadingSignUp").hide();
            switch (result.idNotification) {
                case 0:
                    toastr.error(NotFindStaff, Notification_Error);
                    break;
                case 1:
                    toastr.error(Rolecode_found, Notification_Error);
                    break;
                case 2:
                    toastr.error(Currentrole_found, Notification_Error);
                    break;
                case 3:
                    toastr.success(Roleupdate_successful, Nofitication_Success);
                    LoadDataUser()
                    break;
                case 4:
                    toastr.error(EmployeeCode_Invalid, Notification_Error);
                    break;
            }
            return;
        }
    })
});

//---------------------------------------------
var HtmlCheck = '<i class="fas fa-check"></i>';
//modal change password
$("#btn-ShowModalChangePassword").click(function () {
    $("#fullnameStaff").empty();
    $("#IdNameStaff").empty();
    $("#TxtChangeEmailStaff").val('');
    $("#modal_ChangePasswordStaff").show();
});
$("#btn_closeChangePasswordStaff").click(function () {
    $("#modal_ChangePasswordStaff").hide();
    window.location.reload();
})
//Show Password
function myFunction() {
    var x = document.getElementById("TxtChangePasswordStaff");
    if (x.type === "password") {
        x.type = "text";
    } else {
        x.type = "password";
    }
}
$("#btnCheckGmail").click(function () {
    var get_data = $("#TxtChangeEmailStaff").val();
    $("#Error_DataChange").empty();
    $("#data_SuccessChange").empty();
    if (get_data.length == 0 || get_data == null) {
        $("#Error_DataChange").append(NotNull_Data);
        return;
    } else {
        $.ajax({
            url: "/User/CheckGmailChangePassword",
            type: "get",
            data: {
                Gmail: get_data
            },
            success: function (result) {
                switch (result.idNotification) {
                    case 0:
                        toastr.error(Gmailrequested_found, Notification_Error);
                        $("#fullnameStaff").empty();
                        $("#IdNameStaff").empty();
                        break;
                    case 1:
                        toastr.success(gmailinfo_found, Nofitication_Success);
                        $("#fullnameStaff").append(result.fullName);
                        $("#IdNameStaff").append(result.idStaff);
                        document.getElementById("btn_SentDataPassword").style.display = "block";
                        break;
                }
                return;
            }
        })
    }
});

function ValidateTxtEmailPassword() {
    var get_data = $("#TxtChangeEmailStaff").val();
    $("#Error_DataChange").empty();
    $("#data_SuccessChange").empty();
    if (get_data.length == 0 || get_data == null) {
        $("#Error_DataChange").append(MessageError);
        return;
    } else {
        $("#data_SuccessChange").append(HtmlCheck);
        return;
    }
}
function ValidateTxtPassword() {
    var get_data = $("#TxtChangePasswordStaff").val();
    $("#Error_PasswordDataChange").empty();
    $("#data_PasswordSuccessChange").empty();
    if (get_data.length == 0 || get_data == null) {
        $("#Error_PasswordDataChange").append(MessageError);
        return;
    }
    if (get_data.length > 10) {
        $("#Error_PasswordDataChange").append(Maximun_length);
        return;
    }
    $("#data_PasswordSuccessChange").append(HtmlCheck);
}
function ValidateTxtPasswordConfim() {
    var get_data = $("#TxtChangePasswordConfimStaff").val();
    var get_dataPassword = $("#TxtChangePasswordStaff").val();

    $("#data_PasswordConfimSuccessChange").empty();
    $("#Error_PasswordConfimDataChange").empty();
    if (get_data != get_dataPassword) {
        $("#Error_PasswordConfimDataChange").append(Password_incorrect);
        return;
    } else {
        $("#data_PasswordConfimSuccessChange").append(HtmlCheck);
        return;
    }
}
$("#btn_SentDataPassword").click(function () {

    var get_datagmail = $("#TxtChangeEmailStaff").val();
    if (get_datagmail.length == 0 || get_datagmail == null) {
        $("#Error_DataChange").empty();
        $("#data_SuccessChange").empty();
        $("#Error_DataChange").append(NotNull_Data);
        return;
    }

    var get_data = $("#TxtChangePasswordStaff").val();
    if (get_data.length == 0 || get_data == null) {
        $("#Error_PasswordDataChange").empty();
        $("#data_PasswordSuccessChange").empty();
        $("#Error_PasswordDataChange").append(NotNull_Data);
        return;
    }

    //password special character
    var regularExpression = /^(?=.*[0-9])(?=.*[!@#$%^&*])[a-zA-Z0-9!@#$%^&*]{6,16}$/;
    if (!regularExpression.test(get_data)) {
        var ValidatePassword = $("#Error_PasswordDataChange").empty();
        ValidatePassword.append(Password_characterandnumber);
        $("#data_PasswordSuccessChange").empty();
        return;
    }
    //password upperCase
    if (get_data.search(/[A-Z]/) == -1) {
        var ValidatePassword = $("#Error_PasswordDataChange").empty();
        ValidatePassword.append(Password_uppercase);
        $("#data_PasswordSuccessChange").empty();
        return;
    }

    var get_data = $("#TxtChangePasswordConfimStaff").val();
    var get_dataPassword = $("#TxtChangePasswordStaff").val();

    if (get_data != get_dataPassword) {
        $("#data_PasswordConfimSuccessChange").empty();
        $("#Error_PasswordConfimDataChange").empty();
        $("#Error_PasswordConfimDataChange").append(Password_incorrect);
        return;
    }
    $("#modal_LoadingSignUp").show();
    $.ajax({
        url: "/User/ChangePasswordStaff",
        type: "post",
        data: {
            Gmail: get_datagmail,
            Password: get_dataPassword
        },
        success: function (result) {
            $("#modal_LoadingSignUp").hide();
            switch (result.idNotification) {
                case 0:
                    toastr.error(Password_characterandnumber + "," + Password_uppercase, Notification_Error);
                    $("#modal_ChangePasswordStaff").show();
                    break;
                case 1:
                    toastr.error(NotFindStaff, Notification_Error);
                    $("#modal_ChangePasswordStaff").show();
                    break;
                case 2:
                    toastr.success(Changepassword_successfully, Nofitication_Success);
                    $("#modal_ChangePasswordStaff").hide();
                    LoadDataUser();
                    break;
                case 3:
                    toastr.error(Changepassword_failed, Notification_Error);
                    $("#modal_ChangePasswordStaff").show();
                    break;
            }
            return;
        }
    })

});

//-------------------------------------------------------------
//funtion cancel hide staff
$("#btn-ShowModalHideStaff").click(function () {
    $("#modal_HireStaff").show();
});
$("#btn_closeHireStaff").click(function () {
    $("#modal_HireStaff").hide();
})
$("#CancelHide").click(function () {
    $("#modal_HireStaff").hide();
})
$("#AgreenHide").click(function () {
    $("#modal_HireStaff").hide();
    $("#modal_LoadingSignUp").show();
    $.ajax({
        url: "/User/CancelHideStaff",
        type: "post",
        data: {
            IdUser: $("#IdUser").val()
        },
        success: function (result) {
            $("#modal_LoadingSignUp").hide();
            switch (result.idNotification) {
                case 0:
                    toastr.error(NotFindStaff, Notification_Error);
                    break;
                case 1:
                    toastr.success(employeecanceled_successfully, Nofitication_Success);
                    LoadDataUser()
                    break;
                case 2:
                    toastr.error(EmployeeCode_Invalid, Notification_Error);
                    break;
            }
            return;
        }
    })
})

//-------------------------------------------------------
//modal plans for staff
$("#btn-ShowModalTakeAgainPassword").click(function () {
    $("#TxtNameStaff").empty();
    var NameStaff = $("#TxtFullName").val();
    var IdStaff = $("#IdStaff").text();
    $("#TxtNameStaff").append(' ' + NameStaff + " ---- " + IdStaff);
    $("#modal_Plan").show();
});
$("#btn_closePlan").click(function () {
    LoadDataUser()
    $("#modal_Plan").hide();
})

$("#btn_SentData").click(function () {
    //check title
    var CheckTitlePlan = FuntionCheckTitlePlan();
    if (CheckTitlePlan == false) {
        return;
    }
    //check content
    var CheckContentPlan = FuntionCheckContentPlan();
    if (CheckContentPlan == false) {
        return;
    }
    //check date plan
    var CheckDatePlan = FuntionChangeDatePlan();
    if (CheckDatePlan == false) {
        return;
    }
    //check time plan
    var CheckTimePlan = FuntionChangeTimePlan();
    if (CheckTimePlan == false) {
        return;
    }

    //check file
    var formData = new FormData();
    var IdUser = document.getElementById("IdUser").value;
    var files = $("#TxtFiles").prop("files")
    var CreatePlan_V = {
        NamePlan: $("#TxtTitle").val(),
        ContentPlan: $("#TxtContent").val(),
        DateTimeComplete: $("#TxtDateTimeCompele").val(),
        IdUserPlan: IdUser,
        TimeComplete: $("#TxtTimeCompele").val()
    };

    for (var i = 0; i < files.length; i++) {
        formData.append("L_FilePlans", files[i]);
    }
    formData.append("CreatePlan_V", JSON.stringify(CreatePlan_V));
    $("#modal_LoadingSignUp").show();
    $("#modal_Plan").hide();
    $.ajax({
        url: "/User/CreatePlanStaff",
        type: "post",
        data: formData,
        contentType: false,
        processData: false,
        success: function (result) {
            $("#modal_LoadingSignUp").hide();
            switch (result.idNotification) {
                case 0:
                    toastr.error(NotFindStaff, Notification_Error);
                    $("#modal_Plan").show();
                    break;
                case 1:
                    toastr.success(Dividetaskssuccessful_employees, Nofitication_Success);
                    LoadDataUser()
                    break;
                case 2:
                    toastr.error(EmployeeCode_Invalid, Notification_Error);
                    $("#modal_Plan").show();
                    break;
            }
            return;
        }
    })
})

function FuntionCheckTitlePlan() {
    $("#ErrorTitlePlan").empty();
    $("#SuccessPlanTitle").empty();
    var Get_Title = $("#TxtTitle").val();
    if (Get_Title.length == 0) {
        $("#ErrorTitlePlan").append(NotNull_Data);
        return false;
    } else {
        $("#SuccessPlanTitle").append(HtmlCheck);
        return true;
    }
}

function FuntionCheckContentPlan() {
    $("#ErrorContentPlan").empty();
    $("#SuccessPlanContent").empty();
    var Get_Title = $("#TxtContent").val();
    if (Get_Title.length == 0) {
        $("#ErrorContentPlan").append(NotNull_Data);
        return false;
    } else {
        $("#SuccessPlanContent").append(HtmlCheck);
        return true;
    }
}

function FuntionChangeDatePlan() {
    $("#ErrorDatePlan").empty();
    $("#SuccessPlanDate").empty();
    var Get_Title = $("#TxtDateTimeCompele").val();
    if (Get_Title.length == 0) {
        $("#ErrorDatePlan").append(NotNull_Data);
        return false;
    } else {
        $("#SuccessPlanDate").append(HtmlCheck);
        return true;
    }
}

function FuntionChangeTimePlan() {
    $("#ErrorTimePlan").empty();
    $("#SuccessPlanTime").empty();
    var Get_Title = $("#TxtTimeCompele").val();
    if (Get_Title.length == 0) {
        $("#ErrorTimePlan").append(NotNull_Data);
        return false;
    } else {
        $("#SuccessPlanTime").append(HtmlCheck);
        return true;
    }
}

$("#TxtFiles").change(function () {
    var dataImage = [];
    var dataProcessBarID = [];
    var processBar = "";
    var totalfiles = document.getElementById('TxtFiles').files.length;
    if (totalfiles > 0) {
        if (totalfiles > 5) {
            toastr.error(NotSendMore_5File, Notification_Error);
            $("#TxtFiles").val('');
        } else {
            $("#filelist").empty();
            for (var i = 0; i < totalfiles; i++) {
                var nameFile = document.getElementById('TxtFiles').files[i];
                dataImage[i] = nameFile;
                var processID = "processID_" + i;
                processBar += "<label class=\"label label-primary\">File:" + nameFile.name + "</label><br/><div class=\"progress\">" +
                    "<div id='" + processID + "' class=\"progress-bar progress-bar-success\" role=\"progressbar\" aria-valuenow=\"0\" aria-valuemin=\"0\" aria-valuemax=\"100\" style=\"width:100%\">" +
                    "100% Complete (success)" +
                    "</div>" +
                    "</div>";
                dataProcessBarID[i] = processID;
            }
            $("#filelist").html(processBar);
        }
        return;
    }
})