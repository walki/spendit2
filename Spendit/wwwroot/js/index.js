$(document).ready(function () {

    var expenseForm = $("#expenseForm");
    expenseForm.hide();

    var editButton = $("#editButton");
    editButton.on("click", function () {
        console.log("Edit the Expense");
    });

    var expenseInfo = $(".expense-props li");
    expenseInfo.on("click", function () {
        console.log("You clicked on " + $(this).text());
    });

    var loginToggle = $("#loginToggle");
    var popupForm = $(".popup-form");

    loginToggle.on("click", function () {
        popupForm.fadeToggle(200);
    });



});
