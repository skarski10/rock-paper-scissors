$(function() {
    $("form").submit(function(event) {
        event.preventDefault();
    });

    $("#form-submit").click(function() {
        if($("#options").val() !== "bad") {
            $("#game-options")[0].submit();
        }
    });
});
