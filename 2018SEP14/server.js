var http = require("http");

http.createServer(function (request, response){
    response.end('Ohh hi Mark');
}).listen(8080);

console.log('Server up and running on port 8080');