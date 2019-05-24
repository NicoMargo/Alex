$(document).ready(function () {
    $(".btn").click(function () {
        let Index = $(this).attr("id");        
        $.ajax({
            type: "POST",
            url: url,
            data: { id: Index },             
            success: function (DataJsonClient) {
                var Data = JSON.parse(DataJsonClient);
                alert(Data.Name);
            },
            error: function () {
                alert("ERROR");
            }
        });
    });


    $("#Submit").click(function () {
        var prueba = 333;
        $.ajax({
            type: "POST",
            url: urlUpdate,
            data: { Data: prueba },
            success: function (DataJsonClient) {
                var Data = JSON.parse(DataJsonClient);
                alert(Data.Name);
            },
            error: function () {
                alert("ERROR");
            }
        });
    });
});