using System.Net;
using System.Net.Sockets;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Socket s = new(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        IPAddress adr =  IPAddress.Any;
        IPEndPoint p = new(adr, 12345);
        s.Bind(p);

        byte[]data = new byte[200];
        int n = s.Receive(data);
        String l = Encoding.ASCII.GetString(data, 0, n);
        System.Console.WriteLine(l);
    }
}