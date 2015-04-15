$(function () {
    //$(".remenber").on("click", function () {
    //    var a = $(this).find("i");
    //    if (a.hasClass("fa-circle-thin")) {
    //        $(this).find("i").removeClass("fa-circle-thin").addClass("fa-check-circle");
    //    } else {
    //        $(this).find("i").removeClass("fa-check-circle").addClass("fa-circle-thin");
    //    }
    //})
    $("#username").parent().prepend("<i class='fa fa-user icon'></i>");
    $("#password").parent().prepend("<i class='fa fa-lock icon'></i>");
    $(".btn").on("click", function () {
        var a = $("#username").val();
        var b = $("#password").val();
        var c = $("#validateNum").val();
        var str = "";
        var booft = true;
        if (a.trim() == "") {
            str = "账号不能为空";
            booft = false;
        } else if (b.trim() == "") {
            str = "密码不能为空";
            booft = false;
        } else if (c.trim() == "") {
            str = "验证码不能为空";
            booft = false;
        }
        if (!booft) {
            showMessage(str);
        }
        else {
            login();
        }
    })



    //刷新验证码
    function refrushAuthImg(obj) {
        obj.src = obj.src + "?code=" + Math.random();
    }


    //登录
    function login() {
        //表单数据
        var formData = {
            'username': $("#username").val(),
            'password': $("#password").val(),
            'validateNum': $("#validateNum").val(),
            'rememberMe': $("#rememberMe").val()
        };

        //ajax提交
        $.ajax({
            url: "user/userLogin",
            data: formData,
            type: "post",
            dataType: "json",
            success: function (results) {
                if (results != null) {
                    if (results.mes.length > 0)
                    {
                        showMessage(results.mes);
                    }

                    if (results.locationUrl.length > 0)
                    { window.location = results.locationUrl; }
                }
            }, error: function (error) {
                console.log(error);
            }
        });
    }
})