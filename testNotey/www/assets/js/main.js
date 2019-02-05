$(document).ready(func());

/*function func(){
    var token = "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJfaWQiOiI1YzM1ZTg1YTE1ODJiMDFkODQ0ODFmOTMiLCJ1c2VyTmFtZSI6Ikthc3BlcyIsImVtYWlsIjoiaXZhbi5zZWRlbGtpbkBlZHUuaHVkZGluZ2Uuc2UiLCJwYXNzd29yZCI6IiQyYSQxMCREeFMyWTFOa29iVWRlVjJLdkI4UmQudnhHcFJHNHZSSmo1UmN0eTNRS1ZtakdGcGhQS3FWLiIsIl9fdiI6MH0.Mur9kOf81IK_LARWBnPsWy62m5pNTP16rskAbQbKmww";
    $.ajax({
        method: 'GET',
        url: 'https://api-notey.herokuapp.com/api/1.0/notes/',
        contentType: "application/json",
        headers: {
            'Authorization': token, //this is a global variable, make sure to save this during login call
        },
        success: function(result){
            console.log(result);
        },
        error: function(error) { 
            alert(error.errorMessage); 
        }
    });
}*/

/*function func(){
    //var token = "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJfaWQiOiI1YzM1ZTg1YTE1ODJiMDFkODQ0ODFmOTMiLCJ1c2VyTmFtZSI6Ikthc3BlcyIsImVtYWlsIjoiaXZhbi5zZWRlbGtpbkBlZHUuaHVkZGluZ2Uuc2UiLCJwYXNzd29yZCI6IiQyYSQxMCREeFMyWTFOa29iVWRlVjJLdkI4UmQudnhHcFJHNHZSSmo1UmN0eTNRS1ZtakdGcGhQS3FWLiIsIl9fdiI6MH0.Mur9kOf81IK_LARWBnPsWy62m5pNTP16rskAbQbKmww";
    var heading = "4cool";
    var content = "What's good bruv";
    var date = new Date();
    var dd = date.getDate();
    var mm = date.getMonth()+1; //January is 0!
    var yyyy = date.getFullYear();

    if(dd<10) {
        dd = '0'+dd
    } 

    if(mm<10) {
        mm = '0'+mm
    } 

    date = mm + '/' + dd + '/' + yyyy;
    noteData = {
        heading: heading,
        content: content,
        date: date

    };
    $.ajax({
        method: 'PATCH',
        url: 'https://api-notey.herokuapp.com/api/1.0/notes/update/5c3899d4fb6fc0600bde2a00',
        data: JSON.stringify(noteData),
        contentType: "application/json",
        success: function(result){
            console.log("Patched");
        },
        error: function(error) { 
            alert(error.errorMessage); 
        }
    });
}*/

function func(){
    userData = {
        userName: "RyuTribal1",
        email: "something@gmail.com",
        password: "kaspes17"

    };
    $.ajax({
        method: 'POST',
        url: 'https://api-notey.herokuapp.com/api/1.0/user/register',
        contentType: "application/json",
        data: JSON.stringify(userData),
        success: function(result){
            //do something ...
        },
        error: function(error){
            var err = JSON.parse(error.responseText);
            alert(err.errorMessage);
        }

    });
}
/*function func() {
    $.ajax({
        method: 'DELETE',
        url: 'https://api-notey.herokuapp.com/api/1.0/notes/delete/5c3899d4fb6fc0600bde2a00',
        contentType: "application/json",
        success: function(result){
            console.log("Deleted");
        },
        error: function(error) { 
            alert(error.errorMessage); 
        }
    });
}*/