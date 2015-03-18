
$("#cli").on("click", function () {
    $.ajax({
        url: "feedbackjson.aspx",
        type: "get",
        dataType: "json",
        success: function (data) {
            $.each(data, function (idx) {

                var back = "";
                back += '<div class="col-sm-12 pro-cc-box">  ';                                           ;
                back += '      <div class="col-sm-12 alldv"> ';
                back += '               <div class="col-sm-2 imgdv "> '; 
                back += '                <img src="img/noimg0.jpg" />  ';
                back += '                </div>                 ';
                back += '                <div class="col-sm-8"> ';
                back += '                    <div class="col-sm-6 media-heading">王同学</div> ';
                back += '                     <div class="col-sm-6 media-data">2014-12-30 12:12:21</div>';
                back += '                    <div class="col-sm-12 media-con">' + this.source + '</div>';
                back += '                </div>                    ';
                back += '                <div class="col-sm-12">   ';
                back += '                    <hr>                  ';
                back += '                </div>                    ';
                back += '            </div>                 ';
                back += '</div> ';
                $("#cli").before(back);
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