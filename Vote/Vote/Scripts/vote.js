$(function () {
    $("#voteButton").click(function () {
        $.ajax({
            type: "post",
            url: "api/Vote",
            data: { hiking: "1" },
            success: function (data, textStatus, jqXHR) {
                alert("success");
            }
        });
    });
});