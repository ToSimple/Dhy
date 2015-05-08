
        $(function () {

            //
            var one = true;//锁
            //绑定事件
            $("#obj1").on("click", function () {
                if (one) {
                    //隐藏域为空，加载空表单
                    showOrClosePan();
                }
            });
            //组装未选择的标签 在加载列表开头 seach用到 
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
                }); $(".dia-pan-con").empty();
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

                    }
                });
                $(".dia-pan-con").empty();


                if (str.lastIndexOf(",") == (str.length - 1)) {
                    str = str.substr(0, str.length - 1);
                }
                $("#pan").val(str);

            });

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
        })