$(document).ready(function () {
    $(".EditBtn").click(function () {
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

        $.ajax({
            type: "POST",
            url: urlUpdate,
            data: {
                Surname: $("#modalSurname").val(),
                Name: $("#modalName").val(),
                dni: $("#modalDni").val(),
                email: $("#modelEmail").val(),
                Telephone: $("#modalTelephone").val(),
                Cellphone: $("#modalCellphone").val(),
                Town: $("#modelTown").val(),
                Address: $("#modelAddress").val(),
                Province: 1,
                Leter: $("#modelAppartment").val(),
                Number: $("#modelNumber").val(),
                Floor: $("#modelFloor").val()
            },
            success: function () {
                location.reload();
            },
            error: function () {
                alert("ERROR");
            }
        });
    });
});