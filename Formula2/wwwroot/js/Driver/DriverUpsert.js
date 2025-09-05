$("#btnSave").on("click", function () {
    var driver = {
        name: $('#Name').val(),
        description: $('#Description').val()
    }

    var formData = new FormData();

    formData.append('driver', JSON.stringify(driver));

    $.ajax({
        type: "POST",
        url: "/Driver/CreateDriver",
        data: formData,
        processData: false,
        contentType: false,
        success: function (response) {
            window.location.href = "/Driver/Index";
        }
    })
});