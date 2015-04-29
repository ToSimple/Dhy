

$(function () {
    function getQueryString(name) {
        var reg = new RegExp("(^|&)" + name + "=([^&]*)(&|$)", "i");
        var r = window.location.search.substr(1).match(reg);
        if (r != null) return unescape(r[2]); return null;
    }
    var r = getQueryString("i");
    //alert(r);
    if (r == 1) {
        $(".opt").removeClass("ui-btn-active");
        $(".opt1").addClass("ui-btn-active");
    } else if (r == 2) {
        $(".opt").removeClass("ui-btn-active");
        $(".opt2").addClass("ui-btn-active");
    } else if (r == 3) {
        $(".opt").removeClass("ui-btn-active");
        $(".opt3").addClass("ui-btn-active");
    } else if (r == 4) {
        $(".opt").removeClass("ui-btn-active");
        $(".opt4").addClass("ui-btn-active");
    } else {
        $(".opt").removeClass("ui-btn-active");
        $(".opt1").addClass("ui-btn-active");
    }
    //需要给安全退出加一个id="ext"
    $("#ext").on("click", function () {
        var r = window.confirm("你确定要退出登录账号？");
        return r;
    })
})
