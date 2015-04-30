

var i = 1;
function loo(i) {
    $.ajax({
        type: "get",
        url: "prolist.aspx",
        dataType: "json",
        data: { "index": i },
        beforeSend: function () { 
            if (i != 1) {
                $(".load").css("display", "block");
            } else {
                $(".load").css("display", "none");
            }

        },
        success: function (data) {
            var str = '';
            $.each(data.list, function () {
                // alert(this.id + "-" + "-" + this.img + "-" + this.title);
                //str += '<li class="ui-li-has-thumb ui-first-child"><div style="position:absolute;left:0;height:80px;width:80px;text-align:center;line-height:80px;background-color:#c3c3c3;"><input type="checkbox"></div><a class="ui-btn ui-btn-icon-right ui-icon-carat-r listItem" href="proInfo.html" data-ajax="false"><img src="' + this.img + '" /><h2>' + this.id + '</h2><p>' + this.title + '</p><span class="ui-li-count col-red"><i class="fa fa-minus-circle"></i></span></a></li>';
                str += '<li class="ui-li-has-thumb ui-first-child proItem"><input type="checkbox" /><a class="ui-btn ui-btn-icon-right ui-icon-carat-r listItem" href="proInfo.html" data-ajax="false"><img src="' + this.img + '" class="itemImg" /><h2>' + this.id + '</h2><p>' + this.title + '</p><span class="ui-li-count col-red"><i class="fa fa-minus-circle"></i></span></a></li>';
            })
            $(".uplist").append(str);

            //$(".bj").on("click", function () {
            //    alert(1);
            //    $(this).html('<i class="fa fa-pencil-square-o"></i>&nbsp;取消编辑</a>').removeClass("bj").addClass("qxbj");               
            //    $(".listItem").animate({
            //        left: '80px'
            //    });
            //$(document).on("click", ".qxbj", function () {
            //    $(this).html('<i class="fa fa-pencil-square-o"></i>&nbsp;编辑</a>').removeClass("qxbj").addClass("bj");
            //    $(".listItem").animate({
            //        left: '0'
            //    });
            //});
            //$(".qxbj").one("click", function () {
            //    alert(2);
            //    $(this).html('<i class="fa fa-pencil-square-o"></i>&nbsp;编辑</a>').removeClass("qxbj").addClass("bj");
            //    $(".listItem").animate({
            //        left: '0'
            //    });
            //});


        },
        complete: function () {
            $(".load").css("display", "none");
            $(".firstLoad").css("display", "none");
        }
    });
}
loo(1);
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
        loo(i);
        i++;
    }
});

//function addButton() {
//    $(document).on('swipeleft', '.listItem', function () {
//        var a = $(this).html();
//        alert(typeof (a));
//        var b = '<a class="qxgz" style="display:inline-block;height:81px;line-height:81px;width:45%;background-color:#10ffff;text-align:center;">取消关注</a><a class="qx" style="text-align:center;display:inline-block;height:81px;line-height:81px;width:45%;background-color:#ffff10;">取消</a>';

//        $(this).html(b);
//        $(".qx").on("click", function () {
//            alert(c);
//            $(this).html(c);
//        })
//    });
//}




