$(function () {
    RefreshSquareTable();
});

function RefreshSquareTable() {
    $.ajax({
        type: "POST",
        url: "/Ajax/SquareTable",
        data: '{}',
        contentType: "application/json; charset=utf-8",
        dataType: "html",
        success: function (response) {
            $('#squareTable').html(response);
        },
        failure: function (response) {
            alert(response.responseText);
        },
        error: function (response) {
            alert(response.responseText);
        }
    });
}