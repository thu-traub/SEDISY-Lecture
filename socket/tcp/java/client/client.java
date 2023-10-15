import java.io.PrintWriter;
import java.net.Socket;

public class client {
    public static void main(String[] args) throws Exception {
        Socket socket = new Socket("127.0.0.1", 12345);

        PrintWriter out = new PrintWriter(socket.getOutputStream(), true);

        String message = "Hello from TCP Java client";
        out.println(message);

        socket.close();
    }    
}
