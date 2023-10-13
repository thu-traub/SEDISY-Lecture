using System.Net;
using System.Net.Sockets;

internal class Program
{
    private static void Main(string[] args)
    {
        Socket s = new(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        s.Connect("127.0.0.1", 12345);
        StreamWriter wr = new StreamWriter(new NetworkStream(s));
        wr.WriteLine("hello from client");
        wr.Flush();
        s.Close();
    }
}