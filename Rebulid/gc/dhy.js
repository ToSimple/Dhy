function timeStamp() {
    var time1 = new Date;
    // 比较各游览器的DOM运行速度。    
    for (var i = 0; i < 100; i++) {
        divs = document.createElement("div");
        divs.innerHTML = "第一重div<div>第二重div<div>第三重div</div></div>";
        document.body.appendChild(divs);
    }
    alert("耗时：" + (new Date - time1) + " 毫秒");
}