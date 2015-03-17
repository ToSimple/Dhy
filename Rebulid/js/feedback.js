
$("#cli").on("click", function () {
    $.ajax({
        url: "feedbackjson.aspx",
        data: "",
        success: function (data) {
            $.each(data, function (idx) {
                var back = "";
                back += '<div class="col-sm-12 pro-cc-box">   ';
                back += '    <ul class="media-list">  ';
                back += '        <li class="media">   ';
                back += '            <div class="col-sm-12">  ';
                back += '                <div class="col-sm-2">   ';
                back += '                    <div class="col-sm-12">  ';
                back += '                        <img src="img/noimg0.jpg" />  ';
                back += '                    </div>             ';
                back += '                </div>                 ';
                back += '                <div class="col-sm-8"> ';
                back += '                    <div class="col-sm-6 media-heading">王同学</div> ';
                back += '                    <div class="col-sm-6">2014-12-30 12:12:21</div>  ';
                back += '                    <div class="col-sm-12 media-con">老师教的很不的很不的很不的很不的很不的很不老师教的很不的很不的很不的很不的很不的很不的很不的很的很不的很不的很不错，学习sada123123sds氛围我12312很喜欢！</div>';
                back += '                </div>                    ';
                back += '                <div class="col-sm-12">   ';
                back += '                    <hr>                  ';
                back += '                </div>                    ';
                back += '            </div>                 ';
                back += '        </li>    ';
                back += '    </ul> ';
                back += '</div> ';
                $(this).before(back);
            });
        }
    });

});
$(".weixing").on("mouseover", function () {
    $(".qrcode-g").css("display", "block");
});
$(".weixing").on("mouseout", function () {
    $(".qrcode-g").css("display", "none");
});
$("#feedbackForm").validate({
    rules: {
        feeCon: {
            required: true,
        }
    }, messages: {
        feeCon: {
            required: "不能为空",
        }
    },
    errorPlacement: function (error, element) {
        error.appendTo(element.next());
    }

});