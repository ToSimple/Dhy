$(function () {

    //瀑布流            
    var $container = $('#container');

    function showpubu() {
        $container.imagesLoaded(function () {
            $container.masonry({
                itemSelector: '.citem'
            });
        });
    }
    showpubu();
    //禁用浏览器m默认事件
    var control = navigator.control || {};
    if (control.gesture) {
        control.gesture(false);
    }

    //幻灯
    var div = $(".item");
    $.each(div, function () {
        var x1;
        var x2;
        this.ontouchstart = function (e) {
            var touch = e.touches[0];
            x1 = touch.clientX;
        };
        this.ontouchmove = function (e) {
            e.preventDefault();
            var touch = e.touches[0];
            x2 = touch.clientX;
            if (x2 - x1 > 15) {
                $('.carousel').carousel('prev');
            } else if (x2 - x1 < -15) {
                $('.carousel').carousel('next');
            }
        };
    });

    //工具导航条
    var ul = $(".d_tool_ul")[0];
    var ux1;
    var ux2;
    var g = true;
    ul.ontouchstart = function (e) {
        var touch = e.touches[0];
        ux1 = touch.clientX;
    };
    ul.ontouchmove = function (e) {
        e.preventDefault();
        var touch = e.touches[0];
        ux2 = touch.clientX;
        var ad = $(".d_tool_ul").children();
        var hi = ad.eq(0).css("width");
        if (ux2 - ux1 < -15) {
            if (g) {
                g = false;
                ad.eq(0).animate({ paddingRight: hi, opacity: '0.4' }, "1000", function () {
                    ad.eq(0).removeClass("show");
                    $(".dian").before('<li>' + ad.eq(0).html() + '</li>');
                    ad.eq(0).remove();
                    ad.eq(3).css("width", hi).css("display", "block");
                    g = true;
                });
            }
        } else if (ux2 - ux1 > 15) {
            if (g) {
                g = false;
                ad.eq(2).animate({ paddingLeft: hi, opacity: '0.4' }, "1000", function () {
                    ad.eq(2).removeClass("show");
                    ad.eq(2).css("display", "none");
                    ad.eq(2).css("padding-left", 0);
                    ad.eq(2).css("opacity", 1);
                    ad.eq(0).before('<li class="show">' + ad.eq(5).html() + '</li>');
                    ad.eq(5).remove();
                    g = true;
                });

            }
        }
    };

    //加载数据
    var pageIndex = 1;//页数
    var type = "cool"//项目类型
    $(document).on("click", ".d_tool_ul li", function () {
        if (!$(this).hasClass("dian")) {
            $(".d_tool_ul li").removeClass("active");
            $(this).addClass("active");
            type = $(this).attr("id");
            pageIndex = 1;
            $container.masonry('remove', $("#container .citem"));
            loo();
        }
    });
    //ajax列表加载
    function loo() {
        $.ajax({
            type: "get",
            url: "prolist.aspx",
            dataType: "json",
            data: { "pageIndex": pageIndex, "type": type },
            beforeSend: function () {
                $(".load").css("display", "block");
            },
            success: function (data) {
                var elem;
                var elems = [];
                $.each(data.list, function () {
                    var str = '';
                    elem = document.createElement('div');
                    str += '<a href="javascript:;">                                                         ';
                    str += '    <div class="citem">                                                         ';
                    str += '        <img src="http://i.imgur.com/VWfCPYx.jpg">                              ';
                    str += '        <div class="c_info">                                                    ';
                    str += '            <div class="proName">奥创人工智能 </div>                            ';
                    str += '            <div class="clear"></div>                                           ';
                    str += '            <div class="c_i_con">                                               ';
                    str += '                <div class="tips">                                              ';
                    str += '                    <div class="tip">                                           ';
                    str += '                        <div class="t_con">创客</div>                           ';
                    str += '                        <div class="arrow-right"></div>                         ';
                    str += '                    </div>                                                      ';
                    str += '                    <div class="tip">                                           ';
                    str += '                        <div class="t_con">创客</div>                           ';
                    str += '                        <div class="arrow-right"></div>                         ';
                    str += '                    </div>                                                      ';
                    str += '                    <div class="tip">                                           ';
                    str += '                        <div class="t_con">创客空</div>                         ';
                    str += '                        <div class="arrow-right"></div>                         ';
                    str += '                    </div>                                                      ';
                    str += '                    <div class="tip">                                           ';
                    str += '                        <div class="t_con">创客间创客的得得得得</div>           ';
                    str += '                        <div class="arrow-right"></div>                         ';
                    str += '                    </div>                                                      ';
                    str += '                </div>                                                          ';
                    str += '            </div>                                                              ';
                    str += '            <img src="img/c76b563f38453d44f35faeff595100acb87e0235.png" />';
                    str += '            <div class="name">John Raymons</div>                                ';
                    str += '        </div>                                                                  ';
                    str += '        <div class="c_tj">                                                      ';
                    str += '            <div class="c_tjnum"><i class="fa fa-eye">172</i></div>             ';
                    str += '            <div class="c_tjnum"><i class="fa fa-users">34</i></div>            ';
                    str += '            <div class="c_tjnum"><i class="fa fa-heart">210</i></div>           ';
                    str += '        </div>                                                                  ';
                    str += '    </div>                                                                      ';
                    str += '</a> ';
                    elem.innerHTML = str;
                    elems.push(elem);
                });
                $container.append(elems).masonry('appended', elems);
                showpubu();
                pageIndex++;
            },
            complete: function () {
                $(".load").css("display", "none");
                loding = true;
            }
        });
    };
    //滚动条事件
    var loding = true;;
    $(document).on("scroll", function () {
      
            $(".right_nav").css("display", "none");

        var ws = $(window).scrollTop();
        var wh = $(window).height();
        var dh = $(document).height();
        if (dh - wh - ws < 50 && loding) {
            loding = false;
            loo();

        }
    });
    //右侧导航
    $(".munes").on("click", function () {
        if ($(".right_nav").css("display") == "none") {
            $(".right_nav").css("display", "block");
            $(".right_nav").animate({ width: '44%' }, "800");
        } else {
            $(".right_nav").animate({ width: '0' }, "800", function () {
                $(".right_nav").css("display", "none");
            });

        }
    })
})
