#include <stdio.h>
#include <winsock2.h>

#pragma comment(lib, "ws2_32.lib")

int main() {
    WSADATA wsaData;
    WSAStartup(MAKEWORD(2, 2), &wsaData);

    int server_socket = socket(AF_INET, SOCK_DGRAM, 0);

    struct sockaddr_in server_address;
    server_address.sin_family = AF_INET;
    server_address.sin_port = htons(12345);
    server_address.sin_addr.s_addr = INADDR_ANY;

    bind(server_socket, (struct sockaddr *)&server_address, sizeof(server_address));

    printf("UCP C server (windows): waiting for packets\n");

    char buffer[1024];
    int received_bytes = recv(server_socket, buffer, sizeof(buffer),0);
    buffer[received_bytes] = 0;
    printf("%s\n", buffer);
    close(server_socket);

    WSACleanup();
    return 0;
}
