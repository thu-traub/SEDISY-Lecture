const net = require('net');

const client = new net.Socket();

client.connect(12345, '127.0.0.1', () => {
  client.write("Hello from TCP JavaScript client\r\n");
});

client.on('error', () => {  // we need this for c# server
});