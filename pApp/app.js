var express = require('express');
var bodyParser = require('body-parser');


var app = express();

var product = require('./Routes/Product.Route');

var mongoose = require('mongoose');
var db_url = 'mongodb://dbAdmin:passw0rd@ds155663.mlab.com:55663/t4-papp';
mongoose.connect(db_url, {useNewUrlParser : true});
mongoose.Promise = global.Promise;
var db = mongoose.connection;
db.on('error', console.error.bind(console, 'MongoDB connection error: '));

app.use(bodyParser.json());
app.use(bodyParser.urlencoded({extended: false}));

app.use('/products', product);

app.listen('4242', function(){
    console.log('Server up and running');
});

