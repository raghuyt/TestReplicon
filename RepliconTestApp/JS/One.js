$(document).ready(function () {

    $("#btnDispense").on("click", function () {      
        cleartxt();
        var amount = $("#txtAmount").val();
        if ($.isNumeric(amount)) {
            $.ajax({
                type: "POST",
                url: "/Home/DispenseAmount",
                data: {
                    amount: amount
                },
                success: function (data, status, jqXHR) {
                    var serverData = data.data;
                    if (data.code == 0) {
                        $("#note500").val(serverData.note500);
                        $("#note100").val(serverData.note100);
                        $("#note50").val(serverData.note50);
                        $("#note10").val(serverData.note10);
                        $("#note5").val(serverData.note5);

                        $("#outputTab").show();
                    } else {
                        $("#error_msg").text(serverData.errorMsg);
                    }
                }
            });
        } else {
            $("#error_msg").text("Please enter valid amount !!");
        }

    });
});

function cleartxt() {
    $("#outputTab").hide();
    $("#error_msg").empty();
    $("#note500").val('');
    $("#note100").val('');
    $("#note50").val('');
    $("#note10").val('');
    $("#note5").val('');
}