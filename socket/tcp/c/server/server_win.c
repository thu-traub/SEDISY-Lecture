#include <stdio.h>
#include <winsock2.h>

#pragma comment(lib, "ws2_32.lib")

int main() {
    WSADATA wsaData;
    WSAStartup(MAKEWORD(2, 2), &wsaData);

    int server_socket = socket(AF_INET, SOCK_STREAM, 0);

    struct sockaddr_in server_address;
    server_address.sin_family = AF_INET;
    server_address.sin_port = htons(12345);
    server_address.sin_addr.s_addr = INADDR_ANY;
    char * opt = "\1";
    setsockopt(server_socket, SOL_SOCKET, SO_REUSEADDR, opt, sizeof(opt));

    bind(server_socket, (struct sockaddr *)&server_address, sizeof(server_address));
    listen(server_socket, 5);

    printf("TCP C server (windows): waiting for connections\n");

    char buffer[1024];
    int client_socket = accept(server_socket, NULL, NULL);
    int received_bytes = recv(client_socket, buffer, sizeof(buffer), 0);
    buffer[received_bytes] = 0;
    
    printf("%s", buffer);
    closesocket(server_socket);

    WSACleanup();
    return 0;
}
