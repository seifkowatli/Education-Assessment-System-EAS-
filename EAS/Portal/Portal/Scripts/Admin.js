﻿// Add New User (Register)



// if you dont log in !!you Be referred to login page 
//var accessToken = sessionStorage.getItem('accessToken');
//if (accessToken== null)
//    window.location = "http://localhost:46253/";

function Close_Alert_Div() {

    $('#successText').hide();
    $('#errortxt').hide();
}

//for generate randomPassword
function randomPassword(length) {
    var chars = "abcdefghijklmnopqrstuvwxyz1234567890";
    var chars2 = "!@#$%^&*()-+<>";
    var chars3 = "ABCDEFGHIJKLMNOP"
    var number = "1234567890";
    var pass = "";
    for (var x = 0; x < length; x++) {
        var i = Math.floor(Math.random() * chars.length);
        pass += chars.charAt(i);
        var i = Math.floor(Math.random() * chars2.length);
        pass += chars2.charAt(i);
        var i = Math.floor(Math.random() * chars3.length);
        pass += chars3.charAt(i);
        var i = Math.floor(Math.random() * number.length);
        pass += number.charAt(i);

    }
    return pass;
}


$(document).ready(function () {

    $('#successText').hide();
    $('#errortxt').hide();

    $('#btnRegister').click(function () {


        var Random_Password = randomPassword(4);
        console.log(Random_Password);
       

   
        $.ajax({
            url: 'http://localhost:2199/api/account/register',
            method: 'POST',
            headers: { 'Authorization': 'Bearer ' + sessionStorage.getItem('accessToken') },
            data: {
                UserName: $('#TextUserName').val(),
                Phone: $('#TextPhone').val(),
                Email: $('#TextEmail').val(),
                UserRole: $('#TextRole').find(":selected").text(),
                password: Random_Password,
                confirmpassWord: Random_Password,
                F_Name: $('#F_Name').val(),
                L_Name: $('#L_Name').val(),

            },
            success: function () {

                $('#successText').show('fade');


            },
            
            error: function (jqXHR) {
                $('#P_error').text(jqXHR.responseText);
                $('#errortxt').show('fade');
            }



        });

    });




});

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Add New Course///////

$(document).ready(function () {


    //Get Teacher ID after Admin select Teacher 
    function Get_Teacher_ID() {
        var Teacher_id;

        $("#teacher_select").change(function () {
            var Teacher_id = $(this).children(":selected").attr("id");
            console.log(Teacher_id);
        });
    }



    
//Get Teachers
    function Get_Teachers() {

        $.ajax({
            url: 'http://localhost:2199/api/Admin/Get_Teachers',
            method: 'Get',
            headers: { 'Authorization': 'Bearer ' + sessionStorage.getItem('accessToken') },


            success: function (data) {

                $.each(data, function (i, item) {
                    $('#teacher_select').append($('<option>', {
                        id: item.UserId,
                        text: item.F_Name + " "+item.L_Name
                    }));
                })


            },


        });
    }



    //Add more than topic
   
    var max_fields = 10; //maximum input field allowed
    var fields = $(".fields"); //Fields
    var add_button = $("#add_field"); //Add button

    var x = 1; //initlal text box count
    $(add_button).click(function (e) { //on add input button click
        e.preventDefault(); //undo event
        if (x < max_fields) { //max input box allowed
            x++; //text box increment
            $(fields).append('<div><input class="form-control" type="text"  name="" id=text' + x + '><a href="#" class="remove_field">×</a></div>'); //add input box
            console.log(x);
        }
    });

    //remove topic
    $(fields).on("click", ".remove_field", function (e) { //user click on remove text
        e.preventDefault();
        $(this).parent('div').remove(); x--;
    });




   


    //request 
      Get_Teachers();

});
function Add_Course() {


    //Add Course{Name ,Credit Hour, Description}
    var New_Course = {};

    New_Course['Course_Name'] = $('#Course_Name').val();
    New_Course['Credit_Hours'] = $("#Credit_Hours option:selected").text();
    New_Course['Course_Description'] = $('#Course_Description').val();

    var Course_Teacher = {};
    Course_Teacher['Teacher_ID'] = $('#teacher_select').children(":selected").attr("id");
    Course_Teacher['Semester'] = $('#Semester_id').val();

      

    $.ajax({


        type: "Post",
        data: JSON.stringify(New_Course),
        url: "http://localhost:2199/api/Teacher/Add_New_Question",
        contentType: "application/json",
        headers: { 'Authorization': 'Bearer ' + sessionStorage.getItem('accessToken') },

        success: function (response) {
            $.ajax({

                type: "Post",
                data: JSON.stringify(New_Course),
                url: "http://localhost:2199/api/Admin/Add_Course",
                contentType: "application/json",
                headers: { 'Authorization': 'Bearer ' + sessionStorage.getItem('accessToken') },

                success: function () {
                    //Add Course {Teacher, Semester}

                    $.ajax({



                        type: "Post",
                        data: JSON.stringify(Course_Teacher),
                        url: "http://localhost:2199/api/Admin/Add_Course_Teacher",
                        contentType: "application/json",
                        headers: { 'Authorization': 'Bearer ' + sessionStorage.getItem('accessToken') },
                        success: function () {

                            $('#successText').show('fade');


                        },



                    })
                },


            })


        },
        error: function (jqXHR) {
            $('#P_error').text(jqXHR.responseText);
            $('#errortxt').show('fade');

        }
       
    });




    console.log(New_Course);

}

    
    
    
    
