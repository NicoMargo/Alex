$(document).ready(function () {
    $(".btn").click(function () {
        let Index = $(this).attr("id");
        $.ajax({
            method: "POST",
            url: url,
            data: { id: Index }, 
            success: function (msg) { alert("hola"); },
            error: function (result) {
                alert("ERROR ");
            }
        });
    });
});