


//提示窗口
function showMessage(str) {
    var a = "<div class='say'>" + str + "</div>"
    $("body").children().first().prepend(a);
    setTimeout(clearSay, 2000);
}
function clearSay() {
    $(".say").remove();
}

//收缩
//$(".tip-min").on("click", function () {
//    if ($(this).parent().parent().parent().children(".box-content-pd").css("display") == "none") {

//        $(this).children("i").removeClass("fa-caret-square-o-up").addClass("fa-caret-square-o-down");
//        $(this).parent().parent().parent().children(".box-content-pd").css("display", "block");
//    } else if ($(this).parent().parent().parent().children(".box-content-pd").css("display") == "block") {
//        $(this).children("i").removeClass("fa-caret-square-o-down").addClass("fa-caret-square-o-up");
//        $(this).parent().parent().parent().children(".box-content-pd").css("display", "none");
//    }
//    if ($(this).parent().parent().parent().children(".box-content").css("display") == "none") {
//        $(this).children("i").removeClass("fa-caret-square-o-up").addClass("fa-caret-square-o-down");
//        $(this).parent().parent().parent().children(".box-content").css("display", "block");
//    } else if ($(this).parent().parent().parent().children(".box-content").css("display") == "block") {
//        $(this).children("i").removeClass("fa-caret-square-o-down").addClass("fa-caret-square-o-up");
//        $(this).parent().parent().parent().children(".box-content").css("display", "none");
//    }
//});
$(".box-head").on("click", function () {
    if ($(this).parent().children(".box-content-pd").css("display") == "none") {
        $(this).children().children().children("i").removeClass("fa-caret-square-o-up").addClass("fa-caret-square-o-down");
        $(this).parent().children(".box-content-pd").css("display", "block");
    } else if ($(this).parent().children(".box-content-pd").css("display") == "block") {
        $(this).children("i").removeClass("fa-caret-square-o-down").addClass("fa-caret-square-o-up");
        $(this).parent().children(".box-content-pd").css("display", "none");
    }

    if ($(this).parent().children(".box-content").css("display") == "none") {
        $(this).children().children().children("i").removeClass("fa-caret-square-o-up").addClass("fa-caret-square-o-down");
        $(this).parent().children(".box-content").css("display", "block");
    } else if ($(this).parent().children(".box-content").css("display") == "block") {
        $(this).children().children().children("i").removeClass("fa-caret-square-o-down").addClass("fa-caret-square-o-up");
        $(this).parent().children(".box-content").css("display", "none");
    }
});
