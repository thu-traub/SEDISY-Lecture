import java.io.*;
import java.net.*;

public class server {
    public static void main(String[] args) throws Exception {
        ServerSocket serverSocket = new ServerSocket(12345);
        System.out.println("TCP Java server: waiting for connections");

        Socket clientSocket = serverSocket.accept();

        BufferedReader in = new BufferedReader(new InputStreamReader(clientSocket.getInputStream()));

        String data = in.readLine();
        System.out.println(data);

        clientSocket.close();
        serverSocket.close();
        }
}
