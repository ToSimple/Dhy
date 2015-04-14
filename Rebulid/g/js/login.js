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

        if (a.trim() == "") {
            str = "<div class='say'>账号不能为空</div>";
        } else if (b.trim() == "") {
            str = "<div class='say'>密码不能为空</div>";
        } else if (c.trim() == "") {
            str = "<div class='say'>验证码不能为空</div>";
        }

        $("body").children().first().prepend(str);
        setTimeout(clearSay, 2000);
    })
    function clearSay() {
        $(".say").remove();
    }
})