

$(document).ready(function () {
    function validate(id,specialCondition) {
        if (specialCondition) {
            $("#modal" + id).addClass("validation_error");
            $("#msg" + id).removeClass("hidden");
        }
        else {
            $("#modal" + id).removeClass("validation_error");
            $("#msg" + id).addClass("hidden");
        }
        return specialCondition;
    }

    $(".imageABM").click(function () {
        let Index = $(this).attr("position");
        $.ajax({
            type: "POST",
            url: urlGetOne,
            data: { pos: Index },
            success: function (DataJsonClient) {
                var Data = JSON.parse(DataJsonClient);
                $("#modalUpdateSurname").val(Data.Surname);
                $("#modalUpdateName").val(Data.Name);
                $("#modalUpdateDni").val(Data.Dni);
                $("#modelUpdateEmail").val(Data.Email);
                $("#modalUpdateTelephone").val(Data.Telephone);
                $("#modalUpdateCellphone").val(Data.Cellphone);
                $("#modalUpdateTown").val(Data.Town);
                $("#modalUpdateAddress").val(Data.Address);
                $("#modalUpdateAppartment").val(Data.Leter);
                $("#modalUpdateNumber").val(Data.Number);
                $("#modalUpdateFloor").val(Data.Floor);
            },
            error: function () {
                alert("ERROR");
            }
        });
    });


    $("#UpdateSubmit").click(function () {
        $.ajax({
            type: "POST",
            url: urlUpdate,
            data: {
                Surname:   $("#modalUpdateSurname").val(),
                Name:      $("#modalUpdateName").val(),
                dni:       $("#modalUpdateDni").val(),
                email:     $("#modelUpdateEmail").val(),
                Telephone: $("#modalUpdateTelephone").val(),
                Cellphone: $("#modalUpdateCellphone").val(),
                Town:      $("#modelUpdateTown").val(),
                Address:   $("#modalUpdateAddress").val(),
                Province:  1,       
                Leter:     $("#modalUpdateAppartment").val(),
                Number:    $("#modalUpdateNumber").val(),
                Floor:     $("#modalUpdateFloor").val()
            },                      
            success: function () {
                location.reload();
            },
            error: function () {
                alert("ERROR");
            }
        });
    });

    $("deleteButton").click(function () {
        let Index = $(this).attr("position");
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
        valid = validate("CreateSurname", $("#modalCreateSurname").val() !== "");
        valid = valid && validate("CreateName", $("#modalCreateName").val() !== "");
        valid = valid && validate("CreateDni", $("#modalCreateDni").val() !== "" && $("#modalCreateDni").val() != 0);

        if (valid) {
            $.ajax({
                type: "POST",
                url: urlCreate,
                data: {
                    Surname: $("#modalCreateSurname").val(),
                    Name: $("#modalCreateName").val(),
                    dni: $("#modalCreateDni").val(),
                    email: $("#modalCreateEmail").val(),
                    Telephone: $("#modalCreateTelephone").val(),
                    Cellphone: $("#modalCreateCellphone").val(),
                    Town: $("#modalCreateTown").val(),
                    Address: $("#modalCreateAddressC").val(),
                    Province: 1,
                    Leter: $("#modelCreateAppartment").val(),
                    Number: $("#modelCreateNumber").val(),
                    Floor: $("#modelCreateFloor").val()
                },
                success: function () {
                    location.reload();
                },
                error: function () {
                    alert("ERROR");
                }
            });
        }
        else {
            if ($("#modalCreateName").val() === "") {
                $("#modalCreateName").addClass("validation_error");
            }
        }
    });
});