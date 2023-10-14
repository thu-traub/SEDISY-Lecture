using System.Net;
using System.Net.Sockets;
using System.Text;

Socket s = new(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

IPAddress adr =  IPAddress.Parse("127.0.0.1");
IPEndPoint p = new(adr, 12345);

string m = "Hello from UDP C# client";
byte[] data = Encoding.UTF8.GetBytes(m);
s.SendTo(data, p);
