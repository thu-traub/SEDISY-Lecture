import java.net.*;

public class client {
    public static void main(String[] args) throws Exception {
        DatagramSocket socket = null;
        socket = new DatagramSocket();

        String m = "Hello from UDP Java client";
        byte[] data = m.getBytes();
        InetAddress addr = InetAddress.getByName("127.0.0.1");
        DatagramPacket packet = new DatagramPacket(data, data.length, addr, 12345);
        socket.send(packet);
        
        socket.close();
    }
    
}
