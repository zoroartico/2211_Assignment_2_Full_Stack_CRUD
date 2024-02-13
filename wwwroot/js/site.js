$(document).ready(function () { //outputs (###) ###-####
    $('#phoneInput').on('input', function () {
        //removes non-numerics
        var number = $(this).val().replace(/[^\d]/g, '')
        if (number.length == 10) {
            //applies format (###) ###-####
            number = number.replace(/(\d{3})(\d{3})(\d{4})/, "($1) $2-$3");
        }
        $(this).val(number);
    });
});