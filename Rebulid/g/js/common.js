
//验证规则
//this.rules{
//    required: false,
//    number: false,
//    digits: false,
//    equalTo: "#field",
//    maxlength: 0,
//    minlength: 0,
//}
////验证显示信息
//this.Message{
//    required: "不能为空",
//    number: "必须是数字",
//    equalTo: "填写的内容不一致",
//    maxlength: "长度不能大于" + this.rules.maxlength,
//    minlength: "长度不能小于" + this.rules.minlength,
//} 
function validate() {
    //参数模块
    //验证表单元素集
    this.tags = [];
    //验证表单元素规则集
    this.rules = [];
    //验证表单元素回馈信息集合
    this.messages = [];
    this.submit;
    //绑定触发按钮 元素id
    this.bind = function (btnId) {
        //验证表单元素集
        var tags = this.tags;
        //验证表单元素规则集
        tags.rules = this.rules;
        //验证表单元素回馈信息集合
        tags.message = this.messages;
        //验证通过后
        tags.submit = this.submit;
        //绑定触发
        $(document).on("click", "#" + btnId, function () {
            //通过ext参数控制是否退出大循环
            var ext = false;
            //循环表单元素集合
            $.each(tags, function (i, item) {
                //表单元素单元
                var tag = $("#" + item);

                if (ext == true) {
                    return false;
                } else {
                    //验证单元元素的规则
                    $.each(tags.rules[i], function (j, val) {
                        //判断非空
                        if (j == "required" && val == true) {
                            if (isNull(tag.val())) {
                                showMessage(tags.message[i].required);
                                ext = true;
                                return false;
                            }
                        }
                        //判断是否为数字
                        if (j == "number" && val == true) {
                            if (isNaN(tag.val())) {
                                showMessage(tags.message[i].number);
                                ext = true;
                                return false;
                            }
                        }
                        //判断不能小于
                        if (j == "minlength") {
                            if (tag.val().length < val) {
                                showMessage(tags.message[i].minlength);
                                ext = true;
                                return false;
                            }
                        }
                        //判断不能大于
                        if (j == "maxlength") {
                            if (tag.val().length > val) {
                                showMessage(tags.message[i].maxlength);
                                ext = true;
                                return false;
                            }
                        }
                        if (j == "equalTo") {
                            if (tag.val() != $("#" + val).val()) {
                                showMessage(tags.message[i].equalTo);
                                ext = true;
                                return false;
                            }
                        }

                    });
                }
            });

            if (!ext) {
                tags.submit();
            }
        });

    }
}
var vd = new validate();


//条件验证
function isNull(atr) {
    if (atr == undefined || atr.trim() == "") {
        return true;
    } else {
        return false;
    }
}


//提示窗口
function showMessage(str) {
    var a = "<div class='say'>" + str + "</div>"
    $("body").children().first().prepend(a);
    setTimeout(clearSay, 2000);
}
function clearSay() {
    $(".say").remove();
}


//例子
//<label>账号</label>
//<input id="aaa" />
//<label>密码</label>
//<input id="bbb" />
//<button id="btn">提交</button>
//<script src="../jqjm/jquery.min.js"></script>
//<script src="common.js"></script>
//<script>

//    vd.tags = ["aaa", "bbb"];
//vd.rules = [{ required: true, minlength: 6 }, { required: true, number: true }];
//vd.messages = [{ required: "账号不能为空", minlength: "账号不能少于6个字符串" }, { required: "密码不能为空", number: "密码必须是数字" }]
//vd.submit = function () {
//    alert("表单已经提交");
//    //$.ajax({
//    //    url: "user/userLogin",
//    //    data: formData,
//    //    type: "post",
//    //    dataType: "json",
//    //    success: function (results) {
//    //        if (results != null) {
//    //            if (results.mes.length > 0) {
//    //                showMessage(results.mes);
//    //            }

//    //            if (results.locationUrl.length > 0)
//    //            { window.location = results.locationUrl; }
//    //        }
//    //    }, error: function (error) {
//    //        console.log(error);
//    //    }
//    //});
//}
//vd.bind("btn");