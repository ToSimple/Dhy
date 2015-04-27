$(function () {

    $("#name").on("change", function () {
        p = 1;
        cP = 0;
        name = $("#name").val();
        $(".uplist").empty();
        getData();
    });

    $(document).on("click", ".friendItem", function () {
       
    })


})