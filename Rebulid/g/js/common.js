function showMessage(str) {
    var a = "<div class='say'>" + str + "</div>"
    $("body").children().first().prepend(a);
    setTimeout(clearSay, 2000);
}
function clearSay() {
    $(".say").remove();
}