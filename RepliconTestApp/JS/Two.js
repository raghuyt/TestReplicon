$(document).ready(function () {
    $("#btnFactorial").on("click", function () {
        cleartxt();
        var Fnumber = $("#txtno").val();
        if ($.isNumeric(Fnumber)) {
            $.ajax({
                type: "POST",
                url: "/Home/FactorialNumber",
                data: {
                    Fnumber: Fnumber
                },
                success: function (data, status, jqXHR) {
                    var serverData = data.data;
                    if (data.code == 0) {
                        $("#lblRecursionVal").text(serverData.recursionStr);
                        $("#lblIterationVal").text(serverData.IterationStr); 
                        $("#outputTab").show();
                    } else {
                        $("#error_msg").text(serverData.errorMsg);
                    }
                }
            });
        } else {
            $("#error_msg").text("Please enter valid number !!");
        }
    });

});

function cleartxt() {
    $("#outputTab").hide();
    $("#error_msg").empty();
    $("#lblRecursionVal").empty();
    $("#lblIterationVal").empty();
}