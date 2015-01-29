var http = require('http');
var url = require('url');
function start(route, handle) {
    function onRequest(request, response) {
        var pathname = url.parse(request.url).pathname;
        console.log("Request for " + pathname + " received.");
        route(handle, pathname, response);
        //var content= route(handle, pathname);
        //response.writeHead(200, { 'Content-Type': 'text/plain' });
        //response.write(content);
        //response.end();
    }
    http.createServer(onRequest).listen(8888);
    console.log('Server running at http://127.0.0.1:8888');
}
exports.start = start;


//http.createServer(function (request, response) {
//    console.log("Request received");
//    response.writeHead(200, { 'Content-Type': 'text/plain' });
//    response.write('Hello World\n');
//    response.end();
//}).listen(8888);
//console.log('Server running at http://127.0.0.1:8888');