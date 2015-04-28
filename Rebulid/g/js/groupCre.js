
$(function () {

    vd.tags = ["name", "tip"];
    vd.rules = [{ required: true, minlength: 6 }, { required: true, number: true }];
    vd.messages = [{ required: "团队名称不能为空", minlength: "团队名称不能少于6个字符串" }, { required: "标签不能为空" }]
    vd.submit = function () {

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
    vd.bind("btn");
})
