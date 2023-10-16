#include <stdio.h>
#include <winsock2.h>

#pragma comment(lib, "ws2_32.lib")

int main() {
    WSADATA wsaData;
    WSAStartup(MAKEWORD(2, 2), &wsaData);

    int client_socket = socket(AF_INET, SOCK_STREAM, 0);

    struct sockaddr_in server_address;
    server_address.sin_family = AF_INET;
    server_address.sin_port = htons(12345);
    server_address.sin_addr.s_addr = inet_addr("127.0.0.1");

    connect(client_socket, (struct sockaddr *)&server_address, sizeof(server_address));

    char message[] = "Hello from TCP C client (windows)\n";
    send(client_socket, message, strlen(message), 0);
    close(client_socket);

    WSACleanup();
    return 0;
}
