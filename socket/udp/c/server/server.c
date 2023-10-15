#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <unistd.h>
#include <arpa/inet.h>

int main() {
    int server_socket = socket(AF_INET, SOCK_DGRAM, 0);

    struct sockaddr_in server_address;
    server_address.sin_family = AF_INET;
    server_address.sin_port = htons(12345);
    server_address.sin_addr.s_addr = INADDR_ANY;

    bind(server_socket, (struct sockaddr *)&server_address, sizeof(server_address));

    printf("UCP C server: waiting for packets\n");

    char buffer[1024];
    ssize_t received_bytes = recv(server_socket, buffer, sizeof(buffer),0);
    buffer[received_bytes] = 0;
    printf("%s\n", buffer);
    close(server_socket);

    return 0;
}
