var express = require('express');
var path = require('path');
var app = express();

app.use(express.static('www'));

app.get('/', function(req,res){
    //res.send('Good shit fam');
    res.sendFile(__dirname+'/www/default.html');
});
app.get('/about', function(req,res){
    //res.send('Good shit fam');
    res.sendFile(__dirname+'/www/about.html');
});




app.listen(8080);
