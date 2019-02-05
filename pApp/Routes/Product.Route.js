var express = require('express');
var router = express.Router();

var Product_Controller = require('../Controllers/Product.Controller');

router.get('/test', Product_Controller.test);

module.exports = router;