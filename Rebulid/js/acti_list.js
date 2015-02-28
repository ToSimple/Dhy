(function () {

    var win = $(window);
    winW = win.width();

    // detect window width to set woo width & prj_card width.
    if (winW <= 480) {
        PROJ_CARD_WIDTH = winW / 2 - 20;
        WOO_WIDTH = PROJ_CARD_WIDTH + 10;
    } else if (winW > 480) {
        PROJ_CARD_WIDTH = 220;
        WOO_WIDTH = 230;
    }

    // set the preload prj cards' width.
    var cards = $('.prj_card');
    cards.width(PROJ_CARD_WIDTH);
    cards.each(function (idx, item) {
        var _ = $(item);
        var img_wrap = _.find('.img_wrap');
        var width = img_wrap.data('width');
        var height = img_wrap.data('height');
        img_wrap.height(_.width() / width * height);
    })

    ANALYZERESPONSE = [
		function (data) {
		    data = data;

		    var data = JSON.parse(data);


		    var has_more = false;
		    if (data.last_page > data.current_page) {
		        has_more = true;
		    }

		    WT.addData(data.data);

		    return [
				data.data,
				has_more,
				data.total
		    ]
		}
    ];

    RENDER = [
		function (proj_list) {
		    var back = '';

		    var default_img = {
		        w: 180,
		        h: 180,
		        src: STATIC + 'img/noimg1.jpg'
		    }


		    $.each(proj_list, function (idx) {
		        if (this.asset) {
		            var h = Math.floor(this.asset.height * PROJ_CARD_WIDTH / this.asset.width);
		            var img_src = IMG_SERVER + this.asset.url;
		        } else {
		            var h = Math.floor(default_img.h * PROJ_CARD_WIDTH / default_img.w);
		            var img_src = default_img.src;
		        }

		        back += '<div class="woo">';
		        back += '	<div class="prj_card shadow" style="width:' + PROJ_CARD_WIDTH + 'px">';
		        back += '		<div class="img_wrap" style="height:' + h + 'px">';
		        back += '			<a href="/proj/detail/' + this.id + '"><img srcd="' + img_src + '" alt="' + this.name + '" /></a>';
		        back += '		</div>';
		        back += '		<div class="info_wrap">';
		        back += '			<p class="fb"><a href="/courseInfo.html?courseId=">3D打印聚会</a></p>';
		        back += '<p>地点：北京天安门</p>';
		        back += '<p>时间：2015-2-27</p>';
		        back += '<p>简介：3D打印技术帮助人们实现自己的闷响</p>';
		        back += '		</div>';
		        back += '		<div class="btn-group btn-group-lg btn-group-justified">';
		        back += "			<a class=\"btn btn-default\" href=\"user/ScoreRecordSave?courseId=" + this.courseId + "\" onclick='javascript:if(confirm(\"确定要报名吗?(提示：报名成功后将立即扣除积分)\")){return true;}else{return false;}' target=\"_blank\" role=\"button\"><i class=\"fa fa-users aic\">&nbsp;</i>报名</a> ";
		        back += '				<a class="btn btn-default" href="activities_info.html" role="button"><i class="fa fa-newspaper-o aic">&nbsp;</i>详细</a>';
		        back += '		</div>';
		        back += '	</div>';
		        back += '</div>';
		    })

		    return back;
		}
    ];

    var WT = (function () {
        var WT = {
            ulen: -1,
            init: function (a, b) {
                WT.analyzeResponse = a,
				WT.render = b,

                // 当前可见瀑布流的数据集合
				WT.masnUnits = {};
            },
            reset: function () {
                WT.ulen = -1,
				WT.masnUnits = {};
                WT.addData(FIRST_PAGE_ARR); // 先添加第一页数据
            },
            addData: function (data) {// 添加数据集合进当前可见瀑布流
                for (var i in data) {
                    data[i].idx = ++WT.ulen;
                    WT.masnUnits[data[i].id] = data[i];
                }
            }
        }
        return WT;
    })()

    WT.init(ANALYZERESPONSE, RENDER);

    $.Woo.WooTemp = WT;

}());

(function () {
    $(function () {
        $('<div id="mycontrols"><a href="javascript:;" id="gotop" class="shadow"><i class="fa fa-arrow-up"></i></a></div>').appendTo('body');

        var conf = {
            // "formprefix": '#woo-form-',
            "arrform": ['collect'],
            "arrsplit": '',
            "arrmasnw": WOO_WIDTH,
            "arrmargin": 10,
            "arrfmasnw": 0,
            "arrgap": 10,
            "gotop": '#gotop',
            "resize": true,
            "onScroll": function (tp) { }
        }

        $.Woo(conf);

        // sort
        $('#J_sortProj').children().click(function () {
            var _ = $(this);
            _.addClass('active').siblings().removeClass('active');
            var is_asc = _.data('asc');

            if (is_asc) {
                _.data('asc', 0);
                sort(_.data('sort'), 0); // desc
            } else {
                _.data('asc', 1);
                sort(_.data('sort'), 1); // asc
            }
            $('#woo-form-collect').attr('action', 'Default.aspx?');
            //$('#woo-form-collect').attr('action', '/proj/async_list?order='+_.data('sort')+'&p=');
            $(window).scrollTop(0);
            return false;
        });

        function sort(type, is_asc) {
            var masn = $.Woo.masn[0],
				colc = masn.colCount,
				colY = masn.$dom.data('colY'),
				minY, minI, left,
				munits = $.Woo.WooTemp.masnUnits,
				el,
				arru = [],
				$units = $('.woo:visible').not('.woo-f');

            for (var i = 0; i < colc; i++) {
                colY[i] = 0;
            }
            masn.screent = masn.screen = 0;


            for (el in munits) {
                arru.push({
                    "idx": munits[el].idx,
                    "difficulty": munits[el].difficulty,
                    "period": munits[el].period >> 0,
                    "created_at": parseInt(munits[el].created_at.replace(/-|:|\s/g, '')),
                    "fork": munits[el].forks_count >> 0,
                    "like": munits[el].likes_count >> 0
                })
            }

            // order
            if (is_asc) {
                arru.sort(function (a, b) {
                    if (a[type] >= b[type]) {
                        return 1;
                    } else {
                        return -1;
                    }
                });
            } else {
                arru.sort(function (a, b) {
                    if (a[type] <= b[type]) {
                        return 1;
                    } else {
                        return -1;
                    }
                });
            }



            for (var i = 0, l = arru.length; i < l; i++) {
                var $new = $units.eq(arru[i].idx),
					ht = $new.data('ht'),
					len = colc,
					ars = masn.prePlaceUnit($new, colY, colc);

                minY = ars[0],
				minI = ars[1],
				left = ars[2],
				ht = ars[3];

                $new.css({
                    "left": left,
                    "top": minY
                })
				.removeClass(function (i, cls) {
				    return 'woo-spcol ' + (cls.match(/(co|sc)\d+/ig) || []).join(' ')
				})
				.addClass('sc' + masn.screen + ' co' + minI);
            }
        }

        // clear pagin to clear data in WT
        $('.woo-paper').on('click', 'a', function () {
            var _ = $(this);
            if (!_.hasClass('woo-cur')) {
                $.Woo.WooTemp.reset();
            }
        })
    });
}());