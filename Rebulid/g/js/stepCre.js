
        $(function () {
            var ue = UE.getEditor('editor');
            $(".btn").on("click", function () {
                var a = $("#name").val();
                var b = UE.getEditor('editor').getContent();
                var booft = true;
                var str = "";
                var booft = true;
                if (a.trim() == "") {
                    str = "标题不能为空";
                    booft = false;
                } else if (b.trim() == "") {
                    str = "步骤不能为空";
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
