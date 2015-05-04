


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
$(".tip-min").on("click", function () {
    if ($(this).parent().parent().children(".box-content").css("display") == "none") {
        $(this).children("i").removeClass("fa-caret-square-o-up").addClass("fa-caret-square-o-down");
        $(this).parent().parent().children(".box-content").css("display", "block");
    } else {
        $(this).children("i").removeClass("fa-caret-square-o-down").addClass("fa-caret-square-o-up");
        $(this).parent().parent().children(".box-content").css("display", "none");
    }
})