var j = .8;
var f = 1.6;
var l = 2;
var c = document.getElementById("myCanvas");
var ctx = c.getContext("2d");

var img = new Image();
img.src = "../img/剑1.png";
img.onload = function () {
    ctx.drawImage(img, -20, -6, 99, 74);

    ctx.beginPath();
    ctx.arc(27, 30, 25, 0, 2 * Math.PI);
    ctx.lineWidth = 3;
    ctx.strokeStyle = '#b5e6ff';
    ctx.stroke();

    ctx.beginPath();
    ctx.arc(27, 30, 25, 0, j * Math.PI);
    ctx.lineWidth = 3;
    ctx.strokeStyle = '#ff494a';
    ctx.stroke();
}
var img1 = new Image();
img1.src = "../img/jian.jpg";
img1.onload = function () {
    ctx.drawImage(img1, 66, 8, 42, 42);
    ctx.beginPath();
    ctx.arc(87, 30, 25, 0, 2 * Math.PI);
    ctx.lineWidth = 3;
    ctx.strokeStyle = '#b5e6ff';
    ctx.stroke();
    ctx.beginPath();
    ctx.arc(87, 30, 25, 0, f * Math.PI);
    ctx.lineWidth = 3;
    ctx.strokeStyle = '#ff494a';
    ctx.stroke();
}
var img2 = new Image();
img2.src = "../img/灵3.png";
img2.onload = function () {
    ctx.drawImage(img2, 92, -20, 120, 99);
    ctx.beginPath();
    ctx.arc(147, 30, 25, 0, l * Math.PI);
    ctx.lineWidth = 3;
    ctx.strokeStyle = '#b5e6ff';
    ctx.stroke();
    ctx.beginPath();
    ctx.arc(147, 30, 25, 0, l * Math.PI);
    ctx.lineWidth = 3;
    ctx.strokeStyle = '#ff494a';
    ctx.stroke();

    ctx.fillStyle = "#000"
    //ctx.font = '1em 微软雅黑 ';
    //ctx.fillText('剑', 12, 25);
    //ctx.font = '1em 微软雅黑 ';
    //ctx.fillText('法', 57, 25);
    //ctx.font = '1em 微软雅黑 ';
    //ctx.fillText('灵', 102, 25);
}

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
})