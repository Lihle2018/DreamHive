$(document).ready(function () {
    $('#submitButton').click(function (event) {
        event.preventDefault();
        submitForm();
    });
});
function submitForm() {
    $.ajax({
        url: '/Controller/Index',
        type: 'POST',
        data: $('#ContactForm').serialize(),
        success: function (result) {
            // handle the response
        }
    });
}