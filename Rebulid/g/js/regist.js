$(function () {
    $(".btn").on("click", function () {
        var a = $("#email").val();
        var b = $("#password").val();
        var d = $("#surePassword").val();
        var c = $("#validateNum").val();
        var e = $("#screenName").val();
        var booft = true;
        var str = "";

        if ($("#tk").attr("data-cacheval") == "true" || $("#tk").attr("data-cacheval") == undefined) {
            str = "<div class='say'>请接受并同意网站《用户服务条款》</div>";
            booft = true;
        } else {
            if (a.trim() == "") {
                str = "<div class='say'>账号不能为空</div>";
                booft = false;
            } else if (e.trim() == "") {
                str = "<div class='say'>昵称不能为空</div>";
                booft = false;
            } else if (b.trim() == "") {
                str = "<div class='say'>密码不能为空</div>";
                booft = false;
            } else if (c.trim() == "") {
                str = "<div class='say'>验证码不能为空</div>";
                booft = false;
            } else if (d.trim() == "") {
                str = "<div class='say'>确认密码不能为空</div>";
                booft = false;
            } else if (d.trim() != b.trim()) {
                str = "<div class='say'>输入的两次密码不一样</div>";
                booft = false;
            }

        }
        if (booft) {
            $("body").children().first().prepend(str);
            setTimeout(clearSay, 2000);
        }
        return booft;
    })
    function clearSay() {
        $(".say").remove();
    }
})