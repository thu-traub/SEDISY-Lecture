const net = require('net');

const server = net.createServer((socket) => {
    socket.on('data', (data) => {
        const msg = data.toString();
        console.log(msg);
    });
    socket.on('end', () => {
        server.close();
      });    
});

server.listen(12345, '0.0.0.0', () => {
    console.log("TCP javaScript server: waiting for connections");
});
