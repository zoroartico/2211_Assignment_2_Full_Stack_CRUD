$(document).ready(function () { //outputs (###) ###-####
    $('#phoneInput').on('input', function () {
        //removes non-numerics
        var number = $(this).val().replace(/[^\d]/g, '')
        if (number.length == 10) {
            //applies format (###) ###-#### when total digits becomes 10
            number = number.replace(/(\d{3})(\d{3})(\d{4})/, "($1) $2-$3");
        }
        //returns input to be either (###) ###-#### if 10 digits long
        //else to bare digits to disallow non-numeric typing 
        $(this).val(number);
    });
});