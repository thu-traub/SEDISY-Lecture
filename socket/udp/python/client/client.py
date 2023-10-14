import socket

client_socket = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)

server_address = ('127.0.0.1', 12345)

message = "Hello from UDP python client\r\n"
client_socket.sendto(message.encode('utf-8'), server_address)

client_socket.close()
