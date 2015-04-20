
$(function () {
    var ue = UE.getEditor('editor');
    $(".btn").on("click", function () {
        var a = $("#name").val();
        var b = $("#tip").val();
        var c = $("#bq").val();
        var d = $("#zl").val();
        var e = $("#ly").val();
        var f = UE.getEditor('editor').getContent();
        var booft = true;
        var str = "";
        var booft = true;
        if (a.trim() == "") {
            str = "项目名称不能为空";
            booft = false;
        } else if (b.trim() == "") {
            str = "标签不能为空";
            booft = false;
        }
        else if (c.trim() == "") {
            str = "版权不能为空";
            booft = false;
        } else if (d.trim() == "") {
            str = "参考资料不能为空";
            booft = false;
        } else if (e.trim() == "") {
            str = "来源不能为空";
            booft = false;
        } else if (f.trim() == "") {
            str = "简介不能为空";
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
            'name': $("#name").val(),
            'tip': $("#tip").val(),
            'bq': $("#bq").val(),
            'zl': $("#zl").val(),
            'ly': $("#ly").val(),
            'editor': UE.getEditor('editor').getContent()
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
})
