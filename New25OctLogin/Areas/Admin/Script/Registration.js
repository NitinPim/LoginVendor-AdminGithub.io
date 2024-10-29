$(document).ready(function () {


    $('#btnSubmit').click(function () {
        if (checkValidation()) {
            $('#btnSubmit').text("processing");
            $('#btnSubmit').prop("disable", true);
            AddLoginDetails();
           
        }
    })



   function checkValidation(){
        var validfalg = true;
        if($("#username").val().trim() == ''){
            alert("Enter User Name");
            $("#username").focus();
            validfalg = false;
        }
        else if($("#password").val().trim() == ''){
            alert("Enter Password");
            $("#password").focus();
            validfalg = false;
        }
        else if (!$("input[name='UserRoleId']:checked").val()) { 
            alert("Please select a User Role ID");
            $("input[name='UserRoleId']").focus();
            validFlag = false;
        }
        return validfalg;

   }




   function AddLoginDetails() {
       var requestURL = "/Project/AddLoginDetails";
       var viewDetailsModel = getDetailsModel();

       $.ajax({
           url: requestURL,
           type: "POST",
           data: viewDetailsModel,
           success: function (response) {
               alert(response.message);
               window.location.reload();

           }, error: function () {

           }
       })

   }



   function getDetailsModel() {
       var viewDetailsModel = {
           LoginId: $('#hiddenId').val(),
           UserName:$('#username').val(),
           Password: $('#password').val(),
           UserRoleId: $("input[name='UserRoleId']:checked").val(),

           CreatedBy: 1,

       }
       return viewDetailsModel;
   }


})