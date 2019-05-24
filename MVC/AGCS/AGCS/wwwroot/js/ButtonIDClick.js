$(document).ready(function () {
    $(".imageABM").click(function () {
        let Index = $(this).attr("id");
        $.ajax({
            type: "POST",
            url: url,
            data: { id: Index },
            success: function (DataJsonClient) {
                var Data = JSON.parse(DataJsonClient);
                $("#modalSurname").val(Data.Surname);
                $("#modalName").val(Data.Name);
                $("#modalDni").val(Data.Dni);
                $("#modelEmail").val(Data.Email);
                $("#modalTelephone").val(Data.Telephone);
                $("#modalCellphone").val(Data.Cellphone);
                $("#modelTown").val(Data.Town);
                $("#modelAddress").val(Data.Address);
                $("#modelAppartment").val(Data.Leter);
                $("#modelNumber").val(Data.Number);
                $("#modelFloor").val(Data.Floor);
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
                Surname: $("#modalSurnameC").val(),
                Name: $("#modalNameC").val(),
                dni: $("#modalDniC").val(),
                email: $("#modelEmailC").val(),
                Telephone: $("#modalTelephoneC").val(),
                Cellphone: $("#modalCellphoneC").val(),
                Town: $("#modelTownC").val(),
                Address: $("#modelAddressC").val(),
                Province: 1,
                Leter: $("#modelAppartmentC").val(),
                Number: $("#modelNumberC").val(),
                Floor: $("#modelFloorC").val()
            },
            success: function () {
                location.reload();
            },
            error: function () {
                alert("ERROR");
            }
        });
    });

    $(".w-50").click(function () {
        let Index = $(this).attr("id");
         $("#confirm").click(function () {
            $.ajax({
                type: "DELETE",
                url: urlDelete,
                data: { id: Index },
                success: function () {
                    location.reload();
                },
                error: function () {
                    alert("ERROR");
                }
            });
        });
    });

        $("#newClient").click(function () {
            $.ajax({
                type: "POST",
                url: urlCreate,
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