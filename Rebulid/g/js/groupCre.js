
$(function () {

    $(".btn").on("click", function () {
        var a = $("#name").val();
        var b = $("#tip").val();


        var str = "";
        var booft = true;
        if (a.trim() == "") {
            str = "项目名称不能为空";
            booft = false;
        } else if (b.trim() == "") {
            str = "标签不能为空";
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
            'tip': $("#tip").val()
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
