import socket

client_socket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)

server_address = ('127.0.0.1', 12345)
client_socket.connect(server_address)

message = "Hello from TCP python client\r\n"
client_socket.sendall(message.encode('utf-8'))

client_socket.close()
