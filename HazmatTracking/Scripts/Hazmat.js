//Allows the customer name to be submitted through the dropdown selection
$(function () {

    $("form").submit(function () {
        var dropDownText = $("#hazmat_Material option:selected").text();
        if (dropDownText.length > 0) {
            $("#hazmat_Material").attr("value", dropDownText);
        }
    });

    $("form").submit(function () {
        var dropDownText = $("#hazmat_Destination option:selected").text();
        if (dropDownText.length > 0) {
            $("#hazmat_Destination").attr("value", dropDownText);
        }
    });

    //Used for create pages. Image path is different than edit
    $(".dateCreate").datepicker({
        showOn: "button",
        buttonImage: "../Images/Calendar.gif",
        buttonImageOnly: true,
        buttonText: "Select date",
       defaultDate: '-1m'
    });

    //Used for edit pages. Image path is different than create
    $(".dateEdit").datepicker({
        showOn: "button",
        buttonImage: "../../Images/Calendar.gif",
        buttonImageOnly: true,
        buttonText: "Select date",
    });

    //Formated datepicker date for editing mode
    var date = new Date($("#hazmat_DateEdit").val());
    var month = date.getMonth() + 1;
    var year = date.getFullYear();
    var day = date.getDate();
    var formattedDate = month + '/' + day + '/' + year;
    $("#hazmat_DateEdit").val(formattedDate);
});
