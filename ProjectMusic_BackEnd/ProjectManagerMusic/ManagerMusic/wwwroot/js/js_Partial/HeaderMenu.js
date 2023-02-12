var ImgeIcon = '<i class="fas fa-user-cog" style="font-size: 24px; margin: 2px 1px; color: #3b3939;"></i>';
var ImgeIconBig = '<i class="fas fa-user-cog" style="font-size: 74px; margin: 2px 1px; color: #3b3939;"></i>';
var ImgeUserBig = ' <i class="fas fa-user" style="font-size: 74px; margin: 2px 1px; color: #3b3939;"></i>'
var ImgeAvata = '<img id="AvataImg" style="width: 200%; margin: -30px -40px; height: 200%;"/>';
var user = $("#v_uer").val();
var staff = $("#v_staff").val();
var admin = $("#v_admin").val();
var read_Error = $("#read_Error").val();
var read_Success = $("#read_Success").val();
var Notification_Error = $("#Notification_Error").val();
var Nofitication_Success = $("#Nofitication_Success").val();
var not_seen = $("#not_seen").val();
var watched = $("#watched").val();

//load data
$(document).ready(function () {
    LoadData();
});

//load data user and staff
function LoadData() {
    $.ajax({
        url: "/Account/JsonClaimsInfo",
        type: "get",
        success: function (result) {
            var l_data = document.querySelectorAll("#modaldatashow");
            if (result == 0) {
                for (let i = 0; i < l_data.length; i++) {
                    l_data[i].style.display = "none";
                }
                //show icon signin and sign out
                document.getElementById('ShowAndHide').style.display = 'block';
            } else {
                //hide icon signin and sign out
                document.getElementById('ShowAndHide').style.display = 'none';
                for (let i = 0; i < l_data.length; i++) {
                    l_data[i].style.display = "block";
                }
                var NameSetting = $("#TxtName").empty();
                var RoleSetting = $("#TxtRole").empty();
                $("#ImageBig").empty();
                switch (result.symbolRole) {
                    case "ND":
                        NameSetting.append(result.fullName);
                        RoleSetting.append(user);        
                        $("#ImageBig").append(ImgeUserBig);
                        document.getElementById('IndexFile_Heard').style.display = 'none';
                        break;
                    case "NV":
                        $("#AvataUserAdmin").empty();
                        $("#AvataUserAdmin").append(ImgeIcon);
                        if (result.imageAvata == null) {
                            $("#ImageBig").append(ImgeIconBig);
                        } else {
                            $("#ImageBig").append(ImgeAvata);
                            $("#AvataImg").attr("src", "data:image/jpg;base64," + result.imageAvata + "")
                        }
                        RoleSetting.append(staff);
                        break;
                    case "AD":
                        $("#AvataUserAdmin").empty();
                        $("#AvataUserAdmin").append(ImgeIcon);
                        if (result.imageAvata == null) {
                            $("#ImageBig").append(ImgeIconBig);
                        } else {
                            $("#ImageBig").append(ImgeAvata);
                            $("#AvataImg").attr("src", "data:image/jpg;base64," + result.imageAvata + "")
                        }
                        RoleSetting.append(admin);
                        break;
                    default: return;
                }
                //load notification by id user
                LoadNotification(result.idUser);
            }
            return;
        }
    })
}

//Show modal infomaton Admin
$("#btn_ShowInfoAdmin").click(function () {
    var TxtGmail = $("#TxtGmail").empty();
    var TxtBirthday = $("#TxtBirthday").empty();
    var TxtRoleName = $("#TxtRoleName").empty();
    var TxtDateRegiter = $("#TxtDateRegiter").empty();
    var TxtNames = $("#TxtNames").empty();
    $.ajax({
        url: "/Account/JsonClaimsInfo",
        type: "get",
        success: function (result) {
            if (result.fullName != null) {
                TxtNames.val(result.fullName);
                TxtGmail.val(result.email);
                TxtBirthday.val(result.birthday);
                TxtRoleName.val(result.nameRole);
                TxtDateRegiter.val(result.dateCreate);
            }
            $("#modal_ShowInfomationAdmin").show();
            return;
        }
    })
});
$("#btn_CloseModalInfoAdmin").click(function () {
    $("#modal_ShowInfomationAdmin").hide();
});

