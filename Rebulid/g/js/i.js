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
    } else {
        $(".opt").removeClass("ui-btn-active");
        $(".opt1").addClass("ui-btn-active");
    }
})


var j = .8;
var f = 1.6;
var l = 2;
var c = document.getElementById("myCanvas");
var ctx = c.getContext("2d");

ctx.beginPath();
ctx.arc(20, 20, 15, 0, 2 * Math.PI);
ctx.lineWidth = 3;
ctx.strokeStyle = '#b5e6ff';
ctx.stroke();

ctx.beginPath();
ctx.arc(20, 20, 15, 0, j * Math.PI);
ctx.lineWidth = 3;
ctx.strokeStyle = '#ff494a';
ctx.stroke();

ctx.beginPath();
ctx.arc(65, 20, 15, 0, 2 * Math.PI);
ctx.lineWidth = 3;
ctx.strokeStyle = '#b5e6ff';
ctx.stroke();
ctx.beginPath();
ctx.arc(65, 20, 15, 0, f * Math.PI);
ctx.lineWidth = 3;
ctx.strokeStyle = '#ff494a';
ctx.stroke();

ctx.beginPath();
ctx.arc(110, 20, 15, 0, l * Math.PI);
ctx.lineWidth = 3;
ctx.strokeStyle = '#b5e6ff';
ctx.stroke();
ctx.beginPath();
ctx.arc(110, 20, 15, 0, l * Math.PI);
ctx.lineWidth = 3;
ctx.strokeStyle = '#ff494a';
ctx.stroke();

ctx.fillStyle = "#000"
ctx.font = '1em 微软雅黑 ';
ctx.fillText('剑', 12, 25);
ctx.font = '1em 微软雅黑 ';
ctx.fillText('法', 57, 25);
ctx.font = '1em 微软雅黑 ';
ctx.fillText('灵', 102, 25);
