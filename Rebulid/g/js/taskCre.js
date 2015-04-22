
$(function () {
    var ue = UE.getEditor('editor');

    $(".btn").on("click", function () {
        var a = $("#name").val();
        var b = $("#b").val();
        var c = $("#d").val();

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
            'prop':$("#prop").val(), 
            'name': $("#name").val(),
            'b': $("#b").val(),
            'd': $("#d").val(),
            'info':$("#info").val(),
            'editor': UE.getEditor('editor').getContent(),
            'montype': $("#montype").val(),
            'state':$("#state").val()
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
