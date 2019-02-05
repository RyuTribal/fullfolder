var express = require('express');
var app = express();
var error = "Error 404";
var url = window.location.pathname;

if(url = '/'){
    app.get('/', function(req,res){
        res.send('Welcome to my web server');
    });
}

else{
    error;
}

var server = app.listen(8088, function(){
    var host = server.address().address;
    var port = server.address().port;

    console.log ('server started, listening on port 8088');
});