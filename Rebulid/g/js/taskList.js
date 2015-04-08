$.ajax({
    type: "get",
    url: "list.aspx",
    dataType: "json",
    data: { "index": 0 },
    beforeSend: function () {
        $(".load").css("display", "block");
    },
    success: function (data) {
        var str = '';
        $.each(data.list, function () {
            // alert(this.id + "-" + "-" + this.img + "-" + this.title);
            str += '<li class="ui-li-has-thumb ui-first-child"><a class="ui-btn ui-btn-icon-right ui-icon-carat-r" href="#"><img src="' + this.img + '" /><h2>' + this.id + '</h2><p>' + this.title + '</p></a></li>';
        })
        $(".uplist").append(str);
    },
    complete: function () {
        $(".load").css("display", "none");
    }
})
$(document).on("scrollstop", function () {
    //alert($(window).scrollTop());//这个方法是当前滚动条滚动的距离
    //alert($(window).height());//获取当前窗体的高度
    //alert($(document).height());//获取当前文档的高度
    //alert($(document).height()-$(window).height());
    var ws = $(window).scrollTop();
    var wh = $(window).height();
    var dh = $(document).height();
    //alert(dh - wh - ws);
    if (dh - wh - ws < 50) {
        var i = 1;
        $.ajax({
            type: "get",
            url: "list.aspx",
            dataType: "json",
            data: { "index": i },
            beforeSend: function () {
                $(".load").css("display", "block");
            },
            success: function (data) {
                var str = '';
                $.each(data.list, function () {
                    // alert(this.id + "-" + "-" + this.img + "-" + this.title);
                    str += '<li class="ui-li-has-thumb ui-first-child"><a class="ui-btn ui-btn-icon-right ui-icon-carat-r" href="#"><img src="' + this.img + '" /><h2>' + this.id + '</h2><p>' + this.title + '</p></a></li>';
                })
                $(".uplist").append(str);
            },
            complete: function () {
                $(".load").css("display", "none");
            }
        })
    }
});