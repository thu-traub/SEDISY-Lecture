using System.Collections;
using System.Net;
using System.Net.Sockets;

internal class Program
{
    private static void Main(string[] args)
    {
        Socket s = new(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        IPAddress adr =  IPAddress.Any;
        IPEndPoint p = new(adr, 12345);
        s.Bind(p);
        s.Listen();
        Socket cl = s.Accept();

        StreamReader rd = new StreamReader(new NetworkStream(cl));
        string? data = rd.ReadLine();
        System.Console.WriteLine(data);
        
        s.Close();
    }
}