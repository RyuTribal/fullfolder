var express = require('express');
var bodyParser = require('body-parser');
var PORT = process.env.PORT || 4242;
var app = express();

app.set('views', __dirname + '/views');
app.set('view engine', 'jade');

app.use(bodyParser.json());
app.use(bodyParser.urlencoded({extended: false}));

app.use('/', express.static(__dirname + '/www'));

app.get('/', function(req,res){
    res.render('index', {messages: ''});
});

app.listen(PORT, function(){
    console.log('Server up and running');
});