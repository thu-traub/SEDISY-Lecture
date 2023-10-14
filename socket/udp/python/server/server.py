import socket

server_socket = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)

server_address = ('localhost', 12345)
server_socket.bind(server_address)

print("UDP python server: waiting for packats")

data = server_socket.recv(1024)
print(data.decode('utf-8'))
