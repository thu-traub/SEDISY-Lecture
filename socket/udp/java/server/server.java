import java.net.*;

public class server {
    public static void main(String[] args) throws Exception {
        DatagramSocket socket = null;
        socket = new DatagramSocket(12345);

        byte[] data = new byte[1024];

        System.out.println("UDP Java server: waiting for packets");

        DatagramPacket packet = new DatagramPacket(data, data.length);
        socket.receive(packet);
        
        String message = new String(packet.getData(), 0, packet.getLength(), "UTF-8");
        System.out.println(message);
        socket.close();
    }
}
