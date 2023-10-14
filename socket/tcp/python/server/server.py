import socket

server_socket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)

server_address = ('localhost', 12345)
server_socket.bind(server_address)

server_socket.listen(5)

print("TCP python server: waiting for connections")
connection, client_address = server_socket.accept()

data = connection.recv(1024)
print(data.decode('utf-8'))

connection.close()
