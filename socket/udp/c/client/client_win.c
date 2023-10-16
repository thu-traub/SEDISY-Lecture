#include <stdio.h>
#include <winsock2.h>

#pragma comment(lib, "ws2_32.lib")

int main() {
    WSADATA wsaData;
    WSAStartup(MAKEWORD(2, 2), &wsaData);
    int client_socket = socket(AF_INET, SOCK_DGRAM, 0);

    struct sockaddr_in server_address;
    server_address.sin_family = AF_INET;
    server_address.sin_port = htons(12345);
    server_address.sin_addr.s_addr = inet_addr("127.0.0.1");

    char message[] = "Hello from UDP C client (windows)\n";
    sendto(client_socket, message, strlen(message), 0, (struct sockaddr *)&server_address, sizeof(server_address));
    close(client_socket);

    WSACleanup();
    return 0;
}
