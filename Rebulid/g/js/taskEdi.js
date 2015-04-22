
$(function () {

    $(".btn").on("click", function () {
        var a = $("#name").val();
        var b = $("#b").val();
        var c = $("#d").val();

        var d = $("#a").val();
        var e = $("#b1").val();
        var f = $("#c").val();
        var g = $("#d1").val();


        var booft = true;
        var str = "";
        var booft = true;
        if (a.trim() == "") {
            str = "任务名称不能为空";
            booft = false;
        } else if (b.trim() == "") {
            str = "任务标签不能为空";
            booft = false;
        } else if (c.trim() == "") {
            str = "交易积分不能为空";
            booft = false;
        } else if (d.trim() == "") {
            str = "截至时间";
            booft = false;
        } else if (e.trim() == "") {
            str = "截至时间";
            booft = false;
        } else if (f.trim() == "") {
            str = "限定频次";
            booft = false;
        } else if (g.trim() == "") {
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
})
