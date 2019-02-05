var express = require('express');
var router = express.Router();
var multer = require('multer');

var storage = multer.diskStorage({
    destination: function (req, file, cb) {
      cb(null, '../uploads')
    },
    filename: function (req, file, cb) {
      cb(null, file.fieldname + '-' + Date.now())
    }
  })
   
  var upload = multer({ storage: storage })

var wine_controller = require('../controllers/wine.controller');

router.get('/', wine_controller.list);
router.post('/create', wine_controller.create);
router.get('/:id', wine_controller.details);
module.exports = router;