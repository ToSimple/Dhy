

$(function () {
    $(".btn").on("click", function () {
        var a = $("#a").val();
        var b = $("#b").val();
        var c = $("#c").val();
        var d = $("#d").val();


        var booft = true;
        var str = "";
        var booft = true;
        if (a.trim() == "") {
            str = "开始时间";
            booft = false;
        } else if (b.trim() == "") {
            str = "截至时间";
            booft = false;
        } else if (c.trim() == "") {
            str = "限定频次";
            booft = false;
        } else if (d.trim() == "") {
            str = "积分要求";
            booft = false;
        }
        if (!booft) {
            showMessage(str);
        }
        else {
            submit();
        }
    })

    function submit() {
        //表单数据
        var formData = {
            'type:': $("#tp").val(),
            'prop': $("#prop").val(),
            'name': $("#name").val(),
            'b': $("#b").val(),
            'd': $("#d").val(),
            'info': $("#info").val(),
            'montype': $("#montype").val(),
            'state': $("#state").val()
        };

        //ajax提交
        $.ajax({
            url: "user/userLogin",
            data: formData,
            type: "post",
            dataType: "json",
            success: function (results) {
                if (results != null) {
                    if (results.mes.length > 0) {
                        showMessage(results.mes);
                    }

                    if (results.locationUrl.length > 0)
                    { window.location = results.locationUrl; }
                }
            }, error: function (error) {
                console.log(error);
            }
        });
    }


    //个人
    var one = true;//锁
    //绑定事件
    $("#obj1").on("click", function () {
        if (one) {
            //查看隐藏域是否有数据
            var hid = $("#pan").val();
            //如果有数据 ，获取数据填写表单
            if (hid != "") {
                var formData = {
                    'userIds': hid
                };
                $.ajax({
                    url: "taskCreSec.aspx",
                    data: formData,
                    type: "get",
                    dataType: "json",
                    beforeSend: function () {
                        $(".dg-load").css("display", "block");
                        one = false;
                    },
                    success: function (results) {
                        $(".dg-load").css("display", "none")
                        dialogpan(results);
                        showOrClosePan();
                    },
                    complete: function () {
                        $(".dg-load").css("display", "none");
                        one = true;
                    }
                });
            } else {
                //隐藏域为空，加载空表单
                showOrClosePan();
            }

        }
    });
    //组装选中checked的标签
    function dialogpan(results) {
        //results有值，生成选中对象标签
        if (results != undefined) {
            var str = "";
            $.each(results.users, function () {
                str += '<div class="dia-conItem dia-pan">';
                str += '<input type="checkbox" data-role="none" value="' + this.id + '" checked="checked" >' + this.name;
                str += '</div>';
            });
            $(".dia-pan-con").html(str);
        }
    }
    //组装未选择的标签 在加载列表开头 搜索用到 
    function dialogpanNoChecked(results) {
        //results有值，生成选中对象标签
        if (results != undefined) {
            var str = "";
            $.each(results.users, function () {
                str += '<div class="dia-conItem dia-pan">';
                str += '<input type="checkbox" data-role="none" value="' + this.id + '" >' + this.name;
                str += '</div>';
            });
            $(".dia-pan-con").prepend(str);
        }
    }
    //显示还是隐藏模拟窗口
    function showOrClosePan() {
        if ($(".dg-pan").css("display") == "none") {
            $("#searchper").val("");
            $(".dg-pan").css("display", "block");
        } else {
            $(".dg-pan").css("display", "none");
        }
    }
    //单击列表一行，选中checked
    $(document).on("click", ".dia-pan", function () {
        var a = $(this).children("input").prop("checked");
        $(this).children("input").prop("checked", !a);
    });
    //关闭按钮
    $(".close-dia").on("click", function () {
        var items = $(".dia-pan > input:checkbox");
        var pd = false;
        //遍历每个对象，如果未选中则删除dom标签
        $.each(items, function () {
            if (this.checked) {

                pd = true;
            }
        });
        if ($("#obj1").prop("checked")) {
            $("#obj1").prop("checked", false);
            $("#obj1").parent().children().first().removeClass("ui-checkbox-on").addClass("ui-checkbox-off");
        } else {
            $("#obj1").prop("checked", true);
            $("#obj1").parent().children().first().removeClass("ui-checkbox-off").addClass("ui-checkbox-on");
        }
        showOrClosePan();
    });
    //选定按钮
    $(".close-pan").on("click", function () {
        showOrClosePan();
        var items = $(".dia-pan > input:checkbox");
        var pd = false;
        var str = "";
        //遍历每个对象，如果未选中则删除dom标签
        $.each(items, function () {
            if (this.checked) {
                str += this.value + ",";
                pd = true;
            } else {
                this.parentNode.parentNode.removeChild(this.parentNode);
            }
        });


        if (str.lastIndexOf(",") == (str.length - 1)) {
            str = str.substr(0, str.length - 1);
        }
        $("#pan").val(str);
        if (!pd) {
            $("#obj1").prop("checked", false);
            $("#obj1").parent().children().first().removeClass("ui-checkbox-on").addClass("ui-checkbox-off");
        } else {
            $("#obj1").prop("checked", true);
            $("#obj1").parent().children().first().removeClass("ui-checkbox-off").addClass("ui-checkbox-on");
        }

    });
    //搜索
    $("#searchper").on("change", function () {
        var formData = {
            'name': $(this).val()
        };
        $.ajax({
            url: "taskCreSec.aspx",
            data: formData,
            type: "get",
            dataType: "json",
            success: function (results) {
                dialogpanNoChecked(results);
            },
        });
    });

    //团队
    var two = true;//锁
    //绑定事件
    $("#obj2").on("click", function () {
        if (two) {
            //查看隐藏域是否有数据
            var hid = $("#tuan").val();
            //如果有数据 ，获取数据填写表单
            if (hid != "") {
                var formData = {
                    'userIds': hid
                };
                $.ajax({
                    url: "taskCreSec.aspx",
                    data: formData,
                    type: "get",
                    dataType: "json",
                    beforeSend: function () {
                        $(".dg-load").css("display", "block");
                        two = false;
                    },
                    success: function (results) {
                        $(".dg-load").css("display", "none")
                        dialogTuan(results);
                        showOrClosetuan();
                    },
                    complete: function () {
                        $(".dg-load").css("display", "none");
                        two = true;
                    }
                });
            } else {
                //隐藏域为空，加载空表单
                showOrClosetuan();
            }

        }
    });
    //组装选中checked的标签 初始加载用到
    function dialogTuan(results) {
        //results有值，生成选中对象标签
        if (results != undefined) {
            var str = "";
            $.each(results.users, function () {
                str += '<div class="dia-conItem dia-tuan">';
                str += '<input type="checkbox" data-role="none" value="' + this.id + '" checked="checked" >' + this.name;
                str += '</div>';
            });
            $(".dia-tuan-con").html(str);
        }
    }
    //组装未选择的标签 在加载列表开头 搜索用到 
    function dialogTuanNoChecked(results) {
        //results有值，生成选中对象标签
        if (results != undefined) {
            var str = "";
            $.each(results.users, function () {
                str += '<div class="dia-conItem dia-tuan">';
                str += '<input type="checkbox" data-role="none" value="' + this.id + '" >' + this.name;
                str += '</div>';
            });
            $(".dia-tuan-con").prepend(str);
        }
    }
    //显示还是隐藏模拟窗口
    function showOrClosetuan() {
        if ($("#dg-tuan").css("display") == "none") {
            $("#searchper").val("");
            $("#dg-tuan").css("display", "block");
        } else {
            $("#dg-tuan").css("display", "none");
        }
    }
    //关闭按钮
    $("#close-tuan").on("click", function () {
       var eq= $("#tuan").val(str);
       if (eq!="") {
            $("#obj2").prop("checked", false);
            $("#obj2").parent().children().first().removeClass("ui-checkbox-on").addClass("ui-checkbox-off");
        } else {
            $("#obj2").prop("checked", true);
            $("#obj2").parent().children().first().removeClass("ui-checkbox-off").addClass("ui-checkbox-on");
        }
        showOrClosetuan();
    });
    //选定按钮
    $("#xd-tuan").on("click", function () {
        showOrClosetuan();
        var items = $(".dia-tuan > input:checkbox");
        var pd = false;
        var str = "";
        //遍历每个对象，如果未选中则删除dom标签
        $.each(items, function () {
            if (this.checked) {
                str += this.value + ",";
                pd = true;
            } else {
                this.parentNode.parentNode.removeChild(this.parentNode);
            }
        });


        if (str.lastIndexOf(",") == (str.length - 1)) {
            str = str.substr(0, str.length - 1);
        }
        $("#tuan").val(str);
        if (!pd) {
            $("#obj2").prop("checked", false);
            $("#obj2").parent().children().first().removeClass("ui-checkbox-on").addClass("ui-checkbox-off");
        } else {
            $("#obj2").prop("checked", true);
            $("#obj2").parent().children().first().removeClass("ui-checkbox-off").addClass("ui-checkbox-on");
        }

    });
    //搜索
    $("#searchTuan").on("change", function () {
        var formData = {
            'name': $(this).val()
        };
        $.ajax({
            url: "taskCreSec.aspx",
            data: formData,
            type: "get",
            dataType: "json",
            success: function (results) {
                dialogTuanNoChecked(results);
            },
        });
    });

})