// Load the dgram module to create a udp client.
const dgram = require('dgram');

const message = "Hello from UDP JavaScript client";
const client = dgram.createSocket('udp4');

client.send(message, 12345, '127.0.0.1', (err) => {
  client.close();
});

