var mongoose = require('mongoose');
var Schema = mongoose.Schema;

var WineSchema = new Schema({
    name: {type: String, required: true, max: 100},
    stars: {type : Number, required : true},
    country: {type: String, required: true, max: 80},
    color: {type: String, required: true, max: 20},
    
    grapes: [
        {type: String, required: true, max: 60}
    ],
    yearMade: {type: Number, required: true},
    region: {type: String, required: true, max: 100},
    price: {type: Number, required: true},
    articleNumber: {type: Number, required : true},
    img: { data: Buffer, contentType: String }
    
    
});

module.exports = mongoose.model('Wine', WineSchema);