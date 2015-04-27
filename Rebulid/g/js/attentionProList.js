var p = 1;//页码
var cP = 0;//检测页码
var lP = 0;//最后页码
var name = "";//搜索关键字
var str = "";//显示内容
var mode = "show";//显示模式
var dis = "none";//复选框display样式
var liCss = "";//li样式
getData();//初始化列表

$(function () {
    //搜索change事件
    $("#name").on("change", function () {
        p = 1;
        cP = 0;
        name = $("#name").val();
        $(".uplist").empty();
        getData();
    });

    //滚动条事件
    $(document).on("scrollstop", function () {
        //alert($(window).scrollTop());//这个方法是当前滚动条滚动的距离
        //alert($(window).height());//获取当前窗体的高度
        //alert($(document).height());//获取当前文档的高度
        //alert($(document).height()-$(window).height());
        var ws = $(window).scrollTop();
        var wh = $(window).height();
        var dh = $(document).height();
        //alert(ws/(dh -wh));
        if (ws / (dh - wh) >= 0.95)//到达底部100px时,加载新内容
        {
            if (cP < p && cP < lP) {
                getData();
                cP++;
            }
        }
    });

    //编辑
    $(document).on("click", "#editBtn", function () {
        mode = "edit";
        dis = "inline-block";
        liCss = "proItem";
        $(".lia").addClass("proItem");
        //显示复选框
        $(".bjcboxCss").css("display", "inline-block");
        //href失效
        $(".ah").attr("href", "#");
        //编辑按钮消失
        $("#editBtn").css("display", "none");
        //菜单显示
        $(".bjbtn").css("display", "inline-block");
    });

    //取消编辑
    $(document).on("click", ".qxbj", function () {
        mode = "show";
        dis = "none";
        liCss = "";
        $(".lia").removeClass("proItem");
        //隐藏复选框
        $(".bjcboxCss").css("display", "none");
        //href生效
        $(".ah").unbind("click");
        //显示编辑按钮
        $("#editBtn").css("display", "inline-block");
        //隐藏菜单
        $(".bjbtn").css("display", "none");
    });

    // 取消关注
    $(document).on("click", ".qxgz", function () {
        var sel = "";
        $("input[name='bjckbox']:checked").each(function () {
            sel += "," + $(this).attr("value");
        });
        if (sel == "") {
            alert("请选择取消项！");
        } else {
            if (confirm("确定要取消关注吗？")) {
                if (sel != "") sel = sel.substring(1);
                deleteAttention(sel);
            }
        }
    });

    //编辑模式下，选中一列数据选中checkbox
    $(document).on("click", ".lia", function () {
        if (mode == "show") {
            //href生效
            var projectId = $(this).children(".bjcboxCss").attr("value");
            $(".ah").attr("href", "projectInfo?projectId=" + projectId);
        }
        if (mode == "edit") {
            if ($(this).children("input").is(':checked')) {
                $(this).children("input").prop("checked", false);
            } else {
                $(this).children("input").prop("checked", true);
            }
        }
    });

});

//取消关注提交处理
function deleteAttention(selIds) {
    //表单数据
    var formData = {
        'selIds': selIds
    };
    //ajax提交表单
    $.ajax({
        url: "deleteAttention",
        data: formData,
        type: "post",
        dataType: "json",
        success: function (results) {
            if (results.mes.length > 0) {
                //显示提示信息
                showMessage(results.mes);
            }

            //成功
            if (results.mN == 1) {
                //清除取消的关注项
                var sIds = new Array();
                sIds = selIds.split(",");

                for (var i = 0; i < sIds.length; i++) {
                    $("#li_" + sIds[i]).remove();
                }
            }

        },
        error: function (error) {
            console.log(error);
        }
    });
}

// 显示模式
function setMode(mode) {
    p = 1;
    cP = 0;
    str = "";
    $(".uplist").empty();
    this.mode = mode;
    getData();
}

//获取列表数据
function getData() {
    $.ajax({
        type: "get",
        url: "attentionProjectsData",
        dataType: "json",
        data: {
            "curPage": p,
            "name": name
        },
        beforeSend: function () {
            if (p > 1) {
                $(".load").css("display", "block");
            }
        },
        success: function (results) {
            cP = results.current_page;
            lP = results.last_page;
            p = cP + 1;
            str = "";
            var default_img = {
                w: 80,
                h: 60,
                src: IMG_SERVER + 'img/default.jpg'
            }
            $.each(
                            results.data,
                            function () {
                                if (this[1].projectImgses
                                        && this[1].projectImgses.length) {
                                    var img_src = IMG_SERVER
                                            + 'userfiles/image/project/'
                                            + this[1].projectImgses[0].imgPath
                                            + IMG_RULE_1;
                                } else {
                                    var img_src = default_img.src;
                                }

                                str += '<li id="li_' + this[0].usersAttentionProjectsId + '" class="lia ui-li-has-thumb ui-first-child '
                                        + liCss
                                        + '"><input type="checkbox" class="bjcboxCss" name="bjckbox" value="'
                                        + this[0].usersAttentionProjectsId
                                        + '" style="display:'
                                        + dis
                                        + '"/><a class="ah ui-btn ui-btn-icon-right ui-icon-carat-r" data-ajax="false"><img src="'
                                        + img_src
                                        + '" /><h2>'
                                        + this[1].name
                                        + '</h2><p>'
                                        + this[1].addtime
                                        + '</p></a></li>';

                            })
            $(".uplist").append(str);
        },
        complete: function () {
            $(".load").css("display", "none");
            $(".firstLoad").css("display", "none");
        }
    });
}