//notification user
function LoadNotification(Id_user) {
    if (Id_user == null) {
        return
    } else {
        $.ajax({
            url: "/Notification/GetNotificationByUser",
            type: "get",
            data: {
                IdUser: Id_user,
                take: 20
            },
            success: function (result) {
                var NumberLisst = $(".position-absolute").empty();
                var ShowList = $("#ShowListNotification").empty();
                var NumberSmall = $("#NumberMessage").empty();
                var count = 0;
                $.each(result, function (key, item) {
                    var Html = "";
                    if (item.idViewNotification == 2) {
                        count++;
                        Html += '<div class="media new" onclick="ReadNotification(' + item.idNotification + ', ' + item.idViewNotification + ')">';
                        Html += '<input type="hidden" value="' + item.idNotification + '"/>'
                        Html += '<div class="az-img-user" id="Show'+ item.idNotification +'"><i class="fas fa-envelope" style="font-size: 30px; color: #1270d2;"></i></div>';
                        Html += '<div class="media-body">';
                        Html += '<p style="color: black; font - size: 16px; font - family: initial;">' + item.titleNotification + '</p>';
                        Html += '<p style="text-align:right;">' + item.dateCreate + ' -- ' + item.timeCreate + '</p>'
                        Html += '<span>' + item.authorNotification + ' -- <i id="seen' + item.idNotification +'">' + not_seen + '</i></span>'
                        Html += '</div>';
                        Html += '</div>';
                    } else {
                        Html += '<div class="media new" onclick="ReadNotification(' + item.idNotification + ', ' + item.idViewNotification + ')">';
                        Html += '<input type="hidden" value="' + item.idNotification + '"/>'
                        Html += '<div class="az-img-user" id="Show'+ item.idNotification +'"><i class="fas fa-envelope-open" style="color: #f7007b; font-size: 30px"></i></div>';
                        Html += '<div class="media-body">';
                        Html += '<p style="color: black; font - size: 16px; font - family: initial;">' + item.titleNotification + '</p>';
                        Html += '<p style="text-align:right;">' + item.dateCreate + ' -- ' + item.timeCreate + '</p>'
                        Html += '<span>' + item.authorNotification + ' -- <i id="seen' + item.idNotification +'">' + watched + '</i> </span>'
                        Html += '</div>';
                        Html += '</div>';
                    }
                    ShowList.append(Html);
                })
                NumberLisst.append(count);
                NumberSmall.append(count);
            }
        })
    }
    return;
}

//read notification user
function ReadNotification(IdNotification, IdView) {
    if (IdView == 1) {
        toastr.success(read_Success, Nofitication_Success);
        return;
    }   
    var html = '<i class="fas fa-envelope-open" style="color: #f7007b; font-size: 30px"></i>';
    var Setid = "#Show" + IdNotification;
    var Setseen = "#seen" + IdNotification;
    var GetValue = $(Setid).empty();
    var GetValueSeen = $(Setseen).empty();
    $.ajax({
        url: "/Notification/WatchNotification",
        type: "get",
        data: {
            IdNotification: IdNotification
        },
        success: function (result) {
            if (result == true) {
                GetValue.append(html);
                GetValueSeen.append(watched);
                toastr.success(read_Success, Nofitication_Success);
            } else {
                toastr.error(read_Error, Notification_Error);
            }
        }
    })   
    return;
}

//remove set activer for logout
$("#LogOut").click(function () {
    localStorage.setItem("IdFlaps", "1");
    return;
})

//reomve set activer for IndexFile
$("#IndexFile_Heard").click(function () {
    localStorage.setItem("IdFlaps", "1");
    return;
})
