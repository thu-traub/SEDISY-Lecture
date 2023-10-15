const dgram = require('dgram');

const server = dgram.createSocket('udp4');

server.on('message', (msg, rinfo) => {
  console.log(msg.toString());
  server.close()
});

server.on('listening', () => {
  console.log("UDP JavaScript server: waiting for packets");
});

server.bind(12345, '0.0.0.0');
