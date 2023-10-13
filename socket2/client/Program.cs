using System.Net;
using System.Net.Sockets;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Socket s = new(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

        IPAddress adr =  IPAddress.Parse("127.0.0.1");
        IPEndPoint p = new(adr, 12345);

        string m = "hello from UDP";
        byte[] data = Encoding.ASCII.GetBytes(m);
        s.SendTo(data, p);
    }
}